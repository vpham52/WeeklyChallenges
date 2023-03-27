using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {

            return char.IsLetter(c);

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberOdd(int num)
        {
                      

            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            //if (numbers == null)
            //{
            //    return 0;
            //}

            //double min = 0;
            //double max = 0;

            //foreach (var num in numbers)
            //{
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    if (num < min)
            //    {
            //        min = max;
            //    }                

            //    if (numbers.Count() <= 1)
            //    {
            //        min = num;
            //    }

            //    return min + max;

            //}

            return (numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max());

            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
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
            var sum = 0;

            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; ++i)
            {
                sum += numbers[i];
            }
            return sum;

            //Null Condition ? //Null Coalescing ??
            //return numbers?.Sum() ?? 0;

        }

        public int SumEvens(int[] numbers)
        {
                        
            if (numbers == null)
            {
                return 0;
            }

            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                    
                }

            }
            return evenSum;           

          
        }

        public bool IsSumOdd(List<int> numbers)
        {


            if (numbers == null)
            {
                return false;
            }

            int oddSum = 0;

            foreach (var num in numbers)
            {
                oddSum += num;
            }
            return oddSum % 2 != 0;

            //return (numbers == null) ? false : (numbers.Sum() % 2 != 0);


        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number/ 2;
            }


        }
    }
}
