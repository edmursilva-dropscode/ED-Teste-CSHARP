using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FrameWork.Dados
{
    public class DAL_Data
    {
        #region Variaveis
        //Variáveis públicas
        public String vsl_ServerName = "EDMURSILVA-PC";
        public String vsl_UserID = "root";
        public String vsl_Password = "EgsjR7268";
        public String vsl_IntSecurity= "True";
        public String vsl_Database = "TESTE_ESL_LOJA";
        //Variáveis dos objetos do ADO
        public SqlCommand vol_Command = new SqlCommand();           //Variável do objeto Command
        public SqlConnection vol_Conexao = new SqlConnection();     //Variável do objeto Connection
        #endregion

        #region  Contrutores
        //Construtor New
        public DAL_Data()
        {
            try
            {
                //Verifica se a conexão está fechada
                if (vol_Conexao.State == ConnectionState.Closed)
                {
                    //pNome de conexão com o banco de dados                                        
                    String vsl_Conexao = String.Format("Data Source={0}; Initial Catalog={1}; Integrated Security={2}", vsl_ServerName, vsl_Database, vsl_IntSecurity);                    
                    vol_Conexao = new SqlConnection(vsl_Conexao);
                    //Abre a conexão com o banco de dados
                    vol_Conexao.Open();
                }
            }
            catch (SqlException Error)
            {
                //Exclui o contéudo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                //Aviso
                MessageBox.Show("Erro: " + Error.Message, "TESTE_ESL_Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Propriedades
        //Variáveis das propriedades
        private StringBuilder vcl_SqlCommand = new StringBuilder(); //Recebe um comando SQL

        //Determina o camando SQL que será usado
        public StringBuilder SqlCommand
        {
            get { return vcl_SqlCommand; }
            set { vcl_SqlCommand = value; }
        }

        //Método get que será usado pelas demais classe para usar acesso a base de dados
        public SqlConnection Conexao
        {
            get { return vol_Conexao; }
        }

        //Método get que será usado pelas demais classe para usar acesso a base de dados
        public SqlCommand Command
        {
            get { return vol_Command; }
        }
        #endregion "Propriedades"

        #region Métodos Públicos
        //Método para execução de comandos
        public bool Execute()
        {
            try
            {
                //Associa a conexão ao Command
                vol_Command.Connection = Conexao;
                //Define a comando sql que será executado   
                vol_Command.CommandText = SqlCommand.ToString();
                //Define o tipo do comando
                vol_Command.CommandType = CommandType.Text;
                //Executa o comando
                vol_Command.ExecuteNonQuery();
                //Exclui o contéudo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro: " + Error.Message, "TESTE_ESL_Loja",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlCommand.Remove(0, SqlCommand.Length);
                return false;

            }
        }

        //Método para execução de procedures
        public bool ExecuteProc()
        {
            try
            {
                //Associa a conexão ao Command
                using (vol_Command.Connection = Conexao)
                {
                    //Define a comando sql que será executado   
                    vol_Command.CommandText = SqlCommand.ToString();
                    //Define o tipo do comando
                    vol_Command.CommandType = CommandType.StoredProcedure;
                    //Executa o comando
                    vol_Command.ExecuteNonQuery();
                    //Exclui o contéudo da StringBuilder
                    SqlCommand.Remove(0, SqlCommand.Length);
                    return true;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro: " + Error.Message, "TESTE_ESL_Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlCommand.Remove(0, SqlCommand.Length);
                return false;
            }
        }

        //Método que retorna um objeto DataReader
        public SqlDataReader GetDataReader()
        {
            try
            {
                //Define a instrução sql do comando
                vol_Command.CommandText = SqlCommand.ToString();
                //Define o tipo do comando
                vol_Command.CommandType = CommandType.Text;
                //Associa a conexão ao Command
                vol_Command.Connection = Conexao;
                //Exclui o contéudo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                //Retorna o DataReader
                return vol_Command.ExecuteReader();
            }
            catch
            {
                return null;
            }
        }

        //Método que retorna um objeto DataReader ao executar um procedure
        public SqlDataReader GetDataReaderProc()
        {
            try
            {
                //Associa a conexão ao Command
                vol_Command.Connection = Conexao;
                //Define a instrução sql do comando
                vol_Command.CommandText = SqlCommand.ToString();
                //Define o tipo do comando
                vol_Command.CommandType = CommandType.StoredProcedure;
                //Exclui o contéudo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                //Retorna o DataReader
                return vol_Command.ExecuteReader();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro: " + Error.Message, "TESTE_ESL_Loja",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlCommand.Remove(0, SqlCommand.Length);
                return null;
            }
        }

        //Gravar que retorna um objeto DataSet
        public DataSet GetDataSet()
        {
            try
            {
                //Define a instrução sql do comando
                vol_Command.CommandText = SqlCommand.ToString();
                //Define o tipo do comando
                vol_Command.CommandType = CommandType.Text;
                //Associa a conexão ao Command
                vol_Command.Connection = Conexao;
                //Executa o comando
                vol_Command.ExecuteNonQuery();
                //Cria um DataAdapter
                SqlDataAdapter vol_DataAdapter = new SqlDataAdapter();
                //Cria um DataSet
                DataSet vol_DataSet = new DataSet();
                //Associa o comando ao DataAdapter
                vol_DataAdapter.SelectCommand = vol_Command;
                //Carrega os registros no DataSet
                vol_DataAdapter.Fill(vol_DataSet);
                //Exclui o contéudo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                //Retorna o DataSet
                return vol_DataSet;
            }
            catch
            {
                //Exclui o contéudo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                return null;
            }
        }

        //Método para execução de procedure para retornar um DataSet
        public DataSet GetDataSetProc()
        {
            try
            {
                //Associa a conexão ao Command
                vol_Command.Connection = Conexao;
                //Define a instrução sql do comando
                vol_Command.CommandText = SqlCommand.ToString();
                //Define o tipo do comando
                vol_Command.CommandType = CommandType.StoredProcedure;
                //Executa o comando
                vol_Command.ExecuteNonQuery();
                //Cria um DataAdapter
                SqlDataAdapter vol_DataAdapter = new SqlDataAdapter();
                //Cria um DataSet
                DataSet vol_DataSet = new DataSet();
                //Associa o comando ao DataAdapter
                vol_DataAdapter.SelectCommand = vol_Command;
                //Carrega os registros no DataSet
                vol_DataAdapter.Fill(vol_DataSet);
                //Exclui o contéudo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                //Retorna o DataSet
                return vol_DataSet;
            }
            catch (Exception Error)
            {
                //Exclui o contéudo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                //Aviso
                MessageBox.Show("Erro: " + Error.Message, "TESTE_ESL_Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                //Exclui o contéudo da StringBuilder
                SqlCommand.Remove(0, SqlCommand.Length);
                Command.Parameters.Clear();
            }
        }
        #endregion
    }
}