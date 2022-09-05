using System;
using DesafioEngenho.Services;

namespace DesafioEngenho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique o range de numeros para verificar os multiplos de tres e cinco: ");

            string range = Console.ReadLine();

            try
            {
                int ConverRange = int.Parse(range);

                MultiplierService service = new MultiplierService();

                int resultado = service.VerificarMultiplosDeTresECinco(ConverRange);

                Console.WriteLine($"a soma dos multiplos de tres e cinco dado o range de {range}, é: {resultado}");
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
