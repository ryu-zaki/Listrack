using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Listrack
{
    public partial class NoteTakerForm : Form
    {

        DataTable notes;
        bool editing = false;
        List<string> notesList;
        List<string> titles;
        public string username;

        public NoteTakerForm(string username, List<string> notesList, List<string> titles)
        {
            InitializeComponent();
            this.notesList = notesList;
            this.titles = titles;
            this.username = username;
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
                if (DataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("There is nothing in here that can be delete.", "Error");
                }

                else if (DataGridView1.Rows.Count == 1)
                {
                    //di maayos par
                    noLabel.Visible = true;
                }
                
                int index = DataGridView1.SelectedCells[0].RowIndex;
                notes.Rows[index].Delete();
                notesList.RemoveAt(index);
                titles.RemoveAt(index);
            
                //for (int i = DataGridView1.Rows.Count - 1; i >= 0; i--)
                //{
                //    if (DataGridView1.Rows.Count == 0)
                //    {
                //        MessageBox.Show("There is nothing in here that can be delete.", "Error");
                //    }
                    
                //    else if(DataGridView1.Rows.Count <= 0)
                //    {
                //        //di maayos par
                //        noLabel.Visible = true;
                //    }
                //}
            
            titleTextbox.Clear();
            messageTextbox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (editing)
            {
                notes.Rows[DataGridView1.CurrentCell.RowIndex]["Title"] = titleTextbox.Text;
                notes.Rows[DataGridView1.CurrentCell.RowIndex]["Message"] = messageTextbox.Text;

                //SQL Part
                notesList[DataGridView1.CurrentCell.RowIndex] = messageTextbox.Text;
                titles[DataGridView1.CurrentCell.RowIndex] = titleTextbox.Text;
                titleTextbox.Clear();
                messageTextbox.Clear();
            }

            else 
            {
                if (titleTextbox.Text == "" || messageTextbox.Text == "")
                {
                    MessageBox.Show("Please enter a title or note", "Error");
                }
                else
                {
                    notes.Rows.Add(titleTextbox.Text, messageTextbox.Text);

                    //SQL Part
                    notesList.Add(messageTextbox.Text);
                    titles.Add(titleTextbox.Text);
                    titleTextbox.Clear();
                    messageTextbox.Clear();
                }
            }

            for (int i = DataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                if (DataGridView1.Rows[i] != null)
                {
                    noLabel.Visible = false;
                }
                else
                {
                    noLabel.Visible = true;
                }
            }


           
           
            editing = false;
            DataGridView1.ClearSelection();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                int index = DataGridView1.CurrentCell.RowIndex;
                

                if (index > -1)
                {
                    titleTextbox.Text = notes.Rows[index].ItemArray[0].ToString();
                    messageTextbox.Text = notes.Rows[index].ItemArray[1].ToString();

                    editing = true;
                    
                }

                for (int i = DataGridView1.Rows.Count - 1; i >= 0; i--)
                {
                    if (DataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("There is nothing in here that can be edited.", "Error");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("There is nothing in here that can be edited.", "Error"); }
            
            
        }

        private void NoteTakerForm_Load(object sender, EventArgs e)
        {
            
            notes = new DataTable();
            notes.Columns.Add("Title", typeof(String));
            notes.Columns.Add("Message", typeof(String));

            NoteTaker.GetNotes(username, notes, DataGridView1, noLabel, notesList, titles);

            DataGridView1.Columns["Message"].Visible = false;
            DataGridView1.Columns["Title"].Width = 190;
            SetTooltips();
            DataGridView1.ClearSelection();
            
        }

        private void undobutton_Click(object sender, EventArgs e)
        {
            messageTextbox.Undo();
        }

        private void redobutton_Click(object sender, EventArgs e)
        {
            messageTextbox.Redo();
        }

        private void fontbutton_Click(object sender, EventArgs e)
        {
            FontDialog newFont = new FontDialog();
            if (newFont.ShowDialog() == DialogResult.OK)
                messageTextbox.Font = newFont.Font;
        }

        private void fontColor_Click(object sender, EventArgs e)
        {
            ColorDialog fontColor = new ColorDialog();
            if (fontColor.ShowDialog() == DialogResult.OK)
                messageTextbox.ForeColor =  fontColor.Color;

            //hindi bumabalik sa default font style & font color
        }

        private void themebutton_Click(object sender, EventArgs e)
        {
            ColorDialog backgroundColor = new ColorDialog();
            if (backgroundColor.ShowDialog() == DialogResult.OK)
            
                //BackColor
                messageTextbox.BackColor = backgroundColor.Color;
                DataGridView1.BackgroundColor = backgroundColor.Color;
                noLabel.BackColor = backgroundColor.Color;
                saveButton.BackColor = backgroundColor.Color;
                editButton.BackColor = backgroundColor.Color;
                deleteButton.BackColor = backgroundColor.Color;
                fontColorButton.BackColor = backgroundColor.Color;
                fontStyleButton.BackColor = backgroundColor.Color;
                themeButton.BackColor = backgroundColor.Color;
                undobutton.BackColor = backgroundColor.Color;
                redobutton.BackColor = backgroundColor.Color;
                //FillColor
                undobutton.FillColor = backgroundColor.Color;
                redobutton.FillColor = backgroundColor.Color;
                messagebackground.FillColor = backgroundColor.Color;
                notesbackground.FillColor = backgroundColor.Color;
                titleTextbox.FillColor = backgroundColor.Color;
                buttonsbackground.FillColor = backgroundColor.Color;
                stylebackground.FillColor = backgroundColor.Color;
        }

        private void changeBackgroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog backgroundColor = new ColorDialog();
            if (backgroundColor.ShowDialog() == DialogResult.OK)
                this.BackColor = backgroundColor.Color;
        }
        private void SetTooltips()
        {
            saveBtnTooltip.SetToolTip(saveButton, "Save");
            editBtnTooltip.SetToolTip(editButton, "Edit");
            deleteBtnTooltip.SetToolTip(deleteButton, "Delete");
            undoBtnTooltip.SetToolTip(undobutton, "Undo");
            redoBtnTooltip.SetToolTip(redobutton, "Redo");
            fontColorBtnTooltip.SetToolTip(fontColorButton, "Font Color");
            fontStyleBtnTooltip.SetToolTip(fontStyleButton, "Font Style");
            themeBtnTooltip.SetToolTip(themeButton, "Change Theme");
            changeBackgroundBtnTooltip.SetToolTip(changeBackgroundButton, "Change Background Color");
        }

        private void NoteTakerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

    }
}
