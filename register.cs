using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listrack
{
    public partial class register : Form
    {

        Guna2Panel panel;
        public register(Guna2Panel panel)
        {
            
            InitializeComponent();
            this.panel = panel;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string userText = usernameInputBox.Text;
            string passText = passInputBox.Text;
            string confirmText = ConfirmPassInput.Text;

            Register reg = new Register(userText, passText, this, usernameInputBox, passInputBox, ConfirmPassInput, panel);


            bool emptyChecker = userText != "" && passText != "";
            bool passConChecker = passText == confirmText;
            if (emptyChecker)
            {
                if (passConChecker)
                {
                    this.Cursor = Cursors.WaitCursor;
                    reg.UserCheck();
                }

                else
                {
                    MessageBox.Show("Passwords did not Matched", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("These Fields cannot be empty", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void LoginAnchor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            panel.Controls.Remove(this);
            panel.SendToBack();
            
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            
            if (showPass.Checked)
            {
                
                ConfirmPassInput.UseSystemPasswordChar = false;
                ConfirmPassInput.PasswordChar = '\0';
                passInputBox.UseSystemPasswordChar = false;
                passInputBox.PasswordChar = '\0';
            }
            else
            {
                ConfirmPassInput.UseSystemPasswordChar = true;
                ConfirmPassInput.PasswordChar = '●';
                passInputBox.UseSystemPasswordChar = true;
                passInputBox.PasswordChar = '●';
            }
        }
    }
}
