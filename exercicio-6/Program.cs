using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_6.model
{
class Program
{
    static void Main(string[] args)
    {
        // Acessar e modificar o estado do jogo
        EstadoDoJogo jogo = EstadoDoJogo.Instancia;

        jogo.MostrarEstado();

        // Simular eventos do jogo
        jogo.Pontuacao += 150;
        jogo.Vidas -= 1;
        jogo.NivelAtual += 1;

        Console.WriteLine("\nDepois de jogar um pouco...");
        jogo.MostrarEstado();
    }
}
}