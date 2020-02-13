
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char response = ' ';
            do
            {
                double numOfMarks, average, sum = 0;


                Console.WriteLine("How many marks are you entering?");
                numOfMarks = int.Parse(Console.ReadLine());

                for (int count = 1; count <= numOfMarks; count++)
                {
                    int mark;
                    Console.WriteLine($"Please enter mark #{count}");
                    mark = int.Parse(Console.ReadLine());
                    sum += mark;
                }
                average = sum / numOfMarks;

                Console.WriteLine($"The average is {average}");

                Console.WriteLine("Restart?");
                response = char.Parse(Console.ReadLine());
            } while (response == 'y');

        }   
    }
}
