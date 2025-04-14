using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_14.model
{
    public class Jogador
    {
        public string Nome { get; private set; }

        public Jogador(string nome)
        {
            Nome = nome;
        }

        public void InteragirComNPC(NPC npc)
        {
            Console.WriteLine($"\n{Nome} interage com {npc.Nome}...");
            npc.IniciarDialogo();
        }
    }
}