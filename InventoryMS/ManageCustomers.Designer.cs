namespace InventoryMS
{
    partial class ManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MP_minimise = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MU_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MC_telephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MC_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MC_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MC_data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MC_Home = new System.Windows.Forms.Button();
            this.MC_delete = new System.Windows.Forms.Button();
            this.MC_editButton = new System.Windows.Forms.Button();
            this.MC_addButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OC_Orders = new System.Windows.Forms.Label();
            this.orderCount_label = new System.Windows.Forms.Label();
            this.ordersAmount_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OA_Amount = new System.Windows.Forms.Label();
            this.LOD_label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LOD_Date = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MC_data)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.MP_minimise);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MU_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 100);
            this.panel1.TabIndex = 1;
            // 
            // MP_minimise
            // 
            this.MP_minimise.AutoSize = true;
            this.MP_minimise.BackColor = System.Drawing.Color.Transparent;
            this.MP_minimise.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP_minimise.ForeColor = System.Drawing.Color.White;
            this.MP_minimise.Location = new System.Drawing.Point(752, -4);
            this.MP_minimise.Name = "MP_minimise";
            this.MP_minimise.Size = new System.Drawing.Size(26, 29);
            this.MP_minimise.TabIndex = 33;
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
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MU_close
            // 
            this.MU_close.AutoSize = true;
            this.MU_close.BackColor = System.Drawing.Color.Transparent;
            this.MU_close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MU_close.ForeColor = System.Drawing.Color.White;
            this.MU_close.Location = new System.Drawing.Point(787, 6);
            this.MU_close.Name = "MU_close";
            this.MU_close.Size = new System.Drawing.Size(29, 29);
            this.MU_close.TabIndex = 1;
            this.MU_close.Text = "X";
            this.MU_close.Click += new System.EventHandler(this.MU_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Customers";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 15);
            this.panel2.TabIndex = 11;
            // 
            // MC_telephone
            // 
            this.MC_telephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MC_telephone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_telephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_telephone.HintForeColor = System.Drawing.Color.Empty;
            this.MC_telephone.HintText = "";
            this.MC_telephone.isPassword = false;
            this.MC_telephone.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MC_telephone.LineIdleColor = System.Drawing.Color.Gray;
            this.MC_telephone.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MC_telephone.LineThickness = 3;
            this.MC_telephone.Location = new System.Drawing.Point(13, 268);
            this.MC_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.MC_telephone.Name = "MC_telephone";
            this.MC_telephone.Size = new System.Drawing.Size(212, 36);
            this.MC_telephone.TabIndex = 14;
            this.MC_telephone.Text = "Telephone Number";
            this.MC_telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MC_name
            // 
            this.MC_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MC_name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_name.HintForeColor = System.Drawing.Color.Empty;
            this.MC_name.HintText = "";
            this.MC_name.isPassword = false;
            this.MC_name.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MC_name.LineIdleColor = System.Drawing.Color.Gray;
            this.MC_name.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MC_name.LineThickness = 3;
            this.MC_name.Location = new System.Drawing.Point(13, 205);
            this.MC_name.Margin = new System.Windows.Forms.Padding(4);
            this.MC_name.Name = "MC_name";
            this.MC_name.Size = new System.Drawing.Size(212, 36);
            this.MC_name.TabIndex = 13;
            this.MC_name.Text = "Customer Name";
            this.MC_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MC_id
            // 
            this.MC_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MC_id.Enabled = false;
            this.MC_id.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_id.HintForeColor = System.Drawing.Color.Empty;
            this.MC_id.HintText = "";
            this.MC_id.isPassword = false;
            this.MC_id.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MC_id.LineIdleColor = System.Drawing.Color.Gray;
            this.MC_id.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MC_id.LineThickness = 3;
            this.MC_id.Location = new System.Drawing.Point(13, 142);
            this.MC_id.Margin = new System.Windows.Forms.Padding(4);
            this.MC_id.Name = "MC_id";
            this.MC_id.Size = new System.Drawing.Size(212, 36);
            this.MC_id.TabIndex = 12;
            this.MC_id.Text = "Customer ID";
            this.MC_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MC_data
            // 
            this.MC_data.AllowUserToAddRows = false;
            this.MC_data.AllowUserToDeleteRows = false;
            this.MC_data.AllowUserToResizeColumns = false;
            this.MC_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MC_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MC_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MC_data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MC_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MC_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MC_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MC_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MC_data.ColumnHeadersHeight = 25;
            this.MC_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MC_data.DefaultCellStyle = dataGridViewCellStyle3;
            this.MC_data.EnableHeadersVisualStyles = false;
            this.MC_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MC_data.Location = new System.Drawing.Point(249, 142);
            this.MC_data.Name = "MC_data";
            this.MC_data.ReadOnly = true;
            this.MC_data.RowHeadersVisible = false;
            this.MC_data.RowTemplate.Height = 25;
            this.MC_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MC_data.Size = new System.Drawing.Size(544, 378);
            this.MC_data.TabIndex = 15;
            this.MC_data.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.MC_data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MC_data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MC_data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MC_data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MC_data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MC_data.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.MC_data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MC_data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MC_data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MC_data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MC_data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MC_data.ThemeStyle.HeaderStyle.Height = 25;
            this.MC_data.ThemeStyle.ReadOnly = true;
            this.MC_data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MC_data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MC_data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MC_data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.MC_data.ThemeStyle.RowsStyle.Height = 25;
            this.MC_data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MC_data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MC_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MC_data_CellContentClick);
            this.MC_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MC_data_CellContentClick);
            // 
            // MC_Home
            // 
            this.MC_Home.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_Home.Location = new System.Drawing.Point(15, 397);
            this.MC_Home.Name = "MC_Home";
            this.MC_Home.Size = new System.Drawing.Size(210, 36);
            this.MC_Home.TabIndex = 19;
            this.MC_Home.Text = "Return to Home";
            this.MC_Home.UseVisualStyleBackColor = true;
            this.MC_Home.Click += new System.EventHandler(this.MC_Home_Click);
            // 
            // MC_delete
            // 
            this.MC_delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_delete.Location = new System.Drawing.Point(153, 339);
            this.MC_delete.Name = "MC_delete";
            this.MC_delete.Size = new System.Drawing.Size(72, 36);
            this.MC_delete.TabIndex = 18;
            this.MC_delete.Text = "Delete";
            this.MC_delete.UseVisualStyleBackColor = true;
            this.MC_delete.Click += new System.EventHandler(this.MC_delete_Click);
            // 
            // MC_editButton
            // 
            this.MC_editButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_editButton.Location = new System.Drawing.Point(81, 339);
            this.MC_editButton.Name = "MC_editButton";
            this.MC_editButton.Size = new System.Drawing.Size(62, 36);
            this.MC_editButton.TabIndex = 17;
            this.MC_editButton.Text = "Edit";
            this.MC_editButton.UseVisualStyleBackColor = true;
            this.MC_editButton.Click += new System.EventHandler(this.MC_editButton_Click);
            // 
            // MC_addButton
            // 
            this.MC_addButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_addButton.Location = new System.Drawing.Point(13, 339);
            this.MC_addButton.Name = "MC_addButton";
            this.MC_addButton.Size = new System.Drawing.Size(62, 36);
            this.MC_addButton.TabIndex = 16;
            this.MC_addButton.Text = "Add";
            this.MC_addButton.UseVisualStyleBackColor = true;
            this.MC_addButton.Click += new System.EventHandler(this.MC_addButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.OC_Orders);
            this.panel3.Controls.Add(this.orderCount_label);
            this.panel3.Location = new System.Drawing.Point(15, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 78);
            this.panel3.TabIndex = 25;
            // 
            // OC_Orders
            // 
            this.OC_Orders.AutoSize = true;
            this.OC_Orders.BackColor = System.Drawing.Color.Transparent;
            this.OC_Orders.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OC_Orders.ForeColor = System.Drawing.Color.White;
            this.OC_Orders.Location = new System.Drawing.Point(61, 31);
            this.OC_Orders.Name = "OC_Orders";
            this.OC_Orders.Size = new System.Drawing.Size(90, 29);
            this.OC_Orders.TabIndex = 27;
            this.OC_Orders.Text = "Orders";
            // 
            // orderCount_label
            // 
            this.orderCount_label.AutoSize = true;
            this.orderCount_label.BackColor = System.Drawing.Color.Transparent;
            this.orderCount_label.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCount_label.ForeColor = System.Drawing.Color.White;
            this.orderCount_label.Location = new System.Drawing.Point(27, 7);
            this.orderCount_label.Name = "orderCount_label";
            this.orderCount_label.Size = new System.Drawing.Size(112, 19);
            this.orderCount_label.TabIndex = 26;
            this.orderCount_label.Text = "Orders Count";
            // 
            // ordersAmount_label
            // 
            this.ordersAmount_label.AutoSize = true;
            this.ordersAmount_label.BackColor = System.Drawing.Color.Transparent;
            this.ordersAmount_label.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersAmount_label.ForeColor = System.Drawing.Color.White;
            this.ordersAmount_label.Location = new System.Drawing.Point(24, 7);
            this.ordersAmount_label.Name = "ordersAmount_label";
            this.ordersAmount_label.Size = new System.Drawing.Size(124, 19);
            this.ordersAmount_label.TabIndex = 26;
            this.ordersAmount_label.Text = "Orders Amount";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.OA_Amount);
            this.panel4.Controls.Add(this.ordersAmount_label);
            this.panel4.Location = new System.Drawing.Point(325, 531);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 78);
            this.panel4.TabIndex = 26;
            // 
            // OA_Amount
            // 
            this.OA_Amount.AutoSize = true;
            this.OA_Amount.BackColor = System.Drawing.Color.Transparent;
            this.OA_Amount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OA_Amount.ForeColor = System.Drawing.Color.White;
            this.OA_Amount.Location = new System.Drawing.Point(56, 31);
            this.OA_Amount.Name = "OA_Amount";
            this.OA_Amount.Size = new System.Drawing.Size(104, 29);
            this.OA_Amount.TabIndex = 28;
            this.OA_Amount.Text = "Amount";
            // 
            // LOD_label
            // 
            this.LOD_label.AutoSize = true;
            this.LOD_label.BackColor = System.Drawing.Color.Transparent;
            this.LOD_label.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOD_label.ForeColor = System.Drawing.Color.White;
            this.LOD_label.Location = new System.Drawing.Point(23, 7);
            this.LOD_label.Name = "LOD_label";
            this.LOD_label.Size = new System.Drawing.Size(128, 19);
            this.LOD_label.TabIndex = 26;
            this.LOD_label.Text = "Last Order Date";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.LOD_Date);
            this.panel5.Controls.Add(this.LOD_label);
            this.panel5.Location = new System.Drawing.Point(620, 531);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 78);
            this.panel5.TabIndex = 27;
            // 
            // LOD_Date
            // 
            this.LOD_Date.AutoSize = true;
            this.LOD_Date.BackColor = System.Drawing.Color.Transparent;
            this.LOD_Date.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOD_Date.ForeColor = System.Drawing.Color.White;
            this.LOD_Date.Location = new System.Drawing.Point(36, 31);
            this.LOD_Date.Name = "LOD_Date";
            this.LOD_Date.Size = new System.Drawing.Size(64, 29);
            this.LOD_Date.TabIndex = 29;
            this.LOD_Date.Text = "Date";
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 633);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MC_Home);
            this.Controls.Add(this.MC_delete);
            this.Controls.Add(this.MC_editButton);
            this.Controls.Add(this.MC_addButton);
            this.Controls.Add(this.MC_data);
            this.Controls.Add(this.MC_telephone);
            this.Controls.Add(this.MC_name);
            this.Controls.Add(this.MC_id);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MC_data)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MU_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MC_telephone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MC_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MC_id;
        private Guna.UI2.WinForms.Guna2DataGridView MC_data;
        private System.Windows.Forms.Button MC_Home;
        private System.Windows.Forms.Button MC_delete;
        private System.Windows.Forms.Button MC_editButton;
        private System.Windows.Forms.Button MC_addButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label OC_Orders;
        private System.Windows.Forms.Label orderCount_label;
        private System.Windows.Forms.Label ordersAmount_label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LOD_label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label OA_Amount;
        private System.Windows.Forms.Label LOD_Date;
        private System.Windows.Forms.Label MP_minimise;
    }
}