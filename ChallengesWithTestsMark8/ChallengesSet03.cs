using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
           return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        { 
            if (numbers == null)
            {
                return false;
            }
           var answer = numbers.Where(x => x % 2 != 0).Sum();            

            if (answer % 2 != 0)
            {
                return true;               

            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool uppercase = false;
            
            bool lowercase = false;
            bool number = false;   
            foreach(var ch in password)
            {
                if (char.IsUpper(ch))
                {
                    uppercase = true;
                }
                else if (char.IsLower(ch))
                {
                    lowercase = true;
                }
                else
                {
                    number = true;
                }
               
            }
            if (uppercase && lowercase && number)
            {
                return true;
            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            var answer = dividend / divisor;
            return answer;
        }

        public int LastMinusFirst(int[] nums)
        {
           var answer = nums[nums.Length - 1] - nums[0];
            return answer;
        }

        public int[] GetOddsBelow100()
        {
            var answer = new List<int>();
            for (int i = 0;i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    answer.Add(i);
                }
            }
           return answer.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            
            for (int i = 0;i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
   

