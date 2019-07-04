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
    public class profissao
    {
        private int idProfissao;
        private string cargo;
        private string turno;
        private decimal salario;
        private string risco;

        conectaBD BD = new conectaBD();


        public int IdProfissao
        {
            get { return idProfissao; }
            set { idProfissao = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public decimal Salario
        {
            get{ return salario; }
            set { salario = value; }
        }

        public string Risco
        {
            get { return risco; }
            set { risco = value; }
        }
        public DataTable PesquisaPorprofissao()
        {
            try
            {
                BD._sql = "SELECT e.id_epi as ID, ep.descricao_epi " +
                    " FROM profissao p JOIN epi_profissao e ON p.id_profissao = e.id_profissao " +
                    " JOIN epi ep ON ep.id_epi = e.id_epi" +
                     " WHERE e.id_profissao= " + idProfissao.ToString();
                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }

    }
}