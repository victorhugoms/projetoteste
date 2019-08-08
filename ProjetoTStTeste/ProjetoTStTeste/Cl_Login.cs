using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoTStTeste
{
    class Cl_Login
    {
        conectaBD BD = new conectaBD();

        public int id_login;
        public string login;
        public string senha;
        public bool administrador;


        public DataTable ListaLogin()
        {

            try
            {
                BD._sql = "SELECT id_login, login FROM USUARIO order by login";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }

            
        }
        public DataTable buscasenha()
        {
            try
            {
                BD._sql = "SELECT senha, administrador FROM USUARIO " +
                    " where id_login = " + id_login.ToString();

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }

        }
        
    }
}
