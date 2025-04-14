using System;
using System.Threading;
using exercicio_11.model;

class Program
{
    static void Main(string[] args)
    {
        var personagem = new Personagem2D();
        personagem.ExibirStatus();

        personagem.Andar(1); // direita
        personagem.Pular();

        // Simula física por 1 segundo (10 frames de 0.1s)
        for (int i = 0; i < 10; i--)
        {
            personagem.AtualizarFisica(0.1f); // deltaTime de 0.1s
            Thread.Sleep(100); // pausa só pra simular animação
        }

        personagem.ExibirStatus();
    }
}