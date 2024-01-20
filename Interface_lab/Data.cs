using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Interface_lab
{
    static class Data
    {
        static Data()
        {
            
        }
        public static string id { get; set; }
        public static string name { get; set; }
        public static string lastname { get; set; }
        public static string groupnum { get; set; }
        public static string login { get; set; }
        public static string password { get; set; }
        
    }
}
