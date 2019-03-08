using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            float Volume;
            float Area;
            float pi = 3.1415926f;
            Console.WriteLine("Introduza o valor do raio: " );
            string raio = Console.ReadLine();
            float r = Convert.ToSingle(raio);
            Console.WriteLine("Introduza o valor da altura: ");
            string altura = Console.ReadLine();
            float a = Convert.ToSingle(altura);
            Volume = pi*r*r*a;
            Area = 2 * pi * r * (r + a);
            Console.WriteLine($"o Volume do cilindro é: {Volume:f3}");
            Console.WriteLine("A area do cilindro é: {0:f3}", Area);
        }
    }
}
