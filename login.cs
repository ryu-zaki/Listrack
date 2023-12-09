using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Listrack
{
    public partial class login : Form
    {
        register RegForm;

        public login()
        {
            
            InitializeComponent();
            this.RegForm = new register(LogRegPanelCon);
        }


        private void RegisterAnchor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm.TopLevel = false;
            LogRegPanelCon.Controls.Add(RegForm);
            LogRegPanelCon.BringToFront();
            RegForm.Show();
          
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
           if (showPass.Checked)
            {
                passInputBox.UseSystemPasswordChar = false;
                passInputBox.PasswordChar = '\0';

            }
            else
            {
                passInputBox.UseSystemPasswordChar = true;
                passInputBox.PasswordChar = '●';
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (usernameInputBox.Text != "" && passInputBox.Text != "")
            {
                Login log = new Login(usernameInputBox.Text, passInputBox.Text, this);
                log.LogAcc();
                
            }
            else
            {
                MessageBox.Show("These Fields cannot be empty", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
