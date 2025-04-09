using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_1.model
{
    public class Vendedor : NPC
    {
     public string movimentacao;
    public string interacao;
    public Vendedor(string movimentacao, string interacao)
        {
            this.movimentacao = movimentacao;
            this.interacao = interacao;
        }

    public void Mover() {
    Console.WriteLine("O Vendedor anda pela sua loja");
        }
    public void Interagir() {
    Console.WriteLine("Vendedor da boas-vindas ao Jogador!");
    Console.WriteLine("");
        }   
    }
}