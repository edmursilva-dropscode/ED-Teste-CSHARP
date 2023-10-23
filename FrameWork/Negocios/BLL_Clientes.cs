using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrameWork.Dados;
using FrameWork.Entidades;

namespace FrameWork.Negocios
{
    public class BLL_Clientes : BLL_Functions
    {
        #region Variáveis
        //Objetos de classe
        DAL_Clientes vol_DadosClientes = null;              //Objeto da classe DAL_Cientes
        #endregion

        #region Metodos Públicos
        //Carregar grid
        public void CarregarGridClientes(DataGridView pGrid, Int32 pIdCliente)
        {
            //Inicialização da classe de DAL_Clientes
            vol_DadosClientes = new DAL_Clientes();

            try
            {
                //Limpar grid
                pGrid.Columns.Clear();
                pGrid.DataSource = null;
                //Carrega os registros do grid
                pGrid.DataSource = vol_DadosClientes.SelecionarClientes(pIdCliente);
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
        public Clientes SelecionarClientes(Int32 pIdCliente)
        {
            //Inicialização da classe de DAL_Clientes
            vol_DadosClientes = new DAL_Clientes();
            //Objeto da classe Clientes
            Clientes vol_Clientes = null;

            try
            {
                //Carrega lista Clientes
                List<Clientes> vol_ListaClientes = vol_DadosClientes.SelecionarClientes(pIdCliente);
                foreach (Clientes vol_Item in vol_ListaClientes)
                {
                    vol_Clientes = new Clientes
                    {
                        IdCliente = vol_Item.IdCliente,
                        Descricao = vol_Item.Descricao
                    };
                    break;
                }
                return vol_Clientes;
            }
            catch
            {
                return null;
            }
        }

        //Médodo Editar 
        public Clientes Editar(Int32 pIdCliente)
        {
            //Variável de acesso a classe
            vol_DadosClientes = new DAL_Clientes();
            //Variável de acesso a classe Clientes
            Clientes vol_Clientes = null;
            //Seleciona o Produto
            List<Clientes> vol_ListaClientes = vol_DadosClientes.SelecionarClientes(pIdCliente);
            //Percorre lista
            foreach (Clientes vol_Item in vol_ListaClientes)
            {
                vol_Clientes = new Clientes
                {
                    IdCliente = vol_Item.IdCliente,
                    Descricao = vol_Item.Descricao
                };
                break;
            }
            //Retorna o item pesquisado
            return vol_Clientes;
        }

        //Gravar 
        public bool Gravar(Int32 pIdCliente, string pDescricao)
        {
            //Inicialização da classe de DAL_Clientes
            vol_DadosClientes = new DAL_Clientes();
            //Executa método para gravar
            return vol_DadosClientes.Gravar(pIdCliente, pDescricao);
        }

        //Alterar 
        public bool Alterar(Int32 pIdCliente, string pDescricao)
        {
            //Inicialização da classe de DAL_Clientes
            vol_DadosClientes = new DAL_Clientes();
            //Executa método para alterar
            return vol_DadosClientes.Alterar(pIdCliente, pDescricao);
        }

        //Excluir
        public bool Excluir(Int32 pIdCliente)
        {
            //Inicialização da classe de DAL_Clientes
            vol_DadosClientes = new DAL_Clientes();
            //Verifica se possui registros
            if (vol_DadosClientes.SelecionarClientes(pIdCliente).Count != 0)
            {
                //Executa método para excluir
                return vol_DadosClientes.Excluir(pIdCliente);
            }
            else
            {
                return false;
            }
        }

        //Método para gerar o próximo ID
        public Int32 NextId()
        {
            //Inicialização da classe de DAL_Clientes
            vol_DadosClientes = new DAL_Clientes();
            return vol_DadosClientes.NextId();
        }

        //Carrega lista de clienes
        public void ListarClientes(ListView pLista)
        {
            pLista.Items.Clear();
            //Inicialização da classe de DAL_Clientes
            vol_DadosClientes = new DAL_Clientes();
            //Contador
            int vil_Count = 0;
            try
            {
                List<Clientes> vol_ListarClientes = vol_DadosClientes.SelecionarClientes(0);

                foreach (Clientes vol_Item in vol_ListarClientes)
                {
                    ListViewItem vol_ListViewItem = new ListViewItem(Convert.ToString(vol_Item.IdCliente).PadLeft(3, '0'));
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
