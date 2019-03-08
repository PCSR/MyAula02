using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double xx = 0.12345;
            int ii = 18;
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
            Console.WriteLine("{0:f2}",xx);
            Console.WriteLine("{0:p1}", xx);
            Console.WriteLine("{0:c}", xx);
            Console.WriteLine("{0:x}", ii);
            Console.WriteLine("{0:c}", ii);
            Console.WriteLine($"{ii:c}");

            
        }
       
    }
}