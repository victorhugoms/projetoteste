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
    public class Pessoa
    {
        private int idCliente;
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
        private int id_turno;
        private int id_Profissao;
        private int sexo;
        private int id_epi;

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
            get { return endereco; }
            set { endereco = value; }

        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public int Telefone
        {
            get { return id_Telefone; }
            set { id_Telefone = value; }
        }

        public int Id_Cidade
        {
            get { return id_Cidade; }
            set { id_Cidade = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public int Id_Turno
        {
            get { return id_turno; }
            set { id_turno = value; }
        }

        public int Id_Profissao
        {
            get { return id_Profissao; }
            set { id_Profissao = value; }
        }

        public int Id_Estado
        {
            get { return id_Estado; }
            set { id_Estado = value; }
        }

        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int Id_epi
        {
            get { return id_epi; }
            set { id_epi = value; }
        }



        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO funcionario (nome_funcionario,data_nascimento,endereco_funcionario," +
                                                                  "id_estado,id_cidade,id_profissao,bairro_funcionario,cep_funcionario,cpf_funcionario,email_funcionario,id_turno,id_epi) " +
                                        " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                                                  nome, dt_Nascimento.ToShortDateString(), endereco,
                                                  id_Estado, id_Cidade, id_Profissao, bairro, cep, cpf, email,id_turno, id_epi) +
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

        public DataTable ListaUf()
        {
            try
            {
                BD._sql = "SELECT ID_ESTADO, SIGLA FROM ESTADOS ORDER BY SIGLA";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ListaCidade()
        {
            try
            {
                BD._sql = "SELECT ID_CIDADE, CIDADE FROM CIDADES WHERE ID_ESTADO = " + id_Estado.ToString() + " ORDER BY CIDADE";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }


        }

        public DataTable Turnolista()
        {
            try
            {
                BD._sql = "SELECT id_turno, Periodo FROM Turno";
                return BD.ExecutaSelect();
            }
            catch (Exception)
            {

                { return null; }
            }
        }

        public DataTable Profissao1()
        {
            try
            {
                BD._sql = "SELECT id_profissao , cargo_profissao FROM profissao";
                return BD.ExecutaSelect();
            }
            catch
            {

                { return null; }
            }
        }

        public DataTable epi1()
        {
            try
            {
                BD._sql = "S";
                return BD.ExecutaSelect();
            }
            catch
            {

                { return null; }
            }
        }
    }
}
