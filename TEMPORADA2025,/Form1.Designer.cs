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
            label1 = new Label();
            txtFutbolistasList = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(12, 362);
            button1.Name = "button1";
            button1.Size = new Size(700, 36);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Pruebas";
            // 
            // txtFutbolistasList
            // 
            txtFutbolistasList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFutbolistasList.Location = new Point(12, 163);
            txtFutbolistasList.Name = "txtFutbolistasList";
            txtFutbolistasList.Size = new Size(700, 27);
            txtFutbolistasList.TabIndex = 2;
            txtFutbolistasList.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(724, 410);
            Controls.Add(txtFutbolistasList);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "TEMPORADA2025,";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtFutbolistasList;
    }
}
