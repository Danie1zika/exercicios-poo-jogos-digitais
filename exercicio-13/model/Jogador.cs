using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_13.model
{
    public class Jogador
    {
        public string Nome { get; private set; }
        public List<CartaBase> Cartas { get; private set; }

        public Jogador(string nome)
        {
            Nome = nome;
            Cartas = new List<CartaBase>();
        }

        public void AdicionarCarta(CartaBase carta)
        {
            Cartas.Add(carta);
        }

        public bool TemCartasVivas()
        {
            return Cartas.Any(c => c.EstaViva);
        }

        public CartaBase EscolherCartaViva()
        {
            return Cartas.FirstOrDefault(c => c.EstaViva);
        }
    }
}