using System;

namespace MethodOverloading
{
    class MainClass
    {

        public static int Add(int x, int y)
        {
            return (x + y);
        }

        public static decimal Add(decimal z, decimal a)
        {
            return (z + a);
        }

        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if(isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(isCheck == true && sum == 1)
            {
                return $"{sum} dollars";
            }
            else if(isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        

        static void Main(string[] args)
        {
            var x = 30;
            var y = 30;

            var answer = Add(x, y);

            var z = 36.0m;
            var a = 45.0m;

            var decimalAnswer = Add(z, a);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} deciaml add: {decimalAnswer}");

            Console.WriteLine(thirdAnswer);
        }
    }
}
