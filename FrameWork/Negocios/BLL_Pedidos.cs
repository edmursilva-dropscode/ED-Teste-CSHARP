using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrameWork.Dados;
using FrameWork.Entidades;

namespace FrameWork.Negocios
{
    public class BLL_Pedidos : BLL_Functions
    {
        #region Variáveis
        //Objetos de classe
        DAL_Pedidos vol_DadosPedidos = null;              //Objeto da classe DAL_Pedidos
        DAL_ItensPedido vol_DadosItensPedido = null;      //Objeto da classe DAL_ItensPedido
        #endregion

        #region Metodos Públicos
        //Carregar grid
        public void CarregarGridPedidos(DataGridView pGrid, Int32 pIdPedido)
        {
            //Inicialização da classe de DAL_Pedidos
            vol_DadosPedidos = new DAL_Pedidos();

            try
            {
                //Limpar grid
                pGrid.Columns.Clear();
                pGrid.DataSource = null;
                //Carrega os registros do grid
                pGrid.DataSource = vol_DadosPedidos.SelecionarPedidos(pIdPedido);
                //Define estrutura do grid
                pGrid.Columns[0].HeaderText = "Código pedido";
                pGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                pGrid.Columns[0].ReadOnly = true;
                pGrid.Columns[0].Width = 150;
                pGrid.Columns[0].DefaultCellStyle.Format = "000000";
                pGrid.Columns[1].HeaderText = "Data venda";
                pGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[1].ReadOnly = true;
                pGrid.Columns[1].Width = 150;
                pGrid.Columns[2].HeaderText = "Códgo cliente";
                pGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                pGrid.Columns[2].ReadOnly = true;
                pGrid.Columns[2].Width = 150;
                pGrid.Columns[2].DefaultCellStyle.Format = "000";
                pGrid.Columns[3].HeaderText = "Cliente";
                pGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[3].ReadOnly = true;
                pGrid.Columns[3].Width = 300;
                //Redimensionar as colunas de DataGridView para caber o conteúdo recém-carregado.
                //pGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                pGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                pGrid.AllowUserToResizeColumns = false;
                pGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                pGrid.AllowUserToResizeRows = false;
                pGrid.RowHeadersWidthSizeMode =  DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                //Atualiliza o grid
                pGrid.Refresh();

            }
            catch
            {
                return;
            }
        }

        //Selecionar
        public Pedidos SelecionarPedidos(Int32 pIdPedido)
        {
            //Inicialização da classe de DAL_Pedidos
            vol_DadosPedidos = new DAL_Pedidos();
            //Objeto da classe Pedidos
            Pedidos vol_Pedidos = null;

            try
            {
                //Carrega lista Pedidos
                List<Pedidos> vol_ListaPedidos = vol_DadosPedidos.SelecionarPedidos(pIdPedido);
                foreach (Pedidos vol_Item in vol_ListaPedidos)
                {
                    Pedidos pedidos = new Pedidos
                    {
                        IdPedido = vol_Item.IdPedido,
                        DtVenda = vol_Item.DtVenda,
                        IdCliente = vol_Item.IdCliente
                    };
                    vol_Pedidos = pedidos;
                    break;
                }
                return vol_Pedidos;
            }
            catch
            {
                return null;
            }
        }

        //Médodo Editar 
        public Pedidos Editar(Int32 pIdPedido)
        {
            //Variável de acesso a classe
            vol_DadosPedidos = new DAL_Pedidos();
            //Variável de acesso a classe Pedidos
            Pedidos vol_Pedidos = null;
            //Seleciona o Produto
            List<Pedidos> vol_ListaPedidos = vol_DadosPedidos.SelecionarPedidos(pIdPedido);
            //Percorre lista
            foreach (Pedidos vol_Item in vol_ListaPedidos)
            {
                vol_Pedidos = new Pedidos
                {
                    IdPedido = vol_Item.IdPedido,
                    DtVenda = vol_Item.DtVenda,
                    IdCliente = vol_Item.IdCliente
                };
                break;
            }
            //Retorna o item pesquisado
            return vol_Pedidos;
        }

