using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FrameWork.Negocios;
using FrameWork.Facade;
using FrameWork.Entidades;


namespace Interface.Forms
{
    public partial class FrmLogin : Form
    {
        #region Variaveis
        //Objetos das classes
        public FrmMain vol_Main;                        //Cria uma instância do form principal
        FBL_Usuario vol_FacadeUsuario = null;
        //Variáveis Públicas
        public bool vbg_AcessoSistema = false;           //Guarda o controle de acesso ao sistema
        public String vcg_AcessoLogin = String.Empty;    //Guarda o controle de sair da aplicacao 
       
        //Variáveis de uso comum
        private String vcp_Senha = String.Empty;         //Guarda a senha do usuário   
        private Int32 vip_IdUsuario = 0;                 //Guarda o nome do usuário   
        private Int32 vip_TipoPerfil;
        private Int32 vip_CountSenha = 0;
        
        #endregion

        #region Form
        public FrmLogin(FrmMain frm)
        {
            InitializeComponent();
            vol_Main = frm;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (vol_Main.tslUsuario.Text == string.Empty)
            {
                vol_Main.vbg_Login = false;
                this.Text = "Bem Vindo ao TESTE_ESL_Loja";
            }
            else
            {
                vol_Main.vbg_Login = true;
                this.Text = "Autenticação";
            }
        }
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape)
            {
                //simula o pressionar a tecla ESC
                BtnFechar_Click(sender, e);
            }
        }
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!vol_Main.vbg_Login)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }
        #endregion

        #region Controles
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (!vol_Main.vbg_Login)
            {
                Application.Exit();
            }
            else
            {                
                this.Close();
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Verifica se o código do Usuário foi digitado
            if (txtIdUsuario.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe seu Código de Acesso !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdUsuario.Focus();
                return;
            }

            //Verifica se a Senha do Usuário foi digitada
            if (txtSenha.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe seu Código de Acesso !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenha.Focus();
                return;
            }

            //Verifica se a senha digitada é igual a senha do Usuário
            if (vcp_Senha.ToUpper().Trim() != txtSenha.Text.ToUpper().Trim())
            {
                vip_CountSenha++;

                //Valida se a senha foi digitada errada por 5 vezes
                if (vip_CountSenha > 4)
                {
                    MessageBox.Show("Acesso Negado !" + (char)13 + "A aplicação será encerrada.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                MessageBox.Show("Acesso Negado !" + (char)13 + "Verifique seu código e senha de acesso.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Text = String.Empty;
                txtSenha.Focus();
                return;
            }

            vol_Main.vbg_Login = true;

            //Atualiza variaveis de controle
            vol_Main.txtIdUsuario.Text = vip_IdUsuario.ToString();
            vol_Main.tslUsuario.Text = lblNomeUsuario.Text.Trim();
            vol_Main.txtSupervisor.Text = Convert.ToString(vip_TipoPerfil);
            vol_Main.txtValidarSenha.Text = txtSenha.Text.Trim();
            this.Close();
        }
        private void TxtIdUsuario_Leave(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text.Trim() == String.Empty)
            {
                return;
            }

            //Inicializa objeto
            vol_FacadeUsuario = new FBL_Usuario();
            Usuario vol_Usuario = vol_FacadeUsuario.SelecionarUsuarioSistemas(Convert.ToInt32(txtIdUsuario.Text.Trim()));
            if (vol_Usuario == null)
            {
                MessageBox.Show("Usuário não encontrado !", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Atualiza variavel de controle
                txtIdUsuario.Text = String.Empty;
                //Inicializa foco
                txtIdUsuario.Focus();
                return;
            }
            else
            {
                if (vol_Usuario.Ativo != 0)
                {
                    MessageBox.Show("Conta de acesso desabilitada !", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdUsuario.Focus();
                    return;
                }
                else
                {
                    vcp_Senha = vol_Usuario.Senha;
                    lblNomeUsuario.Text = vol_Usuario.Nome;
                    vip_TipoPerfil = vol_Usuario.TipoPerfil;
                    vip_IdUsuario = vol_Usuario.IdUsuario;
                }
            }
        }
        private void TxtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void TxtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text.Trim() == String.Empty)
            {
                txtSenha.Text = String.Empty;
                lblNomeUsuario.Text = String.Empty;
            }
        }
        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSenha.Text.Trim() != String.Empty)
                {
                    BtnLogin_Click(sender, e);
                    return;
                }
            }
        }
        #endregion

        #region "Métodos Public"
        //Médodo público para atualizar controles 
        public Boolean Editar(String pAcessoLogin)
        {
            //Atualiza variaveis de controle
            vcg_AcessoLogin = pAcessoLogin;
            if (vcg_AcessoLogin == "0")
            {
                if (vcg_AcessoLogin == "0")
                {
                    this.Text = "Bem vindo ao TESTE_ESL_Loja";
                }
                else if (vcg_AcessoLogin == "1")
                {
                    this.Text = "Autenticação";
                }
            }
            return true;
        }
        #endregion
    }
}