using System;
using System.Collections.Generic;
using Sa02Poo.RegraDeNegocios3;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int avioes;
            Console.WriteLine("Quantos aviões você tem?");
            avioes = int.Parse(Console.ReadLine());

            Aplicativo3RN app3 = new Aplicativo3RN();
            Console.WriteLine("Você tem " + app3.multiplicar(avioes) + " assentos.");
            Console.ReadKey();
        }
    }
}
