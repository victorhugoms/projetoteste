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
    public partial class Pessoas : Form
    {
        
        public Pessoas()
        {
            InitializeComponent();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Pessoa pes = new Pessoa();

                 pes.Nome = txtNome.Text;
                pes.Email = txtEmail.Text;
                pes.Cpf = txtCpf.Text;
                pes.Dt_nascimento = Convert.ToDateTime(dtpNascimento.Text);
                pes.Endereco = txtEndereco.Text;
                pes.Bairro = txtBairro.Text;
                pes.Id_Cidade = Convert.ToInt32(cmbCidade.Text);
                pes.Id_Estado = Convert.ToInt32(cmbEstado.Text);
                pes.Cep = txtcep.Text;
                pes.Id_Turno = Convert.ToInt32(cmbTurno.SelectedValue);
                pes.Id_Profissao = Convert.ToInt32(cmbCargo.SelectedValue);

                if (txtId.Text == "")
                {
                    txtId.Text = Convert.ToString(pes.Adicionar());
                    if (dgvTelefone.Rows.Count > 0)
                    {
                        SalvaTelefones();
                    }
                }
                else
                {
                   
                }
        }

            private void SalvaTelefones()
            {
                foreach (DataGridViewRow dataGridViewRow in dgvTelefone.Rows)
                {
                    Pessoa pes = new Pessoa();
                    pes.IdCliente = Convert.ToInt32(txtId.Text);
                    if (dataGridViewRow.Cells["Telefone"].Value != null)
                    {
                        pes.AdicionarTelefone(dataGridViewRow.Cells["Telefone"].Value.ToString(), dataGridViewRow.Cells["Tipo"].Value.ToString());
                    }
                }

            }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {

            pntelefone.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EPI epi = new EPI();
            epi.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Pessoas_Load(object sender, EventArgs e)
        {
            Pessoa pessoas = new Pessoa();

            cmbEstado.DisplayMember = "SIGLA";
            cmbEstado.ValueMember = "ID_ESTADO";
            cmbEstado.DataSource = pessoas.ListaUf();
            cmbEstado.SelectedValue = 0;

            cmbCargo.DisplayMember = "CARGO_PROFISSAO";
            cmbCargo.ValueMember = "ID_PROFISSAO";
            cmbCargo.DataSource = pessoas.Profissao1();
            cmbCargo.SelectedValue = 0;

            cmbTurno.DisplayMember = "periodo";
            cmbTurno.ValueMember = "ID_TURNO";
            cmbTurno.DataSource = pessoas.Turnolista();
            cmbTurno.SelectedValue = 0;

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEstado.SelectedIndex >= 0)
            {
                Pessoa cliente = new Pessoa();
                cliente.Id_Estado = Convert.ToInt16(cmbEstado.SelectedValue);
                cmbCidade.DisplayMember = "CIDADE";
                cmbCidade.ValueMember = "ID_CIDADE";
                cmbCidade.DataSource = cliente.ListaCidade();
                cmbCidade.SelectedValue = 0;
            }
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            profissao pro = new profissao();
            pro.IdProfissao= Convert.ToInt32(cmbCargo.SelectedValue);
            //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
            dgvEpi.DataSource = pro.PesquisaPorprofissao();
            dgvEpi.AutoResizeColumns();
           

        }

        private void epi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pntelefone.Visible = false;
            DataGridViewRow row = (DataGridViewRow)dgvTelefone.Rows[0].Clone();
            row.Cells[0].Value = txttel.Text;
            row.Cells[1].Value = cmbTipo.Text;
            dgvTelefone.Rows.Add(row);
            txttel.Text = "";
            cmbTipo.SelectedValue = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvTelefone.Rows.Remove(dgvTelefone.CurrentRow);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvEpi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExames_Click(object sender, EventArgs e)
        {

        }
    }
    
}
