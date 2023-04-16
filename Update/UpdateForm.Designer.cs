namespace Update
{
    partial class UpdateForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.progress_bar = new Update.ProgressBar();
            this.state_lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(12, 45);
            this.progress_bar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progress_bar.MaxValue = 100;
            this.progress_bar.MinValue = 0;
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(467, 27);
            this.progress_bar.TabIndex = 0;
            this.progress_bar.Value = 0;
            // 
            // state_lab
            // 
            this.state_lab.AutoSize = true;
            this.state_lab.Location = new System.Drawing.Point(13, 22);
            this.state_lab.Name = "state_lab";
            this.state_lab.Size = new System.Drawing.Size(41, 12);
            this.state_lab.TabIndex = 1;
            this.state_lab.Text = "update";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 88);
            this.ControlBox = false;
            this.Controls.Add(this.state_lab);
            this.Controls.Add(this.progress_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progress_bar;
        private System.Windows.Forms.Label state_lab;
    }
}

