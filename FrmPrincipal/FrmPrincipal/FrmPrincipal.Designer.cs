namespace FrmPrincipal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btImportarCanditato = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btCadastroCandidato = new System.Windows.Forms.ToolStripMenuItem();
            this.votosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btCadastroVto = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeGráficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btColuna = new System.Windows.Forms.ToolStripMenuItem();
            this.btBarra = new System.Windows.Forms.ToolStripMenuItem();
            this.btPizza = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.votosToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btImportarCanditato});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // btImportarCanditato
            // 
            this.btImportarCanditato.Name = "btImportarCanditato";
            this.btImportarCanditato.Size = new System.Drawing.Size(172, 22);
            this.btImportarCanditato.Text = "Importar resultado";
            this.btImportarCanditato.Click += new System.EventHandler(this.btImportarCanditato_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCadastroCandidato});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.cadastroToolStripMenuItem.Text = "Candidato";
            // 
            // btCadastroCandidato
            // 
            this.btCadastroCandidato.Name = "btCadastroCandidato";
            this.btCadastroCandidato.Size = new System.Drawing.Size(182, 22);
            this.btCadastroCandidato.Text = "Cadastrar Candidato";
            this.btCadastroCandidato.Click += new System.EventHandler(this.btCadastroCandidato_Click);
            // 
            // votosToolStripMenuItem
            // 
            this.votosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCadastroVto});
            this.votosToolStripMenuItem.Name = "votosToolStripMenuItem";
            this.votosToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.votosToolStripMenuItem.Text = "Votos";
            // 
            // btCadastroVto
            // 
            this.btCadastroVto.Name = "btCadastroVto";
            this.btCadastroVto.Size = new System.Drawing.Size(157, 22);
            this.btCadastroVto.Text = "Adicionar votos";
            this.btCadastroVto.Click += new System.EventHandler(this.btCadastroVto_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeGráficoToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // tipoDeGráficoToolStripMenuItem
            // 
            this.tipoDeGráficoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btColuna,
            this.btBarra,
            this.btPizza});
            this.tipoDeGráficoToolStripMenuItem.Name = "tipoDeGráficoToolStripMenuItem";
            this.tipoDeGráficoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.tipoDeGráficoToolStripMenuItem.Text = "Tipo de Gráfico";
            // 
            // btColuna
            // 
            this.btColuna.Name = "btColuna";
            this.btColuna.Size = new System.Drawing.Size(112, 22);
            this.btColuna.Text = "Coluna";
            this.btColuna.Click += new System.EventHandler(this.btColuna_Click);
            // 
            // btBarra
            // 
            this.btBarra.Name = "btBarra";
            this.btBarra.Size = new System.Drawing.Size(112, 22);
            this.btBarra.Text = "Barra";
            this.btBarra.Click += new System.EventHandler(this.btBarra_Click);
            // 
            // btPizza
            // 
            this.btPizza.Name = "btPizza";
            this.btPizza.Size = new System.Drawing.Size(112, 22);
            this.btPizza.Text = "Pizza";
            this.btPizza.Click += new System.EventHandler(this.btPizza_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 24);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Votos";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(844, 361);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Gráfico Pesquisa Eleitoral";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 385);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btImportarCanditato;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btCadastroCandidato;
        private System.Windows.Forms.ToolStripMenuItem votosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btCadastroVto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeGráficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btColuna;
        private System.Windows.Forms.ToolStripMenuItem btBarra;
        private System.Windows.Forms.ToolStripMenuItem btPizza;
    }
}

