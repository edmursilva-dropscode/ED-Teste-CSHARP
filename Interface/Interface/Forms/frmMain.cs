using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Janus.Windows.GridEX;
using System.Xml;
using FrameWork.Negocios;
using FrameWork.Facade;
using FrameWork.Entidades;

namespace Interface.Forms
{
    public partial class FrmMain : Form
    {
        #region Variaveis
        //Objetos de classe
        private FBL_Functions vol_FacadeFunctions = null;
        private FBL_Pedidos vol_FacadePedidos = null;
        private FBL_Produtos vol_FacadeProdutos = null;
        private FBL_Clientes vol_FacadeClientes = null;
        private FBL_ItensPedido vol_FacadeItensPedido = null;
        //Variaveis public
        public Boolean vbg_Login = false;
        //Variaveis private
        private String vcp_Modulo = String.Empty;
        private String vcp_SubModulo = String.Empty;
        //Controle de variaveis do Pedido
        private Int32 vil_IdPedido = 0;
        private Int32 vil_IdProduto = 0;
        private Int32 vil_IdCliente = 0;
        #endregion

        #region Form
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Controla a exibição do painel de categorias
            FP_ExibirCategorias();

            //Redimensiona a Toolbar
            FP_Toolbar(0);

            //Chama o Form de login 
            FrmLogin vol_Login = new FrmLogin(this);
            vol_Login.Hide();
            if (vol_Login.Editar("0"))
            {
                vol_Login.ShowDialog();
            }
            if (!vbg_Login)
            {
                this.Dispose();
                this.Close();
            }
            else if (vbg_Login)
            {
                //
                brdCategoria.lblTitulo.Text = "Categorias";
                //
                brdBordaMain.lblTitulo.Text = "TESTE_ESL_Loja";

                //Carrega o Treeview 
                vol_FacadeFunctions = new FBL_Functions();
                vol_FacadeFunctions.TreeMain(trvMain, imgTreeView);
                //Redimensiona os componentes do frmMain
                FP_Redimensionar(vcp_Modulo);
                //Redimensiona a Toolbar
                FP_Toolbar(1);
                //Controla a exibição do painel de categorias
                FP_ExibirCategorias();
            }
            vol_Login.Dispose();

