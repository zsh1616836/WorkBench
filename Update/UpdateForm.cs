using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using xmlExplain;

namespace Update
{
    public partial class UpdateForm : Form
    {
        private readonly int _type;
        private readonly string _url = "";
        private readonly string _path = "";
        private readonly bool _success;

        public static string CurrentPath = Application.StartupPath;

        public static string UpdateName = Process.GetCurrentProcess().ProcessName + ".exe";

        public static string AppName = "WorkBench.exe";

        public UpdateForm()
        {
            InitializeComponent();
            Shown += UpdateForm_Shown;
            string updateCfg = Path.Combine(CurrentPath, "update.cfg");
            if (File.Exists(updateCfg))
            {
                try
                {
                    XmlReader reader = new XmlReader(updateCfg);
                    _type = int.Parse(reader.Root.Attribute("type").Value);
                    _url = reader.Root.Attribute("url").Value;
                    _path = reader.Root.Attribute("path").Value;
                    _success = true;
                }
                catch (Exception)
                {
                    //ignore
                }
            }
        }

        internal int Progress
        {
            set
            {
                if (progress_bar.InvokeRequired)
                {
                    progress_bar.Invoke(new Action(delegate { progress_bar.Value = value; }));
                }
                else
                {
                    progress_bar.Value = value;
                }
            }
        }

        internal string State
        {
            set
            {
                if (state_lab.InvokeRequired)
                {
                    state_lab.Invoke(new Action(delegate { state_lab.Text = value; }));
                }
                else
                {
                    state_lab.Text = value;
                }
            }
        }

        private void UpdateSelf(IUpdate update)
        {
            State = "Checking update for self...";

            if (update.UpdateSelf())
            {
                Progress = 100;
                State = "Update self success, restarting...";
                Thread.Sleep(500);
                Process.Start(UpdateName);
                Environment.Exit(0);
            }
        }

        private void StartWorkBeach()
        {
            Process.Start(UpdateForm.AppName);
        }

        private void Checkout()
        {
            if (_success)
            {
                IUpdate update = null;
                if (_type == 0)
                    update = new HttpUpdate(this, _url);
                if (_type == 1)
                    update = new LocalUpdate(this, _path);

                if (update != null)
                {
                    UpdateSelf(update);

                    if (update.CheckUpdate())
                    {
                        update.Update();
                    }
                }
            }

            StartWorkBeach();
            Environment.Exit(0);
        }

        private void UpdateForm_Shown(object sender, EventArgs e)
        {
            string bak = Path.Combine(CurrentPath, UpdateName + ".bak");
            if (File.Exists(bak))
            {
                File.Delete(bak);
            }

            new Thread(Checkout).Start();
        }
    }
}