        //Gravar 
        public bool Gravar(Int32 pIdPedido, string pDtVenda, Int32 pIdCliente, ListView pItensPedido)
        {
            //Inicialização da classe de DAL_Pedidos
            vol_DadosPedidos = new DAL_Pedidos();
            //Executa método para gravar
            if(vol_DadosPedidos.Gravar(pIdPedido, pDtVenda, pIdCliente) == false)
            {
                return false;
            }

            //Executa método excluir itens
            //Inicialização da classe de DAL_ItensPedido
            vol_DadosItensPedido = new DAL_ItensPedido();
            //Executa método para gravar
            if (vol_DadosItensPedido.Excluir(0, pIdPedido) == false)
            {
                return false;
            }

            //Executa método gravar itens do pedido
            for (int vil_Count = 0; vil_Count <= pItensPedido.Items.Count - 1; vil_Count++)
            {
                //Inicialização da classe de DAL_ItensPedido
                vol_DadosItensPedido = new DAL_ItensPedido();
                //Executa método para gravar itens
                if (vol_DadosItensPedido.Gravar(Convert.ToInt32(pItensPedido.Items[vil_Count].SubItems[7].Text), Convert.ToInt32(pItensPedido.Items[vil_Count].SubItems[8].Text), Convert.ToInt32(pItensPedido.Items[vil_Count].SubItems[6].Text), Convert.ToString(pItensPedido.Items[vil_Count].SubItems[3].Text), Convert.ToString(pItensPedido.Items[vil_Count].SubItems[4].Text)) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //Alterar 
        public bool Alterar(Int32 pIdPedido, string pDtVenda, Int32 pIdCliente, ListView pItensPedido)
        {
            //Inicialização da classe de DAL_Pedidos
            vol_DadosPedidos = new DAL_Pedidos();
            //Executa método para alterar
            if (!vol_DadosPedidos.Alterar(pIdPedido, pDtVenda, pIdCliente))
            {
                //return false;
            }

            //Executa método excluir itens
            //Inicialização da classe de DAL_ItensPedido
            vol_DadosItensPedido = new DAL_ItensPedido();
            //Executa método para gravar
            if (vol_DadosItensPedido.Excluir(0, pIdPedido) == false)
            {
                //return false;
            }

            //Executa método gravar itens do pedido
            for (int vil_Count = 0; vil_Count <= pItensPedido.Items.Count - 1; vil_Count++)
            {
                //Inicialização da classe de DAL_ItensPedido
                vol_DadosItensPedido = new DAL_ItensPedido();
                //Executa método para gravar itens
                if (vol_DadosItensPedido.Gravar(Convert.ToInt32(pItensPedido.Items[vil_Count].SubItems[7].Text), Convert.ToInt32(pItensPedido.Items[vil_Count].SubItems[8].Text), Convert.ToInt32(pItensPedido.Items[vil_Count].SubItems[6].Text), Convert.ToString(pItensPedido.Items[vil_Count].SubItems[3].Text), Convert.ToString(pItensPedido.Items[vil_Count].SubItems[4].Text)) == false)
                {
                    //return false;
                }
            }
            return true;
        }

        //Excluir
        public bool Excluir(Int32 pIdPedido)
        {
            //Inicialização da classe de DAL_Pedidos
            vol_DadosPedidos = new DAL_Pedidos();
            //Verifica se possui registros
            if (vol_DadosPedidos.SelecionarPedidos(pIdPedido).Count != 0)
            {
                //Executa método para excluir
                return vol_DadosPedidos.Excluir(pIdPedido);
            }
            else
            {
                return false;
            }
        }

        //Método para gerar o próximo ID
        public Int32 NextId()
        {
            //Inicialização da classe de DAL_Pedidos
            vol_DadosPedidos = new DAL_Pedidos();
            return vol_DadosPedidos.NextId();
        }
        #endregion
    }
}
