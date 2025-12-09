
using System.Text;
using TEMPORADA2025_.Models;

namespace TEMPORADA2025_
{
    public partial class Form1 : Form
    {
        private readonly FutbolistaRepository futbolistaRepository = new FutbolistaRepository();
        private readonly EquipoRepository equipoRepository = new EquipoRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);

            form2.Show();

            this.Hide();
        }
        private void txtFutbolistasList_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                int yearSelected = anoFundacion.Value.Year;
                DateTime dateOfFoundation = new DateTime(yearSelected, 1, 1);

                var newPlayer = new Equipos
                {
                    CodigoEquipo= txtNombreEquipo.Text,
                    Nombre = txtNombreEquipo.Text,
                    Pais = txtPaisEquipo.Text,
                    Categoria = Acategoria.Text,
                    Año = dateOfFoundation,
                    presupuesto = txtPresupuesto.Text
                };
                equipoRepository.InsertarEquipos(newPlayer);
                MessageBox.Show("Equipo insertado!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Validation Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addFutbolista_Click(object sender, EventArgs e)
        {
            try
            {
                var newPlayer = new Futbolista
                {
                    Identificacion = Guid.NewGuid().ToString().Substring(0, 8), // Example ID generation
                    NombreFutbolista = txtNombreFutbolista.Text,
                    Equipo = txtEquipo.Text,
                    Edad = int.TryParse(txtEquipo.Text, out int edad) ? edad : 0,
                    Goles = int.TryParse(txtGoles.Text, out int goles) ? goles: 0,
                    Nacionalidad = txtNacionalidad.Text,
                    Posicion = posicion.Text,
                    Lesiones = siLesion.Checked ? true : false
                };
                futbolistaRepository.InsertaFutbolista(newPlayer);
                MessageBox.Show("Futbolista insertado!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Validation Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void posicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
