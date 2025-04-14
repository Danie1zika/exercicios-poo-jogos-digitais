using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_13.model
{
    public class Mago : CartaBase
    {
        public Mago(string nome) : base(nome, 20, 10) {}

        public override void UsarHabilidade(CartaBase alvo)
        {
            Console.WriteLine($"{Nome} lança Bola de Fogo em {alvo.Nome}!");
            alvo.ReceberDano(Ataque * 2);
        }
    }
}