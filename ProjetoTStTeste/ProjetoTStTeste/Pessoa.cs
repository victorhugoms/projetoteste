using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoTStTeste
{
    class Pessoa
    {
        private Int32 idCliente;
        private String nome;
        private String cpf;
        private DateTime dt_Nascimento;
        private int id_Telefone;
        private String email;
        private String endereco;
        private String bairro;
        private int id_Cidade;
        private int id_Estado;
        private String cep;
        private String complemento;
        private String turno;
        private int id_Profissao;

        conectaBD BD = new conectaBD();

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateTime Dt_nascimento
        {
            get { return dt_Nascimento; }
            set { dt_Nascimento = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Endereco
        {
            get { return endereco;  }
            set { endereco = value; }
        
        }

        public string Bairro
        {
            get { return bairro;  }
            set { bairro = value;  }
        }

        public int Telefone
        {
            get { return id_Telefone;  }
            set { id_Telefone = value; }
        }

        public int Id_Cidade
        {
            get { return id_Cidade;  }
            set { id_Cidade = value;  }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value;  }
        }

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public int Id_Profissao
        {
            get { return id_Profissao; }
            set { id_Profissao = value; }
        }


        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO CLIENTE (nome_funcionario,data_nascimento,endereco_funcionario," +
                                                                  "id_estado,id_cidade,id_profissao,bairro_funcionario,cep_funcionario,cpf_funcionario,email_funcionario,turno) " +
                                        " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                                  nome, dt_Nascimento.ToShortDateString(), endereco,
                                                  id_Estado, id_Cidade, id_Profissao, bairro, cep, cpf, email, turno) +
                                                  "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;





        }
}
