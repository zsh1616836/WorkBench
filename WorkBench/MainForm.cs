﻿using System;
using System.Collections.Generic;
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

        public MainForm()
        {
            InitializeComponent();

            LoadConfig();
            Shown += MainForm_Shown;
            Closing += MainForm_Closing;
            memo_box.TextChanged += Memo_box_TextChanged;
            memo_box.KeyDown += Memo_box_KeyDown;
            this.OpenDoubleBuffer();
            KeyDown += MainForm_KeyDown;
            tab_panel.KeyDown += MainForm_KeyDown;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                tab_panel.Controls.Clear();
                _memoWriter.Close();
                LoadConfig();
                MainForm_Shown(null, null);
            }
        }

        private void Memo_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                memo_save_btn_Click(null, null);
            }
        }

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
            string memoFile = Path.Combine(Application.StartupPath, "memo.txt");
            FileStream stream = new FileStream(memoFile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            _memoWriter = new StreamWriter(stream, Encoding.UTF8);
        }

        private void LoadConfig()
        {
            string configFile = Path.Combine(Application.StartupPath, "config.xml");
            Node pages;
            try
            {
                XmlReader reader = new XmlReader(configFile);
                pages = reader.Root.Child("pages");
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
                memo_box.Rtf = File.ReadAllText(memoFile, Encoding.UTF8);
            }

            memo_save_btn.BackgroundImage = Properties.Resources.save_dis;
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
            memo_save_btn.BackgroundImage = Properties.Resources.save_dis;
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
    }
}