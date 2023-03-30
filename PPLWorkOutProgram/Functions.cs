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
        public double BPOutput1(BenchPress BP, int intBenchPressMax)
        {
            double firstSetWeight = intBenchPressMax * 0.5;
            double firstSetVolume = firstSetWeight * 10;
            double secondSetWeight = intBenchPressMax * 0.6;
            double secondSetVolume = secondSetWeight * 5;
            double workingSetWeight = intBenchPressMax * 0.75;
            double workingSetVolume = workingSetWeight * 15;
            double volumeLifted = firstSetVolume + secondSetVolume + workingSetVolume;

            Console.WriteLine(BP.Name + " description: " + BP.Description);
            BP.warmUp();
            Console.WriteLine("First set: 10 reps at " + firstSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + secondSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + workingSetWeight + "lbs.");
            Console.ReadLine();
            return volumeLifted;    
        }
        public double BPOutput2(BenchPress BP, int intBenchPressMax)
        {
            double firstSetWeight = intBenchPressMax * 0.5;
            double firstSetVolume = firstSetWeight * 10;
            double secondSetWeight = intBenchPressMax * 0.6;
            double secondSetVolume = secondSetWeight * 5;
            double workingSetWeight = intBenchPressMax * 0.75;
            double workingSetVolume = workingSetWeight * 15;
            double volumeLifted = firstSetVolume + secondSetVolume + workingSetVolume;

            Console.WriteLine(BP.Name + " description: " + BP.Description);
            BP.warmUp();
            Console.WriteLine("First set: 10 reps at " + firstSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + secondSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + workingSetWeight + "lbs.");
            Console.ReadLine();
            return volumeLifted;
        }
        public double BPOutput3(BenchPress BP, int intBenchPressMax)
        {
            double firstSetWeight = intBenchPressMax * 0.5;
            double firstSetVolume = firstSetWeight * 10;
            double secondSetWeight = intBenchPressMax * 0.6;
            double secondSetVolume = secondSetWeight * 5;
            double workingSetWeight = intBenchPressMax * 0.75;
            double workingSetVolume = workingSetWeight * 15;
            double volumeLifted = firstSetVolume + secondSetVolume + workingSetVolume;

            Console.WriteLine(BP.Name + " description: " + BP.Description);
            BP.warmUp();
            Console.WriteLine("First set: 10 reps at " + firstSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + secondSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + workingSetWeight + "lbs.");
            Console.ReadLine();
            return volumeLifted;
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
        public double DLOutput1(Deadlift DL, int intDeadliftMax)
        {
            double firstSetWeight = intDeadliftMax * 0.5;
            double firstSetVolume = firstSetWeight * 10;
            double secondSetWeight = intDeadliftMax * 0.6;
            double secondSetVolume = secondSetWeight * 5;
            double workingSetWeight = intDeadliftMax * 0.75;
            double workingSetVolume = workingSetWeight * 15;
            double volumeLifted = firstSetVolume + secondSetVolume + workingSetVolume;

            Console.WriteLine(DL.Name + " description: " + DL.Description);
            DL.warmUp();
            Console.WriteLine("First set: 10 reps at " + firstSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + secondSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + workingSetWeight + "lbs.");
            Console.ReadLine();
            return volumeLifted;

        }
        public double DLOutput2(Deadlift DL, int intDeadliftMax)
        {
            double firstSetWeight = intDeadliftMax * 0.5;
            double firstSetVolume = firstSetWeight * 10;
            double secondSetWeight = intDeadliftMax * 0.6;
            double secondSetVolume = secondSetWeight * 5;
            double workingSetWeight = intDeadliftMax * 0.75;
            double workingSetVolume = workingSetWeight * 15;
            double volumeLifted = firstSetVolume + secondSetVolume + workingSetVolume;

            Console.WriteLine(DL.Name + " description: " + DL.Description);
            DL.warmUp();
            Console.WriteLine("First set: 10 reps at " + firstSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + secondSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + workingSetWeight + "lbs.");
            Console.ReadLine();
            return volumeLifted;
        }
        public double DLOutput3(Deadlift DL, int intDeadliftMax)
        {
            double firstSetWeight = intDeadliftMax * 0.5;
            double firstSetVolume = firstSetWeight * 10;
            double secondSetWeight = intDeadliftMax * 0.6;
            double secondSetVolume = secondSetWeight * 5;
            double workingSetWeight = intDeadliftMax * 0.75;
            double workingSetVolume = workingSetWeight * 15;
            double volumeLifted = firstSetVolume + secondSetVolume + workingSetVolume;

            Console.WriteLine(DL.Name + " description: " + DL.Description);
            DL.warmUp();
            Console.WriteLine("First set: 10 reps at " + firstSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + secondSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + workingSetWeight + "lbs.");
            Console.ReadLine();
            return volumeLifted;
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
        public double SQOutput1(Squat SQ, int intSquatMax)
        {
            double firstSetWeight = intSquatMax * 0.5;
            double firstSetVolume = firstSetWeight * 10;
            double secondSetWeight = intSquatMax * 0.6;
            double secondSetVolume = secondSetWeight * 5;
            double workingSetWeight = intSquatMax * 0.75;
            double workingSetVolume = workingSetWeight * 15;
            double volumeLifted = firstSetVolume + secondSetVolume + workingSetVolume;

            Console.WriteLine(SQ.Name + " description: " + SQ.Description);
            SQ.warmUp();
            Console.WriteLine("First set: 10 reps at " + firstSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + secondSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + workingSetWeight + "lbs.");
            Console.ReadLine();
            return volumeLifted;
        }
        public double SQOutput2(Squat SQ, int intSquatMax)
        {
            double firstSetWeight = intSquatMax * 0.5;
            double firstSetVolume = firstSetWeight * 10;
            double secondSetWeight = intSquatMax * 0.6;
            double secondSetVolume = secondSetWeight * 5;
            double workingSetWeight = intSquatMax * 0.75;
            double workingSetVolume = workingSetWeight * 15;
            double volumeLifted = firstSetVolume + secondSetVolume + workingSetVolume;

            Console.WriteLine(SQ.Name + " description: " + SQ.Description);
            SQ.warmUp();
            Console.WriteLine("First set: 10 reps at " + firstSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + secondSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + workingSetWeight + "lbs.");
            Console.ReadLine();
            return volumeLifted;
        }
        public double SQOutput3(Squat SQ, int intSquatMax)
        {
            double firstSetWeight = intSquatMax * 0.5;
            double firstSetVolume = firstSetWeight * 10;
            double secondSetWeight = intSquatMax * 0.6;
            double secondSetVolume = secondSetWeight * 5;
            double workingSetWeight = intSquatMax * 0.75;
            double workingSetVolume = workingSetWeight * 15;
            double volumeLifted = firstSetVolume + secondSetVolume + workingSetVolume;

            Console.WriteLine(SQ.Name + " description: " + SQ.Description);
            SQ.warmUp();
            Console.WriteLine("First set: 10 reps at " + firstSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Second set: 5 reps at " + secondSetWeight + "lbs.");
            Console.ReadLine();
            Console.WriteLine("Working sets: 3 sets of 5 reps at " + workingSetWeight + "lbs.");
            Console.ReadLine();
            return volumeLifted;
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
