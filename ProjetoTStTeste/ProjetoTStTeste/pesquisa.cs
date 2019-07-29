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
            dgvpesquisa.Columns[13].Visible = false;
            dgvpesquisa.Columns[14].Visible = false;
            dgvpesquisa.Columns[16].Visible = false;
            dgvpesquisa.Columns[8].Visible = false;
            dgvpesquisa.AutoResizeColumns();

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
            pes.Id_Profissao = Convert.ToInt32(linha[0].Cells[8].Value);
            dgvepii.DataSource = pes.Pesquisaepi();
            dgvepii.AutoResizeColumns();
            pes.IdCliente = Convert.ToInt32(linha[0].Cells[0].Value);
            dgvexame.DataSource = pes.exames();
            dgvexame.AutoResizeColumns();
            dgvexame.Columns[0].Width = 238;

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvpesquisa.SelectedRows;
            

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 cliente para editar", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Pessoa pes = new Pessoa();
            pes.IdCliente = Convert.ToInt32(linha[0].Cells[0].Value);
            pes.Nome = linha[0].Cells[1].Value.ToString();
            pes.Cpf = linha[0].Cells[2].Value.ToString();
            pes.Dt_nascimento = Convert.ToDateTime(linha[0].Cells[3].Value.ToString());
            pes.Endereco = linha[0].Cells[4].Value.ToString();
            pes.Id_Profissao = Convert.ToInt32(linha[0].Cells[8].Value);
            pes.Email = linha[0].Cells[5].Value.ToString();
            pes.Sexo = linha[0].Cells[9].Value.ToString();
            pes.Bairro = linha[0].Cells[11].Value.ToString();
            pes.Cep = linha[0].Cells[12].Value.ToString();
            pes.Id_Turno = Convert.ToInt32(linha[0].Cells[16].Value);



            if (linha[0].Cells[14].Value.ToString() != "")
            {
                pes.Id_Cidade = Convert.ToInt32(linha[0].Cells[13].Value);
            }

            if (linha[0].Cells[13].Value.ToString() != "")
            {
                pes.Id_Estado = Convert.ToInt32(linha[0].Cells[14].Value);

            }

            Pessoas Cadastro = new Pessoas();
            Cadastro.pessoa_carrega = pes;
            Cadastro.ShowDialog();
            txtpesquisa_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DataGridViewSelectedRowCollection linha_selecionada = dgvpesquisa.SelectedRows;

                if (linha_selecionada.Count != 1)
                {
                    MessageBox.Show("Selecione pelo menos 1 registro para ser removido.");
                }
                else
                {
                    Pessoa delete_cliente = new Pessoa();
                    delete_cliente.IdCliente = Convert.ToInt32(linha_selecionada[0].Cells[0].Value.ToString());
                    delete_cliente.Deletartel();
                    delete_cliente.Deletar();
                    txtpesquisa_TextChanged(sender, e);
                }
            }
        }
    }
}
