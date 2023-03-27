using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLWorkOutProgram
{
    public static class TitleScreen
    {
        public static void Title()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine(".:::::::  .:::::::  .::           .::        .::                 .::                         .::  ");
            Console.WriteLine(".::    .::.::    .::.::           .::        .::                 .::                         .::  ");
            Console.WriteLine(".::    .::.::    .::.::           .::   .:   .::   .::    .: .:::.::  .::   .::    .::  .::.:.: .:");
            Console.WriteLine(".:::::::  .:::::::  .::           .::  .::   .:: .::  .::  .::   .:: .::  .::  .:: .::  .::  .::  ");
            Console.WriteLine(".::       .::       .::           .:: .: .:: .::.::    .:: .::   .:.::   .::    .::.::  .::  .::  ");
            Console.WriteLine(".::       .::       .::           .: .:    .:::: .::  .::  .::   .:: .::  .::  .:: .::  .::  .::  ");
            Console.WriteLine(".::       .::       .::::::::     .::        .::   .::    .:::   .::  .::   .::      .::.::   .:: ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

        }
        public static void continueOption(UserInput userInput)
        {
            Console.WriteLine("Do you want to enter another workout? (Y/N)");
            string continueWorkout = Console.ReadLine().ToLower();
            if (continueWorkout == "y")
            {
                userInput.continueChoice = "y";
                Console.Clear();
            }
            else
            {
                userInput.choice = "0";
            }
        }
        public static class WorkoutQuestions
        {
            public static void Questions()
            {
                Console.WriteLine("Press 1 to enter a push workout");
                Console.WriteLine("Press 2 to enter a pull workout");
                Console.WriteLine("Press 3 to enter a leg workout");
                Console.WriteLine("Press any other key to exit program");
            }
        }
    }

    public class UserInput
    {
        public string choice { get; set; }
        public string continueChoice { get; set; }
    }
    public static class PushTitle
    {
        public static void Push()

        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine(".:::::::  .:::::::  .::           .::        .::                 .::                         .::  ");
            Console.WriteLine(".::    .::.::    .::.::           .::        .::                 .::                         .::  ");
            Console.WriteLine(".::    .::.::    .::.::           .::   .:   .::   .::    .: .:::.::  .::   .::    .::  .::.:.: .:");
            Console.WriteLine(".:::::::  .:::::::  .::           .::  .::   .:: .::  .::  .::   .:: .::  .::  .:: .::  .::  .::  ");
            Console.WriteLine(".::       .::       .::           .:: .: .:: .::.::    .:: .::   .:.::   .::    .::.::  .::  .::  ");
            Console.WriteLine(".::       .::       .::           .: .:    .:::: .::  .::  .::   .:: .::  .::  .:: .::  .::  .::  ");
            Console.WriteLine(".::       .::       .::::::::     .::        .::   .::    .:::   .::  .::   .::      .::.::   .:: ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("             >======>   >=>     >=>   >=>>=>   >=>    >=>            ");
            Console.WriteLine("             >=>    >=> >=>     >=> >=>    >=> >=>    >=>            ");
            Console.WriteLine("             >=>    >=> >=>     >=>  >=>       >=>    >=>            ");
            Console.WriteLine("             >======>   >=>     >=>    >=>     >=====>>=>            ");
            Console.WriteLine("             >=>        >=>     >=>       >=>  >=>    >=>            ");
            Console.WriteLine("             >=>        >=>     >=> >=>    >=> >=>    >=>            ");
            Console.WriteLine("             >=>          >====>      >=>>=>   >=>    >=>            ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    public static class PullTitle
    {
        public static void Pull()

        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine(".:::::::  .:::::::  .::           .::        .::                 .::                         .::  ");
            Console.WriteLine(".::    .::.::    .::.::           .::        .::                 .::                         .::  ");
            Console.WriteLine(".::    .::.::    .::.::           .::   .:   .::   .::    .: .:::.::  .::   .::    .::  .::.:.: .:");
            Console.WriteLine(".:::::::  .:::::::  .::           .::  .::   .:: .::  .::  .::   .:: .::  .::  .:: .::  .::  .::  ");
            Console.WriteLine(".::       .::       .::           .:: .: .:: .::.::    .:: .::   .:.::   .::    .::.::  .::  .::  ");
            Console.WriteLine(".::       .::       .::           .: .:    .:::: .::  .::  .::   .:: .::  .::  .:: .::  .::  .::  ");
            Console.WriteLine(".::       .::       .::::::::     .::        .::   .::    .:::   .::  .::   .::      .::.::   .:: ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("             >======>   >=>     >=> >=>       >=>                   ");
            Console.WriteLine("             >=>    >=> >=>     >=> >=>       >=>                   ");
            Console.WriteLine("             >=>    >=> >=>     >=> >=>       >=>                   ");
            Console.WriteLine("             >======>   >=>     >=> >=>       >=>                   ");
            Console.WriteLine("             >=>        >=>     >=> >=>       >=>                   ");
            Console.WriteLine("             >=>        >=>     >=> >=>       >=>                   ");
            Console.WriteLine("             >=>          >====>    >======>  >======>              ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public static class LegsTitle
    {
        public static void Legs()

        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine(".:::::::  .:::::::  .::           .::        .::                 .::                         .::  ");
            Console.WriteLine(".::    .::.::    .::.::           .::        .::                 .::                         .::  ");
            Console.WriteLine(".::    .::.::    .::.::           .::   .:   .::   .::    .: .:::.::  .::   .::    .::  .::.:.: .:");
            Console.WriteLine(".:::::::  .:::::::  .::           .::  .::   .:: .::  .::  .::   .:: .::  .::  .:: .::  .::  .::  ");
            Console.WriteLine(".::       .::       .::           .:: .: .:: .::.::    .:: .::   .:.::   .::    .::.::  .::  .::  ");
            Console.WriteLine(".::       .::       .::           .: .:    .:::: .::  .::  .::   .:: .::  .::  .:: .::  .::  .::  ");
            Console.WriteLine(".::       .::       .::::::::     .::        .::   .::    .:::   .::  .::   .::      .::.::   .:: ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("             >=>       >=======>    >===>      >=>>=>               ");
            Console.WriteLine("             >=>       >=>        >>    >=>  >=>    >=>             ");
            Console.WriteLine("             >=>       >=>       >=>          >=>                   ");
            Console.WriteLine("             >=>       >=====>   >=>            >=>                 ");
            Console.WriteLine("             >=>       >=>       >=>   >===>       >=>              ");
            Console.WriteLine("             >=>       >=>        >=>    >>  >=>    >=>             ");
            Console.WriteLine("             >=======> >=======>   >====>      >=>>=>               ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
