using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_lab
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection(
            "server=localhost;port=3306;username=root;password=root;database=interface_lab");
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)//проверка на подключение 
            {
                connection.Open();
            }
        }
        public void closeConnection()//закрывает соедененеие
        {
            if (connection.State == System.Data.ConnectionState.Open)//проверка на подключение 
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection() //возвращает соеденение с бд
        {
            return connection;
        }
    }
}
