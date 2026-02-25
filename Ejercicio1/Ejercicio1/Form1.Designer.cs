namespace Ejercicio1
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
            txtNumero = new TextBox();
            label1 = new Label();
            btnGenerar = new Button();
            lstTabla = new ListBox();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(42, 70);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(228, 27);
            txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 35);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 1;
            label1.Text = "ingrese un numero debajo";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(42, 103);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(161, 100);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar tabla";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.Location = new Point(381, 54);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(211, 124);
            lstTabla.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstTabla);
            Controls.Add(btnGenerar);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label label1;
        private Button btnGenerar;
        private ListBox lstTabla;
    }
}
