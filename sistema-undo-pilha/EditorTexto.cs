using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_undo_pilha
{
    public class EditorTexto
    {
        public Pilha Historico { get; private set; }
        public EditorTexto ProximoTexto { get; set; }
        public string texto { get; set; }
        public EditorTexto()
        {
            this.Historico = new Pilha();
        }

        public void Digitar(EditorTexto message)
        {
            this.Historico.Empilhar(message);
        }

        public EditorTexto Desfazer()
        {
            if (this.Historico.Vazia())
            {
                Console.WriteLine("Nada para desfazer");
                return null;
            }
            else
            {
                return this.Historico.Desempilhar();
            }
        }

        public void MostrarHistorico()
        {
            this.Historico.ExibirPilha();
        }
    }
}
