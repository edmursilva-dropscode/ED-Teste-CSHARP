using System;

namespace FrameWork.Entidades
{
    public class Pedidos
    {
        #region Atributos
        private Int32 vil_IdPedido = 0;                   //
        private String vcl_DtVenda = String.Empty;        //
        private Int32 vil_IdCliente = 0;                  //
        private String vsl_Cliente = String.Empty;        //
        #endregion

        #region Propriedades
        public Int32 IdPedido
        {
            get { return vil_IdPedido; }
            set { vil_IdPedido = value; }
        }

        public String DtVenda
        {
            get { return vcl_DtVenda; }
            set { vcl_DtVenda = value; }
        }

        public Int32 IdCliente
        {
            get { return vil_IdCliente; }
            set { vil_IdCliente = value; }
        }

        public String Cliente
        {
            get { return vsl_Cliente; }
            set { vsl_Cliente = value; }
        }
        #endregion
    }
}
