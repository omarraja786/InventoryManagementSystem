namespace InventoryMS
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MP_minimise = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MProd_close = new System.Windows.Forms.Label();
            this.MProd_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MP_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MP_quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MP_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MP_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MP_description = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MP_category = new System.Windows.Forms.ComboBox();
            this.MC_Home = new System.Windows.Forms.Button();
            this.MC_delete = new System.Windows.Forms.Button();
            this.MC_editButton = new System.Windows.Forms.Button();
            this.MC_addButton = new System.Windows.Forms.Button();
            this.MP_data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MP_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.MP_minimise);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MProd_close);
            this.panel1.Controls.Add(this.MProd_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 100);
            this.panel1.TabIndex = 2;
            // 
            // MP_minimise
            // 
            this.MP_minimise.AutoSize = true;
            this.MP_minimise.BackColor = System.Drawing.Color.Transparent;
            this.MP_minimise.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP_minimise.ForeColor = System.Drawing.Color.White;
            this.MP_minimise.Location = new System.Drawing.Point(748, -4);
            this.MP_minimise.Name = "MP_minimise";
            this.MP_minimise.Size = new System.Drawing.Size(26, 29);
            this.MP_minimise.TabIndex = 32;
            this.MP_minimise.Text = "_";
            this.MP_minimise.Click += new System.EventHandler(this.MP_minimise_Click);
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
            // MProd_close
            // 
            this.MProd_close.AutoSize = true;
            this.MProd_close.BackColor = System.Drawing.Color.Transparent;
            this.MProd_close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MProd_close.ForeColor = System.Drawing.Color.White;
            this.MProd_close.Location = new System.Drawing.Point(787, 6);
            this.MProd_close.Name = "MProd_close";
            this.MProd_close.Size = new System.Drawing.Size(29, 29);
            this.MProd_close.TabIndex = 1;
            this.MProd_close.Text = "X";
            this.MProd_close.Click += new System.EventHandler(this.MCat_close_Click);
            // 
            // MProd_title
            // 
            this.MProd_title.AutoSize = true;
            this.MProd_title.BackColor = System.Drawing.Color.Transparent;
            this.MProd_title.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MProd_title.ForeColor = System.Drawing.Color.White;
            this.MProd_title.Location = new System.Drawing.Point(261, 32);
            this.MProd_title.Name = "MProd_title";
            this.MProd_title.Size = new System.Drawing.Size(304, 41);
            this.MProd_title.TabIndex = 0;
            this.MProd_title.Text = "Manage Products";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 15);
            this.panel2.TabIndex = 12;
            // 
            // MP_price
            // 
            this.MP_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MP_price.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MP_price.HintForeColor = System.Drawing.Color.Empty;
            this.MP_price.HintText = "";
            this.MP_price.isPassword = false;
            this.MP_price.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MP_price.LineIdleColor = System.Drawing.Color.Gray;
            this.MP_price.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MP_price.LineThickness = 3;
            this.MP_price.Location = new System.Drawing.Point(14, 326);
            this.MP_price.Margin = new System.Windows.Forms.Padding(4);
            this.MP_price.Name = "MP_price";
            this.MP_price.Size = new System.Drawing.Size(212, 36);
            this.MP_price.TabIndex = 16;
            this.MP_price.Text = "Product Price";
            this.MP_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MP_quantity
            // 
            this.MP_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MP_quantity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MP_quantity.HintForeColor = System.Drawing.Color.Empty;
            this.MP_quantity.HintText = "";
            this.MP_quantity.isPassword = false;
            this.MP_quantity.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MP_quantity.LineIdleColor = System.Drawing.Color.Gray;
            this.MP_quantity.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MP_quantity.LineThickness = 3;
            this.MP_quantity.Location = new System.Drawing.Point(12, 265);
            this.MP_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.MP_quantity.Name = "MP_quantity";
            this.MP_quantity.Size = new System.Drawing.Size(212, 36);
            this.MP_quantity.TabIndex = 15;
            this.MP_quantity.Text = "Product Quantity";
            this.MP_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MP_name
            // 
            this.MP_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MP_name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MP_name.HintForeColor = System.Drawing.Color.Empty;
            this.MP_name.HintText = "";
            this.MP_name.isPassword = false;
            this.MP_name.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MP_name.LineIdleColor = System.Drawing.Color.Gray;
            this.MP_name.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MP_name.LineThickness = 3;
            this.MP_name.Location = new System.Drawing.Point(12, 202);
            this.MP_name.Margin = new System.Windows.Forms.Padding(4);
            this.MP_name.Name = "MP_name";
            this.MP_name.Size = new System.Drawing.Size(212, 36);
            this.MP_name.TabIndex = 14;
            this.MP_name.Text = "Product Name";
            this.MP_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MP_id
            // 
            this.MP_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MP_id.Enabled = false;
            this.MP_id.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MP_id.HintForeColor = System.Drawing.Color.Empty;
            this.MP_id.HintText = "";
            this.MP_id.isPassword = false;
            this.MP_id.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MP_id.LineIdleColor = System.Drawing.Color.Gray;
            this.MP_id.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MP_id.LineThickness = 3;
            this.MP_id.Location = new System.Drawing.Point(12, 139);
            this.MP_id.Margin = new System.Windows.Forms.Padding(4);
            this.MP_id.Name = "MP_id";
            this.MP_id.Size = new System.Drawing.Size(212, 36);
            this.MP_id.TabIndex = 13;
            this.MP_id.Text = "Product ID";
            this.MP_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MP_description
            // 
            this.MP_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MP_description.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MP_description.HintForeColor = System.Drawing.Color.Empty;
            this.MP_description.HintText = "";
            this.MP_description.isPassword = false;
            this.MP_description.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MP_description.LineIdleColor = System.Drawing.Color.Gray;
            this.MP_description.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MP_description.LineThickness = 3;
            this.MP_description.Location = new System.Drawing.Point(14, 387);
            this.MP_description.Margin = new System.Windows.Forms.Padding(4);
            this.MP_description.Name = "MP_description";
            this.MP_description.Size = new System.Drawing.Size(212, 36);
            this.MP_description.TabIndex = 17;
            this.MP_description.Text = "Description";
            this.MP_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MP_category
            // 
            this.MP_category.BackColor = System.Drawing.SystemColors.Control;
            this.MP_category.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.MP_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MP_category.FormattingEnabled = true;
            this.MP_category.Location = new System.Drawing.Point(14, 451);
            this.MP_category.Name = "MP_category";
            this.MP_category.Size = new System.Drawing.Size(212, 24);
            this.MP_category.TabIndex = 18;
            this.MP_category.Text = "Product Category";
            // 
            // MC_Home
            // 
            this.MC_Home.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_Home.Location = new System.Drawing.Point(16, 558);
            this.MC_Home.Name = "MC_Home";
            this.MC_Home.Size = new System.Drawing.Size(210, 36);
            this.MC_Home.TabIndex = 27;
            this.MC_Home.Text = "Return to Home";
            this.MC_Home.UseVisualStyleBackColor = true;
            this.MC_Home.Click += new System.EventHandler(this.MC_Home_Click);
            // 
            // MC_delete
            // 
            this.MC_delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_delete.Location = new System.Drawing.Point(154, 500);
            this.MC_delete.Name = "MC_delete";
            this.MC_delete.Size = new System.Drawing.Size(72, 36);
            this.MC_delete.TabIndex = 26;
            this.MC_delete.Text = "Delete";
            this.MC_delete.UseVisualStyleBackColor = true;
            this.MC_delete.Click += new System.EventHandler(this.MC_delete_Click);
            // 
            // MC_editButton
            // 
            this.MC_editButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_editButton.Location = new System.Drawing.Point(82, 500);
            this.MC_editButton.Name = "MC_editButton";
            this.MC_editButton.Size = new System.Drawing.Size(62, 36);
            this.MC_editButton.TabIndex = 25;
            this.MC_editButton.Text = "Edit";
            this.MC_editButton.UseVisualStyleBackColor = true;
            this.MC_editButton.Click += new System.EventHandler(this.MC_editButton_Click);
            // 
            // MC_addButton
            // 
            this.MC_addButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_addButton.Location = new System.Drawing.Point(14, 500);
            this.MC_addButton.Name = "MC_addButton";
            this.MC_addButton.Size = new System.Drawing.Size(62, 36);
            this.MC_addButton.TabIndex = 24;
            this.MC_addButton.Text = "Add";
            this.MC_addButton.UseVisualStyleBackColor = true;
            this.MC_addButton.Click += new System.EventHandler(this.MC_addButton_Click);
            // 
            // MP_data
            // 
            this.MP_data.AllowUserToAddRows = false;
            this.MP_data.AllowUserToDeleteRows = false;
            this.MP_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MP_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MP_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MP_data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MP_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MP_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MP_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MP_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MP_data.ColumnHeadersHeight = 25;
            this.MP_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MP_data.DefaultCellStyle = dataGridViewCellStyle3;
            this.MP_data.EnableHeadersVisualStyles = false;
            this.MP_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MP_data.Location = new System.Drawing.Point(255, 202);
            this.MP_data.Name = "MP_data";
            this.MP_data.ReadOnly = true;
            this.MP_data.RowHeadersVisible = false;
            this.MP_data.RowTemplate.Height = 25;
            this.MP_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MP_data.Size = new System.Drawing.Size(544, 392);
            this.MP_data.TabIndex = 28;
            this.MP_data.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.MP_data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MP_data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MP_data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MP_data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MP_data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MP_data.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.MP_data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MP_data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MP_data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MP_data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP_data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MP_data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MP_data.ThemeStyle.HeaderStyle.Height = 25;
            this.MP_data.ThemeStyle.ReadOnly = true;
            this.MP_data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MP_data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MP_data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MP_data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.MP_data.ThemeStyle.RowsStyle.Height = 25;
            this.MP_data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MP_data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MP_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MP_data_CellContentClick);
            // 
            // SearchCombo
            // 
            this.SearchCombo.BackColor = System.Drawing.SystemColors.Control;
            this.SearchCombo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.SearchCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(387, 139);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(212, 24);
            this.SearchCombo.TabIndex = 29;
            this.SearchCombo.Text = "Select Category";
            this.SearchCombo.SelectedIndexChanged += new System.EventHandler(this.SearchCombo_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(612, 139);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 24);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(712, 139);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(87, 24);
            this.refreshButton.TabIndex = 31;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 633);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.MP_data);
            this.Controls.Add(this.MC_Home);
            this.Controls.Add(this.MC_delete);
            this.Controls.Add(this.MC_editButton);
            this.Controls.Add(this.MC_addButton);
            this.Controls.Add(this.MP_category);
            this.Controls.Add(this.MP_description);
            this.Controls.Add(this.MP_price);
            this.Controls.Add(this.MP_quantity);
            this.Controls.Add(this.MP_name);
            this.Controls.Add(this.MP_id);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MP_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MProd_close;
        private System.Windows.Forms.Label MProd_title;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MP_price;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MP_quantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MP_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MP_id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MP_description;
        private System.Windows.Forms.ComboBox MP_category;
        private System.Windows.Forms.Button MC_Home;
        private System.Windows.Forms.Button MC_delete;
        private System.Windows.Forms.Button MC_editButton;
        private System.Windows.Forms.Button MC_addButton;
        private Guna.UI2.WinForms.Guna2DataGridView MP_data;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label MP_minimise;
    }
}