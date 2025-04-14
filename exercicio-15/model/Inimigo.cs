using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_15.model
{
    public class Inimigo
    {
        public EstadoInimigo EstadoAtual { get; private set; }

        public Inimigo()
        {
            EstadoAtual = new Patrulhando();
        }

        public void MudarEstado(EstadoInimigo novoEstado)
        {
            EstadoAtual = novoEstado;
            EstadoAtual.EntrarNoEstado(this);
        }

        // Lógica para verificar se o jogador foi visto
        public bool ViuJogador() => new Random().Next(0, 2) == 1;

        // Lógica para verificar se o jogador foi alcançado
        public bool AlcancouJogador() => new Random().Next(0, 2) == 1;

        // Lógica para verificar se o jogador se escondeu
        public bool JogadorSeEscondeu() => new Random().Next(0, 2) == 1;

        public void AtualizarEstado()
        {
            EstadoAtual.Atualizar(this);
        }
    }
}