using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Generics
{
    public class ArrayDataStructure
    {
        //this problem consumes
        //Time complexity O(n) since for loop
        //Space Complexity O(n) since new array has been used
        public void RotateArray(int[] inputArray, int numberOfSteps)
        {
            int inputLength = inputArray.Length;
            int[] rotatedArray = new int[inputLength];
            for(int i=0; i<inputLength; i++)
            {
                int newIndex = (i + numberOfSteps) % inputLength;
                rotatedArray[newIndex] = inputArray[i];
            }
            foreach(int element in rotatedArray)
            {
                Console.WriteLine(element);
            }
        }

        //Complexities
        //Time : O(n) since for loop
        //Space : O(1) since no new array is created
        public void MaxConsecutiveOnesInBinary(byte[] inputArray)
        {
            int maxConsecutiveCounter = 0;
            int currentConsecutiveOnes = 0;
            for(int i=0; i<inputArray.Length; i++){
                if(inputArray[i]==1){
                    currentConsecutiveOnes++;
                }
                else{
                    currentConsecutiveOnes = 0;
                }
                maxConsecutiveCounter = Math.Max(maxConsecutiveCounter, currentConsecutiveOnes);
            }
            Console.WriteLine($"Max number of Consecutive 1\'s in the array : {maxConsecutiveCounter}");
        }
    }
}
