using System;
using System.IO;
using System.Linq;

namespace KataAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read each line of the file into a string array. Each element of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"Text.txt");
            
            int op = 0;
            string numberOfWord = string.Empty;
            do
            {
                Console.Write("Insert the number of words: ");
                numberOfWord = Console.ReadLine();
            } while (!int.TryParse(numberOfWord, out op));

            string[] input = new string[Convert.ToInt32(numberOfWord)];
       
            for (int i = 0; i < Convert.ToInt32(numberOfWord); i++) 
            {
                Console.Write($"Insert the words to search #{i+1}: ");
                input[i] = Console.ReadLine();
            }

            Console.WriteLine("\nAnagrams:\n");
            string word1;
            for (int i = 0; i < Convert.ToInt32(numberOfWord); i++) {

                word1 = input[i];
                char[] char1 = word1.ToLower().ToCharArray();
             
                Array.Sort(char1);
             
                string NewWord1 = new string(char1);

                string word;          
                foreach (string line in lines)
                {              
                    word = line.Trim();

                    if (word.Length == word1.Length)
                    {
                        char[] char2 = word.ToLower().ToCharArray();

                        Array.Sort(char2);

                        string NewWord2 = new string(char2);

                        if (NewWord1 == NewWord2)
                        {
                            Console.Write(word+" ");
                        }                   
                    }
                }
                Console.WriteLine();
            }

            //Hold Console screen alive to view the results.  
            Console.ReadLine();  
        
        }
    }
}
