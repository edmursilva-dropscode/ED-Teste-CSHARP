using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrameWork.Dados;
using FrameWork.Entidades;

namespace FrameWork.Negocios
{
    public class BLL_ItensPedido : BLL_Functions
    {
        #region Variáveis
        //Objetos de classe
        DAL_ItensPedido vol_DadosItensPedido = null;              //Objeto da classe DAL_ItensPedido
        #endregion

        #region Metodos Públicos
        //Selecionar
        public ItensPedido SelecionarItensPedido(Int32 pIdPedido)
        {
            //Inicialização da classe de DAL_ItensPedidos
            vol_DadosItensPedido = new DAL_ItensPedido();
            //Objeto da classe Pedidos
            ItensPedido vol_ItensPedido = null;

            try
            {
                //Carrega lista Pedidos
                List<ItensPedido> vol_ListaItensPedido = vol_DadosItensPedido.SelecionarItensPedido(pIdPedido);
                foreach (ItensPedido vol_Item in vol_ListaItensPedido)
                {
                    vol_ItensPedido = new ItensPedido
                    {
                        IdPedido = vol_Item.IdPedido,
                        IdItensPedido = vol_Item.IdItensPedido,
                        IdProduto = vol_Item.IdProduto,
                        Qtde = vol_Item.Qtde,
                        ValorUnitario = vol_Item.ValorUnitario
                    };
                    break;
                }
                return vol_ItensPedido;
            }
            catch
            {
                return null;
            }
        }

        //Listar
        public void ListarItensPedido(ListView pLista, Int32 pIdPedido)
        {
            //Inicialização da classe de DAL_ItensPedido
            vol_DadosItensPedido = new DAL_ItensPedido();
            //Contador
            int vil_Count = 0;
            try
            {
                List<ItensPedido> vol_ListaItensPedido = vol_DadosItensPedido.SelecionarItensPedido(pIdPedido);
                //Percorre a lista
                foreach (ItensPedido vol_Item in vol_ListaItensPedido)
                {
                    ListViewItem vol_ListViewItem = new ListViewItem("");
                    vol_ListViewItem.SubItems.Add(Convert.ToString(vol_Item.IdProduto).PadLeft(3, '0'));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(vol_Item.Descricao));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(String.Format("{0:N2}", vol_Item.Qtde)));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(String.Format("{0:N2}", vol_Item.ValorUnitario)));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(String.Format("{0:N2}", vol_Item.Qtde * vol_Item.ValorUnitario)));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(vol_Item.IdProduto));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(vol_Item.IdItensPedido));
                    vol_ListViewItem.SubItems.Add(Convert.ToString(vol_Item.IdPedido));
                    pLista.Items.Add(vol_ListViewItem);
                    vil_Count++;
                    AplicarCorLista(vol_ListViewItem, vil_Count);
                }
            }
            catch
            {
                return;
            }
        }

        //Médodo Editar 
        public ItensPedido Editar(Int32 pIdPedido)
        {
            //Variável de acesso a classe
            vol_DadosItensPedido = new DAL_ItensPedido();
            //Variável de acesso a classe ItensPedido
            ItensPedido vol_ItensPedido = null;
            //Seleciona o Produto
            List<ItensPedido> vol_ListaItensPedido = vol_DadosItensPedido.SelecionarItensPedido(pIdPedido);
            //Percorre lista
            foreach (ItensPedido vol_Item in vol_ListaItensPedido)
            {
                vol_ItensPedido = new ItensPedido
                {
                    IdPedido = vol_Item.IdPedido,
                    IdItensPedido = vol_Item.IdItensPedido,
                    IdProduto = vol_Item.IdProduto,
                    Qtde = vol_Item.Qtde,
                    ValorUnitario = vol_Item.ValorUnitario
                };
                break;
            }
            //Retorna o item pesquisado
            return vol_ItensPedido;
        }

        //Gravar 
        public bool Gravar(Int32 pIdItensPedido, Int32 pIdPedido, Int32 pIdProduto, string pQtde, string pValorUnitario)
        {
            //Inicialização da classe de DAL_ItensPedidos
            vol_DadosItensPedido = new DAL_ItensPedido();
            //Executa método para gravar
            return vol_DadosItensPedido.Gravar(pIdItensPedido, pIdPedido, pIdProduto, pQtde, pValorUnitario);
        }

        //Alterar 
        public bool Alterar(Int32 pIdItensPedido, Int32 pIdPedido, Int32 pIdProduto, string pQtde, string pValorUnitario)
        {
            //Inicialização da classe de DAL_ItensPedidos
            vol_DadosItensPedido = new DAL_ItensPedido();
            //Executa método para alterar
            return vol_DadosItensPedido.Alterar(pIdItensPedido, pIdPedido, pIdProduto, pQtde, pValorUnitario);
        }

        //Excluir
        public bool Excluir(Int32 pIdItensPedido, Int32 pIdPedido)
        {
            //Inicialização da classe de DAL_ItensPedidos
            vol_DadosItensPedido = new DAL_ItensPedido();
            //Verifica se possui registros
            if (vol_DadosItensPedido.SelecionarItensPedido(pIdPedido).Count != 0)
            {
                //Executa método para excluir
                return vol_DadosItensPedido.Excluir(pIdItensPedido, pIdPedido);
            }
            else
            {
                return false;
            }
        }

        //Método para gerar o próximo ID
        public Int32 NextId()
        {
            //Inicialização da classe de DAL_ItensPedidos
            vol_DadosItensPedido = new DAL_ItensPedido();
            return vol_DadosItensPedido.NextId();
        }
        #endregion
    }
}

