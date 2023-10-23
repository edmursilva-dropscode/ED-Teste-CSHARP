using System;

namespace FrameWork.Entidades
{
    public class Usuario
    {
        #region Controles
        private Int32 vil_IdUsuario = 0;                            //Identificador do usuário
        private String vcl_Nome = String.Empty;                     //Nome do usuário
        private String vsl_Senha = String.Empty;                    //Senha do usuário
        private Int32 vil_Ativo = 0;                                //Flag ativo
        private String vsl_DtCadastro = String.Empty;               //Data de cadastro
        private Int32 vip_TipoPerfil = 0;                           //Tipo de acesso do usuário
        #endregion

        #region Propriedades
        public Int32 IdUsuario
        {
            get { return vil_IdUsuario; }
            set { vil_IdUsuario = value; }
        }

        public String Nome
        {
            get { return vcl_Nome; }
            set { vcl_Nome = value; }
        }

        public String Senha
        {
            get { return vsl_Senha; }
            set { vsl_Senha = value; }
        }

        public Int32 Ativo
        {
            get { return vil_Ativo; }
            set { vil_Ativo = value; }
        }

        public String DtCadastro
        {
            get { return vsl_DtCadastro; }
            set { vsl_DtCadastro = value; }
        }

        public Int32 TipoPerfil
        {
            get { return vip_TipoPerfil; }
            set { vip_TipoPerfil = value; }
        }
        #endregion
    }
}
