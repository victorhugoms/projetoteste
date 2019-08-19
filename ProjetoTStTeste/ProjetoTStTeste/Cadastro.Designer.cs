namespace ProjetoTStTeste
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTelefone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPendente = new System.Windows.Forms.RadioButton();
            this.rdbEmdia = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pntelefone = new System.Windows.Forms.Panel();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnremover = new System.Windows.Forms.Button();
            this.dgvEpi = new System.Windows.Forms.DataGridView();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.msknascimento = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.grblogin = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.pntelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpi)).BeginInit();
            this.grblogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(5, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail: *";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(239, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefones:";
            // 
            // btnTelefone
            // 
            this.btnTelefone.Location = new System.Drawing.Point(261, 235);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.Size = new System.Drawing.Size(33, 23);
            this.btnTelefone.TabIndex = 10;
            this.btnTelefone.Text = "+";
            this.btnTelefone.UseVisualStyleBackColor = true;
            this.btnTelefone.Click += new System.EventHandler(this.btnTelefone_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMasculino);
            this.groupBox1.Controls.Add(this.rdbFeminino);
            this.groupBox1.Location = new System.Drawing.Point(478, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 52);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(136, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 2;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Checked = true;
            this.rdbFeminino.Location = new System.Drawing.Point(16, 19);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 0;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(4, 169);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(219, 20);
            this.txtEndereco.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(239, 169);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(219, 20);
            this.txtBairro.TabIndex = 16;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(390, 114);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(144, 21);
            this.cmbEstado.TabIndex = 17;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(550, 114);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(144, 21);
            this.cmbCidade.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "CEP:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(346, 227);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(144, 21);
            this.cmbCargo.TabIndex = 23;
            this.cmbCargo.SelectedIndexChanged += new System.EventHandler(this.cmbCargo_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(343, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Profissão:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Turno:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(346, 267);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(144, 21);
            this.cmbTurno.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPendente);
            this.groupBox2.Controls.Add(this.rdbEmdia);
            this.groupBox2.Location = new System.Drawing.Point(11, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 48);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exames";
            // 
            // rdbPendente
            // 
            this.rdbPendente.AutoSize = true;
            this.rdbPendente.Location = new System.Drawing.Point(136, 22);
            this.rdbPendente.Name = "rdbPendente";
            this.rdbPendente.Size = new System.Drawing.Size(71, 17);
            this.rdbPendente.TabIndex = 1;
            this.rdbPendente.Text = "Pendente";
            this.rdbPendente.UseVisualStyleBackColor = true;
            // 
            // rdbEmdia
            // 
            this.rdbEmdia.AutoSize = true;
            this.rdbEmdia.Checked = true;
            this.rdbEmdia.Location = new System.Drawing.Point(38, 25);
            this.rdbEmdia.Name = "rdbEmdia";
            this.rdbEmdia.Size = new System.Drawing.Size(59, 17);
            this.rdbEmdia.TabIndex = 0;
            this.rdbEmdia.TabStop = true;
            this.rdbEmdia.Text = "Em Dia";
            this.rdbEmdia.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(510, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(206, 23);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(298, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(206, 23);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(599, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "EPI:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(31, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(97, 20);
            this.txtId.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "ID :";
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.AllowUserToDeleteRows = false;
            this.dgvTelefone.AllowUserToOrderColumns = true;
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Telefone,
            this.Tipo});
            this.dgvTelefone.Location = new System.Drawing.Point(11, 227);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefone.Size = new System.Drawing.Size(232, 104);
            this.dgvTelefone.TabIndex = 41;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // pntelefone
            // 
            this.pntelefone.Controls.Add(this.mskTel);
            this.pntelefone.Controls.Add(this.button2);
            this.pntelefone.Controls.Add(this.label14);
            this.pntelefone.Controls.Add(this.label11);
            this.pntelefone.Controls.Add(this.cmbTipo);
            this.pntelefone.Location = new System.Drawing.Point(9, 227);
            this.pntelefone.Name = "pntelefone";
            this.pntelefone.Size = new System.Drawing.Size(246, 107);
            this.pntelefone.TabIndex = 42;
            this.pntelefone.Visible = false;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(76, 49);
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(121, 20);
            this.mskTel.TabIndex = 52;
            this.mskTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salvar Telefone";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Telefone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Residencial",
            "Celular",
            "Recado",
            "Fax",
            "Comercial"});
            this.cmbTipo.Location = new System.Drawing.Point(76, 16);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(261, 277);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(33, 23);
            this.btnremover.TabIndex = 11;
            this.btnremover.Text = "-";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // dgvEpi
            // 
            this.dgvEpi.AllowUserToAddRows = false;
            this.dgvEpi.AllowUserToDeleteRows = false;
            this.dgvEpi.BackgroundColor = System.Drawing.Color.White;
            this.dgvEpi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpi.Location = new System.Drawing.Point(519, 194);
            this.dgvEpi.Name = "dgvEpi";
            this.dgvEpi.ReadOnly = true;
            this.dgvEpi.Size = new System.Drawing.Size(185, 185);
            this.dgvEpi.TabIndex = 45;
            // 
            // mskcpf
            // 
            this.mskcpf.Location = new System.Drawing.Point(5, 114);
            this.mskcpf.Mask = "000.000.000-00";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(100, 20);
            this.mskcpf.TabIndex = 47;
            this.mskcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskcpf_MaskInputRejected);
            this.mskcpf.Enter += new System.EventHandler(this.mskcpf_Enter);
            // 
            // msknascimento
            // 
            this.msknascimento.Location = new System.Drawing.Point(133, 116);
            this.msknascimento.Mask = "00/00/0000";
            this.msknascimento.Name = "msknascimento";
            this.msknascimento.Size = new System.Drawing.Size(100, 20);
            this.msknascimento.TabIndex = 48;
            this.msknascimento.ValidatingType = typeof(System.DateTime);
            this.msknascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msknascimento_MaskInputRejected);
            this.msknascimento.Enter += new System.EventHandler(this.msknascimento_Enter_1);
            // 
            // mskCEP
            // 
            this.mskCEP.BeepOnError = true;
            this.mskCEP.Location = new System.Drawing.Point(261, 114);
            this.mskCEP.Mask = "00000-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(100, 20);
            this.mskCEP.TabIndex = 49;
            this.mskCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCEP_MaskInputRejected);
            this.mskCEP.Enter += new System.EventHandler(this.mskCEP_Enter);
            // 
            // grblogin
            // 
            this.grblogin.Controls.Add(this.label18);
            this.grblogin.Controls.Add(this.label17);
            this.grblogin.Controls.Add(this.txtsenha);
            this.grblogin.Controls.Add(this.txtusuario);
            this.grblogin.Location = new System.Drawing.Point(298, 308);
            this.grblogin.Name = "grblogin";
            this.grblogin.Size = new System.Drawing.Size(200, 100);
            this.grblogin.TabIndex = 50;
            this.grblogin.TabStop = false;
            this.grblogin.Text = "Login";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Senha:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Usuário:";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(81, 63);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 20);
            this.txtsenha.TabIndex = 1;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(81, 26);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 0;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.grblogin);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.msknascimento);
            this.Controls.Add(this.mskcpf);
            this.Controls.Add(this.dgvEpi);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.pntelefone);
            this.Controls.Add(this.btnTelefone);
            this.Controls.Add(this.dgvTelefone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Pessoas_Load);
            this.Shown += new System.EventHandler(this.Pessoas_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.pntelefone.ResumeLayout(false);
            this.pntelefone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpi)).EndInit();
            this.grblogin.ResumeLayout(false);
            this.grblogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbPendente;
        private System.Windows.Forms.RadioButton rdbEmdia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.Panel pntelefone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvEpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.MaskedTextBox msknascimento;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtusuario;
        public System.Windows.Forms.GroupBox grblogin;
    }
}