using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace DigitalPersona
{
    class MySqlAdapter
    {
        public MySqlConnection mySqlConnection;
        private MySqlCommand mySqlCommand;

        public MySqlAdapter(String host, String user, String password, String database)
        {
            MySqlConnectionStringBuilder mysql_info = new MySqlConnectionStringBuilder();
            mysql_info.Server = host;
            mysql_info.UserID = user;
            mysql_info.Password = password;
            mysql_info.Database = database;
            mysql_info.SslMode = MySqlSslMode.None;

            try
            {
                mySqlConnection = new MySqlConnection(mysql_info.ToString());
                
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BASE DE DATOS" + e.Message);
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void CreateUser(User user)
        {
            mySqlConnection.Open();
            mySqlCommand = new MySqlCommand();
            mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = "INSERT INTO User (name, pawprint, pawprint_length) VALUES (?, ?, ?)";

            mySqlCommand.Parameters.AddWithValue("name", user.Name);
            mySqlCommand.Parameters.AddWithValue("pawprint", user.Pawprint);
            mySqlCommand.Parameters.AddWithValue("pawprint_length", user.Pawprint_length);

            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();
        }

        public List<User> GetAllUsers()
        {
            mySqlConnection.Open();
            mySqlCommand = new MySqlCommand();
            mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = "SELECT * FROM user";
            MySqlDataReader mySqlDataReader;
            mySqlDataReader = mySqlCommand.ExecuteReader();

            User user;
            List<User> ListUser = new List<User>();
            while (mySqlDataReader.Read())
            {
                user = new User();
                user.Name = mySqlDataReader.GetString("name");
                user.Pawprint_length = mySqlDataReader.GetInt32("pawprint_length");

                byte[] buffer = new byte[user.Pawprint_length];
                mySqlDataReader.GetBytes(mySqlDataReader.GetOrdinal("pawprint"), 0, buffer, 0, user.Pawprint_length);
                user.Pawprint = buffer;

                ListUser.Add(user);
            }

            mySqlConnection.Close();
            return ListUser;
        }
    }
}
