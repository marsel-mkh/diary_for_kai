namespace Interface_lab
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CloseLable = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.AboutMeButton = new System.Windows.Forms.Label();
            this.SudBBtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.PropusliBtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.zachetkaBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DiaryButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.miniPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseLable
            // 
            this.CloseLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseLable.AutoSize = true;
            this.CloseLable.BackColor = System.Drawing.Color.Transparent;
            this.CloseLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLable.ForeColor = System.Drawing.Color.White;
            this.CloseLable.Location = new System.Drawing.Point(1121, 0);
            this.CloseLable.Name = "CloseLable";
            this.CloseLable.Size = new System.Drawing.Size(31, 29);
            this.CloseLable.TabIndex = 2;
            this.CloseLable.Text = "X";
            this.CloseLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseLable.Click += new System.EventHandler(this.CloseLable_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(116)))));
            this.MenuPanel.Controls.Add(this.AboutMeButton);
            this.MenuPanel.Controls.Add(this.SudBBtn);
            this.MenuPanel.Controls.Add(this.pictureBox5);
            this.MenuPanel.Controls.Add(this.PropusliBtn);
            this.MenuPanel.Controls.Add(this.pictureBox4);
            this.MenuPanel.Controls.Add(this.zachetkaBtn);
            this.MenuPanel.Controls.Add(this.pictureBox3);
            this.MenuPanel.Controls.Add(this.DiaryButton);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Controls.Add(this.pictureBox2);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(243, 785);
            this.MenuPanel.TabIndex = 3;
            // 
            // AboutMeButton
            // 
            this.AboutMeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutMeButton.AutoSize = true;
            this.AboutMeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutMeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutMeButton.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutMeButton.ForeColor = System.Drawing.Color.White;
            this.AboutMeButton.Location = new System.Drawing.Point(71, 755);
            this.AboutMeButton.Name = "AboutMeButton";
            this.AboutMeButton.Size = new System.Drawing.Size(77, 21);
            this.AboutMeButton.TabIndex = 9;
            this.AboutMeButton.Text = "About me";
            this.AboutMeButton.Click += new System.EventHandler(this.AboutMeButton_Click);
            // 
            // SudBBtn
            // 
            this.SudBBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SudBBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SudBBtn.FlatAppearance.BorderSize = 0;
            this.SudBBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SudBBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SudBBtn.ForeColor = System.Drawing.Color.White;
            this.SudBBtn.Location = new System.Drawing.Point(55, 312);
            this.SudBBtn.Name = "SudBBtn";
            this.SudBBtn.Size = new System.Drawing.Size(176, 43);
            this.SudBBtn.TabIndex = 8;
            this.SudBBtn.Text = "Студенческий билет";
            this.SudBBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SudBBtn.UseVisualStyleBackColor = true;
            this.SudBBtn.Click += new System.EventHandler(this.SudBBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 312);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // PropusliBtn
            // 
            this.PropusliBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PropusliBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PropusliBtn.FlatAppearance.BorderSize = 0;
            this.PropusliBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PropusliBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropusliBtn.ForeColor = System.Drawing.Color.White;
            this.PropusliBtn.Location = new System.Drawing.Point(61, 248);
            this.PropusliBtn.Name = "PropusliBtn";
            this.PropusliBtn.Size = new System.Drawing.Size(176, 43);
            this.PropusliBtn.TabIndex = 6;
            this.PropusliBtn.Text = "Пропуски";
            this.PropusliBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PropusliBtn.UseVisualStyleBackColor = true;
            this.PropusliBtn.Click += new System.EventHandler(this.PropusliBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 248);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // zachetkaBtn
            // 
            this.zachetkaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zachetkaBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zachetkaBtn.FlatAppearance.BorderSize = 0;
            this.zachetkaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zachetkaBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zachetkaBtn.ForeColor = System.Drawing.Color.White;
            this.zachetkaBtn.Location = new System.Drawing.Point(61, 184);
            this.zachetkaBtn.Name = "zachetkaBtn";
            this.zachetkaBtn.Size = new System.Drawing.Size(176, 43);
            this.zachetkaBtn.TabIndex = 4;
            this.zachetkaBtn.Text = "Зачетка";
            this.zachetkaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zachetkaBtn.UseVisualStyleBackColor = true;
            this.zachetkaBtn.Click += new System.EventHandler(this.zachetkaBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // DiaryButton
            // 
            this.DiaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiaryButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DiaryButton.FlatAppearance.BorderSize = 0;
            this.DiaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiaryButton.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiaryButton.ForeColor = System.Drawing.Color.White;
            this.DiaryButton.Location = new System.Drawing.Point(55, 121);
            this.DiaryButton.Name = "DiaryButton";
            this.DiaryButton.Size = new System.Drawing.Size(176, 43);
            this.DiaryButton.TabIndex = 2;
            this.DiaryButton.Text = "Дневник";
            this.DiaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiaryButton.UseVisualStyleBackColor = true;
            this.DiaryButton.Click += new System.EventHandler(this.DiaryButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(46)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(243, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(909, 135);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // miniPanel
            // 
            this.miniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miniPanel.Location = new System.Drawing.Point(243, 135);
            this.miniPanel.Name = "miniPanel";
            this.miniPanel.Size = new System.Drawing.Size(909, 650);
            this.miniPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(78)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1152, 785);
            this.Controls.Add(this.miniPanel);
            this.Controls.Add(this.CloseLable);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLable;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button DiaryButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AboutMeButton;
        private System.Windows.Forms.Button SudBBtn;
        private System.Windows.Forms.Button PropusliBtn;
        private System.Windows.Forms.Button zachetkaBtn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel miniPanel;
    }
}