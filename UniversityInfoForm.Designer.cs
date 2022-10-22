namespace unipi_tour_guide
{
    partial class UniversityInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniversityInfoForm));
            this.lbhistory = new System.Windows.Forms.Label();
            this.lblocation = new System.Windows.Forms.Label();
            this.lbroam = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unipi_browser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbhistory
            // 
            this.lbhistory.AutoSize = true;
            this.lbhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhistory.Location = new System.Drawing.Point(56, 76);
            this.lbhistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbhistory.Name = "lbhistory";
            this.lbhistory.Size = new System.Drawing.Size(65, 18);
            this.lbhistory.TabIndex = 0;
            this.lbhistory.Text = "Ιστορία";
            this.lbhistory.Click += new System.EventHandler(this.lbhistory_Click);
            // 
            // lblocation
            // 
            this.lblocation.AutoSize = true;
            this.lblocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocation.Location = new System.Drawing.Point(484, 76);
            this.lblocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblocation.Name = "lblocation";
            this.lblocation.Size = new System.Drawing.Size(212, 18);
            this.lblocation.TabIndex = 1;
            this.lblocation.Text = "Τοποθεσίες και Πρόσβαση";
            this.lblocation.Click += new System.EventHandler(this.lblocation_Click);
            // 
            // lbroam
            // 
            this.lbroam.AutoSize = true;
            this.lbroam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbroam.Location = new System.Drawing.Point(272, 76);
            this.lbroam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbroam.Name = "lbroam";
            this.lbroam.Size = new System.Drawing.Size(89, 18);
            this.lbroam.TabIndex = 2;
            this.lbroam.Text = "Περιήγηση";
            this.lbroam.Click += new System.EventHandler(this.lbroam_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // unipi_browser
            // 
            this.unipi_browser.Location = new System.Drawing.Point(28, 135);
            this.unipi_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.unipi_browser.Name = "unipi_browser";
            this.unipi_browser.Size = new System.Drawing.Size(687, 349);
            this.unipi_browser.TabIndex = 4;
            // 
            // UniversityInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 496);
            this.Controls.Add(this.unipi_browser);
            this.Controls.Add(this.lbroam);
            this.Controls.Add(this.lblocation);
            this.Controls.Add(this.lbhistory);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UniversityInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Πανεπιστήμιο";
            this.Load += new System.EventHandler(this.UniversityInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhistory;
        private System.Windows.Forms.Label lblocation;
        private System.Windows.Forms.Label lbroam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.WebBrowser unipi_browser;
    }
}