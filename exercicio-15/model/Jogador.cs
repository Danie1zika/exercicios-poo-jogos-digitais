using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_15.model
{
    public class Jogador
    {
        public string Nome { get; private set; }

        public Jogador(string nome)
        {
            Nome = nome;
        }
    }
}