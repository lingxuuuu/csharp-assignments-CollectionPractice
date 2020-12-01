using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array to hold integer values 0 through 9
            int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(numArray[0]);

            int[] numArray2 = new int[10];
            for (int i = 0; i < numArray2.Length; i++)
            {
                numArray2[i] = i;
            }
            Console.WriteLine(numArray2.Length);
            Console.WriteLine(numArray2[0]);

            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] myString = { "Tim", "Martin", "Nikki", "Sara" };
            Console.WriteLine(myString[0]);


            //Create an array of length 10 that alternates between true and false values, starting with true
            bool[] myArray = new bool[10];
            for (int i = 0; i < myArray.Length; i += 2)
            {
                myArray[i] = true;
            }
            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[1]);
            Console.WriteLine(myArray.Length);


            //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("chocolate");
            flavors.Add("valina");
            flavors.Add("coffee");
            flavors.Add("strawberry");
            flavors.Add("cherry");
            //Output the length of this list after building it .Count instead of .Length
            Console.WriteLine(flavors.Count);
            //Output the third flavor in the list, then remove this value
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            //Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(flavors.Count);


            //Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> profile = new Dictionary<string, string>();
            foreach (var name in myString)
            {
                profile.Add(name, null);
            }
            Random rand = new Random();
            foreach (var name in myString)
            {
                int randInx = rand.Next(flavors.Count);
                profile[name] = flavors[randInx];
            }
            foreach (var entry in profile)
            {
                Console.WriteLine("{0}'s favorite flavor is {1}", entry.Key, entry.Value);
            }


        }
    }
}
