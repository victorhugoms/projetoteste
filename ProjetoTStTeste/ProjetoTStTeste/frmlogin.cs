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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        bool senhaok;

  
        
        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            pes.Id_Funcionario = Convert.ToInt32(cmblogin.SelectedValue);

            DataTable dt = pes.buscasenha();

            

            if(txtSenha.Text == dt.Rows[0]["senha"].ToString())
            {
                TextBox txt = (TextBox)Application.OpenForms["MenuInicial"].Controls["txtAdm"];
                txt.Text = dt.Rows[0]["administrador"].ToString();

                senhaok = true;
                this.Close();

            }
            else
            {
                MessageBox.Show(" senha incorreta !");
                txtSenha.Text = "";
                txtSenha.Focus();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            senhaok = true;
            Application.Exit();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            cmblogin.DisplayMember = "usuario";
            cmblogin.ValueMember = "id_funcionario";
            cmblogin.DataSource = pes.ListaLogin();
            cmblogin.SelectedValue = 0;
            senhaok = false;
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null,null);
            }
        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (senhaok == false)
            {
                e.Cancel = true;
            }
        }
    }
}
