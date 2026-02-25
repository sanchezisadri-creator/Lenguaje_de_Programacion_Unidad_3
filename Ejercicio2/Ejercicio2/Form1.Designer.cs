namespace Ejercicio2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtMinutos = new TextBox();
            txtSegundos = new TextBox();
            lblTiempo = new Label();
            btnIniciar = new Button();
            btnDetener = new Button();
            btnReiniciar = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(139, 75);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(207, 27);
            txtMinutos.TabIndex = 0;
            // 
            // txtSegundos
            // 
            txtSegundos.Location = new Point(373, 75);
            txtSegundos.Name = "txtSegundos";
            txtSegundos.Size = new Size(205, 27);
            txtSegundos.TabIndex = 1;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(337, 26);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(44, 20);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "00:00";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(170, 132);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(130, 39);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(377, 132);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(132, 39);
            btnDetener.TabIndex = 4;
            btnDetener.Text = "detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(281, 187);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(124, 40);
            btnReiniciar.TabIndex = 5;
            btnReiniciar.Text = "reinicio";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(242, 251);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(231, 66);
            progressBar1.TabIndex = 6;
            progressBar1.Click += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(btnReiniciar);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(lblTiempo);
            Controls.Add(txtSegundos);
            Controls.Add(txtMinutos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMinutos;
        private TextBox txtSegundos;
        private Label lblTiempo;
        private Button btnIniciar;
        private Button btnDetener;
        private Button btnReiniciar;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}