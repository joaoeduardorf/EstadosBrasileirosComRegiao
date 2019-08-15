using EstadosBrasileirosComRegiao;
using System;

namespace ConsoleDotnetCore
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Regiões");
            foreach (var regiao in Regiao.Regioes)
            {
                ImprimirRegiao(regiao);
            }

            Console.WriteLine();
            Console.WriteLine("Estados com regiões");
            foreach (var estado in Estado.Estados)
            {
                ImprimirEstadoComRegiao(estado);
            }

            Console.WriteLine();
            Console.WriteLine("Estados por região ");
            foreach (var regiao in Regiao.Regioes)
            {
                Console.WriteLine(string.Format("Região: {0}", regiao.Nome));

                var estadosPorRegiao = Estado.EstadosPorRegiao(regiao);
                foreach (var estado in estadosPorRegiao)
                {
                    ImprimirEstado(estado);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }



        static void ImprimirRegiao(Regiao regiao) => Console.WriteLine(string.Format("{0}", regiao.Nome));

        static void ImprimirEstado(Estado estado) => Console.WriteLine(string.Format("{0} - {1}", estado.Nome, estado.Sigla));

        static void ImprimirEstadoComRegiao(Estado estado) => Console.WriteLine(string.Format("{0} - {1} - {2}", estado.Nome, estado.Sigla, estado.Regiao.Nome));
    }
}
