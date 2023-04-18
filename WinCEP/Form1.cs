using CEPBLL;
namespace WinCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaCEP consultaCEP = new ConsultaCEP();
            CEP cep = consultaCEP.Consultar(txtCEP.Text);
            txtEndereco.Text = cep.Logradouro;
            txtCidade.Text = $"{cep.Localidade}/{cep.Uf}";
        }
    }
}