using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PPLWorkOutProgram
{
    public class BenchPress : Exercise
    {
        public string Equipment;
        public BenchPress() 
        {
             
            Name = "Bench Press";
            Description = "While laying flat on back, lower barbell to chest, then push back up";
            

        } 

    }
    public class OverHeadPress : Exercise 
    {
        public string Stance;
        public OverHeadPress() 
        {
            Name = "Overhead Press";
            Description = "Can be performed sitting or standing. Hold bar at chin level press up to extend arms above head";

        } 
    }
    public class TriCepExtension : Exercise
        { public TriCepExtension() 
            {
            Name = "Tricep Extension";
            Description = "Using a rope or other cable attachment, keeping elbows still press down to straighten arms. Squeeze triceps at bottom of lift";

            } 
        }
}
