using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_9.model
{
    using System;

class Personagem
{
    public string Nome { get; }
    public int Nivel { get; private set; }
    public int Experiencia { get; private set; }
    public int XPParaProximoNivel { get; private set; }

    public int Forca { get; private set; }
    public int Agilidade { get; private set; }
    public int VidaMaxima { get; private set; }

    public Personagem(string nome)
    {
        Nome = nome;
        Nivel = 1;
        Experiencia = 0;
        XPParaProximoNivel = 100;

        Forca = 10;
        Agilidade = 8;
        VidaMaxima = 100;
    }

    public void GanharExperiencia(int xp)
    {
        Console.WriteLine($"\n{Nome} ganhou {xp} de XP!");

        Experiencia += xp;

        while (Experiencia >= XPParaProximoNivel)
        {
            Experiencia -= XPParaProximoNivel;
            SubirDeNivel();
        }
    }

    private void SubirDeNivel()
    {
        Nivel++;
        Forca += 5;
        Agilidade += 3;
        VidaMaxima += 20;
        XPParaProximoNivel += 50;

        Console.WriteLine($"\n{Nome} subiu para o nível {Nivel}!");
        Console.WriteLine("Atributos aumentados:");
        Console.WriteLine($"Força: {Forca}, Agilidade: {Agilidade}, Vida Máxima: {VidaMaxima}");
        Console.WriteLine($"Próximo nível em {XPParaProximoNivel} XP.");
    }

    public void MostrarStatus()
    {
        Console.WriteLine("\n--- Status do Personagem ---");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Nível: {Nivel}");
        Console.WriteLine($"XP: {Experiencia}/{XPParaProximoNivel}");
        Console.WriteLine($"Força: {Forca}, Agilidade: {Agilidade}, Vida Máxima: {VidaMaxima}");
        Console.WriteLine("------------------------------");
    }
}

}