using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Character_15
{
    internal class Program
    {
       public static string removechar(string abc, int n)
        {
            return abc.Remove(n, 1);
        } 
        static void Main(string[] args)
        {
            Console.WriteLine(removechar("vinayrintu", 4));
            Console.WriteLine(removechar("ravula", 4));
            Console.WriteLine(removechar("pawankalyan", 1));
            Console.ReadLine();
        }
    }
}
