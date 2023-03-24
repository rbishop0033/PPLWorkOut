using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLWorkOutProgram
{
    // Typically you only want one class per file. Since this whole file is called Squat,
    // but it also has other lower leg exercises in it, it's a little confusing.
    // Don't be afraid to make folders and organize. For example, a more helpful structure might be:
    //
    // exercises(folder)/
    // ├─ Exercise.cs
    // ├─ push(folder)/
    // │  ├─ BenchPress.cs
    // │  ├─ OverheadPress.cs
    // │  ├─ TricepExtension.cs
    // ├─ pull(folder)/
    // │  ├─ Deadlift.cs
    // │  ├─ LatPulldown.cs
    // │  ├─ FacePulls.cs
    // ├─ legs(folder)/
    // │  ├─ Squat.cs
    // │  ├─ LegPress.cs
    // │  ├─ LegExtension.cs
    //
    // So now you have all your Exercises, organized by which type(PPL), each within their own sub folders
    // And Exercise.cs being the parent class, can just hang in the parent Exercises directory.
    public class Squat : Exercise
    {
        public string Equipment;
        public Squat()
        {

            Name = "Squat";
            Equipment = "Barbell with weight plates, preferably in a squat rack or stand";
            Description = "With barbell on across back, bend down until knees are parallel with floor while keeping knees in line with shoulders";
        }

    }
    public class LegPress : Exercise
    {
        public string Equipmemt;
        public LegPress()
        {
            Name = "Leg Press";
            Description = "Using LP machine, push platform away using same foot placement/path as squat";

        }
    }
    public class LegExtension : Exercise
    {
        public LegExtension()
        {
            Name = "Leg Extension";
            Description = "Can be done with both legs or single. While seated lift leg and squeeze quad at top of movement";

        }
    }
}
