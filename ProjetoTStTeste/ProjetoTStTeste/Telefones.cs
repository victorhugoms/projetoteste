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
    class Telefones : Pessoa
    {
        private String tipo;
        private string numero; 
        private int id_Telefone;

        public int Telefone
        {
            get { return id_Telefone; }
            set { id_Telefone = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }


       

        conectaBD BD = new conectaBD();



       

        public void Deletartel2()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM telefone WHERE id_telefone = {0}", id_Telefone);

                exOK = BD.ExecutaComando(false);


            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        public int AdicionarTelefone()
        {
            int exOK = 0;
            try
            {

                BD._sql = String.Format(new CultureInfo("en-US"),
                    "INSERT INTO TELEFONE (id_funcionario,numero_telefone,descricao_telefone) " +
                    " values ({0},'{1}','{2}')",
                    Id_Funcionario, numero, Tipo) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out exOK);

                if (exOK > 0)
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

            return exOK;

        }

    }
}
