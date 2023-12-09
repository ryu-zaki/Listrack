using Guna.UI2.WinForms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Listrack
{
    internal class AppsMainClass
    {
        // this.Location = new System.Drawing.Point(435, 174);

        //Initialized Forms;


        //public static string connectionString = "Host=containers-us-west-79.railway.app;PORT=6130;USERNAME=postgres;PASSWORD=2zuy5TyWsONptHqxqNco;DATABASE=railway;";
        public static string connectionString = "Host=localhost;PORT=5432;USERNAME=postgres;PASSWORD=reanneMoran;DATABASE=test";
        public static NpgsqlConnection connection = new NpgsqlConnection(connectionString);

       
    }

    

    class NoteTaker : AppsMainClass
    {
       
        //Mamayson & Lorico

        //Write Your Code Here
        public static void GetNotes(string username, DataTable notes, Guna2DataGridView dataGrid, Guna2HtmlLabel noLabel, List<string> notesList, List<string> titles)
        {
            connection.Open();
            string query = "SELECT * FROM note_info WHERE username = @Username";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataRow newRow = notes.NewRow();
                newRow["Title"] = reader.GetString(3);
                newRow["Message"] = reader.GetString(2);

                notesList.Add(reader.GetString(2));
                titles.Add(reader.GetString(3));

                notes.Rows.Add(newRow);
                noLabel.Visible = false;
            }

            dataGrid.DataSource = notes;
            dataGrid.ClearSelection();
            connection.Close();
        }

        public static void ClearNotes(string username)
        {
            connection.Open();
            string query = "DELETE FROM note_info WHERE username = @Username";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void SaveInfo(string username, string note, string title)
        {
            connection.Open();

            string query = "INSERT INTO note_info (username, note, title) VALUES (@Username, @Note, @Title)";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Note", note);
            cmd.Parameters.AddWithValue("@Title", title);

            cmd.ExecuteNonQuery();

            connection.Close();

        }

    }

    class TodoList : AppsMainClass
    {
       
        //Write Your Code Here
        //Vidal & Tenegra
        public static void GetInfo(string username, Guna2DataGridView dataGrid, List<string> dates, List<string> tasks, List<bool> isChecks)
        {
            connection.Open();
            string query = "SELECT * FROM todo_info WHERE username = @Username";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                dataGrid.Rows.Add(bool.Parse(reader.GetString(4)), reader.GetString(2), reader.GetString(3));

               
                isChecks.Add(bool.Parse(reader.GetString(4)));
                dates.Add(reader.GetString(3));
                tasks.Add(reader.GetString(2));
            }
            dataGrid.ClearSelection();
            connection.Close();
        }
       
        public static void DBCleaner(string username)
        {
            connection.Open();
            string query = "DELETE FROM todo_info WHERE username = @Username";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
         public static void SaveInfo(string username, bool ischecked, string task, string date)
        {
           
            connection.Open();
            string query = "INSERT INTO todo_info (username, task, date, ischecked) VALUES (@Username, @Task, @Date, @Ischecked)";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Task", task);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Ischecked", ischecked);

            cmd.ExecuteNonQuery();
            connection.Close();

        }

    }

    class ExpenseTracker : AppsMainClass
    {
        public static void GetHistory(string username, Guna2DataGridView ExpenseHistory, System.Windows.Forms.Label NoHistoryMsg)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM expense_history WHERE username = @Username";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    NoHistoryMsg.Visible = false;
                    if (ExpenseHistory.Rows.Count > 0)
                    {
                        ExpenseHistory.Rows.Clear();
                    }
                   

                    //iterator
                    int i = 0;
                    while (reader.Read())
                    {
                        string totalAmount = reader.GetString(2);
                        DateTime actualDate = reader.GetDateTime(3);                           
                        ExpenseHistory.Rows.Add(totalAmount, actualDate.ToShortDateString());

                        
                    }
                }
                else
                {
                    NoHistoryMsg.Visible = true;
                }
                connection.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void ResetSave(string username , string totalAmount)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO expense_history (username, total_amount, actual_date) VALUES (@Username, @Total_Amount, @Actual_Date)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Total_Amount", totalAmount);
                cmd.Parameters.AddWithValue("@Actual_Date", DateTime.Now);

                cmd.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception)
            {

                throw;
            }
            
            
        }


       public static void DeleteExpense(string username, string description, string time)
       {
            try
            {
                connection.Open();
                string query = "DELETE FROM expense_info WHERE username = @Username AND description = @Description AND time = @Time";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Time", time);

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
       }

       
       public static void GetUserInfo(string username, DataGridView DataGrid, System.Windows.Forms.Label SpendTotal, Guna2HtmlLabel NoExpsenseMsg)
       {
            try
            {
                connection.Open();
                string query = "SELECT * FROM expense_info WHERE username = @Username";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    double totalCon = 0;

                    NoExpsenseMsg.Visible = false;
                    while (reader.Read())
                    {
                        string description = reader.GetString(2);
                        string amount = reader.GetString(3);
                        string time = reader.GetString(4);
                        DataGrid.Rows.Add(description, amount, time);
                        totalCon += double.Parse(amount.Substring(1));
                    }

                    SpendTotal.Text = "₱" + (totalCon.ToString($"F{2}"));
                } else
                {
                    NoExpsenseMsg.Visible = true;

                }
                connection.Close();


            }
            catch (Exception)
            {

                throw;
            }
       }
        
       public static void RecordExpense(string username, string description, string amount, string time)
       {
            try
            {
                connection.Open();
                string query = "INSERT INTO expense_info (username, description, amount, time) VALUES (@Username, @Description, @Amount, @Time)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Time", time);

                NpgsqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }
}