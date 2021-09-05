using System;

namespace ConsoleAppRaiseExceptionForSecondNum
{
    class ArrayOutOfIndex
    {
        public void Divide(int num1, int num2)
        {
            
            try
            {
                if (num2 == 0 || num2 > 10000)
                {
                    throw new Exception("Second number is 0 or greater than 10000");
                    
                }
                else
                {
                    int res = num1 + num2;
                    Console.WriteLine(" Sum = " + res);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*finally
            {
                Console.WriteLine(" Sum = " + res);
            }*/
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 1st number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Handling System Exception");
            ArrayOutOfIndex obj = new ArrayOutOfIndex();
            obj.Divide(num1, num2);

        }
    }
}