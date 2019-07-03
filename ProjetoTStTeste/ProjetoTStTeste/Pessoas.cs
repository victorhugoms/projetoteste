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
            if (txtNome.Text != "") 
            {
               
                pes.Nome = txtNome.Text;
                pes.Email = txtEmail.Text;
                pes.Cpf = mskCpf.Text;
                pes.Dt_nascimento = Convert.ToDateTime(dtpNascimento.Text);
                pes.Endereco = txtEndereco.Text;
                pes.Bairro = txtBairro.Text;
                pes.Id_Cidade = Convert.ToInt32(cmbCidade.Text);
                pes.Id_Estado = Convert.ToInt32(cmbEstado.Text);
                pes.Cep = mskCep.Text;
                pes.Id_Turno = Convert.ToInt32(cmbTurno.Text);
                pes.Id_Profissao = Convert.ToInt32(cmbCargo.Text);
                pes.Id_epi = Convert.ToInt32(epi.Text);



                if (rdbFeminino.Checked)
                {
                    pes.Sexo = 1;
                }
                else
                {
                    if (rdbMasculino.Checked)

                        pes.Sexo = 2;

                    else

                        pes.Sexo = 3;
                }

            }

           






        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {

            Telefone addPro = new Telefone();
            addPro.Show();
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
            Pessoa pessoas = new Pessoa();
            epi.DisplayMember = "descricao_epi, VALIDADE_EPI";
            epi.ValueMember = "id_epi";
            epi.DataSource = pessoas.epi1();
            epi.SelectedValue = 0;
        }

    }
    
}
