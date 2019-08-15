using System;
using System.Collections.Generic;

namespace EstadosBrasileirosComRegiao
{
    public class Regiao
    {
        /// <summary>
        /// Nome da região
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        private Regiao(string nome) => (Nome) = (nome);

        /// <summary>
        /// Região Centro-Oeste
        /// </summary>
        public static readonly Regiao CENTROOESTE = new Regiao("Centro-Oeste");

        /// <summary>
        /// Região Nordeste
        /// </summary>
        public static readonly Regiao NORDESTE = new Regiao("Nordeste");

        /// <summary>
        /// Região Norte
        /// </summary>
        public static readonly Regiao NORTE = new Regiao("Norte");

        /// <summary>
        /// Região Sudeste
        /// </summary>
        public static readonly Regiao SUDESTE = new Regiao("Sudeste");

        /// <summary>
        /// Região Sul
        /// </summary>
        public static readonly Regiao SUL = new Regiao("Sul");

        /// <summary>
        /// Todas as regiões
        /// </summary>
        public static IEnumerable<Regiao> Regioes
        {
            get
            {
                yield return CENTROOESTE;
                yield return NORDESTE;
                yield return NORTE;
                yield return SUDESTE;
                yield return SUL;
            }
        }
    }
}
