using System;
using Sa02Poo.RegraDeNegocios5;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal mes1;
            decimal mes2;
            decimal mes3;


            Console.WriteLine("Qual o faturameto da empresa no primeiro mês?");
            mes1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o faturameto da empresa no segundo mês?");
            mes2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o faturameto da empresa no terceiro mês?");
            mes3 = decimal.Parse(Console.ReadLine());

            Aplicativo5RN app5 = new Aplicativo5RN();
            Console.WriteLine("O faturamento trimestral foi de " + app5.trimestre(mes1, mes2,  mes3) + " reais.");
            Console.ReadKey();
        }
    }
}
