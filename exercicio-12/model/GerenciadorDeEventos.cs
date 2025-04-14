using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_12.model
{
    public class GerenciadorEventos
    {
        // Delegates e eventos
        public delegate void EventoSimples();
        public delegate void EventoComMensagem(string mensagem);

        public event EventoSimples ChefeDerrotado;
        public event EventoComMensagem JogadorSubiuNivel;
        public event EventoComMensagem MissaoConcluida;

        public void DispararChefeDerrotado()
        {
            Console.WriteLine(" Chefe derrotado!");
            ChefeDerrotado?.Invoke();
        }

        public void DispararJogadorSubiuNivel(string nome)
        {
            Console.WriteLine($" {nome} subiu de nível!");
            JogadorSubiuNivel?.Invoke(nome);
        }

        public void DispararMissaoConcluida(string nomeMissao)
        {
            Console.WriteLine($" Missão \"{nomeMissao}\" concluída!");
            MissaoConcluida?.Invoke(nomeMissao);
        }
    }
}