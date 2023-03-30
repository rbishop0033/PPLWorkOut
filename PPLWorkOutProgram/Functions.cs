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
            BP.warmUp();
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
            BP.warmUp();
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
            BP.warmUp();
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
            OH.warmUp();
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
            Console.ReadLine();
            Console.WriteLine("Accessory sets: 3 sets of 10 at weight that can be performed while maintaining good form");
            Console.ReadLine();
        }
        public void DLOutput1(Deadlift DL, int intDeadliftMax)
        {
            Console.WriteLine(DL.Name + " description: " + DL.Description);
            DL.warmUp();
            Console.WriteLine("First set: 10 reps at " + (intDeadliftMax * 0.5) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intDeadliftMax * .6) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intDeadliftMax * .75) + "lbs.");
            Console.ReadLine();

        }
        public void DLOutput2(Deadlift DL, int intDeadliftMax)
        {
            Console.WriteLine(DL.Name + " description: " + DL.Description);
            DL.warmUp();
            Console.WriteLine("First set: 10 reps at " + (intDeadliftMax * 0.5) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intDeadliftMax * .6) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intDeadliftMax * .7) + "lbs.");
            Console.ReadLine();
        }
        public void DLOutput3(Deadlift DL, int intDeadliftMax)
        {
            Console.WriteLine(DL.Name + " Description: " + DL.Description);
            DL.warmUp();
            Console.WriteLine("First set: 10 reps at " + (intDeadliftMax * 0.5) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intDeadliftMax * .6) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intDeadliftMax * .65) + "lbs.");
            Console.ReadLine();
        }
        public void LPOutput(LatPullDown LP, int intBenchPressMax)
        {
            Console.WriteLine(LP.Name + " Description: " + LP.Description);
            LP.warmUp();
            Console.WriteLine("First set: 10 reps at " + (intBenchPressMax * 0.2) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intBenchPressMax * .3) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intBenchPressMax * .4) + "lbs.");
            Console.ReadLine();
        }
        public void FPOutput(FacePulls FP, int intBenchPressMax)
        {
            Console.WriteLine(FP.Name + " Description: " + FP.Description);
            Console.ReadLine();
            Console.WriteLine("Accessory sets: 3 sets of 10 at weight that can be performed while maintaining good form");
            Console.ReadLine();

        }
        public void SQOutput1(Squat SQ, int intSquatMax)
        {
            Console.WriteLine(SQ.Name + " description: " + SQ.Description);
            SQ.warmUp();
            Console.WriteLine("First set: 10 reps at " + (intSquatMax * 0.5) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intSquatMax * .6) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intSquatMax * .75) + "lbs.");
            Console.ReadLine();

        }
        public void SQOutput2(Squat SQ, int intSquatMax)
        {
            Console.WriteLine(SQ.Name + " description: " + SQ.Description);
            SQ.warmUp();
            Console.WriteLine("First set: 10 reps at " + (intSquatMax * 0.5) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intSquatMax * .6) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intSquatMax * .7) + "lbs.");
            Console.ReadLine();
        }
        public void SQOutput3(Squat SQ, int intSquatMax)
        {
            Console.WriteLine(SQ.Name + " Description: " + SQ.Description);
            SQ.warmUp();
            Console.WriteLine("First set: 10 reps at " + (intSquatMax * 0.5) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intSquatMax * .6) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intSquatMax * .65) + "lbs.");
            Console.ReadLine();
        }
        public void LPROutput(LegPress LPR, int intSquatMax)
        {
            Console.WriteLine(LPR.Name + " Description: " + LPR.Description);
            LPR.warmUp();
            Console.WriteLine("First set: 10 reps at " + (intSquatMax * 0.2) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + (intSquatMax * .3) + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + (intSquatMax * .4) + "lbs.");
            Console.ReadLine();
        }
        public void LEOutput(LegExtension LE, int intSquatMax)
        {
            Console.WriteLine(LE.Name + " Description: " + LE.Description);
            Console.ReadLine();
            Console.WriteLine("Accessory sets: 3 sets of 10 at weight that can be performed while maintaining good form");
            Console.ReadLine();

        }
    }
}
