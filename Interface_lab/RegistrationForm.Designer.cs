namespace Interface_lab
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.kai_logo = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Label();
            this.RegistrationPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupNum = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.RegistrButton = new System.Windows.Forms.Button();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.RegistrationLable = new System.Windows.Forms.Label();
            this.CloseLable = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kai_logo)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.RegistrationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kai_logo
            // 
            this.kai_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.kai_logo.Image = ((System.Drawing.Image)(resources.GetObject("kai_logo.Image")));
            this.kai_logo.Location = new System.Drawing.Point(0, 0);
            this.kai_logo.Name = "kai_logo";
            this.kai_logo.Size = new System.Drawing.Size(439, 107);
            this.kai_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kai_logo.TabIndex = 2;
            this.kai_logo.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(78)))), ((int)(((byte)(155)))));
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.RegistrationPanel);
            this.mainPanel.Controls.Add(this.CloseLable);
            this.mainPanel.Controls.Add(this.kai_logo);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(439, 478);
            this.mainPanel.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(-1, -6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(36, 37);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "<";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // RegistrationPanel
            // 
            this.RegistrationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(78)))), ((int)(((byte)(155)))));
            this.RegistrationPanel.Controls.Add(this.label1);
            this.RegistrationPanel.Controls.Add(this.groupNum);
            this.RegistrationPanel.Controls.Add(this.pass);
            this.RegistrationPanel.Controls.Add(this.Login);
            this.RegistrationPanel.Controls.Add(this.LastName);
            this.RegistrationPanel.Controls.Add(this.name);
            this.RegistrationPanel.Controls.Add(this.PasswordTextbox);
            this.RegistrationPanel.Controls.Add(this.RegistrButton);
            this.RegistrationPanel.Controls.Add(this.LoginTextbox);
            this.RegistrationPanel.Controls.Add(this.LastNameTextbox);
            this.RegistrationPanel.Controls.Add(this.NameTextbox);
            this.RegistrationPanel.Controls.Add(this.RegistrationLable);
            this.RegistrationPanel.Location = new System.Drawing.Point(0, 107);
            this.RegistrationPanel.Name = "RegistrationPanel";
            this.RegistrationPanel.Size = new System.Drawing.Size(439, 371);
            this.RegistrationPanel.TabIndex = 0;
            this.RegistrationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationPanel_MouseDown);
            this.RegistrationPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Номер группы:";
            // 
            // groupNum
            // 
            this.groupNum.BackColor = System.Drawing.SystemColors.Window;
            this.groupNum.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNum.Location = new System.Drawing.Point(55, 164);
            this.groupNum.Multiline = true;
            this.groupNum.Name = "groupNum";
            this.groupNum.Size = new System.Drawing.Size(323, 39);
            this.groupNum.TabIndex = 12;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(225, 212);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(67, 23);
            this.pass.TabIndex = 11;
            this.pass.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(51, 212);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(59, 23);
            this.Login.TabIndex = 10;
            this.Login.Text = "Логин";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.ForeColor = System.Drawing.Color.White;
            this.LastName.Location = new System.Drawing.Point(190, 51);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(82, 23);
            this.LastName.TabIndex = 9;
            this.LastName.Text = "Фамилия";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(51, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(43, 23);
            this.name.TabIndex = 8;
            this.name.Text = "Имя";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextbox.Location = new System.Drawing.Point(229, 238);
            this.PasswordTextbox.Multiline = true;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(149, 39);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            // 
            // RegistrButton
            // 
            this.RegistrButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RegistrButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RegistrButton.FlatAppearance.BorderSize = 0;
            this.RegistrButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.RegistrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrButton.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(78)))), ((int)(((byte)(155)))));
            this.RegistrButton.Location = new System.Drawing.Point(55, 300);
            this.RegistrButton.Name = "RegistrButton";
            this.RegistrButton.Size = new System.Drawing.Size(323, 35);
            this.RegistrButton.TabIndex = 3;
            this.RegistrButton.Text = "Создать";
            this.RegistrButton.UseVisualStyleBackColor = false;
            this.RegistrButton.Click += new System.EventHandler(this.RegistrButton_Click);
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.LoginTextbox.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextbox.Location = new System.Drawing.Point(55, 238);
            this.LoginTextbox.Multiline = true;
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(157, 39);
            this.LoginTextbox.TabIndex = 2;
            this.LoginTextbox.Enter += new System.EventHandler(this.LoginTextbox_Enter);
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTextbox.Location = new System.Drawing.Point(194, 77);
            this.LastNameTextbox.Multiline = true;
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(184, 39);
            this.LastNameTextbox.TabIndex = 6;
            this.LastNameTextbox.Enter += new System.EventHandler(this.LastNameTextbox_Enter);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextbox.Location = new System.Drawing.Point(55, 77);
            this.NameTextbox.Multiline = true;
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(119, 39);
            this.NameTextbox.TabIndex = 5;
            this.NameTextbox.Enter += new System.EventHandler(this.NameTextbox_Enter);
            // 
            // RegistrationLable
            // 
            this.RegistrationLable.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrationLable.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLable.ForeColor = System.Drawing.Color.White;
            this.RegistrationLable.Location = new System.Drawing.Point(0, 0);
            this.RegistrationLable.Name = "RegistrationLable";
            this.RegistrationLable.Size = new System.Drawing.Size(439, 51);
            this.RegistrationLable.TabIndex = 0;
            this.RegistrationLable.Text = "       Создание учетной записи";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 478);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.kai_logo)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.RegistrationPanel.ResumeLayout(false);
            this.RegistrationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kai_logo;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button RegistrButton;
        private System.Windows.Forms.Label CloseLable;
        private System.Windows.Forms.Panel RegistrationPanel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.Label RegistrationLable;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox groupNum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}