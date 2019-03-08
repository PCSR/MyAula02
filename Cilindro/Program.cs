using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double Volume;
            double Area;
            double Volume2;
            float pi = 3.1415926f;
            Console.WriteLine("Introduza o valor do raio: " );
            string raio = Console.ReadLine();
            //Converte string recebida pelo utilizador num float
            float r = Convert.ToSingle(raio);
            Console.WriteLine("Introduza o valor da altura: ");
            string altura = Console.ReadLine();
            //Converte string recebida pelo utilizador num float
            float a = Convert.ToSingle(altura);
            Volume = pi*r*r*a;
            Console.WriteLine($"O Volume do cilindro é: {Volume:f3}");
            Area = 2 * pi * r * (r + a);
            Console.WriteLine("A Area do cilindro é: {0:f3}", Area);
            //Volume usando Math.PI e Math.Pow em vez de pi e r*r
            Volume2 = Math.PI * Math.Pow(r,2)*a;
            Console.WriteLine($"O Volume do cilindro é: {Volume2:f3}");
            
        }
    }
}
