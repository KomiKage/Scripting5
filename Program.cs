using System;
using System.Collections.Generic;

namespace Scripting5
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            #region variables

            string item;

            #endregion



            #region part 1

            var monkeys = new List<string>() { "George Monkey", "John F. Monkey", "Joe Monkey", "Donald Monkey", "Barack Monkey" };
            var hunters = new List<string>() { "Assasin Monkey", "Sniper Monkey", "Crazy Monkey" };

            void part1()
            {

                hunters.AddRange(monkeys);
                for (int i = 0; i < hunters.Count; i++)
                {
                    Console.WriteLine(hunters[i]);
                }

                Console.WriteLine("");
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                part2();

            }
            #endregion

            #region part 2

            void part2()
            {

                Console.WriteLine("Please enter an item...");
                Console.WriteLine("");
                item = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Does the list contain " + item + " : " + hunters.Contains("donkey"));
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                part3();

            }

            #endregion

            #region part 3

            void part3()
            {
                Console.WriteLine("A random item has been removed from the list.");
                Console.WriteLine("");
                int random = rnd.Next(1, hunters.Count);
                hunters.RemoveAt(random);
                hunters.Sort();

                for (int i = 0; i < hunters.Count; i++)
                {
                    Console.WriteLine(hunters[i]);
                }

                Console.WriteLine("");
                Console.WriteLine("Press any ket to continue...");
                Console.ReadKey();
                Console.Clear();
                part4();
            }

            #endregion

            #region part 4

            void part4()
            {

                int monkey = hunters.Count - 5;

                hunters.RemoveRange(4, monkey);

                hunters.Reverse();

                Console.WriteLine("Monkeys have been removed");

                for (int i = 0; i < hunters.Count; i++)
                {
                    Console.WriteLine(hunters[i]);
                }

            }

            #endregion

            part1();
        }
    }
}
