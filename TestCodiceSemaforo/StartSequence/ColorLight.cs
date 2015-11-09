using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartSequence
{
    public class ColorLight
    {
        public LightColor Light { get; set; }
        public SoundType Sound { get; set; }
        public object Ellispe { get; set; }

        public ColorLight(LightColor light, SoundType sound, object ellipse)
        {
            Light = light;
            Sound = sound;
            Ellispe = ellipse;
        }
    }
}
