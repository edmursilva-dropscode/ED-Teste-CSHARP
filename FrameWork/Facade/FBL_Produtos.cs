using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrameWork.Negocios;
using FrameWork.Entidades;

namespace FrameWork.Facade
{
    public class FBL_Produtos : FBL_Functions
    {
        #region Variaveis
        //Objeto da classe
        BLL_Produtos vol_NegociosProdutos = null;               //Objeto de acesso da classe BLL_Produtos
        #endregion

        #region Métodos Públicos
        //Carrega o grid
        public void CarregarGridProdutos(DataGridView pGrid, Int32 pIdProduto)
        {
            //Inicialização da classe de BLL_Produtos
            vol_NegociosProdutos = new BLL_Produtos();
            //Executa o método para carregar o grid
            vol_NegociosProdutos.CarregarGridProdutos(pGrid, pIdProduto);
        }

        //Selecionar
        public Produtos SelecionarProdutos(Int32 pIdProduto)
        {
            //Objeto da classe Produtos
            Produtos vol_Produtos = new Produtos();
            //Inicialização da classe de BLL_Produtos
            vol_NegociosProdutos = new BLL_Produtos();
            //Executao método para selecionar a Produtos
            vol_Produtos = vol_NegociosProdutos.SelecionarProdutos(pIdProduto);
            //Retorna os parâmetros
            return vol_Produtos;
        }

        //Editar
        public Produtos Editar(Int32 pIdProdutopIdProduto)
        {
            //Inicialização da classe de BLL_Produtos
            vol_NegociosProdutos = new BLL_Produtos();
            //Executa o método para alteração
            return vol_NegociosProdutos.Editar(pIdProdutopIdProduto);
        }

        //Gravar
        public bool Gravar(Int32 pIdProduto, string pDescricao)
        {
            //Inicialização da classe de BLL_Produtos
            vol_NegociosProdutos = new BLL_Produtos();
            //Executa método para gravar
            return vol_NegociosProdutos.Gravar(pIdProduto, pDescricao);
        }

        //Alterar 
        public bool Alterar(Int32 pIdProduto, string pDescricao)
        {
            //Inicialização da classe de BLL_Produtos
            vol_NegociosProdutos = new BLL_Produtos();
            //Executa método para alterar
            return vol_NegociosProdutos.Alterar(pIdProduto, pDescricao);
        }

        //Excluir
        public bool Excluir(Int32 pIdProduto, string pDescricao)
        {
            //Inicialização da classe de BLL_Produtos
            vol_NegociosProdutos = new BLL_Produtos();
            //Exxecuta método para excluir
            return vol_NegociosProdutos.Excluir(pIdProduto);
        }

        //Método para gerar o próximo ID
        public Int32 NextId()
        {
            //Inicialização da classe de BLL_Produtos
            vol_NegociosProdutos = new BLL_Produtos();
            return vol_NegociosProdutos.NextId();
        }
        #endregion


    }
}
