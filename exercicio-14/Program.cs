using System;
using exercicio_14.model;

class Program
{
    static void Main(string[] args)
    {
        var jogador = new Jogador("Wanderson");
        var npc = new NPC("Guardião da Floresta");

        jogador.InteragirComNPC(npc);

        // Aguardar a resposta do jogador
        Console.Write("\nEscolha uma opção: ");
        int escolha = int.Parse(Console.ReadLine() ?? "0");
        npc.IniciarDialogo();
        // Lidar com a escolha
    }
}