using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Timers;

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
        private int Intervall { get; set; }
        private Timer timer;

        public StartSequence()
        {
            timer = new Timer();            
            Intervall = 0;
        }

        public StartSequence(int stepIntervall)
        {
            Intervall = stepIntervall;
        }

        public void Start()
        {
            timer.Elapsed += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, ElapsedEventArgs e)
        {
            if (Intervall < 5)
            {
                OnSequenceChange(LightColor.Red, SoundType.Change); // 5 secondi
            }

            if (Intervall < 10)
            {
                OnSequenceChange(LightColor.Yellow, SoundType.Change); //5secondi
            }

            if (Intervall < 11)
            {
                OnSequenceChange(LightColor.Sec5, SoundType.Change); //1 secondo
            }

            if (Intervall < 12)
            {
                OnSequenceChange(LightColor.Sec4, SoundType.Change); //1 secondo
            }

            if (Intervall < 13)
            {
                OnSequenceChange(LightColor.Sec3, SoundType.Change); //1 secondo
            }

            if (Intervall < 14)
            {
                OnSequenceChange(LightColor.Sec2, SoundType.Change); //1 secondo
            }

            if (Intervall < 15)
            {
                OnSequenceChange(LightColor.Sec1, SoundType.Change); //1 secondo
            }

            if (Intervall > 15)
            {
                OnSequenceChange(LightColor.Green, SoundType.Start); //fissa
            }

            Intervall++;
        }

        private void OnSequenceChange(LightColor light, SoundType sound)
        {
            if (SequenceChange != null)
                SequenceChange(this, new SequenceChangeEventArgs() { Light = light, Sound = sound });
        }

        public void Abort()
        {
            timer.Stop();
        }
    }
}
