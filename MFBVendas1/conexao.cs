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
            // String de conexão configurada conforme fornecido
            strConexao = "Server=localhost;Database=MFBVendas;Integrated Security=True;";
            conn = new SqlConnection(strConexao);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return conn;
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
    }
}