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
            this.SuspendLayout();
            // 
            // lbhistory
            // 
            this.lbhistory.AutoSize = true;
            this.lbhistory.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhistory.Location = new System.Drawing.Point(57, 94);
            this.lbhistory.Name = "lbhistory";
            this.lbhistory.Size = new System.Drawing.Size(83, 23);
            this.lbhistory.TabIndex = 0;
            this.lbhistory.Text = "Ιστορία";
            // 
            // lblocation
            // 
            this.lblocation.AutoSize = true;
            this.lblocation.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocation.Location = new System.Drawing.Point(645, 94);
            this.lblocation.Name = "lblocation";
            this.lblocation.Size = new System.Drawing.Size(261, 23);
            this.lblocation.TabIndex = 1;
            this.lblocation.Text = "Τοποθεσίες και Πρόσβαση";
            // 
            // lbroam
            // 
            this.lbroam.AutoSize = true;
            this.lbroam.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbroam.Location = new System.Drawing.Point(371, 94);
            this.lbroam.Name = "lbroam";
            this.lbroam.Size = new System.Drawing.Size(113, 23);
            this.lbroam.TabIndex = 2;
            this.lbroam.Text = "Περιήγηση";
            // 
            // UniversityInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 611);
            this.Controls.Add(this.lbroam);
            this.Controls.Add(this.lblocation);
            this.Controls.Add(this.lbhistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UniversityInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Πανεπιστήμιο";
            this.Load += new System.EventHandler(this.UniversityInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhistory;
        private System.Windows.Forms.Label lblocation;
        private System.Windows.Forms.Label lbroam;
    }
}