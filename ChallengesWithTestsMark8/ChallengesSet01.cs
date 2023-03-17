using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            //if(num1 == num2)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //ternary
            return (num1 == num2 ? true : false);
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //throw new NotImplementedException();
            var subtractAnswer = minuend - subtrahend;

            return subtractAnswer;

        }

        public int Add(int number1, int number2)
        {
            //throw new NotImplementedException();
            return (number1 + number2);

        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //throw new NotImplementedException();
            //if (number1 < number2)
            //{
            //    return number1;
            //}
            //else
            //{
            //    return number2;
            //}

            //ternary
            return (number1 < number2 ? number1 : number2);

        }

        public long Multiply(long factor1, long factor2)
        {
            return (factor1 * factor2);
        }

        public string GetGreeting(string nameOfPerson)
        {
            //throw new NotImplementedException();

            if (nameOfPerson != "")
            {
                return $"Hello, {nameOfPerson}!";
            }

            else
            {
                return "Hello!";

            }

          
        }

        public string GetHey()
        {
            //throw new NotImplementedException();
            return "HEY!";

        }
    }
}
