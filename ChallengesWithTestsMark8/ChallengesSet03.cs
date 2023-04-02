using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            //if (vals == null)
            //{
            //    return false;
            //}


            //foreach (var item in vals)
            //{
            //    if (item == false)
            //    {
            //        return true;
            //    }                            

            //}; return false;

            return vals.Contains(false) ? true : false; 

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }

            var sumOfOdds = numbers.Where(x => x % 2 != 0).Sum();

            foreach (var item in numbers)
            {

                if (sumOfOdds % 2 != 0)
                { 
                   
                    return true;
                }

            }return false;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber));     

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
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            //throw new NotImplementedException();
            var odds = new List<int>();

            
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }

            return odds.ToArray();

            // return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
