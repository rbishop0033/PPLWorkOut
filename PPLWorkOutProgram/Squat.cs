using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLWorkOutProgram
{
    public class Squat : Exercise
    {
        public string Equipment;
        public Squat()
        {

            Name = "Squat";
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
