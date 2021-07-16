using System;
using System.Windows.Forms;

namespace Apis_s
{
    public partial class FrmPagina_inicial : Form
    {
        public FrmPagina_inicial()
        {
            InitializeComponent();
        }
        private void TsmListar_Click(object sender, EventArgs e)
        {
            FrmFuncionario_Listar frmFuncionario_Listar = new FrmFuncionario_Listar();
            frmFuncionario_Listar.Show();
        }

        private void TsmCadrastrar_Click(object sender, EventArgs e)
        {
            FrmFuncionario_Cadrastro frmFuncionario_Cadrastro = new FrmFuncionario_Cadrastro();
            frmFuncionario_Cadrastro.Show();
        }

        private void FrmPagina_inicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFuncionario_Cadrastro frmFuncionario_Cadrastro = new FrmFuncionario_Cadrastro();
            frmFuncionario_Cadrastro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFuncionario_Listar frmFuncionario_Listar = new FrmFuncionario_Listar();
            frmFuncionario_Listar.ShowDialog();
        }
    }
}
