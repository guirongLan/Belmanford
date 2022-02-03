using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belmanford
{
    class Arco
    {
        public Nodo inizio, fine;
        public int costoArco;
        public bool passato;
        public Arco()
        {
            inizio = fine = null;
            costoArco = 0;
            passato = false;
        }
        public Arco(Nodo inizio, Nodo fine, int costo)
        {
            this.inizio = inizio;
            this.fine = fine;
            costoArco = costo;
            passato = false;
        }

    }
}
