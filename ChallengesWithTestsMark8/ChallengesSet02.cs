using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
            
        {
            int sum = 0;
            if (vals == null || vals.Length == 0)
            {
                return true;
            }
            for (int i = 0; i < vals.Length; i++)
            {
                sum++;
            }
            if (sum % 2 == 0) 
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
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }

        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

           return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                    
                }
            }
            return sum;


        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = Sum(numbers.ToArray());

            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
            for (var i = 1; i < number; i+=2)
            {
                count++;
            }

            return count;
        }
    }
}
