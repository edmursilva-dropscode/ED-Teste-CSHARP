using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrameWork.Negocios;
using FrameWork.Entidades;

namespace FrameWork.Facade
{
    public class FBL_Pesquisar : FBL_Functions
    {
        #region Variáveis
        //Objetos de classe
        BLL_Produtos vol_NegociosProdutos = null;       //Objeto da classe BLL_Produtos
        BLL_Clientes vol_NegociosClientes = null;       //Objeto da classe BLL_Clientes
        #endregion

        #region Métodos Públicos
        public void ListarProdutos(ListView pLista)
        {
            vol_NegociosProdutos = new BLL_Produtos();
            vol_NegociosProdutos.ListarProdutos(pLista);
        }

        public void ListarClientes(ListView pLista)
        {
            vol_NegociosClientes = new BLL_Clientes();
            vol_NegociosClientes.ListarClientes(pLista);
        }
        #endregion

    }
}
