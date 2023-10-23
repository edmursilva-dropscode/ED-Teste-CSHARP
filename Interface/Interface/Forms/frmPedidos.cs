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
    public partial class FrmPedidos : Form
    {
        #region Variaveis
        //Objetos das classes
        FBL_Pedidos vol_FacadePedidos = null;
        FBL_Clientes vol_FacadeClientes = null;
        FBL_ItensPedido vol_FacadeItensPedido = null;
        FBL_Functions vol_FacadeFunctions = null;
        //Variáveis Públicas
        public bool vbg_Editar = false;                           
        public Int32 vig_IdPedido = 0;     
        public Int32 vig_IdCliente = 0;
        public Int32 vig_IdItensPedido = 0;
        public Int32 vig_IdProduto = 0;
        public String vsg_DescricaoProduto = String.Empty;
        public Double vdg_Qtde = 0;
        public Double vdg_ValorUnitario = 0;        
        public Int32 vip_ItemLista = 0;
        //Variaveis private

        #endregion

        #region Form
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            //Altera a cor de fundo do form
            this.BackColor = Color.FromArgb(231, 234, 244);
            //Adiciona o controle label do título a da imagem da barra
            pctBarra.Controls.Add(lblTitulo);
            //Adiciona o controle imagem do icone a da imagem da barra
            pctBarra.Controls.Add(pctIcone);
            //Inicializa objeto
            vol_FacadeFunctions = new FBL_Functions();
            vol_FacadeFunctions.ColorListView(lvwItensPedido, false);
            lvwItensPedido.Items.Clear();
            //Valida controle de editar ou incluir
            if (vbg_Editar)
            {
                //Inicializa objeto
                vol_FacadePedidos = new FBL_Pedidos();
                Pedidos vol_Pedidos = vol_FacadePedidos.Editar(vig_IdPedido);
                //Preenche campos da tela
                if (vol_Pedidos.IdPedido > 0)
                {
                    //Preenche campos da tela
                    if (vol_Pedidos.IdPedido > 0)
                    {
                        vig_IdPedido = Convert.ToInt32(vol_Pedidos.IdPedido);
                        lblIdPedido.Text = Convert.ToString(vol_Pedidos.IdPedido);
                    }
                    if (vol_Pedidos.IdCliente > 0)
                    {
                        vig_IdCliente = Convert.ToInt32(vol_Pedidos.IdCliente);
                        txtIdCliente.Text = Convert.ToString(vol_Pedidos.IdCliente).PadLeft(3, '0');
                    }
                    if (!String.IsNullOrEmpty(vol_Pedidos.DtVenda))
                        dtpDataVenda.Text = Convert.ToString(vol_Pedidos.DtVenda);

                    //Inicializa objeto
                    vol_FacadeClientes = new FBL_Clientes();
                    //Seleciona o cliente
                    Clientes vol_Clientes = vol_FacadeClientes.SelecionarClientes(vig_IdCliente);
                    if (vol_Clientes != null)
                    {
                        //Preenche campos da tela
                        if (vol_Clientes.IdCliente > 0)
                            txtIdCliente.Text = Convert.ToString(vol_Clientes.IdCliente).PadLeft(3, '0'); ;
                        if (!String.IsNullOrEmpty(vol_Clientes.Descricao))
                            lblNomeCliente.Text = vol_Clientes.Descricao;
                    }
                }

                //Exibe dados dos itens do pedido
                vol_FacadeItensPedido = new FBL_ItensPedido();
                vol_FacadeItensPedido.ListarItensPedido(lvwItensPedido, vig_IdPedido);

                //Indica o foco habilidato
                dtpDataVenda.Focus();
            }
            else
            {
                //Preparando atualizacao      
                FP_LimparControles(this.Controls, 0);

                //Atualiza controle do form
                btnExcluir.Visible = false;

                //Inicializa objeto
                vol_FacadePedidos = new FBL_Pedidos();
                //Obtém próximo ID
                lblIdPedido.Text = Convert.ToString(vol_FacadePedidos.NextId()).PadLeft(3, '0');
                vig_IdPedido = Convert.ToInt32(lblIdPedido.Text);

                //Indica o foco habilidato
                dtpDataVenda.Focus();
            }
        }

        private void FrmPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //simula o pressionar a tecla ESC
                BtnFechar_Click(sender, e);
            }
        }
        #endregion

        #region Controles
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Inicializa o objeto
            vol_FacadePedidos = new FBL_Pedidos();

            if (MessageBox.Show("Confirma a Excluir ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Altera os dados 
                if (!vol_FacadePedidos.Excluir(Convert.ToInt32(lblIdPedido.Text)))
                {
                    //aviso de não alterado
                    MessageBox.Show("Não foi possível excluir o pedido !", "Cadastro de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.BtnFechar_Click(sender, e);
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (FP_ValidarCampos())
            {
                //Inicializa o objeto
                vol_FacadePedidos = new FBL_Pedidos();

                //Verifica se é alteração
                if (vbg_Editar)
                {
                    if (MessageBox.Show("Confirma a Alteração ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Altera os dados da anamnese
                        if (!vol_FacadePedidos.Alterar(Convert.ToInt32(lblIdPedido.Text), String.Format("{0:dd/MM/yyyy}", dtpDataVenda.Value), Convert.ToInt32(txtIdCliente.Text), lvwItensPedido))                       
                        {
                            //aviso de não alterado
                            MessageBox.Show("Não foi possível alterar o pedido !", "Cadastro de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (!vol_FacadePedidos.Gravar(Convert.ToInt32(lblIdPedido.Text), String.Format("{0:dd/MM/yyyy}", dtpDataVenda.Value), Convert.ToInt32(txtIdCliente.Text), lvwItensPedido))
                        {
                            //aviso de não inclusao
                            MessageBox.Show("Não foi possível incluir o pedido !", "Cadastro de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        //Atualiza variavies de controle
                        vig_IdPedido = Convert.ToInt32(lblIdPedido.Text);

                        //Simula click no botao
                        this.BtnFechar_Click(sender, e);
                    }
                }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        private void TxtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BtnPesquisarCliente_Click(sender, e);
            }
        }

        private void TxtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxtCliente_Leave(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length < 1) return;
            if (txtIdCliente.Text != String.Empty)
            {
                //Inicializa objeto
                vol_FacadeClientes = new FBL_Clientes();
                //Seleciona o cliente
                Clientes vol_Clientes = vol_FacadeClientes.SelecionarClientes(Convert.ToInt32(txtIdCliente.Text));
                if (vol_Clientes != null)
                {
                    //Preenche campos da tela
                    if (!String.IsNullOrEmpty(vol_Clientes.Descricao))
                        txtIdCliente.Text = Convert.ToString(vol_Clientes.IdCliente).PadLeft(3, '0');
                        lblNomeCliente.Text = vol_Clientes.Descricao;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado !", "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualiza variaveis de controle
                    lblNomeCliente.Text = String.Empty;
                    txtIdCliente.Text = String.Empty;
                }
            }
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Trim() == String.Empty)
            {
                lblNomeCliente.Text = String.Empty;
            }
        }

        private void BtnPesquisarCliente_Click(object sender, EventArgs e)
        {
            FrmPesquisar vol_Pesquisar = new FrmPesquisar
            {
                vcg_Pesquisa = "Clientes"
            };
            vol_Pesquisar.ShowDialog();
            vol_Pesquisar.Dispose();
            //Preenche itens da tela
            txtIdCliente.Text = (vol_Pesquisar.vig_Codigo > 0 ? Convert.ToString(Convert.ToInt16(vol_Pesquisar.vig_Codigo)) : String.Empty).PadLeft(3, '0');
            lblNomeCliente.Text = vol_Pesquisar.vcg_Descricao;
        }

        private void BtnIncluirItem_Click(object sender, EventArgs e)
        {
            //Objetos das classes
            FrmItensPedido vol_ItensPedido = new FrmItensPedido
            {
                //Atualiza variaveis de controle
                vig_IdItensPedido = 0,
                vig_IdPedido = vig_IdPedido
            };
            //Chama o form
            vol_ItensPedido.ShowDialog();
            //Atualiza variaveis de controle
            vig_IdItensPedido = vol_ItensPedido.vig_IdItensPedido;
            vig_IdProduto = vol_ItensPedido.vig_IdProduto;
            vsg_DescricaoProduto = vol_ItensPedido.vsg_DescricaoProduto;
            vdg_Qtde = vol_ItensPedido.vdl_Qtde;
            vdg_ValorUnitario = vol_ItensPedido.vdl_ValorUnitario;
            //Valida lista de intens 
            if (vol_ItensPedido.vig_IdProduto > 0)
            {
                //Vaidada produto a ser incluido na lista
                FP_ValidarProduto();
            }
        }

        private void BtnExcluirItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Excluir do item da lista ?", "Confirme !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vip_ItemLista = 0;
                //Remove da lista o item escolhido
                ListView.SelectedListViewItemCollection vil_items = lvwItensPedido.SelectedItems;
                foreach (ListViewItem item in vil_items) item.Remove();
            }
        }

        private void LvwItensPedido_Click(object sender, EventArgs e)
        {
            //Guarda qual o item da lista a ser excluido
            vip_ItemLista = lvwItensPedido.SelectedIndices[0];
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
            if (String.IsNullOrEmpty(txtIdCliente.Text))
            {
                MessageBox.Show("Informe o cliente do pedido !", "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdCliente.Focus();
                return false;
            }
            return true;
        }

        //Valida produto na lista de itens
        private bool FP_ValidarProduto()
        {
            //Variaveis de controle
            Int32 vil_Count = 0;
            Boolean vbl_IncluirProduto = false;

            //Valida produto na lista
            for (int vil_ListItem = 0; vil_ListItem < lvwItensPedido.Items.Count; vil_ListItem++)
            {
                if (Convert.ToInt32(lvwItensPedido.Items[vil_ListItem].SubItems[6].Text) == vig_IdProduto)
                {
                    //Atualiza variaveis de controle
                    vbl_IncluirProduto = true;
                    //
                    break;
                }
            }

            //Incluir item na lista
            if (vbl_IncluirProduto == false)
            {
                ListViewItem vol_ListViewItem = new ListViewItem("");
                vol_ListViewItem.SubItems.Add(Convert.ToString(vig_IdProduto).PadLeft(3, '0'));
                vol_ListViewItem.SubItems.Add(Convert.ToString(vsg_DescricaoProduto));
                vol_ListViewItem.SubItems.Add(Convert.ToString(vdg_Qtde));
                vol_ListViewItem.SubItems.Add(Convert.ToString(vdg_ValorUnitario));
                vol_ListViewItem.SubItems.Add(String.Format("{0:N2}", vdg_Qtde * vdg_ValorUnitario));
                vol_ListViewItem.SubItems.Add(Convert.ToString(vig_IdProduto));
                vol_ListViewItem.SubItems.Add(Convert.ToString(vig_IdItensPedido + lvwItensPedido.Items.Count));
                vol_ListViewItem.SubItems.Add(Convert.ToString(vig_IdPedido));
                //Aciciona cor na lista
                lvwItensPedido.Items.Add(vol_ListViewItem);
                //Inicializa objeto
                vol_FacadeFunctions = new FBL_Functions();
                vil_Count++;
                vol_FacadeFunctions.AplicarCorLista(vol_ListViewItem, vil_Count);
            }
            else
            {
                MessageBox.Show("Produto já existe na lista !", "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return true;
        }
        #endregion

    }
}
