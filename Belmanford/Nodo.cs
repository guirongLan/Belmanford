using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belmanford
{
    class Nodo:IEquatable<Nodo>
    {
        public string nome;//nome della vertice
        public int peso;//il suo peso
        public Nodo precedente;//mi serve ricordare i passaggi minimi
        public bool utilizzato;//per sapere se ho gia passato
        public Nodo()
        {
            nome = "IDK";
            peso = Int32.MaxValue;
            precedente = null;
            utilizzato = false;
        }
        public Nodo(string nome, int peso)
        {
            this.nome = nome;
            this.peso = peso;
            precedente = null;
            utilizzato = false;
        }
        public void StampaNodo()
        {
            Console.WriteLine(nome + ";" + peso+";");
        }

        public Nodo CambiaPeso(Nodo a,int pesodacambiare)
        {
            a.peso = pesodacambiare;
            return  a;
        }

        public bool Equals(Nodo other)
        {
            if (nome == other.nome)
            {
                return true;
            }
            return false;
        }
    }
}
