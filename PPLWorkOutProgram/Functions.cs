using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLWorkOutProgram
{
    public class Functions
    {
        public void BPOutput1(BenchPress BP, int intBenchPressMax)
        {
            Console.WriteLine(BP.Name + " description: " + BP.Description);
            Console.WriteLine("Bench Press Warmup:");
            Console.WriteLine("First set: 10 reps at " + (intBenchPressMax * 0.5) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intBenchPressMax * .6) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intBenchPressMax * .75) + "lbs.");
            Console.ReadLine();

        }
        public void BPOutput2(BenchPress BP, int intBenchPressMax)
        {
            Console.WriteLine(BP.Name + " description: " + BP.Description);
            Console.WriteLine("Bench Press Warmup:");
            Console.WriteLine("First set: 10 reps at " + (intBenchPressMax * 0.5) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intBenchPressMax * .6) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intBenchPressMax * .7) + "lbs.");
            Console.ReadLine();
        }
        public void BPOutput3(BenchPress BP, int intBenchPressMax)
        {
            Console.WriteLine(BP.Name + " Description: " + BP.Description);
            Console.WriteLine("Bench Press Warmup:");
            Console.WriteLine("First set: 10 reps at " + (intBenchPressMax * 0.5) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intBenchPressMax * .6) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intBenchPressMax * .65) + "lbs.");
            Console.ReadLine();
        }
        public void OHOutput(OverHeadPress OH, int intBenchPressMax)
        {
            Console.WriteLine(OH.Name + " Description: " + OH.Description);
            Console.WriteLine("First set: 10 reps at " + (intBenchPressMax * 0.2) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intBenchPressMax * .3) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intBenchPressMax * .4) + "lbs.");
            Console.ReadLine();
        }
        public void TCOutput(TriCepExtension TC, int intBenchPressMax)
        {
            Console.WriteLine(TC.Name + " Description: " + TC.Description);
            Console.ReadLine() ;
            Console.WriteLine("Accessory sets: 3 sets of 10 at weight that can be performed while maintaining good form");
            Console.ReadLine();
        }
    }
}
