using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using xmlExplain;

namespace WorkBench
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, TabPage> _pages = new Dictionary<string, TabPage>();

        private StreamWriter _memoWriter;

        private ColorDialog _colorDialog;

        public static string CurrentPath;

        public MainForm()
        {
            InitializeComponent();

            CurrentPath = Application.StartupPath;
            LoadConfig();
            Shown += MainForm_Shown;
            Closing += MainForm_Closing;
            memo_box.TextChanged += Memo_box_TextChanged;
            //memo_box.KeyDown += Memo_box_KeyDown;
            this.OpenDoubleBuffer();
            //KeyDown += MainForm_KeyDown;
            //tab_panel.KeyDown += MainForm_KeyDown;
        }

        /*private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                tab_panel.Controls.Clear();
                _memoWriter.Close();
                LoadConfig();
                MainForm_Shown(null, null);
            }
        }*/

        /*private void Memo_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                memo_save_btn_Click(null, null);
            }
        }*/

        private void Memo_box_TextChanged(object sender, EventArgs e)
        {
            if (memo_save_btn.Enabled) return;
            memo_save_btn.Enabled = true;
            memo_save_btn.BackgroundImage = Properties.Resources.save_en;
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _memoWriter.Close();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            string memoFile = Path.Combine(CurrentPath, "memo.txt");
            FileStream stream = new FileStream(memoFile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            _memoWriter = new StreamWriter(stream, Encoding.ASCII);
            this.BringWindowToFront();
        }

        private void LoadConfig()
        {
            string configFile = Path.Combine(CurrentPath, "config.xml");
            Node pages;
            try
            {
                XmlReader reader = new XmlReader(configFile);
                pages = reader.Root.Child("pages");
                int memoWidth = reader.Root.Attribute("memo_size") != null
                    ? int.Parse(reader.Root.Attribute("memo_size").Value)
                    : 250;
                main_table_panel.ColumnStyles[1].Width = memoWidth;
            }
            catch (XmlException)
            {
                return;
            }
            catch (FileNotFoundException)
            {
                return;
            }

            foreach (var page in pages.Children)
            {
                Page pg = new Page();
                pg.LoadConfigNode(page);
                tab_panel.Controls.Add(pg);
            }

            string memoFile = Path.Combine(Application.StartupPath, "memo.txt");
            if (File.Exists(memoFile))
            {
                memo_box.Rtf = File.ReadAllText(memoFile, Encoding.ASCII);
            }

            memo_save_btn.BackgroundImage = Properties.Resources.save_gray;
            memo_save_btn.Enabled = false;
        }

        private void memo_save_btn_Click(object sender, EventArgs e)
        {
            if (!memo_box.Rtf.StartsWith("{"))
            {
                MessageBox.Show(@"Save failed! Please retry.", @"Error", MessageBoxButtons.OK);
                return;
            }

            _memoWriter.BaseStream.SetLength(0);
            _memoWriter.Write(memo_box.Rtf);
            _memoWriter.Flush();
            memo_save_btn.BackgroundImage = Properties.Resources.save_gray;
            memo_save_btn.Enabled = false;
        }

        private void text_color_Click(object sender, EventArgs e)
        {
            if (_colorDialog == null)
                _colorDialog = new ColorDialog();
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = _colorDialog.Color;
                memo_box.SelectionColor = color;
            }
        }

        private void strike_btn_Click(object sender, EventArgs e)
        {
            memo_box.SelectionFont = !memo_box.SelectionFont.Strikeout
                ? new Font(memo_box.SelectionFont, memo_box.SelectionFont.Style | FontStyle.Strikeout)
                : new Font(memo_box.SelectionFont, memo_box.SelectionFont.Style & ~FontStyle.Strikeout);
        }

        private void underline_btn_Click(object sender, EventArgs e)
        {
            memo_box.SelectionFont = !memo_box.SelectionFont.Underline
                ? new Font(memo_box.SelectionFont, memo_box.SelectionFont.Style | FontStyle.Underline)
                : new Font(memo_box.SelectionFont, memo_box.SelectionFont.Style & ~FontStyle.Underline);
        }

        private void italic_btn_Click(object sender, EventArgs e)
        {
            memo_box.SelectionFont = !memo_box.SelectionFont.Italic
                ? new Font(memo_box.SelectionFont, memo_box.SelectionFont.Style | FontStyle.Italic)
                : new Font(memo_box.SelectionFont, memo_box.SelectionFont.Style & ~FontStyle.Italic);
        }

        private void bold_btn_Click(object sender, EventArgs e)
        {
            memo_box.SelectionFont = !memo_box.SelectionFont.Bold
                ? new Font(memo_box.SelectionFont, memo_box.SelectionFont.Style | FontStyle.Bold)
                : new Font(memo_box.SelectionFont, memo_box.SelectionFont.Style & ~FontStyle.Bold);
        }

        private void refresh_menu_Click(object sender, EventArgs e)
        {
            tab_panel.Controls.Clear();
            _memoWriter.Close();
            LoadConfig();
            MainForm_Shown(null, null);
        }

        private void exit_menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void config_file_menu_Click(object sender, EventArgs e)
        {
            string configPath = Path.Combine(CurrentPath, "config.xml");
            if (!File.Exists(configPath))
            {
                Node root = new Node("auto");
                root.AddChild("pages");
                root.AddAttribute("memo_size", "350");
                XmlWriter writer = new XmlWriter(configPath);
                writer.Write(root);
            }

            Process.Start(configPath);
        }

        private void save_memo_menu_Click(object sender, EventArgs e)
        {
            memo_save_btn_Click(null, null);
        }

        private void memo_location_left_menu_Click(object sender, EventArgs e)
        {
            if (memo_location_left_menu.Checked)
                return;
            Swap();
        }

        private void memo_location_right_menu_Click(object sender, EventArgs e)
        {
            if (memo_location_right_menu.Checked)
                return;
            Swap();
        }

        private void Swap()
        {
            ColumnStyle left = main_table_panel.ColumnStyles[0];
            ColumnStyle right = main_table_panel.ColumnStyles[1];
            float width = left.SizeType == SizeType.Absolute ? left.Width : right.Width;
            left.SizeType = left.SizeType == SizeType.Absolute ? SizeType.Percent : SizeType.Absolute;
            right.SizeType = right.SizeType == SizeType.Absolute ? SizeType.Percent : SizeType.Absolute;
            left.Width = left.SizeType == SizeType.Absolute ? width : 100;
            right.Width = right.SizeType == SizeType.Absolute ? width : 100;

            main_table_panel.SetColumn(memo_panel, left.SizeType == SizeType.Absolute ? 0 : 1);
            main_table_panel.SetColumn(tab_panel, left.SizeType == SizeType.Absolute ? 1 : 0);

            memo_location_left_menu.Checked = left.SizeType == SizeType.Absolute;
            memo_location_right_menu.Checked = left.SizeType == SizeType.Percent;
        }
    }
}