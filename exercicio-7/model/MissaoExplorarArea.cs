using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_7.model
{
    // Missão: Explorar área
class MissaoExplorarArea : Missao
{
    public bool AreaExplorada { get; private set; }

    public MissaoExplorarArea()
        : base("Explorar Área", "Explore a área secreta no mapa.")
    {
        AreaExplorada = false;
    }

    public void Explorar()
    {
        AreaExplorada = true;
        VerificarConclusao();
    }

    public override void VerificarConclusao()
    {
        if (AreaExplorada)
            Concluida = true;
    }

    public override void MostrarStatus()
    {
        base.MostrarStatus();
        Console.WriteLine($"Área explorada: {(AreaExplorada ? "Sim" : "Não")}");
    }
}
}