using System;
using System.Linq;

namespace PowerFinderTestApp
{
    class Program
    {
        static void Main(){
            double exponent = 1;
            int baseValue = 16;
            double power = Math.Pow(baseValue, exponent);

            //Check powers until one is found without containing the undesired digits
            while(new [] {"1", "2", "4", "8"}.Any(power.ToString().Contains)){
                exponent++;
                power = Math.Pow(baseValue, exponent);
            }
                      
            Console.WriteLine("The result of 16^" + exponent + " is " + power + " and does not contain 1,2, 4, or 8 in the value."); 
        }
    }
}   