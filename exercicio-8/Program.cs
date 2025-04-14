using System;

namespace RPGComposicao
{
    // Arma
    class Arma
    {
        public string Nome { get; }
        public int Dano { get; }

        public Arma(string nome, int dano)
        {
            Nome = nome;
            Dano = dano;
        }
    }

    // Armadura
    class Armadura
    {
        public string Nome { get; }
        public int Defesa { get; }

        public Armadura(string nome, int defesa)
        {
            Nome = nome;
            Defesa = defesa;
        }
    }

    // Tipo de ataque (simples neste exemplo)
    class TipoAtaque
    {
        public string Nome { get; }

        public TipoAtaque(string nome)
        {
            Nome = nome;
        }
    }

    // Personagem usando composição
    class Personagem
    {
        public string Nome { get; set; }
        public Arma ArmaAtual { get; set; }
        public Armadura ArmaduraAtual { get; set; }
        public TipoAtaque Ataque { get; set; }

        public Personagem(string nome)
        {
            Nome = nome;
        }

        public void MostrarStatus()
        {
            Console.WriteLine($"\nPersonagem: {Nome}");
            Console.WriteLine($"Arma: {ArmaAtual?.Nome ?? "Nenhuma"} | Dano: {ArmaAtual?.Dano ?? 0}");
            Console.WriteLine($"Armadura: {ArmaduraAtual?.Nome ?? "Nenhuma"} | Defesa: {ArmaduraAtual?.Defesa ?? 0}");
            Console.WriteLine($"Tipo de Ataque: {Ataque?.Nome ?? "Nenhum"}");
            Console.WriteLine("------------------------------");
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um kit:");
            Console.WriteLine("1 - Guerreiro (Espada + Escudo)");
            Console.WriteLine("2 - Arqueiro (Arco e Flecha + Sem armadura)");
            Console.Write("Sua escolha: ");
            string escolha = Console.ReadLine();

            Personagem jogador = new Personagem("Herói");

            switch (escolha)
            {
                case "1":
                    jogador.ArmaAtual = new Arma("Espada", 15);
                    jogador.ArmaduraAtual = new Armadura("Escudo", 10);
                    jogador.Ataque = new TipoAtaque("Ataque Corpo a Corpo");
                    break;

                case "2":
                    jogador.ArmaAtual = new Arma("Arco e Flecha", 12);
                    jogador.ArmaduraAtual = null; // Sem armadura
                    jogador.Ataque = new TipoAtaque("Ataque à Distância");
                    break;

                default:
                    Console.WriteLine("Escolha inválida! Personagem criado sem kit.");
                    break;
            }

            jogador.MostrarStatus();

            // Simular troca de arma
            Console.WriteLine("Trocando para Machado...");
            jogador.ArmaAtual = new Arma("Machado", 18);
            jogador.MostrarStatus();
        }
    }
}
