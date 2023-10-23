using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FrameWork.Entidades;

namespace FrameWork.Dados
{
    public class DAL_ItensPedido : DAL_Data
    {
        //Seleciona ItensPedido
        public List<ItensPedido> SelecionarItensPedido(int pIdPedido)
        {
            List<ItensPedido> vol_ListaItensPedido = new List<ItensPedido>();
            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_S_ITENS_PEDIDO");
                Command.Parameters.AddWithValue("@PIDPEDIDO", pIdPedido);
                using (SqlDataReader vol_DataReader = GetDataReaderProc())
                {
                    while (vol_DataReader.Read())
                    {
                        ItensPedido vol_ItensPedido = new ItensPedido
                        {
                            IdItensPedido = Convert.ToInt32(vol_DataReader["IDITENS_PEDIDO"]),
                            IdPedido = Convert.ToInt32(vol_DataReader["IDPEDIDO"]),
                            IdProduto = Convert.ToInt32(vol_DataReader["IDPRODUTO"]),
                            Descricao = Convert.ToString(vol_DataReader["PRODUTO"]),
                            Qtde = Convert.ToDouble(vol_DataReader["QTDE"]),
                            ValorUnitario = Convert.ToDouble(vol_DataReader["VALOR_UNITARIO"])
                        };
                        //Adiciona item a lista
                        vol_ListaItensPedido.Add(vol_ItensPedido);
                    }
                    return vol_ListaItensPedido;
                }
            }
            catch
            {
                return null;
            }
        }

        //Gravar 
        public bool Gravar(Int32 pIdItensPedido, Int32 pIdPedido, Int32 pIdProduto, string pQtde, string pValorUnitario)
        {
            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_I_ITENS_PEDIDO");
                Command.Parameters.AddWithValue("@PIDITENS_PEDIDO", pIdItensPedido);
                Command.Parameters.AddWithValue("@PIDPEDIDO", pIdPedido);
                Command.Parameters.AddWithValue("@PIDPRODUTO", pIdProduto);
                Command.Parameters.AddWithValue("@PQTDE", pQtde.Replace(",","."));
                Command.Parameters.AddWithValue("@PVALOR_UNITARIO", pValorUnitario.Replace(",","."));
                return ExecuteProc();
            }
            catch
            {
                return false;
            }
        }

        //Altera 
        public bool Alterar(Int32 pIdItensPedido, Int32 pIdPedido, Int32 pIdProduto, string pQtde, string pValorUnitario)
        {
            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_U_ITENS_PEDIDO");
                Command.Parameters.AddWithValue("@PIDITENS_PEDIDO", pIdItensPedido);
                Command.Parameters.AddWithValue("@PIDPEDIDO", pIdPedido);
                Command.Parameters.AddWithValue("@PIDPRODUTO", pIdProduto);
                Command.Parameters.AddWithValue("@PQTDE", pQtde);
                Command.Parameters.AddWithValue("@PVALOR_UNITARIO", pValorUnitario);
                return ExecuteProc();
            }
            catch
            {
                return false;
            }
        }

        //Excluir
        public bool Excluir(Int32 pIdItensPedido, Int32 pIdPedido)
        {
            try
            {
                //Exclui os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_D_ITENS_PEDIDO");                                    
                Command.Parameters.AddWithValue("@PIDITENSPEDIDO", pIdItensPedido);
                Command.Parameters.AddWithValue("@PIDPEDIDO", pIdPedido);
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
                SqlCommand.Append("SP_LOJA_N_ITENS_PEDIDO");
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



