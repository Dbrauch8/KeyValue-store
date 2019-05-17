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
            ListDisplay();
            Console.Clear();
            LinkedListDisplay();
            Console.Clear();
            QueueDisplay();
            Console.Clear();
            StackDisplay();
            Console.Clear();
            DictionaryDisplay();
            Console.Clear();
            SortedListDisplay();
            

        }

        private static void SortedListDisplay()
        {
            Console.WriteLine("SortedList, Round two let the race begin!");

            SortedList<string, int> places2 = new SortedList<string, int>() { { "Peach", 1 }, { "Koopa", 2 }, { "Bowser", 3 }, { "Luigi", 4 }, { "Mario", 5 } };

            foreach (var place in places2)
            {
                Console.WriteLine(place);
            }

            Console.ReadLine();
        }

        private static void DictionaryDisplay()
        {
            Console.WriteLine("Dictionary, Let the Race begin!");
            Dictionary<string, int> places = new Dictionary<string, int>() { { "Mario", 1 }, { "Luigi", 2 }, { "Peach", 3 }, { "Bowser", 4 }, { "Koopa", 5 } };

            foreach (var place in places)
            {
                Console.WriteLine(place);
            }

            Console.ReadLine();
        }

        private static void StackDisplay()
        {
            Console.WriteLine("Stack");
            Stack<int> builds = new Stack<int>();

            foreach (var build in new int[] { 1, 2, 3, 4, 5 })
            {
                builds.Push(build);
                Console.WriteLine($"{build} has been pushed on the stack!");
            }

            Console.WriteLine("\nThe stack contains");
            foreach (var build in builds)
            {
                Console.WriteLine(build);
            }

            Console.ReadLine();
        }

        private static void QueueDisplay()
        {
            Console.WriteLine("Queue");
            Queue<string> mario = new Queue<string>();

            foreach (var mari in new string[] { "Mario", "Luigi", "Peach", "Bowser", "Koopa" })
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

        private static void LinkedListDisplay()
        {
            Console.WriteLine("LinkedList");
            LinkedList<string> linkList = new LinkedList<string>();

            foreach (var link in new string[] { "one", "two", "three", "four", "five" })
            {
                linkList.AddLast(link);
            }

            foreach (var link in linkList)
            {
                Console.WriteLine(link);
            }
            Console.ReadLine();
        }

        private static void ListDisplay()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("List");

            foreach (var num in list)
            {

                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
