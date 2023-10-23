using System;

namespace FrameWork.Entidades
{
    public class Clientes
    {
        #region Atributos
        private Int32 vil_IdCliente = 0;                    //
        private String vcl_Descricao = String.Empty;        //
        #endregion

        #region Propriedades
        public Int32 IdCliente
        {
            get { return vil_IdCliente; }
            set { vil_IdCliente = value; }
        }

        public String Descricao
        {
            get { return vcl_Descricao; }
            set { vcl_Descricao = value; }
        }
        #endregion
    }
}