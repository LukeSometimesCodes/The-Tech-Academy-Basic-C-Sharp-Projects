using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Series
{
    class Program
    {
        static void Main()
        {
            ////ASSIGNMENT PART ONE

            //string[] finishTheLine = { "I", "couldn't", "think", "of", "a", "sentence", "that", "would", "make", "sense", };
            //Console.WriteLine("Input some text and I'll shove it inbetween a sentence I already made");
            //string inputText = Console.ReadLine();
            ////Thought I would need this but guess not
            ////int inputText1 = Int32.Parse(inputText);

            //for (int i = 0; i < finishTheLine.Length; i++)
            //{
            //    Console.WriteLine(finishTheLine[i] + " " + inputText);
            //}
            //Console.ReadLine();



            //ASSIGNMENT PART TWO
            //INFINITE LOOP AND FIXING IT
            //bool test1 = true;
            //while (test1 ==true)
            //{
            //    Console.WriteLine("All work no play makes jack a dull boy");
            //    //Commenting out test1 = false means it wil always be true, making it endless
            //    //test1 = false;
            //    Console.ReadLine();




            //ASSIGNMENT PART 3
            //COMPARISON LOOP

            //List<int> numbers = new List<int>();
            //numbers.Add(20);
            //numbers.Add(22);
            //numbers.Add(23);
            //numbers.Add(24);
            //numbers.Add(25);
            //numbers.Add(26);
            //numbers.Add(26);
            //numbers.Add(27);
            //numbers.Add(28);
            //numbers.Add(29);

            //foreach (int score in numbers)
            //{
            //    if (score < 26)
            //    {
            //        Console.WriteLine("test");
            //    }
            //}
            //Console.ReadLine();

            //List<int> numbers = new List<int>();
            //numbers.Add(20);
            //numbers.Add(22);
            //numbers.Add(23);
            //numbers.Add(24);
            //numbers.Add(25);
            //numbers.Add(26);
            //numbers.Add(26);
            //numbers.Add(27);
            //numbers.Add(28);
            //numbers.Add(29);

            ////same operation but will now include the 26
            //foreach (int score in numbers)
            //{
            //    if (score <= 26)
            //    {
            //        Console.WriteLine("test");
            //    }
            //}
            //Console.ReadLine();

            //ASSIGNMENT PART FOUR
            //NAME SEARCH


            //Console.WriteLine("Name data base, type in a name to search for it");
            //string nameChosen = Console.ReadLine();
            //List<string> names = new List<string>() { "Luke", "Todd", "Kyson", "Jeremy", "John", "Derek", "Steve"};

            //foreach (string name in names)
            //{
            //    if (name == nameChosen) // delete this to print all names out
            //    {
            //        Console.WriteLine("Yes, it appears we have a " + nameChosen + " in the system");
            //        break;
            //    }

            //    else if (name != nameChosen)
            //    {
            //        Console.WriteLine("Name is not in database, try again");
            //        break;
            //    }
            //}
            //Console.ReadLine();



            //ASSIGNMENT PART 5
            //IDENTICAL NAME SEARCH

            //Console.WriteLine("Name data base, type in a name to search for it");
            //string nameChosen = Console.ReadLine();
            //List<string> names = new List<string>() { "Luke", "Todd", "Luke", "Jeremy", "John", "Derek", "Steve", "Kyson"};

            //foreach (string name in names)
            //{
            //    if (name == nameChosen) // delete this to print all names out
            //    {
            //        Console.WriteLine("Yes, it appears we have a " + nameChosen + " in the system");
            //        Console.WriteLine("This name is in indice " + nameChosen.IndexOf(name));
                    
            //    }

            //    else if (name != nameChosen)
            //    {
            //        Console.WriteLine("Name is not in database, try again");
            //        continue;
            //    }
            //}
            //Console.ReadLine();


            //ASSIGNMENT 6
            //DUPLICATE IN LIST

            Console.WriteLine("Name data base, type in a name to search for it");
            string nameChosen = Console.ReadLine();
            List<string> names = new List<string>() { "Luke", "Todd", "Luke", "Jeremy", "John", "Derek", "Steve", "Kyson" };

            foreach (string name in names)
            {
                if (name == nameChosen)
                {
                    Console.WriteLine(name + "- We have multiple of this name");
                }

                else if (name != nameChosen)
                {
                    Console.WriteLine(name + " - This name is unique");
                }


            }
            Console.ReadLine();
        }

    }
}
