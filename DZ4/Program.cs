using System;

namespace DZ4
{
    class Program
    {
        private static object names;

        enum Months { Jenyary=1, February, March, April, May, June, Julie, August, September, Octomber, November, December }
       
        enum Seasons { Autun=1, Winter, Spring, Summer }
        static void Main(string[] args)
        {
        Start:

            Console.WriteLine("Введите номер месяца");
            int mothsNumbers = int.Parse(Console.ReadLine());
            if (mothsNumbers < 1 | mothsNumbers > 12)
            {
                Console.WriteLine("Вы ввели неверный номер");
                goto Start;
            }
            else
            {
                Console.WriteLine("Это {0}", ((Months)mothsNumbers).ToString());
                if (mothsNumbers > 2 && mothsNumbers < 6 )
                {
                    Console.WriteLine("Весна");
                }
                else if (mothsNumbers > 5 && mothsNumbers < 9)
                {
                    Console.WriteLine("Лето");
                }
                else if (mothsNumbers > 8 && mothsNumbers < 12)
                {
                    Console.WriteLine("Осень");
                }
                else
                {
                    Console.WriteLine("Зима" );
                }
            }
            Console.ReadKey();
            
   
            
        }   
    }
}
