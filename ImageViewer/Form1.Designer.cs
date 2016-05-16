namespace ImageViewer
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.preBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.V_DefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.V_PlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.V_AutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.V_CenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pathlbe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 370);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // preBtn
            // 
            this.preBtn.Location = new System.Drawing.Point(12, 222);
            this.preBtn.Name = "preBtn";
            this.preBtn.Size = new System.Drawing.Size(75, 23);
            this.preBtn.TabIndex = 1;
            this.preBtn.Text = "上一张";
            this.preBtn.UseVisualStyleBackColor = true;
            this.preBtn.Click += new System.EventHandler(this.preBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(728, 222);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "下一张";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.ViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.OpenToolStripMenuItem.Text = "打开";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.V_DefaultToolStripMenuItem,
            this.V_PlanToolStripMenuItem,
            this.V_AutoToolStripMenuItem,
            this.V_CenterToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.ViewToolStripMenuItem.Text = "视图";
            // 
            // V_DefaultToolStripMenuItem
            // 
            this.V_DefaultToolStripMenuItem.Name = "V_DefaultToolStripMenuItem";
            this.V_DefaultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.V_DefaultToolStripMenuItem.Text = "默认";
            this.V_DefaultToolStripMenuItem.Click += new System.EventHandler(this.V_DefaultToolStripMenuItem_Click);
            // 
            // V_PlanToolStripMenuItem
            // 
            this.V_PlanToolStripMenuItem.Name = "V_PlanToolStripMenuItem";
            this.V_PlanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.V_PlanToolStripMenuItem.Text = "平铺";
            this.V_PlanToolStripMenuItem.Click += new System.EventHandler(this.V_PlanToolStripMenuItem_Click);
            // 
            // V_AutoToolStripMenuItem
            // 
            this.V_AutoToolStripMenuItem.Name = "V_AutoToolStripMenuItem";
            this.V_AutoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.V_AutoToolStripMenuItem.Text = "自适应";
            this.V_AutoToolStripMenuItem.Click += new System.EventHandler(this.V_AutoToolStripMenuItem_Click);
            // 
            // V_CenterToolStripMenuItem
            // 
            this.V_CenterToolStripMenuItem.Name = "V_CenterToolStripMenuItem";
            this.V_CenterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.V_CenterToolStripMenuItem.Text = "居中";
            this.V_CenterToolStripMenuItem.Click += new System.EventHandler(this.V_CenterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "路径";
            // 
            // pathlbe
            // 
            this.pathlbe.AutoSize = true;
            this.pathlbe.Location = new System.Drawing.Point(94, 38);
            this.pathlbe.Name = "pathlbe";
            this.pathlbe.Size = new System.Drawing.Size(0, 12);
            this.pathlbe.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 438);
            this.Controls.Add(this.pathlbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.preBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button preBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem V_DefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem V_PlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem V_AutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem V_CenterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pathlbe;
    }
}

