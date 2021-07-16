using Apis_s.Classes;
using System;
using System.Windows.Forms;

namespace Apis_s
{
    public partial class FrmFuncionario_Cadrastro : Form
    {
        public FrmFuncionario_Cadrastro()
        {
            InitializeComponent();
        }
        private void Senha2_TextChanged(object sender, EventArgs e)
        {
            string senha1 = Senha1.Text;
            string senha2 = Senha2.Text;

            if (senha2.Equals(senha1))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
        private void FrmFuncionario_Cadrastro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            Funcionario funcionario = new Funcionario(
            TxtNomeFuncionario.Text,
            TxtEmailFuncionario.Text,
            Senha2.Text
            );
            funcionario.Cadrastrar_Funcionario();
            MessageBox.Show("Funcionario cadrastrado");
        }
    }
}
