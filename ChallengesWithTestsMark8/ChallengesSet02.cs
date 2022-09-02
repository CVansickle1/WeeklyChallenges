using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var count = vals.Count();
            return count % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
           return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null || !numbers.Any())
            {
                return 0;
            }
            var min = numbers.Min();
            return min += numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Count() < str2.Count())
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
            
           
        }

        public int Sum(int[] numbers)
        {
            try
            {
                if (!numbers.Any())
                {
                    return 0;
                }
                return numbers.Sum();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int SumEvens(int[] numbers)
        {
            try
            {
                if (!numbers.Any())
                {
                    return 0;
                }
                return numbers.Where(x => x % 2 == 0).Sum();
            }
            catch(Exception ex)
            {
                return 0;
            }

        }

        public bool IsSumOdd(List<int> numbers)
        {
            try
            {
                if (!numbers.Any())
                {
                    return false;
                }
                return numbers.Sum() % 2 != 0;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var num = Math.Round((decimal)number / 2, 0, MidpointRounding.ToZero);
            if(number < 1)
            {
                return 0;
            }
            return (long)num;
        }
    }
}
