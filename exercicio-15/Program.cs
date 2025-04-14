﻿using System;
using exercicio_15.model;

class Program
{
    static void Main(string[] args)
    {
        var inimigo = new Inimigo();
        var jogador = new Jogador("Luna");

        // Simulando atualização do estado do inimigo em vários turnos
        for (int turno = 0; turno < 10; turno++)
        {
            Console.WriteLine($"\n--- Turno {turno + 1} ---");
            inimigo.AtualizarEstado();
            System.Threading.Thread.Sleep(1000); // Espera 1 segundo para o próximo turno
        }
    }
}