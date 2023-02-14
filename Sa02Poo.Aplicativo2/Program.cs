using System;
using Sa02Poo.RegraDeNegocios2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            int anoAtual;
            Console.WriteLine("Você sabe em qual ano foi criado o primeiro avião da Embraer?");
            resposta = Console.ReadLine();
            if(resposta == "Sim")
            {
                Console.WriteLine("Parabens!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Qual o ano atual?");
                anoAtual = int.Parse(Console.ReadLine());

                Aplicativo2RN app2 = new Aplicativo2RN();
                Console.WriteLine("O primeiro avião da embraer foi criado em 1968 há " + app2.diferença(anoAtual) );
                Console.ReadKey();
            }


        }
    }
}
