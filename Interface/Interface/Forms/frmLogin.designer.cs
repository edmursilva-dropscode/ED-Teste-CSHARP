namespace Interface.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblLogin1 = new System.Windows.Forms.Label();
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.lblLogin3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.pctBarra = new System.Windows.Forms.PictureBox();
            this.pctLinha = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinha)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin1
            // 
            this.lblLogin1.AutoSize = true;
            this.lblLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin1.Location = new System.Drawing.Point(6, 67);
            this.lblLogin1.Name = "lblLogin1";
            this.lblLogin1.Size = new System.Drawing.Size(49, 15);
            this.lblLogin1.TabIndex = 0;
            this.lblLogin1.Text = "Código:";
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin2.Location = new System.Drawing.Point(6, 92);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(44, 15);
            this.lblLogin2.TabIndex = 1;
            this.lblLogin2.Text = "Nome:";
            // 
            // lblLogin3
            // 
            this.lblLogin3.AutoSize = true;
            this.lblLogin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin3.Location = new System.Drawing.Point(6, 118);
            this.lblLogin3.Name = "lblLogin3";
            this.lblLogin3.Size = new System.Drawing.Size(46, 15);
            this.lblLogin3.TabIndex = 2;
            this.lblLogin3.Text = "Senha:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(179, 148);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 25);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(243, 148);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(65, 25);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(70, 66);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtIdUsuario.MaxLength = 6;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(59, 21);
            this.txtIdUsuario.TabIndex = 0;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.TxtIdUsuario_TextChanged);
            this.txtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdUsuario_KeyPress);
            this.txtIdUsuario.Leave += new System.EventHandler(this.TxtIdUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(70, 115);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(101, 21);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyDown);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Location = new System.Drawing.Point(7, 142);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(300, 2);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            // 
            // pctBarra
            // 
            this.pctBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctBarra.Image = ((System.Drawing.Image)(resources.GetObject("pctBarra.Image")));
            this.pctBarra.Location = new System.Drawing.Point(0, 0);
            this.pctBarra.Name = "pctBarra";
            this.pctBarra.Size = new System.Drawing.Size(317, 53);
            this.pctBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctBarra.TabIndex = 78;
            this.pctBarra.TabStop = false;
            // 
            // pctLinha
            // 
            this.pctLinha.Image = ((System.Drawing.Image)(resources.GetObject("pctLinha.Image")));
            this.pctLinha.Location = new System.Drawing.Point(-254, 53);
            this.pctLinha.Name = "pctLinha";
            this.pctLinha.Size = new System.Drawing.Size(884, 2);
            this.pctLinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLinha.TabIndex = 79;
            this.pctLinha.TabStop = false;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNomeUsuario.Location = new System.Drawing.Point(71, 91);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(237, 21);
            this.lblNomeUsuario.TabIndex = 80;
            this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 185);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.pctLinha);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin3);
            this.Controls.Add(this.lblLogin2);
            this.Controls.Add(this.lblLogin1);
            this.Controls.Add(this.pctBarra);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin1;
        private System.Windows.Forms.Label lblLogin2;
        private System.Windows.Forms.Label lblLogin3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.PictureBox pctBarra;
        private System.Windows.Forms.PictureBox pctLinha;
        private System.Windows.Forms.Label lblNomeUsuario;

    }
}