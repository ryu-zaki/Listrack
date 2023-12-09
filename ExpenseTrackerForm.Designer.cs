using System.Drawing;
using System.Windows.Forms;

namespace Listrack
{
    partial class ExpenseTrackerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SpendTotal = new System.Windows.Forms.Label();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InputDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.ExpenseDataGrid = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoExpenseMsg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AnimateForm = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HistoryBtnToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2HtmlToolTip2 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.EditToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.DeleteToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.HistoryPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitHistoryPanel = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NoHistoryMsg = new System.Windows.Forms.Label();
            this.ExpenseHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.HistoryAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.resetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.resetBtnDisabled = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtnDisabled = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtnDisabled = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HistoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HistoryBtnDisabled = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDataGrid)).BeginInit();
            this.HistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.SpendTotal);
            this.guna2Panel1.Controls.Add(this.CurrentDate);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(212, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(307, 107);
            this.guna2Panel1.TabIndex = 1;
            // 
            // SpendTotal
            // 
            this.SpendTotal.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.SpendTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpendTotal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SpendTotal.Location = new System.Drawing.Point(58, 51);
            this.SpendTotal.Name = "SpendTotal";
            this.SpendTotal.Size = new System.Drawing.Size(163, 45);
            this.SpendTotal.TabIndex = 5;
            this.SpendTotal.Text = "₱0.00";
            this.SpendTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CurrentDate
            // 
            this.CurrentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CurrentDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentDate.Location = new System.Drawing.Point(3, 28);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(265, 23);
            this.CurrentDate.TabIndex = 4;
            this.CurrentDate.Text = "06/22/23";
            this.CurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(93, 6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(88, 19);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "SPEND TODAY";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(24, 147);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(87, 23);
            this.guna2HtmlLabel4.TabIndex = 4;
            this.guna2HtmlLabel4.Text = "Description";
            // 
            // InputDesc
            // 
            this.InputDesc.BackColor = System.Drawing.Color.Transparent;
            this.InputDesc.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.InputDesc.BorderRadius = 10;
            this.InputDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputDesc.DefaultText = "";
            this.InputDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputDesc.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InputDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputDesc.ForeColor = System.Drawing.Color.Black;
            this.InputDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputDesc.Location = new System.Drawing.Point(28, 177);
            this.InputDesc.Name = "InputDesc";
            this.InputDesc.PasswordChar = '\0';
            this.InputDesc.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.InputDesc.PlaceholderText = "Electric Bills";
            this.InputDesc.SelectedText = "";
            this.InputDesc.Size = new System.Drawing.Size(170, 42);
            this.InputDesc.TabIndex = 5;
            // 
            // InputAmount
            // 
            this.InputAmount.BackColor = System.Drawing.Color.Transparent;
            this.InputAmount.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.InputAmount.BorderRadius = 10;
            this.InputAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputAmount.DefaultText = "";
            this.InputAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputAmount.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InputAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputAmount.ForeColor = System.Drawing.Color.Black;
            this.InputAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputAmount.Location = new System.Drawing.Point(257, 177);
            this.InputAmount.Name = "InputAmount";
            this.InputAmount.PasswordChar = '\0';
            this.InputAmount.PlaceholderForeColor = System.Drawing.SystemColors.WindowFrame;
            this.InputAmount.PlaceholderText = "Ex.10.00";
            this.InputAmount.SelectedText = "";
            this.InputAmount.Size = new System.Drawing.Size(187, 42);
            this.InputAmount.TabIndex = 7;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(252, 147);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(104, 23);
            this.guna2HtmlLabel5.TabIndex = 6;
            this.guna2HtmlLabel5.Text = "Enter Amount";
            // 
            // ExpenseDataGrid
            // 
            this.ExpenseDataGrid.AllowUserToAddRows = false;
            this.ExpenseDataGrid.AllowUserToDeleteRows = false;
            this.ExpenseDataGrid.AllowUserToOrderColumns = true;
            this.ExpenseDataGrid.AllowUserToResizeColumns = false;
            this.ExpenseDataGrid.AllowUserToResizeRows = false;
            this.ExpenseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpenseDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ExpenseDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ExpenseDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpenseDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpenseDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ExpenseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Amount,
            this.Time});
            this.ExpenseDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpenseDataGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.ExpenseDataGrid.GridColor = System.Drawing.SystemColors.Menu;
            this.ExpenseDataGrid.Location = new System.Drawing.Point(7, 244);
            this.ExpenseDataGrid.Name = "ExpenseDataGrid";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpenseDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(5);
            this.ExpenseDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.ExpenseDataGrid.Size = new System.Drawing.Size(711, 235);
            this.ExpenseDataGrid.TabIndex = 14;
            this.ExpenseDataGrid.SelectionChanged += new System.EventHandler(this.ExpenseDataGrid_SelectionChanged_1);
            // 
            // Description
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.Description.DefaultCellStyle = dataGridViewCellStyle12;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Amount
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.DefaultCellStyle = dataGridViewCellStyle13;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // NoExpenseMsg
            // 
            this.NoExpenseMsg.BackColor = System.Drawing.Color.Transparent;
            this.NoExpenseMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoExpenseMsg.Location = new System.Drawing.Point(305, 336);
            this.NoExpenseMsg.Name = "NoExpenseMsg";
            this.NoExpenseMsg.Size = new System.Drawing.Size(139, 30);
            this.NoExpenseMsg.TabIndex = 15;
            this.NoExpenseMsg.Text = "No Expense Yet";
            // 
            // AnimateForm
            // 
            this.AnimateForm.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            this.AnimateForm.Interval = 200;
            this.AnimateForm.TargetForm = this;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(28, 107);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(194, 34);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Add new Expense";
            // 
            // HistoryBtnToolTip
            // 
            this.HistoryBtnToolTip.AllowLinksHandling = true;
            this.HistoryBtnToolTip.AutoPopDelay = 5000;
            this.HistoryBtnToolTip.BorderColor = System.Drawing.Color.Transparent;
            this.HistoryBtnToolTip.ForeColor = System.Drawing.Color.DimGray;
            this.HistoryBtnToolTip.InitialDelay = 200;
            this.HistoryBtnToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.HistoryBtnToolTip.ReshowDelay = 100;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.AutoPopDelay = 5000;
            this.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2HtmlToolTip1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlToolTip1.InitialDelay = 200;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.ReshowDelay = 100;
            // 
            // guna2HtmlToolTip2
            // 
            this.guna2HtmlToolTip2.AllowLinksHandling = true;
            this.guna2HtmlToolTip2.AutoPopDelay = 5000;
            this.guna2HtmlToolTip2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2HtmlToolTip2.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlToolTip2.InitialDelay = 200;
            this.guna2HtmlToolTip2.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip2.ReshowDelay = 100;
            // 
            // EditToolTip
            // 
            this.EditToolTip.AllowLinksHandling = true;
            this.EditToolTip.AutoPopDelay = 5000;
            this.EditToolTip.BorderColor = System.Drawing.Color.Transparent;
            this.EditToolTip.ForeColor = System.Drawing.Color.DimGray;
            this.EditToolTip.InitialDelay = 200;
            this.EditToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.EditToolTip.ReshowDelay = 100;
            // 
            // DeleteToolTip
            // 
            this.DeleteToolTip.AllowLinksHandling = true;
            this.DeleteToolTip.BorderColor = System.Drawing.Color.Transparent;
            this.DeleteToolTip.ForeColor = System.Drawing.Color.DimGray;
            this.DeleteToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.HistoryPanel.BorderThickness = 2;
            this.HistoryPanel.Controls.Add(this.ExitHistoryPanel);
            this.HistoryPanel.Controls.Add(this.label2);
            this.HistoryPanel.Controls.Add(this.NoHistoryMsg);
            this.HistoryPanel.Controls.Add(this.ExpenseHistory);
            this.HistoryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HistoryPanel.Location = new System.Drawing.Point(0, 0);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Padding = new System.Windows.Forms.Padding(4);
            this.HistoryPanel.Size = new System.Drawing.Size(251, 491);
            this.HistoryPanel.TabIndex = 23;
            this.HistoryPanel.Visible = false;
            // 
            // ExitHistoryPanel
            // 
            this.ExitHistoryPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitHistoryPanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitHistoryPanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitHistoryPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitHistoryPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitHistoryPanel.FillColor = System.Drawing.Color.Transparent;
            this.ExitHistoryPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitHistoryPanel.ForeColor = System.Drawing.Color.White;
            this.ExitHistoryPanel.Image = global::Listrack.Properties.Resources.icons8_cross_50__1_;
            this.ExitHistoryPanel.ImageSize = new System.Drawing.Size(30, 30);
            this.ExitHistoryPanel.Location = new System.Drawing.Point(212, 1);
            this.ExitHistoryPanel.Name = "ExitHistoryPanel";
            this.ExitHistoryPanel.Size = new System.Drawing.Size(36, 36);
            this.ExitHistoryPanel.TabIndex = 15;
            this.ExitHistoryPanel.Click += new System.EventHandler(this.ExitHistoryPanel_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Expense History";
            // 
            // NoHistoryMsg
            // 
            this.NoHistoryMsg.AutoSize = true;
            this.NoHistoryMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoHistoryMsg.Location = new System.Drawing.Point(21, 244);
            this.NoHistoryMsg.Name = "NoHistoryMsg";
            this.NoHistoryMsg.Size = new System.Drawing.Size(195, 17);
            this.NoHistoryMsg.TabIndex = 1;
            this.NoHistoryMsg.Text = "There\'s nothing in your History";
            // 
            // ExpenseHistory
            // 
            this.ExpenseHistory.AllowUserToAddRows = false;
            this.ExpenseHistory.AllowUserToDeleteRows = false;
            this.ExpenseHistory.AllowUserToResizeColumns = false;
            this.ExpenseHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ExpenseHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpenseHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.ExpenseHistory.ColumnHeadersHeight = 37;
            this.ExpenseHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoryAmount,
            this.ActualDate});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpenseHistory.DefaultCellStyle = dataGridViewCellStyle19;
            this.ExpenseHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.ExpenseHistory.Location = new System.Drawing.Point(3, 107);
            this.ExpenseHistory.Name = "ExpenseHistory";
            this.ExpenseHistory.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.ExpenseHistory.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.ExpenseHistory.RowTemplate.Height = 25;
            this.ExpenseHistory.Size = new System.Drawing.Size(248, 384);
            this.ExpenseHistory.TabIndex = 17;
            this.ExpenseHistory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.ExpenseHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ExpenseHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ExpenseHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ExpenseHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ExpenseHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ExpenseHistory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ExpenseHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.ExpenseHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ExpenseHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ExpenseHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ExpenseHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ExpenseHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ExpenseHistory.ThemeStyle.HeaderStyle.Height = 37;
            this.ExpenseHistory.ThemeStyle.ReadOnly = false;
            this.ExpenseHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ExpenseHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExpenseHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpenseHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ExpenseHistory.ThemeStyle.RowsStyle.Height = 25;
            this.ExpenseHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.ExpenseHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // HistoryAmount
            // 
            this.HistoryAmount.HeaderText = "Amount";
            this.HistoryAmount.Name = "HistoryAmount";
            this.HistoryAmount.ReadOnly = true;
            // 
            // ActualDate
            // 
            this.ActualDate.HeaderText = "Actual Date";
            this.ActualDate.Name = "ActualDate";
            this.ActualDate.ReadOnly = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // resetBtn
            // 
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetBtn.FillColor = System.Drawing.Color.Transparent;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Image = global::Listrack.Properties.Resources.icons8_reset_50;
            this.resetBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.resetBtn.Location = new System.Drawing.Point(682, 12);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(36, 36);
            this.resetBtn.TabIndex = 25;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // resetBtnDisabled
            // 
            this.resetBtnDisabled.Cursor = System.Windows.Forms.Cursors.No;
            this.resetBtnDisabled.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetBtnDisabled.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetBtnDisabled.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetBtnDisabled.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetBtnDisabled.FillColor = System.Drawing.Color.Transparent;
            this.resetBtnDisabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetBtnDisabled.ForeColor = System.Drawing.Color.White;
            this.resetBtnDisabled.Image = global::Listrack.Properties.Resources.icons8_reset_50__1_;
            this.resetBtnDisabled.ImageSize = new System.Drawing.Size(30, 30);
            this.resetBtnDisabled.Location = new System.Drawing.Point(682, 12);
            this.resetBtnDisabled.Name = "resetBtnDisabled";
            this.resetBtnDisabled.Size = new System.Drawing.Size(36, 36);
            this.resetBtnDisabled.TabIndex = 24;
            // 
            // EditBtnDisabled
            // 
            this.EditBtnDisabled.Cursor = System.Windows.Forms.Cursors.No;
            this.EditBtnDisabled.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtnDisabled.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtnDisabled.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtnDisabled.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtnDisabled.FillColor = System.Drawing.Color.Transparent;
            this.EditBtnDisabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditBtnDisabled.ForeColor = System.Drawing.Color.White;
            this.EditBtnDisabled.Image = global::Listrack.Properties.Resources.icons8_pencil_24__1_;
            this.EditBtnDisabled.ImageSize = new System.Drawing.Size(30, 30);
            this.EditBtnDisabled.Location = new System.Drawing.Point(579, 123);
            this.EditBtnDisabled.Name = "EditBtnDisabled";
            this.EditBtnDisabled.Size = new System.Drawing.Size(36, 36);
            this.EditBtnDisabled.TabIndex = 13;
            // 
            // DeleteBtnDisabled
            // 
            this.DeleteBtnDisabled.Cursor = System.Windows.Forms.Cursors.No;
            this.DeleteBtnDisabled.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtnDisabled.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtnDisabled.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtnDisabled.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtnDisabled.FillColor = System.Drawing.Color.Transparent;
            this.DeleteBtnDisabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteBtnDisabled.ForeColor = System.Drawing.Color.White;
            this.DeleteBtnDisabled.Image = global::Listrack.Properties.Resources.icons8_delete_30__1_;
            this.DeleteBtnDisabled.ImageSize = new System.Drawing.Size(30, 30);
            this.DeleteBtnDisabled.Location = new System.Drawing.Point(530, 122);
            this.DeleteBtnDisabled.Name = "DeleteBtnDisabled";
            this.DeleteBtnDisabled.Size = new System.Drawing.Size(36, 36);
            this.DeleteBtnDisabled.TabIndex = 12;
            // 
            // EditBtn
            // 
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.Transparent;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Image = global::Listrack.Properties.Resources.icons8_pencil_24;
            this.EditBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.EditBtn.Location = new System.Drawing.Point(578, 123);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(36, 36);
            this.EditBtn.TabIndex = 10;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Image = global::Listrack.Properties.Resources.icons8_delete_30;
            this.DeleteBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.DeleteBtn.Location = new System.Drawing.Point(530, 122);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(36, 36);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.BorderRadius = 10;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = global::Listrack.Properties.Resources.icons8_add_50;
            this.AddBtn.Location = new System.Drawing.Point(542, 177);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(118, 42);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextFormatNoPrefix = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_2);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateBtn.BorderRadius = 10;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtn.FillColor = System.Drawing.Color.DarkOrange;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Image = global::Listrack.Properties.Resources.icons8_update_50;
            this.UpdateBtn.Location = new System.Drawing.Point(542, 177);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(118, 42);
            this.UpdateBtn.TabIndex = 16;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.TextFormatNoPrefix = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HistoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HistoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HistoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HistoryBtn.FillColor = System.Drawing.Color.Transparent;
            this.HistoryBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HistoryBtn.ForeColor = System.Drawing.Color.White;
            this.HistoryBtn.Image = global::Listrack.Properties.Resources.icons8_clock_50;
            this.HistoryBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.HistoryBtn.Location = new System.Drawing.Point(634, 123);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(36, 36);
            this.HistoryBtn.TabIndex = 11;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // HistoryBtnDisabled
            // 
            this.HistoryBtnDisabled.Cursor = System.Windows.Forms.Cursors.No;
            this.HistoryBtnDisabled.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HistoryBtnDisabled.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HistoryBtnDisabled.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HistoryBtnDisabled.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HistoryBtnDisabled.FillColor = System.Drawing.Color.Transparent;
            this.HistoryBtnDisabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HistoryBtnDisabled.ForeColor = System.Drawing.Color.White;
            this.HistoryBtnDisabled.Image = global::Listrack.Properties.Resources.icons8_clock_50__1_;
            this.HistoryBtnDisabled.ImageSize = new System.Drawing.Size(30, 30);
            this.HistoryBtnDisabled.Location = new System.Drawing.Point(634, 123);
            this.HistoryBtnDisabled.Name = "HistoryBtnDisabled";
            this.HistoryBtnDisabled.Size = new System.Drawing.Size(36, 36);
            this.HistoryBtnDisabled.TabIndex = 18;
            // 
            // ExpenseTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(730, 491);
            this.Controls.Add(this.HistoryPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.NoExpenseMsg);
            this.Controls.Add(this.ExpenseDataGrid);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.InputAmount);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.InputDesc);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.EditBtnDisabled);
            this.Controls.Add(this.DeleteBtnDisabled);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.HistoryBtn);
            this.Controls.Add(this.HistoryBtnDisabled);
            this.Controls.Add(this.resetBtnDisabled);
            this.Controls.Add(this.resetBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseTrackerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDataGrid)).EndInit();
            this.HistoryPanel.ResumeLayout(false);
            this.HistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox InputDesc;
        private Guna.UI2.WinForms.Guna2TextBox InputAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button HistoryBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtnDisabled;
        private Guna.UI2.WinForms.Guna2Button EditBtnDisabled;
        private DataGridView ExpenseDataGrid;
        private Guna.UI2.WinForms.Guna2HtmlLabel NoExpenseMsg;
        private Label CurrentDate;
        private Label SpendTotal;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2Button HistoryBtnDisabled;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlToolTip HistoryBtnToolTip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip2;
        private Guna.UI2.WinForms.Guna2HtmlToolTip EditToolTip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip DeleteToolTip;
        public Guna.UI2.WinForms.Guna2AnimateWindow AnimateForm;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Time;
        private Guna.UI2.WinForms.Guna2Panel HistoryPanel;
        private Guna.UI2.WinForms.Guna2Button ExitHistoryPanel;
        private Label label2;
        private Label NoHistoryMsg;
        private Guna.UI2.WinForms.Guna2DataGridView ExpenseHistory;
        private DataGridViewTextBoxColumn HistoryAmount;
        private DataGridViewTextBoxColumn ActualDate;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2Button resetBtnDisabled;
        private Guna.UI2.WinForms.Guna2Button resetBtn;
    }
}
