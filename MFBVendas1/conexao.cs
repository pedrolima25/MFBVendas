using System;
using System.Data.SqlClient;

namespace SistemaDeVendasMFB
{
    public class Conexao
    {
        private string strConexao;
        private SqlConnection conn;

        public Conexao()
        {
            // Ensure the connection string is properly set
            strConexao = "Server=localhost;Database=MFBVendas;Integrated Security=True;";
            if (string.IsNullOrWhiteSpace(strConexao))
            {
                throw new InvalidOperationException("Connection string is not initialized.");
            } 
            conn = new SqlConnection(strConexao);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(conn.ConnectionString))
                {
                    conn.ConnectionString = strConexao;
                }
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return conn;
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Erro ao conectar ao banco de dados (SQL Exception): " + sqlEx.Message + " - Error Code: " + sqlEx.ErrorCode);
            }
            catch (InvalidOperationException invOpEx)
            {
                throw new Exception("Erro ao conectar ao banco de dados (Invalid Operation): " + invOpEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }

        public void FecharConexao()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public bool TestarPermissaoDeletar()
        {
            try
            {
                using (SqlConnection connection = AbrirConexao())
                {
                    string query = "SELECT HAS_PERMS_BY_NAME('dbo.Produtos', 'OBJECT', 'DELETE')";
                    SqlCommand command = new SqlCommand(query, connection);
                    int result = (int)command.ExecuteScalar();
                    return result == 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao testar permissão de deletar: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
