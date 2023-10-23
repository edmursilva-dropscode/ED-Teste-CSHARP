using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FrameWork.Entidades;

namespace FrameWork.Dados
{
    public class DAL_Produtos : DAL_Data
    {
        //Seleciona Produtos
        public List<Produtos> SelecionarProdutos(Int32 pIdProduto)
        {
            List<Produtos> vol_ListaProdutos = new List<Produtos>();
            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_S_PRODUTOS");
                Command.Parameters.AddWithValue("@PIDPRODUTO", pIdProduto);
                using (SqlDataReader vol_DataReader = GetDataReaderProc())
                {
                    while (vol_DataReader.Read())
                    {
                        Produtos vol_Produtos = new Produtos
                        {
                            IdProduto = Convert.ToInt32(vol_DataReader["IDPRODUTO"]),
                            Descricao = Convert.ToString(vol_DataReader["DESCRICAO"])
                        };
                        //Adiciona item a lista
                        vol_ListaProdutos.Add(vol_Produtos);
                    }
                    return vol_ListaProdutos;
                }
            }
            catch
            {
                return null;
            }
        }

        //Gravar 
        public bool Gravar(Int32 pIdProduto, string pDescricao)
        {
            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_I_PRODUTOS");
                Command.Parameters.AddWithValue("@PIDPRODUTO", pIdProduto);
                Command.Parameters.AddWithValue("@PDESCRICAO", pDescricao);
                return ExecuteProc();
            }
            catch
            {
                return false;
            }
        }

        //Altera 
        public bool Alterar(Int32 pIdProduto, string pDescricao)
        {
            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_U_PRODUTOS");
                Command.Parameters.AddWithValue("@PIDPRODUTO", pIdProduto);
                Command.Parameters.AddWithValue("@PDESCRICAO", pDescricao);
                return ExecuteProc();
            }
            catch
            {
                return false;
            }
        }

        //Excluir
        public bool Excluir(Int32 pIdProduto)
        {
            try
            {
                //Exclui os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_D_PRODUTOS");
                Command.Parameters.AddWithValue("@PIDPRODUTO", pIdProduto);
                return ExecuteProc();
            }
            catch
            {
                return false;
            }
        }

        public Int32 NextId()
        {
            //Variavel de controle
            Int32 vil_NextId = 1;

            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_N_PRODUTOS");
                using (SqlDataReader vol_DataReader = GetDataReaderProc())
                {
                    while (vol_DataReader.Read())
                    {
                        vil_NextId = Convert.ToInt32(vol_DataReader[0]) + 1;
                    }

                }
                return vil_NextId;
            }
            catch
            {
                return vil_NextId;
            }
        }
    }
}
