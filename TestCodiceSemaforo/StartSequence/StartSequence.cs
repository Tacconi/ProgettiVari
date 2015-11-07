using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartSequence
{
    public class SequenceEventArgs : EventArgs
    {
        public LightColor Light { get; set; } //Luce
        public SoundType Sound { get; set; } //Suono

    }

    public class StartSequence
    {
        public event EventHandler<SequenceEventArgs> SequenceChange; //evento per cambio colore e suono

        public StartSequence()
        {

        }

        public StartSequence(int stepIntervall)
        {

        }
        public void Start()
        {

        }
        public void Abort()
        {

        }



    }
}
