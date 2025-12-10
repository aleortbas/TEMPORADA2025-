namespace TEMPORADA2025_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAno = new DataGridView();
            mostrarEquiposAno = new Button();
            BttVolver = new Button();
            button1 = new Button();
            ArqueroCategoria = new Button();
            nombresFutbolistas = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAno).BeginInit();
            SuspendLayout();
            // 
            // dgvAno
            // 
            dgvAno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAno.Location = new Point(12, 12);
            dgvAno.Name = "dgvAno";
            dgvAno.RowHeadersWidth = 51;
            dgvAno.Size = new Size(905, 304);
            dgvAno.TabIndex = 0;
            dgvAno.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mostrarEquiposAno
            // 
            mostrarEquiposAno.Location = new Point(12, 402);
            mostrarEquiposAno.Name = "mostrarEquiposAno";
            mostrarEquiposAno.Size = new Size(116, 29);
            mostrarEquiposAno.TabIndex = 1;
            mostrarEquiposAno.Text = "equiposAnos";
            mostrarEquiposAno.UseVisualStyleBackColor = true;
            mostrarEquiposAno.Click += mostrarEquiposAno_Click;
            // 
            // BttVolver
            // 
            BttVolver.Location = new Point(823, 507);
            BttVolver.Name = "BttVolver";
            BttVolver.Size = new Size(94, 29);
            BttVolver.TabIndex = 2;
            BttVolver.Text = "Volver";
            BttVolver.UseVisualStyleBackColor = true;
            BttVolver.Click += BttVolver_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 452);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 3;
            button1.Text = "futbolistaCategoria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ArqueroCategoria
            // 
            ArqueroCategoria.Location = new Point(12, 507);
            ArqueroCategoria.Name = "ArqueroCategoria";
            ArqueroCategoria.Size = new Size(154, 29);
            ArqueroCategoria.TabIndex = 4;
            ArqueroCategoria.Text = "arquero Categoria";
            ArqueroCategoria.UseVisualStyleBackColor = true;
            ArqueroCategoria.Click += ArqueroCategoria_Click;
            // 
            // nombresFutbolistas
            // 
            nombresFutbolistas.Location = new Point(12, 350);
            nombresFutbolistas.Name = "nombresFutbolistas";
            nombresFutbolistas.Size = new Size(125, 29);
            nombresFutbolistas.TabIndex = 5;
            nombresFutbolistas.Text = "nombre futbolista";
            nombresFutbolistas.UseVisualStyleBackColor = true;
            nombresFutbolistas.Click += nombresFutbolistas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 327);
            label1.Name = "label1";
            label1.Size = new Size(358, 20);
            label1.TabIndex = 6;
            label1.Text = "Futbolistas: frecuencia de 'a' y palabras en el nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 379);
            label2.Name = "label2";
            label2.Size = new Size(393, 20);
            label2.TabIndex = 7;
            label2.Text = "Listado de los equipos creados entre los años 1900 y 1950";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 434);
            label3.Name = "label3";
            label3.Size = new Size(469, 20);
            label3.TabIndex = 8;
            label3.Text = "Listado de Jugadores con más de 10 Goles en equipos de categoría A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 484);
            label4.Name = "label4";
            label4.Size = new Size(481, 20);
            label4.TabIndex = 9;
            label4.Text = "Listado de Arqueros lesionados pertenecientes a un equipo categoría C";
            label4.Click += label4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 559);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nombresFutbolistas);
            Controls.Add(ArqueroCategoria);
            Controls.Add(button1);
            Controls.Add(BttVolver);
            Controls.Add(mostrarEquiposAno);
            Controls.Add(dgvAno);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvAno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAno;
        private Button mostrarEquiposAno;
        private Button BttVolver;
        private Button button1;
        private Button ArqueroCategoria;
        private Button nombresFutbolistas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}