using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_design
{
    public abstract class Veicolo
    {
        private int postidisponibili;
        public Veicolo(int postiIniziali)
        {
            this.postidisponibili = postiIniziali;
        }

        public virtual void Siediti()
        {
            int postiAttuali = postidisponibili--;
        }

        // difference between virtual and abstract 
        public virtual void Alzati()
        {
            int postiAttuali = postidisponibili++;
        }


        public int GetPostiDisponibili()
        {
            return postidisponibili;
        }
    }
}
