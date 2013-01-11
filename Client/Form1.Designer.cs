namespace Tranzap
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.libraryPage = new System.Windows.Forms.TabPage();
            this.downloadsPage = new System.Windows.Forms.TabPage();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.libraryPage);
            this.tabControl.Controls.Add(this.searchPage);
            this.tabControl.Controls.Add(this.downloadsPage);
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 414);
            this.tabControl.TabIndex = 0;
            // 
            // libraryPage
            // 
            this.libraryPage.Location = new System.Drawing.Point(4, 22);
            this.libraryPage.Name = "libraryPage";
            this.libraryPage.Padding = new System.Windows.Forms.Padding(3);
            this.libraryPage.Size = new System.Drawing.Size(776, 388);
            this.libraryPage.TabIndex = 0;
            this.libraryPage.Text = "Library";
            this.libraryPage.UseVisualStyleBackColor = true;
            // 
            // downloadsPage
            // 
            this.downloadsPage.Location = new System.Drawing.Point(4, 22);
            this.downloadsPage.Name = "downloadsPage";
            this.downloadsPage.Padding = new System.Windows.Forms.Padding(3);
            this.downloadsPage.Size = new System.Drawing.Size(776, 388);
            this.downloadsPage.TabIndex = 1;
            this.downloadsPage.Text = "Downloads";
            this.downloadsPage.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchPage
            // 
            this.searchPage.Location = new System.Drawing.Point(4, 22);
            this.searchPage.Name = "searchPage";
            this.searchPage.Size = new System.Drawing.Size(776, 388);
            this.searchPage.TabIndex = 2;
            this.searchPage.Text = "Search";
            this.searchPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Tranzap";
            this.tabControl.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage libraryPage;
        private System.Windows.Forms.TabPage downloadsPage;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabPage searchPage;
    }
}

