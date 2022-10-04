namespace unipi_tour_guide
{
    partial class form1
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
        //Ιάσονας
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.no_account_link = new System.Windows.Forms.LinkLabel();
            this.login_button = new System.Windows.Forms.Button();
            this.signup_label = new System.Windows.Forms.LinkLabel();
            this.banner_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.banner_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(145, 142);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(105, 24);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(145, 204);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 24);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(145, 169);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 20);
            this.username_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(145, 231);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(100, 20);
            this.password_textbox.TabIndex = 3;
            // 
            // no_account_link
            // 
            this.no_account_link.ActiveLinkColor = System.Drawing.Color.PowderBlue;
            this.no_account_link.AutoSize = true;
            this.no_account_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.no_account_link.Location = new System.Drawing.Point(124, 316);
            this.no_account_link.Name = "no_account_link";
            this.no_account_link.Size = new System.Drawing.Size(143, 13);
            this.no_account_link.TabIndex = 4;
            this.no_account_link.TabStop = true;
            this.no_account_link.Text = "Continue without an account";
            this.no_account_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.no_account_link_LinkClicked);
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.login_button.Location = new System.Drawing.Point(159, 257);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // signup_label
            // 
            this.signup_label.ActiveLinkColor = System.Drawing.Color.PowderBlue;
            this.signup_label.AutoSize = true;
            this.signup_label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.signup_label.Location = new System.Drawing.Point(172, 293);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(45, 13);
            this.signup_label.TabIndex = 6;
            this.signup_label.TabStop = true;
            this.signup_label.Text = "Sign Up";
            this.signup_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_label_LinkClicked);
            // 
            // banner_picturebox
            // 
            this.banner_picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.banner_picturebox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.banner_picturebox.InitialImage = null;
            this.banner_picturebox.Location = new System.Drawing.Point(3, 6);
            this.banner_picturebox.Name = "banner_picturebox";
            this.banner_picturebox.Size = new System.Drawing.Size(377, 100);
            this.banner_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner_picturebox.TabIndex = 7;
            this.banner_picturebox.TabStop = false;
            this.banner_picturebox.Click += new System.EventHandler(this.banner_picturebox_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 459);
            this.Controls.Add(this.banner_picturebox);
            this.Controls.Add(this.signup_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.no_account_link);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unipi Guide";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banner_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.LinkLabel no_account_link;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.LinkLabel signup_label;
        private System.Windows.Forms.PictureBox banner_picturebox;
    }
}

