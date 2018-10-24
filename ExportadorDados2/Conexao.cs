using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;
using System.Threading;

namespace ExportadorDados2
{
    class Conexao
    {
        public FbConnection AbrirConexao(string TipoConexao)
        {
            FbConnection conexao = null;
            if (TipoConexao == "Primaria")
            {
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
            }
            else
            {
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
            }

            return conexao;
        }

        public void FecharConexao(FbConnection fbConnection)
        {
            if (fbConnection.State == ConnectionState.Open)
                fbConnection.Close();
        }
    }
}
