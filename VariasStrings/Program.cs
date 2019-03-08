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
            string d = "123" + a;
            string e = $"{a} mais {c}";
            string f= String.Format("a e' {0}, e b e' {1}", a, b);


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(@"Verbatim com a = {0}", a);
        }
    }
}