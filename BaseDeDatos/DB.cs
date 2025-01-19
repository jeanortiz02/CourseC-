using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BaseDeDatos
{
    public abstract class DB
    {
        private string _connectionstring;
        protected MySqlConnection _connection;

        public DB( string server, string db, string user, string password )
        {
            _connectionstring = $"Server={server}; Database={db}; Uid={user}; Pwd={password};";
        }

        public void Connect()
        {
            _connection = new MySqlConnection(_connectionstring);
            _connection.Open();
        }

        public void Close()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open) 
            { 
                _connection.Close();
            }
        }
    }
}
