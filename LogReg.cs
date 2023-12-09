using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Guna.UI2.WinForms;

namespace Listrack
{
    internal class LogReg
    {

        public static string connectionString = "Host=containers-us-west-79.railway.app;PORT=6130;USERNAME=postgres;PASSWORD=2zuy5TyWsONptHqxqNco;DATABASE=railway;";

        public static NpgsqlConnection connection = new NpgsqlConnection(connectionString);
    }

    class Login : LogReg
    {
        public string usernameText;
        public string passwordText;
        public login logForm;

        public Login(string usernameText, string passwordText, login logForm)
        {
            this.usernameText = usernameText;
            this.passwordText = passwordText;
            this.logForm = logForm;
        }

        public void LogAcc()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM listrack_user WHERE username = @username AND password = @password";

                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", usernameText);
                cmd.Parameters.AddWithValue("@password", passwordText);

                NpgsqlDataReader reader = cmd.ExecuteReader();


                int i = 0;
                while (reader.Read())
                {
                    i++;
                }
                logForm.Cursor = Cursors.Default;
                if (i > 0)
                {
                    MessageBox.Show("Enjoy Our Application!", "Welcome To Listrack", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Display the Main Application When Login is Successfull
                    MainMenu menu = new MainMenu(usernameText, logForm);
                    menu.Show();

                }
                else
                {
                    logForm.Opacity = 1;
                    MessageBox.Show("You Don't have an account!", "Failed to log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
    }

        class Register : LogReg
        {

            string username;
            string password;
            register regForm;

            Guna2TextBox userInputComp;
            Guna2TextBox passInputComp;
            Guna2TextBox confirmInputComp;
            Guna2Panel panel;
            public Register(string username, string password, register reg, Guna2TextBox userInputComp, Guna2TextBox passInputComp, Guna2TextBox confirmInputComp, Guna2Panel panel)
            {
                this.username = username;
                this.password = password;

                this.regForm = reg;

                this.userInputComp = userInputComp;
                this.passInputComp = passInputComp;
                this.confirmInputComp = confirmInputComp;
                this.panel = panel;
            }

            public void RegAcc()
            {
                connection.Open();
                DateTime currentDate = DateTime.Now;
                string query = "INSERT INTO listrack_user (username, password, login_date) VALUES (@Username, @Password, @LoginDate)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@LoginDate", currentDate);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    i++;
                }
                regForm.Cursor = Cursors.Default;
                userInputComp.Text = "";
                passInputComp.Text = "";
                confirmInputComp.Text = "";
                MessageBox.Show("You can now log in your account.", "Login Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                panel.Controls.Remove(regForm);
                panel.SendToBack();
                connection.Close();
            }

            public void UserCheck()
            {
                connection.Open();
                string query = "SELECT * FROM listrack_user WHERE username = @Username";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    i++;
                }

                if (i > 0)
                {
                    MessageBox.Show("Username is already taken.", "Please change your username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    connection.Close();
                    RegAcc();
                }
            }


        }
    }

