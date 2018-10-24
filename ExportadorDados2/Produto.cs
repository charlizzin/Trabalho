using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace ExportadorDados2
{
    class Produto
    {
        Conexao conexao = new Conexao();
        public List<string> ListaDados(FbConnection fbConnection, string strQuery)
        {
            FbConnection conexao = new FbConnection();
            List<string> ListaDeDados = new List<string>();
            DataTable dataTable = new DataTable();
            try

            {
                conexao = fbConnection;
                FbCommand cmd = new FbCommand
                {
                    CommandText = strQuery.ToString(),
                    CommandType = CommandType.Text,
                    Connection = conexao
                };

                FbDataAdapter fbDataAdapter = new FbDataAdapter(cmd);
                fbDataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    ListaDeDados.Add(row[0].ToString());
                }

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
                conexao.Close();
            }

            return ListaDeDados
;

        }

        public List<string> CodigosFiltrados()
        {
            var primario =  ListaDados(conexao.AbrirConexao("Primaria"), strQry);
            var secundario =  ListaDados(conexao.AbrirConexao("Secundaria"), strQry);
            var resultado = primario;

            List<string> listaCodigos = resultado;

            foreach (var item in primario)
            {
                if (secundario.Contains(item))
                    resultado.Remove(item);
            }

            return resultado;
        }

        private readonly string strQry = "SELECT * FROM PRODUTO PRO ORDER BY PRO.CODPROD";
    }
}
