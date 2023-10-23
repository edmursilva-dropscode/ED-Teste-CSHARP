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
    public partial class frmClientes : Form
    {
        #region Variaveis
        //Objetos das classes
        FBL_Clientes vol_FacadeClientes = null;
        //Variáveis Públicas
        public bool vbg_Editar = false;
        public Int32 vig_IdCliente = 0;
        #endregion

        #region Form
        public frmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //Altera a cor de fundo do form
            this.BackColor = Color.FromArgb(231, 234, 244);
            //Adiciona o controle label do título a da imagem da barra
            pctBarra.Controls.Add(lblTitulo);
            //Adiciona o controle imagem do icone a da imagem da barra
            pctBarra.Controls.Add(pctIcone);
            if (vbg_Editar)
            {
                //Inicializa objeto
                vol_FacadeClientes = new FBL_Clientes();
                Clientes vol_Clientes = vol_FacadeClientes.Editar(vig_IdCliente);
                //Preenche campos da tela
                if (vol_Clientes.IdCliente > 0)
                    lblIdCliente.Text = Convert.ToString(vol_Clientes.IdCliente).PadLeft(3, '0');
                if (!String.IsNullOrEmpty(vol_Clientes.Descricao))
                    txtDescricao.Text = vol_Clientes.Descricao;

            }
            else
            {
                //Atualiza controle do form
                btnExcluir.Visible = false;

                //Inicializa objeto
                vol_FacadeClientes = new FBL_Clientes();
                //Obtém próximo ID
                lblIdCliente.Text = Convert.ToString(vol_FacadeClientes.NextId()).PadLeft(3, '0');
            }
        }

        private void FrmClientes_KeyDown(object sender, KeyEventArgs e)
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
        #endregion

        #region Controles
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (FP_ValidarCampos())
            {
                //Inicializa o objeto
                vol_FacadeClientes = new FBL_Clientes();

                //Verifica se é alteração
                if (vbg_Editar)
                {
                    if (MessageBox.Show("Confirma a Alteração ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Altera os dados da anamnese
                        if (!vol_FacadeClientes.Alterar(Convert.ToInt32(lblIdCliente.Text), txtDescricao.Text))
                        {
                            //aviso de não alterado
                            MessageBox.Show("Não foi possível alterar o produto !", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        this.BtnFechar_Click(sender, e);
                    }
                }
                else
                {
                    if (MessageBox.Show("Confirma a Inclusão ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Inclui os dados da anamnese
                        if (!vol_FacadeClientes.Gravar(Convert.ToInt32(lblIdCliente.Text), txtDescricao.Text))
                        {
                            //aviso de não inclusao
                            MessageBox.Show("Não foi possível incluir o produto !", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        //Atualiza variavies de controle
                        vig_IdCliente = Convert.ToInt32(lblIdCliente.Text);

                        //Simula click no botao
                        this.BtnFechar_Click(sender, e);
                    }
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Inicializa o objeto
            vol_FacadeClientes = new FBL_Clientes();

            if (MessageBox.Show("Confirma a Excluir ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Altera os dados da anamnese
                if (!vol_FacadeClientes.Excluir(Convert.ToInt32(lblIdCliente.Text)))
                {
                    //aviso de não alterado
                    MessageBox.Show("Não foi possível excluir o produto !", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.BtnFechar_Click(sender, e);
            }
        }
        #endregion

        #region Métodos Privados
        //Valida campos de entrada do form
        private bool FP_ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição do produto !", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Focus();
                return false;
            }
            return true;
        }
        #endregion
    }
}
