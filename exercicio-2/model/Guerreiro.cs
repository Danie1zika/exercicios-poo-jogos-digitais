using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_2.model
{
    interface IAtaque {
    void Atacar();
    }
    class Guerreiro : IAtaque {
    public void Atacar() {
    Console.WriteLine("Guerreiro ataca com espada!");
        }
    }
}