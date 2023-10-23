using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrameWork.Negocios;
using FrameWork.Entidades;

namespace FrameWork.Facade
{
    public class FBL_Clientes : FBL_Functions
    {
        #region Variaveis
        //Objeto da classe
        BLL_Clientes vol_NegociosClientes = null;               //Objeto de acesso da classe BLL_Clientes
        #endregion

        #region Métodos Públicos
        //Carrega o grid
        public void CarregarGridClientes(DataGridView pGrid, Int32 pIdCliente)
        {
            //Inicialização da classe de BLL_Clientes
            vol_NegociosClientes = new BLL_Clientes();
            //Executa o método para carregar o grid
            vol_NegociosClientes.CarregarGridClientes(pGrid, pIdCliente);
        }

        //Selecionar
        public Clientes SelecionarClientes(Int32 pIdCliente)
        {
            //Objeto da classe Clientes
            Clientes vol_Clientes = new Clientes();
            //Inicialização da classe de BLL_Clientes
            vol_NegociosClientes = new BLL_Clientes();
            //Executao método para selecionar a Clientes
            vol_Clientes = vol_NegociosClientes.SelecionarClientes(pIdCliente);
            //Retorna os parâmetros
            return vol_Clientes;
        }

        //Editar
        public Clientes Editar(Int32 pIdCliente)
        {
            //Inicialização da classe de BLL_Clientes
            vol_NegociosClientes = new BLL_Clientes();
            //Executa o método para alteração
            return vol_NegociosClientes.Editar(pIdCliente);
        }

        //Gravar
        public bool Gravar(Int32 pIdCliente, string pDescricao)
        {
            //Inicialização da classe de BLL_Clientes
            vol_NegociosClientes = new BLL_Clientes();
            //Executa método para gravar
            return vol_NegociosClientes.Gravar(pIdCliente, pDescricao);
        }

        //Alterar 
        public bool Alterar(Int32 pIdCliente, string pDescricao)
        {
            //Inicialização da classe de BLL_Clientes
            vol_NegociosClientes = new BLL_Clientes();
            //Executa método para alterar
            return vol_NegociosClientes.Alterar(pIdCliente, pDescricao);
        }

        //Excluir
        public bool Excluir(Int32 pIdCliente)
        {
            //Inicialização da classe de BLL_Clientes
            vol_NegociosClientes = new BLL_Clientes();
            //Exxecuta método para excluir
            return vol_NegociosClientes.Excluir(pIdCliente);
        }

        //Método para gerar o próximo ID
        public Int32 NextId()
        {
            //Inicialização da classe de BLL_Clientes
            vol_NegociosClientes = new BLL_Clientes();
            return vol_NegociosClientes.NextId();
        }
        #endregion


    }
}

