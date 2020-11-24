namespace InventoryMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usernameBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login_text_header = new System.Windows.Forms.Label();
            this.MP_minimise = new System.Windows.Forms.Label();
            this.MProd_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.showPassword);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.usernameBox);
            this.panel1.Controls.Add(this.login_text_header);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(114, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 350);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.BackColor = System.Drawing.Color.Transparent;
            this.showPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.Location = new System.Drawing.Point(105, 312);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(130, 20);
            this.showPassword.TabIndex = 5;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = false;
            this.showPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(13, 313);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(41, 16);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(16, 257);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(219, 42);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordBox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordBox.HintText = "";
            this.passwordBox.isPassword = true;
            this.passwordBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.passwordBox.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordBox.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.passwordBox.LineThickness = 3;
            this.passwordBox.Location = new System.Drawing.Point(16, 197);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(219, 31);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.Text = "Password";
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usernameBox
            // 
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameBox.HintForeColor = System.Drawing.Color.Empty;
            this.usernameBox.HintText = "";
            this.usernameBox.isPassword = false;
            this.usernameBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.usernameBox.LineIdleColor = System.Drawing.Color.Gray;
            this.usernameBox.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.usernameBox.LineThickness = 3;
            this.usernameBox.Location = new System.Drawing.Point(16, 141);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(219, 31);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.Text = "Username";
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // login_text_header
            // 
            this.login_text_header.AutoSize = true;
            this.login_text_header.BackColor = System.Drawing.Color.Transparent;
            this.login_text_header.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_text_header.ForeColor = System.Drawing.Color.DimGray;
            this.login_text_header.Location = new System.Drawing.Point(89, 13);
            this.login_text_header.Name = "login_text_header";
            this.login_text_header.Size = new System.Drawing.Size(69, 29);
            this.login_text_header.TabIndex = 0;
            this.login_text_header.Text = "Login";
            // 
            // MP_minimise
            // 
            this.MP_minimise.AutoSize = true;
            this.MP_minimise.BackColor = System.Drawing.Color.Transparent;
            this.MP_minimise.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP_minimise.ForeColor = System.Drawing.Color.White;
            this.MP_minimise.Location = new System.Drawing.Point(420, -11);
            this.MP_minimise.Name = "MP_minimise";
            this.MP_minimise.Size = new System.Drawing.Size(26, 29);
            this.MP_minimise.TabIndex = 34;
            this.MP_minimise.Text = "_";
            this.MP_minimise.Click += new System.EventHandler(this.MP_minimise_Click);
            // 
            // MProd_close
            // 
            this.MProd_close.AutoSize = true;
            this.MProd_close.BackColor = System.Drawing.Color.Transparent;
            this.MProd_close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MProd_close.ForeColor = System.Drawing.Color.White;
            this.MProd_close.Location = new System.Drawing.Point(455, 0);
            this.MProd_close.Name = "MProd_close";
            this.MProd_close.Size = new System.Drawing.Size(29, 29);
            this.MProd_close.TabIndex = 33;
            this.MProd_close.Text = "X";
            this.MProd_close.Click += new System.EventHandler(this.MProd_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 441);
            this.Controls.Add(this.MP_minimise);
            this.Controls.Add(this.MProd_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login_text_header;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Label clearButton;
        private System.Windows.Forms.Button loginButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MP_minimise;
        private System.Windows.Forms.Label MProd_close;
    }
}

