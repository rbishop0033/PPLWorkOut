using PPLWorkOutProgram;
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
                int intBenchPressMax = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1-3. How many exercises do you want to do?");
                string strNumberOfExercises = Console.ReadLine();
                if (strNumberOfExercises == "1")
                {
                    BenchPress BP1= new BenchPress();//adding BP as an object
                    Console.WriteLine(BP1.Name);
                    Console.WriteLine(BP1.Description);
                    Console.ReadLine();
                    Console.WriteLine("Bench Press Warmup:");
                    Console.WriteLine("First set: 10 reps at " + (intBenchPressMax * 0.5 )  + "lbs.");
                    Console.ReadLine();
                    Console.WriteLine("Second set: 5 reps at " + (intBenchPressMax*.6) + "lbs.");
                    Console.ReadLine();
                    Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intBenchPressMax*.75) + "lbs.");
                    Console.ReadLine();

                    Console.WriteLine("Congrats on your workout!");

                }
                if (strNumberOfExercises == "2")
                    {
                    BenchPress BP1 = new BenchPress();
                    Console.WriteLine("First excercise:");
                    Console.WriteLine(BP1.Name);
                    Console.WriteLine(BP1.Description);
                    Console.ReadLine();
                    Console.WriteLine("Bench Press Warmup:");
                    Console.WriteLine("First set: 10 reps at " + (intBenchPressMax * 0.5) + "lbs.");
                    Console.ReadLine();
                    Console.WriteLine("Second set: 5 reps at " + (intBenchPressMax * .6) + "lbs.");
                    Console.ReadLine();
                    Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intBenchPressMax * .7) + "lbs.");
                    Console.ReadLine();

                    OverHeadPress OH1 = new OverHeadPress();
                    Console.WriteLine("Second excercise:");
                    Console.WriteLine(OH1.Name);
                    Console.WriteLine(OH1.Description);
                    Console.ReadLine();
                    Console.WriteLine("First set: 10 reps at " + (intBenchPressMax * 0.2) + "lbs.");
                    Console.ReadLine();
                    Console.WriteLine("Second set: 5 reps at " + (intBenchPressMax * .3) + "lbs.");
                    Console.ReadLine();
                    Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intBenchPressMax * .4) + "lbs.");
                    Console.ReadLine();

                    Console.WriteLine("Congrats on your workout!");

                    }
                if (strNumberOfExercises == "3")
                    {
                    BenchPress BP1 = new BenchPress();
                    Console.WriteLine("First exercise:");
                    Console.WriteLine(BP1.Name);
                    Console.WriteLine(BP1.Description);
                    Console.ReadLine();

                    Console.WriteLine("Bench Press Warmup:");
                    Console.WriteLine("First set: 10 reps at " + (intBenchPressMax * 0.5) + "lbs.");
                    Console.ReadLine();
                    Console.WriteLine("Second set: 5 reps at " + (intBenchPressMax * .6) + "lbs.");
                    Console.ReadLine();
                    Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intBenchPressMax * .7) + "lbs.");
                    Console.ReadLine();

                    OverHeadPress OH1 = new OverHeadPress();
                    Console.WriteLine("Second excercise:");
                    Console.WriteLine(OH1.Name);
                    Console.WriteLine(OH1.Description);
                    Console.ReadLine();
                    Console.WriteLine("First set: 10 reps at " + (intBenchPressMax * 0.2) + "lbs.");
                    Console.ReadLine();
                    Console.WriteLine("Second set: 5 reps at " + (intBenchPressMax * .3) + "lbs.");
                    Console.ReadLine();
                    Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intBenchPressMax * .4) + "lbs.");
                    Console.ReadLine();

                    TriCepExtension TC1 = new TriCepExtension();
                    Console.WriteLine("Third exercise:");
                    Console.WriteLine(TC1.Name); Console.WriteLine(TC1.Description);
                    Console.ReadLine();
                    Console.WriteLine("Accessory sets: 3 sets of 10 at weight that can be performed while maintaining good form");
                    Console.ReadLine();
                    Console.WriteLine("Congrats on your workout!");
                    }
                else Console.ReadLine();
                        {
                    Console.WriteLine("Please enter 1-3 excercises");
                        }

            }
        }
    }
}
