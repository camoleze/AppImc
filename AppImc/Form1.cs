namespace AppImc
{
    public partial class frmImc : Form
    {
        public frmImc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, result;

            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);

            result = peso / (altura * altura);

            label3.Text ="Resultado : " + result.ToString("F");

        }
    }
}