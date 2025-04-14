using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_7.model
{
    abstract class Missao
{
    public string Nome { get; }
    public string Descricao { get; }
    public bool Concluida { get; protected set; }

    public Missao(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
        Concluida = false;
    }

    public abstract void VerificarConclusao();

    public virtual void MostrarStatus()
    {
        string status = Concluida ? "Concluída" : "Em andamento";
        Console.WriteLine($"{Nome} - {status}");
    }
}
}