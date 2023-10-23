using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrameWork.Negocios;
using FrameWork.Entidades;

namespace FrameWork.Facade
{
    public class FBL_ItensPedido : FBL_Functions
    {
        #region Variaveis
        //Objeto da classe
        BLL_ItensPedido vol_NegociosItensPedido = null;               //Objeto de acesso da classe BLL_ItensPedido
        #endregion

        #region Métodos Públicos
        //Selecionar
        public ItensPedido SelecionarItensPedido(Int32 pIdPedido)
        {
            //Objeto da classe ItensPedido
            _ = new ItensPedido();
            //Inicialização da classe de BLL_ItensPedido
            vol_NegociosItensPedido = new BLL_ItensPedido();
            //Executao método para selecionar a Pedidos
            ItensPedido vol_ItensPedido = vol_NegociosItensPedido.SelecionarItensPedido( pIdPedido);
            //Retorna os parâmetros
            return vol_ItensPedido;
        }

        //Listar
        public void ListarItensPedido(ListView pLista, Int32 pIdPedido)
        {
            //Inicialização da classe de BLL_ItensPedido
            vol_NegociosItensPedido = new BLL_ItensPedido();
            //Executao método para selecionar a Pedidos
            vol_NegociosItensPedido.ListarItensPedido(pLista, pIdPedido);
        }

        //Editar
        public ItensPedido Editar(Int32 pIdPedido)
        {
            //Inicialização da classe de BLL_ItensPedido
            vol_NegociosItensPedido = new BLL_ItensPedido();
            //Executa o método para alteração
            return vol_NegociosItensPedido.Editar(pIdPedido);
        }

        //Gravar
        public bool Gravar(Int32 pIdItensPedido, Int32 pIdPedido, Int32 pIdProduto, string pQtde, string pValorUnitario)
        {
            //Inicialização da classe de BLL_ItensPedido
            vol_NegociosItensPedido = new BLL_ItensPedido();
            //Executa método para gravar
            return vol_NegociosItensPedido.Gravar(pIdItensPedido, pIdPedido, pIdProduto, pQtde, pValorUnitario);
        }

        //Alterar 
        public bool Alterar(Int32 pIdItensPedido, Int32 pIdPedido, Int32 pIdProduto, string pQtde, string pValorUnitario)
        {
            //Inicialização da classe de BLL_ItensPedido
            vol_NegociosItensPedido = new BLL_ItensPedido();
            //Executa método para alterar
            return vol_NegociosItensPedido.Alterar(pIdItensPedido, pIdPedido, pIdProduto, pQtde, pValorUnitario);
        }

        //Excluir
        public bool Excluir(Int32 pIdItensPedido, Int32 pIdPedido)
        {
            //Inicialização da classe de BLL_ItensPedido
            vol_NegociosItensPedido = new BLL_ItensPedido();
            //Exxecuta método para excluir
            return vol_NegociosItensPedido.Excluir(pIdItensPedido, pIdPedido);
        }

        //Método para gerar o próximo ID
        public Int32 NextId()
        {
            //Inicialização da classe de BLL_ItensPedido
            vol_NegociosItensPedido = new BLL_ItensPedido();
            return vol_NegociosItensPedido.NextId();
        }
        #endregion


    }
}

