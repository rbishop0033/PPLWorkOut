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
    }

    public class UserInput
    {
        // This field is probably better suited to be an int,
        // since you are only ever asking the user to enter an integer value
        public string choice { get; set; }
        // This field could be a bool since it basically just represents yes/no
        public string continueChoice { get; set; }
    }
    public static class PushTitle
    {
        public static void Push()

        {
            // Since you already have a method that writes the 'main title screen', you can just call that here.
            // You can do this in the other title screen methods as well. This helps in two ways:
            // 1. Eliminates duplicated code
            // 2. Keeps the main title screen consistant. If you wanted to change the Title screen art to "LPP WORKOUT" instead, you only change it in one place and not four different places
            TitleScreen.Title();

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
