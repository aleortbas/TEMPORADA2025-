using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using TEMPORADA2025_.Models;

namespace TEMPORADA2025_
{
    public class FutbolistaRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["TEMPORADA2025"].ConnectionString;

        public List<Futbolista> GetAllFutbolistas()
        { 
            var futbolistas = new List<Futbolista>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT identificacion, nombre_futbolista FROM futbolistas";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var futbolista = new Futbolista
                            {
                                Identificacion = reader.GetString(0),
                                MombreFutbolista = reader.GetString(1)
                            };
                            futbolistas.Add(futbolista);
                        }
                    }
                }
            }
            return futbolistas;
        }
    }
}
