﻿using System;
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

        public Pessoa pessoa_carrega;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCPF(txtCpf.Text))
            {

                Pessoa pes = new Pessoa();

                pes.Nome = txtNome.Text;
                pes.Email = txtEmail.Text;
                pes.Cpf = txtCpf.Text;
                pes.Dt_nascimento = Convert.ToDateTime(txtdata.Text);
                pes.Endereco = txtEndereco.Text;
                pes.Bairro = txtBairro.Text;
                pes.Id_Cidade = Convert.ToInt32(cmbCidade.SelectedValue);
                pes.Id_Estado = Convert.ToInt32(cmbEstado.SelectedValue);
                pes.Cep = txtcep.Text;
                pes.Id_Profissao = Convert.ToInt32(cmbCargo.SelectedValue);
                pes.Id_Turno = Convert.ToInt32(cmbTurno.SelectedValue);
               
               
                
                if (rdbFeminino.Checked)
                {
                    pes.Sexo = "Feminino";
                }
                else
                {
                    pes.Sexo = "Masculino";
                }

                if (rdbEmdia.Checked)
                {
                    pes.Exame = 1;
                }
                else
                {
                    pes.Exame = 0;
                }

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
                    pes.IdCliente = Convert.ToInt32(txtId.Text);
                    pes.Atualizar();
                }
            }
            else
            {
                MessageBox.Show("CPF inválido!");
            }

            this.Close();
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
            if (cmbEstado.SelectedIndex >= 0)
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
            pro.IdProfissao = Convert.ToInt32(cmbCargo.SelectedValue);
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

        private void Pessoas_Shown(object sender, EventArgs e)
        {
           
            if (pessoa_carrega != null)
            {
                txtId.Text = pessoa_carrega.IdCliente.ToString();
                txtNome.Text = pessoa_carrega.Nome;
                txtEmail.Text = pessoa_carrega.Email;
                txtCpf.Text = pessoa_carrega.Cpf;
                txtdata.Text = pessoa_carrega.Dt_nascimento.ToShortDateString();
                txtEndereco.Text = pessoa_carrega.Endereco;
                txtBairro.Text = pessoa_carrega.Bairro;
                txtcep.Text = pessoa_carrega.Cep;
                txtEmail.Text = pessoa_carrega.Email;
               


                if (pessoa_carrega.Id_Estado != null)
                {
                    cmbEstado.SelectedValue = pessoa_carrega.Id_Estado;
                }

                if (pessoa_carrega.Id_Cidade != null)
                {
                    cmbCidade.SelectedValue = pessoa_carrega.Id_Cidade;
                }

                if(pessoa_carrega.Id_Profissao != null)
                {
                    cmbCargo.SelectedValue = pessoa_carrega.Id_Profissao;
                }

                if (pessoa_carrega.Id_Turno != null)
                {
                    cmbTurno.SelectedValue = pessoa_carrega.Id_Turno;
                }
                if (pessoa_carrega.IdCliente != null)
                {
                    dgvTelefone.Columns[0].Visible = false;
                    dgvTelefone.Columns[1].Visible = false;
                    dgvTelefone.DataSource = pessoa_carrega.Pesquisatelefone();
                    dgvTelefone.AutoResizeColumns();
                }
               
                


                if (txtId.Text != "")
                {
                   
                    btnSalvar.Text = "Atualizar";
                }

            }
            


        }

        public bool ValidaCPF(string cpf)

        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtcep_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

    }
}
