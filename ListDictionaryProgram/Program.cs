using System;
using System.Collections.Generic;

namespace ListDictionaryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ListProblem();
            DictionaryProblem();
        }

        //Problem #1 List
        public static void ListProblem()
        {
            List<string> people = new List<string>();

            string person = "";
            int number;

            do
            {
                Console.Write("Enter a name or press 'Enter' again to quit: ");
                person = Console.ReadLine();

                people.Add(person);

            } while (person != "");

            number = people.Count - 1;

            if (number == 0)
            {

            }
            else if (number == 1)
            {
                Console.WriteLine(people[0] + " likes your post.");
            }
            else if (number == 2)
            {
                Console.WriteLine(people[0] + " and " + people[1] + " like your post.");
            }
            else if (number == 3)
            {
                Console.WriteLine(people[0] + ", " + people[1] + " and " + (number - 2) + " other like your post.");
            }
            else
            {
                Console.WriteLine(people[0] + ", " + people[1] + " and " + (number - 2) + " others like your post.");
            }
        }

        public static void DictionaryProblem()
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            string userInput = "";

            Console.WriteLine("\nEnter a sentence:");
            userInput = Console.ReadLine();

            foreach(char i in userInput)
            {
                if (i == ' ')
                {

                }
                else if (letters.ContainsKey(i))
                {
                    letters[i] += 1;
                }
                else
                {
                    letters.Add(i, 1);
                }
            }

            foreach (KeyValuePair<char, int> kvp in letters)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }
        }
    }
}