using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string a = "\"String 1\"";
            string b = @"\String 2\";
            string c = @"""String 3""";


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
