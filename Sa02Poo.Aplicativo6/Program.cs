using System;
using Sa02Poo.RegraDeNegocios6;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precoUnitario, Frota;

            Console.WriteLine("Quantos aviões vai querer? ");
            Frota = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço unitario dos Aviões?");
            precoUnitario = decimal.Parse(Console.ReadLine());

            Aplicativo6RN app6 = new Aplicativo6RN();

            Console.Write("O preço total é "+ app6.calculo(precoUnitario, Frota));
            Console.ReadLine();
        }
    }
}
