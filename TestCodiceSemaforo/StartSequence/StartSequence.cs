using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartSequence
{
    public class SequenceChangeEventArgs : EventArgs
    {
        public LightColor Light { get; set; } //Luce
        public SoundType Sound { get; set; } //Suono

    }

    public class StartSequence
    {
        public event EventHandler<SequenceChangeEventArgs> SequenceChange; //evento per cambio colore e suono

        public StartSequence()
        {

        }

        public StartSequence(int stepIntervall)
        {

        }
        public void Start()
        {
            TimeSpan Change = new TimeSpan(0, 0, 5);
            OnSequenceChange(LightColor.Red, SoundType.Change); // 5 secondi
            //subito dopo
            OnSequenceChange(LightColor.Yellow, SoundType.Change); //5secondi
            // subito dopo 
            OnSequenceChange(LightColor.Sec5, SoundType.Change); //1 secondo
            OnSequenceChange(LightColor.Sec4, SoundType.Change); //1 secondo
            OnSequenceChange(LightColor.Sec3, SoundType.Change); //1 secondo
            OnSequenceChange(LightColor.Sec2, SoundType.Change); //1 secondo
            OnSequenceChange(LightColor.Sec1, SoundType.Change); //1 secondo
            //subito dopo 
            OnSequenceChange(LightColor.Green, SoundType.Start); //fissa

        }

        private void OnSequenceChange(LightColor light, SoundType sound)
        {
            if (SequenceChange != null)
                SequenceChange(this, new SequenceChangeEventArgs() { Light = light, Sound = sound });
        }

        public void Abort()
        {

        }



    }
}
