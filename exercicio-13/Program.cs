using System;
using exercicio_13.model;

class Program
{
    static void Main(string[] args)
    {
        var jogador1 = new Jogador("Wanderson");
        var jogador2 = new Jogador("Timóteo");

        jogador1.AdicionarCarta(new Guerreiro("Guerreiro de Fogo"));
        jogador1.AdicionarCarta(new Mago("Mago Sombrio"));

        jogador2.AdicionarCarta(new Assassino("Assassino Silencioso"));
        jogador2.AdicionarCarta(new Guerreiro("Guerreiro da Luz"));

        Console.WriteLine("🎮 Início da batalha!");

        int turno = 1;

        while (jogador1.TemCartasVivas() && jogador2.TemCartasVivas())
        {
            Console.WriteLine($"\n--- Turno {turno} ---");

            var carta1 = jogador1.EscolherCartaViva();
            var carta2 = jogador2.EscolherCartaViva();

            if (turno % 2 == 1)
            {
                carta1.UsarHabilidade(carta2);
                if (carta2.EstaViva)
                    carta2.Atacar(carta1);
            }
            else
            {
                carta2.UsarHabilidade(carta1);
                if (carta1.EstaViva)
                    carta1.Atacar(carta2);
            }

            ExibirStatus(jogador1, jogador2);
            turno++;
        }

        Console.WriteLine("\n🏁 Fim do combate!");
        Console.WriteLine(jogador1.TemCartasVivas() ? "🏆 Jogador 1 venceu!" : "🏆 Jogador 2 venceu!");
    }

    static void ExibirStatus(Jogador j1, Jogador j2)
    {
        Console.WriteLine($"\nStatus de {j1.Nome}:");
        foreach (var carta in j1.Cartas)
            Console.WriteLine($"- {carta.Nome}: {carta.Vida} de vida");

        Console.WriteLine($"\nStatus de {j2.Nome}:");
        foreach (var carta in j2.Cartas)
            Console.WriteLine($"- {carta.Nome}: {carta.Vida} de vida");
    }
}