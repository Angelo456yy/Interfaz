namespace Tiempo
{
    public partial class Form1 : Form
    {
        private int AValue;
        private int BValue;
        private double VCValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double distancia = Math.Abs(BValue - AValue); 

            
            double tiempo = distancia / VCValue;

            
            MessageBox.Show($"El tiempo estimado de viaje es de {tiempo} horas.", "Tiempo");
        }

        private void A_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(A.Text, out AValue);
        }

        private void B_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(B.Text, out BValue);
        }

        private void VC_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VC.Text, out VCValue);
        }

        private void T_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
