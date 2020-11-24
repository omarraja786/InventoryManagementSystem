namespace InventoryMS
{
    partial class ManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MCat_close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MP_minimise = new System.Windows.Forms.Label();
            this.MCat_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MCat_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MCat_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MCat_data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MC_Home = new System.Windows.Forms.Button();
            this.MC_delete = new System.Windows.Forms.Button();
            this.MC_editButton = new System.Windows.Forms.Button();
            this.MC_addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MCat_data)).BeginInit();
            this.SuspendLayout();
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
            // MCat_close
            // 
            this.MCat_close.AutoSize = true;
            this.MCat_close.BackColor = System.Drawing.Color.Transparent;
            this.MCat_close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCat_close.ForeColor = System.Drawing.Color.White;
            this.MCat_close.Location = new System.Drawing.Point(787, 6);
            this.MCat_close.Name = "MCat_close";
            this.MCat_close.Size = new System.Drawing.Size(29, 29);
            this.MCat_close.TabIndex = 1;
            this.MCat_close.Text = "X";
            this.MCat_close.Click += new System.EventHandler(this.MU_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.MP_minimise);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MCat_close);
            this.panel1.Controls.Add(this.MCat_title);
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
            this.MP_minimise.Location = new System.Drawing.Point(748, -3);
            this.MP_minimise.Name = "MP_minimise";
            this.MP_minimise.Size = new System.Drawing.Size(26, 29);
            this.MP_minimise.TabIndex = 33;
            this.MP_minimise.Text = "_";
            this.MP_minimise.Click += new System.EventHandler(this.MP_minimise_Click);
            // 
            // MCat_title
            // 
            this.MCat_title.AutoSize = true;
            this.MCat_title.BackColor = System.Drawing.Color.Transparent;
            this.MCat_title.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCat_title.ForeColor = System.Drawing.Color.White;
            this.MCat_title.Location = new System.Drawing.Point(261, 32);
            this.MCat_title.Name = "MCat_title";
            this.MCat_title.Size = new System.Drawing.Size(333, 41);
            this.MCat_title.TabIndex = 0;
            this.MCat_title.Text = "Manage Categories";
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
            // MCat_name
            // 
            this.MCat_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MCat_name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCat_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MCat_name.HintForeColor = System.Drawing.Color.Empty;
            this.MCat_name.HintText = "";
            this.MCat_name.isPassword = false;
            this.MCat_name.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MCat_name.LineIdleColor = System.Drawing.Color.Gray;
            this.MCat_name.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MCat_name.LineThickness = 3;
            this.MCat_name.Location = new System.Drawing.Point(13, 209);
            this.MCat_name.Margin = new System.Windows.Forms.Padding(4);
            this.MCat_name.Name = "MCat_name";
            this.MCat_name.Size = new System.Drawing.Size(212, 36);
            this.MCat_name.TabIndex = 15;
            this.MCat_name.Text = "Catagory Name";
            this.MCat_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MCat_id
            // 
            this.MCat_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MCat_id.Enabled = false;
            this.MCat_id.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCat_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MCat_id.HintForeColor = System.Drawing.Color.Empty;
            this.MCat_id.HintText = "";
            this.MCat_id.isPassword = false;
            this.MCat_id.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.MCat_id.LineIdleColor = System.Drawing.Color.Gray;
            this.MCat_id.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.MCat_id.LineThickness = 3;
            this.MCat_id.Location = new System.Drawing.Point(13, 146);
            this.MCat_id.Margin = new System.Windows.Forms.Padding(4);
            this.MCat_id.Name = "MCat_id";
            this.MCat_id.Size = new System.Drawing.Size(212, 36);
            this.MCat_id.TabIndex = 14;
            this.MCat_id.Text = "Category ID";
            this.MCat_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MCat_data
            // 
            this.MCat_data.AllowUserToAddRows = false;
            this.MCat_data.AllowUserToDeleteRows = false;
            this.MCat_data.AllowUserToResizeColumns = false;
            this.MCat_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MCat_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MCat_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MCat_data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MCat_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MCat_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MCat_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MCat_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MCat_data.ColumnHeadersHeight = 25;
            this.MCat_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MCat_data.DefaultCellStyle = dataGridViewCellStyle3;
            this.MCat_data.EnableHeadersVisualStyles = false;
            this.MCat_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MCat_data.Location = new System.Drawing.Point(253, 146);
            this.MCat_data.Name = "MCat_data";
            this.MCat_data.ReadOnly = true;
            this.MCat_data.RowHeadersVisible = false;
            this.MCat_data.RowTemplate.Height = 25;
            this.MCat_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MCat_data.Size = new System.Drawing.Size(544, 447);
            this.MCat_data.TabIndex = 16;
            this.MCat_data.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.MCat_data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MCat_data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MCat_data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MCat_data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MCat_data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MCat_data.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.MCat_data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MCat_data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MCat_data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MCat_data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCat_data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MCat_data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MCat_data.ThemeStyle.HeaderStyle.Height = 25;
            this.MCat_data.ThemeStyle.ReadOnly = true;
            this.MCat_data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MCat_data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MCat_data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MCat_data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.MCat_data.ThemeStyle.RowsStyle.Height = 25;
            this.MCat_data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MCat_data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MCat_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MCat_data_CellContentClick);
            // 
            // MC_Home
            // 
            this.MC_Home.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_Home.Location = new System.Drawing.Point(15, 337);
            this.MC_Home.Name = "MC_Home";
            this.MC_Home.Size = new System.Drawing.Size(210, 36);
            this.MC_Home.TabIndex = 23;
            this.MC_Home.Text = "Return to Home";
            this.MC_Home.UseVisualStyleBackColor = true;
            this.MC_Home.Click += new System.EventHandler(this.MC_Home_Click);
            // 
            // MC_delete
            // 
            this.MC_delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_delete.Location = new System.Drawing.Point(153, 279);
            this.MC_delete.Name = "MC_delete";
            this.MC_delete.Size = new System.Drawing.Size(72, 36);
            this.MC_delete.TabIndex = 22;
            this.MC_delete.Text = "Delete";
            this.MC_delete.UseVisualStyleBackColor = true;
            this.MC_delete.Click += new System.EventHandler(this.MC_delete_Click);
            // 
            // MC_editButton
            // 
            this.MC_editButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_editButton.Location = new System.Drawing.Point(81, 279);
            this.MC_editButton.Name = "MC_editButton";
            this.MC_editButton.Size = new System.Drawing.Size(62, 36);
            this.MC_editButton.TabIndex = 21;
            this.MC_editButton.Text = "Edit";
            this.MC_editButton.UseVisualStyleBackColor = true;
            this.MC_editButton.Click += new System.EventHandler(this.MC_editButton_Click);
            // 
            // MC_addButton
            // 
            this.MC_addButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MC_addButton.Location = new System.Drawing.Point(13, 279);
            this.MC_addButton.Name = "MC_addButton";
            this.MC_addButton.Size = new System.Drawing.Size(62, 36);
            this.MC_addButton.TabIndex = 20;
            this.MC_addButton.Text = "Add";
            this.MC_addButton.UseVisualStyleBackColor = true;
            this.MC_addButton.Click += new System.EventHandler(this.MC_addButton_Click);
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 633);
            this.Controls.Add(this.MC_Home);
            this.Controls.Add(this.MC_delete);
            this.Controls.Add(this.MC_editButton);
            this.Controls.Add(this.MC_addButton);
            this.Controls.Add(this.MCat_data);
            this.Controls.Add(this.MCat_name);
            this.Controls.Add(this.MCat_id);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MCat_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MCat_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MCat_title;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MCat_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MCat_id;
        private Guna.UI2.WinForms.Guna2DataGridView MCat_data;
        private System.Windows.Forms.Button MC_Home;
        private System.Windows.Forms.Button MC_delete;
        private System.Windows.Forms.Button MC_editButton;
        private System.Windows.Forms.Button MC_addButton;
        private System.Windows.Forms.Label MP_minimise;
    }
}