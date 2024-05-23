using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problems.Quests
{
    public static class ReverseString
    {
        public static void Reverse(string inputString){
            char[] charsArray = inputString.ToCharArray();
            int stringLength = charsArray.Length;
            for(int i=0,j=stringLength-1; i<j; i++, j--){
                (charsArray[j], charsArray[i]) = (charsArray[i], charsArray[j]);
            }
            string reversedString = new(charsArray); //constructor call with parameters
            Console.WriteLine(reversedString);
        }

        public static void ReverseWithoutArray(string inputString){
            string reversedString = string.Empty;
            for(int fromEnding = inputString.Length-1; fromEnding>=0; fromEnding--)reversedString += inputString[fromEnding];
            Console.WriteLine("{0} {1}",reversedString, "Without Array");
        }
    }
}