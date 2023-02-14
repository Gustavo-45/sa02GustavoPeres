using System;
using System.Collections.Generic;
using Sa02Poo.RegraDeNegocios7;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal preco1, preco2, preco3, preco4, preco5;


            Console.WriteLine("Qual o valor da primeira peça ?");
            preco1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da segunda peça? ");
            preco2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da terceira peça? ");
            preco3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da quarta peça? ");
            preco4 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da quinta peça? ");
            preco5 = decimal.Parse(Console.ReadLine());

            Aplicativo7RN app7 = new Aplicativo7RN();
            Console.WriteLine("O valor total foi de " + app7.pecas(preco1, preco2, preco3, preco4, preco5));
            Console.ReadKey();
        }
    }
}
