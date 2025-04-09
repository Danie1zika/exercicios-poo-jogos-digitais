using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_1.model
{
    public class Vilão : NPC
    {
        public string movimentacao;
        public string interacao;
        public Vilão(string movimentacao, string interacao)
        {
            this.movimentacao = movimentacao;
            this.interacao = interacao;
        }

        public void Mover() {
            Console.WriteLine("Vilão se esconde nas sombras esperando o momento certo para atacar de surpresa");
        }
        public void Interagir() {
            Console.WriteLine("Inicia-se uma cutscene");
        }
    }
}