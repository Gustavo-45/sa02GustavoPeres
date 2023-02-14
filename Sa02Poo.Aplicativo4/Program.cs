using System;
using System.Collections.Generic;
using Sa02Poo.RegraDeNegocios4;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var i = 0;
            Aplicativo4RN app4 = new Aplicativo4RN();
            Console.WriteLine("Parabens você ganhou um premio de " + app4.premiacao(i) + " reais.");
            Console.ReadKey();

            
        }
    }
}
