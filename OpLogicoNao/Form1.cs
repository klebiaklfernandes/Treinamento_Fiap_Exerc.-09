namespace OpLogicoNao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnVerificar_Click(object sender, EventArgs e)
        {
            string tipoUser;
            tipoUser = txtTipo.Text;

            if (!(tipoUser == "ADMINISTRADOR"))
            {
                MessageBox.Show("Sem poderes administrativos!", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Olá administrador!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}