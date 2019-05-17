using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
         List<int> list = new List<int>() {1, 2, 3, 4, 5};
         Console.WriteLine("List");
         foreach (var num in list)
         {
             
             Console.WriteLine(num);
         }

         Console.ReadLine();


         Console.WriteLine("LinkedList");
         LinkedList<string> linkList = new LinkedList<string>();

         foreach (var link in new string[] {"one", "two", "three", "four", "five"})
         {
             linkList.AddLast(link);
         }

         foreach (var link in linkList)
         {
             Console.WriteLine(link);
         }




        }
    }
}
