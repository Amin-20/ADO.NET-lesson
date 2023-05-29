using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Models;

namespace WpfApp3.Repository
{
    public class Repo
    {
        ObservableCollection<Author> _authors = new ObservableCollection<Author>();
        SqlConnection conn;
        string cs = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;

        public Repo()
        {
            using (conn = new SqlConnection())
            {
                conn.ConnectionString = cs;
                conn.Open();

                SqlDataReader reader = null;

                string query = "SELECT * FROM Authors";
                using (var command = new SqlCommand(query, conn))
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Author author = new Author
                        {
                            Id = int.Parse(reader[0].ToString()),
                            FirstName = reader[1].ToString(),
                            LastName = reader[2].ToString()
                        };
                        _authors.Add(author);
                    }
                }
            }
        }
        public ObservableCollection<Author> GetAll()
        {
            return _authors;
        }



    }
}
