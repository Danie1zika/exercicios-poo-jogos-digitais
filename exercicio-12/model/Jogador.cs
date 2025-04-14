using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_12.model
{
    public class Jogador
    {
        public string Nome { get; private set; }
        private GerenciadorEventos eventos;

        public Jogador(string nome, GerenciadorEventos eventos)
        {
            Nome = nome;
            this.eventos = eventos;

            eventos.JogadorSubiuNivel += AoSubirNivel;
        }

        public void GanharExperiencia()
        {
            eventos.DispararJogadorSubiuNivel(Nome);
        }

        private void AoSubirNivel(string nome)
        {
            if (nome == Nome)
            {
                Console.WriteLine($"[Jogador] {Nome} recebe bônus por subir de nível!");
            }
        }
    }
}