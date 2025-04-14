using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_12.model
{
     public class Missao
    {
        public string Nome { get; private set; }
        private GerenciadorEventos eventos;

        public Missao(string nome, GerenciadorEventos eventos)
        {
            Nome = nome;
            this.eventos = eventos;

            eventos.MissaoConcluida += MissaoFinalizada;
        }

        public void Concluir()
        {
            eventos.DispararMissaoConcluida(Nome);
        }

        private void MissaoFinalizada(string nome)
        {
            if (nome == Nome)
            {
                Console.WriteLine($"[Missão] Recompensas da missão \"{nome}\" foram entregues.");
            }
        }
    }
}