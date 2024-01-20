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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Interface_lab
{
    public partial class ZachetkaForm : Form
    {
        public ZachetkaForm()
        {
            InitializeComponent();
        }
        string username = Data.name;
        private void ZachetkaForm_Load(object sender, EventArgs e)
        {
            DataBase date = new DataBase();
            //по имени теперь делаем выборку
            MySqlCommand command = new MySqlCommand("SELECT * FROM predmet_31404 " +
                                                            "WHERE name = @name", date.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = username;
            date.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EconomikaZachetka.Text = reader.GetString(2);
                    InterfaceZachetka.Text = reader.GetString(3);
                    DateZachetka.Text = reader.GetString(4);
                    ProgramZachetka.Text = reader.GetString(5);
                }
            }
            reader.Close();
            date.closeConnection();
            Zlabel.Text = $"Зачетная книжка {Data.lastname} {Data.name} из группы {Data.groupnum}";
        }
    }
}
