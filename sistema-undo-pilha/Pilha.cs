using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_undo_pilha
{
    public class Pilha
    {
        public string[] Elementos { get; private set; }
        public int Head { get; private set; }

        public Pilha()
        {
            this.Elementos = new string[10];
        }

        public void Empilhar(string elemento)
        {
            if (elemento == null)
            {
                Console.WriteLine("Elemento nulo");
            }
            else
            {
                if (this.Cheia())
                {
                    Console.WriteLine("Pilha cheia");
                }
                else
                {
                    this.Elementos[this.Head] = elemento;
                    this.Head++;
                }
            }
        }

        public string Desempilhar()
        {
            if (this.Vazia())
            {
                return "Pilha vazia";
            }
            else
            {
                this.Head--;
                string elemento = this.Elementos[this.Head];
                this.Elementos[this.Head] = null;
                return elemento;
            }
        }

        public bool Vazia()
        {
            if (this.Head == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Cheia()
        {
            if (this.Head == this.Elementos.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ExibirPilha()
        {
            for (int i = this.Head - 1; i >= 0; i--)
            {
                Console.WriteLine(this.Elementos[i]);
            }
        }
    }
}
