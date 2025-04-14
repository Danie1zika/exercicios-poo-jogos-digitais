using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_14.model
{
    public class OpcaoDialogo
    {
        public string Texto { get; private set; }
        public Action ProximaEscolha { get; private set; }

        public OpcaoDialogo(string texto, Action proximaEscolha)
        {
            Texto = texto;
            ProximaEscolha = proximaEscolha;
        }
    }
}