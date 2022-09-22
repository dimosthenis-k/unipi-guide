namespace unipi_tour_guide
{
    partial class SchoolsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolsForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.school_selection_label = new System.Windows.Forms.Label();
            this.schools_unipi_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.schools_unipi_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(254, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(534, 373);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Οικονομικών, Επιχειρηματικών και Κοινωνικών Σπουδών";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ναυτιλίας και Βιομηχανίας";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Χρηματοοικονομικής και Στατιστικής";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Τεχνολογιών Πληροφορικής και Επικοινωνιών";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // school_selection_label
            // 
            this.school_selection_label.AutoSize = true;
            this.school_selection_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.school_selection_label.Location = new System.Drawing.Point(210, 20);
            this.school_selection_label.Name = "school_selection_label";
            this.school_selection_label.Size = new System.Drawing.Size(396, 16);
            this.school_selection_label.TabIndex = 5;
            this.school_selection_label.Text = "Επιλέξτε μια απο τις σχολές για παραπάνω πληροφορίες";
            // 
            // schools_unipi_logo
            // 
            this.schools_unipi_logo.Location = new System.Drawing.Point(45, 65);
            this.schools_unipi_logo.Name = "schools_unipi_logo";
            this.schools_unipi_logo.Size = new System.Drawing.Size(102, 94);
            this.schools_unipi_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schools_unipi_logo.TabIndex = 6;
            this.schools_unipi_logo.TabStop = false;
            // 
            // SchoolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.schools_unipi_logo);
            this.Controls.Add(this.school_selection_label);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchoolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unipi Guide - Σχολές";
            this.Load += new System.EventHandler(this.SchoolsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schools_unipi_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label school_selection_label;
        private System.Windows.Forms.PictureBox schools_unipi_logo;
    }
}