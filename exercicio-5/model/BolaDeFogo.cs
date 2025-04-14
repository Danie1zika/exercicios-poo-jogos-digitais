using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_5.model
{
    class BolaDeFogo : Habilidade
{
    public BolaDeFogo() : base("Bola de Fogo", 20, 30) { }

    public override void Executar(Personagem alvo, Personagem lancador)
    {
        Console.WriteLine($"{lancador.Nome} lança {Nome} em {alvo.Nome}, causando {Dano} de dano!");
        alvo.ReceberDano(Dano);
    }
}
}