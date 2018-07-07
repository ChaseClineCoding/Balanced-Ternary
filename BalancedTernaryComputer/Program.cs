using System;

namespace BalancedTernaryComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            int DEC = int.Parse(Console.ReadLine());

            int largestExponent = (int)(Math.Ceiling(Math.Log(Math.Abs(DEC), 3)));
            int arrSize = largestExponent + 1;

            char[] chars = new char[arrSize];
            if (DEC < 0)
            {
                chars[0] = 'T';
                int currentValue = (int)(-1 * Math.Pow(3, largestExponent));
                for (int i = 1, exp = largestExponent-1; i < chars.Length; i++, exp--)
                {
                    if (currentValue == DEC)
                    {
                        chars[i] = '0';
                        continue;
                    } else
                    {
                        int nextValue = (int)Math.Pow(3, exp);
                        if (currentValue + nextValue <= DEC)
                        {
                            chars[i] = '1';
                            currentValue += nextValue;
                        } else
                        {
                            chars[i] = '0';
                        }
                    }
                }
            }
            else
            {
                chars[0] = '1';
                int currentValue = (int)(Math.Pow(3, largestExponent));
                for (int i = 1, exp = largestExponent - 1; i < chars.Length; i++, exp--)
                {
                    if (currentValue == DEC)
                    {
                        chars[i] = '0';
                        continue;
                    }
                    else
                    {
                        int nextValue = (int)Math.Pow(3, exp);
                        if (currentValue - nextValue >= DEC)
                        {
                            chars[i] = 'T';
                            currentValue -= nextValue;
                        }
                        else
                        {
                            chars[i] = '0';
                        }
                    }
                }
            }
        

            string result = string.Join("", chars);
            Console.WriteLine(result);
        }
    }
}