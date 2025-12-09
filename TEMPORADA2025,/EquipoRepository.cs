using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using TEMPORADA2025_.Models;

namespace TEMPORADA2025_
{
    public class EquipoRepository ()
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["TEMPORADA2025"].ConnectionString;
        public void InsertarEquipos(Equipos equipos)
        {
            string query = "INSERT INTO equipos (codigo_equipo, nombre, pais, categoria, año, presupuesto)" +
                "VALUES (@CodigoEquipo, @nombre, @pais, @categoria, @año, @presupuesto)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CodigoEquipo", "prb");
                    command.Parameters.AddWithValue("@nombre", equipos.Nombre);
                    command.Parameters.AddWithValue("@pais", equipos.Pais);
                    command.Parameters.AddWithValue("@categoria", equipos.Categoria);
                    command.Parameters.AddWithValue("@año", equipos.Año);
                    command.Parameters.AddWithValue("@presupuesto", equipos.presupuesto);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
        public List<anosEquipos> GetAñosEquipos()
        {
            var startList = new List<anosEquipos>();

            string query = "select codigo_equipo, nombre, año from equipos where año between '1900-01-01' and '1950-12-31';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var equipo = new anosEquipos // Change the type to 'anosEquipos' to match the list type
                            {
                                CodigoEquipo = reader["codigo_equipo"].ToString(),
                                Nombre = reader["nombre"].ToString(),
                                Año = Convert.ToDateTime(reader["año"])
                            };
                            startList.Add(equipo);
                        }
                    }
                }
            }
            return startList;
        }
    }
}
