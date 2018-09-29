using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ExportadorDados
{
    public class conexaoFireBird
    {
        public FbConnection conexaoPrimaria()
        {
            FbConnection fbConnectionPrincipal = new FbConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ToString()
            };
            if (fbConnectionPrincipal.State == ConnectionState.Closed)
            {
                fbConnectionPrincipal.Open();
            }
            return fbConnectionPrincipal;
        }
        public FbConnection conexaoSecundaria()
        {
            FbConnection fbConnectionSecundaria = new FbConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["strFirebirdSecundaria"].ToString()
            };
            return fbConnectionSecundaria;
        }
    }
}
