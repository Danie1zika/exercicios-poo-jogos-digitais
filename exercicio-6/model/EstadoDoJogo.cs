using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_6.model
{
class EstadoDoJogo
{
    // Instância única (singleton)
    private static EstadoDoJogo instancia;

    // Propriedade pública para acesso global
    public static EstadoDoJogo Instancia
    {
        get
        {
            if (instancia == null)
            {
                instancia = new EstadoDoJogo();
            }
            return instancia;
        }
    }

    // Propriedades do estado do jogo
    public int NivelAtual { get; set; }
    public int Pontuacao { get; set; }
    public int Vidas { get; set; }

    // Construtor privado para evitar múltiplas instâncias
    private EstadoDoJogo()
    {
        NivelAtual = 1;
        Pontuacao = 0;
        Vidas = 3;
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"Nível: {NivelAtual} | Pontuação: {Pontuacao} | Vidas: {Vidas}");
    }
}

}