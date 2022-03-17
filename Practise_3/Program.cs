using System;

namespace Practise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            /*string name = Console.ReadLine();
           char simv=Convert.ToChar(Console.ReadLine());

           int result = IsExist(name, simv);
           Console.WriteLine(result);*/
            #endregion
            #region Task-2
            /*int number = Convert.ToInt32(Console.ReadLine());
            int result = RootOf(number);
            Console.WriteLine(result);*/
            #endregion
            #region Task-3
            /*int number =Convert.ToInt32(Console.ReadLine());
            int result=sum(number);
            Console.WriteLine(result);*/
            #endregion
            #region \Task-4
            /*int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers=new int[size];
            for(int i=0; i<numbers.Length; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            int result = maxNum(numbers);
            Console.WriteLine(result);*/
            #endregion
            #region Task-5
            /*int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            numbers = positivElements(numbers);
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);*/
            #endregion


        }


        static int IsExist(string name,char simv)

        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == simv)
                    return i;
            }
            return -1;
        }
         
        
        static int RootOf(int number)
        {
            if (number == 0)
                return 0;
            else if (number == 1)
                return 1;
            for (int i = 2; i < number / 2; i++)
            {
                if (i * i == number)
                    return i;
                if (i * i > number)
                    return i - 1;
            }

            return -1;

        }


        static int sum(int number)
        {
            int digit, sumDigit = 0;
            while (number > 0)
            {
                digit = number % 10;
                sumDigit += digit;
                number /= 10;
            }
            return sumDigit;
        }

        static int maxNum(int[]numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }

        static int[] positivElements(int[]numbers)
        {
            int i = 0;
            while(i < numbers.Length)
            {
                if(numbers[i]<0)
                {
                    numbers[i] *= -1;
                }
                i++;
            }
            return numbers;
           
        }

    }
}
