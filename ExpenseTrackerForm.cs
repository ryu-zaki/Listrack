
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listrack
{
    public partial class ExpenseTrackerForm : Form
    {
        string username;
        public ExpenseTrackerForm(string username)
        {
            this.username = username;
            InitializeComponent();

            //Show the Current Date
            
            CurrentDate.Text = DateTime.Now.ToLongDateString();

            //Tooltips Set-up
            HistoryBtnToolTip.SetToolTip(HistoryBtn, "View History");
            EditToolTip.SetToolTip(EditBtn, "Edit");
            DeleteToolTip.SetToolTip(DeleteBtn, "Delete");

            //Adding Data to Database
            ExpenseTracker.GetUserInfo(username, ExpenseDataGrid, SpendTotal, NoExpenseMsg);
            ExpenseDataGrid.ClearSelection();
            

            if (ExpenseDataGrid.Rows.Count > 0)
            {
                resetBtnDisabled.SendToBack();
            } else
            {
                resetBtnDisabled.BringToFront();
            }

            //Expense History
            ExpenseTracker.GetHistory(username, ExpenseHistory, NoHistoryMsg);
            ExpenseHistory.ClearSelection();

        }

        void RowAdder()
        {
            string desc = InputDesc.Text;


            DateTime currentTime = DateTime.Now;

            if (InputDesc.Text == "" || InputAmount.Text == "")
            {
                MessageBox.Show("You must provide a value on every field.", $"Failed to Add Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    double amount = double.Parse(InputAmount.Text);
                    ExpenseDataGrid.Rows.Add(desc, "₱" + amount.ToString($"F{2}"), currentTime.ToShortTimeString());

                    //Input Date into Database
                    ExpenseTracker.RecordExpense(username, desc, "₱" + amount.ToString($"F{2}"), currentTime.ToShortTimeString());

                    double prevAmount = double.Parse(SpendTotal.Text.Substring(1));
                    SpendTotal.Text = $"₱{(prevAmount + amount).ToString($"F{2}")}";

                    //For Visibility of No Expense Message
                    NoExpenseMsg.SendToBack();

                    //To Reset the Input Fields 
                    InputDesc.Text = "";
                    InputAmount.Text = "";
                    UpdateBtn.SendToBack();
                    resetBtnDisabled.SendToBack();
                }
                catch (Exception)
                {
                    //For Detecting of Not A Number Value
                    MessageBox.Show("Your Amount is Not a Number", "Amount Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ExpenseDataGrid.ClearSelection();

            }


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void AddBtn_Click_2(object sender, EventArgs e)
        {
            if (InputDesc.Text == "" || InputAmount.Text == "")
            {
                MessageBox.Show("You must provide a value on every field.", "Failed to Add Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RowAdder();

            }
        }

        private void ExpenseDataGrid_SelectionChanged_1(object sender, EventArgs e)
        {
            int selectedRows = ExpenseDataGrid.SelectedRows.Count;

            if (selectedRows > 0)
            {
                //To Enable Deleting and Editing rows
                DeleteBtnDisabled.SendToBack();


                //Enable Editing if the selected rows is only one.
                if (selectedRows == 1)
                {
                    EditBtnDisabled.SendToBack();
                }
                else
                {
                    EditBtnDisabled.BringToFront();

                }
            }
            else
            {
                DeleteBtnDisabled.BringToFront();
                EditBtnDisabled.BringToFront();
            }
        }

        void SeclectedRowDeleter()
        {
            foreach (DataGridViewRow selectedRow in ExpenseDataGrid.SelectedRows)
            {
                ExpenseTracker.DeleteExpense(username, selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[2].Value.ToString());
                double SelectedRowAmount = double.Parse(selectedRow.Cells[1].Value.ToString().Substring(1));
                double CurrentAmountTotal = double.Parse(SpendTotal.Text.Substring(1));
                SpendTotal.Text = "₱" + (CurrentAmountTotal - SelectedRowAmount).ToString("F2");

                ExpenseDataGrid.Rows.Remove(selectedRow);
            }

            if (ExpenseDataGrid.Rows.Count <= 0)
            {
                NoExpenseMsg.BringToFront();
                resetBtnDisabled.BringToFront();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ExpenseDataGrid.SelectedRows.Count > 0)
            {
                SeclectedRowDeleter();
            }

            ExpenseDataGrid.ClearSelection();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            UpdateBtn.BringToFront();

            DataGridViewSelectedRowCollection selectedRow = ExpenseDataGrid.SelectedRows;

            string desc = selectedRow[0].Cells[0].Value.ToString();
            string amount = selectedRow[0].Cells[1].Value.ToString().Substring(1);

            InputDesc.Text = desc;
            InputAmount.Text = amount;

            InputDesc.FillColor = Color.DarkOrange;
            InputAmount.FillColor = Color.DarkOrange;
            InputDesc.PlaceholderForeColor = Color.Snow;
            InputAmount.PlaceholderForeColor = Color.Snow;

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (InputDesc.Text == "" || InputAmount.Text == "")
            {
                MessageBox.Show("You must provide a value on every field.", "Failed to Update Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    double amount = double.Parse(InputAmount.Text);
                    SeclectedRowDeleter();
                    RowAdder();

                    InputDesc.FillColor = SystemColors.GradientActiveCaption;
                    InputAmount.FillColor = SystemColors.GradientActiveCaption;
                    InputDesc.PlaceholderForeColor = SystemColors.WindowFrame;
                    InputAmount.PlaceholderForeColor = SystemColors.WindowFrame;
                }
                catch (Exception)
                {
                    //For Detecting of Not A Number Value
                    MessageBox.Show("Your Amount is Not a Number", "Amount Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            HistoryBtn.SendToBack();
            NoExpenseMsg.BringToFront();
            ExpenseHistory.ClearSelection();
            HistoryPanel.Visible = true;
        }

        private void ExitHistoryPanel_Click_1(object sender, EventArgs e)
        {
            HistoryBtn.BringToFront();
            HistoryPanel.Visible = false;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset your expenses list ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                ExpenseTracker.ResetSave(username, SpendTotal.Text);
                ExpenseDataGrid.SelectAll();
                SeclectedRowDeleter();

                //Expense History
                ExpenseTracker.GetHistory(username, ExpenseHistory, NoHistoryMsg);
            }
            
        }
    }
}
