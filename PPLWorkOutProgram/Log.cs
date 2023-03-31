using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PPLWorkOutProgram
{
    public class WorkOutLog
    {
        public static void LogWorkout()
        {
            // Write file using StreamWriter 
            string fullpath = @".\WorkoutLog.dat";
            string readText = "";
            if (File.Exists(fullpath)) 
            {
                readText = File.ReadAllText(fullpath);
            }
            using (StreamWriter writer = new StreamWriter(fullpath))
            {
                writer.WriteLine(readText);
                writer.WriteLine("Workout complete");
                writer.WriteLine(DateTime.Now.ToString());

            }  
        }
    }
}

