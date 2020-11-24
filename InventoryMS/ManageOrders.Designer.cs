namespace InventoryMS
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MO_minimise = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MO_close = new System.Windows.Forms.Label();
            this.MO_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CL_label = new System.Windows.Forms.Label();
            this.MO_customers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MO_OrderID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MO_CustID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MO_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date_label = new System.Windows.Forms.Label();
            this.MO_SearchCombo = new System.Windows.Forms.ComboBox();
            this.MO_CatData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MO_refreshButton = new System.Windows.Forms.Button();
            this.MO_quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.MO_addButton = new System.Windows.Forms.Button();
            this.MO_quantityData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MO_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.gbp = new System.Windows.Forms.Label();
            this.MO_insert = new System.Windows.Forms.Button();
            this.MO_view = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MO_delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MO_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MO_CatData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MO_quantityData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.MO_minimise);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MO_close);
            this.panel1.Controls.Add(this.MO_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 100);
            this.panel1.TabIndex = 3;
            // 
            // MO_minimise
            // 
            this.MO_minimise.AutoSize = true;
            this.MO_minimise.BackColor = System.Drawing.Color.Transparent;
            this.MO_minimise.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_minimise.ForeColor = System.Drawing.Color.White;
            this.MO_minimise.Location = new System.Drawing.Point(1024, -10);
            this.MO_minimise.Name = "MO_minimise";
            this.MO_minimise.Size = new System.Drawing.Size(26, 29);
            this.MO_minimise.TabIndex = 32;
            this.MO_minimise.Text = "_";
            this.MO_minimise.Click += new System.EventHandler(this.MO_minimise_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MO_close
            // 
            this.MO_close.AutoSize = true;
            this.MO_close.BackColor = System.Drawing.Color.Transparent;
            this.MO_close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_close.ForeColor = System.Drawing.Color.White;
            this.MO_close.Location = new System.Drawing.Point(1063, 0);
            this.MO_close.Name = "MO_close";
            this.MO_close.Size = new System.Drawing.Size(29, 29);
            this.MO_close.TabIndex = 1;
            this.MO_close.Text = "X";
            this.MO_close.Click += new System.EventHandler(this.MO_close_Click);
            // 
            // MO_title
            // 
            this.MO_title.AutoSize = true;
            this.MO_title.BackColor = System.Drawing.Color.Transparent;
            this.MO_title.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_title.ForeColor = System.Drawing.Color.White;
            this.MO_title.Location = new System.Drawing.Point(439, 25);
            this.MO_title.Name = "MO_title";
            this.MO_title.Size = new System.Drawing.Size(268, 41);
            this.MO_title.TabIndex = 0;
            this.MO_title.Text = "Manage Orders";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 853);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 15);
            this.panel2.TabIndex = 13;
            // 
            // CL_label
            // 
            this.CL_label.AutoSize = true;
            this.CL_label.BackColor = System.Drawing.Color.Transparent;
            this.CL_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CL_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CL_label.Location = new System.Drawing.Point(12, 108);
            this.CL_label.Name = "CL_label";
            this.CL_label.Size = new System.Drawing.Size(152, 24);
            this.CL_label.TabIndex = 14;
            this.CL_label.Text = "Customer List";
            // 
            // MO_customers
            // 
            this.MO_customers.AllowUserToAddRows = false;
            this.MO_customers.AllowUserToDeleteRows = false;
            this.MO_customers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MO_customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MO_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MO_customers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MO_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MO_customers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MO_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MO_customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MO_customers.ColumnHeadersHeight = 25;
            this.MO_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MO_customers.DefaultCellStyle = dataGridViewCellStyle3;
            this.MO_customers.EnableHeadersVisualStyles = false;
            this.MO_customers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MO_customers.Location = new System.Drawing.Point(16, 150);
            this.MO_customers.Name = "MO_customers";
            this.MO_customers.ReadOnly = true;
            this.MO_customers.RowHeadersVisible = false;
            this.MO_customers.RowTemplate.Height = 25;
            this.MO_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MO_customers.Size = new System.Drawing.Size(513, 239);
            this.MO_customers.TabIndex = 29;
            this.MO_customers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.MO_customers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MO_customers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MO_customers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MO_customers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MO_customers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MO_customers.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.MO_customers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MO_customers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MO_customers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MO_customers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_customers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MO_customers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MO_customers.ThemeStyle.HeaderStyle.Height = 25;
            this.MO_customers.ThemeStyle.ReadOnly = true;
            this.MO_customers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MO_customers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MO_customers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MO_customers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.MO_customers.ThemeStyle.RowsStyle.Height = 25;
            this.MO_customers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MO_customers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MO_customers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MO_customers_CellContentClick);
            // 
            // MO_OrderID
            // 
            this.MO_OrderID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MO_OrderID.Enabled = false;
            this.MO_OrderID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_OrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MO_OrderID.HintForeColor = System.Drawing.Color.Empty;
            this.MO_OrderID.HintText = "";
            this.MO_OrderID.isPassword = false;
            this.MO_OrderID.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MO_OrderID.LineIdleColor = System.Drawing.Color.Gray;
            this.MO_OrderID.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MO_OrderID.LineThickness = 3;
            this.MO_OrderID.Location = new System.Drawing.Point(560, 150);
            this.MO_OrderID.Margin = new System.Windows.Forms.Padding(4);
            this.MO_OrderID.Name = "MO_OrderID";
            this.MO_OrderID.Size = new System.Drawing.Size(212, 36);
            this.MO_OrderID.TabIndex = 30;
            this.MO_OrderID.Text = "Order ID";
            this.MO_OrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MO_CustID
            // 
            this.MO_CustID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MO_CustID.Enabled = false;
            this.MO_CustID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_CustID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MO_CustID.HintForeColor = System.Drawing.Color.Empty;
            this.MO_CustID.HintText = "";
            this.MO_CustID.isPassword = false;
            this.MO_CustID.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MO_CustID.LineIdleColor = System.Drawing.Color.Gray;
            this.MO_CustID.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MO_CustID.LineThickness = 3;
            this.MO_CustID.Location = new System.Drawing.Point(560, 208);
            this.MO_CustID.Margin = new System.Windows.Forms.Padding(4);
            this.MO_CustID.Name = "MO_CustID";
            this.MO_CustID.Size = new System.Drawing.Size(212, 36);
            this.MO_CustID.TabIndex = 31;
            this.MO_CustID.Text = "Customer ID";
            this.MO_CustID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MO_date
            // 
            this.MO_date.BorderColor = System.Drawing.Color.DimGray;
            this.MO_date.BorderThickness = 2;
            this.MO_date.CheckedState.Parent = this.MO_date;
            this.MO_date.FillColor = System.Drawing.SystemColors.Control;
            this.MO_date.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.MO_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.MO_date.HoverState.Parent = this.MO_date;
            this.MO_date.Location = new System.Drawing.Point(560, 339);
            this.MO_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.MO_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.MO_date.Name = "MO_date";
            this.MO_date.ShadowDecoration.Parent = this.MO_date;
            this.MO_date.Size = new System.Drawing.Size(212, 36);
            this.MO_date.TabIndex = 32;
            this.MO_date.Value = new System.DateTime(2020, 11, 21, 0, 0, 0, 0);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.BackColor = System.Drawing.Color.Transparent;
            this.date_label.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.date_label.Location = new System.Drawing.Point(557, 320);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(87, 18);
            this.date_label.TabIndex = 33;
            this.date_label.Text = "Order Date";
            // 
            // MO_SearchCombo
            // 
            this.MO_SearchCombo.BackColor = System.Drawing.SystemColors.Control;
            this.MO_SearchCombo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.MO_SearchCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MO_SearchCombo.FormattingEnabled = true;
            this.MO_SearchCombo.Location = new System.Drawing.Point(16, 408);
            this.MO_SearchCombo.Name = "MO_SearchCombo";
            this.MO_SearchCombo.Size = new System.Drawing.Size(212, 24);
            this.MO_SearchCombo.TabIndex = 35;
            this.MO_SearchCombo.Text = "Select Category";
            this.MO_SearchCombo.SelectionChangeCommitted += new System.EventHandler(this.MO_SearchCombo_SelectionChangeCommitted);
            // 
            // MO_CatData
            // 
            this.MO_CatData.AllowUserToAddRows = false;
            this.MO_CatData.AllowUserToDeleteRows = false;
            this.MO_CatData.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.MO_CatData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.MO_CatData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MO_CatData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MO_CatData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MO_CatData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MO_CatData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MO_CatData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MO_CatData.ColumnHeadersHeight = 25;
            this.MO_CatData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MO_CatData.DefaultCellStyle = dataGridViewCellStyle6;
            this.MO_CatData.EnableHeadersVisualStyles = false;
            this.MO_CatData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MO_CatData.Location = new System.Drawing.Point(16, 446);
            this.MO_CatData.Name = "MO_CatData";
            this.MO_CatData.ReadOnly = true;
            this.MO_CatData.RowHeadersVisible = false;
            this.MO_CatData.RowTemplate.Height = 25;
            this.MO_CatData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MO_CatData.Size = new System.Drawing.Size(513, 271);
            this.MO_CatData.TabIndex = 34;
            this.MO_CatData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.MO_CatData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MO_CatData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MO_CatData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MO_CatData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MO_CatData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MO_CatData.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.MO_CatData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MO_CatData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MO_CatData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MO_CatData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_CatData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MO_CatData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MO_CatData.ThemeStyle.HeaderStyle.Height = 25;
            this.MO_CatData.ThemeStyle.ReadOnly = true;
            this.MO_CatData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MO_CatData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MO_CatData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MO_CatData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.MO_CatData.ThemeStyle.RowsStyle.Height = 25;
            this.MO_CatData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MO_CatData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MO_CatData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MO_CatData_CellContentClick);
            this.MO_CatData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MO_CatData_CellContentClick);
            // 
            // MO_refreshButton
            // 
            this.MO_refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MO_refreshButton.BackgroundImage")));
            this.MO_refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MO_refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MO_refreshButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_refreshButton.ForeColor = System.Drawing.Color.White;
            this.MO_refreshButton.Location = new System.Drawing.Point(243, 408);
            this.MO_refreshButton.Name = "MO_refreshButton";
            this.MO_refreshButton.Size = new System.Drawing.Size(87, 24);
            this.MO_refreshButton.TabIndex = 36;
            this.MO_refreshButton.Text = "Refresh";
            this.MO_refreshButton.UseVisualStyleBackColor = true;
            this.MO_refreshButton.Click += new System.EventHandler(this.MO_refreshButton_Click);
            // 
            // MO_quantity
            // 
            this.MO_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MO_quantity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MO_quantity.HintForeColor = System.Drawing.Color.Empty;
            this.MO_quantity.HintText = "";
            this.MO_quantity.isPassword = false;
            this.MO_quantity.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MO_quantity.LineIdleColor = System.Drawing.Color.Gray;
            this.MO_quantity.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MO_quantity.LineThickness = 3;
            this.MO_quantity.Location = new System.Drawing.Point(560, 468);
            this.MO_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.MO_quantity.Name = "MO_quantity";
            this.MO_quantity.Size = new System.Drawing.Size(212, 36);
            this.MO_quantity.TabIndex = 37;
            this.MO_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.quantityLabel.Location = new System.Drawing.Point(557, 446);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(67, 18);
            this.quantityLabel.TabIndex = 38;
            this.quantityLabel.Text = "Quantity";
            // 
            // MO_addButton
            // 
            this.MO_addButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MO_addButton.Location = new System.Drawing.Point(781, 467);
            this.MO_addButton.Name = "MO_addButton";
            this.MO_addButton.Size = new System.Drawing.Size(112, 37);
            this.MO_addButton.TabIndex = 39;
            this.MO_addButton.Text = "Add to Order";
            this.MO_addButton.UseVisualStyleBackColor = true;
            this.MO_addButton.Click += new System.EventHandler(this.MO_addButton_Click);
            // 
            // MO_quantityData
            // 
            this.MO_quantityData.AllowUserToAddRows = false;
            this.MO_quantityData.AllowUserToDeleteRows = false;
            this.MO_quantityData.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.MO_quantityData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.MO_quantityData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MO_quantityData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MO_quantityData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MO_quantityData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MO_quantityData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MO_quantityData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.MO_quantityData.ColumnHeadersHeight = 25;
            this.MO_quantityData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MO_quantityData.DefaultCellStyle = dataGridViewCellStyle9;
            this.MO_quantityData.EnableHeadersVisualStyles = false;
            this.MO_quantityData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MO_quantityData.Location = new System.Drawing.Point(560, 507);
            this.MO_quantityData.Name = "MO_quantityData";
            this.MO_quantityData.ReadOnly = true;
            this.MO_quantityData.RowHeadersVisible = false;
            this.MO_quantityData.RowTemplate.Height = 25;
            this.MO_quantityData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MO_quantityData.Size = new System.Drawing.Size(532, 210);
            this.MO_quantityData.TabIndex = 40;
            this.MO_quantityData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.MO_quantityData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MO_quantityData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MO_quantityData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MO_quantityData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MO_quantityData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MO_quantityData.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.MO_quantityData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MO_quantityData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MO_quantityData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MO_quantityData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_quantityData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MO_quantityData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MO_quantityData.ThemeStyle.HeaderStyle.Height = 25;
            this.MO_quantityData.ThemeStyle.ReadOnly = true;
            this.MO_quantityData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MO_quantityData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MO_quantityData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MO_quantityData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.MO_quantityData.ThemeStyle.RowsStyle.Height = 25;
            this.MO_quantityData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MO_quantityData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MO_name
            // 
            this.MO_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MO_name.Enabled = false;
            this.MO_name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MO_name.HintForeColor = System.Drawing.Color.Empty;
            this.MO_name.HintText = "";
            this.MO_name.isPassword = false;
            this.MO_name.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MO_name.LineIdleColor = System.Drawing.Color.Gray;
            this.MO_name.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MO_name.LineThickness = 3;
            this.MO_name.Location = new System.Drawing.Point(560, 266);
            this.MO_name.Margin = new System.Windows.Forms.Padding(4);
            this.MO_name.Name = "MO_name";
            this.MO_name.Size = new System.Drawing.Size(212, 36);
            this.MO_name.TabIndex = 41;
            this.MO_name.Text = "Customer Name";
            this.MO_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalLabel.Location = new System.Drawing.Point(937, 720);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(93, 18);
            this.totalLabel.TabIndex = 42;
            this.totalLabel.Text = "Order Total:";
            // 
            // gbp
            // 
            this.gbp.AutoSize = true;
            this.gbp.BackColor = System.Drawing.Color.Transparent;
            this.gbp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbp.ForeColor = System.Drawing.Color.Red;
            this.gbp.Location = new System.Drawing.Point(1028, 720);
            this.gbp.Name = "gbp";
            this.gbp.Size = new System.Drawing.Size(16, 18);
            this.gbp.TabIndex = 43;
            this.gbp.Text = "£";
            // 
            // MO_insert
            // 
            this.MO_insert.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MO_insert.Location = new System.Drawing.Point(940, 753);
            this.MO_insert.Name = "MO_insert";
            this.MO_insert.Size = new System.Drawing.Size(152, 37);
            this.MO_insert.TabIndex = 44;
            this.MO_insert.Text = "Insert Order";
            this.MO_insert.UseVisualStyleBackColor = true;
            this.MO_insert.Click += new System.EventHandler(this.MO_insert_Click);
            // 
            // MO_view
            // 
            this.MO_view.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MO_view.Location = new System.Drawing.Point(16, 753);
            this.MO_view.Name = "MO_view";
            this.MO_view.Size = new System.Drawing.Size(112, 37);
            this.MO_view.TabIndex = 45;
            this.MO_view.Text = "View Orders";
            this.MO_view.UseVisualStyleBackColor = true;
            this.MO_view.Click += new System.EventHandler(this.MO_view_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(16, 796);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 37);
            this.button1.TabIndex = 46;
            this.button1.Text = "Return to Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MO_delete
            // 
            this.MO_delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MO_delete.Location = new System.Drawing.Point(899, 467);
            this.MO_delete.Name = "MO_delete";
            this.MO_delete.Size = new System.Drawing.Size(152, 37);
            this.MO_delete.TabIndex = 47;
            this.MO_delete.Text = "Delete Order";
            this.MO_delete.UseVisualStyleBackColor = true;
            this.MO_delete.Click += new System.EventHandler(this.MO_delete_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 868);
            this.Controls.Add(this.MO_delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MO_view);
            this.Controls.Add(this.MO_insert);
            this.Controls.Add(this.gbp);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.MO_name);
            this.Controls.Add(this.MO_quantityData);
            this.Controls.Add(this.MO_addButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.MO_quantity);
            this.Controls.Add(this.MO_refreshButton);
            this.Controls.Add(this.MO_SearchCombo);
            this.Controls.Add(this.MO_CatData);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.MO_date);
            this.Controls.Add(this.MO_CustID);
            this.Controls.Add(this.MO_OrderID);
            this.Controls.Add(this.MO_customers);
            this.Controls.Add(this.CL_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MO_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MO_CatData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MO_quantityData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MO_minimise;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MO_close;
        private System.Windows.Forms.Label MO_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CL_label;
        private Guna.UI2.WinForms.Guna2DataGridView MO_customers;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MO_OrderID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MO_CustID;
        private Guna.UI2.WinForms.Guna2DateTimePicker MO_date;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.ComboBox MO_SearchCombo;
        private Guna.UI2.WinForms.Guna2DataGridView MO_CatData;
        private System.Windows.Forms.Button MO_refreshButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MO_quantity;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button MO_addButton;
        private Guna.UI2.WinForms.Guna2DataGridView MO_quantityData;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MO_name;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label gbp;
        private System.Windows.Forms.Button MO_insert;
        private System.Windows.Forms.Button MO_view;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MO_delete;
    }
}