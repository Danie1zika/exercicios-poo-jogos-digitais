using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_15.model
{
    public class Patrulhando : EstadoInimigo
    {
        public void EntrarNoEstado(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo começou a patrulhar a área.");
        }

        public void Atualizar(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo está patrulhando.");

            if (inimigo.ViuJogador())
            {
                inimigo.MudarEstado(new Perseguindo());
            }
        }
    }
}