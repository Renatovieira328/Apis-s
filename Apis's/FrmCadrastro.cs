using Apis_s.Classes;
using System;
using System.Windows.Forms;

namespace Apis_s
{
    public partial class FrmCadrastro : Form
    {
        public FrmCadrastro()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbTiopoCadrastro.Text == "Empresa")
            {
                groupBox2.Visible = false;
                groupBox1.Visible = true;
            }
            else if (CbTiopoCadrastro.Text == "Cliente")
            {
                groupBox2.Visible = true;
                groupBox1.Visible = false;
            }
        }

        private void txtSenha2_TextChanged(object sender, EventArgs e)
        {
            string senha1 = txtSenha1.Text;
            string senha2 = TxtSenha2.Text;

            if (senha2.Equals(senha1))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaskCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Cadrastro cadrastro = new Cadrastro(
                TxtNomeEmpresa.Text,
                TxtTelefoneEmpresa.Text,
                TxtEmailEmpresa.Text,
                MaskCNPJ.Text,
                TxtSenha2.Text
                );
            cadrastro.Cadrastrar_Empresa();
            MessageBox.Show("Empresa Cadrastrada");
        }
        private void txtSenha4_TextChanged(object sender, EventArgs e)
        {
            string senha3 = TxtSenha3.Text;
            string senha4 = TxtSenha4.Text;

            if (senha4.Equals(senha3))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MskCPFCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Cliente cliente = new Cliente(
                TxtNomeCliente.Text,
                TxtEmailCliente.Text,
                TxtSenha4.Text,
                MskCPFCliente.Text
                );
            cliente.Cadrastrar_Cliente();
            MessageBox.Show("Cliente cadrastrado");
        }
    }
}
