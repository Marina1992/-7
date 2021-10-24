using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        { /*  Два треугольника заданы длинами своих сторон. 
           *  Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  
           *  Для решения задачи можно использовать формулу Герона   */
            
          
       
            
             double S= GetParam(8, 8, 8 );
            Console.WriteLine("Площадь 1 треугольника {0:f2}" ,S);

            double S1 = GetParam(15, 20, 10);
            Console.WriteLine("Площадь 2 треугольника {0:f2}", S1);

            if (S>S1)
            { Console.WriteLine("Площадь первого больше"); }

            else
            {
                { Console.WriteLine("Площадь второго  больше"); }
            }
            Console.ReadKey();

        }


        static double GetParam(int x, int y,  int z )
        {
            
           double P = (x + y + z) /2;
           double S =  (Math.Sqrt(P*(P-x)* (P - y) * (P - z))) ;
            return S;

        }
    }
}
