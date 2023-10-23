using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrameWork.Negocios;
using FrameWork.Entidades;


namespace FrameWork.Facade
{
    public class FBL_Usuario : FBL_Functions
    {
        #region Variaveis
        //Objeto da classe
        BLL_Usuario vol_NegociosUsuario = null;                     //Objeto de acesso da classe BLL_Usuario
        #endregion

        #region Métodos Públicos
        //Selecionar Usuario/Sistema
        public Usuario SelecionarUsuarioSistemas(Int32 pIdUsuario)
        {
            //Objeto da classe Usuario
            _ = new Usuario();
            //Inicialização da classe de BLL_Usuario
            vol_NegociosUsuario = new BLL_Usuario();
            //Executao método para selecionar o Usuario
            Usuario vol_Usuario = vol_NegociosUsuario.SelecionarUsuarioSistemas(pIdUsuario);
            //Retorna os parâmetros do Usuario
            return vol_Usuario;
        }
        #endregion
    }
}
