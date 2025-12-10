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

        public List<CategoriaEquiposFutbolista> GetFutbolistasCategoria()
        {
            var startList = new List<CategoriaEquiposFutbolista>();

            string query = "select e.nombre, f.nombre_futbolista, f.goles from futbolistas f " +
                "inner join equipos e on f.equipo = e.codigo_equipo where f.goles > 10 and e.categoria = 'A'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query,  connection))
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            var categoriaFutbolista = new CategoriaEquiposFutbolista
                            {
                                Nombre = reader.GetString(0),
                                NombreFutbolista = reader.GetString(1),
                                Goles = reader.GetInt32(2)
                            };
                            startList.Add(categoriaFutbolista);
                        }
                    }
                }
            }
            return startList;
        }
    }
}
