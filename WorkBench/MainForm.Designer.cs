using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WorkBench
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.main_table_panel = new System.Windows.Forms.TableLayoutPanel();
            this.tab_panel = new System.Windows.Forms.TabControl();
            this.memo_panel = new System.Windows.Forms.TableLayoutPanel();
            this.text_color = new System.Windows.Forms.Button();
            this.memo_title = new System.Windows.Forms.Label();
            this.memo_box = new System.Windows.Forms.RichTextBox();
            this.memo_save_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.head0 = new System.Windows.Forms.Label();
            this.head1 = new System.Windows.Forms.Label();
            this.head2 = new System.Windows.Forms.Label();
            this.head3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.main_table_panel.SuspendLayout();
            this.memo_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_table_panel
            // 
            this.main_table_panel.ColumnCount = 2;
            this.main_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.main_table_panel.Controls.Add(this.tab_panel, 0, 0);
            this.main_table_panel.Controls.Add(this.memo_panel, 1, 0);
            this.main_table_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_table_panel.Location = new System.Drawing.Point(0, 0);
            this.main_table_panel.Margin = new System.Windows.Forms.Padding(0);
            this.main_table_panel.Name = "main_table_panel";
            this.main_table_panel.RowCount = 1;
            this.main_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_table_panel.Size = new System.Drawing.Size(1867, 991);
            this.main_table_panel.TabIndex = 0;
            // 
            // tab_panel
            // 
            this.tab_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_panel.Location = new System.Drawing.Point(2, 2);
            this.tab_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_panel.Name = "tab_panel";
            this.tab_panel.SelectedIndex = 0;
            this.tab_panel.Size = new System.Drawing.Size(1597, 987);
            this.tab_panel.TabIndex = 0;
            // 
            // memo_panel
            // 
            this.memo_panel.ColumnCount = 3;
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.Controls.Add(this.text_color, 1, 0);
            this.memo_panel.Controls.Add(this.memo_title, 0, 0);
            this.memo_panel.Controls.Add(this.memo_box, 0, 1);
            this.memo_panel.Controls.Add(this.memo_save_btn, 2, 0);
            this.memo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memo_panel.Location = new System.Drawing.Point(1601, 0);
            this.memo_panel.Margin = new System.Windows.Forms.Padding(0);
            this.memo_panel.Name = "memo_panel";
            this.memo_panel.RowCount = 2;
            this.memo_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memo_panel.Size = new System.Drawing.Size(266, 991);
            this.memo_panel.TabIndex = 1;
            // 
            // text_color
            // 
            this.text_color.BackgroundImage = global::WorkBench.Properties.Resources.font_color;
            this.text_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.text_color.Dock = System.Windows.Forms.DockStyle.Left;
            this.text_color.FlatAppearance.BorderSize = 0;
            this.text_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text_color.Location = new System.Drawing.Point(205, 2);
            this.text_color.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_color.Name = "text_color";
            this.text_color.Size = new System.Drawing.Size(26, 29);
            this.text_color.TabIndex = 3;
            this.text_color.UseVisualStyleBackColor = true;
            this.text_color.Click += new System.EventHandler(this.text_color_Click);
            // 
            // memo_title
            // 
            this.memo_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memo_title.AutoSize = true;
            this.memo_title.Location = new System.Drawing.Point(4, 7);
            this.memo_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memo_title.Name = "memo_title";
            this.memo_title.Size = new System.Drawing.Size(98, 18);
            this.memo_title.TabIndex = 0;
            this.memo_title.Text = "Memorandum";
            // 
            // memo_box
            // 
            this.memo_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memo_panel.SetColumnSpan(this.memo_box, 3);
            this.memo_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memo_box.Font = new System.Drawing.Font("宋体", 11F);
            this.memo_box.Location = new System.Drawing.Point(2, 35);
            this.memo_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memo_box.Name = "memo_box";
            this.memo_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.memo_box.Size = new System.Drawing.Size(262, 954);
            this.memo_box.TabIndex = 1;
            this.memo_box.Text = "";
            // 
            // memo_save_btn
            // 
            this.memo_save_btn.BackgroundImage = global::WorkBench.Properties.Resources.save_en;
            this.memo_save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memo_save_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memo_save_btn.FlatAppearance.BorderSize = 0;
            this.memo_save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memo_save_btn.Location = new System.Drawing.Point(235, 2);
            this.memo_save_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memo_save_btn.Name = "memo_save_btn";
            this.memo_save_btn.Size = new System.Drawing.Size(29, 29);
            this.memo_save_btn.TabIndex = 2;
            this.memo_save_btn.UseVisualStyleBackColor = true;
            this.memo_save_btn.Click += new System.EventHandler(this.memo_save_btn_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(546, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Open project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Location = new System.Drawing.Point(186, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 40);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 40);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // head0
            // 
            this.head0.AutoSize = true;
            this.head0.BackColor = System.Drawing.Color.Gainsboro;
            this.head0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.head0.Location = new System.Drawing.Point(3, 2);
            this.head0.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.head0.Name = "head0";
            this.head0.Size = new System.Drawing.Size(177, 20);
            this.head0.TabIndex = 0;
            this.head0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // head1
            // 
            this.head1.AutoSize = true;
            this.head1.BackColor = System.Drawing.Color.Gainsboro;
            this.head1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.head1.Location = new System.Drawing.Point(184, 2);
            this.head1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(177, 20);
            this.head1.TabIndex = 1;
            this.head1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // head2
            // 
            this.head2.AutoSize = true;
            this.head2.BackColor = System.Drawing.Color.Gainsboro;
            this.head2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.head2.Location = new System.Drawing.Point(365, 2);
            this.head2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.head2.Name = "head2";
            this.head2.Size = new System.Drawing.Size(177, 20);
            this.head2.TabIndex = 2;
            this.head2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // head3
            // 
            this.head3.AutoSize = true;
            this.head3.BackColor = System.Drawing.Color.Gainsboro;
            this.head3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.head3.Location = new System.Drawing.Point(546, 2);
            this.head3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.head3.Name = "head3";
            this.head3.Size = new System.Drawing.Size(180, 20);
            this.head3.TabIndex = 3;
            this.head3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel2.Location = new System.Drawing.Point(367, 24);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(173, 40);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 991);
            this.Controls.Add(this.main_table_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkBench";
            this.main_table_panel.ResumeLayout(false);
            this.memo_panel.ResumeLayout(false);
            this.memo_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel main_table_panel;
        private TableLayoutPanel memo_panel;
        private Label memo_title;
        private RichTextBox memo_box;
        private TabControl tab_panel;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label head0;
        private Label head1;
        private Label head2;
        private Label head3;
        private LinkLabel linkLabel2;
        private Button memo_save_btn;
        private Button text_color;
    }
}

