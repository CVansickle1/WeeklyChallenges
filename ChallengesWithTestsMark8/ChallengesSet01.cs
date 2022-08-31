using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return num1 == num2;
        }

        public double Subtract(double minuend, double subtrahend) => minuend - subtrahend;
        

        public int Add(int number1, int number2) => number1 + number2;
        

        public int GetSmallestNumber(int number1, int number2) => number1 > number2 ? number2 : number1;
       

        public long Multiply(long factor1, long factor2) => factor1 * factor2;
        

        public string GetGreeting(string nameOfPerson)
        {
            if(nameOfPerson == "")
            {
                return "Hello!";
            }
            return "Hello, " + nameOfPerson + "!";
        }

        public string GetHey() => "HEY!";
        
    }
}
