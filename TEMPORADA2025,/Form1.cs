
using System.Text;

namespace TEMPORADA2025_
{
    public partial class Form1 : Form
    {
        private readonly FutbolistaRepository futbolistaRepository = new FutbolistaRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                var futbolistas = futbolistaRepository.GetAllFutbolistas();

                foreach (var f in futbolistas)
                {
                    // Format the output: ID | Name and add a new line
                    sb.AppendLine($"{f.Identificacion} | {f.MombreFutbolista}");
                }

                // Set the TextBox text
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
