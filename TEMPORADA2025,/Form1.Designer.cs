namespace TEMPORADA2025_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            nombreEquipo = new Label();
            txtNombreEquipo = new TextBox();
            addEquipo = new Button();
            addFutbolista = new Button();
            pais = new Label();
            txtPaisEquipo = new TextBox();
            txtCategoria = new TextBox();
            categoria = new Label();
            txtPresupuesto = new TextBox();
            presupuesto = new Label();
            txtAño = new TextBox();
            año = new Label();
            txtNacionalidad = new TextBox();
            label1 = new Label();
            txtGoles = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            txtEquipo = new TextBox();
            label4 = new Label();
            txtNombreFutbolista = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            posicion = new ComboBox();
            siLesion = new RadioButton();
            noLesion = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(12, 602);
            button1.Name = "button1";
            button1.Size = new Size(700, 55);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nombreEquipo
            // 
            nombreEquipo.AutoSize = true;
            nombreEquipo.Location = new Point(12, 9);
            nombreEquipo.Name = "nombreEquipo";
            nombreEquipo.Size = new Size(64, 20);
            nombreEquipo.TabIndex = 1;
            nombreEquipo.Text = "Nombre";
            nombreEquipo.Click += label1_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreEquipo.Location = new Point(12, 32);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(191, 27);
            txtNombreEquipo.TabIndex = 2;
            txtNombreEquipo.TextChanged += txtFutbolistasList_TextChanged;
            // 
            // addEquipo
            // 
            addEquipo.Location = new Point(12, 310);
            addEquipo.Name = "addEquipo";
            addEquipo.Size = new Size(94, 29);
            addEquipo.TabIndex = 3;
            addEquipo.Text = "Equipo";
            addEquipo.UseVisualStyleBackColor = true;
            addEquipo.Click += addEquipo_Click;
            // 
            // addFutbolista
            // 
            addFutbolista.Location = new Point(527, 508);
            addFutbolista.Name = "addFutbolista";
            addFutbolista.Size = new Size(94, 29);
            addFutbolista.TabIndex = 4;
            addFutbolista.Text = "Futbolista";
            addFutbolista.UseVisualStyleBackColor = true;
            addFutbolista.Click += addFutbolista_Click;
            // 
            // pais
            // 
            pais.AutoSize = true;
            pais.Location = new Point(12, 72);
            pais.Name = "pais";
            pais.Size = new Size(34, 20);
            pais.TabIndex = 5;
            pais.Text = "Pais";
            // 
            // txtPaisEquipo
            // 
            txtPaisEquipo.Location = new Point(12, 95);
            txtPaisEquipo.Name = "txtPaisEquipo";
            txtPaisEquipo.Size = new Size(191, 27);
            txtPaisEquipo.TabIndex = 6;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(12, 153);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(191, 27);
            txtCategoria.TabIndex = 8;
            // 
            // categoria
            // 
            categoria.AutoSize = true;
            categoria.Location = new Point(12, 130);
            categoria.Name = "categoria";
            categoria.Size = new Size(74, 20);
            categoria.TabIndex = 7;
            categoria.Text = "Categoria";
            categoria.Click += label3_Click;
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Location = new Point(12, 266);
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.Size = new Size(191, 27);
            txtPresupuesto.TabIndex = 12;
            // 
            // presupuesto
            // 
            presupuesto.AutoSize = true;
            presupuesto.Location = new Point(12, 243);
            presupuesto.Name = "presupuesto";
            presupuesto.Size = new Size(89, 20);
            presupuesto.TabIndex = 11;
            presupuesto.Text = "Presupuesto";
            // 
            // txtAño
            // 
            txtAño.Location = new Point(12, 208);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(191, 27);
            txtAño.TabIndex = 10;
            // 
            // año
            // 
            año.AutoSize = true;
            año.Location = new Point(12, 185);
            año.Name = "año";
            año.Size = new Size(36, 20);
            año.TabIndex = 9;
            año.Text = "Año";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(430, 283);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(191, 27);
            txtNacionalidad.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 260);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 21;
            label1.Text = "Nacionalidad";
            label1.Click += label1_Click_1;
            // 
            // txtGoles
            // 
            txtGoles.Location = new Point(430, 221);
            txtGoles.Name = "txtGoles";
            txtGoles.Size = new Size(191, 27);
            txtGoles.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 198);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 19;
            label2.Text = "Goles";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(430, 153);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(191, 27);
            txtEdad.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 130);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 17;
            label3.Text = "Edad";
            // 
            // txtEquipo
            // 
            txtEquipo.Location = new Point(430, 95);
            txtEquipo.Name = "txtEquipo";
            txtEquipo.Size = new Size(191, 27);
            txtEquipo.TabIndex = 16;
            txtEquipo.TextChanged += txtEquipo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 72);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 15;
            label4.Text = "Equipo";
            label4.Click += label4_Click;
            // 
            // txtNombreFutbolista
            // 
            txtNombreFutbolista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreFutbolista.Location = new Point(430, 32);
            txtNombreFutbolista.Name = "txtNombreFutbolista";
            txtNombreFutbolista.Size = new Size(191, 27);
            txtNombreFutbolista.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 9);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 13;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 405);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 23;
            label6.Text = "Lesiones";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(430, 322);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 25;
            label7.Text = "Posicion";
            // 
            // posicion
            // 
            posicion.FormattingEnabled = true;
            posicion.Items.AddRange(new object[] { "Arquero", "Defensa", "Medio", "Delantero" });
            posicion.Location = new Point(430, 359);
            posicion.Name = "posicion";
            posicion.Size = new Size(191, 28);
            posicion.TabIndex = 26;
            posicion.SelectedIndexChanged += posicion_SelectedIndexChanged;
            // 
            // siLesion
            // 
            siLesion.AutoSize = true;
            siLesion.Location = new Point(430, 439);
            siLesion.Name = "siLesion";
            siLesion.Size = new Size(42, 24);
            siLesion.TabIndex = 27;
            siLesion.Text = "Si";
            siLesion.UseVisualStyleBackColor = true;
            siLesion.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // noLesion
            // 
            noLesion.AutoSize = true;
            noLesion.Location = new Point(430, 469);
            noLesion.Name = "noLesion";
            noLesion.Size = new Size(50, 24);
            noLesion.TabIndex = 28;
            noLesion.Text = "No";
            noLesion.UseVisualStyleBackColor = true;
            noLesion.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(724, 669);
            Controls.Add(noLesion);
            Controls.Add(siLesion);
            Controls.Add(posicion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtNacionalidad);
            Controls.Add(label1);
            Controls.Add(txtGoles);
            Controls.Add(label2);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtEquipo);
            Controls.Add(label4);
            Controls.Add(txtNombreFutbolista);
            Controls.Add(label5);
            Controls.Add(txtPresupuesto);
            Controls.Add(presupuesto);
            Controls.Add(txtAño);
            Controls.Add(año);
            Controls.Add(txtCategoria);
            Controls.Add(categoria);
            Controls.Add(txtPaisEquipo);
            Controls.Add(pais);
            Controls.Add(addFutbolista);
            Controls.Add(addEquipo);
            Controls.Add(txtNombreEquipo);
            Controls.Add(nombreEquipo);
            Controls.Add(button1);
            Name = "Form1";
            Text = "TEMPORADA2025,";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label nombreEquipo;
        private TextBox txtNombreEquipo;
        private Button addEquipo;
        private Button addFutbolista;
        private Label pais;
        private TextBox txtPaisEquipo;
        private TextBox txtCategoria;
        private Label categoria;
        private TextBox txtPresupuesto;
        private Label presupuesto;
        private TextBox txtAño;
        private Label año;
        private TextBox txtNacionalidad;
        private Label label1;
        private TextBox txtGoles;
        private Label label2;
        private TextBox txtEdad;
        private Label label3;
        private TextBox txtEquipo;
        private Label label4;
        private TextBox txtNombreFutbolista;
        private Label label5;
        private Label label6;
        private TextBox txtIdentificacion;
        private Label label7;
        private ComboBox posicion;
        private RadioButton siLesion;
        private RadioButton noLesion;
    }
}
