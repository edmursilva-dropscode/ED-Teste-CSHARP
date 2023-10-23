using System;
using System.Windows.Forms;
using FrameWork.Negocios;
using FrameWork.Entidades;


namespace FrameWork.Facade
{
    public class FBL_Pedidos : FBL_Functions
    {
        #region Variaveis
        //Objeto da classe
        BLL_Pedidos vol_NegociosPedidos = null;               //Objeto de acesso da classe BLL_Pedidos
        #endregion

        #region Métodos Públicos
        //Carrega o grid
        public void CarregarGridPedidos(DataGridView pGrid, Int32 pIdPedido)
        {
            //Inicialização da classe de BLL_Pedidos
            vol_NegociosPedidos = new BLL_Pedidos();
            //Executa o método para carregar o grid
            vol_NegociosPedidos.CarregarGridPedidos(pGrid, pIdPedido);
        }

        //Selecionar
        public Pedidos SelecionarPedidos(Int32 pIdPedido)
        {
            //Objeto da classe Pedidos
            _ = new Pedidos();
            //Inicialização da classe de BLL_Pedidos
            vol_NegociosPedidos = new BLL_Pedidos();
            //Executao método para selecionar a Pedidos
            Pedidos vol_Pedidos = vol_NegociosPedidos.SelecionarPedidos(pIdPedido);
            //Retorna os parâmetros
            return vol_Pedidos;
        }

        //Editar
        public Pedidos Editar(Int32 pIdPedido)
        {
            //Inicialização da classe de BLL_Pedidos
            vol_NegociosPedidos = new BLL_Pedidos();
            //Executa o método para alteração
            return vol_NegociosPedidos.Editar(pIdPedido);
        }

        //Gravar
        public bool Gravar(Int32 pIdPedido, string pDtVenda, Int32 pIdCliente, ListView pItensPedido)
        {
            //Inicialização da classe de BLL_Pedidos
            vol_NegociosPedidos = new BLL_Pedidos();
            //Executa método para gravar
            return vol_NegociosPedidos.Gravar(pIdPedido, pDtVenda, pIdCliente, pItensPedido);
        }

        //Alterar 
        public bool Alterar(Int32 pIdPedido, string pDtVenda, Int32 pIdCliente, ListView pItensPedido)
        {
            //Inicialização da classe de BLL_Pedidos
            vol_NegociosPedidos = new BLL_Pedidos();
            //Executa método para alterar
            return vol_NegociosPedidos.Alterar(pIdPedido, pDtVenda, pIdCliente, pItensPedido);
        }

        //Excluir
        public bool Excluir(Int32 pIdPedido)
        {
            //Inicialização da classe de BLL_Pedidos
            vol_NegociosPedidos = new BLL_Pedidos();
            //Exxecuta método para excluir
            return vol_NegociosPedidos.Excluir(pIdPedido);
        }

        //Método para gerar o próximo ID
        public Int32 NextId()
        {
            //Inicialização da classe de BLL_Pedidos
            vol_NegociosPedidos = new BLL_Pedidos();
            return vol_NegociosPedidos.NextId();
        }
        #endregion


    }
}
