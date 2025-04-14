using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_7.model
{
    // Missão: Coletar itens
class MissaoColetarItens : Missao
{
    public int ItensColetados { get; private set; }
    public int ItensNecessarios { get; }

    public MissaoColetarItens(int qtd)
        : base("Coletar Itens", $"Colete {qtd} itens.")
    {
        ItensNecessarios = qtd;
        ItensColetados = 0;
    }

    public void Coletar()
    {
        ItensColetados++;
        VerificarConclusao();
    }

    public override void VerificarConclusao()
    {
        if (ItensColetados >= ItensNecessarios)
            Concluida = true;
    }

    public override void MostrarStatus()
    {
        base.MostrarStatus();
        Console.WriteLine($"Progresso: {ItensColetados}/{ItensNecessarios} itens coletados");
    }
}
}