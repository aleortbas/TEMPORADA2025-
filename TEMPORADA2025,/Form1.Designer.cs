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
            cambioForm = new Button();
            nombreEquipo = new Label();
            txtNombreEquipo = new TextBox();
            addEquipo = new Button();
            addFutbolista = new Button();
            pais = new Label();
            txtPaisEquipo = new TextBox();
            categoria = new Label();
            txtPresupuesto = new TextBox();
            presupuesto = new Label();
            año = new Label();
            txtNacionalidad = new TextBox();
            label1 = new Label();
            txtGoles = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtNombreFutbolista = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            posicion = new ComboBox();
            siLesion = new RadioButton();
            noLesion = new RadioButton();
            Acategoria = new RadioButton();
            Bcategoria = new RadioButton();
            Ccategoria = new RadioButton();
            anoFundacion = new DateTimePicker();
            Codigo = new Label();
            codigoEquipo = new TextBox();
            listaEquipos = new ComboBox();
            SuspendLayout();
            // 
            // cambioForm
            // 
            cambioForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cambioForm.Location = new Point(12, 602);
            cambioForm.Name = "cambioForm";
            cambioForm.Size = new Size(700, 55);
            cambioForm.TabIndex = 0;
            cambioForm.Text = "Ir a estadisticas";
            cambioForm.UseVisualStyleBackColor = true;
            cambioForm.Click += button1_Click;
            // 
            // nombreEquipo
            // 
            nombreEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            nombreEquipo.AutoSize = true;
            nombreEquipo.Location = new Point(12, 72);
            nombreEquipo.Name = "nombreEquipo";
            nombreEquipo.Size = new Size(64, 20);
            nombreEquipo.TabIndex = 1;
            nombreEquipo.Text = "Nombre";
            nombreEquipo.Click += label1_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombreEquipo.Location = new Point(12, 95);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(253, 27);
            txtNombreEquipo.TabIndex = 2;
            txtNombreEquipo.TextChanged += txtFutbolistasList_TextChanged;
            // 
            // addEquipo
            // 
            addEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            addEquipo.Location = new Point(12, 373);
            addEquipo.Name = "addEquipo";
            addEquipo.Size = new Size(94, 29);
            addEquipo.TabIndex = 3;
            addEquipo.Text = "Equipo";
            addEquipo.UseVisualStyleBackColor = true;
            addEquipo.Click += addEquipo_Click;
            // 
            // addFutbolista
            // 
            addFutbolista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            addFutbolista.Location = new Point(423, 513);
            addFutbolista.Name = "addFutbolista";
            addFutbolista.Size = new Size(94, 29);
            addFutbolista.TabIndex = 4;
            addFutbolista.Text = "Futbolista";
            addFutbolista.UseVisualStyleBackColor = true;
            addFutbolista.Click += addFutbolista_Click;
            // 
            // pais
            // 
            pais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pais.AutoSize = true;
            pais.Location = new Point(12, 135);
            pais.Name = "pais";
            pais.Size = new Size(34, 20);
            pais.TabIndex = 5;
            pais.Text = "Pais";
            // 
            // txtPaisEquipo
            // 
            txtPaisEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPaisEquipo.Location = new Point(12, 158);
            txtPaisEquipo.Name = "txtPaisEquipo";
            txtPaisEquipo.Size = new Size(253, 27);
            txtPaisEquipo.TabIndex = 6;
            // 
            // categoria
            // 
            categoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            categoria.AutoSize = true;
            categoria.Location = new Point(12, 193);
            categoria.Name = "categoria";
            categoria.Size = new Size(74, 20);
            categoria.TabIndex = 7;
            categoria.Text = "Categoria";
            categoria.Click += label3_Click;
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPresupuesto.Location = new Point(12, 329);
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.Size = new Size(253, 27);
            txtPresupuesto.TabIndex = 12;
            // 
            // presupuesto
            // 
            presupuesto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            presupuesto.AutoSize = true;
            presupuesto.Location = new Point(12, 306);
            presupuesto.Name = "presupuesto";
            presupuesto.Size = new Size(89, 20);
            presupuesto.TabIndex = 11;
            presupuesto.Text = "Presupuesto";
            // 
            // año
            // 
            año.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            año.AutoSize = true;
            año.Location = new Point(12, 248);
            año.Name = "año";
            año.Size = new Size(36, 20);
            año.TabIndex = 9;
            año.Text = "Año";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtNacionalidad.Location = new Point(423, 284);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(253, 27);
            txtNacionalidad.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(423, 261);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 21;
            label1.Text = "Nacionalidad";
            label1.Click += label1_Click_1;
            // 
            // txtGoles
            // 
            txtGoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtGoles.Location = new Point(423, 222);
            txtGoles.Name = "txtGoles";
            txtGoles.Size = new Size(253, 27);
            txtGoles.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(423, 199);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 19;
            label2.Text = "Goles";
            // 
            // txtEdad
            // 
            txtEdad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtEdad.Location = new Point(423, 154);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(253, 27);
            txtEdad.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(423, 131);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 17;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(423, 73);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 15;
            label4.Text = "Equipo";
            label4.Click += label4_Click;
            // 
            // txtNombreFutbolista
            // 
            txtNombreFutbolista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtNombreFutbolista.Location = new Point(423, 33);
            txtNombreFutbolista.Name = "txtNombreFutbolista";
            txtNombreFutbolista.Size = new Size(253, 27);
            txtNombreFutbolista.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(423, 10);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 13;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(423, 406);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 23;
            label6.Text = "Lesiones";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(423, 323);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 25;
            label7.Text = "Posicion";
            // 
            // posicion
            // 
            posicion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            posicion.FormattingEnabled = true;
            posicion.Items.AddRange(new object[] { "Arquero", "Defensa", "Medio", "Delantero" });
            posicion.Location = new Point(423, 360);
            posicion.Name = "posicion";
            posicion.Size = new Size(253, 28);
            posicion.TabIndex = 26;
            posicion.SelectedIndexChanged += posicion_SelectedIndexChanged;
            // 
            // siLesion
            // 
            siLesion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            siLesion.AutoSize = true;
            siLesion.Location = new Point(423, 440);
            siLesion.Name = "siLesion";
            siLesion.Size = new Size(42, 24);
            siLesion.TabIndex = 27;
            siLesion.Text = "Si";
            siLesion.UseVisualStyleBackColor = true;
            siLesion.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // noLesion
            // 
            noLesion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            noLesion.AutoSize = true;
            noLesion.Location = new Point(423, 470);
            noLesion.Name = "noLesion";
            noLesion.Size = new Size(50, 24);
            noLesion.TabIndex = 28;
            noLesion.Text = "No";
            noLesion.UseVisualStyleBackColor = true;
            noLesion.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Acategoria
            // 
            Acategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Acategoria.AutoSize = true;
            Acategoria.Location = new Point(12, 221);
            Acategoria.Name = "Acategoria";
            Acategoria.Size = new Size(40, 24);
            Acategoria.TabIndex = 29;
            Acategoria.Text = "A";
            Acategoria.UseVisualStyleBackColor = true;
            // 
            // Bcategoria
            // 
            Bcategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Bcategoria.AutoSize = true;
            Bcategoria.Location = new Point(58, 221);
            Bcategoria.Name = "Bcategoria";
            Bcategoria.Size = new Size(39, 24);
            Bcategoria.TabIndex = 30;
            Bcategoria.Text = "B";
            Bcategoria.UseVisualStyleBackColor = true;
            // 
            // Ccategoria
            // 
            Ccategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Ccategoria.AutoSize = true;
            Ccategoria.Location = new Point(104, 221);
            Ccategoria.Name = "Ccategoria";
            Ccategoria.Size = new Size(39, 24);
            Ccategoria.TabIndex = 31;
            Ccategoria.Text = "C";
            Ccategoria.UseVisualStyleBackColor = true;
            // 
            // anoFundacion
            // 
            anoFundacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            anoFundacion.Location = new Point(12, 271);
            anoFundacion.Name = "anoFundacion";
            anoFundacion.Size = new Size(273, 27);
            anoFundacion.TabIndex = 32;
            // 
            // Codigo
            // 
            Codigo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Codigo.AutoSize = true;
            Codigo.Location = new Point(12, 9);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(58, 20);
            Codigo.TabIndex = 33;
            Codigo.Text = "Codigo";
            // 
            // codigoEquipo
            // 
            codigoEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            codigoEquipo.Location = new Point(12, 32);
            codigoEquipo.MaxLength = 3;
            codigoEquipo.Name = "codigoEquipo";
            codigoEquipo.Size = new Size(253, 27);
            codigoEquipo.TabIndex = 34;
            codigoEquipo.TextChanged += codigoEquipo_TextChanged;
            codigoEquipo.KeyPress += codigoEquipo_KeyPress;
            // 
            // listaEquipos
            // 
            listaEquipos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listaEquipos.FormattingEnabled = true;
            listaEquipos.Items.AddRange(new object[] { "Arquero", "Defensa", "Medio", "Delantero" });
            listaEquipos.Location = new Point(423, 100);
            listaEquipos.Name = "listaEquipos";
            listaEquipos.Size = new Size(253, 28);
            listaEquipos.TabIndex = 35;
            listaEquipos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(724, 669);
            Controls.Add(listaEquipos);
            Controls.Add(codigoEquipo);
            Controls.Add(Codigo);
            Controls.Add(anoFundacion);
            Controls.Add(Ccategoria);
            Controls.Add(Bcategoria);
            Controls.Add(Acategoria);
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
            Controls.Add(label4);
            Controls.Add(txtNombreFutbolista);
            Controls.Add(label5);
            Controls.Add(txtPresupuesto);
            Controls.Add(presupuesto);
            Controls.Add(año);
            Controls.Add(categoria);
            Controls.Add(txtPaisEquipo);
            Controls.Add(pais);
            Controls.Add(addFutbolista);
            Controls.Add(addEquipo);
            Controls.Add(txtNombreEquipo);
            Controls.Add(nombreEquipo);
            Controls.Add(cambioForm);
            Name = "Form1";
            Text = "TEMPORADA2025,";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cambioForm;
        private Label nombreEquipo;
        private TextBox txtNombreEquipo;
        private Button addEquipo;
        private Button addFutbolista;
        private Label pais;
        private TextBox txtPaisEquipo;
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
        private Label label4;
        private TextBox txtNombreFutbolista;
        private Label label5;
        private Label label6;
        private TextBox txtIdentificacion;
        private Label label7;
        private ComboBox posicion;
        private RadioButton siLesion;
        private RadioButton noLesion;
        private RadioButton Acategoria;
        private RadioButton Bcategoria;
        private RadioButton Ccategoria;
        private DateTimePicker anoFundacion;
        private Label Codigo;
        private TextBox codigoEquipo;
        private ComboBox listaEquipos;
    }
}
