using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abc";
            string result = StringHelper.ChangeFirstLetterCase(str);
            Console.WriteLine(str);
            Console.WriteLine(result);
            int[] a= new int[]{ -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };

           
            int rs=FindSmallestPositiveInteger.GetSmallestPositiveInteger2(a);
            Console.WriteLine(rs);

            

        }
    }
}
