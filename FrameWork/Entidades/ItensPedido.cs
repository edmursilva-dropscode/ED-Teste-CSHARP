using System;

namespace FrameWork.Entidades
{
    public class ItensPedido
    {
        #region Atributos
        private Int32 vil_IdItensPedido = 0;              //
        private Int32 vil_IdPedido = 0;                   //
        private Int32 vil_IdProduto = 0;                  //
        private String vsl_Descricao = String.Empty;      //
        private Double vdl_Qtde = 0;                      //
        private Double vdl_ValorUnitario = 0;             //

        #endregion

        #region Propriedades
        public Int32 IdItensPedido
        {
            get { return vil_IdItensPedido; }
            set { vil_IdItensPedido = value; }
        }

        public Int32 IdPedido
        {
            get { return vil_IdPedido; }
            set { vil_IdPedido = value; }
        }

        public Int32 IdProduto
        {
            get { return vil_IdProduto; }
            set { vil_IdProduto = value; }
        }

        public String Descricao
        {
            get { return vsl_Descricao; }
            set { vsl_Descricao = value; }
        }

        public Double Qtde
        {
            get { return vdl_Qtde; }
            set { vdl_Qtde = value; }
        }

        public Double ValorUnitario
        {
            get { return vdl_ValorUnitario; }
            set { vdl_ValorUnitario = value; }
        }
        #endregion
    }
}
