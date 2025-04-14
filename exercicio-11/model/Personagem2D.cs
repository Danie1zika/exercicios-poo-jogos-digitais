using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_11.model
{
    public class Personagem2D
    {
        public float PosicaoX { get; private set; }
        public float PosicaoY { get; private set; }
        public float VelocidadeY { get; private set; }
        public bool NoChao { get; private set; }

        private const float Gravidade = 9.8f;
        private const float ForcaPulo = -15f;
        private const float VelocidadeAndar = 5f;
        private const float ChaoY = 0f;

        public Personagem2D()
        {
            PosicaoX = 0f;
            PosicaoY = ChaoY;
            VelocidadeY = 0f;
            NoChao = true;
        }

        public void Andar(float direcao)
        {
            // -1 para esquerda, +1 para direita
            PosicaoX += direcao * VelocidadeAndar;
            Console.WriteLine($"Andou para {(direcao < 0 ? "esquerda" : "direita")}. PosiçãoX: {PosicaoX}");
        }

        public void Pular()
        {
            if (NoChao)
            {
                VelocidadeY = ForcaPulo;
                NoChao = false;
                Console.WriteLine("Pulou!");
            }
        }

        public void AtualizarFisica(float deltaTime)
        {
            if (!NoChao)
            {
                VelocidadeY += Gravidade * deltaTime;
                PosicaoY += VelocidadeY * deltaTime;

                if (PosicaoY >= ChaoY)
                {
                    PosicaoY = ChaoY;
                    VelocidadeY = 0f;
                    NoChao = true;
                    Console.WriteLine("Colidiu com o chão.");
                }
                else
                {
                    Console.WriteLine($"Caindo... Altura: {PosicaoY:F2}");
                }
            }
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"\nPosição: ({PosicaoX}, {PosicaoY}) | No chão: {NoChao}");
        }
    }
}
