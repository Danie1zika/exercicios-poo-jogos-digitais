using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_15.model
{
    public class Perseguindo : EstadoInimigo
    {
        public void EntrarNoEstado(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo avistou o jogador e está perseguindo!");
        }

        public void Atualizar(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo está perseguindo o jogador.");

            if (inimigo.AlcancouJogador())
            {
                inimigo.MudarEstado(new Atacando());
            }
            else if (inimigo.JogadorSeEscondeu())
            {
                inimigo.MudarEstado(new Patrulhando());
            }
        }
    }
}