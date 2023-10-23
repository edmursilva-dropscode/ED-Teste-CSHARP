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
    public partial class frmProdutos : Form
    {
        #region Variaveis
        //Objetos das classes
        FBL_Produtos vol_FacadeProdutos = null;
        //Variáveis Públicas
        public bool vbg_Editar = false;
        public Int32 vig_IdProduto = 0;
        #endregion

        #region Form
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
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
                vol_FacadeProdutos = new FBL_Produtos();
                Produtos vol_Produtos = vol_FacadeProdutos.Editar(vig_IdProduto);
                //Preenche campos da tela
                if (vol_Produtos.IdProduto > 0)
                    lblIdProduto.Text = Convert.ToString(vol_Produtos.IdProduto).PadLeft(3, '0');
                if (!String.IsNullOrEmpty(vol_Produtos.Descricao))
                    txtDescricao.Text = vol_Produtos.Descricao;

            }
            else
            {
                //Atualiza controle do form
                btnExcluir.Visible = false;

                //Inicializa objeto
                vol_FacadeProdutos = new FBL_Produtos();
                //Obtém próximo ID
                lblIdProduto.Text = Convert.ToString(vol_FacadeProdutos.NextId()).PadLeft(3, '0');
            }
        }

        private void frmProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape)
            {
                //simula o pressionar a tecla ESC
                btnFechar_Click(sender, e);
            }
        }
        #endregion

        #region Controles
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (FP_ValidarCampos())
            {
                //Inicializa o objeto
                vol_FacadeProdutos = new FBL_Produtos();

                //Verifica se é alteração
                if (vbg_Editar)
                {
                    if (MessageBox.Show("Confirma a Alteração ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Altera os dados da anamnese
                        if (!vol_FacadeProdutos.Alterar(Convert.ToInt32(lblIdProduto.Text), txtDescricao.Text))
                        {
                            //aviso de não alterado
                            MessageBox.Show("Não foi possível alterar o produto !", "Cadastro de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        this.btnFechar_Click(sender, e);
                    }
                }
                else
                {
                    if (MessageBox.Show("Confirma a Inclusão ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Inclui os dados da anamnese
                        if (!vol_FacadeProdutos.Gravar(Convert.ToInt32(lblIdProduto.Text), txtDescricao.Text))
                        {
                            //aviso de não inclusao
                            MessageBox.Show("Não foi possível incluir o produto !", "Cadastro de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        //Atualiza variavies de controle
                        vig_IdProduto = Convert.ToInt32(lblIdProduto.Text);

                        //Simula click no botao
                        this.btnFechar_Click(sender, e);
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Inicializa o objeto
            vol_FacadeProdutos = new FBL_Produtos();

            if (MessageBox.Show("Confirma a Excluir ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Altera os dados da anamnese
                if (!vol_FacadeProdutos.Excluir(Convert.ToInt32(lblIdProduto.Text), String.Empty))
                {
                    //aviso de não alterado
                    MessageBox.Show("Não foi possível excluir o produto !", "Cadastro de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.btnFechar_Click(sender, e);
            }
        }
        #endregion

        #region Métodos Privados
        //Valida campos de entrada do form
        private bool FP_ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descriçõ do produto !", "Cadastro de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Focus();
                return false;
            }
            return true;
        }
        #endregion





    }
}
