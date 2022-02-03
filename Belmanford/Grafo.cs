using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belmanford
{
    class Grafo
    {
        public List<Nodo> Nodi = new List<Nodo>();
        public List<Arco> Archi = new List<Arco>();

        public Grafo(List<Nodo> Nodi, List<Arco> Archi)
        {
            this.Nodi = Nodi;
            this.Archi = Archi;
        }

        void inizializzazioneBF(Nodo inizio)
        {
            inizio.peso = 0;//peso 0
            foreach (Nodo a in Nodi)
            {
                if (!a.nome.Equals(inizio.nome))// tutti gli altri hanno un peso infinito
                {
                    a.peso = Int32.MaxValue;
                }
            }
        }
        public void BellmanFord(Nodo a)
        { 
            inizializzazioneBF(a);//inizializzo
            for (int i = 0; i < Nodi.Count - 1; i++)//faccio n-1 volte
            {
                bool check = false;
                foreach (Arco item in Archi)//prendo tutti gli archi 
                {
                    if (item.inizio.peso != Int32.MaxValue)//quelli che non sono stato inizialklizato non lo tocco
                    {
                        if (item.fine.peso > item.costoArco + item.inizio.peso)//se c è maggiore di a + b cambio il suo valore
                        {
                            item.fine.peso = item.costoArco + item.inizio.peso;
                            check = true;
                        }
                    }
                }
                if (!check)
                {
                    break;//vuol dire che non sono stati chambiamenti quindi posso fermanre prima
                }
            }
            //per controllare se il grafo ci sono cicli o no
            bool verifica = false;
            foreach (Arco item in Archi)
            {
                if (item.inizio.peso != Int32.MaxValue)
                {
                    if (item.fine.peso > item.costoArco + item.inizio.peso)
                    {
                        item.fine.peso = item.costoArco + item.inizio.peso;
                        verifica = true;
                    }
                }
            }
            if (verifica == true)
            {
                Console.WriteLine("ci sono cicli al interno ");
            }
            else
            {
                Console.WriteLine("grafo minimo fatto con Bellman ford");
                foreach (Nodo nodo in Nodi)
                {
                    nodo.StampaNodo();
                }
                
            }
            
        }
    }
}
