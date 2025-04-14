using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_5.model
{
    class RaioDeGelo : Habilidade
{
    public RaioDeGelo() : base("Raio de Gelo", 15, 20) { }

    public override void Executar(Personagem alvo, Personagem lancador)
    {
        Console.WriteLine($"{lancador.Nome} dispara {Nome} em {alvo.Nome}, causando {Dano} de dano!");
        alvo.ReceberDano(Dano);
    }
}
}