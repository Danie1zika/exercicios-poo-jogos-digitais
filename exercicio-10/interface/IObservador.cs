using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_10.Interface
{
// Observer
interface IObservador
{
    void Atualizar(string item, decimal novoPreco);
}

// Subject (Economia)
class Economia
{
    private Dictionary<string, decimal> precos = new();
    private Dictionary<string, int> historicoVendas = new();
    private List<IObservador> observadores = new();

    public Economia()
    {
        precos["Espada"] = 100m;
        historicoVendas["Espada"] = 0;
    }

    public void RegistrarObservador(IObservador obs)
    {
        observadores.Add(obs);
    }

    public void Notificar(string item)
    {
        foreach (var obs in observadores)
        {
            obs.Atualizar(item, precos[item]);
        }
    }

    public void VenderItem(string item)
    {
        Console.WriteLine($"Jogador vendeu uma {item}.");

        if (!historicoVendas.ContainsKey(item))
            historicoVendas[item] = 0;

        historicoVendas[item]++;

        AjustarPreco(item);
    }

    private void AjustarPreco(string item)
    {
        int vendas = historicoVendas[item];

        if (vendas >= 3)
        {
            precos[item] *= 0.9m; // reduz 10%
            historicoVendas[item] = 0; // zera o contador após ajuste
            Console.WriteLine($"Preço da {item} ajustado devido à alta oferta.");
            Notificar(item);
        }
    }

    public decimal ConsultarPreco(string item)
    {
        return precos.ContainsKey(item) ? precos[item] : 0;
    }
}

// Comerciante (Observer)
class Comerciante : IObservador
{
    public string Nome { get; }

    public Comerciante(string nome)
    {
        Nome = nome;
    }

    public void Atualizar(string item, decimal novoPreco)
    {
        Console.WriteLine($"[NPC {Nome}] O novo preço da {item} é {novoPreco:C}");
    }
}

}