namespace Interface.Forms
{
    partial class FrmItensPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensPedido));
            this.pctIcone = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctLinha = new System.Windows.Forms.PictureBox();
            this.pctBarra = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtIdItensPedido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // pctIcone
            // 
            this.pctIcone.BackColor = System.Drawing.Color.Transparent;
            this.pctIcone.Image = ((System.Drawing.Image)(resources.GetObject("pctIcone.Image")));
            this.pctIcone.Location = new System.Drawing.Point(5, 10);
            this.pctIcone.Name = "pctIcone";
            this.pctIcone.Size = new System.Drawing.Size(32, 32);
            this.pctIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctIcone.TabIndex = 64;
            this.pctIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(340, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Itens do Pedido";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pctLinha
            // 
            this.pctLinha.Image = ((System.Drawing.Image)(resources.GetObject("pctLinha.Image")));
            this.pctLinha.Location = new System.Drawing.Point(-59, 50);
            this.pctLinha.Name = "pctLinha";
            this.pctLinha.Size = new System.Drawing.Size(869, 2);
            this.pctLinha.TabIndex = 62;
            this.pctLinha.TabStop = false;
            // 
            // pctBarra
            // 
            this.pctBarra.Image = ((System.Drawing.Image)(resources.GetObject("pctBarra.Image")));
            this.pctBarra.Location = new System.Drawing.Point(0, 0);
            this.pctBarra.Name = "pctBarra";
            this.pctBarra.Size = new System.Drawing.Size(818, 50);
            this.pctBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBarra.TabIndex = 61;
            this.pctBarra.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(50, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Produto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(67, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 110;
            this.label8.Text = "Qtde:";
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescricaoProduto.ForeColor = System.Drawing.Color.Black;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(204, 86);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(276, 21);
            this.lblDescricaoProduto.TabIndex = 11;
            this.lblDescricaoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(109, 85);
            this.txtIdProduto.MaxLength = 3;
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(88, 21);
            this.txtIdProduto.TabIndex = 1;
            this.txtIdProduto.TextChanged += new System.EventHandler(this.TxtProduto_TextChanged);
            this.txtIdProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProduto_KeyDown);
            this.txtIdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProduto_KeyPress);
            this.txtIdProduto.Leave += new System.EventHandler(this.TxtProduto_Leave);
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdPedido.ForeColor = System.Drawing.Color.Black;
            this.lblIdPedido.Location = new System.Drawing.Point(109, 58);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(88, 21);
            this.lblIdPedido.TabIndex = 112;
            this.lblIdPedido.Text = "0";
            this.lblIdPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(54, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 111;
            this.label3.Text = "Pedido:";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(343, 177);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(65, 25);
            this.btnGravar.TabIndex = 116;
            this.btnGravar.TabStop = false;
            this.btnGravar.Text = "&Incluir";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(409, 177);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(65, 25);
            this.btnFechar.TabIndex = 115;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(167, 86);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(29, 19);
            this.btnPesquisarProduto.TabIndex = 298;
            this.btnPesquisarProduto.TabStop = false;
            this.btnPesquisarProduto.Text = "...";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.BtnPesquisarCliente_Click);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(109, 114);
            this.txtQtde.MaxLength = 6;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(88, 21);
            this.txtQtde.TabIndex = 299;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtde_KeyPress);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(109, 141);
            this.txtValorUnitario.MaxLength = 6;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(88, 21);
            this.txtValorUnitario.TabIndex = 301;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorUnitario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(18, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 300;
            this.label2.Text = "Valor Unitário:";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(466, 2);
            this.listBox1.TabIndex = 302;
            // 
            // txtIdItensPedido
            // 
            this.txtIdItensPedido.ForeColor = System.Drawing.Color.Red;
            this.txtIdItensPedido.Location = new System.Drawing.Point(320, 16);
            this.txtIdItensPedido.Name = "txtIdItensPedido";
            this.txtIdItensPedido.Size = new System.Drawing.Size(14, 21);
            this.txtIdItensPedido.TabIndex = 303;
            this.txtIdItensPedido.Text = "0";
            this.txtIdItensPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdItensPedido.Visible = false;
            // 
            // frmItensPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 212);
            this.Controls.Add(this.txtIdItensPedido);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescricaoProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pctIcone);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctLinha);
            this.Controls.Add(this.pctBarra);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItensPedido";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Itens do Pedido";
            this.Load += new System.EventHandler(this.FrmItensPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmItensPedido_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pctIcone;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.PictureBox pctLinha;
        internal System.Windows.Forms.PictureBox pctBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        internal System.Windows.Forms.TextBox txtIdItensPedido;
    }
}