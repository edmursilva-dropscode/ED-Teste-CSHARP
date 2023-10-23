using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FrameWork.Entidades;

namespace FrameWork.Dados
{
    public class DAL_Usuario : DAL_Data
    {
        //Seleciona usuario/sistema
        public List<Usuario> SelecionarUsuarioSistemas(Int32 pIdUsuario)
        {
            _= GetVol_Usuario();
            List<Usuario> vol_ListUsuario = new List<Usuario>();
            try
            {
                //Limpa os parâmetros
                Command.Parameters.Clear();
                SqlCommand.Append("SP_LOJA_S_USUARIOS");
                Command.Parameters.AddWithValue("@PIDUSUARIO", pIdUsuario);
                using (SqlDataReader vol_DataReader = GetDataReaderProc())
                {
                    while (vol_DataReader.Read())
                    {
                        Usuario vol_Usuario = new Usuario
                        {
                            IdUsuario = Convert.ToInt32(vol_DataReader["IDUSUARIO"]),
                            Nome = Convert.ToString(vol_DataReader["NOME"]),
                            Senha = Convert.ToString(vol_DataReader["SENHA"]),
                            Ativo = Convert.ToInt32(vol_DataReader["ATIVO"]),
                            DtCadastro = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(vol_DataReader["DTCADASTRO"])),
                            TipoPerfil = Convert.ToInt32(vol_DataReader["TIPO_PERFIL"])
                        };
                        //Adiciona item a lista
                        vol_ListUsuario.Add(vol_Usuario);
                    }
                    return vol_ListUsuario;
                }
            }
            catch
            {
                return null;
            }
        }

        private static Usuario GetVol_Usuario()
        {
            return null;
        }
    }
}
