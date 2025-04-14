using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_15.model
{
    public class Atacando : EstadoInimigo
    {
        public void EntrarNoEstado(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo está atacando o jogador!");
        }

        public void Atualizar(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo está atacando.");

            // Aqui podemos adicionar lógica de ataque
            if (inimigo.JogadorSeEscondeu())
            {
                inimigo.MudarEstado(new Patrulhando());
            }
        }
    }
}