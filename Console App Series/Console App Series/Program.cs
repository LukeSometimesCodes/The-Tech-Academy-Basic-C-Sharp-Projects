﻿using System;
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

            string[] finishTheLine = { "I", "couldn't", "think", "of", "a", "sentence", "that", "would", "make", "sense", };
            Console.WriteLine("Input some text and I'll shove it inbetween a sentence I already made");
            string inputText = Console.ReadLine();
            //Thought I would need this but guess not
            //int inputText1 = Int32.Parse(inputText);

            for (int i = 0; i < finishTheLine.Length; i++)
            {
                finishTheLine[i] += inputText;
            }
            for (int i = 0; i < finishTheLine.Length; i++)
            {
                Console.WriteLine(finishTheLine[i] + " " + inputText);
            }

            Console.ReadLine();



            //ASSIGNMENT PART TWO
            //INFINITE LOOP AND FIXING IT

            bool test1 = true;
            while (test1 == true)
            {
                Console.WriteLine("endless loop");
                //Commenting out test1 = false means it wil always be true, making it endless
                test1 = false;

            }


            //    //ASSIGNMENT PART 3
            //    //COMPARISON LOOP

            List<int> numbers = new List<int>();
            numbers.Add(20);
            numbers.Add(22);
            numbers.Add(23);
            numbers.Add(24);
            numbers.Add(25);
            numbers.Add(26);
            numbers.Add(26);
            numbers.Add(27);
            numbers.Add(28);
            numbers.Add(29);

            for (int i = 0; i < 26; i++)
                Console.WriteLine(i);
            Console.ReadLine();

            List<int> numbers1 = new List<int>();
            numbers1.Add(20);
            numbers1.Add(22);
            numbers1.Add(23);
            numbers1.Add(24);
            numbers1.Add(25);
            numbers1.Add(26);
            numbers1.Add(26);
            numbers1.Add(27);
            numbers1.Add(28);
            numbers1.Add(29);

            //same operation but will now include the 26
            for (int i = 0; i <= 26; i++)
                Console.WriteLine(i);

            Console.ReadLine();

            //ASSIGNMENT PART FOUR
            //NAME SEARCH


            Console.WriteLine("Name data base, type in a name to search for it");
            string nameChosen = Console.ReadLine();
            List<string> names = new List<string>() { "Luke", "Todd", "Kyson", "Kevin", "Jeremy", "John", "Derek", "Steve" };


            
            if (!names.Contains(nameChosen))
            {
                Console.WriteLine("The item you chose is not in the list");
                
            }
            else
            {
                for (int i = 0; i < names.Count; i++)
                {
                    if (nameChosen == names[i])
                    {
                        Console.WriteLine("Yes, it appears we have a " + nameChosen + " in the system at index " + i);

                        break;
                    }


                }
            }
            Console.ReadLine();
           

            //ASSIGNMENT PART 5
            //IDENTICAL NAME SEARCH

            Console.WriteLine("Name data base, type in a name to search for it");
            string nameChosen2 = Console.ReadLine();
            List<string> names2 = new List<string>() { "Luke", "Todd", "Kyson", "Luke", "Jeremy", "John", "Derek", "Steve" };

            if (!names2.Contains(nameChosen2))
            {
                Console.WriteLine("The item you chose is not in the list");

            }
            else
            {
                for (int i = 0; i < names2.Count; i++)
                {
                    if (nameChosen2 == names2[i])
                    {
                        Console.WriteLine("Yes, it appears we have a " + nameChosen2 + " in the system at index " + i);

                        
                    }


                }
            }
            Console.ReadLine();




            //ASSIGNMENT 6
            //DUPLICATE IN LIST


            List<string> names3 = new List<string>() { "Luke", "Todd", "Luke", "Jeremy", "John", "Derek", "Steve", "Kyson" };
            List<string> names4 = new List<string>() { };

            foreach (string name in names3)

            {
                if (names4.Contains(name))
                {
                    Console.WriteLine(name + "- We have multiple of this name");
                }

                else
                {
                    Console.WriteLine(name + " - This name is unique");
                }
                names4.Add(name);
            }
            Console.ReadLine();

        }
            
            }
        }
    


    
    

