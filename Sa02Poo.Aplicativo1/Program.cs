using Sa02Poo.RegraDeNegocios1;
using System;

namespace Sa02Poo.Aplicativo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal v1, v2;
            Console.WriteLine("Qual o valor do primeiro avião?");
            v1 = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do segundo avião?");
            v2 = Decimal.Parse(Console.ReadLine());

            Aplicativo1RN app1 = new Aplicativo1RN();
            Console.WriteLine("Os aviões custam " + app1.somarDoisAvioes(v1, v2));
            Console.ReadKey();

            
        }
    }

}






