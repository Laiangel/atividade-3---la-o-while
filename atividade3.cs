using System;

class atividade3
{
    static void Main()
    {
        int contador = 10; // Inicializa o contador com 10

        Console.WriteLine("Contagem regressiva:");

        // Laço while que executa enquanto o contador for maior ou igual a 1
        while (contador >= 1)
        {
            Console.WriteLine(contador); // Imprime o valor atual do contador
            contador--; // Decrementa o valor do contador
        }

        Console.WriteLine("Fogo!");
    }
}

