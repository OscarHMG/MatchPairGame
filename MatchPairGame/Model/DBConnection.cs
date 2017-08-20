using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MatchPairGame.Model
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "n3k";
            uid = "root";
            password = "toor";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public void register(string userName, string password, string name, string lastName, string birthDate, string email)
        {
            string query = "INSERT INTO usuario (usuario, nombre, apellido, contrasena,correo) VALUES('"+userName+ "','"+name+ "','" +lastName+ "','"+birthDate+ "','"+email+ "');";
            Console.WriteLine(query);
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Completado!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("El usuario ingresado ya existe, intente registrarse nuevamente.");

                }
                //close connection
                this.CloseConnection();
            }
        }


        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

       
        //Count statement
        public int login(string userName, string password)
        {
            string query = "SELECT usuario FROM usuario where usuario=\""+userName+ "\" and contrasena=\""+password+ "\";";
            int Count = -1;
            Console.WriteLine(query);
            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                Console.WriteLine(Count);
                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }




}
