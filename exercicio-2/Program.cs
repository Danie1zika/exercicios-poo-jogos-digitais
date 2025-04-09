using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Interface representando um ataque
interface IAtaque  {
    void Atacar();
}

class Guerreiro : IAtaque {
    public void Atacar() {
        Console.WriteLine("Guerreiro ataca com espada!");
    }
}
// Classe Mago implementando a interface IAtaque
class Mago : IAtaque {
    public void Atacar() {
        Console.WriteLine("Mago lança bola de fogo!");
    }
}
// Classe Arqueiro implementando a interface IAtaque
class Arqueiro : IAtaque {
    public void Atacar() {
        Console.WriteLine("Arqueiro dispara flechas");
    }
}
class Program {
    static void Main(string[] args) {

        IAtaque guerreiro = new Guerreiro();
        guerreiro.Atacar();
        IAtaque mago = new Mago();
        mago.Atacar();
        IAtaque arqueiro = new Arqueiro();
        arqueiro.Atacar();


    }
}