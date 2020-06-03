using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mirror_Word
{
    delegate string Mirror(string a);
    class Program
    {
        static void Main(string[] args)
        {
            Mirror a1 = delegate (string a)
            {
                char[] b = a.ToCharArray();
                Array.Reverse(b);
                return new string(b);
            };
            Console.WriteLine(a1("Hello world"));
            Console.WriteLine(a1("123"));
            
        }
    }
}
