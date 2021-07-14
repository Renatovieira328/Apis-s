using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apis_s.Classes;

namespace Apis_s
{
    public partial class FrmCadrastro : Form
    {
        public FrmCadrastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaskCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Cadrastro cadrastro = new Cadrastro(
                TxtNomeEmpresa.Text,
                TxtTelefoneEmpresa.Text,
                TxtEmailEmpresa.Text,
                MaskCNPJ.Text,
                TxtSenha.Text
                );
            cadrastro.Cadrastrar_Empresa();
            MessageBox.Show("Empresa Cadrastrada");
        }
    }
}
