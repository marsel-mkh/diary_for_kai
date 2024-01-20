using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Interface_lab
{
    public partial class StudBiletForm : Form
    {
        public StudBiletForm()
        {
            InitializeComponent();

        }
        string userlogin = Data.login;
        private void StudBiletForm_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(userlogin);
            DataBase date = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login=@ul", date.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userlogin;
            date.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) 
                {
                    idLable.Text  = reader.GetString(0);
                    nameLable.Text  = reader.GetString(3);
                    lastNameLable.Text = reader.GetString(4);
                    GroupNumLable.Text = reader.GetString(5);
                }
            }
            reader.Close();
            date.closeConnection();
        }


    }
}
