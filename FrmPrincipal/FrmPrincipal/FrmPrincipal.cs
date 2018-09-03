using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            candidatos = new List<Candidato>();

        }

        private List<string> l;
        private List<Candidato> candidatos { get; set; }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void CarregaCadidatos()
        {
            openFileDialog1.ShowDialog();
            var caminho = openFileDialog1.FileName;
            openFileDialog1.Dispose();

            System.IO.StreamReader file =
    new System.IO.StreamReader(caminho);
            l = new List<string>();
            string line = null;
            while (true)
            {
                line = file.ReadLine();
                if (line == null) break;
                l.Add(line);
            }

            foreach (var i in l)
            {
                candidatos.Add(new Candidato { Nome = i.Split(';')[0], Totalvotos = int.Parse(i.Split(';')[1]) });
            }

            CarregaChart();
        }
        private void CarregaChart()
        {
            chart1.Series["Votos"].Points.Clear();
            foreach (var item in candidatos)
            {
                chart1.Series["Votos"].Points.AddXY(item.Nome, item.Totalvotos);
            }

        }

        private void btImportarCanditato_Click(object sender, EventArgs e)
        {
            CarregaCadidatos();
        }

        private void btCadastroCandidato_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadastro();
            frm.ShowDialog();
            candidatos.Add(frm.c);
            frm.Dispose();
            chart1.Series["Votos"].Points.AddXY(candidatos.Last().Nome, candidatos.Last().Totalvotos);

        }

        private void btCadastroVto_Click(object sender, EventArgs e)
        {
            var frm = new FrmVotos();
            frm.l = candidatos;
            frm.ShowDialog();
            foreach (var i in candidatos)
            {
                if (frm.canditadoSelecionado == i.Nome)
                {
                    i.Totalvotos += frm.voto;
                }
            }
            frm.Close();

            CarregaChart();
        }

        private void btColuna_Click(object sender, EventArgs e)
        {
            chart1.Series["Votos"].ChartType = SeriesChartType.Column;
        }

        private void btBarra_Click(object sender, EventArgs e)
        {
            chart1.Series["Votos"].ChartType = SeriesChartType.Bar;
        }

        private void btPizza_Click(object sender, EventArgs e)
        {
            chart1.Series["Votos"].ChartType = SeriesChartType.Pie;
        }
    }
}
