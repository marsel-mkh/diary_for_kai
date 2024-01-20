using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interface_lab
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginTextbox.Text = "Введите логин";
            LoginTextbox.ForeColor = Color.Gray;

            PasswordTextbox.Text = "Введите пароль";
            LoginTextbox.ForeColor = Color.Gray;
        }

        private void CloseLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CloseLable_MouseEnter(object sender, EventArgs e)
        {
            CloseLable.ForeColor = Color.LightGray;
        }

        private void CloseLable_MouseLeave(object sender, EventArgs e)
        {
            CloseLable.ForeColor = Color.White;
        }
        Point p;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)//движение окна по координатам
            {
                this.Left += e.X - p.X;
                this.Top += e.Y - p.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DataBase date = new DataBase();
            string userLogin = LoginTextbox.Text;
            string userPassword = PasswordTextbox.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter= new MySqlDataAdapter();
            //синтаксис языка sql
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP",date.GetConnection());
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show("Неверный логин или пароль");
            //передача логина в другую форму
            //Data.login = userLogin;
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM users WHERE login=@ul", date.GetConnection());
            command1.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            date.openConnection();
            MySqlDataReader reader = command1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Data.id = reader.GetString(0);
                    Data.login = reader.GetString(1);
                    Data.password = reader.GetString(2);
                    Data.name = reader.GetString(3);
                    Data.lastname = reader.GetString(4);
                    Data.groupnum = reader.GetString(5);
                }
            }
            reader.Close();
            date.closeConnection();
        }

        private void LoginTextbox_Enter(object sender, EventArgs e)
        {
            if (LoginTextbox.Text == "Введите логин")
            {
                LoginTextbox.Text = "";
                LoginTextbox.ForeColor = Color.Black;
            }
        }

        private void LoginTextbox_Leave(object sender, EventArgs e)
        {
            if (LoginTextbox.Text == "")
            {
                LoginTextbox.ForeColor = Color.Gray;
                LoginTextbox.Text = "Введите логин";
            }
                  
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            if(PasswordTextbox.Text == "Введите пароль")
            {
                PasswordTextbox.ForeColor = Color.Black;
                PasswordTextbox.Text = "";
            }


        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            if(PasswordTextbox.Text == "")
            {
                PasswordTextbox.ForeColor = Color.Gray;
                PasswordTextbox.Text = "Введите пароль";
            }

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm Regform = new RegistrationForm();
            Regform.Show();
            
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
