using System;

namespace FrameWork.Entidades
{
    public class Conselheiros
    {
        #region Atributos
        private Int32 vil_IdConselheiro = 0;                    //
        private Int32 vil_IdPessoa = 0;                         //
        private Int32 vil_IdPessoaTitular = 0;                  //
        private String vcl_Codigo = String.Empty;               //
        private String vcl_Nome = String.Empty;                 //
        private Int32 vil_Idade = 0;                            //
        private Int32 vil_IdTipoConselheiro = 0;                //
        private String vcl_TipoConselheiro = String.Empty;      //
        private Int32 vil_IdUsuario = 0;                        //
        private String vcl_DtMandatoInicio = String.Empty;      //        
        private String vcl_DtMandatoFim = String.Empty;         //
        private String vcl_MandatoPeriodo = String.Empty;       //
        private String vcl_DtEliminacao = String.Empty;         //
        private Int32 vil_NumeroVotos = 0;                      //
        private Int32 vil_Classificacao = 0;                    //
        private String vcl_Observacao = String.Empty;           //
        private Int32 vil_OrdemFila = 0;                        //
        private String vcl_Situacao = String.Empty;             //
        //
        private String vcl_Descricao = String.Empty;            //
        private Int32 vil_Ativo = 0;                            //
        private Int32 vil_EstatisticaReuniao = 0;               //
        private Int32 vil_EstatisticaFaltas = 0;                //
        private Int32 vil_EstatisticaJustificativas = 0;        //
        private Int32 vil_EstatisticaPresenca = 0;              //
        private Int32 vil_EstatisticaLicenciamento = 0;         //
        //
        private Int32 vil_TotalEliminacao = 0;                  //
        private Int32 vil_TotalSuplentes = 0;                   //
        private Int32 vil_TotalJustificativaPendentes = 0;      //
        //
        private Int32 vil_Presenca = 0;                         //
        private Int32 vil_Ausencia = 0;                         //
        private Int32 vil_Justificativa = 0;                    //
        private Int32 vil_IdReuniao = 0;                        //
        #endregion

        #region Propriedades
        public Int32 IdConselheiro
        {
            get { return vil_IdConselheiro; }
            set { vil_IdConselheiro = value; }
        }

        public Int32 IdPessoa 
        {
            get { return vil_IdPessoa; }
            set { vil_IdPessoa = value; }
        }

        public Int32 IdPessoaTitular
        {
            get { return vil_IdPessoaTitular; }
            set { vil_IdPessoaTitular = value; }
        }

        public String Codigo
        {
            get { return vcl_Codigo; }
            set { vcl_Codigo = value; }
        }

        public String Nome
        {
            get { return vcl_Nome; }
            set { vcl_Nome = value; }
        }

        public Int32 Idade
        {
            get { return vil_Idade; }
            set { vil_Idade = value; }
        }

        public Int32 IdTipoConselheiro
        {
            get { return vil_IdTipoConselheiro; }
            set { vil_IdTipoConselheiro = value; }
        }

        public String TipoConselheiro
        {
            get { return vcl_TipoConselheiro; }
            set { vcl_TipoConselheiro = value; }
        }

        public Int32 IdUsuario
        {
            get { return vil_IdUsuario; }
            set { vil_IdUsuario = value; }
        }

        public String DtMandatoInicio
        {
            get { return vcl_DtMandatoInicio; }
            set { vcl_DtMandatoInicio = value; }
        }

        public String DtMandatoFim
        {
            get { return vcl_DtMandatoFim; }
            set { vcl_DtMandatoFim = value; }
        }

        public String MandatoPeriodo
        {
            get { return vcl_MandatoPeriodo; }
            set { vcl_MandatoPeriodo = value; }
        }

        public String DtEliminacao
        {
            get { return vcl_DtEliminacao; }
            set { vcl_DtEliminacao = value; }
        }

        public Int32 NumeroVotos
        {
            get { return vil_NumeroVotos; }
            set { vil_NumeroVotos = value; }
        }

        public Int32 Classificacao
        {
            get { return vil_Classificacao; }
            set { vil_Classificacao = value; }
        }

        public String Observacao
        {
            get { return vcl_Observacao; }
            set { vcl_Observacao = value; }
        }

        public Int32 OrdemFila
        {
            get { return vil_OrdemFila; }
            set { vil_OrdemFila = value; }
        }

        public String Situacao
        {
            get { return vcl_Situacao; }
            set { vcl_Situacao = value; }
        }

        public String Descricao
        {
            get { return vcl_Descricao; }
            set { vcl_Descricao = value; }
        }

        public Int32 Ativo
        {
            get { return vil_Ativo; }
            set { vil_Ativo = value; }
        }

        public Int32 EstatisticaReuniao
        {
            get { return vil_EstatisticaReuniao; }
            set { vil_EstatisticaReuniao = value; }
        }

        public Int32 EstatisticaFaltas
        {
            get { return vil_EstatisticaFaltas; }
            set { vil_EstatisticaFaltas = value; }
        }

        public Int32 EstatisticaJustificativas
        {
            get { return vil_EstatisticaJustificativas; }
            set { vil_EstatisticaJustificativas = value; }
        }

        public Int32 EstatisticaPresenca
        {
            get { return vil_EstatisticaPresenca; }
            set { vil_EstatisticaPresenca = value; }
        }

        public Int32 EstatisticaLicenciamento
        {
            get { return vil_EstatisticaLicenciamento; }
            set { vil_EstatisticaLicenciamento = value; }
        }

        public Int32 TotalEliminacao
        {
            get { return vil_TotalEliminacao; }
            set { vil_TotalEliminacao = value; }
        }

        public Int32 TotalSuplentes
        {
            get { return vil_TotalSuplentes; }
            set { vil_TotalSuplentes = value; }
        }

        public Int32 TotalJustificativaPendentes
        {
            get { return vil_TotalJustificativaPendentes; }
            set { vil_TotalJustificativaPendentes = value; }
        }

        public Int32 Presenca
        {
            get { return vil_Presenca; }
            set { vil_Presenca = value; }
        }

        public Int32 Ausencia
        {
            get { return vil_Ausencia; }
            set { vil_Ausencia = value; }
        }

        public Int32 Justificativa
        {
            get { return vil_Justificativa; }
            set { vil_Justificativa = value; }
        }

        public Int32 IdReuniao
        {
            get { return vil_IdReuniao; }
            set { vil_IdReuniao = value; }
        }
        #endregion

    }
}
