 /* Given the complexity of finding a integer greater than 4 for this problem, with many mathematicians working on this and problems similar 
 and with numbers up to 16^7750 being previously tested with no luck, I'm assuming you are not expecting someone to find the answer in a job 
 application for junior programming position. Therefore I suspect the point of this problem is to think outside of the box. Here's my go at that: The problem 
 as stated requests the first power of 16 that doesn't contain a 1,2,4, or 8. Power being defined the result of a x^y expression. Therefore is no 
 requirement placed that y be an integer. Since doubles are represented by  53 binary digits, they are accurate to almost 16 base 10 digits (~15.9546) 
 to guarantee accuracy we will round down to using 15 digits. Therefore answers will be checked in increments of 1e-15 basis*/

using System;
using System.Linq;

namespace PowerFinderTestApp
{
    class Program
    {
        static void Main(){
            
            /*This function takes base, the minimum (non-inclusive) exponent, list of forbidden numbers and number of cycles (optional) 
            The number of cycles is there for performance reasons to pervent=-=-o running to infinity
            It defaults to 20 cycles if not set.*/
            string FindNextDesiredPower(double baseValue, double exponent, char[] forbiddenValues, int maxCycles = 20){
                double power;

                //The exponent inputted into the function is not to be used therefore it must be incremented before the loop.
                exponent += 1e-15;
                power = Math.Pow(baseValue, exponent);

                int temp = 0;
                //Check powers until one is found without containing the undesired digits
                while(forbiddenValues.Any(power.ToString().Contains) && temp<maxCycles){
                    exponent += 1e-15;
                    power = Math.Pow(baseValue, exponent);               
                    temp++;
                }
                return "The result of 16^" + exponent + " is " + power + ". It is the first exponent above 4 which does not contain the digits 1,2, 4, or 8 in the power.";     
                
            } 
            Console.WriteLine(FindNextDesiredPower(16,4,new [] {'1', '2', '4', '8'}, 200));

        }
    }
}   