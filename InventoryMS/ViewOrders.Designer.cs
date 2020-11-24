namespace InventoryMS
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VO_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VO_minimise = new System.Windows.Forms.Label();
            this.VO_close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VO_data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.VO_delete = new System.Windows.Forms.Button();
            this.VO_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VO_data)).BeginInit();
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
            // VO_title
            // 
            this.VO_title.AutoSize = true;
            this.VO_title.BackColor = System.Drawing.Color.Transparent;
            this.VO_title.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_title.ForeColor = System.Drawing.Color.White;
            this.VO_title.Location = new System.Drawing.Point(287, 34);
            this.VO_title.Name = "VO_title";
            this.VO_title.Size = new System.Drawing.Size(220, 41);
            this.VO_title.TabIndex = 0;
            this.VO_title.Text = "View Orders";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.VO_minimise);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.VO_close);
            this.panel1.Controls.Add(this.VO_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 100);
            this.panel1.TabIndex = 3;
            // 
            // VO_minimise
            // 
            this.VO_minimise.AutoSize = true;
            this.VO_minimise.BackColor = System.Drawing.Color.Transparent;
            this.VO_minimise.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_minimise.ForeColor = System.Drawing.Color.White;
            this.VO_minimise.Location = new System.Drawing.Point(748, -4);
            this.VO_minimise.Name = "VO_minimise";
            this.VO_minimise.Size = new System.Drawing.Size(26, 29);
            this.VO_minimise.TabIndex = 32;
            this.VO_minimise.Text = "_";
            this.VO_minimise.Click += new System.EventHandler(this.VO_minimise_Click);
            // 
            // VO_close
            // 
            this.VO_close.AutoSize = true;
            this.VO_close.BackColor = System.Drawing.Color.Transparent;
            this.VO_close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_close.ForeColor = System.Drawing.Color.White;
            this.VO_close.Location = new System.Drawing.Point(787, 6);
            this.VO_close.Name = "VO_close";
            this.VO_close.Size = new System.Drawing.Size(29, 29);
            this.VO_close.TabIndex = 1;
            this.VO_close.Text = "X";
            this.VO_close.Click += new System.EventHandler(this.VO_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 15);
            this.panel2.TabIndex = 13;
            // 
            // VO_data
            // 
            this.VO_data.AllowUserToAddRows = false;
            this.VO_data.AllowUserToDeleteRows = false;
            this.VO_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.VO_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.VO_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VO_data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.VO_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VO_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VO_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VO_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.VO_data.ColumnHeadersHeight = 25;
            this.VO_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VO_data.DefaultCellStyle = dataGridViewCellStyle9;
            this.VO_data.EnableHeadersVisualStyles = false;
            this.VO_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VO_data.Location = new System.Drawing.Point(74, 117);
            this.VO_data.Name = "VO_data";
            this.VO_data.ReadOnly = true;
            this.VO_data.RowHeadersVisible = false;
            this.VO_data.RowTemplate.Height = 25;
            this.VO_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VO_data.Size = new System.Drawing.Size(681, 443);
            this.VO_data.TabIndex = 41;
            this.VO_data.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.VO_data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.VO_data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.VO_data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.VO_data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.VO_data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.VO_data.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.VO_data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VO_data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.VO_data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VO_data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.VO_data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.VO_data.ThemeStyle.HeaderStyle.Height = 25;
            this.VO_data.ThemeStyle.ReadOnly = true;
            this.VO_data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.VO_data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VO_data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.VO_data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.VO_data.ThemeStyle.RowsStyle.Height = 25;
            this.VO_data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VO_data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.VO_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VO_data_CellContentClick);
            this.VO_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VO_data_CellContentClick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // VO_delete
            // 
            this.VO_delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VO_delete.Location = new System.Drawing.Point(74, 566);
            this.VO_delete.Name = "VO_delete";
            this.VO_delete.Size = new System.Drawing.Size(152, 37);
            this.VO_delete.TabIndex = 45;
            this.VO_delete.Text = "Delete Order";
            this.VO_delete.UseVisualStyleBackColor = true;
            this.VO_delete.Click += new System.EventHandler(this.VO_delete_Click);
            // 
            // VO_print
            // 
            this.VO_print.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VO_print.Location = new System.Drawing.Point(603, 566);
            this.VO_print.Name = "VO_print";
            this.VO_print.Size = new System.Drawing.Size(152, 37);
            this.VO_print.TabIndex = 46;
            this.VO_print.Text = "Print Order";
            this.VO_print.UseVisualStyleBackColor = true;
            this.VO_print.Click += new System.EventHandler(this.VO_print_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 633);
            this.Controls.Add(this.VO_print);
            this.Controls.Add(this.VO_delete);
            this.Controls.Add(this.VO_data);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VO_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label VO_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VO_minimise;
        private System.Windows.Forms.Label VO_close;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView VO_data;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button VO_delete;
        private System.Windows.Forms.Button VO_print;
    }
}