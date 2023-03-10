using PPLWorkOutProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PPLWorkOutProgram
{
    public class Deadlift : Exercise
    {

        public string Equipment;
        public Deadlift()
        {

            Name = "Deadlift";
            Equipment = "Barbell with weight plates";
            Description = "Bend down to barbell with hinge at hips. While maintaining straight lower back, pull bar up and close hip hinge";

        }

    }
    public class LatPullDown : Exercise
    {
        public string Equipmemt;
        public LatPullDown()
        {
            Name = "Lat Pulldown";
            Description = "While sitting grasp bar from overhead. Pull down to chest and squeeze lats at bottom";

        }
    }
    public class FacePulls : Exercise
    {
        public FacePulls()
        {
            Name = "Facepull";
            Description = "Using a rope or other cable attachment, pull towards face and roll shoulders outward";

        }
    }
}

