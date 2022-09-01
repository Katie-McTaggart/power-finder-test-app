using System;
using System.Linq;

namespace PowerFinderTestApp
{
    class Program
    {
        static void Main(){
            //Function finds a power and then determines if it contains 1, 2, 4, or 8.  
            static bool checkNextPower(int baseValue, double power){
                char[] forbiddenValues = new char[] {'1','2','4','8'};
                double result;

                //Find the next power
                result = Math.Pow(baseValue, power);

                /*Check the result to see if it contains any one of the undesired values.
                If it does we want to keep looking */
                if(forbiddenValues.Any(result.ToString().Contains) == true){
                    return false;
                }
                else{
                    return true;
                }
            }

            double j;
            int num = 16;
            bool potentialPower;
            
            //Loop through values until a potential power is found to not contain the undesired values
            for(j = 1; j<100; j++){
                potentialPower = checkNextPower(num, j);  

                if(potentialPower == true){
                    break;
                }
            }
            Console.WriteLine("The result of 16^" + j + " does not contain 1,2, 4, or 8 in the value."); 
        }
    }
}   