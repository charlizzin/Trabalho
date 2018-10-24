using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Threading;

namespace ExportadorDados2
{
    class Conexao1
    {
        private static readonly Conexao1 conexaoPrimaria = new Conexao1();
        private static readonly Conexao1 conexaoSecundaria = new Conexao1();

        private Conexao1() { }

        public static Conexao1 ConexaoPrimaria => conexaoPrimaria;

        public static Conexao1 ConexaoSecundaria => conexaoSecundaria;

        public FbConnection AbrirConnPrimaria()
        {
            FbConnection conexao = null;
            try
            {
                conexao = new FbConnection
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ToString()
                };
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O sistema nao conseguiu conectar com o banco de dados!!!");
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
            }

            return conexao;
        }

        public FbConnection AbrirConnSecundaria()
        {
                FbConnection conexao = null;
                try
                {
                    conexao = new FbConnection
                    {
                        ConnectionString = ConfigurationManager.ConnectionStrings["strFirebirdSecundaria"].ToString()
                    };
                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.Open();
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O sistema nao conseguiu conectar com o banco de dados!!!");
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(1000);
                }

                return conexao;
        }

        public void FecharConexao(FbConnection fbConnection)
        {
            if (fbConnection.State == ConnectionState.Open)
                fbConnection.Close();
        }

        public void ExecutarComando(string strQuery)
        {
            FbConnection fbConnection = new FbConnection();

            try
            {
                fbConnection = AbrirConnPrimaria();
                FbCommand cmd = new FbCommand
                {
                    CommandText = strQuery.ToString(),
                    CommandType = CommandType.Text,
                    Connection = fbConnection
                };
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Houve algum erro ao tentar executar o comandoSQL!!!");
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
            }
            finally
            {
                FecharConexao(fbConnection);
            }
        }
    }
}
