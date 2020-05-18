using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._05._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Írjon egy programot, ami leosztályoz egy maximálisan 100 pontos dolgozatot 
            //az 50, 65, 80, 90 ponthatárok szerint! 
            //A határérték a jobb jegyhez tartozik. Ha a pontszám negatív vagy száznál nagyobb, 
            //akkor a program írja ki, hogy hibás az adat!
            Console.Write("Adjon meg egy egész számot 0 - 100 között: ");
            int pont = Convert.ToInt32(Console.ReadLine());
            if (pont > 100 || pont < 0)
            {
                Console.WriteLine("Hibás az adat!");
            }
            else
            {
                if (pont < 50)
                {
                    Console.WriteLine("A dolgozata elégtelen!");
                }
                else if(pont < 65)
                {
                    Console.WriteLine("A dolgozata elégséges!");
                }
                else if (pont < 80)
                {
                    Console.WriteLine("A dolgozata közepes!");
                }
                else if (pont < 90)
                {
                    Console.WriteLine("A dolgozata jó!");
                }
                else
                {
                    Console.WriteLine("A dolgozata jeles!");
                }
            }

            if (pont > 100 || pont < 0)
            {
                Console.WriteLine("Hibás az adat!");
            }
            else
            {
                if (pont >= 0 && pont <=49)
                {
                    Console.WriteLine("A dolgozata elégtelen!");
                }
                if (pont >= 50 && pont <= 64)
                {
                    Console.WriteLine("A dolgozata elégséges!");
                }
                if (pont >= 65 && pont <= 79)
                {
                    Console.WriteLine("A dolgozata közepes!");
                }
                if (pont >= 80 && pont <= 89)
                {
                    Console.WriteLine("A dolgozata jó!");
                }
                if(pont >= 90 && pont<=100)
                {
                    Console.WriteLine("A dolgozata jeles!");
                }
            }

            Console.ReadKey();
            
        }
    }
}
