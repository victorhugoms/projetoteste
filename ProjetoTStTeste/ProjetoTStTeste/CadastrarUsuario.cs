using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoTStTeste
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }
        conectaBD BD = new conectaBD();

        public string cd_usuario;
        public string cd_senha;
        public byte cd_administrador;

        


        
        
        


        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            
            cd_usuario = txtUsuario.Text;
            cd_senha = txtSenha.Text;
            cd_administrador = 1;
            this.Close();
            
        }

        
    }
}
