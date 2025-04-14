using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_5.model
{
    // Classe base Habilidade
abstract class Habilidade
{
    public string Nome { get; protected set; }
    public int CustoDeMana { get; protected set; }
    public int Dano { get; protected set; }

    public Habilidade(string nome, int custoDeMana, int dano)
    {
        Nome = nome;
        CustoDeMana = custoDeMana;
        Dano = dano;
    }

    public abstract void Executar(Personagem alvo, Personagem lancador);
}
}