using PPLWorkOutProgram;
using System;

namespace WorkoutProgram
{
    public class Program
    {
        static void Main(string[] args)//beginning of program
        {
            TitleScreen.Title();
            
            Console.WriteLine("Press 1 to enter a push workout");
            Console.WriteLine("Press 2 to enter a pull workout");
            Console.WriteLine("Press 3 to enter a leg workout");
            Console.WriteLine("Press 0 to exit program");
            string userInput = Console.ReadLine();

            
            while(userInput != "0") 
            {
                Console.Clear();
                TitleScreen.Title();
                Console.WriteLine("Come back to enter more workouts!");
                Console.WriteLine("Exiting program");
                Environment.Exit(0);

                if (userInput == "1")//beggining of the workout programs 
                {
                Console.WriteLine("What is your 1RM (1 rep max) for bench press?");
                int intBenchPressMax = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1-3. How many exercises do you want to do?");
                string strNumberOfBPExercises = Console.ReadLine();
                if (strNumberOfBPExercises == "1")
                {
                    BenchPress BP1 = new BenchPress();//adding BP as an object
                    Console.WriteLine("Excercise: " + BP1.Name);
                    Console.WriteLine("Equipment needed: " + BP1.Equipment);
                    Functions function1 = new Functions();
                    function1.BPOutput1(BP1, intBenchPressMax);

                    List<BenchPress> BenchList = new List<BenchPress>();
                    BenchList.Add(new BenchPress());
                    BenchList[0].Equipment = "barbell";

                    Console.WriteLine("Congrats on your workout!");
                    Console.ReadLine();
                    Console.WriteLine("Do you want to enter another workout?");
                    Console.ReadLine();

                }
                if (strNumberOfBPExercises == "2")
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
                    Console.ReadLine();
                    Console.WriteLine("Do you want to enter another workout?");
                    Console.ReadLine();

                }
                if (strNumberOfBPExercises == "3")
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
                    Console.ReadLine();
                    Console.WriteLine("Do you want to enter another workout?");
                    Console.ReadLine();
                }
                else Console.ReadLine();
                {
                    Console.WriteLine("Please enter 1-3 excercises");
                }
                
                }
                if (userInput == "2")//next option for workout type
                {
                    Console.WriteLine("What is your 1RM (1 rep max) for deadlift?");
                    int intDeadliftMax = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 1-3. How many exercises do you want to do?");
                    string strNumberOfDLExercises = Console.ReadLine();

                    if (strNumberOfDLExercises == "1")
                    {
                        Deadlift DL1 = new Deadlift();//adding DL as an object
                        Console.WriteLine("Excercise: " + DL1.Name);
                        Console.WriteLine("Equipment needed: " + DL1.Equipment);
                        Functions function1 = new Functions();
                        function1.DLOutput1(DL1, intDeadliftMax);

                        List<BenchPress> BenchList = new List<BenchPress>();
                        BenchList.Add(new BenchPress());
                        BenchList[0].Equipment = "barbell";

                        Console.WriteLine("Congrats on your workout!");
                        Console.ReadLine();
                        Console.WriteLine("Do you want to enter another workout?");
                        Console.ReadLine();
                    }
                    if (strNumberOfDLExercises == "2")
                    {
                        Deadlift DL1 = new Deadlift();
                        Console.WriteLine("First excercise: " + DL1.Name);
                        Console.WriteLine("Equipment needed: " + DL1.Equipment);
                        Functions function1 = new Functions();
                        function1.DLOutput2(DL1, intDeadliftMax);

                        LatPullDown LP1 = new LatPullDown();//located within the DL class
                        Console.WriteLine("Second excercise: " + LP1.Name);
                        Functions function2 = new Functions();
                        function2.LPOutput(LP1, intDeadliftMax);

                        Console.WriteLine("Congrats on your workout!");
                        Console.ReadLine();
                        Console.WriteLine("Do you want to enter another workout?");
                        Console.ReadLine();
                    }
                    if (strNumberOfDLExercises == "3")
                    {
                        Deadlift DL1 = new Deadlift();
                        Console.WriteLine("First excercise: " + DL1.Name);
                        Console.WriteLine("Equipment needed: " + DL1.Equipment);
                        Functions function1 = new Functions();
                        function1.DLOutput3(DL1, intDeadliftMax);

                        LatPullDown LP1 = new LatPullDown();//located within the DL class
                        Console.WriteLine("Second excercise: " + LP1.Name);
                        Functions function2 = new Functions();
                        function2.LPOutput(LP1, intDeadliftMax);

                        FacePulls FP1 = new FacePulls();
                        Console.WriteLine("Third exercise:" + FP1.Name);
                        Functions function3 = new Functions();
                        function3.FPOutput(FP1, intDeadliftMax);


                        Console.WriteLine("Congrats on your workout!");
                        Console.ReadLine();
                        Console.WriteLine("Do you want to enter another workout?");
                        Console.ReadLine();
                    }

                    if (userInput == "3")//final option for workout type    
                    {
                        Console.WriteLine("What is your 1RM (1 rep max) for squat?");
                        int intSquatMax = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 1-3. How many exercises do you want to do?");
                        string strNumberOfSQExercises = Console.ReadLine();

                        if (strNumberOfSQExercises == "1")
                        {
                            Squat SQ1 = new Squat();//adding SQ as an object
                            Console.WriteLine("Excercise: " + SQ1.Name);
                            Console.WriteLine("Equipment needed: " + SQ1.Equipment);
                            Functions function1 = new Functions();
                            function1.SQOutput1(SQ1, intDeadliftMax);

                            List<BenchPress> BenchList = new List<BenchPress>();
                            BenchList.Add(new BenchPress());
                            BenchList[0].Equipment = "barbell";

                            Console.WriteLine("Congrats on your workout!");
                            Console.ReadLine();
                            Console.WriteLine("Do you want to enter another workout?");
                            Console.ReadLine();
                        }
                        if (strNumberOfSQExercises == "2")
                        {
                            Squat SQ1 = new Squat();//adding SQ as an object
                            Console.WriteLine("Excercise: " + SQ1.Name);
                            Console.WriteLine("Equipment needed: " + SQ1.Equipment);
                            Functions function1 = new Functions();
                            function1.SQOutput2(SQ1, intDeadliftMax);

                            LegPress LPR1 = new LegPress();//located within the SQ class
                            Console.WriteLine("Second excercise: " + LPR1.Name);
                            Functions function2 = new Functions();
                            function2.LPROutput(LPR1, intSquatMax);

                            Console.WriteLine("Congrats on your workout!");
                            Console.ReadLine();
                            Console.WriteLine("Do you want to enter another workout?");
                            Console.ReadLine();
                        }
                        if (strNumberOfSQExercises == "3")
                        {
                            Squat SQ1 = new Squat();//adding SQ as an object
                            Console.WriteLine("Excercise: " + SQ1.Name);
                            Console.WriteLine("Equipment needed: " + SQ1.Equipment);
                            Functions function1 = new Functions();
                            function1.SQOutput3(SQ1, intDeadliftMax);

                            LegPress LPR1 = new LegPress();//located within the SQ class
                            Console.WriteLine("Second excercise: " + LPR1.Name);
                            Functions function2 = new Functions();
                            function2.LPROutput(LPR1, intSquatMax);

                            LegExtension LE1 = new LegExtension();
                            Console.WriteLine("Third exercise:" + LE1.Name);
                            Functions function3 = new Functions();
                            function3.LEOutput(LE1, intSquatMax);


                            Console.WriteLine("Congrats on your workout!");
                            Console.ReadLine();
                            Console.WriteLine("Do you want to enter another workout?");
                            Console.ReadLine();
                        }
                        else if (userInput == null) { }

                        {
                            Console.WriteLine("Please enter 1-3 excercises");
                            Console.ReadLine();
                            Console.WriteLine("Type exit to quit program");
                        }
                    }
                }
            }
        }
    }
}
