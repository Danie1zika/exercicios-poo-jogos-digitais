using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_7.model
{
    // Classe jogador com lista de missões
class Jogador
{
    public string Nome { get; }
    private List<Missao> missoes = new();

    public Jogador(string nome)
    {
        Nome = nome;
    }

    public void AceitarMissao(Missao missao)
    {
        missoes.Add(missao);
        Console.WriteLine($"{Nome} aceitou a missão: {missao.Nome}");
    }

    public void MostrarMissoes()
    {
        Console.WriteLine($"\nMissões de {Nome}:");
        foreach (var m in missoes)
        {
            m.MostrarStatus();
            Console.WriteLine();
        }
    }
}
}