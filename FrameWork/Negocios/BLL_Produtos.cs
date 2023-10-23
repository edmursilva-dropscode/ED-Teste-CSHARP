using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrameWork.Dados;
using FrameWork.Entidades;

namespace FrameWork.Negocios
{
    public class BLL_Produtos : BLL_Functions
    {
        #region Variáveis
        //Objetos de classe
        DAL_Produtos vol_DadosProdutos = null;              //Objeto da classe DAL_Produtos
        #endregion

        #region Metodos Públicos
        //Carregar grid
        public void CarregarGridProdutos(DataGridView pGrid, Int32 pIdProduto)
        {
            //Inicialização da classe de DAL_Produtos
            vol_DadosProdutos = new DAL_Produtos();

            try
            {
                //Limpar grid
                pGrid.Columns.Clear();
                pGrid.DataSource = null;
                //Carrega os registros do grid
                pGrid.DataSource = vol_DadosProdutos.SelecionarProdutos(pIdProduto);
                //Define estrutura do grid
                pGrid.Columns[0].HeaderText = "Código";
                pGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                pGrid.Columns[0].ReadOnly = true;
                pGrid.Columns[0].Width = 100;
                pGrid.Columns[0].DefaultCellStyle.Format = "000";
                pGrid.Columns[1].HeaderText = "Descrição";
                pGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pGrid.Columns[1].ReadOnly = true;
                pGrid.Columns[1].Width = 700;
                //Redimensionar as colunas de DataGridView para caber o conteúdo recém-carregado.
                //pGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                pGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                pGrid.AllowUserToResizeColumns = false;
                pGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                pGrid.AllowUserToResizeRows = false;
                pGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                //Atualiliza o grid
                pGrid.Refresh();
                
            }
            catch
            {
                return;
            }
        }

        //Selecionar
        public Produtos SelecionarProdutos(Int32 pIdProduto)
        {
            //Inicialização da classe de DAL_Produtos
            vol_DadosProdutos = new DAL_Produtos();
            //Objeto da classe Produtos
            Produtos vol_Produtos = null;

            try
            {
                //Carrega lista Produtos
                List<Produtos> vol_ListaProdutos = vol_DadosProdutos.SelecionarProdutos(pIdProduto);
                foreach (Produtos vol_Item in vol_ListaProdutos)
                {
                    vol_Produtos = new Produtos
                    {
                        IdProduto = vol_Item.IdProduto,
                        Descricao = vol_Item.Descricao
                    };
                    break;
                }
                return vol_Produtos;
            }
            catch
            {
                return null;
            }
        }

        //Médodo Editar 
        public Produtos Editar(Int32 pIdProduto)
        {
            //Variável de acesso a classe
            vol_DadosProdutos = new DAL_Produtos();
            //Variável de acesso a classe Produtos
            Produtos vol_Produtos = null;
            //Seleciona o Produto
            List<Produtos> vol_ListaProdutos = vol_DadosProdutos.SelecionarProdutos(pIdProduto);
            //Percorre lista
            foreach (Produtos vol_Item in vol_ListaProdutos)
            {
                vol_Produtos = new Produtos
                {
                    IdProduto = vol_Item.IdProduto,
                    Descricao = vol_Item.Descricao
                };
                break;
            }
            //Retorna o item pesquisado
            return vol_Produtos;
        }

        //Gravar 
        public bool Gravar(Int32 pIdProduto, string pDescricao)
        {
            //Inicialização da classe de DAL_Produtos
            vol_DadosProdutos = new DAL_Produtos();
            //Executa método para gravar
            return vol_DadosProdutos.Gravar(pIdProduto, pDescricao);
        }

        //Alterar 
        public bool Alterar(Int32 pIdProduto, string pDescricao)
        {
            //Inicialização da classe de DAL_Produtos
            vol_DadosProdutos = new DAL_Produtos();
            //Executa método para alterar
            return vol_DadosProdutos.Alterar(pIdProduto, pDescricao);
        }

        //Excluir
        public bool Excluir(Int32 pIdProduto)
        {
            //Inicialização da classe de DAL_Produtos
            vol_DadosProdutos = new DAL_Produtos();
            //Verifica se possui registros
            if (vol_DadosProdutos.SelecionarProdutos(pIdProduto).Count != 0)
            {
                //Executa método para excluir
                return vol_DadosProdutos.Excluir(pIdProduto);
            }
            else
            {
                return false;
            }
        }

        //Método para gerar o próximo ID
        public Int32 NextId()
        {
            //Inicialização da classe de DAL_Produtos
            vol_DadosProdutos = new DAL_Produtos();
            return vol_DadosProdutos.NextId();
        }        

        //Carrega lista de produtos
        public void ListarProdutos(ListView pLista)
        {
            pLista.Items.Clear();
            //Inicialização da classe de DAL_Produtos
            vol_DadosProdutos = new DAL_Produtos();
            //Contador
            int vil_Count = 0;
            try
            {
                List<Produtos> vol_ListarProdutos = vol_DadosProdutos.SelecionarProdutos(0);

                foreach (Produtos vol_Item in vol_ListarProdutos)
                {
                    ListViewItem vol_ListViewItem = new ListViewItem(Convert.ToString(vol_Item.IdProduto).PadLeft(3, '0'));
                    vol_ListViewItem.SubItems.Add(vol_Item.Descricao);
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
        #endregion
    }
}
