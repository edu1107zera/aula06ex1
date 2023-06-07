using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.WriteLine("\nDigite um numero de 1 a 10.");
            numero = Int32.Parse(Console.ReadLine());
           
            if ((numero >= 1) & (numero <= 10))
            {
               
            }
            
            else
            {
                
                Console.WriteLine("\n//////Digite um numero valido//////");
                Console.Clear();
                Main(null);
                return;
              

            }
           

            Console.WriteLine("FIM DO PROGRAMA");
            Console.ReadKey();




        }
    }
}
