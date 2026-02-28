namespace Ejercicio8
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
            label1 = new Label();
            txtOracion = new TextBox();
            btnContar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 36);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite una oración:";
            // 
            // txtOracion
            // 
            txtOracion.Location = new Point(210, 59);
            txtOracion.Name = "txtOracion";
            txtOracion.Size = new Size(239, 27);
            txtOracion.TabIndex = 1;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(232, 92);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(176, 84);
            btnContar.TabIndex = 2;
            btnContar.Text = "Contar Palabras";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(628, 66);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(81, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "palabras: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnContar);
            Controls.Add(txtOracion);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOracion;
        private Button btnContar;
        private Label lblResultado;
    }
}
