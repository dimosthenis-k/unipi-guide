namespace unipi_tour_guide
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.slideshow_picturebox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.slideshow_timer = new System.Windows.Forms.Timer(this.components);
            this.welcome_label = new System.Windows.Forms.Label();
            this.main_menu_label = new System.Windows.Forms.Label();
            this.university_section_button = new System.Windows.Forms.Button();
            this.schools_section_button = new System.Windows.Forms.Button();
            this.contact_section_button = new System.Windows.Forms.Button();
            this.calendar_section_button = new System.Windows.Forms.Button();
            this.ratings_section_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow_picturebox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slideshow_picturebox
            // 
            this.slideshow_picturebox.Location = new System.Drawing.Point(526, 146);
            this.slideshow_picturebox.Name = "slideshow_picturebox";
            this.slideshow_picturebox.Size = new System.Drawing.Size(249, 227);
            this.slideshow_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slideshow_picturebox.TabIndex = 0;
            this.slideshow_picturebox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem.Text = "Info";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // slideshow_timer
            // 
            this.slideshow_timer.Interval = 2500;
            this.slideshow_timer.Tick += new System.EventHandler(this.slideshow_timer_Tick);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.welcome_label.Location = new System.Drawing.Point(113, 44);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(601, 20);
            this.welcome_label.TabIndex = 3;
            this.welcome_label.Text = "Καλωσήρθατε στο Unipi Guide, έναν οδηγό για το Πανεπιστήμιο Πειραιώς!";
            // 
            // main_menu_label
            // 
            this.main_menu_label.AutoSize = true;
            this.main_menu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.main_menu_label.Location = new System.Drawing.Point(142, 146);
            this.main_menu_label.Name = "main_menu_label";
            this.main_menu_label.Size = new System.Drawing.Size(133, 18);
            this.main_menu_label.TabIndex = 4;
            this.main_menu_label.Text = "Μενού Επιλογών";
            this.main_menu_label.Click += new System.EventHandler(this.main_menu_label_Click);
            // 
            // university_section_button
            // 
            this.university_section_button.Location = new System.Drawing.Point(103, 197);
            this.university_section_button.Name = "university_section_button";
            this.university_section_button.Size = new System.Drawing.Size(90, 36);
            this.university_section_button.TabIndex = 5;
            this.university_section_button.Text = "Πανεπιστήμιο";
            this.university_section_button.UseVisualStyleBackColor = true;
            this.university_section_button.Click += new System.EventHandler(this.university_section_button_Click);
            // 
            // schools_section_button
            // 
            this.schools_section_button.Location = new System.Drawing.Point(103, 255);
            this.schools_section_button.Name = "schools_section_button";
            this.schools_section_button.Size = new System.Drawing.Size(90, 36);
            this.schools_section_button.TabIndex = 6;
            this.schools_section_button.Text = "Σχολές";
            this.schools_section_button.UseVisualStyleBackColor = true;
            this.schools_section_button.Click += new System.EventHandler(this.schools_section_button_Click);
            // 
            // contact_section_button
            // 
            this.contact_section_button.Location = new System.Drawing.Point(227, 254);
            this.contact_section_button.Name = "contact_section_button";
            this.contact_section_button.Size = new System.Drawing.Size(90, 37);
            this.contact_section_button.TabIndex = 8;
            this.contact_section_button.Text = "Επικοινωνία";
            this.contact_section_button.UseVisualStyleBackColor = true;
            this.contact_section_button.Click += new System.EventHandler(this.contact_section_button_Click);
            // 
            // calendar_section_button
            // 
            this.calendar_section_button.Location = new System.Drawing.Point(227, 197);
            this.calendar_section_button.Name = "calendar_section_button";
            this.calendar_section_button.Size = new System.Drawing.Size(90, 37);
            this.calendar_section_button.TabIndex = 9;
            this.calendar_section_button.Text = "Ημερολόγιο";
            this.calendar_section_button.UseVisualStyleBackColor = true;
            this.calendar_section_button.Click += new System.EventHandler(this.calendar_section_button_Click);
            // 
            // ratings_section_button
            // 
            this.ratings_section_button.Location = new System.Drawing.Point(103, 315);
            this.ratings_section_button.Name = "ratings_section_button";
            this.ratings_section_button.Size = new System.Drawing.Size(214, 37);
            this.ratings_section_button.TabIndex = 10;
            this.ratings_section_button.Text = "Σχόλια Χρηστών";
            this.ratings_section_button.UseVisualStyleBackColor = true;
            this.ratings_section_button.Click += new System.EventHandler(this.ratings_section_button_Click);
<<<<<<< HEAD

=======
<<<<<<< HEAD
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "authors";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
=======
>>>>>>> fb179189c2019da32d43d80314f71270fbffee58
>>>>>>> e438b481183aa611c76e781b9e981526663deefa
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ratings_section_button);
            this.Controls.Add(this.calendar_section_button);
            this.Controls.Add(this.contact_section_button);
            this.Controls.Add(this.schools_section_button);
            this.Controls.Add(this.university_section_button);
            this.Controls.Add(this.main_menu_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.slideshow_picturebox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unipi Guide - Welcome";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slideshow_picturebox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slideshow_picturebox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Timer slideshow_timer;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label main_menu_label;
        private System.Windows.Forms.Button university_section_button;
        private System.Windows.Forms.Button schools_section_button;
        private System.Windows.Forms.Button contact_section_button;
        private System.Windows.Forms.Button calendar_section_button;
        private System.Windows.Forms.Button ratings_section_button;
    }
}