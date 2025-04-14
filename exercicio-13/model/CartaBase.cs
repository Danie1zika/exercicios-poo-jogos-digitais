using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_13.model
{
     public abstract class CartaBase
    {
        public string Nome { get; protected set; }
        public int Vida { get; protected set; }
        public int Ataque { get; protected set; }

        public bool EstaViva => Vida > 0;

        public CartaBase(string nome, int vida, int ataque)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
        }

        public virtual void Atacar(CartaBase alvo)
        {
            Console.WriteLine($"{Nome} ataca {alvo.Nome} causando {Ataque} de dano.");
            alvo.ReceberDano(Ataque);
        }

        public void ReceberDano(int dano)
        {
            Vida -= dano;
            if (Vida < 0) Vida = 0;
        }

        public abstract void UsarHabilidade(CartaBase alvo);
    }
}