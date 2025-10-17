using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_undo_pilha
{
    public class Pilha
    {
        public EditorTexto Head { get; private set; }
        public int contador { get; set; }

        public Pilha()
        {
            this.contador = 0;
            this.Head = null;
        }

        public void Empilhar(EditorTexto elemento)
        {
            if (this.Vazia())
            {
                this.Head = elemento;
                this.contador++;
            }
            else
            {
                if (this.Cheia())
                {
                    Console.WriteLine("Pilha cheia");
                }
                else
                {
                    elemento.ProximoTexto = this.Head;
                    this.Head = elemento;
                    this.contador++;
                }
            }
        }

        public EditorTexto Desempilhar()
        {
            if (this.Vazia())
            {
                return null;
            }
            else
            {
                EditorTexto aux = this.Head;
                this.Head = this.Head.ProximoTexto;
                if(this.Head == null)
                {
                    this.Head = null;
                    this.contador = 0;
                }
                if (this.contador > 0)
                {
                    this.contador--;
                }
                return aux;
            }
        }

        public bool Vazia()
        {
            if(Head == null)
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
            if (this.contador == 10)
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
            if (this.Vazia())
            {
                Console.WriteLine("Pilha vazia");
            }
            else
            {
                EditorTexto aux = this.Head;
                do
                {
                    Console.WriteLine($"Mensagem: {aux.texto}");
                    aux = aux.ProximoTexto;
                } while (aux != null);
            }
        }
    }
}
