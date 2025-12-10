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
            ((System.ComponentModel.ISupportInitialize)dgvAno).BeginInit();
            SuspendLayout();
            // 
            // dgvAno
            // 
            dgvAno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAno.Location = new Point(204, 133);
            dgvAno.Name = "dgvAno";
            dgvAno.RowHeadersWidth = 51;
            dgvAno.Size = new Size(300, 188);
            dgvAno.TabIndex = 0;
            dgvAno.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mostrarEquiposAno
            // 
            mostrarEquiposAno.Location = new Point(182, 347);
            mostrarEquiposAno.Name = "mostrarEquiposAno";
            mostrarEquiposAno.Size = new Size(116, 29);
            mostrarEquiposAno.TabIndex = 1;
            mostrarEquiposAno.Text = "equiposAnos";
            mostrarEquiposAno.UseVisualStyleBackColor = true;
            mostrarEquiposAno.Click += mostrarEquiposAno_Click;
            // 
            // BttVolver
            // 
            BttVolver.Location = new Point(681, 347);
            BttVolver.Name = "BttVolver";
            BttVolver.Size = new Size(94, 29);
            BttVolver.TabIndex = 2;
            BttVolver.Text = "Volver";
            BttVolver.UseVisualStyleBackColor = true;
            BttVolver.Click += BttVolver_Click;
            // 
            // button1
            // 
            button1.Location = new Point(320, 347);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 3;
            button1.Text = "futbolistaCategoria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ArqueroCategoria
            // 
            ArqueroCategoria.Location = new Point(491, 347);
            ArqueroCategoria.Name = "ArqueroCategoria";
            ArqueroCategoria.Size = new Size(154, 29);
            ArqueroCategoria.TabIndex = 4;
            ArqueroCategoria.Text = "arquero Categoria";
            ArqueroCategoria.UseVisualStyleBackColor = true;
            ArqueroCategoria.Click += ArqueroCategoria_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ArqueroCategoria);
            Controls.Add(button1);
            Controls.Add(BttVolver);
            Controls.Add(mostrarEquiposAno);
            Controls.Add(dgvAno);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvAno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAno;
        private Button mostrarEquiposAno;
        private Button BttVolver;
        private Button button1;
        private Button ArqueroCategoria;
    }
}