namespace Listrack
{
    partial class register
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
            this.showPass = new System.Windows.Forms.CheckBox();
            this.registerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passInputBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameInputBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ConfirmPassInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LoginAnchor = new System.Windows.Forms.LinkLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(380, 347);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(101, 17);
            this.showPass.TabIndex = 13;
            this.showPass.Text = "Show password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // registerBtn
            // 
            this.registerBtn.BorderRadius = 25;
            this.registerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(416, 384);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(222, 47);
            this.registerBtn.TabIndex = 12;
            this.registerBtn.Text = "Register";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // passInputBox
            // 
            this.passInputBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passInputBox.BorderRadius = 26;
            this.passInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passInputBox.DefaultText = "";
            this.passInputBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passInputBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passInputBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passInputBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passInputBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passInputBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passInputBox.ForeColor = System.Drawing.Color.Black;
            this.passInputBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passInputBox.Location = new System.Drawing.Point(380, 192);
            this.passInputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passInputBox.Name = "passInputBox";
            this.passInputBox.PasswordChar = '●';
            this.passInputBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passInputBox.PlaceholderText = "Password";
            this.passInputBox.SelectedText = "";
            this.passInputBox.Size = new System.Drawing.Size(309, 53);
            this.passInputBox.TabIndex = 11;
            this.passInputBox.UseSystemPasswordChar = true;
            // 
            // usernameInputBox
            // 
            this.usernameInputBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameInputBox.BorderRadius = 26;
            this.usernameInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameInputBox.DefaultText = "";
            this.usernameInputBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameInputBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameInputBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameInputBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameInputBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameInputBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameInputBox.ForeColor = System.Drawing.Color.Black;
            this.usernameInputBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameInputBox.Location = new System.Drawing.Point(380, 116);
            this.usernameInputBox.Margin = new System.Windows.Forms.Padding(10);
            this.usernameInputBox.Name = "usernameInputBox";
            this.usernameInputBox.Padding = new System.Windows.Forms.Padding(20);
            this.usernameInputBox.PasswordChar = '\0';
            this.usernameInputBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.usernameInputBox.PlaceholderText = "Username";
            this.usernameInputBox.SelectedText = "";
            this.usernameInputBox.Size = new System.Drawing.Size(309, 54);
            this.usernameInputBox.TabIndex = 10;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(471, 75);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(145, 22);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Create you account!";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(396, 29);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(281, 40);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Join to our Journey";
            // 
            // ConfirmPassInput
            // 
            this.ConfirmPassInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConfirmPassInput.BorderRadius = 26;
            this.ConfirmPassInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPassInput.DefaultText = "";
            this.ConfirmPassInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmPassInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmPassInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPassInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPassInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPassInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConfirmPassInput.ForeColor = System.Drawing.Color.Black;
            this.ConfirmPassInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPassInput.Location = new System.Drawing.Point(380, 271);
            this.ConfirmPassInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmPassInput.Name = "ConfirmPassInput";
            this.ConfirmPassInput.PasswordChar = '●';
            this.ConfirmPassInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ConfirmPassInput.PlaceholderText = "Confirm Password";
            this.ConfirmPassInput.SelectedText = "";
            this.ConfirmPassInput.Size = new System.Drawing.Size(309, 53);
            this.ConfirmPassInput.TabIndex = 14;
            this.ConfirmPassInput.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(512, 345);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(136, 17);
            this.guna2HtmlLabel3.TabIndex = 15;
            this.guna2HtmlLabel3.Text = "Have an account ? Try to";
            // 
            // LoginAnchor
            // 
            this.LoginAnchor.AutoSize = true;
            this.LoginAnchor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LoginAnchor.Location = new System.Drawing.Point(649, 345);
            this.LoginAnchor.Name = "LoginAnchor";
            this.LoginAnchor.Size = new System.Drawing.Size(40, 16);
            this.LoginAnchor.TabIndex = 16;
            this.LoginAnchor.TabStop = true;
            this.LoginAnchor.Text = "Login";
            this.LoginAnchor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginAnchor_LinkClicked);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.Image = global::Listrack.Properties.Resources.login_bg__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(321, 430);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 454);
            this.Controls.Add(this.LoginAnchor);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.ConfirmPassInput);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passInputBox);
            this.Controls.Add(this.usernameInputBox);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listrack";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.CheckBox showPass;
        private Guna.UI2.WinForms.Guna2Button registerBtn;
        private Guna.UI2.WinForms.Guna2TextBox passInputBox;
        private Guna.UI2.WinForms.Guna2TextBox usernameInputBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPassInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.LinkLabel LoginAnchor;
    }
}