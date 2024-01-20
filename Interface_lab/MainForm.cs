using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_lab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            miniPanel.Controls.Add(childForm);
            miniPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AboutMeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение дневник КНИТУ-КАИ\nВерсия:0.0.1.");  
        }

        private void DiaryButton_Click(object sender, EventArgs e)
        {
            openChildForm(new DiaryForm());

        }

        private void zachetkaBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ZachetkaForm());
        }

        private void PropusliBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ProguliForm());
        }

        private void SudBBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new StudBiletForm());
        }

        private void CloseLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
