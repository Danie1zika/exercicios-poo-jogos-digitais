using System;
using System.Collections.Generic;
using exercicio_7.model;
class Program
{
    static void Main(string[] args)
    {
        Jogador jogador = new Jogador("Aventureiro");

        // Criar missões
        var missao1 = new MissaoDerrotarInimigos(3);
        var missao2 = new MissaoColetarItens(2);
        var missao3 = new MissaoExplorarArea();

        // Jogador aceita as missões
        jogador.AceitarMissao(missao1);
        jogador.AceitarMissao(missao2);
        jogador.AceitarMissao(missao3);

        // Progresso simulado
        missao1.Derrotar();
        missao1.Derrotar();
        missao2.Coletar();
        missao3.Explorar();

        // Mostrar estado atual
        jogador.MostrarMissoes();

        // Finalizando
        missao1.Derrotar(); // Agora completa

        Console.WriteLine("Após mais progresso...\n");
        jogador.MostrarMissoes();
    }
}
