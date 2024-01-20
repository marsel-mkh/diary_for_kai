using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interface_lab
{
    public partial class ProguliForm : Form
    {
        public ProguliForm()
        {
            InitializeComponent();
        }
        string username = Data.name;
        private void ProguliForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(userlogin);
            // MessageBox.Show(username);
            DataBase date = new DataBase();
            //по имени теперь делаем выборку
            MySqlCommand command = new MySqlCommand("SELECT * FROM usersproguli " +
                                                            "WHERE name = @name", date.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = username;
            date.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EconomikaPropuski.Text = reader.GetString(2); 
                    InterfacePropuski.Text = reader.GetString(3);
                    DatePropuski.Text= reader.GetString(4);
                    ProgramPropuski.Text = reader.GetString(5);
                }
            }
            reader.Close();
            date.closeConnection();
        }
    }
}
