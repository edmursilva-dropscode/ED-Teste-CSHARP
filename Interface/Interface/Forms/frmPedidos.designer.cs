namespace Interface.Forms
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.pctIcone = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctLinha = new System.Windows.Forms.PictureBox();
            this.pctBarra = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnIncluirItem = new System.Windows.Forms.Button();
            this.lvwItensPedido = new System.Windows.Forms.ListView();
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.lblTitulo.Location = new System.Drawing.Point(647, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pedidos";
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
            this.label1.Location = new System.Drawing.Point(15, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluirItem);
            this.groupBox1.Controls.Add(this.btnIncluirItem);
            this.groupBox1.Controls.Add(this.lvwItensPedido);
            this.groupBox1.Location = new System.Drawing.Point(7, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 242);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Itens ";
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(104, 208);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(94, 25);
            this.btnExcluirItem.TabIndex = 297;
            this.btnExcluirItem.TabStop = false;
            this.btnExcluirItem.Text = "&Excluir Item";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.BtnExcluirItem_Click);
            // 
            // btnIncluirItem
            // 
            this.btnIncluirItem.Location = new System.Drawing.Point(8, 208);
            this.btnIncluirItem.Name = "btnIncluirItem";
            this.btnIncluirItem.Size = new System.Drawing.Size(94, 25);
            this.btnIncluirItem.TabIndex = 296;
            this.btnIncluirItem.TabStop = false;
            this.btnIncluirItem.Text = "&Inclui Item";
            this.btnIncluirItem.UseVisualStyleBackColor = true;
            this.btnIncluirItem.Click += new System.EventHandler(this.BtnIncluirItem_Click);
            // 
            // lvwItensPedido
            // 
            this.lvwItensPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwItensPedido.FullRowSelect = true;
            this.lvwItensPedido.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwItensPedido.Location = new System.Drawing.Point(8, 20);
            this.lvwItensPedido.Name = "lvwItensPedido";
            this.lvwItensPedido.Size = new System.Drawing.Size(772, 182);
            this.lvwItensPedido.TabIndex = 295;
            this.lvwItensPedido.UseCompatibleStateImageBehavior = false;
            this.lvwItensPedido.View = System.Windows.Forms.View.Details;
            this.lvwItensPedido.Click += new System.EventHandler(this.LvwItensPedido_Click);
            // 
            // columnHeader25
            // 
            this.columnHeader25.DisplayIndex = 5;
            this.columnHeader25.Text = "";
            this.columnHeader25.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Código Produto";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Qtde.";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Valor Unitário";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Valor Total";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "IdProduto";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "IdItensPedido";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "IdPedido";
            this.columnHeader8.Width = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(18, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 110;
            this.label8.Text = "Data:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomeCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNomeCliente.Location = new System.Drawing.Point(164, 112);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(276, 21);
            this.lblNomeCliente.TabIndex = 11;
            this.lblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(69, 111);
            this.txtIdCliente.MaxLength = 3;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(88, 21);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.TxtCliente_TextChanged);
            this.txtIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCliente_KeyDown);
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCliente_KeyPress);
            this.txtIdCliente.Leave += new System.EventHandler(this.TxtCliente_Leave);
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdPedido.ForeColor = System.Drawing.Color.Black;
            this.lblIdPedido.Location = new System.Drawing.Point(69, 58);
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
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 111;
            this.label3.Text = "Código:";
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(69, 84);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(87, 21);
            this.dtpDataVenda.TabIndex = 113;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(600, 386);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 25);
            this.btnExcluir.TabIndex = 114;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(666, 386);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(65, 25);
            this.btnGravar.TabIndex = 116;
            this.btnGravar.TabStop = false;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(732, 386);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(65, 25);
            this.btnFechar.TabIndex = 115;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Location = new System.Drawing.Point(127, 112);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(29, 19);
            this.btnPesquisarCliente.TabIndex = 298;
            this.btnPesquisarCliente.TabStop = false;
            this.btnPesquisarCliente.Text = "...";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.BtnPesquisarCliente_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 417);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "frmPedidos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPedidos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pctIcone;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.PictureBox pctLinha;
        internal System.Windows.Forms.PictureBox pctBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnFechar;
        internal System.Windows.Forms.ListView lvwItensPedido;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnIncluirItem;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}