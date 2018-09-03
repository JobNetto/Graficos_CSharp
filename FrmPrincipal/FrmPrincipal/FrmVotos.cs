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
    public partial class FrmVotos : Form
    {
        public FrmVotos()
        {
            InitializeComponent();
        }

        public string canditadoSelecionado { get; set; }
        public int voto { get; set; }

        public List<Candidato> l;
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            canditadoSelecionado = cbCanditados.SelectedItem.ToString();
            voto = int.Parse(textBox1.Text);
            Close();
        }

        private void FrmVotos_Load(object sender, EventArgs e)
        {
            foreach(var i in l)
            {
                cbCanditados.Items.Add(i.Nome);
            }

            cbCanditados.SelectedIndex = 0;
        }
    }
}
