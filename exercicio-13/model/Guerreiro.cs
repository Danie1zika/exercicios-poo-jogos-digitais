using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_13.model
{
    public class Guerreiro : CartaBase
    {
        public Guerreiro(string nome) : base(nome, 30, 8) {}

        public override void UsarHabilidade(CartaBase alvo)
        {
            Console.WriteLine($"{Nome} usa Golpe Pesado em {alvo.Nome}!");
            alvo.ReceberDano(Ataque + 5);
        }
    }
}