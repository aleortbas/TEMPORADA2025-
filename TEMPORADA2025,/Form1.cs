
using System.Text;
using TEMPORADA2025_.Models;

namespace TEMPORADA2025_
{
    public partial class Form1 : Form
    {
        private readonly FutbolistaRepository futbolistaRepository = new FutbolistaRepository();
        private readonly EquipoRepository equipoRepository = new EquipoRepository();
        private readonly EquipoService _equipoService = new EquipoService();
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
                    CodigoEquipo = codigoEquipo.Text,
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
                    Equipo = listaEquipos.SelectedValue.ToString(),
                    Edad = int.TryParse(txtEdad.Text, out int edad) ? edad : 0,
                    Goles = int.TryParse(txtGoles.Text, out int goles) ? goles : 0,
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void LoadTeamsIntoComboBox()
        {
            try
            {
                // 1. Get the list of DTOs from the service layer
                List<ListaEquipos> teams = _equipoService.LoadTeams();

                // 2. Set the DataSource: This is the list of objects that populates the ComboBox
                listaEquipos.DataSource = teams;

                // 3. Set the DisplayMember: This is the property that the user will SEE in the list
                listaEquipos.DisplayMember = "NOMBRE";

                // 4. Set the ValueMember: This is the property that will be stored when an item is selected
                listaEquipos.ValueMember = "CODIGO";

                // Optional: Select the first item by default
                if (listaEquipos.Items.Count > 0)
                {
                    listaEquipos.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teams: {ex.Message}", "Data Load Error");
            }
        }

        // Example: Reading the selected value
        private void btnSavePlayer_Click(object sender, EventArgs e)
        {
            string selectedTeamCode = listaEquipos.SelectedValue?.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadTeamsIntoComboBox();
        }
    }
}
