namespace Ejercicio3
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
            label2 = new Label();
            label3 = new Label();
            txtValor = new TextBox();
            cmbDe = new ComboBox();
            cmbA = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 95);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 172);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 2;
            label2.Text = "de";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 248);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 3;
            label3.Text = "a";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(313, 125);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(172, 27);
            txtValor.TabIndex = 4;
            // 
            // cmbDe
            // 
            cmbDe.FormattingEnabled = true;
            cmbDe.Location = new Point(333, 195);
            cmbDe.Name = "cmbDe";
            cmbDe.Size = new Size(138, 28);
            cmbDe.TabIndex = 5;
            // 
            // cmbA
            // 
            cmbA.FormattingEnabled = true;
            cmbA.Location = new Point(333, 271);
            cmbA.Name = "cmbA";
            cmbA.Size = new Size(140, 28);
            cmbA.TabIndex = 6;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(313, 322);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(196, 91);
            btnConvertir.TabIndex = 7;
            btnConvertir.Text = "convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(450, 77);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbA);
            Controls.Add(cmbDe);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtValor;
        private ComboBox cmbDe;
        private ComboBox cmbA;
        private Button btnConvertir;
        private Label lblResultado;
    }
}
