using System.Data;
using System.Data.SqlClient;

namespace AnimaisAPI.Service
{
    public class BancoDeDados
    {
        #region Objetos Estáticos
        //Connection obtem acesso ao SQL Server
        public static SqlConnection sqlconnection = new SqlConnection();
        //SqlCommand para executr comandos
        public static SqlCommand comando = new SqlCommand();
        //SqlParamater para adicionar parametros necessários as consultas
        public static SqlParameter parametro = new SqlParameter();
        #endregion

        #region Obter SqlConnection

        public static SqlConnection connection()
        {
            try
            {
                string conexaoBanco = @"Server=DESKTOP-IMUR320\SQLEXPRESS;Database=Animais;Integrated Security=SSPI";
                sqlconnection = new SqlConnection(conexaoBanco);

                //Verifica se a conexão está aberta, caso não esteja ela é aberta após passar pela condição if
                if (sqlconnection.State == ConnectionState.Closed)
                    sqlconnection.Open();

                return sqlconnection;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Abre Conexão
        public void Open()
        {
            sqlconnection.Open();
        }
        #endregion

        #region Fecha Conexão
        public void Close()
        {
            sqlconnection.Close();
        }
        #endregion

        #region Adiciona parametros
        public static void AdicionarParametros(string? especie, string? raca, string? idade)
        {
            comando = new SqlCommand("InsertAnimals", connection());

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@tipo", especie);
            comando.Parameters.AddWithValue("@raca", raca);
            comando.Parameters.AddWithValue("@idade", idade);
            comando.ExecuteNonQuery();

            sqlconnection.Close();

        }
        #endregion

        /*
        public static DataTable ExecutaConsulta()
        {

            comando.Connection = connection();

            comando.CommandText = "SearchAnimals";

            comando.ExecuteScalar();

            IDataReader dtreader = comando.ExecuteReader();
            DataTable dtresult = new DataTable();
            dtresult.Load(dtreader);

            sqlconnection.Close();

            return dtresult;

        }
        */

    }

}
