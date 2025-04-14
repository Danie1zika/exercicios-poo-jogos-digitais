using exercicio_10.Interface;

class Program
{
    static void Main(string[] args)
    {
        Economia economia = new Economia();

        // Criar comerciantes (observadores)
        Comerciante npc1 = new Comerciante("Wanderson");
        Comerciante npc2 = new Comerciante("Timóteo");

        economia.RegistrarObservador(npc1);
        economia.RegistrarObservador(npc2);

        Console.WriteLine($"Preço atual da Espada: {economia.ConsultarPreco("Espada"):C}\n");

        // Simular vendas pelo jogador
        economia.VenderItem("Espada");
        economia.VenderItem("Espada");
        economia.VenderItem("Espada"); // Aqui o preço deve cair

        Console.WriteLine($"\nPreço final da Espada: {economia.ConsultarPreco("Espada"):C}");
    }
}
