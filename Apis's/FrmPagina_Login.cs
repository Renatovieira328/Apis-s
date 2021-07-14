using System.Windows.Forms;

namespace Apis_s
{
    public partial class FrmPagina_Login : Form
    {
        public FrmPagina_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            if (TxtEmail.Text == string.Empty && TxtSenha.Text == string.Empty)
            {
                MessageBox.Show("Email e senha , precisa ser informado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEmail.Focus();
                return;

            }

            string usuario = "antonio";
            string senha = "123456";

            if (TxtEmail.Text == usuario && TxtSenha.Text == senha)
            {
                this.Hide();
                FrmPagina_inicial pagina = new FrmPagina_inicial();
                pagina.ShowDialog();

            }
            else
            {
                MessageBox.Show("Email ou usuário não cadrastrados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEmail.Focus();
                TxtEmail.Clear();
                TxtSenha.Clear();
                return;
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            FrmCadrastro cadrastro = new FrmCadrastro();
            cadrastro.ShowDialog();
        }
    }
}