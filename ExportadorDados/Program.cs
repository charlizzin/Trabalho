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

                StringBuilder sb = GetStringBuilder(item);

                Console.WriteLine(sb);

                Console.ReadKey();
            }
        }

        private static StringBuilder GetStringBuilder(Produto item)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(sql + "'" + item.CODPROD + "', " +
                            "'" + item.ATIVO + "', " +
                            "'" + item.REFERENCIA + "', " +
                            "'" + item.REFFABRICANTE + "', " +
                            "'" + item.DESCRICAO + "', " +
                            "'" + item.DESCRICAO2 + "', " +
                            "'" + item.DESCRICAO3 + "', " +
                            "'" + item.CODGRUPO + "', " +
                            "'" + item.CODSUBGRUPO + "', " +
                            "'" + item.TIPOPROD + "', " +
                            "" + item.ESTMINIMO.ToString().Replace(",", ".") + ", " +
                            "" + item.DIASESTMINIMO.ToString().Replace(",", ".") + ", " +
                            "" + item.ESTMAXIMO.ToString().Replace(",", ".") + ", " +
                            "" + item.DIASESTMAXIMO + ", " +
                            "'" + item.CODCLASFIS + "', " +
                            "" + item.ALIQIPI.ToString().Replace(",", ".") + ", " +
                            "" + item.ALIQISS.ToString().Replace(",", ".") + ", " +
                            "" + item.ALIQICMSREG00.ToString().Replace(",", ".") + ", " +
                            "" + item.BASEICMSREG00.ToString().Replace(",", ".") + ", " +
                            "'" + item.CODTRIBUT00 + "', " +
                            "'" + item.MENSAGEM00 + "', " +
                            "" + item.ALIQICMSREG01.ToString().Replace(",", ".") + ", " +
                            "" + item.BASEICMSREG01.ToString().Replace(",", ".") + ", " +
                            "'" + item.CODTRIBUT01 + "', " +
                            "'" + item.MENSAGEM01 + "', " +
                            "" + item.ALIQICMSREG02.ToString().Replace(",", ".") + ", " +
                            "" + item.BASEICMSREG02.ToString().Replace(",", ".") + ", " +
                            "'" + item.CODTRIBUT02 + "', " +
                            "'" + item.MENSAGEM02 + "', " +
                            "" + item.ALIQICMSREG03.ToString().Replace(",", ".") + ", " +
                            "" + item.BASEICMSREG03.ToString().Replace(",", ".") + ", " +
                            "'" + item.CODTRIBUT03 + "', " +
                            "'" + item.MENSAGEM03 + "', " +
                            "'" + item.SUBSTRIB + "', " +
                            "" + item.LUCROSUBSTRIB.ToString().Replace(",", ".") + ", " +
                            "" + item.COMISSAO.ToString().Replace(",", ".") + ", " +
                            "'" + item.EMBALAGEM + "', " +
                            "'" + item.CODLOCAL + "', " +
                            "'" + item.CODFABRIC + "', " +
                            "" + item.PESO.ToString().Replace(",", ".") + ", " +
                            "'" + item.UNIDADEENT + "', " +
                            "'" + item.UNIDADESAIDA + "', " +
                            "" + item.FATORCONVERSAO.ToString().Replace(",", ".") + ", " +
                            "'" + item.MULTDIVIDE + "', ");
            if (item.PR_ULT_ENT1 != 0)
            {
                sb.Append("" + item.PR_ULT_ENT1.ToString().Replace(",",".") + ", ");
            }
            else sb.Append(" NULL,");
            if (item.DATA_ULT_ENT1.Day != 1 || item.DATA_ULT_ENT1.Month != 1 || item.DATA_ULT_ENT1.Year != 1)
            {
                sb.Append("'" + item.DATA_ULT_ENT1.ToString("yyyy-MM-dd hh:mm:ss").Replace("/","-") + "', ");
            }
            else sb.Append(" NULL,");
            if (item.QUANT_ULT_ENT1 != 0)
            {
                sb.Append("" + item.QUANT_ULT_ENT1.ToString().Replace(",", ".") + ", ");
            }
            else sb.Append(" NULL,");
            sb.Append("" + item.FORNEC_ULT_ENT1 + ", ");
            if (item.PR_ULT_ENT2 != 0)
            {
                sb.Append("" + item.PR_ULT_ENT2.ToString().Replace(",", ".") + "");
            }
            else sb.Append(" NULL,");
            if (item.DATA_ULT_ENT2.Day != 1 || item.DATA_ULT_ENT2.Month != 1 || item.DATA_ULT_ENT2.Year != 1)
            {
                sb.Append("'" + item.DATA_ULT_ENT2.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-") + "', ");
            }
            else sb.Append(" NULL,");
            if (item.QUANT_ULT_ENT2 != 0)
            {
                sb.Append("" + item.QUANT_ULT_ENT2.ToString().Replace(",", ".") + ", ");
            }
            else sb.Append(" NULL,");
            if (item.PR_ULT_ENT3 != 0)
            {
                sb.Append("" + item.PR_ULT_ENT3.ToString().Replace(",", ".") + ", ");
            }
            else sb.Append(" NULL,");
            if (item.DATA_ULT_ENT3.Day != 1 || item.DATA_ULT_ENT3.Month != 1 || item.DATA_ULT_ENT3.Year != 1)
            {
                sb.Append("'" + item.DATA_ULT_ENT3.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-") + "', ");
            }
            else sb.Append(" NULL,");
            if (item.QUANT_ULT_ENT3 != 0)
            {
                sb.Append("" + item.QUANT_ULT_ENT3.ToString().Replace(",", ".") + ", ");
            }
            else sb.Append(" NULL,");
            sb.Append("" + item.DVV.ToString().Replace(",", ".") + ", " +
            "" + item.LUCRO.ToString().Replace(",", ".") + ", ");
            if (item.SUGESTAO != 0)
            {
                sb.Append("" + item.SUGESTAO.ToString().Replace(",", ".") + ", ");
            }
            else sb.Append(" NULL,");
            sb.Append("" + item.PRECO.ToString().Replace(",", ".") + ", " +
            "'" + item.PRODBLOQUEADO + "', " +
            "'" + item.CAMPOLIVRE1 + "', " +
            "'" + item.CAMPOLIVRE2 + "', " +
            "'" + item.CAMPOLIVRE3 + "', " +
            "'" + item.CAMPOLIVRE4 + "', " +
            "'" + item.PRINCIPALFORNEC + "', ");
            if (item.NOTA_ULT_ENT1 != null)
            {
                sb.Append("'" + item.NOTA_ULT_ENT1 + "', ");
            }
            else sb.Append(" NULL,");
            if (item.NOTA_ULT_ENT2 != null)
            {
                sb.Append("'" + item.NOTA_ULT_ENT2 + "', ");
            }
            else sb.Append(" NULL,");
            if (item.NOTA_ULT_ENT3 != null)
            {
                sb.Append("'" + item.NOTA_ULT_ENT3 + "', ");
            }
            else sb.Append(" NULL,");
            if (item.CONTROLESERIE != null)
            {
                sb.Append("'" + item.CONTROLESERIE + "'");
            }
            else sb.Append(" NULL,");
            sb.Append("'" + item.CODPRODBAIXA + "', " +
            "" + item.FATORCONVBAIXA.ToString().Replace(",", ".") + ", " +
            "'" + item.MULTDIVBAIXA + "', ");
            if (item.CODFRETE != null)
            {
                sb.Append("'" + item.CODFRETE + "'");
            }
            else sb.Append(" NULL,");
            sb.Append("'" + item.DT_CADASTRO.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-") + "', " +
            "'" + item.DESCRICAOPRECO + "', " +
            "" + item.PRECO2.ToString().Replace(",", ".") + ", " +
            "'" + item.DESCRICAOPRECO2 + "', " +
            "" + item.PRECO3.ToString().Replace(",", ".") + ", " +
            "'" + item.DESCRICAOPRECO3 + "', " +
            "" + item.LUCRO2.ToString().Replace(",", ".") + ", " +
            "" + item.LUCRO3.ToString().Replace(",", ".") + ", ");
            if (item.ITEMPORTARIA790 != null)
            {
                sb.Append("'" + item.ITEMPORTARIA790 + "'");
            }
            else sb.Append(" NULL,");
            if (item.ENVIADO != null)
            {
                sb.Append("'" + item.ENVIADO + "'");
            }
            else sb.Append(" NULL,");
            sb.Append("'" + item.PRECODOLAR.ToString().Replace(",", ".") + "', ");
            if (item.DATA_ULT_ALTERACAO.Day != 1 || item.DATA_ULT_ALTERACAO.Month != 1 || item.DATA_ULT_ALTERACAO.Year != 1)
            {
                sb.Append("'" + item.DATA_ULT_ALTERACAO.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-") + "', ");
            }
            else sb.Append(" NULL,");
            sb.Append("'" + item.PERCPERDA.ToString().Replace(",", ".") + "', " +
            "'" + item.PRECOPROMO + "', ");
            if (item.DATAINIPROMO.Day != 1 || item.DATAINIPROMO.Month != 1 || item.DATAINIPROMO.Year != 1)
            {
                sb.Append("'" + item.DATAINIPROMO.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-") + "', ");
            }
            else sb.Append(" NULL,");
            if (item.DATAFIMPROMO.Day != 1 || item.DATAFIMPROMO.Month != 1 || item.DATAFIMPROMO.Year != 1)
            {
                sb.Append("'" + item.DATAFIMPROMO.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-") + "', ");
            }
            else sb.Append(" NULL,");
            sb.Append("'" + item.SUBSTRIBSAIDA + "', " +
            "" + item.PERCBASESUBSTRIBSAIDA.ToString().Replace(",", ".") + ", " +
            "" + item.PERCICMSSUBSTRIBSAIDA.ToString().Replace(",", ".") + ", ");
            if (item.TEMSUBITENS != null)
            {
                sb.Append("'" + item.TEMSUBITENS + "'");
            }
            else sb.Append(" NULL,");
            sb.Append("'" + item.CODSEGMENTOSUBTRIBSAIDA + "', " +
            "" + item.ALIQICMSDIVERSOS.ToString().Replace(",", ".") + ", " +
            "" + item.BASEICMSDIVERSOS.ToString().Replace(",", ".") + ", " +
            "'" + item.CODTRIBUTDIVERSOS + "', " +
            "'" + item.MENSAGEMDIVERSOS + "', " +
            "'" + item.TIPODIVERSOS + "', " +
            "'" + item.CONTACXA + "', " +
            "" + item.PERCICMMARGEMLUCRO.ToString().Replace(",", ".") + ", " +
            "" + item.ALIQINTERNAICMLUCRO.ToString().Replace(",", ".") + ", " +
            "'" + item.SEGMENTOICMLUCRO + "', " +
            "'" + item.SEGMENTOICMDIVERSOS + "', " +
            "" + item.ALIQICMSDIVERSOS2.ToString().Replace(",", ".") + ", " +
            "" + item.BASEICMSDIVERSOS2.ToString().Replace(",", ".") + ", " +
            "'" + item.CODTRIBUTDIVERSOS2 + "', " +
            "'" + item.MENSAGEMDIVERSOS2 + "', ");
            if (item.CONTROLELOTE != null)
            {
                sb.Append("'" + item.CONTROLELOTE + "'");
            }
            else sb.Append(" NULL,");
            sb.Append("'" + item.GRADE + "', ");
            if (item.ACEITAPRECOZERO != null)
            {
                sb.Append("'" + item.ACEITAPRECOZERO + "'");
            }
            else sb.Append(" NULL,");
            sb.Append("'" + item.VLRCOBRAROPER.ToString().Replace(",", ".") + "', " +
            "" + item.COMISSAOVLR.ToString().Replace(",", ".") + ", ");
            if (item.GARANTIA != 0)
            {
                sb.Append("'" + item.GARANTIA + "'");
            }
            else sb.Append(" NULL,");
            sb.Append("" + item.IPIANTIGO.ToString().Replace(",", ".") + ", " +
            "" + item.CUSTODOLAR.ToString().Replace(",", ".") + ", " +
            "" + item.ALIQICMSPDV.ToString().Replace(",", ".") + ", ");
            if (item.TEMREBATEFINANC != null)
            {
                sb.Append("'" + item.TEMREBATEFINANC + "'");
            }
            else sb.Append(" NULL,");
            sb.Append("" + item.LUCRO4.ToString().Replace(",", ".") + ", " +
            "'" + item.DESCRICAOPRECO4 + "', " +
            "" + item.PRECO4.ToString().Replace(",", ".") + ", ");
            if (item.PRODBALANCA != null)
            {
                sb.Append("'" + item.PRODBALANCA + "'");
            }
            else sb.Append(" NULL,");
            sb.Append("'" + item.SUBSTRIBSAIDAR1 + "', " +
            "" + item.PERCBASESUBSTRIBSAIDAR1.ToString().Replace(",", ".") + ", " +
            "" + item.PERCICMSSUBSTRIBSAIDAR1.ToString().Replace(",", ".") + ", " +
            "'" + item.SUBSTRIBSAIDAR2 + "', " +
            "" + item.PERCBASESUBSTRIBSAIDAR2.ToString().Replace(",", ".") + ", " +
            "" + item.PERCICMSSUBSTRIBSAIDAR2.ToString().Replace(",", ".") + ", " +
            "'" + item.SUBSTRIBSAIDAR3 + "', " +
            "" + item.PERCBASESUBSTRIBSAIDAR3.ToString().Replace(",", ".") + ", " +
            "" + item.PERCICMSSUBSTRIBSAIDAR3.ToString().Replace(",", ".") + ", " +
            "" + item.DESCONTOMAXIMO.ToString().Replace(",", ".") + ", ");
            if (item.TIPOMEDICAMENTO > 0)
            {
                sb.Append("" + item.TIPOMEDICAMENTO + "");
            }
            else sb.Append(" NULL,");
            if (item.DESCPERCPADRAO > 0)
            {
                sb.Append("" + item.DESCPERCPADRAO.ToString().Replace(",", ".") + "");
            }
            else sb.Append(" NULL,");
            if (item.LUCROPREVISTO > 0)
            {
                sb.Append("" + item.LUCROPREVISTO.ToString().Replace(",", ".") + "");
            }
            else sb.Append(" NULL,");
            if (item.LUCROPREVISTO > 0)
            {
                sb.Append("" + item.LUCROPREVISTO.ToString().Replace(",", ".") + "");
            }
            else sb.Append(" NULL,");
            if (item.REDUTOR > 0)
            {
                sb.Append("" + item.REDUTOR.ToString().Replace(",", ".") + "");
            }
            else sb.Append(" NULL,");
            if (item.ITEMPORTARIAFORAUF != null)
            {
                sb.Append("'" + item.ITEMPORTARIAFORAUF + "'");
            }
            else sb.Append(" NULL,");
            if (item.DATA_ULT_REAJUSTE.Day != 1 || item.DATA_ULT_REAJUSTE.Month != 1 || item.DATA_ULT_REAJUSTE.Year != 1)
            {
                sb.Append("'" + item.DATA_ULT_REAJUSTE.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-") + "'");
            }
            else sb.Append(" NULL,");
            if (item.PRECO_ANTERIOR != 0)
            {
                sb.Append("" + item.PRECO_ANTERIOR.ToString().Replace(",", ".") + "");
            }
            else sb.Append(" NULL,");
            sb.Append("'" + item.CODVOLUME + "', " +
            "'" + item.FRACIONADO + "', " +
            "'" + item.CODGENEROITEM + "', ");
            if (item.CUSTOOPERC != 0)
            {
                sb.Append("" + item.CUSTOOPERC.ToString().Replace(",", ".") + "");
            }
            else sb.Append(" NULL,");
            sb.Append("" + item.PERC_IVA.ToString().Replace(",", ".") + ", " +
            "" + item.VALORIPI.ToString().Replace(",", ".") + ", " +
            "'" + item.TIPOENTREGA + "', " +
            "" + item.LIMINILOTEENTREGA.ToString().Replace(",", ".") + ", " +
            "" + item.LIMFIMLOTEENTREGA.ToString().Replace(",", ".") + ", " +
            "'" + item.CONSIDERACOMISSAO + "', " +
            "" + item.MULTIPLO.ToString().Replace(",", ".") + ", " +
            "'" + item.UNIDADEMULTIPLO + "', " +
            "'" + item.SUBSTRIBSAIDAR4 + "', " +
            "" + item.PERCBASESUBSTRIBSAIDAR4.ToString().Replace(",", ".") + ", " +
            "" + item.PERCICMSSUBSTRIBSAIDAR4.ToString().Replace(",", ".") + ", " +
            "'" + item.TIPOLISTA + "', " +
            "'" + item.CODPRODPRODUCAO + "', " +
            "'" + item.FARMACIAPOPULAR + "', " +
            "'" + item.CFOPDENTROUF + "', " +
            "'" + item.CFOPFORAUF + "', " +
            "'" + item.CODPRODPAI + "', " +
            "'" + item.CODFAMILIA + "', " +
            "'" + item.CODTIPOPRODUTO + "', " +
            "'" + item.CODPRODANP + "', " +
            "'" + item.VERSION.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-") + "', " +
            "'" + item.AGROTOXICO + "', " +
            "'" + item.CODIGOMAPA + "', " +
            "'" + item.CODIGOEMBALAGEM + "', " +
            "" + item.ETQPRECOBASE + ", " +
            "" + item.ETQPARCELAMENTO + ", " +
            "" + item.ETQTXMES.ToString().Replace(",", ".") + ", " +
            "'" + item.ETQINFTXMES + "', " +
            "'" + item.ETQINFPRECOBASE + "', " +
            "'" + item.ETQINFPRECOAPRAZO + "', " +
            "'" + item.ETQINFTXDIA + "', " +
            "" + item.PERCIVASUBSTRIBSAIDA.ToString().Replace(",", ".") + ", " +
            "" + item.PERCIVASUBSTRIBSAIDA1.ToString().Replace(",", ".") + ", " +
            "" + item.PERCIVASUBSTRIBSAIDA2.ToString().Replace(",", ".") + ", " +
            "" + item.PERCIVASUBSTRIBSAIDA3.ToString().Replace(",", ".") + ", " +
            "" + item.PERCIVASUBSTRIBSAIDA4.ToString().Replace(",", ".") + ", " +
            "" + item.IDPRODUTOJAVA + ", " +
            "'" + item.TIPOSINC + "', " +
            "" + item.IMPORTAPRODECOM + ", " +
            "" + item.IDPRODUTOECOM + ", " +
            "'" + item.IAT + "', " +
            "'" + item.CODENQIPI + "', " +
            "'" + item.CODNATRECEITA + "', " +
            "" + item.IDNATRECEITA + ", " +
            "'" + item.CODCEST + "', " +
            "" + item.TIPOMATEREMBA + ", " +
            "" + item.IDPARCEIRO + ", " +
            "" + item.TIPOEQPREDUCAOBASEDIFAL + ", " +
            "'" + item.CODSELFCOLOR + "', " +
            "" + item.PERCENTDESCTOPROMOCAO.ToString().Replace(",", ".") + ", ");
            if (item.CODSHOTCOLOR != null)
            {
                sb.Append("'" + item.CODSHOTCOLOR + "'");
            }
            else sb.Append(" NULL)");
            return sb;
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
                    ATIVO = item["ATIVO"].ToString(),
                    REFERENCIA = item["REFERENCIA"].ToString(),
                    REFFABRICANTE = item["REFFABRICANTE"].ToString(),
                    DESCRICAO = item["DESCRICAO"].ToString(),
                    DESCRICAO2 = item["DESCRICAO2"].ToString(),
                    DESCRICAO3 = item["DESCRICAO3"].ToString(),
                    CODGRUPO = item["CODGRUPO"].ToString(),
                    CODSUBGRUPO = item["CODSUBGRUPO"].ToString(),
                    TIPOPROD = item["TIPOPROD"].ToString(),
                    ESTMINIMO = Convert.ToDouble(item["ESTMINIMO"].ToString()),
                    DIASESTMINIMO = Convert.ToInt32(item["DIASESTMINIMO"].ToString()),
                    ESTMAXIMO = Convert.ToDouble(item["ESTMAXIMO"].ToString()),
                    DIASESTMAXIMO = Convert.ToInt32(item["DIASESTMAXIMO"].ToString()),
                    CODCLASFIS = item["CODCLASFIS"].ToString(),
                    ALIQIPI = Convert.ToDouble(item["ALIQIPI"].ToString()),
                    ALIQISS = Convert.ToDouble(item["ALIQISS"].ToString()),
                    ALIQICMSREG00 = Convert.ToDouble(item["ALIQICMSREG00"].ToString()),
                    BASEICMSREG00 = Convert.ToDouble(item["BASEICMSREG00"].ToString()),
                    CODTRIBUT00 = item["CODTRIBUT00"].ToString(),
                    MENSAGEM00 = item["MENSAGEM00"].ToString(),
                    ALIQICMSREG01 = Convert.ToDouble(item["ALIQICMSREG01"].ToString()),
                    BASEICMSREG01 = Convert.ToDouble(item["BASEICMSREG01"].ToString()),
                    CODTRIBUT01 = item["CODTRIBUT01"].ToString(),
                    MENSAGEM01 = item["MENSAGEM01"].ToString(),
                    ALIQICMSREG02 = Convert.ToDouble(item["ALIQICMSREG02"].ToString()),
                    BASEICMSREG02 = Convert.ToDouble(item["BASEICMSREG02"].ToString()),
                    CODTRIBUT02 = item["CODTRIBUT02"].ToString(),
                    MENSAGEM02 = item["MENSAGEM02"].ToString(),
                    ALIQICMSREG03 = Convert.ToDouble(item["ALIQICMSREG03"].ToString()),
                    BASEICMSREG03 = Convert.ToDouble(item["BASEICMSREG03"].ToString()),
                    CODTRIBUT03 = item["CODTRIBUT03"].ToString(),
                    MENSAGEM03 = item["MENSAGEM03"].ToString(),
                    SUBSTRIB = item["SUBSTRIB"].ToString(),
                    LUCROSUBSTRIB = Convert.ToDouble(item["LUCROSUBSTRIB"].ToString()),
                    COMISSAO = Convert.ToDouble(item["COMISSAO"].ToString()),
                    EMBALAGEM = item["EMBALAGEM"].ToString(),
                    CODLOCAL = item["CODLOCAL"].ToString(),
                    CODFABRIC = item["CODFABRIC"].ToString(),
                    PESO = Convert.ToDouble(item["PESO"].ToString()),
                    UNIDADEENT = item["UNIDADEENT"].ToString(),
                    UNIDADESAIDA = item["UNIDADESAIDA"].ToString(),
                    FATORCONVERSAO = Convert.ToDouble(item["FATORCONVERSAO"].ToString()),
                    MULTDIVIDE = item["MULTDIVIDE"].ToString(),
                    PR_ULT_ENT1 = Convert.ToDouble(item["PR_ULT_ENT1"].ToString()),
                    DATA_ULT_ENT1 = Convert.ToDateTime(item["DATA_ULT_ENT1"].ToString()),
                    QUANT_ULT_ENT1 = Convert.ToDouble(item["QUANT_ULT_ENT1"].ToString()),
                    FORNEC_ULT_ENT1 = item["FORNEC_ULT_ENT1"].ToString(),
                    PR_ULT_ENT2 = Convert.ToDouble(item["PR_ULT_ENT2"].ToString()),
                    DATA_ULT_ENT2 = Convert.ToDateTime(item["DATA_ULT_ENT2"].ToString()),
                    QUANT_ULT_ENT2 = Convert.ToDouble(item["QUANT_ULT_ENT2"].ToString()),
                    FORNEC_ULT_ENT2 = item["FORNEC_ULT_ENT2"].ToString(),
                    PR_ULT_ENT3 = Convert.ToDouble(item["PR_ULT_ENT3"].ToString()),
                    DATA_ULT_ENT3 = Convert.ToDateTime(item["DATA_ULT_ENT3"].ToString()),
                    QUANT_ULT_ENT3 = Convert.ToDouble(item["QUANT_ULT_ENT3"].ToString()),
                    FORNEC_ULT_ENT3 = item["FORNEC_ULT_ENT3"].ToString(),
                    DVV = Convert.ToDouble(item["DVV"].ToString()),
                    LUCRO = Convert.ToDouble(item["LUCRO"].ToString()),
                    SUGESTAO = Convert.ToDouble(item["SUGESTAO"].ToString()),
                    PRECO = Convert.ToDouble(item["PRECO"].ToString()),
                    PRODBLOQUEADO = item["PRODBLOQUEADO"].ToString(),
                    CAMPOLIVRE1 = item["CAMPOLIVRE1"].ToString(),
                    CAMPOLIVRE2 = item["CAMPOLIVRE2"].ToString(),
                    CAMPOLIVRE3 = item["CAMPOLIVRE3"].ToString(),
                    CAMPOLIVRE4 = item["CAMPOLIVRE4"].ToString(),
                    PRINCIPALFORNEC = item["PRINCIPALFORNEC"].ToString(),
                    NOTA_ULT_ENT1 = item["NOTA_ULT_ENT1"].ToString(),
                    NOTA_ULT_ENT2 = item["NOTA_ULT_ENT2"].ToString(),
                    NOTA_ULT_ENT3 = item["NOTA_ULT_ENT3"].ToString(),
                    CONTROLESERIE = item["CONTROLESERIE"].ToString(),
                    CODPRODBAIXA = item["CODPRODBAIXA"].ToString(),
                    FATORCONVBAIXA = Convert.ToDouble(item["FATORCONVBAIXA"].ToString()),
                    MULTDIVBAIXA = item["MULTDIVBAIXA"].ToString(),
                    CODFRETE = item["CODFRETE"].ToString(),
                    DT_CADASTRO = Convert.ToDateTime(item["DT_CADASTRO"].ToString()),
                    DESCRICAOPRECO = item["DESCRICAOPRECO"].ToString(),
                    PRECO2 = Convert.ToDouble(item["PRECO2"].ToString()),
                    DESCRICAOPRECO2 = item["DESCRICAOPRECO2"].ToString(),
                    PRECO3 = Convert.ToDouble(item["PRECO3"].ToString()),
                    DESCRICAOPRECO3 = item["DESCRICAOPRECO3"].ToString(),
                    LUCRO2 = Convert.ToDouble(item["LUCRO2"].ToString()),
                    LUCRO3 = Convert.ToDouble(item["LUCRO3"].ToString()),
                    ITEMPORTARIA790 = item["ITEMPORTARIA790"].ToString(),
                    ENVIADO = item["ENVIADO"].ToString(),
                    PRECODOLAR = Convert.ToDouble(item["PRECODOLAR"].ToString()),
                    DATA_ULT_ALTERACAO = Convert.ToDateTime(item["DATA_ULT_ALTERACAO"].ToString()),
                    PERCPERDA = Convert.ToDouble(item["PERCPERDA"].ToString()),
                    PRECOPROMO = Convert.ToDouble(item["PRECOPROMO"].ToString()),
                    DATAINIPROMO = Convert.ToDateTime(item["DATAINIPROMO"].ToString()),
                    DATAFIMPROMO = Convert.ToDateTime(item["DATAFIMPROMO"].ToString()),
                    SUBSTRIBSAIDA = item["SUBSTRIBSAIDA"].ToString(),
                    PERCBASESUBSTRIBSAIDA = Convert.ToDouble(item["PERCBASESUBSTRIBSAIDA"].ToString()),
                    PERCICMSSUBSTRIBSAIDA = Convert.ToDouble(item["PERCICMSSUBSTRIBSAIDA"].ToString()),
                    TEMSUBITENS = item["TEMSUBITENS"].ToString(),
                    CODSEGMENTOSUBTRIBSAIDA = item["CODSEGMENTOSUBTRIBSAIDA"].ToString(),
                    ALIQICMSDIVERSOS = Convert.ToDouble(item["ALIQICMSDIVERSOS"].ToString()),
                    BASEICMSDIVERSOS = Convert.ToDouble(item["BASEICMSDIVERSOS"].ToString()),
                    CODTRIBUTDIVERSOS = item["CODTRIBUTDIVERSOS"].ToString(),
                    MENSAGEMDIVERSOS = item["MENSAGEMDIVERSOS"].ToString(),
                    TIPODIVERSOS = item["TIPODIVERSOS"].ToString(),
                    CONTACXA = item["CONTACXA"].ToString(),
                    PERCICMMARGEMLUCRO = Convert.ToDouble(item["PERCICMMARGEMLUCRO"].ToString()),
                    ALIQINTERNAICMLUCRO = Convert.ToDouble(item["ALIQINTERNAICMLUCRO"].ToString()),
                    SEGMENTOICMLUCRO = item["SEGMENTOICMLUCRO"].ToString(),
                    SEGMENTOICMDIVERSOS = item["SEGMENTOICMDIVERSOS"].ToString(),
                    ALIQICMSDIVERSOS2 = Convert.ToDouble(item["ALIQICMSDIVERSOS2"].ToString()),
                    BASEICMSDIVERSOS2 = Convert.ToDouble(item["BASEICMSDIVERSOS2"].ToString()),
                    CODTRIBUTDIVERSOS2 = item["CODTRIBUTDIVERSOS2"].ToString(),
                    MENSAGEMDIVERSOS2 = item["MENSAGEMDIVERSOS2"].ToString(),
                    CONTROLELOTE = item["CONTROLELOTE"].ToString(),
                    GRADE = Convert.ToInt32(item["GRADE"].ToString()),
                    ACEITAPRECOZERO = item["ACEITAPRECOZERO"].ToString(),
                    VLRCOBRAROPER = Convert.ToDouble(item["VLRCOBRAROPER"].ToString()),
                    COMISSAOVLR = Convert.ToDouble(item["COMISSAOVLR"].ToString()),
                    GARANTIA = Convert.ToInt32(item["GARANTIA"].ToString()),
                    IPIANTIGO = Convert.ToDouble(item["IPIANTIGO"].ToString()),
                    CUSTODOLAR = Convert.ToDouble(item["CUSTODOLAR"].ToString()),
                    ALIQICMSPDV = Convert.ToDouble(item["ALIQICMSPDV"].ToString()),
                    TEMREBATEFINANC = item["TEMREBATEFINANC"].ToString(),
                    LUCRO4 = Convert.ToDouble(item["LUCRO4"].ToString()),
                    DESCRICAOPRECO4 = item["DESCRICAOPRECO4"].ToString(),
                    PRECO4 = Convert.ToDouble(item["PRECO4"].ToString()),
                    PRODBALANCA = item["PRODBALANCA"].ToString(),
                    SUBSTRIBSAIDAR1 = item["SUBSTRIBSAIDAR1"].ToString(),
                    PERCBASESUBSTRIBSAIDAR1 = Convert.ToDouble(item["PERCBASESUBSTRIBSAIDAR1"].ToString()),
                    PERCICMSSUBSTRIBSAIDAR1 = Convert.ToDouble(item["PERCICMSSUBSTRIBSAIDAR1"].ToString()),
                    SUBSTRIBSAIDAR2 = item["SUBSTRIBSAIDAR2"].ToString(),
                    PERCBASESUBSTRIBSAIDAR2 = Convert.ToDouble(item["PERCBASESUBSTRIBSAIDAR2"].ToString()),
                    PERCICMSSUBSTRIBSAIDAR2 = Convert.ToDouble(item["PERCICMSSUBSTRIBSAIDAR2"].ToString()),
                    SUBSTRIBSAIDAR3 = item["SUBSTRIBSAIDAR3"].ToString(),
                    PERCBASESUBSTRIBSAIDAR3 = Convert.ToDouble(item["PERCBASESUBSTRIBSAIDAR3"].ToString()),
                    PERCICMSSUBSTRIBSAIDAR3 = Convert.ToDouble(item["PERCICMSSUBSTRIBSAIDAR3"].ToString()),
                    DESCONTOMAXIMO = Convert.ToDouble(item["DESCONTOMAXIMO"].ToString()),
                    TIPOMEDICAMENTO = Convert.ToInt32(item["TIPOMEDICAMENTO"].ToString()),
                    DESCPERCPADRAO = Convert.ToDouble(item["DESCPERCPADRAO"].ToString()),
                    LUCROPREVISTO = Convert.ToDouble(item["LUCROPREVISTO"].ToString()),
                    REDUTOR = Convert.ToDouble(item["REDUTOR"].ToString()),
                    ITEMPORTARIAFORAUF = item["ITEMPORTARIAFORAUF"].ToString(),
                    DATA_ULT_REAJUSTE = Convert.ToDateTime(item["DATA_ULT_REAJUSTE"].ToString()),
                    PRECO_ANTERIOR = Convert.ToDouble(item["PRECO_ANTERIOR"].ToString()),
                    CODVOLUME = item["CODVOLUME"].ToString(),
                    FRACIONADO = item["FRACIONADO"].ToString(),
                    CODGENEROITEM = item["CODGENEROITEM"].ToString(),
                    CUSTOOPERC = Convert.ToDouble(item["CUSTOOPERC"].ToString()),
                    PERC_IVA = Convert.ToDouble(item["PERC_IVA"].ToString()),
                    VALORIPI = Convert.ToDouble(item["VALORIPI"].ToString()),
                    TIPOENTREGA = item["TIPOENTREGA"].ToString(),
                    LIMINILOTEENTREGA = Convert.ToDouble(item["LIMINILOTEENTREGA"].ToString()),
                    LIMFIMLOTEENTREGA = Convert.ToDouble(item["LIMFIMLOTEENTREGA"].ToString()),
                    CONSIDERACOMISSAO = item["CONSIDERACOMISSAO"].ToString(),
                    MULTIPLO = Convert.ToDouble(item["MULTIPLO"].ToString()),
                    UNIDADEMULTIPLO = item["UNIDADEMULTIPLO"].ToString(),
                    SUBSTRIBSAIDAR4 = item["SUBSTRIBSAIDAR4"].ToString(),
                    PERCBASESUBSTRIBSAIDAR4 = Convert.ToDouble(item["PERCBASESUBSTRIBSAIDAR4"].ToString()),
                    PERCICMSSUBSTRIBSAIDAR4 = Convert.ToDouble(item["PERCICMSSUBSTRIBSAIDAR4"].ToString()),
                    TIPOLISTA = item["TIPOLISTA"].ToString(),
                    CODPRODPRODUCAO = item["CODPRODPRODUCAO"].ToString(),
                    FARMACIAPOPULAR = item["FARMACIAPOPULAR"].ToString(),
                    CFOPDENTROUF = item["CFOPDENTROUF"].ToString(),
                    CFOPFORAUF = item["CFOPFORAUF"].ToString(),
                    CODPRODPAI = item["CODPRODPAI"].ToString(),
                    CODFAMILIA = item["CODFAMILIA"].ToString(),
                    CODTIPOPRODUTO = item["CODTIPOPRODUTO"].ToString(),
                    CODPRODANP = item["CODPRODANP"].ToString(),
                    VERSION = Convert.ToDateTime(item["VERSION"].ToString()),
                    AGROTOXICO = item["AGROTOXICO"].ToString(),
                    CODIGOMAPA = item["CODIGOMAPA"].ToString(),
                    CODIGOEMBALAGEM = item["CODIGOEMBALAGEM"].ToString(),
                    ETQPRECOBASE = Convert.ToInt32(item["ETQPRECOBASE"].ToString()),
                    ETQPARCELAMENTO = Convert.ToInt32(item["ETQPARCELAMENTO"].ToString()),
                    ETQTXMES = Convert.ToDouble(item["ETQTXMES"].ToString()),
                    ETQINFTXMES = item["ETQINFTXMES"].ToString(),
                    ETQINFPRECOBASE = item["ETQINFPRECOBASE"].ToString(),
                    ETQINFPRECOAPRAZO = item["ETQINFPRECOAPRAZO"].ToString(),
                    ETQINFTXDIA = item["ETQINFTXDIA"].ToString(),
                    PERCIVASUBSTRIBSAIDA = Convert.ToDouble(item["PERCIVASUBSTRIBSAIDA"].ToString()),
                    PERCIVASUBSTRIBSAIDA1 = Convert.ToDouble(item["PERCIVASUBSTRIBSAIDA1"].ToString()),
                    PERCIVASUBSTRIBSAIDA2 = Convert.ToDouble(item["PERCIVASUBSTRIBSAIDA2"].ToString()),
                    PERCIVASUBSTRIBSAIDA3 = Convert.ToDouble(item["PERCIVASUBSTRIBSAIDA3"].ToString()),
                    PERCIVASUBSTRIBSAIDA4 = Convert.ToDouble(item["PERCIVASUBSTRIBSAIDA4"].ToString()),
                    IDPRODUTOJAVA = Convert.ToInt32(item["IDPRODUTOJAVA"].ToString()),
                    TIPOSINC = item["TIPOSINC"].ToString(),
                    IMPORTAPRODECOM = Convert.ToInt32(item["IMPORTAPRODECOM"].ToString()),
                    IDPRODUTOECOM = Convert.ToInt32(item["IDPRODUTOECOM"].ToString()),
                    IAT = item["IAT"].ToString(),
                    CODENQIPI = item["CODENQIPI"].ToString(),
                    CODNATRECEITA = item["CODNATRECEITA"].ToString(),
                    IDNATRECEITA = Convert.ToInt32(item["IDNATRECEITA"].ToString()),
                    CODCEST = item["CODCEST"].ToString(),
                    TIPOMATEREMBA = Convert.ToInt32(item["TIPOMATEREMBA"].ToString()),
                    IDPARCEIRO = Convert.ToInt32(item["IDPARCEIRO"].ToString()),
                    TIPOEQPREDUCAOBASEDIFAL = Convert.ToInt32(item["TIPOEQPREDUCAOBASEDIFAL"].ToString()),
                    CODSELFCOLOR = item["CODSELFCOLOR"].ToString(),
                    PERCENTDESCTOPROMOCAO = Convert.ToDouble(item["PERCENTDESCTOPROMOCAO"].ToString()),
                    CODSHOTCOLOR = item["CODSHOTCOLOR"].ToString()
                });
            }

            return users;
        }
        private static DataTable CreateDataTable()
        {
            DataTable dataTableP = new DataTable();
            try
            {
                FbConnection fbConnectionPrincipal = new FbConnection
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ToString()
                };
                FbConnection fbConnectionSecundaria = new FbConnection
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["strFirebirdSecundaria"].ToString()
                };

                FbDataAdapter fbDataAdapterPrimario = new FbDataAdapter("SELECT * FROM PRODUTO PRO WHERE PRO.CODPROD = '003117'", fbConnectionPrincipal);
                FbDataAdapter fbDataAdapterSecundario = new FbDataAdapter("SELECT * FROM PRODUTO PRO WHERE PRO.CODPROD = '003117'", fbConnectionSecundaria);

                DataTable dataTableS = new DataTable();

                fbDataAdapterPrimario.Fill(dataTableP);
                fbDataAdapterSecundario.Fill(dataTableS);

                dataTableP.Merge(dataTableS);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000000);
            }
            return dataTableP.AsEnumerable().Distinct().CopyToDataTable();

        }
    }
}
