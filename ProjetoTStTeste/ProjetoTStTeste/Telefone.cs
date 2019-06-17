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
    public partial class Telefone : Form
    {
        public Telefone()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telefones tel = new Telefones();

            tel.numero = msknumero.Text;
            tel.Tipo = combotipo.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
