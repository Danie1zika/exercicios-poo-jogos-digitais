using System;
using System.Collections.Generic;

namespace RPGItensSimples
{
    // Interface comum para todos os itens
    interface IItem
    {
        void Usar();
    }

    // Tipos concretos de itens
    class Arma : IItem
    {
        public void Usar()
        {
            Console.WriteLine("Você equipou uma arma! Ataque aumentado.");
        }
    }

    class Pocao : IItem
    {
        public void Usar()
        {
            Console.WriteLine("Você bebeu uma poção! Vida restaurada.");
        }
    }

    class Armadura : IItem
    {
        public void Usar()
        {
            Console.WriteLine("Você vestiu uma armadura! Defesa aumentada.");
        }
    }

    // Fábrica base (Factory Method)
    abstract class FabricaItem
    {
        public abstract IItem CriarItem();
    }

    // Fábricas concretas
    class FabricaArma : FabricaItem
    {
        public override IItem CriarItem()
        {
            return new Arma();
        }
    }

    class FabricaPocao : FabricaItem
    {
        public override IItem CriarItem()
        {
            return new Pocao();
        }
    }

    class FabricaArmadura : FabricaItem
    {
        public override IItem CriarItem()
        {
            return new Armadura();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Lista de fábricas disponíveis
            List<FabricaItem> fabricas = new List<FabricaItem>
            {
                new FabricaArma(),
                new FabricaPocao(),
                new FabricaArmadura()
            };

            Random random = new Random();

            // Geração e uso de 3 itens aleatórios
            for (int i = 0; i < 1; i++)
            {
                int indice = random.Next(fabricas.Count);
                IItem item = fabricas[indice].CriarItem();
                item.Usar();
            }
        }
    }
}
