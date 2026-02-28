namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(maskedTextBox1.Text);
            int Sumadivisores = 0;

            for (int i = 1; i <= Numero / 2; i++)
            {
                if (Numero % i == 0)
                {
                    Sumadivisores = Sumadivisores + i;
                }

            }
            if (Sumadivisores == Numero) 
            {
                MessageBox.Show("El numero es perfecto");
            }
            else
            {
                MessageBox.Show("El numero no es perfecto");
            }
        }
    }
}
