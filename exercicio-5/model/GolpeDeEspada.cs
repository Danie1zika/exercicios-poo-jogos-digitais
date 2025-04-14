using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_5.model
{
    class GolpeDeEspada : Habilidade
{
    public GolpeDeEspada() : base("Golpe de Espada", 5, 10) { }

    public override void Executar(Personagem alvo, Personagem lancador)
    {
        Console.WriteLine($"{lancador.Nome} realiza um {Nome} contra {alvo.Nome}, causando {Dano} de dano!");
        alvo.ReceberDano(Dano);
    }
}
}