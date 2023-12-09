using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Listrack
{
    public partial class TodoListForm : Form
    {
        int row_index = 0;
        public string username;
        public List<string> dates;
        public List<string> tasks;
        public List<bool> isChecks;


        public TodoListForm(string username, List<string> dates, List<string> tasks, List<bool> isChecks)
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            this.username = username;
            this.dates = dates;
            this.tasks = tasks;
            this.isChecks = isChecks;

            TodoList.GetInfo(username, DataGridView1, dates, tasks, isChecks);
           

            if (DataGridView1.Rows.Count > 1)
            {
                DataGridViewCheckBoxColumn checkboxcol = DataGridView1.Columns["Column1"] as DataGridViewCheckBoxColumn;
                checkboxcol.Visible = true;
                btnCheckBox.Visible = true;
            } 
            
        }


        private void Add_Row()
        {
            DataGridViewCheckBoxColumn checkboxcol = DataGridView1.Columns["Column1"] as DataGridViewCheckBoxColumn;
            checkboxcol.Visible = true;
            DataGridViewTextBoxColumn tasks_col = DataGridView1.Columns["Column2"] as DataGridViewTextBoxColumn;
            tasks_col.ReadOnly = false;
            DataGridViewTextBoxColumn date_col = DataGridView1.Columns["Column3"] as DataGridViewTextBoxColumn;
            date_col.ReadOnly = false;
            btnCheckBox.Visible = true;
        }
        private void Disable_Column()
        {
            DataGridViewCheckBoxColumn checkboxcol = DataGridView1.Columns["Column1"] as DataGridViewCheckBoxColumn;
            checkboxcol.Visible = false;
            btnCheckBox.Visible = false;
        }
        private void Disable_Type()
        {
            DataGridViewTextBoxColumn tasks_col = DataGridView1.Columns["Column2"] as DataGridViewTextBoxColumn;
            tasks_col.ReadOnly = true;
            DataGridViewTextBoxColumn date_col = DataGridView1.Columns["Column3"] as DataGridViewTextBoxColumn;
            date_col.ReadOnly = true;
        }
        private void Enable_Type()
        {
            DataGridViewTextBoxColumn tasks_col = DataGridView1.Columns["Column2"] as DataGridViewTextBoxColumn;
            tasks_col.ReadOnly = false;
            DataGridViewTextBoxColumn date_col = DataGridView1.Columns["Column3"] as DataGridViewTextBoxColumn;
            date_col.ReadOnly = false;
        }
        private void btnAddIcon_Click(object sender, EventArgs e)
        {
            Add_Row();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DataGridView1.Rows.Count)
            {
                row_index = e.RowIndex;
                DataGridViewRow row_selected = DataGridView1.Rows[row_index];
                if (!DataGridView1.Rows[row_index].IsNewRow)
                {
                    Disable_Type();
                }
            }
        }

        private void btnEditPen_Click(object sender, EventArgs e)
        {
            Enable_Type();
            DataGridView1.BeginEdit(true);
        }

        private void btnDelete_Click(object sender, EventArgs e) // good
        {
            Del_Function();
            DataGridView1.ClearSelection();
        }

        private void btnCheckBox_Click(object sender, EventArgs e) //good
        {
            Disable_Type();
            bool all_check = false;
            for (int i = 0; i < DataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCheckBoxCell row_detect = DataGridView1.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                if (row_detect != null && row_detect.Value != null && (bool?)row_detect.Value == true)
                {
                    all_check = true;
                }
            }

            for (int i = 0; i < DataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row_fill = DataGridView1.Rows[i] as DataGridViewRow;
                DataGridViewCheckBoxCell row_detect = row_fill.Cells[0] as DataGridViewCheckBoxCell;
                if (row_detect != null)
                {
                    row_detect.Value = !all_check;
                }
            }

            for (int i = 0; i < DataGridView1.Rows.Count - 1; i++)
            {
                ChangeBackgroundColor(i);
            }
        }
        private void Del_Function() //good
        {
            for (int i = DataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                if (DataGridView1.Rows[i] != null && !DataGridView1.Rows[i].IsNewRow)
                {
                    DataGridViewCheckBoxCell rowRemove = DataGridView1.Rows[i].Cells[0] as DataGridViewCheckBoxCell;

                    if (rowRemove.Value != null && (bool)rowRemove.Value == true)
                    {
                        DataGridView1.Rows.RemoveAt(i);
                        try
                        {
                            tasks.RemoveAt(i);
                            dates.RemoveAt(i);
                            isChecks.RemoveAt(i);
                        }
                        catch(Exception)
                        {
                            
                        }
                        
                    }
                }
            }

            if (DataGridView1.Rows.Count <= 1)
            {
                Disable_Column();
            }
        }
        private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                if (e.RowIndex != DataGridView1.NewRowIndex) // Check if it's not the new row
                {
                    DataGridViewCell cell = DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        string dateNow = DateTime.Now.ToString();
                        DataGridView1.Rows[e.RowIndex].Cells[2].Value = dateNow;
                    } 
                }
            }
           

        }
        private void ChangeBackgroundColor(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = DataGridView1.Rows[rowIndex].Cells[0] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null)
                {
                    DataGridViewCell cell = DataGridView1.Rows[rowIndex].Cells[2];

                    object cellValue = checkBoxCell.Value;
                    bool isChecked = (cellValue != null && (bool)cellValue);

                    if (isChecked)
                    {
                        cell.Style.BackColor = Color.FromArgb(203, 213, 192);
                    }
                    else
                    {
                        cell.Style.BackColor = Color.Empty;
                    }
                }
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = DataGridView1.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null)
                {
                    bool isChecked = (bool)checkBoxCell.Value;

                

                    if (isChecked)
                    {
                        DataGridViewCell cell = DataGridView1.Rows[e.RowIndex].Cells[2]; // Column 3

                        // Change the background color of column 3
                        cell.Style.BackColor = Color.FromArgb(203, 213, 192);

                       
                    }
                    else
                    {
                        // If unchecked, set the background color back to default (empty)
                        DataGridViewCell cell = DataGridView1.Rows[e.RowIndex].Cells[2]; // Column 3
                        cell.Style.BackColor = Color.Empty;

                      
                    }
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TodoListForm_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            lblDate0505.Text = currentDate.ToString("dd MMM, yyyy, dddd");

            //theme
            comboBoxTheme.Items.Add("Dark");
            comboBoxTheme.Items.Add("Light");


            SetTheme("Light");

            comboBoxTheme.SelectedIndexChanged += comboBoxTheme_SelectedIndexChanged;

           
            

        }
        //CellClick_Change_Theme


        private void SetTheme(string theme)
        {
            // Set black theme
            if (theme.Equals("Dark", StringComparison.OrdinalIgnoreCase))
            {

                this.BackColor = Color.Black;

                lblDate0505.ForeColor = Color.White;
                lblSetTheme.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
              

                //DataGridView1.DefaultCellStyle.BackColor = Color.Black;
                //DataGridView1.DefaultCellStyle.ForeColor = Color.White;
                //DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                //DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
            // Set light theme
            else if (theme.Equals("Light", StringComparison.OrdinalIgnoreCase))
            {

                this.BackColor = SystemColors.Control;
                lblDate0505.ForeColor = SystemColors.ControlText;
                lblSetTheme.ForeColor = SystemColors.ControlText;
                label1.ForeColor = SystemColors.ControlText;
                label2.ForeColor = SystemColors.ControlText;
              

                //DataGridView1.DefaultCellStyle.BackColor = SystemColors.Control;
                //DataGridView1.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                //DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                //DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;


            }
        }
        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTheme = comboBoxTheme.SelectedItem.ToString();
            SetTheme(selectedTheme);
        }


      

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value != null)
            {
                string dateNow = DateTime.Now.ToString();
                string task = cell.Value.ToString();
                dates.Add(dateNow);
                isChecks.Add(false);


                if (cell is DataGridViewCheckBoxCell checkbox)
                {
                    bool isChecked = (bool)cell.Value;
                    if (isChecks[cell.RowIndex] != null)
                    {
                        isChecks[cell.RowIndex] = isChecked;
                    } else
                    {
                        isChecks.Add(isChecked);
                    }
                } 


                if (e.ColumnIndex == 1 && DataGridView1.Rows.Count > 0)
                {
                    if (e.RowIndex >= 0 && e.RowIndex < tasks.Count)
                    {
                        tasks[e.RowIndex] = cell.Value.ToString();
                    } else
                    {
                        tasks.Add(cell.Value.ToString());
                    }
                    
                
                }
            }
            
        }
    }
}
