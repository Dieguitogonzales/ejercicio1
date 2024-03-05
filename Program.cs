using System;

class Program
{
    struct Corredor
    {
        public string nombre;
        public string apellido;
        public double estatura;
    }

    static void Main(string[] args)
    {
        Corredor[] corredores = new Corredor[3]; // Creamos un array de Corredores con longitud 3

        // Solicitamos los datos de cada corredor y los guardamos en el array
        for (int i = 0; i < corredores.Length; i++)
        {
            Console.WriteLine($"Datos del corredor {i + 1}:");
            Console.Write("Nombre: ");
            corredores[i].nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            corredores[i].apellido = Console.ReadLine();
            Console.Write("Estatura (metros): ");
            corredores[i].estatura = double.Parse(Console.ReadLine());
        }

        // Ordenamos los corredores según su estatura
        Array.Sort(corredores, (x, y) => x.estatura.CompareTo(y.estatura));

        // Mostramos los datos ordenados
        Console.WriteLine("\nDatos de los corredores ordenados por estatura:");
        for (int i = 0; i < corredores.Length; i++)
        {
            Console.WriteLine($"Nombre: {corredores[i].nombre} {corredores[i].apellido}, Estatura: {corredores[i].estatura}m");
        }
        Console.Read();
    }
}