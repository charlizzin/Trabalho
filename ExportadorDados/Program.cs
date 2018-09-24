using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace ExportadorDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crio um objeto de mapeamento para a classe User
            var produtosMapper = new MapperFields<Produto>();

            // obtenho meu DataTable que criei no início 
            var datatable = CreateDataTable();

            // Faço o parse de DataTable para List<User>
            var produtos = produtosMapper.Map(datatable);

            // Percorro minha lista e mostro o resultado
            foreach (var item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sql + $"'{item.CODPROD}', " +
                                        $"'{item.ATIVO}', " +
                                        $"'{item.REFERENCIA}', " +
                                        $"'{item.REFFABRICANTE}', " +
                                        $"'{item.DESCRICAO}', " +
                                        $"'{item.DESCRICAO2}', " +
                                        $"'{item.DESCRICAO3}', " +
                                        $"'{item.CODGRUPO}', " +
                                        $"'{item.CODSUBGRUPO}', " +
                                        $"'{item.TIPOPROD}', " +
                                        $"{item.ESTMINIMO.ToString().Replace(",", ".")}, " +
                                        $"'{item.DIASESTMINIMO}', " +
                                        $"{item.ESTMAXIMO.ToString().Replace(",", ".")}, " +
                                        $"'{item.DIASESTMAXIMO}', " +
                                        $"'{item.CODCLASFIS}', " +
                                        $"{item.ALIQIPI.ToString().Replace(",", ".")}, " +
                                        $"{item.ALIQISS.ToString().Replace(",", ".")}, " +
                                        $"{item.ALIQICMSREG00.ToString().Replace(",", ".")}, " +
                                        $"{item.BASEICMSREG00.ToString().Replace(",", ".")}, " +
                                        $"'{item.CODTRIBUT00}', " +
                                        $"'{item.MENSAGEM00}', " +
                                        $"{item.ALIQICMSREG01.ToString().Replace(",", ".")}, " +
                                        $"{item.BASEICMSREG01.ToString().Replace(",", ".")}, " +
                                        $"'{item.CODTRIBUT01}', " +
                                        $"'{item.MENSAGEM01}', " +
                                        $"{item.ALIQICMSREG02.ToString().Replace(",", ".")}, " +
                                        $"{item.BASEICMSREG02.ToString().Replace(",", ".")}, " +
                                        $"'{item.CODTRIBUT02}', " +
                                        $"'{item.MENSAGEM02}', " +
                                        $"{item.ALIQICMSREG03.ToString().Replace(",", ".")}, " +
                                        $"{item.BASEICMSREG03.ToString().Replace(",", ".")}, " +
                                        $"'{item.CODTRIBUT03}', " +
                                        $"'{item.MENSAGEM03}', " +
                                        $"'{item.SUBSTRIB}', " +
                                        $"{item.LUCROSUBSTRIB.ToString().Replace(",", ".")}, " +
                                        $"{item.COMISSAO.ToString().Replace(",", ".")}, " +
                                        $"'{item.EMBALAGEM}', " +
                                        $"'{item.CODLOCAL}', " +
                                        $"'{item.CODFABRIC}', " +
                                        $"{item.PESO.ToString().Replace(",", ".")}, " +
                                        $"'{item.UNIDADEENT}', " +
                                        $"'{item.UNIDADESAIDA}', " +
                                        $"{item.FATORCONVERSAO.ToString().Replace(",", ".")}, " +
                                        $"'{item.MULTDIVIDE}', " +
                                        $"{item.PR_ULT_ENT1.ToString().Replace(",", ".")}, " +
                                        $"'{item.DATA_ULT_ENT1.ToString("yyyy-MM-dd HH:mm:ss").Replace("/", "-")}', " +
                                        $"{item.QUANT_ULT_ENT1.ToString().Replace(",", ".")}, " +
                                        $"'{item.FORNEC_ULT_ENT1}', " +
                                        $"{item.PR_ULT_ENT2.ToString().Replace(",", ".")}, " +
                                        $"'{item.DATA_ULT_ENT2.ToString("yyyy-MM-dd HH:mm:ss").Replace("/", "-")}', " +
                                        $"{item.QUANT_ULT_ENT2.ToString().Replace(",", ".")}, " +
                                        $"'{item.FORNEC_ULT_ENT2}', " +
                                        $"{item.PR_ULT_ENT3.ToString().Replace(",", ".")}, " +
                                        $"'{item.DATA_ULT_ENT3.ToString("yyyy-MM-dd HH:mm:ss").Replace("/", "-")}', " +
                                        $"{item.QUANT_ULT_ENT3.ToString().Replace(",", ".")}, " +
                                        $"'{item.FORNEC_ULT_ENT3}', " +
                                        $"{item.DVV.ToString().Replace(",", ".")}, " +
                                        $"{item.LUCRO.ToString().Replace(",", ".")}, " +
                                        $"{item.SUGESTAO.ToString().Replace(",", ".")}, " +
                                        $"{item.PRECO.ToString().Replace(",", ".")}, " +
                                        $"'{item.PRODBLOQUEADO}', " +
                                        $"'{item.CAMPOLIVRE1}', " +
                                        $"'{item.CAMPOLIVRE2}', " +
                                        $"'{item.CAMPOLIVRE3}', " +
                                        $"'{item.CAMPOLIVRE4}', " +
                                        $"'{item.PRINCIPALFORNEC}', " +
                                        $"'{item.NOTA_ULT_ENT1}', " +
                                        $"'{item.NOTA_ULT_ENT2}', " +
                                        $"'{item.NOTA_ULT_ENT3}', " +
                                        $"'{item.CONTROLESERIE}', " +
                                        $"'{item.CODPRODBAIXA}', " +
                                        $"{item.FATORCONVBAIXA.ToString().Replace(",", ".")}, " +
                                        $"'{item.MULTDIVBAIXA}', " +
                                        $"'{item.CODFRETE}', " +
                                        $"'{item.DT_CADASTRO.ToString("yyyy-MM-dd HH:mm:ss").Replace("/", "-")}', " +
                                        $"'{item.DESCRICAOPRECO}', " +
                                        $"{item.PRECO2.ToString().Replace(",", ".")}, " +
                                        $"'{item.DESCRICAOPRECO2}', " +
                                        $"{item.PRECO3.ToString().Replace(",", ".")}, " +
                                        $"'{item.DESCRICAOPRECO3}', " +
                                        $"{item.LUCRO2.ToString().Replace(",", ".")}, " +
                                        $"{item.LUCRO3.ToString().Replace(",", ".")}, " +
                                        $"'{item.ITEMPORTARIA790}', " +
                                        $"'{item.ENVIADO}', " +
                                        $"{item.PRECODOLAR.ToString().Replace(",", ".")}, " +
                                        $"'{item.DATA_ULT_ALTERACAO.ToString("yyyy-MM-dd HH:mm:ss").Replace("/", "-")}', " +
                                        $"{item.PERCPERDA.ToString().Replace(",", ".")}, " +
                                        $"{item.PRECOPROMO.ToString().Replace(",", ".")}, " +
                                        $"'{item.DATAINIPROMO.ToString("yyyy-MM-dd HH:mm:ss").Replace("/", "-")}', " +
                                        $"'{item.DATAFIMPROMO.ToString("yyyy-MM-dd HH:mm:ss").Replace("/", "-")}', " +
                                        $"'{item.SUBSTRIBSAIDA}', " +
                                        $"{item.PERCBASESUBSTRIBSAIDA.ToString().Replace(",", ".")}, " +
                                        $"{item.PERCICMSSUBSTRIBSAIDA.ToString().Replace(",", ".")}, " +
                                        $"'{item.TEMSUBITENS}', " +
                                        $"'{item.CODSEGMENTOSUBTRIBSAIDA}', " +
                                        $"{item.ALIQICMSDIVERSOS.ToString().Replace(",", ".")}, " +
                                        $"{item.BASEICMSDIVERSOS.ToString().Replace(",", ".")}, " +
                                        $"'{item.CODTRIBUTDIVERSOS}', " +
                                        $"'{item.MENSAGEMDIVERSOS}', " +
                                        $"'{item.TIPODIVERSOS}', " +
                                        $"'{item.CONTACXA}', " +
                                        $"{item.PERCICMMARGEMLUCRO.ToString().Replace(",", ".")}, " +
                                        $"{item.ALIQINTERNAICMLUCRO.ToString().Replace(",", ".")}, " +
                                        $"'{item.SEGMENTOICMLUCRO}', " +
                                        $"'{item.SEGMENTOICMDIVERSOS}', " +
                                        $"{item.ALIQICMSDIVERSOS2.ToString().Replace(",", ".")}, " +
                                        $"{item.BASEICMSDIVERSOS2.ToString().Replace(",", ".")}, " +
                                        $"'{item.CODTRIBUTDIVERSOS2}', " +
                                        $"'{item.MENSAGEMDIVERSOS2}', " +
                                        $"'{item.CONTROLELOTE}', " +
                                        $"'{item.GRADE}', " +
                                        $"'{item.ACEITAPRECOZERO}', " +
                                        $"{item.VLRCOBRAROPER.ToString().Replace(",", ".")}, " +
                                        $"{item.COMISSAOVLR.ToString().Replace(",", ".")}, " +
                                        $"'{item.GARANTIA}', " +
                                        $"{item.IPIANTIGO.ToString().Replace(",", ".")}, " +
                                        $"{item.CUSTODOLAR.ToString().Replace(",", ".")}, " +
                                        $"{item.ALIQICMSPDV.ToString().Replace(",", ".")}, " +
                                        $"'{item.TEMREBATEFINANC}', " +
                                        $"{item.LUCRO4.ToString().Replace(",", ".")}, " +
                                        $"'{item.DESCRICAOPRECO4}', " +
                                        $"{item.PRECO4.ToString().Replace(",", ".")}, " +
                                        $"'{item.PRODBALANCA}', " +
                                        $"'{item.SUBSTRIBSAIDAR1}', " +
                                        $"{item.PERCBASESUBSTRIBSAIDAR1.ToString().Replace(",", ".")}, " +
                                        $"{item.PERCICMSSUBSTRIBSAIDAR1.ToString().Replace(",", ".")}, " +
                                        $"'{item.SUBSTRIBSAIDAR2}', " +
                                        $"{item.PERCBASESUBSTRIBSAIDAR2.ToString().Replace(",", ".")}, " +
                                        $"{item.PERCICMSSUBSTRIBSAIDAR2.ToString().Replace(",", ".")}, " +
                                        $"'{item.SUBSTRIBSAIDAR3}', " +
                                        $"{item.PERCBASESUBSTRIBSAIDAR3.ToString().Replace(",", ".")}, " +
                                        $"{item.PERCICMSSUBSTRIBSAIDAR3.ToString().Replace(",", ".")}, " +
                                        $"{item.DESCONTOMAXIMO.ToString().Replace(",", ".")}, " +
                                        $"'{item.TIPOMEDICAMENTO}', " +
                                        $"{item.DESCPERCPADRAO.ToString().Replace(",", ".")}, " +
                                        $"{item.LUCROPREVISTO.ToString().Replace(",", ".")}, " +
                                        $"{item.REDUTOR.ToString().Replace(",", ".")}, " +
                                        $"'{item.ITEMPORTARIAFORAUF}', " +
                                        $"'{item.DATA_ULT_REAJUSTE.ToString("yyyy-MM-dd HH:mm:ss").Replace("/", "-")}', " +
                                        $"{item.PRECO_ANTERIOR.ToString().Replace(",", ".")}, " +
                                        $"'{item.CODVOLUME}', " +
                                        $"'{item.FRACIONADO}', " +
                                        $"'{item.CODGENEROITEM}', " +
                                        $"{item.CUSTOOPERC.ToString().Replace(",", ".")}, " +
                                        $"{item.PERC_IVA.ToString().Replace(",", ".")}, " +
                                        $"{item.VALORIPI.ToString().Replace(",", ".")}, " +
                                        $"'{item.TIPOENTREGA}', " +
                                        $"{item.LIMINILOTEENTREGA.ToString().Replace(",", ".")}, " +
                                        $"{item.LIMFIMLOTEENTREGA.ToString().Replace(",", ".")}, " +
                                        $"'{item.CONSIDERACOMISSAO}', " +
                                        $"{item.MULTIPLO.ToString().Replace(",", ".")}, " +
                                        $"'{item.UNIDADEMULTIPLO}', " +
                                        $"'{item.SUBSTRIBSAIDAR4}', " +
                                        $"{item.PERCBASESUBSTRIBSAIDAR4.ToString().Replace(",", ".")}, " +
                                        $"{item.PERCICMSSUBSTRIBSAIDAR4.ToString().Replace(",", ".")}, " +
                                        $"'{item.TIPOLISTA}', " +
                                        $"'{item.CODPRODPRODUCAO}', " +
                                        $"'{item.FARMACIAPOPULAR}', " +
                                        $"'{item.CFOPDENTROUF}', " +
                                        $"'{item.CFOPFORAUF}', " +
                                        $"'{item.CODPRODPAI}', " +
                                        $"'{item.CODFAMILIA}', " +
                                        $"'{item.CODTIPOPRODUTO}', " +
                                        $"'{item.CODPRODANP}', " +
                                        $"'{item.VERSION.ToString("yyyy-MM-dd HH:mm:ss").Replace("/", "-")}', " +
                                        $"'{item.AGROTOXICO}', " +
                                        $"'{item.CODIGOMAPA}', " +
                                        $"'{item.CODIGOEMBALAGEM}', " +
                                        $"'{item.ETQPRECOBASE}', " +
                                        $"'{item.ETQPARCELAMENTO}', " +
                                        $"'{item.ETQTXMES}', " +
                                        $"'{item.ETQINFTXMES}', " +
                                        $"'{item.ETQINFPRECOBASE}', " +
                                        $"'{item.ETQINFPRECOAPRAZO}', " +
                                        $"'{item.ETQINFTXDIA}', " +
                                        $"{item.PERCIVASUBSTRIBSAIDA.ToString().Replace(",", ".")}, " +
                                        $"{item.PERCIVASUBSTRIBSAIDA1.ToString().Replace(",", ".")}, " +
                                        $"{item.PERCIVASUBSTRIBSAIDA2.ToString().Replace(",", ".")}, " +
                                        $"{item.PERCIVASUBSTRIBSAIDA3.ToString().Replace(",", ".")}, " +
                                        $"{item.PERCIVASUBSTRIBSAIDA4.ToString().Replace(",", ".")}, " +
                                        $"'{item.IDPRODUTOJAVA}', " +
                                        $"'{item.TIPOSINC}', " +
                                        $"'{item.IMPORTAPRODECOM}', " +
                                        $"'{item.IDPRODUTOECOM}', " +
                                        $"'{item.IAT}', " +
                                        $"'{item.CODENQIPI}', " +
                                        $"'{item.CODNATRECEITA}', " +
                                        $"'{item.IDNATRECEITA}', " +
                                        $"'{item.CODCEST}', " +
                                        $"'{item.TIPOMATEREMBA}', " +
                                        $"'{item.IDPARCEIRO}', " +
                                        $"'{item.TIPOEQPREDUCAOBASEDIFAL}', " +
                                        $"'{item.CODSELFCOLOR}', " +
                                        $"{item.PERCENTDESCTOPROMOCAO.ToString().Replace(",", ".")}, " +
                                        $"'{item.CODSHOTCOLOR}');");
            }

            Console.ReadKey();
        }
        public const string sql = "INSERT INTO PRODUTO (CODPROD, ATIVO, REFERENCIA, REFFABRICANTE, DESCRICAO, DESCRICAO2, DESCRICAO3, CODGRUPO, CODSUBGRUPO, TIPOPROD, ESTMINIMO, DIASESTMINIMO, ESTMAXIMO, DIASESTMAXIMO, CODCLASFIS, ALIQIPI, ALIQISS, ALIQICMSREG00, BASEICMSREG00, CODTRIBUT00, MENSAGEM00, ALIQICMSREG01, BASEICMSREG01, CODTRIBUT01, MENSAGEM01, ALIQICMSREG02, BASEICMSREG02, CODTRIBUT02, MENSAGEM02, ALIQICMSREG03, BASEICMSREG03, CODTRIBUT03, MENSAGEM03, SUBSTRIB, LUCROSUBSTRIB, COMISSAO, EMBALAGEM, CODLOCAL, CODFABRIC, PESO, UNIDADEENT, UNIDADESAIDA, FATORCONVERSAO, MULTDIVIDE, PR_ULT_ENT1, DATA_ULT_ENT1, QUANT_ULT_ENT1, FORNEC_ULT_ENT1, PR_ULT_ENT2, DATA_ULT_ENT2, QUANT_ULT_ENT2, FORNEC_ULT_ENT2, PR_ULT_ENT3, DATA_ULT_ENT3, QUANT_ULT_ENT3, FORNEC_ULT_ENT3, DVV, LUCRO, SUGESTAO, PRECO, PRODBLOQUEADO, CAMPOLIVRE1, CAMPOLIVRE2, CAMPOLIVRE3, CAMPOLIVRE4, PRINCIPALFORNEC, NOTA_ULT_ENT1, NOTA_ULT_ENT2, NOTA_ULT_ENT3, CONTROLESERIE, CODPRODBAIXA, FATORCONVBAIXA, MULTDIVBAIXA, CODFRETE, DT_CADASTRO, DESCRICAOPRECO, PRECO2, DESCRICAOPRECO2, PRECO3, DESCRICAOPRECO3, LUCRO2, LUCRO3, ITEMPORTARIA790, ENVIADO, PRECODOLAR, DATA_ULT_ALTERACAO, PERCPERDA, PRECOPROMO, DATAINIPROMO, DATAFIMPROMO, SUBSTRIBSAIDA, PERCBASESUBSTRIBSAIDA, PERCICMSSUBSTRIBSAIDA, TEMSUBITENS, CODSEGMENTOSUBTRIBSAIDA, ALIQICMSDIVERSOS, BASEICMSDIVERSOS, CODTRIBUTDIVERSOS, MENSAGEMDIVERSOS, TIPODIVERSOS, CONTACXA, PERCICMMARGEMLUCRO, ALIQINTERNAICMLUCRO, SEGMENTOICMLUCRO, SEGMENTOICMDIVERSOS, ALIQICMSDIVERSOS2, BASEICMSDIVERSOS2, CODTRIBUTDIVERSOS2, MENSAGEMDIVERSOS2, CONTROLELOTE, GRADE, ACEITAPRECOZERO, VLRCOBRAROPER, COMISSAOVLR, GARANTIA, IPIANTIGO, CUSTODOLAR, ALIQICMSPDV, TEMREBATEFINANC, LUCRO4, DESCRICAOPRECO4, PRECO4, PRODBALANCA, SUBSTRIBSAIDAR1, PERCBASESUBSTRIBSAIDAR1, PERCICMSSUBSTRIBSAIDAR1, SUBSTRIBSAIDAR2, PERCBASESUBSTRIBSAIDAR2, PERCICMSSUBSTRIBSAIDAR2, SUBSTRIBSAIDAR3, PERCBASESUBSTRIBSAIDAR3, PERCICMSSUBSTRIBSAIDAR3, DESCONTOMAXIMO, TIPOMEDICAMENTO, DESCPERCPADRAO, LUCROPREVISTO, REDUTOR, ITEMPORTARIAFORAUF, DATA_ULT_REAJUSTE, PRECO_ANTERIOR, CODVOLUME, FRACIONADO, CODGENEROITEM, CUSTOOPERC, PERC_IVA, VALORIPI, TIPOENTREGA, LIMINILOTEENTREGA, LIMFIMLOTEENTREGA, CONSIDERACOMISSAO, MULTIPLO, UNIDADEMULTIPLO, SUBSTRIBSAIDAR4, PERCBASESUBSTRIBSAIDAR4, PERCICMSSUBSTRIBSAIDAR4, TIPOLISTA, CODPRODPRODUCAO, FARMACIAPOPULAR, CFOPDENTROUF, CFOPFORAUF, CODPRODPAI, CODFAMILIA, CODTIPOPRODUTO, CODPRODANP, VERSION, AGROTOXICO, CODIGOMAPA, CODIGOEMBALAGEM, ETQPRECOBASE, ETQPARCELAMENTO, ETQTXMES, ETQINFTXMES, ETQINFPRECOBASE, ETQINFPRECOAPRAZO, ETQINFTXDIA, PERCIVASUBSTRIBSAIDA, PERCIVASUBSTRIBSAIDA1, PERCIVASUBSTRIBSAIDA2, PERCIVASUBSTRIBSAIDA3, PERCIVASUBSTRIBSAIDA4, IDPRODUTOJAVA, TIPOSINC, IMPORTAPRODECOM, IDPRODUTOECOM, IAT, CODENQIPI, CODNATRECEITA, IDNATRECEITA, CODCEST, TIPOMATEREMBA, IDPARCEIRO, TIPOEQPREDUCAOBASEDIFAL, CODSELFCOLOR, PERCENTDESCTOPROMOCAO, CODSHOTCOLOR) VALUES (";

        private static IEnumerable<Produto> MapperUser(DataTable dtUser)
        {
            var users = new List<Produto>();

            foreach (var item in dtUser.AsEnumerable())
            {
                users.Add(new Produto
                {
                    CODPROD = item["CODPROD"].ToString(),
                    DESCRICAO = item["DESCRICAO"].ToString(),
                    DATA_ULT_ENT1 = Convert.ToDateTime(item["DATA_ULT_ENT1"]),
                    DT_CADASTRO = Convert.ToDateTime(item["DT_CADASTRO"]),
                    ALIQIPI = Convert.ToDouble(item["ALIQIPI"]),
                    ALIQISS = Convert.ToDouble(item["ALIQUISS"]),
                    TEMREBATEFINANC = item["TEMREBATEFINANC"].ToString()
                });
            }

            return users;
        }
        private static DataTable CreateDataTable()
        {
            FbConnection fbConnectionPrincipal = new FbConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ToString()
            };
            FbConnection fbConnectionSecundaria = new FbConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["strFirebirdSecundaria"].ToString()
            };

            FbDataAdapter fbDataAdapterPrimario = new FbDataAdapter("SELECT * FROM PRODUTO PRO WHERE PRO.CODPROD = '000399'", fbConnectionPrincipal);
            FbDataAdapter fbDataAdapterSecundario = new FbDataAdapter("SELECT * FROM PRODUTO PRO WHERE PRO.CODPROD = '000399'", fbConnectionSecundaria);

            DataTable dataTableP = new DataTable();
            DataTable dataTableS = new DataTable();
            DataTable dataTableT = new DataTable();

            fbDataAdapterPrimario.Fill(dataTableP);
            fbDataAdapterSecundario.Fill(dataTableS);

            dataTableP.Merge(dataTableS);

            var Produtos = dataTableP.AsEnumerable().Distinct().CopyToDataTable();

            return Produtos;
        }
    }
}
