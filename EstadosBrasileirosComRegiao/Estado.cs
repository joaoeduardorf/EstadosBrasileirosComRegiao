using System.Collections.Generic;
using System.Linq;

namespace EstadosBrasileirosComRegiao
{
    public class Estado
    {
        /// <summary>
        /// Nome do estado
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Sigla do estado
        /// </summary>
        public string Sigla { get; private set; }

        /// <summary>
        /// Região
        /// </summary>
        public Regiao Regiao { get; set; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sigla"></param>
        private Estado(string nome, string sigla, Regiao regiao) => (Nome, Sigla, Regiao) = (nome, sigla, regiao);

        /// <summary>
        ///Nome: Acre, Sigla: AC
        /// </summary>
        public static readonly Estado ACRE = new Estado("Acre", "AC", Regiao.NORTE);

        /// <summary>
        /// Nome: Alagoas, Sigla: AL
        /// </summary>
        public static readonly Estado ALAGOAS = new Estado("Alagoas", "AL", Regiao.NORDESTE);

        /// <summary>
        /// Nome: Amapá, Sigla: AP
        /// </summary>
        public static readonly Estado AMAPA = new Estado("Amapá", "AP", Regiao.NORTE);

        /// <summary>
        /// Nome: Amazonas, Sigla: AM
        /// </summary>
        public static readonly Estado AMAZONAS = new Estado("Amazonas", "AM", Regiao.NORTE);

        /// <summary>
        /// Nome: Bahia, Sigla: BA
        /// </summary>
        public static readonly Estado BAHIA = new Estado("Bahia", "BA", Regiao.NORDESTE);

        /// <summary>
        /// Nome: Ceará, Sigla: CE
        /// </summary>
        public static readonly Estado CEARA = new Estado("Ceará", "CE", Regiao.NORDESTE);

        /// <summary>
        /// Nome: Distrito Federal, Sigla: DF
        /// </summary>
        public static readonly Estado DISTRITOFEDERAL = new Estado("Distrito Federal", "DF", Regiao.CENTROOESTE);

        /// <summary>
        /// Nome: Espírito Santo, Sigla: ES
        /// </summary>
        public static readonly Estado ESPIRITOSANTO = new Estado("Espírito Santo", "ES", Regiao.SUDESTE);

        /// <summary>
        /// Nome: Goiás, Sigla: GO
        /// </summary>
        public static readonly Estado GOIAS = new Estado("Goiás", "GO", Regiao.CENTROOESTE);

        /// <summary>
        /// Nome: Maranhão, Sigla: MA
        /// </summary>
        public static readonly Estado MARANHAO = new Estado("Maranhão", "MA", Regiao.NORDESTE);

        /// <summary>
        /// Nome: Mato Grosso, Sigla: MT
        /// </summary>
        public static readonly Estado MATOGROSSO = new Estado("Mato Grosso", "MT", Regiao.CENTROOESTE);

        /// <summary>
        /// Nome: Mato Grosso do Sul, Sigla: MS
        /// </summary>
        public static readonly Estado MATOGROSSODOSUL = new Estado("Mato Grosso do Sul", "MS", Regiao.CENTROOESTE);

        /// <summary>
        /// Nome: Minas Gerais, Sigla: MG
        /// </summary>
        public static readonly Estado MINASGERAIS = new Estado("Minas Gerais", "MG", Regiao.SUDESTE);

        /// <summary>
        /// Nome: Pará, Sigla: PA
        /// </summary>
        public static readonly Estado PARA = new Estado("Pará", "PA", Regiao.NORTE);

        /// <summary>
        /// Nome: Paraíba, Sigla: PB
        /// </summary>
        public static readonly Estado PARAIBA = new Estado("Paraíba", "PB", Regiao.NORDESTE);

        /// <summary>
        /// Nome: Paraná, Sigla: PR
        /// </summary>
        public static readonly Estado PARANA = new Estado("Paraná", "PR", Regiao.SUL);

        /// <summary>
        /// Nome: Pernambuco, Sigla: PE
        /// </summary>
        public static readonly Estado PERNAMBUCO = new Estado("Pernambuco", "PE", Regiao.NORDESTE);

        /// <summary>
        /// Nome: Piauí, Sigla: PI
        /// </summary>
        public static readonly Estado PIAUI = new Estado("Piauí", "PI", Regiao.NORDESTE);

        /// <summary>
        /// Nome: Rio de Janeiro, Sigla: RJ
        /// </summary>
        public static readonly Estado RIODEJANEIRO = new Estado("Rio de Janeiro", "RJ", Regiao.SUDESTE);

        /// <summary>
        /// Nome: Rio Grande do Norte, Sigla: RN
        /// </summary>
        public static readonly Estado RIOGRANDEDONORTE = new Estado("Rio Grande do Norte", "RN", Regiao.NORDESTE);

        /// <summary>
        /// Nome: Rio Grande do Sul, Sigla: RS
        /// </summary>
        public static readonly Estado RIOGRANDEDOSUL = new Estado("Rio Grande do Sul", "RS", Regiao.SUL);

        /// <summary>
        /// Nome Rondônia, Silga: RO
        /// </summary>
        public static readonly Estado RONDONIA = new Estado("Rondônia", "RO", Regiao.NORTE);

        /// <summary>
        /// Nome: Roraima, Sigla: RO
        /// </summary>
        public static readonly Estado RORAIMA = new Estado("Roraima", "RR", Regiao.NORTE);

        /// <summary>
        /// Nome: Santa Catarina, Sigla: SC
        /// </summary>
        public static readonly Estado SANTACATARINA = new Estado("Santa Catarina", "SC", Regiao.SUL);

        /// <summary>
        /// Nome: São Paulo, Sigla: SP
        /// </summary>
        public static readonly Estado SAOPAULO = new Estado("São Paulo", "SP", Regiao.SUDESTE);

        /// <summary>
        /// Nome: Sergipe, Sigla: SE
        /// </summary>
        public static readonly Estado SERGIPE = new Estado("Sergipe", "SE", Regiao.NORDESTE);

        /// <summary>
        /// Nome: Tocantins, Sigla: TO
        /// </summary>
        public static readonly Estado TOCANTINS = new Estado("Tocantins", "TO", Regiao.NORTE);

        public static IEnumerable<Estado> Estados
        {
            get
            {
                yield return ACRE;
                yield return ALAGOAS;
                yield return AMAPA;
                yield return AMAZONAS;
                yield return BAHIA;
                yield return CEARA;
                yield return DISTRITOFEDERAL;
                yield return ESPIRITOSANTO;
                yield return GOIAS;
                yield return MARANHAO;
                yield return MATOGROSSO;
                yield return MATOGROSSODOSUL;
                yield return MINASGERAIS;
                yield return PARA;
                yield return PARAIBA;
                yield return PARANA;
                yield return PERNAMBUCO;
                yield return PIAUI;
                yield return RIODEJANEIRO;
                yield return RIOGRANDEDONORTE;
                yield return RIOGRANDEDOSUL;
                yield return RONDONIA;
                yield return RORAIMA;
                yield return SANTACATARINA;
                yield return SAOPAULO;
                yield return SERGIPE;
                yield return TOCANTINS;
            }
        }

        public static IEnumerable<Estado> EstadosPorRegiao(Regiao regiao) => Estados.Where(w => w.Regiao == regiao);
    }
}
