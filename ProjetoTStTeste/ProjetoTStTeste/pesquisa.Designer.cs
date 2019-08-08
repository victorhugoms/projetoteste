namespace ProjetoTStTeste
{
    partial class pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisa));
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvpesquisa = new System.Windows.Forms.DataGridView();
            this.btsair = new System.Windows.Forms.Button();
            this.dgvepii = new System.Windows.Forms.DataGridView();
            this.btnalterar = new System.Windows.Forms.Button();
            this.dgvexame = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvepii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexame)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(91, 12);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(595, 20);
            this.txtpesquisa.TabIndex = 0;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome ou CPF";
            // 
            // dgvpesquisa
            // 
            this.dgvpesquisa.AllowUserToAddRows = false;
            this.dgvpesquisa.AllowUserToDeleteRows = false;
            this.dgvpesquisa.BackgroundColor = System.Drawing.Color.White;
            this.dgvpesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvpesquisa.Location = new System.Drawing.Point(15, 55);
            this.dgvpesquisa.Name = "dgvpesquisa";
            this.dgvpesquisa.ReadOnly = true;
            this.dgvpesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpesquisa.Size = new System.Drawing.Size(687, 173);
            this.dgvpesquisa.TabIndex = 2;
            this.dgvpesquisa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvpesquisa_MouseClick);
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.White;
            this.btsair.Location = new System.Drawing.Point(426, 415);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(135, 23);
            this.btsair.TabIndex = 3;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // dgvepii
            // 
            this.dgvepii.AllowUserToAddRows = false;
            this.dgvepii.AllowUserToDeleteRows = false;
            this.dgvepii.BackgroundColor = System.Drawing.Color.White;
            this.dgvepii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvepii.Location = new System.Drawing.Point(423, 234);
            this.dgvepii.Name = "dgvepii";
            this.dgvepii.ReadOnly = true;
            this.dgvepii.Size = new System.Drawing.Size(279, 150);
            this.dgvepii.TabIndex = 4;
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.White;
            this.btnalterar.Location = new System.Drawing.Point(567, 415);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(135, 23);
            this.btnalterar.TabIndex = 5;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // dgvexame
            // 
            this.dgvexame.AllowUserToAddRows = false;
            this.dgvexame.AllowUserToDeleteRows = false;
            this.dgvexame.BackgroundColor = System.Drawing.Color.White;
            this.dgvexame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexame.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvexame.Location = new System.Drawing.Point(15, 234);
            this.dgvexame.Name = "dgvexame";
            this.dgvexame.ReadOnly = true;
            this.dgvexame.Size = new System.Drawing.Size(279, 150);
            this.dgvexame.TabIndex = 6;
            this.dgvexame.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexame_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvexame);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.dgvepii);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.dgvpesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pesquisa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvepii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvpesquisa;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.DataGridView dgvepii;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.DataGridView dgvexame;
        private System.Windows.Forms.Button button1;
    }
}