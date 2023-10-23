using System;
using System.Collections.Generic;
using FrameWork.Entidades;
using FrameWork.Dados;


namespace FrameWork.Negocios
{
    public class BLL_Usuario : BLL_Functions
    {
        #region Variáveis
        //Objetos de classe
        DAL_Usuario vol_DadosUsuario = null;                    //Objeto da classe DAL_Usuario
        //Nova lista
        List<Usuario> vol_ListUsuario = new List<Usuario>();    //Lista da classe
        #endregion

        #region Métodos Públicos
        public Usuario SelecionarUsuarioSistemas(Int32 pIdUsuario)
        {
            //Inicialização da classe de DAL_Usuario
            vol_DadosUsuario = new DAL_Usuario();
            //Objeto da classe Usuario
            Usuario vol_Usuario = null;

            try
            {
                //Carrega lista usuario
                vol_ListUsuario = vol_DadosUsuario.SelecionarUsuarioSistemas(pIdUsuario);
                foreach (Usuario vol_Item in vol_ListUsuario)
                {
                    vol_Usuario = new Usuario
                    {
                        IdUsuario = vol_Item.IdUsuario,
                        Nome = vol_Item.Nome,
                        Senha = vol_Item.Senha,
                        Ativo = vol_Item.Ativo,
                        DtCadastro = vol_Item.DtCadastro,
                        TipoPerfil = vol_Item.TipoPerfil
                    };
                }
                return vol_Usuario;
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
