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
                pes.Nascimento = Convert.ToDateTime(dtpNascimento.Text);
                pes.Endereco = txtEndereco.Text;
                pes.Bairro = txtBairro.Text;
                pes.Complemento = txtComplemento.Text;
                pes.Cidade = cmbCidade.Text;
                pes.Estado = cmbEstado.Text;
                pes.Cep = mskCep.Text;
                pes.Turno = cmbTurno.Text;
                pes.Cargo = cmbCargo.Text;
                pes.Escolaridade = cmbEscolaridade.Text;




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
    }
}
