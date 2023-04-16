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
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.head0 = new System.Windows.Forms.Label();
            this.head1 = new System.Windows.Forms.Label();
            this.head2 = new System.Windows.Forms.Label();
            this.head3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.main_table_panel = new WorkBench.TablePanel();
            this.tab_panel = new System.Windows.Forms.TabControl();
            this.memo_panel = new System.Windows.Forms.TableLayoutPanel();
            this.underline_btn = new System.Windows.Forms.Button();
            this.strike_btn = new System.Windows.Forms.Button();
            this.italic_btn = new System.Windows.Forms.Button();
            this.text_color = new System.Windows.Forms.Button();
            this.bold_btn = new System.Windows.Forms.Button();
            this.memo_title = new System.Windows.Forms.Label();
            this.memo_box = new System.Windows.Forms.RichTextBox();
            this.memo_save_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config_file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.save_memo_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_location_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.memo_location_left_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.memo_location_right_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_help_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.about_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.main_table_panel.SuspendLayout();
            this.memo_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // main_table_panel
            // 
            this.main_table_panel.ColumnCount = 2;
            this.main_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356F));
            this.main_table_panel.Controls.Add(this.tab_panel, 0, 1);
            this.main_table_panel.Controls.Add(this.memo_panel, 1, 1);
            this.main_table_panel.Controls.Add(this.menuStrip1, 0, 0);
            this.main_table_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_table_panel.HeaderVisible = false;
            this.main_table_panel.Location = new System.Drawing.Point(0, 0);
            this.main_table_panel.Margin = new System.Windows.Forms.Padding(0);
            this.main_table_panel.Name = "main_table_panel";
            this.main_table_panel.RowCount = 2;
            this.main_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.main_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_table_panel.Size = new System.Drawing.Size(1868, 992);
            this.main_table_panel.TabIndex = 0;
            // 
            // tab_panel
            // 
            this.tab_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_panel.Location = new System.Drawing.Point(2, 38);
            this.tab_panel.Margin = new System.Windows.Forms.Padding(2, 2, 3, 2);
            this.tab_panel.Name = "tab_panel";
            this.tab_panel.SelectedIndex = 0;
            this.tab_panel.Size = new System.Drawing.Size(1507, 952);
            this.tab_panel.TabIndex = 0;
            // 
            // memo_panel
            // 
            this.memo_panel.BackColor = System.Drawing.Color.White;
            this.memo_panel.ColumnCount = 8;
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.memo_panel.Controls.Add(this.underline_btn, 4, 1);
            this.memo_panel.Controls.Add(this.strike_btn, 5, 1);
            this.memo_panel.Controls.Add(this.italic_btn, 3, 1);
            this.memo_panel.Controls.Add(this.text_color, 6, 1);
            this.memo_panel.Controls.Add(this.bold_btn, 2, 1);
            this.memo_panel.Controls.Add(this.memo_title, 0, 0);
            this.memo_panel.Controls.Add(this.memo_box, 0, 2);
            this.memo_panel.Controls.Add(this.memo_save_btn, 7, 1);
            this.memo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memo_panel.Location = new System.Drawing.Point(1515, 36);
            this.memo_panel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.memo_panel.Name = "memo_panel";
            this.memo_panel.RowCount = 3;
            this.memo_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.memo_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memo_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.memo_panel.Size = new System.Drawing.Size(350, 956);
            this.memo_panel.TabIndex = 1;
            // 
            // underline_btn
            // 
            this.underline_btn.BackgroundImage = global::WorkBench.Properties.Resources.underline;
            this.underline_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.underline_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.underline_btn.FlatAppearance.BorderSize = 0;
            this.underline_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underline_btn.Location = new System.Drawing.Point(220, 35);
            this.underline_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.underline_btn.Name = "underline_btn";
            this.underline_btn.Size = new System.Drawing.Size(29, 29);
            this.underline_btn.TabIndex = 7;
            this.underline_btn.UseVisualStyleBackColor = true;
            this.underline_btn.Click += new System.EventHandler(this.underline_btn_Click);
            // 
            // strike_btn
            // 
            this.strike_btn.BackgroundImage = global::WorkBench.Properties.Resources.font_strike1;
            this.strike_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.strike_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strike_btn.FlatAppearance.BorderSize = 0;
            this.strike_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strike_btn.Location = new System.Drawing.Point(253, 35);
            this.strike_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.strike_btn.Name = "strike_btn";
            this.strike_btn.Size = new System.Drawing.Size(29, 29);
            this.strike_btn.TabIndex = 6;
            this.strike_btn.UseVisualStyleBackColor = true;
            this.strike_btn.Click += new System.EventHandler(this.strike_btn_Click);
            // 
            // italic_btn
            // 
            this.italic_btn.BackgroundImage = global::WorkBench.Properties.Resources.italic;
            this.italic_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.italic_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.italic_btn.FlatAppearance.BorderSize = 0;
            this.italic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.italic_btn.Location = new System.Drawing.Point(187, 35);
            this.italic_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.italic_btn.Name = "italic_btn";
            this.italic_btn.Size = new System.Drawing.Size(29, 29);
            this.italic_btn.TabIndex = 5;
            this.italic_btn.UseVisualStyleBackColor = true;
            this.italic_btn.Click += new System.EventHandler(this.italic_btn_Click);
            // 
            // text_color
            // 
            this.text_color.BackgroundImage = global::WorkBench.Properties.Resources.font_color;
            this.text_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.text_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_color.FlatAppearance.BorderSize = 0;
            this.text_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text_color.Location = new System.Drawing.Point(286, 35);
            this.text_color.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_color.Name = "text_color";
            this.text_color.Size = new System.Drawing.Size(29, 29);
            this.text_color.TabIndex = 4;
            this.text_color.UseVisualStyleBackColor = true;
            this.text_color.Click += new System.EventHandler(this.text_color_Click);
            // 
            // bold_btn
            // 
            this.bold_btn.BackgroundImage = global::WorkBench.Properties.Resources.bold;
            this.bold_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bold_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bold_btn.FlatAppearance.BorderSize = 0;
            this.bold_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bold_btn.Location = new System.Drawing.Point(154, 35);
            this.bold_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bold_btn.Name = "bold_btn";
            this.bold_btn.Size = new System.Drawing.Size(29, 29);
            this.bold_btn.TabIndex = 3;
            this.bold_btn.UseVisualStyleBackColor = true;
            this.bold_btn.Click += new System.EventHandler(this.bold_btn_Click);
            // 
            // memo_title
            // 
            this.memo_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memo_title.AutoSize = true;
            this.memo_panel.SetColumnSpan(this.memo_title, 8);
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
            this.memo_panel.SetColumnSpan(this.memo_box, 8);
            this.memo_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memo_box.Font = new System.Drawing.Font("宋体", 11F);
            this.memo_box.Location = new System.Drawing.Point(2, 68);
            this.memo_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memo_box.Name = "memo_box";
            this.memo_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.memo_box.Size = new System.Drawing.Size(346, 886);
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
            this.memo_save_btn.Location = new System.Drawing.Point(319, 35);
            this.memo_save_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memo_save_btn.Name = "memo_save_btn";
            this.memo_save_btn.Size = new System.Drawing.Size(29, 29);
            this.memo_save_btn.TabIndex = 2;
            this.memo_save_btn.UseVisualStyleBackColor = true;
            this.memo_save_btn.Click += new System.EventHandler(this.memo_save_btn_Click);
            // 
            // menuStrip1
            // 
            this.main_table_panel.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1868, 34);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.config_file_menu,
            this.exit_menu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(68, 28);
            this.fileToolStripMenuItem.Text = "(&F)ile";
            // 
            // config_file_menu
            // 
            this.config_file_menu.Name = "config_file_menu";
            this.config_file_menu.Size = new System.Drawing.Size(210, 34);
            this.config_file_menu.Text = "Config file";
            this.config_file_menu.Click += new System.EventHandler(this.config_file_menu_Click);
            // 
            // exit_menu
            // 
            this.exit_menu.Name = "exit_menu";
            this.exit_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit_menu.Size = new System.Drawing.Size(210, 34);
            this.exit_menu.Text = "Exit";
            this.exit_menu.Click += new System.EventHandler(this.exit_menu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save_memo_menu});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 28);
            this.toolStripMenuItem1.Text = "(&Edit)";
            // 
            // save_memo_menu
            // 
            this.save_memo_menu.Name = "save_memo_menu";
            this.save_memo_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save_memo_menu.Size = new System.Drawing.Size(273, 34);
            this.save_memo_menu.Text = "Save memo";
            this.save_memo_menu.Click += new System.EventHandler(this.save_memo_menu_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refresh_menu,
            this.menu_location_menu});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.viewToolStripMenuItem.Text = "(&V)iew";
            // 
            // refresh_menu
            // 
            this.refresh_menu.Name = "refresh_menu";
            this.refresh_menu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refresh_menu.Size = new System.Drawing.Size(240, 34);
            this.refresh_menu.Text = "Refresh";
            this.refresh_menu.Click += new System.EventHandler(this.refresh_menu_Click);
            // 
            // menu_location_menu
            // 
            this.menu_location_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memo_location_left_menu,
            this.memo_location_right_menu});
            this.menu_location_menu.Name = "menu_location_menu";
            this.menu_location_menu.Size = new System.Drawing.Size(240, 34);
            this.menu_location_menu.Text = "Memo location";
            // 
            // memo_location_left_menu
            // 
            this.memo_location_left_menu.Name = "memo_location_left_menu";
            this.memo_location_left_menu.Size = new System.Drawing.Size(157, 34);
            this.memo_location_left_menu.Text = "Left";
            this.memo_location_left_menu.Click += new System.EventHandler(this.memo_location_left_menu_Click);
            // 
            // memo_location_right_menu
            // 
            this.memo_location_right_menu.Checked = true;
            this.memo_location_right_menu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.memo_location_right_menu.Name = "memo_location_right_menu";
            this.memo_location_right_menu.Size = new System.Drawing.Size(157, 34);
            this.memo_location_right_menu.Text = "Right";
            this.memo_location_right_menu.Click += new System.EventHandler(this.memo_location_right_menu_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_help_menu,
            this.about_menu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.helpToolStripMenuItem.Text = "(&H)elp";
            // 
            // view_help_menu
            // 
            this.view_help_menu.Name = "view_help_menu";
            this.view_help_menu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.view_help_menu.Size = new System.Drawing.Size(225, 34);
            this.view_help_menu.Text = "View help";
            // 
            // about_menu
            // 
            this.about_menu.Name = "about_menu";
            this.about_menu.Size = new System.Drawing.Size(225, 34);
            this.about_menu.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 992);
            this.Controls.Add(this.main_table_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkBench";
            this.main_table_panel.ResumeLayout(false);
            this.main_table_panel.PerformLayout();
            this.memo_panel.ResumeLayout(false);
            this.memo_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TablePanel main_table_panel;
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
        private Button bold_btn;
        private Button underline_btn;
        private Button strike_btn;
        private Button italic_btn;
        private Button text_color;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem refresh_menu;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem config_file_menu;
        private ToolStripMenuItem exit_menu;
        private ToolStripMenuItem view_help_menu;
        private ToolStripMenuItem about_menu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem save_memo_menu;
        private ToolStripMenuItem menu_location_menu;
        private ToolStripMenuItem memo_location_left_menu;
        private ToolStripMenuItem memo_location_right_menu;
    }
}

