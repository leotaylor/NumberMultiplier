using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers separated by a comma.");
            var numbers = Console.ReadLine();
            var numbersArray = numbers.Split(',');
            Console.WriteLine("Multiply 'm' or Square 's'?");
            var mOrS = Console.ReadLine();
            if (mOrS == "m")
            {
                int answer = 0;
                for(int i = 0; i < numbersArray.Length; i++)
                {
                    int currentNumber = int.Parse(numbersArray[i]);
                    if(i == 0)
                    {
                        answer = currentNumber;
                    }
                    else
                    {
                        answer = answer * currentNumber;
                    }
                }
                Console.WriteLine(answer);
                Console.ReadLine();
            } else
            {
                if (mOrS == "s")
                {
                    int answer = 0;
                    for(int i = 0; i < numbersArray.Length; i++)
                    {

                    }
                }
            }
        }
    }
}
