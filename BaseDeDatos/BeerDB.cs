using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BaseDeDatos
{
    public class BeerDB : DB
    {
        public BeerDB(string server, string db, string user, string password) 
            : base(server, db, user, password)
        {
          
        }

        public List<Beer> GetAll()
        {
            Connect();

            List<Beer> beers = new List<Beer>();
            string query = "SELECT * FROM Beer";

            MySqlCommand command = new MySqlCommand(query, _connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) 
            
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);
                beers.Add(new Beer(id, name, brandId));
            }

            Close();

            return beers;
        }

        public Beer GetById(int id)
        {
            Connect();

            Beer beer = null;
            string query = "SELECT id, Name, BrandId FROM Beer " +
                "WHERE id = @id";
            MySqlCommand command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);
                beer = new Beer(id, name, brandId);
            }



            Close();

            return beer;
        }
       
        public void Add(Beer beer)
        {
            Connect();

            string query = "INSERT INTO Beer(Name, BrandId) " +
                "VALUES(@name, @brandId)";

            MySqlCommand command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.ExecuteNonQuery();


            Close();
        }

        public void Edit(Beer beer)
        {
            Connect();

            string query = "UPDATE Beer SET Name=@name, BrandId=@brandId " +
                "WHERE id=@id";
            MySqlCommand command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.Parameters.AddWithValue("@id", beer.Id);
            command.ExecuteNonQuery();

            Close();
        }

        public void Delete(Beer beer)
        {
            Connect();

            string query = "DELETE FROM Beer WHERE id=@id";
            MySqlCommand command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", beer.Id);
            command.ExecuteNonQuery();

            Close();

        }
    }
}
