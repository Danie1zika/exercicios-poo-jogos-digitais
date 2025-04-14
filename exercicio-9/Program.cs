using exercicio_9.model;

class Program
{
    static void Main(string[] args)
    {
        Personagem heroi = new Personagem("Herói Wanderson");

        heroi.MostrarStatus();

        // Simula derrotar inimigos
        heroi.GanharExperiencia(40);
        heroi.MostrarStatus();

        heroi.GanharExperiencia(80); // Deve subir de nível
        heroi.MostrarStatus();

        heroi.GanharExperiencia(200); // Pode subir mais de um nível
        heroi.MostrarStatus();
    }
}
