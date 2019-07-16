using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTStTeste
{
    public partial class pesquisa : Form
    {
        public pesquisa()
        {
            InitializeComponent();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
            dgvpesquisa.DataSource = pes.PesquisaPorNome(txtpesquisa.Text);
            dgvpesquisa.AutoResizeColumns();

        }

        private void dgvpesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btepi_Click(object sender, EventArgs e)
        {

            
        }

        private void dgvpesquisa_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvpesquisa.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 cliente para editar", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pessoa pes = new Pessoa();
            //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
            pes.Id_Profissao = Convert.ToInt32(linha[0].Cells[7].Value);
            dgvepii.DataSource = pes.Pesquisaepi();
            dgvepii.AutoResizeColumns();
        }
    }
}
