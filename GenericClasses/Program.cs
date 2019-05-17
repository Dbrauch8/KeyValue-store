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
         Console.ReadLine();


            Console.WriteLine("Queue");
         Queue<string> mario = new Queue<string>();

         foreach (var mari in new string[]{"Mario", "Luigi", "Peach", "Bowser", "Koopa"})
         {
           mario.Enqueue(mari);
           Console.WriteLine($"{mari} has joined the queue!");
         }
            Console.WriteLine("The queue contains:");
         foreach (var mari in mario)
         {
             Console.WriteLine(mari);
         }

         Console.ReadLine();



        }
    }
}
