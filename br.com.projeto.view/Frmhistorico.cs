using Projeto_Controle_Vendas.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class Frmhistorico : Form
    {
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataincio, datafim;

            dataincio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDAO vendaDAO = new VendaDAO();

            tabelaHistorico.DataSource = vendaDAO.listarVendasPorPeriodo(dataincio, datafim);    
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            VendaDAO vendaDAO = new VendaDAO();

            tabelaHistorico.DataSource = vendaDAO.listarVendas();
        }

        private void tabelaHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_venda = int.Parse(tabelaHistorico.CurrentRow.Cells[0].Value.ToString());

            Frmdetalhes telaDetalhes = new Frmdetalhes(id_venda);

            DateTime dataVenda = Convert.ToDateTime(tabelaHistorico.CurrentRow.Cells[1].Value.ToString());

            telaDetalhes.txtdata.Text = dataVenda.ToString("dd/MM/yyyy");
            telaDetalhes.txtcliente.Text = tabelaHistorico.CurrentRow.Cells[2].Value.ToString();
            telaDetalhes.txttotal.Text = tabelaHistorico.CurrentRow.Cells[3].Value.ToString();
            telaDetalhes.txtobs.Text = tabelaHistorico.CurrentRow.Cells[4].Value.ToString();

            telaDetalhes.ShowDialog();
        }
    }
}
