using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FrameWork.Entidades;

namespace FrameWork.Dados
{
    public class DAL_Pedidos : DAL_Data
    {
        //Seleciona Pedidos
        public List<Pedidos> SelecionarPedidos(Int32 pIdPedido)
        {
            List<Pedidos> vol_ListaPedidos = new List<Pedidos>();
            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_S_PEDIDOS");
                Command.Parameters.AddWithValue("@PIDPEDIDO", pIdPedido);
                using (SqlDataReader vol_DataReader = GetDataReaderProc())
                {
                    while (vol_DataReader.Read())
                    {
                        Pedidos vol_Pedidos = new Pedidos
                        {
                            IdPedido = Convert.ToInt32(vol_DataReader["IDPEDIDO"]),
                            DtVenda = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(vol_DataReader["DTVENDA"])),
                            IdCliente = Convert.ToInt32(vol_DataReader["IDCLIENTE"]),
                            Cliente = Convert.ToString(vol_DataReader["CLIENTE"])
                        };
                        //Adiciona item a lista
                        vol_ListaPedidos.Add(vol_Pedidos);
                    }
                    return vol_ListaPedidos;
                }
            }
            catch
            {
                return null;
            }
        }

        //Gravar 
        public bool Gravar(Int32 pIdPedido, string pDtVenda, Int32 pIdCliente)
        {
            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_I_PEDIDOS");
                Command.Parameters.AddWithValue("@PIDPEDIDO", pIdPedido);
                Command.Parameters.AddWithValue("@PDTVENDA", Convert.ToDateTime(pDtVenda));
                Command.Parameters.AddWithValue("@PIDCLIENTE", pIdCliente);
                return ExecuteProc();
            }
            catch
            {
                return false;
            }
        }

        //Altera 
        public bool Alterar(Int32 pIdPedido, string pDtVenda, Int32 pIdCliente)
        {
            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_U_PEDIDOS");
                Command.Parameters.AddWithValue("@PIDPEDIDO", pIdPedido);
                Command.Parameters.AddWithValue("@PDTVENDA", Convert.ToDateTime(pDtVenda));
                Command.Parameters.AddWithValue("@PIDCLIENTE", pIdCliente);
                return ExecuteProc();
            }
            catch
            {
                return false;
            }
        }

        //Excluir
        public bool Excluir(Int32 pIdPedido)
        {
            try
            {
                //Exclui os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_D_PEDIDOS");
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
                SqlCommand.Append("SP_LOJA_N_PEDIDOS");
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


