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
    public partial class MainMenu : Form
    {
        ExpenseTrackerForm ExForm;
        TodoListForm TodoForm;
        NoteTakerForm NoteForm;
        login logForm;
        public string username;

        //variable containers for user info about Todo List
        public List<string> dates = new List<string>();
        public List<string> tasks = new List<string>();
        public List<bool> isChecks = new List<bool>();


        //variale containers for user info in Note Taker
        public List<string> notesList = new List<string>();
        public List<string> titles = new List<string>();

       

        public MainMenu(string username, login logForm)
        {
            this.logForm = logForm;
            this.username = username;
            this.ExForm = new ExpenseTrackerForm(username);
            this.TodoForm = new TodoListForm(username, dates, tasks, isChecks);
            this.NoteForm = new NoteTakerForm(username, notesList, titles);
            InitializeComponent();
            usernameText.Text = username;
            logForm.Hide();
        }


        public void InfoGetter()
        {
            TodoList.DBCleaner(username);
            for (int i = 0; i < tasks.Count; i++)
            {
                TodoList.SaveInfo(username, isChecks[i], tasks[i], dates[i].ToString());
            }
        }

        public void DataTableSaver()
        {
           NoteTaker.ClearNotes(username);

           for (int i = 0; i < notesList.Count; i++)
           {
                NoteTaker.SaveInfo(username, notesList[i], titles[i]);
           }

        }

        public void AppClose(string actionBtn)
        {
            DialogResult result;

            switch (actionBtn) 
            {
                case "logout":
                    result = MessageBox.Show("Are you sure you want to log out ?", "Log out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    break;

                case "close":
                    result = MessageBox.Show("Are you sure you want to Close this App ?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                break;

                default:
                    result = MessageBox.Show("Are you sure you want to Close this App ?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                break;
            }

          

            if (result == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                //todo list
                InfoGetter();

                //notetaker
                DataTableSaver();
                this.Cursor = Cursors.Default;
                this.Close();
                if (actionBtn == "logout")
                {
                    logForm.Show();
                } else
                {
                    logForm.Close();
                }
                
            }
            else
            {
                return;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            AppClose("close");
        }

        void PanelControlCleaner()
        {
            PanelCon.Controls.Remove(TodoForm);
            PanelCon.Controls.Remove(NoteForm);
            PanelCon.Controls.Remove(ExForm);
        }

        private void todoListBtn_Click(object sender, EventArgs e)
        {
            PanelControlCleaner();
            TodoForm.TopLevel = false;
            PanelCon.Controls.Add(TodoForm);
            PanelCon.BringToFront();
            TodoForm.Show();
      
        }

        private void noteTakerBtn_Click(object sender, EventArgs e)
        {
            PanelControlCleaner();
            NoteForm.TopLevel = false;
            PanelCon.Controls.Add(NoteForm);
            PanelCon.BringToFront();
            NoteForm.Show();

        }

        private void expenseTrackerBtn_Click(object sender, EventArgs e)
        {
            PanelControlCleaner();
            ExForm.TopLevel = false;
            PanelCon.Controls.Add(ExForm);
            PanelCon.BringToFront();
            ExForm.Show();
            
            
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            PanelCon.SendToBack();
            PanelControlCleaner();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            AppClose("logout");
        }
    }
}
