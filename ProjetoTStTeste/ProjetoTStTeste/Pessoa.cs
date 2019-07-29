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
        private String sexo;
        private byte exame;

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

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public byte Exame
        {
            get { return exame; }
            set { exame = value; }
        }



        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), " INSERT INTO funcionario (nome_funcionario,id_profissao,id_estado,id_cidade,endereco_funcionario,cpf_funcionario ,cep_funcionario,bairro_funcionario,id_turno,email_funcionario,data_nascimento,sexo,exame  ) " +
                                        " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}'  )",
                                                  nome,id_Profissao,id_Estado, id_Cidade,endereco,cpf,cep,bairro,id_turno,email,dt_Nascimento.ToShortDateString(),Sexo, Exame) +
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

        public int AdicionarTelefone(string fone, string tipo)
        {
            int id = 0;
            try
            {

                BD._sql = String.Format(new CultureInfo("en-US"),
                    "INSERT INTO TELEFONE (id_funcionario,numero_telefone,descricao_telefone) " +
                    " values ({0},'{1}','{2}')",
                    idCliente, fone, tipo) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Telefone cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Telefone", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;

        }
        public DataTable PesquisaPorprofissao()
        {
            try
            {
                BD._sql = "SELECT e.id_epi as ID, ep.descricao_epi " +
                    "FROM profissao p JOIN epi_profissao e ON p.id_profissao = e.id_profissao " +
                    "JOIN epi ep ON ep.id_epi = e.id_epi" +
                     "WHERE e.id_profissao=" + Id_Profissao.ToString();
                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }
        public DataTable PesquisaPorNome(String nome_pesquisa)
        {
            try
            {
                BD._sql = "SELECT F.id_funcionario AS 'ID', F.nome_funcionario AS 'NOME', F.cpf_funcionario AS 'CPF',F.data_nascimento AS 'NASCIMENTO',  " +
                            " F.endereco_funcionario AS 'ENDEREÇO', F.email_funcionario AS 'Email' ,CID.CIDADE AS 'Cidade', E.SIGLA as 'UF', F.id_profissao, P.cargo_profissao as 'Profissão',  " + 
                            "  F.sexo, F.bairro_funcionario, F.cep_funcionario, f.ID_CIDADE, F.ID_ESTADO, F.exame, F.id_turno, T.Periodo AS 'Turno'  " +
                        " FROM funcionario F  " +
                            "  LEFT JOIN ESTADOS E ON F.ID_ESTADO = E.ID_ESTADO  " +
                            "  LEFT JOIN CIDADES CID ON F.ID_CIDADE = CID.ID_CIDADE  " +
                            " LEFT JOIN profissao P ON F.id_profissao = P.id_profissao " +
                            "  LEFT JOIN turno T ON f.id_turno = t.id_turno  " +
                        "  WHERE F.nome_funcionario LIKE '%" + nome_pesquisa + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }
        public DataTable Pesquisaepi()
        {
            try
            {
                BD._sql = " SELECT ep.descricao_epi  AS 'EPI' , ep.validade_ca_epi As 'Val' " +
                            " from profissao P " +
                            " JOIN epi_profissao e ON p.id_profissao = e.id_profissao " +
                            " JOIN epi ep ON ep.id_epi = e.id_epi " +
                            " WHERE e.id_profissao = " + id_Profissao.ToString();

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }

        public DataTable exames()
        {
            try
            {
                BD._sql = " SELECT exame AS 'EXAMES' " +
                    " FROM funcionario " +
                    " WHERE id_funcionario = " + idCliente.ToString();

                return BD.ExecutaSelect();


            }
            catch
            {



            }
            return null;





        }
        public void Atualizar()
        {
            try
            {
                int exOK = 0;

                BD._sql = String.Format(" UPDATE funcionario SET nome_funcionario  = '{0}' , endereco_funcionario = '{1}' , cep_funcionario = '{2}' , cpf_funcionario =  '{3}' , " +
                    "  bairro_funcionario = '{4}' , id_profissao = '{5}' , email_funcionario = '{6}' , id_estado = '{7}', id_cidade = '{8}' , data_nascimento = '{9}' , id_turno = '{10}' , sexo = '{11}', exame = '{12}' " +
                    " WHERE id_funcionario = '{13}' ", nome, endereco, cep, cpf, bairro, id_Profissao, email, id_Estado, id_Cidade, dt_Nascimento, id_turno, sexo, exame, idCliente);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0) 
                {
                    MessageBox.Show("Erro ao atualizar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente atualizado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Deletar()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM funcionario WHERE id_funcionario = {0}", idCliente);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Funcionario deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }
        public void Deletartel()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM telefone WHERE id_funcionario = {0}", idCliente);

                exOK = BD.ExecutaComando(false);

               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        public DataTable Pesquisatelefone()
        {
            try
            {
                BD._sql = "SELECT numero_telefone AS 'Número' , descricao_telefone AS 'Tipo' " +
                    " FROM telefone t " +
                    " JOIN funcionario f ON f.id_funcionario = t.id_funcionario" +
                     " WHERE f.id_funcionario = " + IdCliente;
                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }


    }
}
