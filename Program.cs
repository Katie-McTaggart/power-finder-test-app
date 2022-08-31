using System;
using System.Linq;

namespace PowerFinderTestApp
{
    class Program
    {
        static bool checkNextPower(int power){
            string one = "1";
            string two = "2";
            string four = "4";
            string eight = "8";
            double result;
            int baseValue = 16;
            bool test_1;
            bool test_2;
            bool test_4;
            bool test_8;

            //Find the number for the next 16^x
            result = Math.Pow(baseValue, power);

            //Check the result to see if it contains one of the undesired values
            test_1 = result.ToString().Contains(one);
            test_2 = result.ToString().Contains(two);
            test_4 = result.ToString().Contains(four);
            test_8 = result.ToString().Contains(eight);

            //Return true when a power is found
            if((test_1 == false) && (test_2 == false) && (test_4 == false) && (test_8 == false)){
                return true;
            }
            else{
                return false;
            }
        }

        static void Main(string[] args)
        {    
            bool potentialPower;
            int j;
            
            for(j = 5; j<1000; j++){
                potentialPower = checkNextPower(j);  

                if(potentialPower == true){
                    break;
                }
            }
            Console.WriteLine("The result of 16^" + j + " does not contain 1,2, 4, or 8 in the value."); 
        }
    }
}   
