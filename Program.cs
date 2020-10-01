using System;

namespace Soma2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int digite; 
            int digite2; 
            int Soma;

            Console.Write("Digite o primeiro número:");
            digite = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o sengundo número:");
            digite2 = Convert.ToInt32(Console.ReadLine());
            Soma = digite + digite2; 
            Console.WriteLine($"{digite} + {digite2} = {Soma}"); 

            
    
             

        }
    }
}
