namespace Interface.Forms
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.pctIcone = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctLinha = new System.Windows.Forms.PictureBox();
            this.pctBarra = new System.Windows.Forms.PictureBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(4, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // pctIcone
            // 
            this.pctIcone.BackColor = System.Drawing.Color.Transparent;
            this.pctIcone.Image = ((System.Drawing.Image)(resources.GetObject("pctIcone.Image")));
            this.pctIcone.Location = new System.Drawing.Point(7, 11);
            this.pctIcone.Name = "pctIcone";
            this.pctIcone.Size = new System.Drawing.Size(32, 32);
            this.pctIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctIcone.TabIndex = 60;
            this.pctIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(140, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(183, 23);
            this.lblTitulo.TabIndex = 59;
            this.lblTitulo.Text = "Clientes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pctLinha
            // 
            this.pctLinha.Image = ((System.Drawing.Image)(resources.GetObject("pctLinha.Image")));
            this.pctLinha.Location = new System.Drawing.Point(-48, 51);
            this.pctLinha.Name = "pctLinha";
            this.pctLinha.Size = new System.Drawing.Size(657, 2);
            this.pctLinha.TabIndex = 58;
            this.pctLinha.TabStop = false;
            // 
            // pctBarra
            // 
            this.pctBarra.Image = ((System.Drawing.Image)(resources.GetObject("pctBarra.Image")));
            this.pctBarra.Location = new System.Drawing.Point(1, 1);
            this.pctBarra.Name = "pctBarra";
            this.pctBarra.Size = new System.Drawing.Size(423, 50);
            this.pctBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBarra.TabIndex = 57;
            this.pctBarra.TabStop = false;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdCliente.ForeColor = System.Drawing.Color.Black;
            this.lblIdCliente.Location = new System.Drawing.Point(72, 60);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(60, 21);
            this.lblIdCliente.TabIndex = 90;
            this.lblIdCliente.Text = "0";
            this.lblIdCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(72, 86);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(251, 21);
            this.txtDescricao.TabIndex = 92;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 2);
            this.listBox1.TabIndex = 93;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(258, 124);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(65, 25);
            this.btnFechar.TabIndex = 94;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(193, 124);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(65, 25);
            this.btnGravar.TabIndex = 95;
            this.btnGravar.TabStop = false;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(128, 124);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 25);
            this.btnExcluir.TabIndex = 96;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 153);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.pctIcone);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLinha);
            this.Controls.Add(this.pctBarra);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox pctIcone;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.PictureBox pctLinha;
        internal System.Windows.Forms.PictureBox pctBarra;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
    }
}