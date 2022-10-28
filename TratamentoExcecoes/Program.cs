using System;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {    //Divisão por zero não é permitida!
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {    //Erro quando digitarmos letras ao invés de numeros
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}
