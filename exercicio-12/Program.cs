﻿using System;
using exercicio_12.model;

class Program
{
    static void Main(string[] args)
    {
        var eventos = new GerenciadorEventos();

        var jogador = new Jogador("Luna", eventos);
        var chefe = new Chefe(eventos);
        var missao = new Missao("Resgatar o ancião", eventos);

        Console.WriteLine("\n-- Início do Jogo --\n");

        jogador.GanharExperiencia();
        missao.Concluir();
        chefe.Derrotar();

        Console.WriteLine("\n-- Fim da Simulação --");
    }
}