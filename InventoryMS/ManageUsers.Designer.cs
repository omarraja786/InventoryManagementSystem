namespace InventoryMS
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MP_minimise = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MU_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MU_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MU_fullName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MU_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MU_telephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MU_addButton = new System.Windows.Forms.Button();
            this.MU_editButton = new System.Windows.Forms.Button();
            this.MU_delete = new System.Windows.Forms.Button();
            this.MU_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MU_data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MU_data)).BeginInit();
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
            this.panel1.TabIndex = 0;
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
            this.pictureBox1.TabIndex = 12;
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
            this.label1.Location = new System.Drawing.Point(275, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Users";
            // 
            // MU_username
            // 
            this.MU_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MU_username.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MU_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MU_username.HintForeColor = System.Drawing.Color.Empty;
            this.MU_username.HintText = "";
            this.MU_username.isPassword = false;
            this.MU_username.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MU_username.LineIdleColor = System.Drawing.Color.Gray;
            this.MU_username.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MU_username.LineThickness = 3;
            this.MU_username.Location = new System.Drawing.Point(11, 141);
            this.MU_username.Margin = new System.Windows.Forms.Padding(4);
            this.MU_username.Name = "MU_username";
            this.MU_username.Size = new System.Drawing.Size(212, 36);
            this.MU_username.TabIndex = 1;
            this.MU_username.Text = "Username";
            this.MU_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MU_username.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // MU_fullName
            // 
            this.MU_fullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MU_fullName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MU_fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MU_fullName.HintForeColor = System.Drawing.Color.Empty;
            this.MU_fullName.HintText = "";
            this.MU_fullName.isPassword = false;
            this.MU_fullName.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MU_fullName.LineIdleColor = System.Drawing.Color.Gray;
            this.MU_fullName.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MU_fullName.LineThickness = 3;
            this.MU_fullName.Location = new System.Drawing.Point(11, 204);
            this.MU_fullName.Margin = new System.Windows.Forms.Padding(4);
            this.MU_fullName.Name = "MU_fullName";
            this.MU_fullName.Size = new System.Drawing.Size(212, 36);
            this.MU_fullName.TabIndex = 2;
            this.MU_fullName.Text = "Full Name";
            this.MU_fullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MU_Password
            // 
            this.MU_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MU_Password.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MU_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MU_Password.HintForeColor = System.Drawing.Color.Empty;
            this.MU_Password.HintText = "";
            this.MU_Password.isPassword = false;
            this.MU_Password.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MU_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.MU_Password.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MU_Password.LineThickness = 3;
            this.MU_Password.Location = new System.Drawing.Point(11, 267);
            this.MU_Password.Margin = new System.Windows.Forms.Padding(4);
            this.MU_Password.Name = "MU_Password";
            this.MU_Password.Size = new System.Drawing.Size(212, 36);
            this.MU_Password.TabIndex = 3;
            this.MU_Password.Text = "Password";
            this.MU_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MU_telephone
            // 
            this.MU_telephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MU_telephone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MU_telephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MU_telephone.HintForeColor = System.Drawing.Color.Empty;
            this.MU_telephone.HintText = "";
            this.MU_telephone.isPassword = false;
            this.MU_telephone.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MU_telephone.LineIdleColor = System.Drawing.Color.Gray;
            this.MU_telephone.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MU_telephone.LineThickness = 3;
            this.MU_telephone.Location = new System.Drawing.Point(13, 328);
            this.MU_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.MU_telephone.Name = "MU_telephone";
            this.MU_telephone.Size = new System.Drawing.Size(212, 36);
            this.MU_telephone.TabIndex = 4;
            this.MU_telephone.Text = "Telephone Number";
            this.MU_telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MU_addButton
            // 
            this.MU_addButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MU_addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MU_addButton.Location = new System.Drawing.Point(11, 403);
            this.MU_addButton.Name = "MU_addButton";
            this.MU_addButton.Size = new System.Drawing.Size(62, 36);
            this.MU_addButton.TabIndex = 5;
            this.MU_addButton.Text = "Add";
            this.MU_addButton.UseVisualStyleBackColor = true;
            this.MU_addButton.Click += new System.EventHandler(this.MU_addButton_Click);
            // 
            // MU_editButton
            // 
            this.MU_editButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MU_editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MU_editButton.Location = new System.Drawing.Point(79, 403);
            this.MU_editButton.Name = "MU_editButton";
            this.MU_editButton.Size = new System.Drawing.Size(62, 36);
            this.MU_editButton.TabIndex = 6;
            this.MU_editButton.Text = "Edit";
            this.MU_editButton.UseVisualStyleBackColor = true;
            this.MU_editButton.Click += new System.EventHandler(this.MU_editButton_Click);
            // 
            // MU_delete
            // 
            this.MU_delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MU_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MU_delete.Location = new System.Drawing.Point(151, 403);
            this.MU_delete.Name = "MU_delete";
            this.MU_delete.Size = new System.Drawing.Size(72, 36);
            this.MU_delete.TabIndex = 7;
            this.MU_delete.Text = "Delete";
            this.MU_delete.UseVisualStyleBackColor = true;
            this.MU_delete.Click += new System.EventHandler(this.MU_delete_Click);
            // 
            // MU_Home
            // 
            this.MU_Home.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MU_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MU_Home.Location = new System.Drawing.Point(13, 461);
            this.MU_Home.Name = "MU_Home";
            this.MU_Home.Size = new System.Drawing.Size(210, 36);
            this.MU_Home.TabIndex = 8;
            this.MU_Home.Text = "Return to Home";
            this.MU_Home.UseVisualStyleBackColor = true;
            this.MU_Home.Click += new System.EventHandler(this.MU_Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 15);
            this.panel2.TabIndex = 10;
            // 
            // MU_data
            // 
            this.MU_data.AllowUserToAddRows = false;
            this.MU_data.AllowUserToDeleteRows = false;
            this.MU_data.AllowUserToResizeColumns = false;
            this.MU_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MU_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MU_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MU_data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MU_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MU_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MU_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MU_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MU_data.ColumnHeadersHeight = 25;
            this.MU_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MU_data.DefaultCellStyle = dataGridViewCellStyle3;
            this.MU_data.EnableHeadersVisualStyles = false;
            this.MU_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MU_data.Location = new System.Drawing.Point(255, 141);
            this.MU_data.Name = "MU_data";
            this.MU_data.ReadOnly = true;
            this.MU_data.RowHeadersVisible = false;
            this.MU_data.RowTemplate.Height = 25;
            this.MU_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MU_data.Size = new System.Drawing.Size(544, 460);
            this.MU_data.TabIndex = 11;
            this.MU_data.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.MU_data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MU_data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MU_data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MU_data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MU_data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MU_data.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.MU_data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MU_data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MU_data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MU_data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MU_data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MU_data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MU_data.ThemeStyle.HeaderStyle.Height = 25;
            this.MU_data.ThemeStyle.ReadOnly = true;
            this.MU_data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MU_data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MU_data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MU_data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.MU_data.ThemeStyle.RowsStyle.Height = 25;
            this.MU_data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MU_data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MU_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MU_data_CellContentClick_1);
            this.MU_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MU_data_CellContentClick_1);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 633);
            this.Controls.Add(this.MU_data);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MU_Home);
            this.Controls.Add(this.MU_delete);
            this.Controls.Add(this.MU_editButton);
            this.Controls.Add(this.MU_addButton);
            this.Controls.Add(this.MU_telephone);
            this.Controls.Add(this.MU_Password);
            this.Controls.Add(this.MU_fullName);
            this.Controls.Add(this.MU_username);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MU_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MU_username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MU_fullName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MU_Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MU_telephone;
        private System.Windows.Forms.Button MU_addButton;
        private System.Windows.Forms.Button MU_editButton;
        private System.Windows.Forms.Button MU_delete;
        private System.Windows.Forms.Button MU_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MU_close;
        private Guna.UI2.WinForms.Guna2DataGridView MU_data;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MP_minimise;
    }
}