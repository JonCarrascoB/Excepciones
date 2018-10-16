using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO 1:

            try
            {
                int num = 5 / Convert.ToInt32(Console.ReadLine());
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Has dividido el numero entre cero");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Has introducido una letra en vez de un numero");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
