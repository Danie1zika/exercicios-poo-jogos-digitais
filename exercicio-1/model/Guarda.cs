using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_1.model
{
    public class Guarda : NPC
    {
        public string movimentacao;
        public string interacao;
        public Guarda(string movimentacao, string interacao)
        {
            this.movimentacao = movimentacao;
            this.interacao = interacao;
        }

        public void Mover() {
        Console.WriteLine("Os Guardas fazem a ronda pelo castelo");
        }
        public void Interagir() {
        Console.WriteLine("(Guarda)...");
        Console.WriteLine("");
        }
    }
}