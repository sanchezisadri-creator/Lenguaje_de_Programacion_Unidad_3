namespace Ejercicio_7
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
            txtInicio = new TextBox();
            label2 = new Label();
            txtFin = new TextBox();
            btnGenerar = new Button();
            lstPrimos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 49);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "inicio";
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(240, 89);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(204, 27);
            txtInicio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 49);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 2;
            label2.Text = "fin";
            // 
            // txtFin
            // 
            txtFin.Location = new Point(498, 89);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(194, 27);
            txtFin.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(287, 159);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(134, 26);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "ver primos";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lstPrimos
            // 
            lstPrimos.FormattingEnabled = true;
            lstPrimos.Location = new Point(451, 138);
            lstPrimos.Name = "lstPrimos";
            lstPrimos.Size = new Size(304, 104);
            lstPrimos.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPrimos);
            Controls.Add(btnGenerar);
            Controls.Add(txtFin);
            Controls.Add(label2);
            Controls.Add(txtInicio);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInicio;
        private Label label2;
        private TextBox txtFin;
        private Button btnGenerar;
        private ListBox lstPrimos;
    }
}
