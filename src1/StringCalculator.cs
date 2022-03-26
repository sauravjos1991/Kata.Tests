using System;
using System.Collections.Generic;


namespace Kata.Tests
{
    public class StringCalculator
        {
            public int Add(string numbers)

            {
            List<char> delimiters=new List<char>()  {',','\n'};
            
                if (numbers.Contains("//"))
                    {
                numbers = numbers.Substring(numbers.IndexOf("//", StringComparison.Ordinal) + 2);
                delimiters.Clear();
                delimiters.Add(numbers.Substring(0,1)[0]);
            }
                        
                string[] splitedNumbers = numbers.Split(delimiters.ToArray());
                int sum = 0;
            string negatives = String.Empty;
                    foreach(string str in splitedNumbers)
                {
                    int number;
                    int.TryParse(str, out number);
                    sum += number;
                if(number<0)
                {
                    negatives += number.ToString() + ',';
                }

                }
                    if (!string.IsNullOrEmpty(negatives))
            {
                throw new Exception("Negatives are not allowed" + negatives.Substring(0,negatives.Length-1));
            }
                return sum;
            }
        }

    
}
