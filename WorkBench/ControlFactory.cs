using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using xmlExplain;

namespace WorkBench
{
    internal class ControlFactory
    {
        public static Control LoadControl(Node node)
        {
            Control control = null;
            switch (node.Name)
            {
                case "table":
                    control = LoadTable(node);
                    break;
                case "start":
                    control = LoadStart(node);
                    break;
                case "link":
                    control = LoadLink(node);
                    break;
                case "label":
                    control = LoadLabel(node);
                    break;
                case "place_holder":
                    control = new Label();
                    break;
            }

            control.OpenDoubleBuffer();
            return control;
        }

        public static Panel LoadTable(Node table)
        {
            TablePanel tp = new TablePanel();
            tp.OpenDoubleBuffer();
            if (table.Attribute("dock") != null && table.Attribute("dock").Value == "fill")
            {
                tp.Dock = DockStyle.Fill;
            }
            else
            {
                tp.Dock = DockStyle.Top;
                tp.AutoSize = true;
                tp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            }

            tp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            if (table.Attribute("broad") != null && table.Attribute("broad").Value == "0")
            {
                tp.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            }

            tp.Margin = new Padding(0);
            tp.Name = "page_panel";
            tp.SuspendLayout();
            tp.HeaderVisible = table.Attribute("head") != null && table.Attribute("head").Value == "1";
            LoadColumns(table.Child("cols"), tp);
            LoadRows(table.Child("rows"), tp);
            tp.BorderStyle = BorderStyle.FixedSingle;

            tp.ResumeLayout();
            tp.PerformLayout();
            Panel panel = new Panel();
            panel.Controls.Add(tp);
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            panel.Margin = new Padding(0);
            return panel;
        }

        private static void LoadRows(Node rows, TablePanel tp)
        {
            int placeCount = 0;
            if (tp.HeaderVisible)
                placeCount = 1;
            tp.RowCount = rows.Children.Count;
            foreach (var t in rows.Children)
            {
                tp.RowStyles.Add(CreateSytle<RowStyle>(t));
            }

            for (int i = 0; i < rows.Children.Count; ++i)
            {
                for (int c = 0; c < rows.Children[i].Children.Count; ++c)
                {
                    Node ctlNode = rows.Children[i].Children[c];
                    Control ctl = LoadControl(ctlNode);
                    int row_span = 1;
                    int col_span = 1;
                    if (ctlNode.Attribute("row_span") != null)
                        int.TryParse(ctlNode.Attribute("row_span").Value, out row_span);
                    if (ctlNode.Attribute("col_span") != null)
                        int.TryParse(ctlNode.Attribute("col_span").Value, out col_span);
                    if (row_span > rows.Children.Count - i)
                        row_span = rows.Children.Count - i;
                    if (col_span > tp.ColumnCount - c)
                        col_span = tp.ColumnCount - c;
                    tp.SetRowSpan(ctl, row_span);
                    tp.SetColumnSpan(ctl, col_span);
                    tp.Controls.Add(ctl, c, placeCount + i);
                }
            }
        }

        private static void LoadColumns(Node cols, TablePanel tp)
        {
            int colCount = cols.Children.Count;
            //tp.BackColor = Color.Transparent;
            tp.ColumnCount = colCount;
            tp.ColumnStyles.Clear();
            tp.Controls.Clear();
            foreach (var col in cols.Children)
            {
                tp.ColumnStyles.Add(CreateSytle<ColumnStyle>(col));
                if (tp.HeaderVisible)
                {
                    Label headLabel = CreateHeaderLabel(col.Text);
                    tp.Controls.Add(headLabel);
                }
            }

            if (tp.HeaderVisible)
            {
                tp.RowCount = 1;
                tp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            }
            else
                tp.RowCount = 0;
        }

        private static T CreateSytle<T>(Node node)
        {
            SizeType type = SizeType.AutoSize;
            int size = 10;
            if (node.Attribute("size_type") != null)
            {
                string t = node.Attribute("size_type").Value;
                type = t == "1" ? SizeType.Absolute : t == "2" ? SizeType.Percent : SizeType.AutoSize;
            }

            if (node.Attribute("size") != null)
            {
                int.TryParse(node.Attribute("size").Value, out size);
            }

            return (T)Activator.CreateInstance(typeof(T), type, size);
        }

        private static Label CreateHeaderLabel(string text)
        {
            Label head = new Label();
            head.AutoSize = true;
            head.BackColor = Color.Gainsboro;
            head.Dock = DockStyle.Fill;
            head.Margin = new Padding(1, 0, 1, 0);
            head.TabIndex = 0;
            head.Text = text;
            head.TextAlign = ContentAlignment.MiddleCenter;

            return head;
        }

        public static Button LoadStart(Node action)
        {
            Button button = new Button();
            button.Dock = DockStyle.Fill;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = Color.Blue;
            button.Margin = new Padding(1);
            button.Text = action.Attribute("text") != null ? action.Attribute("text").Value : "xxx";
            button.UseVisualStyleBackColor = true;

            button.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            string app = action.Attribute("app").Value;
            string param = action.Attribute("command").Value;
            string workingDir = action.Attribute("working_dir") != null ? action.Attribute("working_dir").Value : "";
            button.Click += delegate
            {
                try
                {
                    if (workingDir == "")
                    {
                        Process.Start(app, param);
                    }
                    else
                    {
                        ProcessStartInfo info = new ProcessStartInfo
                        {
                            WorkingDirectory = workingDir,
                            FileName = app,
                            Arguments = param,
                            CreateNoWindow = true
                        };
                        info.UseShellExecute = false;
                        Process.Start(info);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), @"Error", MessageBoxButtons.OK);
                }
            };
            return button;
        }

        public static LinkLabel LoadLink(Node action)
        {
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.AutoSize = true;
            linkLabel.Dock = DockStyle.Fill;
            linkLabel.TabStop = true;
            linkLabel.Text = action.Attribute("text") != null ? action.Attribute("text").Value : "xxx";
            linkLabel.TextAlign = ContentAlignment.MiddleCenter;
            string url = action.Attribute("url") != null ? action.Attribute("url").Value : "";
            if (url.Length > 0)
            {
                linkLabel.LinkClicked += delegate { Process.Start(url); };
            }

            return linkLabel;
        }

        public static Label LoadLabel(Node label)
        {
            Label lab = new Label();
            lab.AutoSize = true;
            lab.Dock = DockStyle.Fill;
            lab.Text = label.Attribute("text") != null ? label.Attribute("text").Value : "xxx";
            lab.TextAlign = ContentAlignment.MiddleCenter;
            return lab;
        }
    }
}