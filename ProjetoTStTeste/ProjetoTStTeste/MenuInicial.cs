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
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
       
            
        }

        internal int adm
        {
            set
            {
                adm = value;
            }
        }

        private void adicionarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro addPro = new Cadastro();
            //addPro.MdiParent = this; // esse aqui e para ativar o container, e so ir no layout e deixa mdicontainer true
            //addPro.WindowState = FormWindowState.Maximized;// e para quando abrir a janela dentro do container ela abre maximizada
       
            addPro.Show();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmlogin login = new frmlogin();
            login.ShowDialog();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisa ps = new pesquisa();
            //ps.MdiParent = this;
            //ps.WindowState = FormWindowState.Maximized;
            ps.pesquisatxt = txtAdm.Text;
            ps.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmlogin formulario = new frmlogin();
            formulario.ShowDialog();

        }

        private void MenuInicial_Shown(object sender, EventArgs e)
        {
           
            if (txtAdm.Text == "True")
            {
                adicionarFuncionarioToolStripMenuItem.Enabled = true;
            }
            
        }

        private void txtAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuInicial_Enter(object sender, EventArgs e)
        {

        }

        private void adicionarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarPessoaToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (txtAdm.Text == "True")
            {
                adicionarFuncionarioToolStripMenuItem.Enabled = true;
            }
            else
            {
                adicionarFuncionarioToolStripMenuItem.Enabled = false;
            }

        }

        private void adicionarPessoaToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
