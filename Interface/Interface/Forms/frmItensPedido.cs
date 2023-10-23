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
    public partial class FrmItensPedido : Form
    {
        #region Variaveis
        //Objetos das classes
        FBL_ItensPedido vol_FacadeItensPedido = null;
        FBL_Produtos vol_FacadeProdutos = null;
        //Variáveis Públicas
        public bool vbg_Editar = false;
        public Int32 vig_IdItensPedido = 0;                   
        public Int32 vig_IdPedido = 0; 
        public Int32 vig_IdProduto = 0;
        public String vsg_DescricaoProduto = String.Empty;
        public Double vdl_Qtde = 0;
        public Double vdl_ValorUnitario = 0;
        #endregion

        #region Form
        public FrmItensPedido()
        {
            InitializeComponent();
        }

        private void FrmItensPedido_Load(object sender, EventArgs e)
        {
            //Altera a cor de fundo do form
            this.BackColor = Color.FromArgb(231, 234, 244);
            //Adiciona o controle label do título a da imagem da barra
            pctBarra.Controls.Add(lblTitulo);
            //Adiciona o controle imagem do icone a da imagem da barra
            pctBarra.Controls.Add(pctIcone);
            //Valida controle de editar ou incluir licenca
            if (vbg_Editar)
            {
                //Inicializa objeto
                vol_FacadeItensPedido = new FBL_ItensPedido();
                ItensPedido vol_ItensPedido = vol_FacadeItensPedido.Editar(vig_IdPedido);
                //Preenche campos da tela
                if (vol_ItensPedido.IdItensPedido > 0)
                {
                    //
                }

                //Indica o foco habilidato
                txtIdProduto.Focus();
            }
            else
            {
                //Preparando atualizacao      
                FP_LimparControles(this.Controls, 0);

                //Inicializa objeto
                vol_FacadeItensPedido = new FBL_ItensPedido();
                //Obtém próximo ID
                txtIdItensPedido.Text = Convert.ToString(vol_FacadeItensPedido.NextId());
                //Atualiza variaveis de controle
                lblIdPedido.Text = Convert.ToString(vig_IdPedido);
                //Indica o foco habilidato
                txtIdProduto.Focus();
            }

        }

        private void FrmItensPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //simula o pressionar a tecla ESC
                BtnFechar_Click(sender, e);
            }
        }
        #endregion

        #region Controles
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (FP_ValidarCampos())
            {

                if (MessageBox.Show("Incluir item na lista ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Atualiza variaveis de controle
                    vig_IdItensPedido = Convert.ToInt32(txtIdItensPedido.Text);
                    vig_IdProduto = Convert.ToInt32(txtIdProduto.Text);
                    vsg_DescricaoProduto = lblDescricaoProduto.Text;
                    vdl_Qtde = Convert.ToDouble(string.Format("{0:n0}", txtQtde.Text));
                    vdl_ValorUnitario = Convert.ToDouble(string.Format("{0:n0}", txtValorUnitario.Text));
                    //Fecha form
                    this.Close();
                    this.Dispose();
                }

            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            //Atualiza variaveis de controle
            vig_IdItensPedido = 0;
            vig_IdProduto = 0;
            vsg_DescricaoProduto = String.Empty;
            vdl_Qtde = 0;
            vdl_ValorUnitario = 0;

            //Fecha form
            this.Close();
            this.Dispose();
        }

        private void TxtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BtnPesquisarCliente_Click(sender, e);
            }
        }

        private void TxtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxtProduto_Leave(object sender, EventArgs e)
        {
            if (txtIdProduto.Text.Length < 1) return;
            if (txtIdProduto.Text != String.Empty)
            {
                //Inicializa objeto
                vol_FacadeProdutos = new FBL_Produtos();
                //Seleciona o cliente
                Produtos vol_Produtos = vol_FacadeProdutos.SelecionarProdutos(Convert.ToInt32(txtIdProduto.Text));
                if (vol_Produtos != null)
                {
                    //Preenche campos da tela
                    if (!String.IsNullOrEmpty(vol_Produtos.Descricao))
                        txtIdProduto.Text = Convert.ToString(vol_Produtos.IdProduto).PadLeft(3, '0');
                        lblDescricaoProduto.Text = vol_Produtos.Descricao;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado !", "Cadastro de Itens do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualiza vriaveis de controle
                    lblDescricaoProduto.Text = String.Empty;
                    txtIdProduto.Text = String.Empty;
                }
            }
        }

        private void TxtProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProduto.Text.Trim() == String.Empty)
            {
                lblDescricaoProduto.Text = String.Empty;
            }
        }

        private void BtnPesquisarCliente_Click(object sender, EventArgs e)
        {
            FrmPesquisar vol_Pesquisar = new FrmPesquisar
            {
                vcg_Pesquisa = "Produtos"
            };
            vol_Pesquisar.ShowDialog();
            vol_Pesquisar.Dispose();
            //Preenche itens da tela
            txtIdProduto.Text = (vol_Pesquisar.vig_Codigo > 0 ? Convert.ToString(Convert.ToInt16(vol_Pesquisar.vig_Codigo)) : String.Empty).PadLeft(3, '0');
            lblDescricaoProduto.Text = vol_Pesquisar.vcg_Descricao;
        }

        private void TxtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita apenas numeros decimais
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if (e.KeyChar==(char)13)
            {
                txtQtde.Text = string.Format("{0:n0}", double.Parse(txtQtde.Text));
            }
        }

        private void TxtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita apenas numeros decimais
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if (e.KeyChar == (char)13)
            {
                txtQtde.Text = string.Format("{0:n0}", double.Parse(txtQtde.Text));
            }
        }
        #endregion

        #region "Funções"
        //Funcao para limpar controles
        private void FP_LimparControles(Control.ControlCollection controles, Single pTipo)
        {
            foreach (Control ctrl in controles)
            {
                if (pTipo == 0)
                {
                    if (ctrl is RadioButton button)
                    {
                        button.Checked = false;
                    }
                    if (ctrl is CheckBox box)
                    {
                        box.Checked = false;
                    }
                    if (ctrl is TextBox box1)
                    {
                        box1.Clear();
                    }
                    if (ctrl is ListView view)
                    {
                        view.Items.Clear();
                    }
                    if (ctrl is ComboBox box2)
                    {
                        box2.Items.Clear();
                    }
                }
                else if (pTipo == 1)
                {
                    if (ctrl is TextBox box)
                    {
                        box.Clear();
                    }
                }
                FP_LimparControles(ctrl.Controls, pTipo);
            }
        }

        //Valida campos de entrada do form
        private bool FP_ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtIdProduto.Text))
            {
                MessageBox.Show("Informe o produto do item do pedido !", "Cadastro de Itens do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdProduto.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtQtde.Text))
            {
                MessageBox.Show("Informe a qtde. do item do pedido !", "Cadastro de Itens do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdProduto.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtValorUnitario.Text))
            {
                MessageBox.Show("Informe a valor unitário do item do pedido !", "Cadastro de Itens do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdProduto.Focus();
                return false;
            }
            
            return true;
        }
        #endregion
    }
}
