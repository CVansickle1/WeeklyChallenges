﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<string>() { str1, str2, str3, str4 };

            return list.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>(4) { number1, number2, number3, number4 };

            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3
                && sideLength2 + sideLength3 > sideLength1
                && sideLength1 + sideLength3 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            double isnumber;
            return double.TryParse(input, out isnumber);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > (objs.Count() / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            try
            {
                return numbers.Where(x => x % 2 == 0).Average();
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (var i = number - 1; i >= 1; i--)
            {
                number *= i;
            }
            return number;
        }
    }
}
