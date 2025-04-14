using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_14.model
{
    public class NPC
    {
        public string Nome { get; private set; }
        private Dialogo dialogo;

        public NPC(string nome)
        {
            Nome = nome;
            dialogo = new Dialogo($"Olá, sou o {nome}. Como posso te ajudar?");
            DefinirDialogo();
        }

        private void DefinirDialogo()
        {
            dialogo.AdicionarOpcao("Preciso de ajuda!", ContinuarDialogo1);
            dialogo.AdicionarOpcao("Só estou passando.", ContinuarDialogo2);
        }

        public void IniciarDialogo()
        {
            dialogo.Exibir();
        }

        private void ContinuarDialogo1()
        {
            var resposta = new Dialogo("Você precisa de ajuda? O que aconteceu?");
            resposta.AdicionarOpcao("Meu pai está perdido, por favor, me ajude!", ContinuarDialogo1_1);
            resposta.AdicionarOpcao("Só estava curioso, nada demais.", ContinuarDialogo1_2);
            resposta.Exibir();
        }

        private void ContinuarDialogo2()
        {
            Console.WriteLine("Ok, tenha um bom dia!");
        }

        private void ContinuarDialogo1_1()
        {
            Console.WriteLine("NPC: Vamos juntos procurar seu pai.");
        }

        private void ContinuarDialogo1_2()
        {
            Console.WriteLine("NPC: Tudo bem, mas se precisar de ajuda, me avise.");
        }
    }
}