using System;

namespace FooBar
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public string FooBarKata(int numberToFoobar)
        {
            string result = string.Empty;

            if((numberToFoobar <= 0) == false)
            {
                if (numberToFoobar == int.MaxValue)
                {
                    throw new OverflowException();
                }

                if (numberToFoobar % 3 == 0)
                {
                    result += "Foo";
                }
                if (numberToFoobar % 5 == 0)
                {
                    result += "Bar";
                }
                if (numberToFoobar % 7 == 0)
                {
                    result += "Qix";
                }

                string toFooBar = numberToFoobar.ToString();
                for (int j = 0; j < toFooBar.Length; j++)
                {
                    char element = toFooBar[j];
                    if (element == '3')
                        result += "Foo";
                    if (element == '5')
                        result += "Bar";
                    if (element == '7')
                        result += "Qix";

                }
                
            }
            else
            {
                result += "Number can not be zero or lower";
            }

            return result;
        }
    }
}
