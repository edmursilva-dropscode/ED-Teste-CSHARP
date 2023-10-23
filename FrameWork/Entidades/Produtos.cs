using System;

namespace FrameWork.Entidades
{
    public class Produtos
    {
        #region Atributos
        private Int32 vil_IdProduto = 0;                    //
        private String vcl_Descricao = String.Empty;        //
        #endregion

        #region Propriedades
        public Int32 IdProduto
        {
            get { return vil_IdProduto; }
            set { vil_IdProduto = value; }
        }

        public String Descricao
        {
            get { return vcl_Descricao; }
            set { vcl_Descricao = value; }
        }
        #endregion
    }
}