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
                    Console.WriteLine("Excercise: " + BP1.Name);
                    Console.WriteLine("Equipment needed: " + BP1.Equipment);
                    Functions function1= new Functions();
                    function1.BPOutput1(BP1,intBenchPressMax);
                    
                    List<BenchPress> BenchList= new List<BenchPress>();
                    BenchList.Add(new BenchPress());
                    BenchList[0].Equipment = "barbell";

                    Console.WriteLine("Congrats on your workout!");

                }
                if (strNumberOfExercises == "2")
                    {
                    BenchPress BP1 = new BenchPress();
                    Console.WriteLine("First excercise: " + BP1.Name);
                    Console.WriteLine("Equipment needed: " + BP1.Equipment);
                   
                    Functions function1 = new Functions();
                    function1.BPOutput2(BP1, intBenchPressMax);

                    OverHeadPress OH1 = new OverHeadPress();//located within the BenchPress class
                    Console.WriteLine("Second excercise: " + OH1.Name);
                    Console.WriteLine("Equipment needed: " + BP1.Equipment);
                    Functions function2 = new Functions();
                    function2.OHOutput(OH1, intBenchPressMax);

                    Console.WriteLine("Congrats on your workout!");

                    }
                if (strNumberOfExercises == "3")
                    {
                    BenchPress BP1 = new BenchPress();
                    Console.WriteLine("First exercise:" + BP1.Name);
                    Functions function1 = new Functions();
                    function1.BPOutput3(BP1, intBenchPressMax);

                    OverHeadPress OH1 = new OverHeadPress();//located within the BenchPress class
                    Console.WriteLine("Second excercise: " + OH1.Name);
                    Functions function2 = new Functions();
                    function2.OHOutput(OH1, intBenchPressMax);

                    TriCepExtension TC1 = new TriCepExtension();
                    Console.WriteLine("Third exercise:" + TC1.Name);
                    Functions function3 = new Functions();
                    function3.TCOutput(TC1, intBenchPressMax);
                  

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