            //Redimensiona os componentes do frmMain
            FP_Redimensionar(vcp_Modulo);

        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)14 && tsbNovo.Visible) // Ctrl + N
                {
                    this.FP_Novo(vcp_Modulo);
                }

                if (e.KeyChar == (char)16 && tsbImprimir.Visible) // Ctrl + P
                {
                    
                }
            }
            catch
            {
                return;
            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5 && tsbAtualizar.Visible)
                {
                    this.FP_Atualizar();
                }
                if (e.KeyCode == Keys.F7 && tsbCalculadora.Visible)
                {
                    this.FP_Calculadora();
                }
                if (e.KeyCode == Keys.F8 && (tsbExibirCategoria.Visible || tsbOcultarCategoria.Visible))
                {
                    this.FP_OcultarCategoria();
                }
                if (e.KeyCode == Keys.F9 && tsbLogin.Visible)
                {
                    this.FP_Login();
                }
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region Controles
        private void TreeMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Atualiza variavies de controle
            pnlPedidos.Visible = false;
            pnlProdutos.Visible = false;
            pnlClientes.Visible = false;
            //
            vil_IdPedido = 0;
            //
            vcp_Modulo = (e.Node.Name); 
            //
            switch (vcp_Modulo)
            {
                case "":
                case "Home":
                    pnlMenu.Visible = true;
                    pnlLogo.Visible = true;
                    brdBordaMain.lblTitulo.Text = "TESTE_ESL_Loja";
                    FP_Toolbar(1);
                    FP_Redimensionar(vcp_Modulo);
                    this.Refresh();

                    break;
                case "Pedidos":
                case "PedidosPendentes":
                case "PedidosConcluidos":
                    vcp_SubModulo = "ItemPedido";
                    brdBordaMain.lblTitulo.Text = "Registro de (" + (e.Node.Text).ToLower() + ")";                    
                    pnlMenu.Visible = false;
                    pnlLogo.Visible = false;                    
                    FP_Toolbar(15);
                    FP_Redimensionar(vcp_Modulo);
                    FP_CarregarGrid(vcp_Modulo);
                    pnlPedidos.Visible = true;
                    txtLocalizarPedidos.Focus();
                    break;
                case "Produtos":
                case "ProdutosAtivos":
                case "ProdutosDescontinuados":
                    vcp_SubModulo = String.Empty;
                    brdBordaMain.lblTitulo.Text = "Registro de (" + (e.Node.Text).ToLower() + ")";
                    pnlMenu.Visible = false;
                    pnlLogo.Visible = false;
                    FP_Toolbar(15);
                    FP_Redimensionar(vcp_Modulo);
                    FP_CarregarGrid(vcp_Modulo);
                    pnlProdutos.Visible = true;
                    txtLocalizarProdutos.Focus();
                    break;
                case "Clientes":
                case "ClientesAtivos":
                case "ClientesDescontinuados":
                    vcp_SubModulo = String.Empty;
                    brdBordaMain.lblTitulo.Text = "Registro de (" + (e.Node.Text).ToLower() + ")";
                    pnlMenu.Visible = false;
                    pnlLogo.Visible = false;
                    FP_Toolbar(15);
                    FP_Redimensionar(vcp_Modulo);
                    FP_CarregarGrid(vcp_Modulo);
                    pnlClientes.Visible = true;
                    txtLocalizarClientes.Focus();
                    break;
                default:
                    break;
            }
        }

        private void TspMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Select para verificar qual botão do menu foi requisitado
            switch (e.ClickedItem.Name)
            {
                case "tsbAtualizar":
                    FP_Atualizar();
                    break;
                case "tsbCalculadora":
                    FP_Calculadora();
                    break;
                case "tsbEditar":
                    break;
                case "tsbExibirCategoria":
                    FP_OcultarCategoria();
                    break;
                case "tsbOcultarCategoria":
                    FP_OcultarCategoria();
                    break;
                case "tsbLocalizar":
                    break;
                case "tsbLogin":
                    FP_Login();
                    break;
                case "tsbNovo":
                    FP_Novo(vcp_Modulo);
                    break;
            }
        }

        private void MnuArquivoLogin_Click(object sender, EventArgs e)
        {
            //Primeira alternar o estado de ativação do item de menu associados
            tsbLogin.Checked = !tsbLogin.Checked;
            //Alterar as pastas botão da barra de ferramentas para a sincronização
            tsbLogin.Checked = tsbLogin.Checked;
            //Chama o Form de login 
            FrmLogin vol_Login = new FrmLogin(this);
            vol_Login.Hide();
            if (vol_Login.Editar("1"))
            {
                vol_Login.ShowDialog();
            }
            if (vbg_Login)
            {
                vol_FacadeFunctions = new FBL_Functions();
                //Carrega o Treeview 
                vol_FacadeFunctions.TreeMain(trvMain, imgTreeView);
                //Redimensiona os componentes do frmMain
                vcp_Modulo = "Home";
                pnlPedidos.Visible = false;
                pnlProdutos.Visible = false; 
                pnlClientes.Visible = false;
 
                //
                FP_Redimensionar(vcp_Modulo);
                //Redimensiona a Toobar
                FP_Toolbar(1);
                //
                brdCategoria.Titulo = "SIIG - Gestão de Conselheiro";
            }
            vol_Login.Dispose();
        }

        private void MnuArquivoImpressora_Click(object sender, EventArgs e)
        {
            PrintDialog vop_PrintDialog = new PrintDialog();
            vop_PrintDialog.ShowDialog();
            vop_PrintDialog.Dispose();
        }

        private void MnuArquivoSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void DgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            //Objeto de acesso ao form
            frmProdutos vol_Produtos = new frmProdutos
            {
                vig_IdProduto = vil_IdProduto,
                vbg_Editar = true
            };
            vol_Produtos.ShowDialog();
            vol_Produtos.Dispose();

            //Atualiza grid
            FP_CarregarGrid(vcp_Modulo);
        }

        private void DgvProdutos_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                DataGridView.HitTestInfo hit = dgvProdutos.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    vil_IdProduto = Convert.ToInt32(dgvProdutos.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }


        private void DgvClientes_DoubleClick(object sender, EventArgs e)
        {
            //Objeto de acesso ao form
            frmClientes vol_Clientes = new frmClientes
            {
                vig_IdCliente = vil_IdCliente,
                vbg_Editar = true
            };
            vol_Clientes.ShowDialog();
            vol_Clientes.Dispose();

            //Atualiza grid
            FP_CarregarGrid(vcp_Modulo);
        }

        private void DgvClientes_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridView.HitTestInfo hit = dgvClientes.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    vil_IdCliente = Convert.ToInt32(dgvClientes.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }

        private void DgvPedidos_DoubleClick(object sender, EventArgs e)
        {
            //Objeto de acesso ao form
            FrmPedidos vol_Pedidos = new FrmPedidos
            {
                vig_IdPedido = vil_IdPedido,
                vbg_Editar = true
            };
            vol_Pedidos.ShowDialog();
            vol_Pedidos.Dispose();

            //Atualiza grid
            FP_CarregarGrid(vcp_Modulo);
        }

        private void DgvPedidos_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                DataGridView.HitTestInfo hit = dgvPedidos.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    vil_IdPedido = Convert.ToInt32(dgvPedidos.Rows[hit.RowIndex].Cells[0].Value);
                }
                //Monta lista
                FP_ExibeListaItensPedido(vcp_SubModulo);
            }
        }
        #endregion

        #region Funcoes
        private void FP_Atualizar()
        {
            switch (vcp_Modulo)
            {
                case "Pedidos":
                case "PedidosPendentes":
                case "PedidosConcluidos":
                    FP_CarregarGrid(vcp_Modulo);
                    break;
                case "Produtos":
                case "ProdutosAtivos":
                case "ProdutosDescontinuados":
                    FP_CarregarGrid(vcp_Modulo);
                    break;
                case "Clientes":
                case "ClientesAtivos":
                case "ClientesDescontinuados":
                    FP_CarregarGrid(vcp_Modulo);
                    break;                
                default:
                    break;
            }
        }

        //Chama a função calculadora
        private void FP_Calculadora()
        {
            System.Diagnostics.Process.Start("calc");
        }

        //Exibe a categoria do form 
        private void FP_ExibirCategorias()
        {
            //Primeira alternar o estado de ativação do item de menu associados
            tsbOcultarCategoria.Checked = !tsbOcultarCategoria.Checked;
            //Alterar as pastas botão da barra de ferramentas para a sincronização
            tsbOcultarCategoria.Checked = tsbOcultarCategoria.Checked;
            // Recolher o painel contendo o TreeView.
            this.splMain.Panel1Collapsed = !tsbOcultarCategoria.Checked;
            //Exibe a categoria do form
            if (!tsbOcultarCategoria.Checked)
            {
                //tsbOcultarCategoria.Visible = false;
                //tsbExibirCategoria.Visible = true;
                //
                if (vcp_Modulo == "Home")
                {
                    //Move o logo do mascote do sistema para o canto inferior direito da tela
                    pctLogo3.Location = new Point((brdBordaMain.Width - pctLogo3.Width) - 10, (brdBordaMain.Height - pctLogo3.Height) - 1);
                    pctLogo3.Visible = true;
                }
                else
                {
                    //Move o logo do mascote do sistema para o canto inferior direito da tela
                    if (vcp_Modulo == "Pedidos")
                    {
                        pnlPedidos.Width = brdBordaMain.Width;
                    }
                    else if (vcp_Modulo == "Produtos")
                    {
                        pnlClientes.Width = brdBordaMain.Width;
                    }
                    else if (vcp_Modulo == "Clientes")
                    {
                        pnlProdutos.Width = brdBordaMain.Width;
                    }
                    pctLogo3.Location = new Point((brdBordaMain.Width - pctLogo3.Width) - 10, (brdBordaMain.Height - pctLogo3.Height) - 1);
                    pctLogo3.Visible = false;

                }


            }
            else
            {
                //tsbOcultarCategoria.Visible = true;
                //tsbExibirCategoria.Visible = false;
                //
                if (vcp_Modulo == "Home")
                {
                    //Move o logo do mascote do sistema para o canto inferior direito da tela
                    pctLogo3.Location = new Point((brdBordaMain.Width - pctLogo3.Width) - 10, (brdBordaMain.Height - pctLogo3.Height) - 1);                   
                    pctLogo3.Visible = true;
                }
                else
                {
                    //Move o logo do mascote do sistema para o canto inferior direito da tela
                    if (vcp_Modulo == "Pedidos")
                    {
                        pnlPedidos.Width = brdBordaMain.Width;
                    }
                    else if (vcp_Modulo == "Produtos")
                    {
                        pnlClientes.Width = brdBordaMain.Width;
                    }
                    else if (vcp_Modulo == "Clientes")
                    {
                        pnlProdutos.Width = brdBordaMain.Width;
                    }
                    pctLogo3.Location = new Point((brdBordaMain.Width - pctLogo3.Width) - 10, (brdBordaMain.Height - pctLogo3.Height) - 1);
                    pctLogo3.Visible = false;
                }
            }
        }

        //
        private void FP_OcultarCategoria()
        {
            //Redimensiona os componentes 
            FP_ExibirCategorias();
        }

        //
        private void FP_Login()
        {
            //Primeira alternar o estado de ativação do item de menu associados
            tsbLogin.Checked = !tsbLogin.Checked;
            //Alterar as pastas botão da barra de ferramentas para a sincronização
            tsbLogin.Checked = tsbLogin.Checked;
            //Chama o Form de login 
            FrmLogin vol_Login = new FrmLogin(this);
            vol_Login.Hide();
            if (vol_Login.Editar("1"))
            {
                vol_Login.ShowDialog();
            }
            if (vbg_Login)
            {
                vol_FacadeFunctions = new FBL_Functions();
                //Carrega o Treeview 
                vol_FacadeFunctions.TreeMain(trvMain, imgTreeView);
                //Redimensiona os componentes do frmMain
                vcp_Modulo = "Home";
                pnlPedidos.Visible = false;
                pnlProdutos.Visible = false;
                pnlClientes.Visible = false;
                
                //
                FP_Redimensionar(vcp_Modulo);
                //Redimensiona a Toobar
                FP_Toolbar(1);
                //
                brdCategoria.Titulo = "SIIG - Gestão de Conselheiro";
            }
            vol_Login.Dispose();
        }

        //
        private void FP_Novo(string pNomeNode)
        {
            try
            {
                switch (pNomeNode)
                {
                    case "Pedidos":
                    case "PedidosPendentes":
                    case "PedidosConcluidos":
                        //Objetos das classes
                        FrmPedidos vol_Pedidos = new FrmPedidos
                        {
                            //Atualiza variaveis de controle
                            vig_IdPedido = vil_IdPedido
                        };
                        //Chama o form
                        vol_Pedidos.ShowDialog();
                        //Atualiza grid
                        FP_Atualizar();
                        //
                        if (vol_Pedidos.vig_IdPedido > 0)
                        {
                            vil_IdPedido = vol_Pedidos.vig_IdPedido;
                            //Recupera identificador da linha                    
                            if (dgvProdutos.RowCount != 0)
                            {
                                dgvProdutos.Refresh();
                            }
                            vil_IdPedido = 0;
                        }
                        break;
                    case "Produtos":
                    case "ProdutosAtivos":
                    case "ProdutosDescontinuados":
                        //Objetos das classes
                        frmProdutos vol_Produtos = new frmProdutos
                        {
                            //Atualiza variaveis de controle
                            vig_IdProduto = vil_IdProduto
                        };
                        //Chama o form
                        vol_Produtos.ShowDialog();
                        //Atualiza grid
                        FP_Atualizar();
                        //
                        if (vol_Produtos.vig_IdProduto > 0)
                        {
                            vil_IdProduto = vol_Produtos.vig_IdProduto;
                            //Recupera identificador da linha                    
                            if (dgvProdutos.RowCount != 0)
                            {                                
                                dgvProdutos.Refresh();
                            }
                            vil_IdProduto = 0;
                        }
                        break;
                    case "Clientes":
                    case "ClientesAtivos":
                    case "ClientesDescontinuados":
                        //Objetos das classes
                        frmClientes vol_Clientes = new frmClientes
                        {
                            //Atualiza variaveis de controle
                            vig_IdCliente = vil_IdCliente
                        };
                        //Chama o form
                        vol_Clientes.ShowDialog();
                        //Atualiza grid
                        FP_Atualizar();
                        //
                        if (vol_Clientes.vig_IdCliente > 0)
                        {
                            vil_IdCliente = vol_Clientes.vig_IdCliente;
                            //Recupera identificador da linha                    
                            if (dgvClientes.RowCount != 0)
                            {
                                dgvClientes.Refresh();
                            }
                            vil_IdCliente = 0;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                return;
            }
        }

        //Redimensiona o grid
        private void FP_Redimensionar(string pNomeNode)
        {
            //Atualiza variaveis de controle

            switch (pNomeNode)
            {
                case "":
                case "Home":
                    //Move o logo do mascote do sistema para o canto inferior direito da tela
                    pctLogo3.Location = new Point((brdBordaMain.Width - pctLogo3.Width) + brdBordaMain.Height / 2 - 40, (brdBordaMain.Height - pctLogo3.Height) + 40);
                    pctLogo3.Visible = true;
                    if (pNomeNode == "Home")
                    {
                        pnlMenu.Visible = true;
                    }                    
                    vcp_Modulo = "Home";
                    //
                    break;
                case "Pedidos":
                case "PedidosPendentes":
                case "PedidosConcluidos":
                    pctLogo3.Visible = false;
                    pctGuiaPedidos01.Visible = true;
                    //
                    trvMain.Width = splMain.Panel1.Width - 5;
                    trvMain.Height = splMain.Panel1.Height - 45;
                    trvMain.Left = 1;
                    //
                    pnlPedidos.Left = 2;
                    pnlPedidos.Top = 26;
                    pnlPedidos.Width = splMain.Panel2.Width - 3;
                    pnlPedidos.Height = splMain.Panel2.Height - 27;
                    //
                    pnlLocalizarPedidos.Visible = true;
                    pnlLocalizarPedidos.Top = 0;
                    pnlLocalizarPedidos.Left = 1;
                    pnlLocalizarPedidos.Width = brdBordaMain.Width;
                    //
                    txtLocalizarPedidos.Width = (pnlPedidos.Width / 2);
                    //
                    //
                    dgvPedidos.Visible = true;
                    dgvPedidos.Top = 40;
                    dgvPedidos.Left = 1;
                    dgvPedidos.Width = brdBordaMain.Width;
                    dgvPedidos.Height = (pnlPedidos.Height / 2) - 42;
                    //
                    lvwItensPedido.Left = 1;
                    lvwItensPedido.Width = dgvPedidos.Width;
                    lvwItensPedido.Top = (pnlPedidos.Height / 2);
                    lvwItensPedido.Height = ((pnlPedidos.Height / 2) - 22);
                    pctGuiaPedidos01.Left = 1;
                    pctGuiaPedidos01.Top = lvwItensPedido.Height + lvwItensPedido.Top;
                    //
                    break;
                case "Produtos":
                case "ProdutosAtivos":
                case "ProdutosDescontinuados":
                    pctLogo3.Visible = false;
                    //
                    trvMain.Width = splMain.Panel1.Width - 5;
                    trvMain.Height = splMain.Panel1.Height - 45;
                    trvMain.Left = 1;
                    //
                    pnlProdutos.Left = 2;
                    pnlProdutos.Top = 26;
                    pnlProdutos.Width = splMain.Panel2.Width - 3;
                    pnlProdutos.Height = splMain.Panel2.Height - 27;
                    //
                    pnlLocalizarProdutos.Visible = true;
                    pnlLocalizarProdutos.Top = 0;
                    pnlLocalizarProdutos.Left = 1;
                    pnlLocalizarProdutos.Width = brdBordaMain.Width;
                    //
                    txtLocalizarProdutos.Width = (pnlProdutos.Width / 2);
                    //
                    dgvProdutos.Visible = true;
                    dgvProdutos.Top = 40;
                    dgvProdutos.Left = 1;
                    dgvProdutos.Width = brdBordaMain.Width;
                    dgvProdutos.Height = (pnlProdutos.Height - pnlLocalizarProdutos.Height - 2);
                    //
                    break;
                case "Clientes":
                case "ClientesAtivos":
                case "ClientesDescontinuados":
                    pctLogo3.Visible = false;
                    //
                    trvMain.Width = splMain.Panel1.Width - 5;
                    trvMain.Height = splMain.Panel1.Height - 45;
                    trvMain.Left = 1;
                    //
                    pnlClientes.Left = 2;
                    pnlClientes.Top = 26;
                    pnlClientes.Width = splMain.Panel2.Width - 3;
                    pnlClientes.Height = splMain.Panel2.Height - 27;
                    //
                    pnlLocalizarClientes.Visible = true;
                    pnlLocalizarClientes.Top = 0;
                    pnlLocalizarClientes.Left = 1;
                    pnlLocalizarClientes.Width = brdBordaMain.Width;
                    //
                    txtLocalizarClientes.Width = (pnlClientes.Width / 2);
                    //
                    dgvClientes.Visible = true;
                    dgvClientes.Top = 40;
                    dgvClientes.Left = 1;
                    dgvClientes.Width = brdBordaMain.Width;
                    dgvClientes.Height = (pnlClientes.Height - pnlLocalizarClientes.Height - 2);
                    //
                    break;
                default:
                    //Move o logo do mascote do sistema para o canto inferior direito da tela
                    pctLogo3.Location = new Point((brdBordaMain.Width - pctLogo3.Width) + 300, (brdBordaMain.Height - pctLogo3.Height) + 40);
                    pctLogo3.Visible = true;
                    vcp_Modulo = "Home";
                    //
                    break;
            }
        }

        //Atualiza botoes
        private void FP_Toolbar(int pBotoes)
        {
            for (int vil_ListaBotoes = 0; vil_ListaBotoes < tspMain.Items.Count; vil_ListaBotoes++)
            {
                tspMain.Items[vil_ListaBotoes].Visible = false;
            }

            if (pBotoes == 0)
            {
                mnuArquivo.Visible = false;
                tspMain.Visible = false;
            }
            else if (pBotoes == 1)
            {
                mnuArquivo.Visible = true;
                tspMain.Visible = true;
                tsbImprimir.Visible = false;
                tsbAtualizar.Visible = true;
                tsbOcultarCategoria.Visible = false;
                tsbLogin.Visible = true;
                tsbAjuda.Visible = false;
            }
            else if (pBotoes == 15)
            {
                mnuArquivo.Visible = true;
                tspMain.Visible = true;

                switch (vcp_Modulo)
                {
                    case "Pedidos": 
                        tsbNovo.Visible = true;
                        break;
                    case "Produtos":
                        tsbNovo.Visible = true;
                        break;
                    case "Clientes":
                        tsbNovo.Visible = true;
                        break;
                    default:
                        break;
                }
                tsbImprimir.Visible = false;
                tsbExcel.Visible = false;
                tsbAgrupar.Visible = false;
                tsbExibirCategoria.Visible = false;
                tsbOcultarCategoria.Visible = false;
                tsbAtualizar.Visible = true;
                tsbDetalhes.Visible = false;
                tsbLogin.Visible = false;
            }
        }

        private void FP_CarregarGrid(string pModulo)
        {

            //Atualiza vaiaveis de controle
            vil_IdProduto = 0;
            vil_IdCliente = 0;
            vil_IdPedido = 0;

            switch (pModulo)
            {
                case "Pedidos":
                case "PedidosPendentes":
                case "PedidosConcluidos":
                    //Carrega o grid
                    vol_FacadePedidos = new FBL_Pedidos();
                    vol_FacadePedidos.CarregarGridPedidos(dgvPedidos, vil_IdPedido);
                    dgvPedidos.Refresh();
                    //Recupera o numero do pedido 
                    if (dgvPedidos.RowCount != 0)
                    {
                        if (vil_IdPedido == 0)
                            vil_IdPedido = Convert.ToInt32(dgvPedidos.Rows[0].Cells[0].Value);
                    }
                    //Monta lista
                    FP_ExibeListaItensPedido(vcp_SubModulo);
                    break;
                case "Produtos":
                case "ProdutosAtivos":
                case "ProdutosDescontinuados":
                    //Carrega o grid
                    vol_FacadeProdutos = new FBL_Produtos();
                    vol_FacadeProdutos.CarregarGridProdutos(dgvProdutos, vil_IdProduto);
                    dgvProdutos.Refresh();
                    break;
                case "Clientes":
                case "ClientesAtivos":
                case "ClientesDescontinuados":
                    //Carrega o grid
                    vol_FacadeClientes = new FBL_Clientes();
                    vol_FacadeClientes.CarregarGridClientes(dgvClientes, vil_IdCliente);
                    dgvClientes.Refresh();
                    break;
                default:
                    break;
            }

        }

        private void FP_ExibeListaItensPedido(String pSubModulo)
        {
            switch (pSubModulo)
            {
                case "ItemPedido":
                    //Limpar listas da reuniao
                    vol_FacadePedidos.ColorListView(lvwItensPedido, false);
                    lvwItensPedido.Items.Clear();
                    //Valida gridConselheiros
                    if (dgvPedidos.RowCount == 0)
                    {
                        break;
                    }
                    //Exibe dados dos itens do pedido
                    vol_FacadeItensPedido = new FBL_ItensPedido();
                    vol_FacadeItensPedido.ListarItensPedido(lvwItensPedido, vil_IdPedido);
                    break;
                default:
                    break;
            }
        }
        #endregion

    }
}
