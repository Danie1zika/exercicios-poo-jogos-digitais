using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_5.model
{
    class Personagem
{
    public string Nome { get; }
    public int Vida { get; private set; }
    public int Mana { get; private set; }

    public Personagem(string nome, int vida, int mana)
    {
        Nome = nome;
        Vida = vida;
        Mana = mana;
    }

    public void UsarHabilidade(Habilidade habilidade, Personagem alvo)
    {
        if (Mana < habilidade.CustoDeMana)
        {
            Console.WriteLine($"{Nome} não tem mana suficiente para usar {habilidade.Nome}!");
            return;
        }

        Mana -= habilidade.CustoDeMana;
        habilidade.Executar(alvo, this);
    }

    public void ReceberDano(int dano)
    {
        Vida -= dano;
        if (Vida < 0) Vida = 0;
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"{Nome} - Vida: {Vida} | Mana: {Mana}");
    }
}
}