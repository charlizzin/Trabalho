using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorDados
{
    public class Produto
    {
        [MapFieldName("CODPROD")]
        public string CODPROD { get; set; }
        [MapFieldName("ATIVO")]
        public string ATIVO { get; set; }
        [MapFieldName("REFERENCIA")]
        public string REFERENCIA { get; set; }
        [MapFieldName("REFFABRICANTE")]
        public string REFFABRICANTE { get; set; }
        [MapFieldName("DESCRICAO")]
        public string DESCRICAO { get; set; }
        [MapFieldName("DESCRICAO2")]
        public string DESCRICAO2 { get; set; }
        [MapFieldName("DESCRICAO3")]
        public string DESCRICAO3 { get; set; }
        [MapFieldName("CODGRUPO")]
        public string CODGRUPO { get; set; }
        [MapFieldName("CODSUBGRUPO")]
        public string CODSUBGRUPO { get; set; }
        [MapFieldName("TIPOPROD")]
        public string TIPOPROD { get; set; }
        [MapFieldName("ESTMINIMO")]
        public double ESTMINIMO { get; set; }
        [MapFieldName("DIASESTMINIMO")]
        public int DIASESTMINIMO { get; set; }
        [MapFieldName("ESTMAXIMO")]
        public double ESTMAXIMO { get; set; }
        [MapFieldName("DIASESTMAXIMO")]
        public int DIASESTMAXIMO { get; set; }
        [MapFieldName("CODCLASFIS")]
        public string CODCLASFIS { get; set; }
        [MapFieldName("ALIQIPI")]
        public double ALIQIPI { get; set; }
        [MapFieldName("ALIQISS")]
        public double ALIQISS { get; set; }
        [MapFieldName("ALIQICMSREG00")]
        public double ALIQICMSREG00 { get; set; }
        [MapFieldName("BASEICMSREG00")]
        public double BASEICMSREG00 { get; set; }
        [MapFieldName("CODTRIBUT00")]
        public string CODTRIBUT00 { get; set; }
        [MapFieldName("MENSAGEM00")]
        public string MENSAGEM00 { get; set; }
        [MapFieldName("ALIQICMSREG01")]
        public double ALIQICMSREG01 { get; set; }
        [MapFieldName("BASEICMSREG01")]
        public double BASEICMSREG01 { get; set; }
        [MapFieldName("CODTRIBUT01")]
        public string CODTRIBUT01 { get; set; }
        [MapFieldName("MENSAGEM01")]
        public string MENSAGEM01 { get; set; }
        [MapFieldName("ALIQICMSREG02")]
        public double ALIQICMSREG02 { get; set; }
        [MapFieldName("BASEICMSREG02")]
        public double BASEICMSREG02 { get; set; }
        [MapFieldName("CODTRIBUT02")]
        public string CODTRIBUT02 { get; set; }
        [MapFieldName("MENSAGEM02")]
        public string MENSAGEM02 { get; set; }
        [MapFieldName("ALIQICMSREG03")]
        public double ALIQICMSREG03 { get; set; }
        [MapFieldName("BASEICMSREG03")]
        public double BASEICMSREG03 { get; set; }
        [MapFieldName("CODTRIBUT03")]
        public string CODTRIBUT03 { get; set; }
        [MapFieldName("MENSAGEM03")]
        public string MENSAGEM03 { get; set; }
        [MapFieldName("SUBSTRIB")]
        public string SUBSTRIB { get; set; }
        [MapFieldName("LUCROSUBSTRIB")]
        public double LUCROSUBSTRIB { get; set; }
        [MapFieldName("COMISSAO")]
        public double COMISSAO { get; set; }
        [MapFieldName("EMBALAGEM")]
        public string EMBALAGEM { get; set; }
        [MapFieldName("CODLOCAL")]
        public string CODLOCAL { get; set; }
        [MapFieldName("CODFABRIC")]
        public string CODFABRIC { get; set; }
        [MapFieldName("PESO")]
        public double PESO { get; set; }
        [MapFieldName("UNIDADEENT")]
        public string UNIDADEENT { get; set; }
        [MapFieldName("UNIDADESAIDA")]
        public string UNIDADESAIDA { get; set; }
        [MapFieldName("FATORCONVERSAO")]
        public double FATORCONVERSAO { get; set; }
        [MapFieldName("MULTDIVIDE")]
        public string MULTDIVIDE { get; set; }
        [MapFieldName("PR_ULT_ENT1")]
        public double PR_ULT_ENT1 { get; set; }
        [MapFieldName("DATA_ULT_ENT1")]
        public DateTime DATA_ULT_ENT1 { get; set; }
        [MapFieldName("QUANT_ULT_ENT1")]
        public double QUANT_ULT_ENT1 { get; set; }
        [MapFieldName("FORNEC_ULT_ENT1")]
        public string FORNEC_ULT_ENT1 { get; set; }
        [MapFieldName("PR_ULT_ENT2")]
        public double PR_ULT_ENT2 { get; set; }
        [MapFieldName("DATA_ULT_ENT2")]
        public DateTime DATA_ULT_ENT2 { get; set; }
        [MapFieldName("QUANT_ULT_ENT2")]
        public double QUANT_ULT_ENT2 { get; set; }
        [MapFieldName("FORNEC_ULT_ENT2")]
        public string FORNEC_ULT_ENT2 { get; set; }
        [MapFieldName("PR_ULT_ENT3")]
        public double PR_ULT_ENT3 { get; set; }
        [MapFieldName("DATA_ULT_ENT3")]
        public DateTime DATA_ULT_ENT3 { get; set; }
        [MapFieldName("QUANT_ULT_ENT3")]
        public double QUANT_ULT_ENT3 { get; set; }
        [MapFieldName("FORNEC_ULT_ENT3")]
        public string FORNEC_ULT_ENT3 { get; set; }
        [MapFieldName("DVV")]
        public double DVV { get; set; }
        [MapFieldName("LUCRO")]
        public double LUCRO { get; set; }
        [MapFieldName("SUGESTAO")]
        public double SUGESTAO { get; set; }
        [MapFieldName("PRECO")]
        public double PRECO { get; set; }
        [MapFieldName("PRODBLOQUEADO")]
        public string PRODBLOQUEADO { get; set; }
        [MapFieldName("CAMPOLIVRE1")]
        public string CAMPOLIVRE1 { get; set; }
        [MapFieldName("CAMPOLIVRE2")]
        public string CAMPOLIVRE2 { get; set; }
        [MapFieldName("CAMPOLIVRE3")]
        public string CAMPOLIVRE3 { get; set; }
        [MapFieldName("CAMPOLIVRE4")]
        public string CAMPOLIVRE4 { get; set; }
        [MapFieldName("PRINCIPALFORNEC")]
        public string PRINCIPALFORNEC { get; set; }
        [MapFieldName("NOTA_ULT_ENT1")]
        public string NOTA_ULT_ENT1 { get; set; }
        [MapFieldName("NOTA_ULT_ENT2")]
        public string NOTA_ULT_ENT2 { get; set; }
        [MapFieldName("NOTA_ULT_ENT3")]
        public string NOTA_ULT_ENT3 { get; set; }
        [MapFieldName("CONTROLESERIE")]
        public string CONTROLESERIE { get; set; }
        [MapFieldName("CODPRODBAIXA")]
        public string CODPRODBAIXA { get; set; }
        [MapFieldName("FATORCONVBAIXA")]
        public double FATORCONVBAIXA { get; set; }
        [MapFieldName("MULTDIVBAIXA")]
        public string MULTDIVBAIXA { get; set; }
        [MapFieldName("CODFRETE")]
        public string CODFRETE { get; set; }
        [MapFieldName("DT_CADASTRO")]
        public DateTime DT_CADASTRO { get; set; }
        [MapFieldName("DESCRICAOPRECO")]
        public string DESCRICAOPRECO { get; set; }
        [MapFieldName("PRECO2")]
        public double PRECO2 { get; set; }
        [MapFieldName("DESCRICAOPRECO2")]
        public string DESCRICAOPRECO2 { get; set; }
        [MapFieldName("PRECO3")]
        public double PRECO3 { get; set; }
        [MapFieldName("DESCRICAOPRECO3")]
        public string DESCRICAOPRECO3 { get; set; }
        [MapFieldName("LUCRO2")]
        public double LUCRO2 { get; set; }
        [MapFieldName("LUCRO3")]
        public double LUCRO3 { get; set; }
        [MapFieldName("ITEMPORTARIA790")]
        public string ITEMPORTARIA790 { get; set; }
        [MapFieldName("ENVIADO")]
        public string ENVIADO { get; set; }
        [MapFieldName("PRECODOLAR")]
        public double PRECODOLAR { get; set; }
        [MapFieldName("DATA_ULT_ALTERACAO")]
        public DateTime DATA_ULT_ALTERACAO { get; set; }
        [MapFieldName("PERCPERDA")]
        public double PERCPERDA { get; set; }
        [MapFieldName("PRECOPROMO")]
        public double PRECOPROMO { get; set; }
        [MapFieldName("DATAINIPROMO")]
        public DateTime DATAINIPROMO { get; set; }
        [MapFieldName("DATAFIMPROMO")]
        public DateTime DATAFIMPROMO { get; set; }
        [MapFieldName("SUBSTRIBSAIDA")]
        public string SUBSTRIBSAIDA { get; set; }
        [MapFieldName("PERCBASESUBSTRIBSAIDA")]
        public double PERCBASESUBSTRIBSAIDA { get; set; }
        [MapFieldName("PERCICMSSUBSTRIBSAIDA")]
        public double PERCICMSSUBSTRIBSAIDA { get; set; }
        [MapFieldName("TEMSUBITENS")]
        public string TEMSUBITENS { get; set; }
        [MapFieldName("CODSEGMENTOSUBTRIBSAIDA")]
        public string CODSEGMENTOSUBTRIBSAIDA { get; set; }
        [MapFieldName("ALIQICMSDIVERSOS")]
        public double ALIQICMSDIVERSOS { get; set; }
        [MapFieldName("BASEICMSDIVERSOS")]
        public double BASEICMSDIVERSOS { get; set; }
        [MapFieldName("CODTRIBUTDIVERSOS")]
        public string CODTRIBUTDIVERSOS { get; set; }
        [MapFieldName("MENSAGEMDIVERSOS")]
        public string MENSAGEMDIVERSOS { get; set; }
        [MapFieldName("TIPODIVERSOS")]
        public string TIPODIVERSOS { get; set; }
        [MapFieldName("CONTACXA")]
        public string CONTACXA { get; set; }
        [MapFieldName("PERCICMMARGEMLUCRO")]
        public double PERCICMMARGEMLUCRO { get; set; }
        [MapFieldName("ALIQINTERNAICMLUCRO")]
        public double ALIQINTERNAICMLUCRO { get; set; }
        [MapFieldName("SEGMENTOICMLUCRO")]
        public string SEGMENTOICMLUCRO { get; set; }
        [MapFieldName("SEGMENTOICMDIVERSOS")]
        public string SEGMENTOICMDIVERSOS { get; set; }
        [MapFieldName("ALIQICMSDIVERSOS2")]
        public double ALIQICMSDIVERSOS2 { get; set; }
        [MapFieldName("BASEICMSDIVERSOS2")]
        public double BASEICMSDIVERSOS2 { get; set; }
        [MapFieldName("CODTRIBUTDIVERSOS2")]
        public string CODTRIBUTDIVERSOS2 { get; set; }
        [MapFieldName("MENSAGEMDIVERSOS2")]
        public string MENSAGEMDIVERSOS2 { get; set; }
        [MapFieldName("CONTROLELOTE")]
        public string CONTROLELOTE { get; set; }
        [MapFieldName("GRADE")]
        public int GRADE { get; set; }
        [MapFieldName("ACEITAPRECOZERO")]
        public string ACEITAPRECOZERO { get; set; }
        [MapFieldName("VLRCOBRAROPER")]
        public double VLRCOBRAROPER { get; set; }
        [MapFieldName("COMISSAOVLR")]
        public double COMISSAOVLR { get; set; }
        [MapFieldName("GARANTIA")]
        public int GARANTIA { get; set; }
        [MapFieldName("IPIANTIGO")]
        public double IPIANTIGO { get; set; }
        [MapFieldName("CUSTODOLAR")]
        public double CUSTODOLAR { get; set; }
        [MapFieldName("ALIQICMSPDV")]
        public double ALIQICMSPDV { get; set; }
        [MapFieldName("TEMREBATEFINANC")]
        public string TEMREBATEFINANC { get; set; }
        [MapFieldName("LUCRO4")]
        public double LUCRO4 { get; set; }
        [MapFieldName("DESCRICAOPRECO4")]
        public string DESCRICAOPRECO4 { get; set; }
        [MapFieldName("PRECO4")]
        public double PRECO4 { get; set; }
        [MapFieldName("PRODBALANCA")]
        public string PRODBALANCA { get; set; }
        [MapFieldName("SUBSTRIBSAIDAR1")]
        public string SUBSTRIBSAIDAR1 { get; set; }
        [MapFieldName("PERCBASESUBSTRIBSAIDAR1")]
        public double PERCBASESUBSTRIBSAIDAR1 { get; set; }
        [MapFieldName("PERCICMSSUBSTRIBSAIDAR1")]
        public double PERCICMSSUBSTRIBSAIDAR1 { get; set; }
        [MapFieldName("SUBSTRIBSAIDAR2")]
        public string SUBSTRIBSAIDAR2 { get; set; }
        [MapFieldName("PERCBASESUBSTRIBSAIDAR2")]
        public double PERCBASESUBSTRIBSAIDAR2 { get; set; }
        [MapFieldName("PERCICMSSUBSTRIBSAIDAR2")]
        public double PERCICMSSUBSTRIBSAIDAR2 { get; set; }
        [MapFieldName("SUBSTRIBSAIDAR3")]
        public string SUBSTRIBSAIDAR3 { get; set; }
        [MapFieldName("PERCBASESUBSTRIBSAIDAR3")]
        public double PERCBASESUBSTRIBSAIDAR3 { get; set; }
        [MapFieldName("PERCICMSSUBSTRIBSAIDAR3")]
        public double PERCICMSSUBSTRIBSAIDAR3 { get; set; }
        [MapFieldName("DESCONTOMAXIMO")]
        public double DESCONTOMAXIMO { get; set; }
        [MapFieldName("TIPOMEDICAMENTO")]
        public int TIPOMEDICAMENTO { get; set; }
        [MapFieldName("DESCPERCPADRAO")]
        public double DESCPERCPADRAO { get; set; }
        [MapFieldName("LUCROPREVISTO")]
        public double LUCROPREVISTO { get; set; }
        [MapFieldName("REDUTOR")]
        public double REDUTOR { get; set; }
        [MapFieldName("ITEMPORTARIAFORAUF")]
        public string ITEMPORTARIAFORAUF { get; set; }
        [MapFieldName("DATA_ULT_REAJUSTE")]
        public DateTime DATA_ULT_REAJUSTE { get; set; }
        [MapFieldName("PRECO_ANTERIOR")]
        public double PRECO_ANTERIOR { get; set; }
        //[MapFieldName("OBSERVACAO")]
        //public string OBSERVACAO { get; set; }
        [MapFieldName("CODVOLUME")]
        public string CODVOLUME { get; set; }
        [MapFieldName("FRACIONADO")]
        public string FRACIONADO { get; set; }
        [MapFieldName("CODGENEROITEM")]
        public string CODGENEROITEM { get; set; }
        [MapFieldName("CUSTOOPERC")]
        public double CUSTOOPERC { get; set; }
        [MapFieldName("PERC_IVA")]
        public double PERC_IVA { get; set; }
        [MapFieldName("VALORIPI")]
        public double VALORIPI { get; set; }
        [MapFieldName("TIPOENTREGA")]
        public string TIPOENTREGA { get; set; }
        [MapFieldName("LIMINILOTEENTREGA")]
        public double LIMINILOTEENTREGA { get; set; }
        [MapFieldName("LIMFIMLOTEENTREGA")]
        public double LIMFIMLOTEENTREGA { get; set; }
        [MapFieldName("CONSIDERACOMISSAO")]
        public string CONSIDERACOMISSAO { get; set; }
        [MapFieldName("MULTIPLO")]
        public double MULTIPLO { get; set; }
        [MapFieldName("UNIDADEMULTIPLO")]
        public string UNIDADEMULTIPLO { get; set; }
        [MapFieldName("SUBSTRIBSAIDAR4")]
        public string SUBSTRIBSAIDAR4 { get; set; }
        [MapFieldName("PERCBASESUBSTRIBSAIDAR4")]
        public double PERCBASESUBSTRIBSAIDAR4 { get; set; }
        [MapFieldName("PERCICMSSUBSTRIBSAIDAR4")]
        public double PERCICMSSUBSTRIBSAIDAR4 { get; set; }
        [MapFieldName("TIPOLISTA")]
        public string TIPOLISTA { get; set; }
        [MapFieldName("CODPRODPRODUCAO")]
        public string CODPRODPRODUCAO { get; set; }
        [MapFieldName("FARMACIAPOPULAR")]
        public string FARMACIAPOPULAR { get; set; }
        [MapFieldName("CFOPDENTROUF")]
        public string CFOPDENTROUF { get; set; }
        [MapFieldName("CFOPFORAUF")]
        public string CFOPFORAUF { get; set; }
        [MapFieldName("CODPRODPAI")]
        public string CODPRODPAI { get; set; }
        [MapFieldName("CODFAMILIA")]
        public string CODFAMILIA { get; set; }
        [MapFieldName("CODTIPOPRODUTO")]
        public string CODTIPOPRODUTO { get; set; }
        [MapFieldName("CODPRODANP")]
        public string CODPRODANP { get; set; }
        [MapFieldName("VERSION")]
        public DateTime VERSION { get; set; }
        [MapFieldName("AGROTOXICO")]
        public string AGROTOXICO { get; set; }
        [MapFieldName("CODIGOMAPA")]
        public string CODIGOMAPA { get; set; }
        [MapFieldName("CODIGOEMBALAGEM")]
        public string CODIGOEMBALAGEM { get; set; }
        [MapFieldName("ETQPRECOBASE")]
        public int ETQPRECOBASE { get; set; }
        [MapFieldName("ETQPARCELAMENTO")]
        public int ETQPARCELAMENTO { get; set; }
        [MapFieldName("ETQTXMES")]
        public double ETQTXMES { get; set; }
        [MapFieldName("ETQINFTXMES")]
        public string ETQINFTXMES { get; set; }
        [MapFieldName("ETQINFPRECOBASE")]
        public string ETQINFPRECOBASE { get; set; }
        [MapFieldName("ETQINFPRECOAPRAZO")]
        public string ETQINFPRECOAPRAZO { get; set; }
        [MapFieldName("ETQINFTXDIA")]
        public string ETQINFTXDIA { get; set; }
        [MapFieldName("PERCIVASUBSTRIBSAIDA")]
        public double PERCIVASUBSTRIBSAIDA { get; set; }
        [MapFieldName("PERCIVASUBSTRIBSAIDA1")]
        public double PERCIVASUBSTRIBSAIDA1 { get; set; }
        [MapFieldName("PERCIVASUBSTRIBSAIDA2")]
        public double PERCIVASUBSTRIBSAIDA2 { get; set; }
        [MapFieldName("PERCIVASUBSTRIBSAIDA3")]
        public double PERCIVASUBSTRIBSAIDA3 { get; set; }
        [MapFieldName("PERCIVASUBSTRIBSAIDA4")]
        public double PERCIVASUBSTRIBSAIDA4 { get; set; }
        [MapFieldName("IDPRODUTOJAVA")]
        public int IDPRODUTOJAVA { get; set; }
        [MapFieldName("TIPOSINC")]
        public string TIPOSINC { get; set; }
        [MapFieldName("IMPORTAPRODECOM")]
        public int IMPORTAPRODECOM { get; set; }
        [MapFieldName("IDPRODUTOECOM")]
        public int IDPRODUTOECOM { get; set; }
        [MapFieldName("IAT")]
        public string IAT { get; set; }
        [MapFieldName("CODENQIPI")]
        public string CODENQIPI { get; set; }
        [MapFieldName("CODNATRECEITA")]
        public string CODNATRECEITA { get; set; }
        [MapFieldName("IDNATRECEITA")]
        public int IDNATRECEITA { get; set; }
        [MapFieldName("CODCEST")]
        public string CODCEST { get; set; }
        [MapFieldName("TIPOMATEREMBA")]
        public int TIPOMATEREMBA { get; set; }
        [MapFieldName("IDPARCEIRO")]
        public int IDPARCEIRO { get; set; }
        [MapFieldName("TIPOEQPREDUCAOBASEDIFAL")]
        public int TIPOEQPREDUCAOBASEDIFAL { get; set; }
        [MapFieldName("CODSELFCOLOR")]
        public string CODSELFCOLOR { get; set; }
        [MapFieldName("PERCENTDESCTOPROMOCAO")]
        public double PERCENTDESCTOPROMOCAO { get; set; }
        [MapFieldName("CODSHOTCOLOR")]
        public string CODSHOTCOLOR { get; set; }
    }
}
