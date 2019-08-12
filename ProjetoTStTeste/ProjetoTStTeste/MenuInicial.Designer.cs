namespace ProjetoTStTeste
{
    partial class MenuInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAdm = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarPessoaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarPessoaToolStripMenuItem
            // 
            this.adicionarPessoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarFuncionarioToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.adicionarPessoaToolStripMenuItem.Name = "adicionarPessoaToolStripMenuItem";
            this.adicionarPessoaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.adicionarPessoaToolStripMenuItem.Text = "Menu";
            this.adicionarPessoaToolStripMenuItem.DropDownOpening += new System.EventHandler(this.adicionarPessoaToolStripMenuItem_DropDownOpening);
            this.adicionarPessoaToolStripMenuItem.Click += new System.EventHandler(this.adicionarPessoaToolStripMenuItem_Click);
            this.adicionarPessoaToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adicionarPessoaToolStripMenuItem_MouseDown);
            // 
            // adicionarFuncionarioToolStripMenuItem
            // 
            this.adicionarFuncionarioToolStripMenuItem.Enabled = false;
            this.adicionarFuncionarioToolStripMenuItem.Image = global::ProjetoTStTeste.Properties.Resources.Add_User_icon;
            this.adicionarFuncionarioToolStripMenuItem.Name = "adicionarFuncionarioToolStripMenuItem";
            this.adicionarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.adicionarFuncionarioToolStripMenuItem.Text = "Cadastrar Funcionário";
            this.adicionarFuncionarioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adicionarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.adicionarFuncionarioToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Image = global::ProjetoTStTeste.Properties.Resources.Search_icon;
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::ProjetoTStTeste.Properties.Resources.Close_icon;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sairToolStripMenuItem.Text = "Logoff";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.pesquisaToolStripMenuItem_Click);
            // 
            // txtAdm
            // 
            this.txtAdm.Location = new System.Drawing.Point(768, 105);
            this.txtAdm.Name = "txtAdm";
            this.txtAdm.Size = new System.Drawing.Size(100, 20);
            this.txtAdm.TabIndex = 1;
            this.txtAdm.Visible = false;
            this.txtAdm.TextChanged += new System.EventHandler(this.txtAdm_TextChanged);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::ProjetoTStTeste.Properties.Resources.segtrabalho;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 621);
            this.Controls.Add(this.txtAdm);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuInicial";
            this.Text = "Menu Principal";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MenuInicial_Shown);
            this.Enter += new System.EventHandler(this.MenuInicial_Enter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAdm;
    }
}

