using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEMPORADA2025_.Models;

namespace TEMPORADA2025_
{
    public partial class Form2 : Form
    {
        private readonly EquipoRepository equipoRepository = new EquipoRepository();
        private readonly FutbolistaRepository futbolistaRepository = new FutbolistaRepository();

        private Form1 _callingForm;
        public Form2(Form1 callingForm)
        {
            InitializeComponent();
            _callingForm = callingForm;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrarEquiposAno_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get the data from the service layer
                List<anosEquipos> results = equipoRepository.GetAñosEquipos();

                // 2. Set the data source of the DataGridView
                // DataGridView automatically generates columns based on the public properties of the list objects.
                dgvAno.DataSource = results;

                // Optional: Customize column headers after setting the source
                if (dgvAno.Columns.Contains("NombreEquipo"))
                {
                    dgvAno.Columns["NombreEquipo"].HeaderText = "Equipo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BttVolver_Click(object sender, EventArgs e)
        {
            _callingForm.Show(); // Show the original Form1 instance
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get the data from the service layer
                List<CategoriaEquiposFutbolista> results = futbolistaRepository.GetFutbolistasCategoria();

                // 2. Set the data source of the DataGridView
                // DataGridView automatically generates columns based on the public properties of the list objects.
                dgvAno.DataSource = results;

                // Optional: Customize column headers after setting the source
                if (dgvAno.Columns.Contains("NombreEquipo"))
                {
                    dgvAno.Columns["NombreEquipo"].HeaderText = "Equipo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ArqueroCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get the data from the service layer
                List<ArquerosCategoria> results = futbolistaRepository.GetArquerosCategoria();

                // 2. Set the data source of the DataGridView
                dgvAno.DataSource = results;

                if (dgvAno.Columns.Contains("NombreEquipo"))
                {
                    dgvAno.Columns["NombreEquipo"].HeaderText = "Equipo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
