using Apis_s.Classes;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Apis_s
{
    public partial class FrmPagina_Login : Form
    {
        Connection conn = new Connection();
        string nome, email, senha;


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
            try
            {
                if (TxtEmail.Text != "" && TxtSenha.Text != "")
                {
                    conn.open();
                    string query = "select nome,email,senha from empresa WHERE email ='" + TxtEmail.Text + "'AND senha ='" + TxtSenha.Text + "'";
                    MySqlDataReader row;
                    row = conn.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            nome = row["nome"].ToString();
                            email = row["email"].ToString();
                            senha = row["senha"].ToString();
                        }
                        MessageBox.Show("Login efetuado com sucesso! ");
                        this.Hide();
                        FrmPagina_inicial pagina_Inicial = new FrmPagina_inicial();
                        pagina_Inicial.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Dados não encomtrados");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou senha estão vazios");
                }
            }
            catch
            {
                MessageBox.Show("Erro com a conecção");
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