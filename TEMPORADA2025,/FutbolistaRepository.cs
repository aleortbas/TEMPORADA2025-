using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using TEMPORADA2025_.Models;

namespace TEMPORADA2025_
{
    public class FutbolistaRepository()
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
                                NombreFutbolista = reader.GetString(1)
                            };
                            futbolistas.Add(futbolista);
                        }
                    }
                }
            }
            return futbolistas;
        }
    

    public void InsertaFutbolista(Futbolista futbolista)
        {
            string query = "INSERT INTO futbolistas (identificacion, nombre_futbolista, equipo, edad,goles, nacionalidad, posicion, lesiones) " +
                "VALUES (@identificacion, @nombre_futbolista, @equipo, @edad, @goles, @nacionalidad, @posicion, @lesiones)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@identificacion", futbolista.Identificacion);
                    command.Parameters.AddWithValue("@nombre_futbolista", futbolista.NombreFutbolista);
                    command.Parameters.AddWithValue("@equipo", "prb");
                    command.Parameters.AddWithValue("@edad", futbolista.Edad);
                    command.Parameters.AddWithValue("@goles", futbolista.Goles);
                    command.Parameters.AddWithValue("@nacionalidad", futbolista.Nacionalidad);
                    command.Parameters.AddWithValue("@posicion", futbolista.Posicion);
                    command.Parameters.AddWithValue("@lesiones", futbolista.Lesiones);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
