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
    public partial class Cadastro : Form
    {

        public Cadastro()
        {
            InitializeComponent();

        }

        public Pessoa pessoa_carrega;
        public CadastrarUsuario cadastrar;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCPF(mskcpf.Text))
            {
                if (msknascimento.Text == "" && txtNome.Text == "")
                {

                    Pessoa pes = new Pessoa();

                    pes.Status = 1;
                    pes.Nome = txtNome.Text;
                    pes.Email = txtEmail.Text;
                    pes.Cpf = mskcpf.Text;
                    pes.Dt_nascimento = Convert.ToDateTime(msknascimento.Text);
                    pes.Endereco = txtEndereco.Text;
                    pes.Bairro = txtBairro.Text;
                    pes.Id_Cidade = Convert.ToInt32(cmbCidade.SelectedValue);
                    pes.Id_Estado = Convert.ToInt32(cmbEstado.SelectedValue);
                    pes.Cep = mskCEP.Text;
                    pes.Id_Profissao = Convert.ToInt32(cmbCargo.SelectedValue);
                    pes.Id_Turno = Convert.ToInt32(cmbTurno.SelectedValue);
                    pes.Usuario = txtusuario.Text;
                    pes.Senha = txtsenha.Text;

                    if (pes.Id_Profissao == 6)
                    {
                        pes.Administrador = 1;
                    }
                    else
                    {
                        pes.Administrador = 0;
                    }


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
                    if (rdbPendente.Checked)
                    {
                        pes.Exame = 0;
                    }

                    if (txtId.Text == "")
                    {

                        txtId.Text = Convert.ToString(pes.Adicionar());

                        if (dgvTelefone.Rows.Count > 0)
                        {


                            SalvaTelefones();
                            this.Close();

                        }
                    }
                    else
                    {
                        pes.Id_Funcionario = Convert.ToInt32(txtId.Text);
                        pes.Atualizar();
                    }
                }
                else
                {
                    MessageBox.Show("data");
                }


            }
            else
            {
                MessageBox.Show("CPF inválido!");
            }

                
            

           
        }

        private void SalvaTelefones()
        {
            foreach (DataGridViewRow dataGridViewRow in dgvTelefone.Rows)
            {
                Pessoa pes = new Pessoa();
                pes.Id_Funcionario = Convert.ToInt32(txtId.Text);
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
                Pessoa funcionario = new Pessoa();
                funcionario.Id_Estado = Convert.ToInt16(cmbEstado.SelectedValue);
                cmbCidade.DisplayMember = "CIDADE";
                cmbCidade.ValueMember = "ID_CIDADE";
                cmbCidade.DataSource = funcionario.ListaCidade();
                cmbCidade.SelectedValue = 0;
            }
        }

        

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            profissao pro = new profissao();
            pro.IdProfissao = Convert.ToInt32(cmbCargo.SelectedValue);
            //Mapeia a origem dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
            dgvEpi.DataSource = pro.PesquisaPorprofissao();
            dgvEpi.AutoResizeColumns();

            CadastrarUsuario Usuario = new CadastrarUsuario();

            
              
            

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();



            if (txtId.Text == "")
            {
                pntelefone.Visible = false;
                DataGridViewRow row = (DataGridViewRow)dgvTelefone.Rows[0].Clone();
                if (mskTel.Text != "")
                {
                    row.Cells[0].Value = mskTel.Text;
                    row.Cells[1].Value = cmbTipo.Text;
                    dgvTelefone.Rows.Add(row);
                    mskTel.Text = "";
                    cmbTipo.SelectedValue = 0;
                }
                else
                {
                    MessageBox.Show("Adicione um número", "Sem número", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


            }
            else
            {
                DataGridViewSelectedRowCollection linha = dgvTelefone.SelectedRows;

                

                Telefones tel = new Telefones();
                tel.Id_Funcionario = Convert.ToInt32(txtId.Text);
                tel.Numero = mskTel.Text;
                tel.Tipo = cmbTipo.Text;
                tel.AdicionarTelefone();

                pntelefone.Visible = false;
                dgvTelefone.DataSource = pessoa_carrega.Pesquisatelefone();
                dgvTelefone.AutoResizeColumns();

            }


            
        }


        private void Pessoas_Shown(object sender, EventArgs e)
        {
           
               
            

            if (pessoa_carrega != null)
            {
                txtId.Text = pessoa_carrega.Id_Funcionario.ToString();
                txtNome.Text = pessoa_carrega.Nome;
                txtEmail.Text = pessoa_carrega.Email;
                mskcpf.Text = pessoa_carrega.Cpf;
                msknascimento.Text = pessoa_carrega.Dt_nascimento.ToShortDateString();
                txtEndereco.Text = pessoa_carrega.Endereco;
                txtBairro.Text = pessoa_carrega.Bairro;
                mskCEP.Text = pessoa_carrega.Cep;
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
                if (pessoa_carrega.Id_Funcionario != null)
                {
                    dgvTelefone.Columns[0].Visible = false;
                    dgvTelefone.Columns[1].Visible = false;
                    dgvTelefone.DataSource = pessoa_carrega.Pesquisatelefone();
                    dgvTelefone.AutoResizeColumns();
                    dgvTelefone.Columns[4].Visible = false;
                    grblogin.Visible = false;


                }
                if (pessoa_carrega.Exame == 0)
                {
                    rdbPendente.Checked = true;
                }
                
             
                if (txtId.Text != "")
                {
                   
                    btnSalvar.Text = "Atualizar";
                }

                Pessoa pes = new Pessoa();
                groupBox1.Visible = false;
               
                
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

        private void btnremover_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvTelefone.SelectedRows;

            Pessoa pes = new Pessoa();

            if (txtId.Text != "")
            {
                if (linha.Count != 0)
                { 
                    Telefones tel = new Telefones();
                tel.Telefone = Convert.ToInt32(linha[0].Cells[4].Value);
                tel.Deletartel2();
                dgvTelefone.Rows.Remove(dgvTelefone.CurrentRow);
                }
                
            }
            else
            {
                if ( (linha.Count != 0) && (linha[0].Cells[0].Value != null) )
                {
                    dgvTelefone.Rows.Remove(dgvTelefone.CurrentRow);
                    
                }
                else
                {
                    MessageBox.Show("Não contem Telefone", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

       

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                mskTel.Mask = "(00)0000-0000";
               

            }
            if (cmbTipo.SelectedIndex == 1)
            {
                mskTel.Mask = "(00)00000-0000";

            }
            if (cmbTipo.SelectedIndex == 2)
            {
                mskTel.Mask = "(00)00000-0000";

            }
            if (cmbTipo.SelectedIndex == 3)
            {
                mskTel.Mask = "0000-0000";

            }
            if (cmbTipo.SelectedIndex == 4)
            {
                mskTel.Mask = "(00)0000-0000";

            }

            
        }

        private void mskcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private delegate void PosicionaCursorDelegate(int posicao);

        private void PosicionaCursor(int posicao)
        {
            mskcpf.SelectionStart = posicao;
        }

        private void mskcpf_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { 0 });
        }

        private void msknascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private delegate void PosicionaCursorDelegate2(int posicao);

        private void PosicionaCursor2(int posicao)
        {
            msknascimento.SelectionStart = posicao;
        }

        private void msknascimento_Enter_1(object sender, EventArgs e)
        {
            this.BeginInvoke(new PosicionaCursorDelegate2(PosicionaCursor2), new object[] { 0 });
        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private delegate void PosicionaCursorDelegate3(int posicao);

        private void PosicionaCursor3(int posicao)
        {
            mskCEP.SelectionStart = posicao;
        }

        private void mskCEP_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new PosicionaCursorDelegate3(PosicionaCursor3), new object[] { 0 });
        }
    }
}
