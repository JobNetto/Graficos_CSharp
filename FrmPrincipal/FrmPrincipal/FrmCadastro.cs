using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }
        public Candidato c;
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            c = new Candidato
            {
                Nome = txtNome.Text + " (" + txtPartido.Text + ") - " + txtNumero.Text,
                Totalvotos = int.Parse(txtVotos.Text)
            };
            Close();
        }
    }
}
