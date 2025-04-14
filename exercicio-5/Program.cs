using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio_5.model;

// Classe base Habilidade

// Subclasses específicas de habilidades

// Classe do personagem

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        // Criando personagens
        Personagem jogador = new Personagem("Herói", 100, 50);
        Personagem inimigo = new Personagem("Goblin", 40, 0);

        // Criando habilidades
        Habilidade bolaDeFogo = new BolaDeFogo();
        Habilidade raioDeGelo = new RaioDeGelo();
        Habilidade golpeDeEspada = new GolpeDeEspada();

        jogador.MostrarStatus();
        inimigo.MostrarStatus();

        Console.WriteLine();

        // Usar habilidades
        jogador.UsarHabilidade(bolaDeFogo, inimigo);
        jogador.UsarHabilidade(raioDeGelo, inimigo);
        jogador.UsarHabilidade(golpeDeEspada, inimigo); // pode não ter mana pra todas

        Console.WriteLine();

        jogador.MostrarStatus();
        inimigo.MostrarStatus();
    }
}
