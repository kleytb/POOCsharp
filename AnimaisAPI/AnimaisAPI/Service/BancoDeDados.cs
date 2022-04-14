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
        //public static SqlCommand sqlcommand = new SqlCommand();
        //SqlParamater para adicionar parametros necessários as consultas
        public static SqlParameter parametro = new SqlParameter();
        #endregion

        #region Obter SqlConnection

        public static SqlConnection connection()
        {
            try
            {
                string conexaoBanco = @"Server=DESKTOP-G3MQTKP\SQLEXPRESS;Database=Animais;Integrated Security=SSPI";
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
        
        public static void Insert(string? especie, string? raca, string? idade)
        {
            SqlCommand cmd = new SqlCommand("InsertAnimals", connection());

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tipo", especie);
            cmd.Parameters.AddWithValue("@raca", raca);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.ExecuteNonQuery();
            
            
            sqlconnection.Close();

            
        }

        /*public static void Busca()
        {
            SqlCommand cmd = new SqlCommand("SearchAnimals", connection());

            cmd.CommandType = CommandType.StoredProcedure;

            
        }*/

    }
}

