using System;

namespace WorkoutProgram
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press 1 to enter a push workout");
            Console.WriteLine("Press 2 to enter a pull workout");
            Console.WriteLine("Press 3 to enter a leg workout");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            if (userInput == "1")//beggining of the workout programs 
            {
                Console.WriteLine("What is your 1RM (1 rep max) for bench press?");
                string strBenchPressMax = Console.ReadLine();
                Console.WriteLine("How many exercises do you want to do?");
                string strNumberOfExercises = Console.ReadLine();
                if (strNumberOfExercises == "1")
                {
                    Console.WriteLine("Let's warmup for bench press");
                    Console.WriteLine("First set: 10 reps at " + strBenchPressMax + "lbs.");
                }

            }


        }
    }
}
