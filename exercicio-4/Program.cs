using System;
using System.Collections.Generic;

// Classe base para os itens
abstract class Item
{
    public string Nome { get; }

    public Item(string nome)
    {
        Nome = nome;
    }

    public abstract void Usar(Jogador jogador);
}

// Itens específicos
class PocaoVida : Item
{
    public int Cura { get; }

    public PocaoVida() : base("Poção de Vida")
    {
        Cura = 20;
    }

    public override void Usar(Jogador jogador)
    {
        jogador.Vida += Cura;
        Console.WriteLine($"{jogador.Nome} usou {Nome} e recuperou {Cura} de vida!");
    }
}

class ItemDano : Item
{
    public int BonusDano { get; }

    public ItemDano() : base("Pedra de Força")
    {
        BonusDano = 5;
    }

    public override void Usar(Jogador jogador)
    {
        jogador.Dano += BonusDano;
        Console.WriteLine($"{jogador.Nome} usou {Nome} e aumentou o dano em {BonusDano}!");
    }
}

class ItemVelocidade : Item
{
    public int BonusVelocidade { get; }

    public ItemVelocidade() : base("Botas Velozes")
    {
        BonusVelocidade = 3;
    }

    public override void Usar(Jogador jogador)
    {
        jogador.Velocidade += BonusVelocidade;
        Console.WriteLine($"{jogador.Nome} usou {Nome} e aumentou a velocidade em {BonusVelocidade}!");
    }
}

// Classe do jogador
class Jogador
{
    public string Nome { get; }
    public int Vida { get; set; }
    public int Dano { get; set; }
    public int Velocidade { get; set; }

    public Jogador(string nome)
    {
        Nome = nome;
        Vida = 100;
        Dano = 10;
        Velocidade = 5;
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"\nStatus de {Nome}: Vida={Vida}, Dano={Dano}, Velocidade={Velocidade}\n");
    }
}

// Inventário com capacidade
class Inventario
{
    private List<Item> itens = new List<Item>();
    public int CapacidadeMaxima { get; }

    public Inventario(int capacidade)
    {
        CapacidadeMaxima = capacidade;
    }

    public bool AdicionarItem(Item item)
    {
        if (itens.Count >= CapacidadeMaxima)
        {
            Console.WriteLine("Inventário cheio! Não é possível adicionar o item.");
            return false;
        }

        itens.Add(item);
        Console.WriteLine($"Item '{item.Nome}' adicionado ao inventário.");
        return true;
    }

    public void RemoverItem(int indice)
    {
        if (indice >= 0 && indice < itens.Count)
        {
            Console.WriteLine($"Item '{itens[indice].Nome}' removido do inventário.");
            itens.RemoveAt(indice);
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    public void UsarItem(int indice, Jogador jogador)
    {
        if (indice >= 0 && indice < itens.Count)
        {
            itens[indice].Usar(jogador);
            itens.RemoveAt(indice);
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    public void MostrarItens()
    {
        Console.WriteLine("\n--- Inventário ---");
        for (int i = 0; i < itens.Count; i++)
        {
            Console.WriteLine($"{i}: {itens[i].Nome}");
        }
        Console.WriteLine("-------------------\n");
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        Jogador jogador = new Jogador("Herói");
        Inventario inventario = new Inventario(5);

        // Adicionando itens
        inventario.AdicionarItem(new PocaoVida());
        inventario.AdicionarItem(new ItemDano());
        inventario.AdicionarItem(new ItemVelocidade());

        // Mostrar status e inventário
        jogador.MostrarStatus();
        inventario.MostrarItens();

        // Usar itens
        inventario.UsarItem(0, jogador); // usar poção de vida
        inventario.UsarItem(1, jogador); // usar botas de velocidade

        // Mostrar depois do uso
        jogador.MostrarStatus();
        inventario.MostrarItens();
    }
}
