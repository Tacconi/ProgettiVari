using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodice
{
    public class Semaforo
    {
        public Semaforo()
        {

        }

        public Semaforo(int Intervallo)
        {

        }

        public Task<int> Start()
        {
            return Task.Factory.StartNew(() => Esecuzione());
        }

        public int Esecuzione()
        {
            int resp;
            resp = 0;

            //TimeSpan timer = new TimeSpan();
            //timer.Seconds            
            return resp;

        }
        
    }
}
