using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_7.model
{
    // Missão: Derrotar inimigos
class MissaoDerrotarInimigos : Missao
{
    public int InimigosDerrotados { get; private set; }
    public int InimigosNecessarios { get; }

    public MissaoDerrotarInimigos(int qtd) 
        : base("Derrotar Inimigos", $"Derrote {qtd} inimigos.")
    {
        InimigosNecessarios = qtd;
        InimigosDerrotados = 0;
    }

    public void Derrotar()
    {
        InimigosDerrotados++;
        VerificarConclusao();
    }

    public override void VerificarConclusao()
    {
        if (InimigosDerrotados >= InimigosNecessarios)
            Concluida = true;
    }

    public override void MostrarStatus()
    {
        base.MostrarStatus();
        Console.WriteLine($"Progresso: {InimigosDerrotados}/{InimigosNecessarios} inimigos derrotados");
    }
}
}