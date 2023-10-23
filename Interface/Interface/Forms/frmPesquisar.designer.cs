namespace Interface.Forms
{
    partial class FrmPesquisar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisar));
            this.pctIcone = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctLinha = new System.Windows.Forms.PictureBox();
            this.pctBarra = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.imgAnexos = new System.Windows.Forms.ImageList(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lvwPesquisa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radCodigo = new System.Windows.Forms.RadioButton();
            this.radDescricao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // pctIcone
            // 
            this.pctIcone.BackColor = System.Drawing.Color.Transparent;
            this.pctIcone.Image = ((System.Drawing.Image)(resources.GetObject("pctIcone.Image")));
            this.pctIcone.Location = new System.Drawing.Point(6, 10);
            this.pctIcone.Name = "pctIcone";
            this.pctIcone.Size = new System.Drawing.Size(32, 32);
            this.pctIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctIcone.TabIndex = 56;
            this.pctIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(136, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 23);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "...";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pctLinha
            // 
            this.pctLinha.Image = ((System.Drawing.Image)(resources.GetObject("pctLinha.Image")));
            this.pctLinha.Location = new System.Drawing.Point(-86, 50);
            this.pctLinha.Name = "pctLinha";
            this.pctLinha.Size = new System.Drawing.Size(657, 2);
            this.pctLinha.TabIndex = 54;
            this.pctLinha.TabStop = false;
            // 
            // pctBarra
            // 
            this.pctBarra.Image = ((System.Drawing.Image)(resources.GetObject("pctBarra.Image")));
            this.pctBarra.Location = new System.Drawing.Point(0, 0);
            this.pctBarra.Name = "pctBarra";
            this.pctBarra.Size = new System.Drawing.Size(489, 50);
            this.pctBarra.TabIndex = 53;
            this.pctBarra.TabStop = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Navy;
            this.lblMensagem.Location = new System.Drawing.Point(3, 58);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(259, 13);
            this.lblMensagem.TabIndex = 57;
            this.lblMensagem.Text = "Digite parte da descrição ... a ser localizado";
            // 
            // imgAnexos
            // 
            this.imgAnexos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAnexos.ImageStream")));
            this.imgAnexos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAnexos.Images.SetKeyName(0, "PPT");
            this.imgAnexos.Images.SetKeyName(1, "PDF");
            this.imgAnexos.Images.SetKeyName(2, "DOC");
            this.imgAnexos.Images.SetKeyName(3, "IMG");
            this.imgAnexos.Images.SetKeyName(4, "EML");
            this.imgAnexos.Images.SetKeyName(5, "HTM");
            this.imgAnexos.Images.SetKeyName(6, "XLS");
            this.imgAnexos.Images.SetKeyName(7, "TXT");
            this.imgAnexos.Images.SetKeyName(8, "VID");
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(272, 296);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(70, 27);
            this.btnFechar.TabIndex = 98;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(192, 296);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(80, 27);
            this.btnSelecionar.TabIndex = 97;
            this.btnSelecionar.TabStop = false;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(302, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(5, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 21);
            this.txtNome.TabIndex = 277;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNome_KeyDown);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // lvwPesquisa
            // 
            this.lvwPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwPesquisa.FullRowSelect = true;
            this.lvwPesquisa.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwPesquisa.HideSelection = false;
            this.lvwPesquisa.Location = new System.Drawing.Point(6, 98);
            this.lvwPesquisa.MultiSelect = false;
            this.lvwPesquisa.Name = "lvwPesquisa";
            this.lvwPesquisa.Size = new System.Drawing.Size(336, 193);
            this.lvwPesquisa.TabIndex = 278;
            this.lvwPesquisa.UseCompatibleStateImageBehavior = false;
            this.lvwPesquisa.View = System.Windows.Forms.View.Details;
            this.lvwPesquisa.DoubleClick += new System.EventHandler(this.LvwPesquisa_DoubleClick);
            this.lvwPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvwPesquisa_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 53;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "...";
            this.columnHeader2.Width = 279;
            // 
            // radCodigo
            // 
            this.radCodigo.AutoSize = true;
            this.radCodigo.ForeColor = System.Drawing.Color.Navy;
            this.radCodigo.Location = new System.Drawing.Point(7, 299);
            this.radCodigo.Name = "radCodigo";
            this.radCodigo.Size = new System.Drawing.Size(65, 17);
            this.radCodigo.TabIndex = 279;
            this.radCodigo.TabStop = true;
            this.radCodigo.Text = "Código";
            this.radCodigo.UseVisualStyleBackColor = true;
            this.radCodigo.CheckedChanged += new System.EventHandler(this.RadCodigo_CheckedChanged);
            // 
            // radDescricao
            // 
            this.radDescricao.AutoSize = true;
            this.radDescricao.ForeColor = System.Drawing.Color.Navy;
            this.radDescricao.Location = new System.Drawing.Point(76, 299);
            this.radDescricao.Name = "radDescricao";
            this.radDescricao.Size = new System.Drawing.Size(81, 17);
            this.radDescricao.TabIndex = 280;
            this.radDescricao.TabStop = true;
            this.radDescricao.Text = "Descrição";
            this.radDescricao.UseVisualStyleBackColor = true;
            this.radDescricao.CheckedChanged += new System.EventHandler(this.RadDescricao_CheckedChanged);
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 326);
            this.Controls.Add(this.radDescricao);
            this.Controls.Add(this.radCodigo);
            this.Controls.Add(this.lvwPesquisa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.pctIcone);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLinha);
            this.Controls.Add(this.pctBarra);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de ...";
            this.Load += new System.EventHandler(this.FrmPesquisar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPesquisar_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmPesquisar_KeyPress);
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
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.ImageList imgAnexos;
        private System.Windows.Forms.ListView lvwPesquisa;
        private System.Windows.Forms.RadioButton radCodigo;
        private System.Windows.Forms.RadioButton radDescricao;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}