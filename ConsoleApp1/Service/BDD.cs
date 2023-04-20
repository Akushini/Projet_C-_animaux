using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1.Service
{
    public class BDD
    {
        public BDD() 
        {
        }

        public SqlConnection Connection()
        {
            string connectionString = "Server=LAPTOP-K9GHE7AE;Initial Catalog=test;Integrated Security=True; Encrypt=False";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        public void Read()
        {
            SqlConnection connection = Connection();

            string query = "Select * From Animals";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            int id = 0;
            string name = "";
            string rarity = "";
            string specie = "";

            while(reader.Read()) 
            {
                id = reader.GetInt32(0);
                name = reader.GetString(1);
                rarity = reader.GetString(2);
                specie = reader.GetString(3);



                Console.WriteLine("Id : " + id + " | " + "Espèce : " + specie+ " | " + "Nom : " + name + " | " + "Rareté : " +rarity);
            }
            
        }

        public void Write(string name, string specie, string rarity)
        {
            SqlConnection connection = Connection();
            string query = "INSERT INTO Animals VALUES ('" +name +"', '"+rarity +"', '"+specie+"')";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
        }

        

        
    }
}
