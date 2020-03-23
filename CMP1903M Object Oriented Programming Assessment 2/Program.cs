using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//NATHAN JONES
//CMP1903M OBJECT ORIENTED PROGRAMMING ASSESSMENT 2 
//MARCH 2020

namespace CMP1903M_Object_Oriented_Programming_Assessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] TXT_1A = System.IO.File.ReadAllLines(@"GitRepositories_1a.txt");           //READING THE FILE AND ALL OF ITS LINES AS A STRING 
            string[] TXT_1B = System.IO.File.ReadAllLines(@"GitRepositories_1b.txt");           //READING THE FILE AND ALL OF ITS LINES AS A STRING
            string[] TXT_2A = System.IO.File.ReadAllLines(@"GitRepositories_2a.txt");           //READING THE FILE AND ALL OF ITS LINES AS A STRING 
            string[] TXT_2B = System.IO.File.ReadAllLines(@"GitRepositories_2b.txt");           //READING THE FILE AND ALL OF ITS LINES AS A STRING 
            string[] TXT_3A = System.IO.File.ReadAllLines(@"GitRepositories_3a.txt");           //READING THE FILE AND ALL OF ITS LINES AS A STRING 
            string[] TXT_3B = System.IO.File.ReadAllLines(@"GitRepositories_3b.txt");           //READING THE FILE AND ALL OF ITS LINES AS A STRING 

            Console.WriteLine("Welcome To The C# Git Diff Function!");

            Console.WriteLine("What Text Files Would You Like To Compare?");
            Console.WriteLine("1. 1A & 1B");
            Console.WriteLine("2. 3A & 1B");
            Console.WriteLine("3. 1A & 2B");
            Console.WriteLine("4. 2A & 3B");

            string choice = Console.ReadLine();                                                

            if(choice == "1")
            {
                int count1 = 0;
                var Words1 = TXT_1A;
                string WordsSTR1 = String.Concat(Words1);
                char[] WordsCHAR1 = WordsSTR1.ToCharArray();
                bool prevIsLetter1 = false;
                foreach (char c in WordsCHAR1)
                {
                    bool isLetter = char.IsLetter(c);
                    if (isLetter && !prevIsLetter1)
                    {
                        count1++;
                    }
                    prevIsLetter1 = isLetter;
                }

                int count2 = 0;
                var Words2 = TXT_1B;
                string WordsSTR2 = String.Concat(Words2);
                char[] WordsCHAR2 = WordsSTR2.ToCharArray();
                bool prevIsLetter2 = false;
                foreach (char c in WordsCHAR2)
                {
                    bool isLetter = char.IsLetter(c);
                    if (isLetter && !prevIsLetter2)
                    {
                        count2++;
                    }
                    prevIsLetter2 = isLetter;
                }

                if (count1 == count2)
                {
                    Console.WriteLine("They Are The Same!");
                }

                if (count1 != count2)
                {
                    Console.WriteLine("They Are Different!");
                }
            }

            if (choice == "2")
            {
                int count1 = 0;
                var Words1 = TXT_3A;
                string WordsSTR1 = String.Concat(Words1);
                char[] WordsCHAR1 = WordsSTR1.ToCharArray();
                bool prevIsLetter1 = false;
                foreach (char c in WordsCHAR1)
                {
                    bool isLetter = char.IsLetter(c);
                    if (isLetter && !prevIsLetter1)
                    {
                        count1++;
                    }
                    prevIsLetter1 = isLetter;
                }

                int count2 = 0;
                var Words2 = TXT_1B;
                string WordsSTR2 = String.Concat(Words2);
                char[] WordsCHAR2 = WordsSTR2.ToCharArray();
                bool prevIsLetter2 = false;
                foreach (char c in WordsCHAR2)
                {
                    bool isLetter = char.IsLetter(c);
                    if (isLetter && !prevIsLetter2)
                    {
                        count2++;
                    }
                    prevIsLetter2 = isLetter;
                }

                if (count1 == count2)
                {
                    Console.WriteLine("They Are The Same!");
                }
                
                if(count1!=count2)
                {
                    Console.WriteLine("They Are Different!");
                }
            }

            if (choice == "3")
            {
                int count1 = 0;
                var Words1 = TXT_1A;
                string WordsSTR1 = String.Concat(Words1);
                char[] WordsCHAR1 = WordsSTR1.ToCharArray();
                bool prevIsLetter1 = false;
                foreach (char c in WordsCHAR1)
                {
                    bool isLetter = char.IsLetter(c);
                    if (isLetter && !prevIsLetter1)
                    {
                        count1++;
                    }
                    prevIsLetter1 = isLetter;
                }

                int count2 = 0;
                var Words2 = TXT_2B;
                string WordsSTR2 = String.Concat(Words2);
                char[] WordsCHAR2 = WordsSTR2.ToCharArray();
                bool prevIsLetter2 = false;
                foreach (char c in WordsCHAR2)
                {
                    bool isLetter = char.IsLetter(c);
                    if (isLetter && !prevIsLetter2)
                    {
                        count2++;
                    }
                    prevIsLetter2 = isLetter;
                }

                if (count1 == count2)
                {
                    Console.WriteLine("They Are The Same!");
                }
                if (count1 != count2)
                {
                    Console.WriteLine("They Are Different!");
                }
            }

            if (choice == "4")
            {
                int count1 = 0;
                var Words1 = TXT_2A;
                string WordsSTR1 = String.Concat(Words1);
                char[] WordsCHAR1 = WordsSTR1.ToCharArray();
                bool prevIsLetter1 = false;
                foreach (char c in WordsCHAR1)
                {
                    bool isLetter = char.IsLetter(c);
                    if (isLetter && !prevIsLetter1)
                    {
                        count1++;
                    }
                    prevIsLetter1 = isLetter;
                }

                int count2 = 0;
                var Words2 = TXT_3B;
                string WordsSTR2 = String.Concat(Words2);
                char[] WordsCHAR2 = WordsSTR2.ToCharArray();
                bool prevIsLetter2 = false;
                foreach (char c in WordsCHAR2)
                {
                    bool isLetter = char.IsLetter(c);
                    if (isLetter && !prevIsLetter2)
                    {
                        count2++;
                    }
                    prevIsLetter2 = isLetter;
                }

                if (count1 == count2)
                {
                    Console.WriteLine("They Are The Same!");
                }

                if (count1 != count2)
                {
                    Console.WriteLine("They Are Different!");
                }
            }
        }
    }
}
