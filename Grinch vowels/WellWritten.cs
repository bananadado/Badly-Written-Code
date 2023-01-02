using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.IO;
//using System.AnnoyTim;

namespace Grinch_Vowels
{
    internal class Program
    {//i dont apologais
        static void Main(string[] args)
        {
            var vowels = new char[5] { 'u', 'e', 'i', 'o', 'a' }.ToList();                                  /*# This creates a char[] array which is now a list because the .reverse wasn't working and also yhes*/  
            vowels.Reverse(); //So that it is in the "correct" order for you except not quite. .Reverse swaps the order of the elements in the list. Reverse (/rɪˈvəːs/): To move backwards. e.g. "the lorry reversed into the back of a bus"
            var sorryNot_sorry = vowels[3]; //as it isnt in the correct order i have to create this cbristmas mirakel
            vowels[3] = vowels[1]; //swappity swappity i wish i was in pythonity
            vowels[1] = sorryNot_sorry;    //your luky its not "temp"    
            var hiTim = File.ReadAllText("A112 - Grinch2.txt").ToCharArray(); //because streamreaders are 2 much effort you know right?! "A lot of instructions this time?  Was that the problem?  Did you have to look up more on text files?" - a cs teacher
            File.WriteAllText("vowels.txt", ""); //to clear the text file because i exclusively append later
            foreach (var vowel in vowels) //ok this makes sense kind of. there were var(ious) ways i couldve done this
            {                 //gotta leave that good whitespace right?

                File.AppendAllText("vowels.txt", $"There are {hiTim /* helloooo tim how are you? */ .Where(x => char.Parse(x.ToString().ToLower()) == vowel).Count()} {vowel}'s in the file\n");
            }
            File.AppendAllText("vowels.txt", String.Join("", hiTim.Where /* scooby dooby doo where are you? */ (x => !vowels.Contains(char.Parse(x.ToString().ToLower()/* I love commenting in between my code */.ToUpper() /* funky monkeys */.ToLower())))));

            //"Bonuse code!?")
            //Interval notational is a syntax error => x ∈ (4,12]
            //Console.Readkey(true);
            //linqity linq
        }
    }
}
