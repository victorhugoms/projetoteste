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
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvpesquisa = new System.Windows.Forms.DataGridView();
            this.btsair = new System.Windows.Forms.Button();
            this.dgvepii = new System.Windows.Forms.DataGridView();
            this.btepi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvepii)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(112, 12);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(595, 20);
            this.txtpesquisa.TabIndex = 0;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome ou CPF";
            // 
            // dgvpesquisa
            // 
            this.dgvpesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpesquisa.Location = new System.Drawing.Point(112, 55);
            this.dgvpesquisa.Name = "dgvpesquisa";
            this.dgvpesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpesquisa.Size = new System.Drawing.Size(595, 198);
            this.dgvpesquisa.TabIndex = 2;
            this.dgvpesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpesquisa_CellContentClick);
            this.dgvpesquisa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvpesquisa_MouseClick);
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(674, 415);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(75, 23);
            this.btsair.TabIndex = 3;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // dgvepii
            // 
            this.dgvepii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvepii.Location = new System.Drawing.Point(112, 288);
            this.dgvepii.Name = "dgvepii";
            this.dgvepii.Size = new System.Drawing.Size(240, 150);
            this.dgvepii.TabIndex = 4;
            // 
            // btepi
            // 
            this.btepi.Location = new System.Drawing.Point(674, 370);
            this.btepi.Name = "btepi";
            this.btepi.Size = new System.Drawing.Size(75, 23);
            this.btepi.TabIndex = 5;
            this.btepi.Text = "Epi";
            this.btepi.UseVisualStyleBackColor = true;
            this.btepi.Click += new System.EventHandler(this.btepi_Click);
            // 
            // pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btepi);
            this.Controls.Add(this.dgvepii);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.dgvpesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpesquisa);
            this.Name = "pesquisa";
            this.Text = "pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvepii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvpesquisa;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.DataGridView dgvepii;
        private System.Windows.Forms.Button btepi;
    }
}