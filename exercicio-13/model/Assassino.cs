using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_13.model
{
    public class Assassino : CartaBase
    {
        public Assassino(string nome) : base(nome, 25, 7) {}

        public override void UsarHabilidade(CartaBase alvo)
        {
            Console.WriteLine($"{Nome} realiza Ataque Crítico em {alvo.Nome}!");
            alvo.ReceberDano(Ataque + 10);
        }
    }
}