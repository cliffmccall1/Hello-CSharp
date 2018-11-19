using System;

namespace newApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting;
            greeting = "Hello C#!";

            Console.WriteLine(greeting);

            int age;
            age = 27;

            Console.WriteLine(age);

            int sum;
            sum = 2 + 2;

            int newSum;
            newSum = sum + 10;

            Console.WriteLine(sum);
            Console.WriteLine(newSum);

            bool isOpen = true;
            Console.WriteLine(isOpen);

            if (isOpen == false)
            {
                Console.WriteLine("Yay!");
            }
            else
            {
                Console.WriteLine("Sad");
            }
        }
    }
}
