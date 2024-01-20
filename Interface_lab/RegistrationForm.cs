using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_lab
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void CloseLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point p;
        private void RegistrationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }

        private void RegistrationPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//движение окна по координатам
            {
                this.Left += e.X - p.X;
                this.Top += e.Y - p.Y;
            }
        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            bool b = true;
            //проверки на пустые текстбоксы
            if (LoginTextbox.Text == "")
            {
                LoginTextbox.BackColor = Color.Red;
                b= false;
            }
            if (PasswordTextbox.Text == "")
            {
                PasswordTextbox.BackColor = Color.Red;
                b = false;
            }
            if (NameTextbox.Text == "")
            {
                NameTextbox.BackColor = Color.Red;
                b = false;
            }
            if (LastNameTextbox.Text == "")
            {
                LastNameTextbox.BackColor = Color.Red;
                b = false;
            }
            if (b == false) { MessageBox.Show("Вы не ввели данные в одно из полей"); return; }
            if (isUserEXist())
                return;//проверка на логин
            //подключение бд
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand
                ("INSERT INTO `users` (`login`, `password`, `Name`, `LastName`,`groupNum`) " +
                "VALUES (@login, @pass, @name, @lname,@num)",db.GetConnection());

            //установка вместо заглушек реальных значений
            command.Parameters.Add("Login", MySqlDbType.VarChar).Value = LoginTextbox.Text;
            command.Parameters.Add("pass", MySqlDbType.VarChar).Value = PasswordTextbox.Text;
            command.Parameters.Add("name", MySqlDbType.VarChar).Value = NameTextbox.Text;
            command.Parameters.Add("lname", MySqlDbType.VarChar).Value = LastNameTextbox.Text;
            command.Parameters.Add("num", MySqlDbType.VarChar).Value = groupNum.Text;
            db.openConnection();
            //
            if(command.ExecuteNonQuery() == 1 )//функция выполняет запрос и проверяет на успешность
            {
                MessageBox.Show("успешная регистрация");
                this.Hide();
                LoginForm loginForm = new LoginForm();  
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }    
            db.closeConnection();
        }

        private void NameTextbox_Enter(object sender, EventArgs e)
        {
            NameTextbox.BackColor = Color.White;
        }

        private void LastNameTextbox_Enter(object sender, EventArgs e)
        {
            LastNameTextbox.BackColor = Color.White;
        }

        private void LoginTextbox_Enter(object sender, EventArgs e)
        {
            LoginTextbox.BackColor = Color.White;
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            PasswordTextbox.BackColor = Color.White;
        }
        public Boolean isUserEXist()
        {
            DataBase date = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //синтаксис языка sql
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", date.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginTextbox.Text;   
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return true;
            }
            else
                return false;
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.LightGray;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Lform = new LoginForm();
            Lform.ShowDialog();
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.White;
        }

        private void CloseLable_MouseEnter(object sender, EventArgs e)
        {
            CloseLable.ForeColor = Color.LightGray;
        }

        private void CloseLable_MouseLeave(object sender, EventArgs e)
        {
            CloseLable.ForeColor = Color.White;
        }


    }
    
}
