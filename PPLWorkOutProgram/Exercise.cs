using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLWorkOutProgram
{
    public class Exercise // will be primary class that will share inheritance with other excercises.
    {

        public string Name;
        public string Description;
        public string Weight;
        public string type = "WarmUp";
        public void warmUp()
        {
            Console.WriteLine("Warmup: Perform 10 reps at very light weight to get prepared for exercise");
        }

        
    }
}
