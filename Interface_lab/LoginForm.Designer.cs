namespace Interface_lab
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.CloseLable = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.kai_logo = new System.Windows.Forms.PictureBox();
            this.AutorisationPanel = new System.Windows.Forms.Panel();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AutorisationLable = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kai_logo)).BeginInit();
            this.AutorisationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(78)))), ((int)(((byte)(155)))));
            this.mainPanel.Controls.Add(this.CloseLable);
            this.mainPanel.Controls.Add(this.RegistrationButton);
            this.mainPanel.Controls.Add(this.LoginButton);
            this.mainPanel.Controls.Add(this.kai_logo);
            this.mainPanel.Controls.Add(this.AutorisationPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(439, 422);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // CloseLable
            // 
            this.CloseLable.AutoSize = true;
            this.CloseLable.BackColor = System.Drawing.Color.Transparent;
            this.CloseLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLable.ForeColor = System.Drawing.Color.White;
            this.CloseLable.Location = new System.Drawing.Point(408, 0);
            this.CloseLable.Name = "CloseLable";
            this.CloseLable.Size = new System.Drawing.Size(31, 29);
            this.CloseLable.TabIndex = 1;
            this.CloseLable.Text = "X";
            this.CloseLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseLable.Click += new System.EventHandler(this.CloseLable_Click);
            this.CloseLable.MouseEnter += new System.EventHandler(this.CloseLable_MouseEnter);
            this.CloseLable.MouseLeave += new System.EventHandler(this.CloseLable_MouseLeave);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RegistrationButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RegistrationButton.FlatAppearance.BorderSize = 0;
            this.RegistrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(78)))), ((int)(((byte)(155)))));
            this.RegistrationButton.Location = new System.Drawing.Point(150, 336);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(184, 35);
            this.RegistrationButton.TabIndex = 4;
            this.RegistrationButton.Text = "Создать аккаунт";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(78)))), ((int)(((byte)(155)))));
            this.LoginButton.Location = new System.Drawing.Point(150, 277);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(184, 35);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // kai_logo
            // 
            this.kai_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.kai_logo.Image = ((System.Drawing.Image)(resources.GetObject("kai_logo.Image")));
            this.kai_logo.Location = new System.Drawing.Point(0, 0);
            this.kai_logo.Name = "kai_logo";
            this.kai_logo.Size = new System.Drawing.Size(439, 101);
            this.kai_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kai_logo.TabIndex = 2;
            this.kai_logo.TabStop = false;
            // 
            // AutorisationPanel
            // 
            this.AutorisationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(78)))), ((int)(((byte)(155)))));
            this.AutorisationPanel.Controls.Add(this.PasswordTextbox);
            this.AutorisationPanel.Controls.Add(this.pictureBox4);
            this.AutorisationPanel.Controls.Add(this.LoginTextbox);
            this.AutorisationPanel.Controls.Add(this.pictureBox3);
            this.AutorisationPanel.Controls.Add(this.pictureBox2);
            this.AutorisationPanel.Controls.Add(this.AutorisationLable);
            this.AutorisationPanel.Location = new System.Drawing.Point(66, 110);
            this.AutorisationPanel.Name = "AutorisationPanel";
            this.AutorisationPanel.Size = new System.Drawing.Size(307, 187);
            this.AutorisationPanel.TabIndex = 0;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextbox.Location = new System.Drawing.Point(84, 108);
            this.PasswordTextbox.Multiline = true;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(184, 39);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            this.PasswordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(44, 108);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextbox.Location = new System.Drawing.Point(84, 63);
            this.LoginTextbox.Multiline = true;
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(184, 39);
            this.LoginTextbox.TabIndex = 2;
            this.LoginTextbox.Enter += new System.EventHandler(this.LoginTextbox_Enter);
            this.LoginTextbox.Leave += new System.EventHandler(this.LoginTextbox_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(44, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // AutorisationLable
            // 
            this.AutorisationLable.BackColor = System.Drawing.Color.Transparent;
            this.AutorisationLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutorisationLable.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutorisationLable.ForeColor = System.Drawing.Color.White;
            this.AutorisationLable.Location = new System.Drawing.Point(0, 0);
            this.AutorisationLable.Name = "AutorisationLable";
            this.AutorisationLable.Size = new System.Drawing.Size(307, 187);
            this.AutorisationLable.TabIndex = 0;
            this.AutorisationLable.Text = "Авторизация";
            this.AutorisationLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(439, 422);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kai_logo)).EndInit();
            this.AutorisationPanel.ResumeLayout(false);
            this.AutorisationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel AutorisationPanel;
        private System.Windows.Forms.Label AutorisationLable;
        private System.Windows.Forms.Label CloseLable;
        private System.Windows.Forms.PictureBox kai_logo;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegistrationButton;
    }
}