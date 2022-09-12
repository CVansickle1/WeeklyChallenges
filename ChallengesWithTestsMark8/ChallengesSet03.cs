using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            try
            {


                foreach (bool val in vals)
                {
                    if (val == false)
                    {
                        return true;
                    }
                    
                }
                return false;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            try
            {
                if(numbers.Sum() % 2 != 0)
                {
                    return true;
                }
                return false;
            }
            catch(Exception)
            { return false; }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            try
            {
                if(password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }
        public decimal Divide(decimal dividend, decimal divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch (Exception)
            {
                return 0;
            }
        }   

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();

            for(var i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           for(var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
