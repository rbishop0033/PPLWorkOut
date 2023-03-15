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
            UserInput userInput1 = new UserInput();
            userInput1.continueChoice = "n";
            userInput1.choice = Console.ReadLine();


            while (userInput1.choice != "0")
            {
                if (userInput1.continueChoice == "y")
                {
                    TitleScreen.Title();

                    Console.WriteLine("Press 1 to enter a push workout");
                    Console.WriteLine("Press 2 to enter a pull workout");
                    Console.WriteLine("Press 3 to enter a leg workout");
                    Console.WriteLine("Press 0 to exit program");
                    userInput1.choice = Console.ReadLine();
                }

                if (userInput1.choice == "1")//beggining of the workout programs 
                {
                    Console.Clear();
                    PushTitle.Push();

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

                        Console.WriteLine("Congrats on your workout! (enter any key to continue)");
                        /* Console.ReadLine(); */
                        /* TitleScreen.continueOption(userInput1); */

                    }
                    if (strNumberOfBPExercises == "2")
                    {
                        Console.Clear();
                        PullTitle.Pull();

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

                        Console.WriteLine("Congrats on your workout! (enter any key to continue)");
                        Console.ReadLine();

                    }
                    if (strNumberOfBPExercises == "3")
                    {
                        Console.Clear();
                        PullTitle.Pull();


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


                        Console.WriteLine("Congrats on your workout! (enter any key to continue)");
                        Console.ReadLine();
                    }
                }
                if (userInput1.choice == "2")//next option for workout type
                {
                    Console.Clear();
                    PullTitle.Pull();

                    Console.WriteLine("What is your 1RM (1 rep max) for deadlift?");
                    int intDeadliftMax = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 1-3. How many exercises do you want to do?");
                    string strNumberOfDLExercises = Console.ReadLine();

                    if (strNumberOfDLExercises == "1")
                    {
                        Console.Clear();
                        PullTitle.Pull();

                        Deadlift DL1 = new Deadlift();//adding DL as an object
                        Console.WriteLine("Excercise: " + DL1.Name);
                        Console.WriteLine("Equipment needed: " + DL1.Equipment);
                        Functions function1 = new Functions();
                        function1.DLOutput1(DL1, intDeadliftMax);

                        List<BenchPress> BenchList = new List<BenchPress>();
                        BenchList.Add(new BenchPress());
                        BenchList[0].Equipment = "barbell";

                        Console.WriteLine("Congrats on your workout! (enter any key to continue)");
                        Console.ReadLine();
                    }
                    if (strNumberOfDLExercises == "2")
                    {
                        Console.Clear();
                        PullTitle.Pull();

                        Deadlift DL1 = new Deadlift();
                        Console.WriteLine("First excercise: " + DL1.Name);
                        Console.WriteLine("Equipment needed: " + DL1.Equipment);
                        Functions function1 = new Functions();
                        function1.DLOutput2(DL1, intDeadliftMax);

                        LatPullDown LP1 = new LatPullDown();//located within the DL class
                        Console.WriteLine("Second excercise: " + LP1.Name);
                        Functions function2 = new Functions();
                        function2.LPOutput(LP1, intDeadliftMax);

                        Console.WriteLine("Congrats on your workout! (enter any key to continue)");
                        Console.ReadLine();
                    }
                    if (strNumberOfDLExercises == "3")
                    {
                        Console.Clear();
                        PullTitle.Pull();

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
                        Console.WriteLine("Third exercise: " + FP1.Name);
                        Functions function3 = new Functions();
                        function3.FPOutput(FP1, intDeadliftMax);


                        Console.WriteLine("Congrats on your workout! (enter any key to continue)");
                        Console.ReadLine();
                    }
                }

                if (userInput1.choice == "3")//final option for workout type    
                {
                    Console.Clear();
                    LegsTitle.Legs();

                    Console.WriteLine("What is your 1RM (1 rep max) for squat?");
                    int intSquatMax = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 1-3. How many exercises do you want to do?");
                    string strNumberOfSQExercises = Console.ReadLine();

                    if (strNumberOfSQExercises == "1")
                    {
                        Console.Clear();
                        LegsTitle.Legs();

                        Squat SQ1 = new Squat();//adding SQ as an object
                        Console.WriteLine("Excercise: " + SQ1.Name);
                        Console.WriteLine("Equipment needed: " + SQ1.Equipment);
                        Functions function1 = new Functions();
                        function1.SQOutput1(SQ1, intSquatMax);

                        List<BenchPress> BenchList = new List<BenchPress>();
                        BenchList.Add(new BenchPress());
                        BenchList[0].Equipment = "barbell";

                        Console.WriteLine("Congrats on your workout! (enter any key to continue)");
                        Console.ReadLine();
                    }
                    if (strNumberOfSQExercises == "2")
                    {
                        Console.Clear();
                        LegsTitle.Legs();

                        Squat SQ1 = new Squat();//adding SQ as an object
                        Console.WriteLine("Excercise: " + SQ1.Name);
                        Console.WriteLine("Equipment needed: " + SQ1.Equipment);
                        Functions function1 = new Functions();
                        function1.SQOutput2(SQ1, intSquatMax);

                        LegPress LPR1 = new LegPress();//located within the SQ class
                        Console.WriteLine("Second excercise: " + LPR1.Name);
                        Functions function2 = new Functions();
                        function2.LPROutput(LPR1, intSquatMax);

                        Console.WriteLine("Congrats on your workout! (enter any key to continue)");
                        Console.ReadLine();
                    }
                    if (strNumberOfSQExercises == "3")
                    {
                        Console.Clear();
                        LegsTitle.Legs();

                        Squat SQ1 = new Squat();//adding SQ as an object
                        Console.WriteLine("Excercise: " + SQ1.Name);
                        Console.WriteLine("Equipment needed: " + SQ1.Equipment);
                        Functions function1 = new Functions();
                        function1.SQOutput3(SQ1, intSquatMax);

                        LegPress LPR1 = new LegPress();//located within the SQ class
                        Console.WriteLine("Second excercise: " + LPR1.Name);
                        Functions function2 = new Functions();
                        function2.LPROutput(LPR1, intSquatMax);

                        LegExtension LE1 = new LegExtension();
                        Console.WriteLine("Third exercise:" + LE1.Name);
                        Functions function3 = new Functions();
                        function3.LEOutput(LE1, intSquatMax);


                        Console.WriteLine("Congrats on your workout! (enter any key to continue)");
                        Console.ReadLine();
                    }
                }
                else if (userInput1.choice == null)
                {
                    Console.Clear();
                    TitleScreen.Title();
                    Console.WriteLine("Come back to enter more workouts!");
                    Console.WriteLine("Exiting program");
                    Environment.Exit(0);
                }

                Thread.Sleep(3000);
                TitleScreen.continueOption(userInput1);
            }
        }

    }
}
