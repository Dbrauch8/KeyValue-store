using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
         List<int> list = new List<int>() {1, 2, 3, 4, 5};

         foreach (var num in list)
         {
             Console.WriteLine(num);
         }



        }
    }
}
