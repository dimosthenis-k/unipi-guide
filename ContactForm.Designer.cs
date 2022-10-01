namespace unipi_tour_guide
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.saveiconpb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.saveiconpb)).BeginInit();
            this.SuspendLayout();
            // 
            // saveiconpb
            // 
            this.saveiconpb.Location = new System.Drawing.Point(808, 459);
            this.saveiconpb.Name = "saveiconpb";
            this.saveiconpb.Size = new System.Drawing.Size(50, 49);
            this.saveiconpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveiconpb.TabIndex = 0;
            this.saveiconpb.TabStop = false;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 520);
            this.Controls.Add(this.saveiconpb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactForm";
            this.Text = "Επικοινωνία";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saveiconpb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox saveiconpb;
    }
}