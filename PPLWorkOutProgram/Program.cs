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
            Console.WriteLine("Press any other key and then option 'N' to exit program");
            UserInput userInput1 = new UserInput();
            userInput1.continueChoice = "n";
            userInput1.choice = Console.ReadLine();

            if (userInput1.choice == null)
            {
                userInput1.choice = "0";
            }

            while (userInput1.choice != "0")//loop to enter additional workouts
            {
                if (userInput1.continueChoice == "y")
                {
                    TitleScreen.Title();//pulls ascii art to top of screen

                    Console.WriteLine("Press 1 to enter a push workout");
                    Console.WriteLine("Press 2 to enter a pull workout");
                    Console.WriteLine("Press 3 to enter a leg workout");
                    Console.WriteLine("Press 0 to exit program");
                    userInput1.choice = Console.ReadLine();
                }

                if (userInput1.choice == "1")//beggining of the workout programs 
                {
                    Console.Clear();
                    PushTitle.Push();//separate ascii art for each option chosen by the user

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
                        var volumeLifted = function1.BPOutput1(BP1, intBenchPressMax);
                        Console.WriteLine($"Workout volume: You benchpressed a total of {volumeLifted} lbs.!");//an overal total volume returned to the user.
                        Console.ReadLine();

                        Console.WriteLine("Congrats on your workout! (enter any key to continue)");
                        Console.ReadLine();

                    }
                    if (strNumberOfBPExercises == "2")
                    {
                        Console.Clear();
                        PushTitle.Push();

                        BenchPress BP1 = new BenchPress();
                        Console.WriteLine("First excercise: " + BP1.Name);
                        Console.WriteLine("Equipment needed: " + BP1.Equipment);

                        Functions function1 = new Functions();
                        var volumeLifted = function1.BPOutput1(BP1, intBenchPressMax);
                        Console.WriteLine($"Workout volume: You benchpressed a total of {volumeLifted} lbs.!");
                        Console.ReadLine();

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
                        PushTitle.Push();


                        BenchPress BP1 = new BenchPress();
                        Console.WriteLine("First exercise:" + BP1.Name);
                        Functions function1 = new Functions();
                        var volumeLifted = function1.BPOutput1(BP1, intBenchPressMax);
                        Console.WriteLine($"Workout volume: You benchpressed a total of {volumeLifted} lbs.!");
                        Console.ReadLine();

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
                        var volumeLifted = function1.DLOutput1(DL1, intDeadliftMax);
                        Console.WriteLine($"Workout volume: You deadlifted a total of {volumeLifted} lbs.!");
                        Console.ReadLine();


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
                        var volumeLifted = function1.DLOutput1(DL1, intDeadliftMax);
                        Console.WriteLine($"Workout volume: You deadlifted a total of {volumeLifted} lbs.!");
                        Console.ReadLine();

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
                        var volumeLifted = function1.DLOutput1(DL1, intDeadliftMax);
                        Console.WriteLine($"Workout volume: You deadlifted a total of {volumeLifted} lbs.!");
                        Console.ReadLine();

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
                        var volumeLifted = function1.SQOutput1(SQ1, intSquatMax);
                        Console.WriteLine($"Workout volume: You squatted a total of {volumeLifted} lbs.!");
                        Console.ReadLine();

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
                        var volumeLifted = function1.SQOutput1(SQ1, intSquatMax);
                        Console.WriteLine($"Workout volume: You squatted a total of {volumeLifted} lbs.!");
                        Console.ReadLine();

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
                        var volumeLifted = function1.SQOutput1(SQ1, intSquatMax);
                        Console.WriteLine($"Workout volume: You squatted a total of {volumeLifted} lbs.!");
                        Console.ReadLine();

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
                WorkOutLog.LogWorkout();
                Thread.Sleep(2000);
                TitleScreen.continueOption(userInput1);
            }
        }

    }
}
