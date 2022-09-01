﻿ /* Given the complexity of finding a integer greater than 4 for this 
 problem, with many mathematicians working on this and problems similar 
 and with numbers up to 16^7750 being previously tested with no luck, 
 I'm assuming you are not expecting someone to find the answer in a job 
 application for junior programming position. Therefore I suspect the 
 point of this problem is to think outside of the box. Here's my go at that: The problem 
 as stated requests the first power of 16 that doesn't contain a 1,2,4, 
 or 8. Power being defined the result of a x^y expression. Therefore is no 
 requirement placed that y be an integer. Since doubles are represented by 
 53 binary digits, they are accurate to almost 16 base 10 digits (~15.9546) 
 to guarantee accuracy we will round down to using 15 digits. Therefore answers
 will be checked in increments of 1e-15 basis*/

using System;
using System.Linq;

namespace PowerFinderTestApp
{
    class Program
    {
        static void Main(){
            double exponent = 4.0;
            int baseValue = 16;
            double power;

            exponent += 1e-15;
            power = Math.Pow(baseValue, exponent);

            //This is to prevent the while loop from continuing to run if it does not 
            //find a value within 200 attempts.
            int temp = 0;
            int Max = 200;

            //Check powers until one is found without containing the undesired digits
            while(new [] {"1", "2", "4", "8"}.Any(power.ToString().Contains) && temp<Max){
                exponent += 1e-15;
                power = Math.Pow(baseValue, exponent);
                Console.WriteLine("power is " + power);
                temp++;
            }
                     
            Console.WriteLine("The result of 16^" + exponent + " is " + power + ". It is the first exponent above 4 which does not contain the digits 1,2, 4, or 8 in the power."); 
        }
    }
}   