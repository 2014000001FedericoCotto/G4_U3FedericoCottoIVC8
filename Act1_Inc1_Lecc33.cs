using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        string[] nombres = new string[10];
        string[] telefonos = new string[10];
        Console.WriteLine("FedericoCottoIVC8");
        Console.WriteLine("=== REGISTRO DE CONTACTOS ===");
        Console.WriteLine("Por favor, introduce los datos de las 10 personas:");

        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Contacto #{i + 1}:");

            Console.Write("Nombre: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Teléfono: ");
            telefonos[i] = Console.ReadLine();

            Console.WriteLine(); 
        }

        Console.Clear(); 
        Console.WriteLine("=== AGENDA TELEFÓNICA INTERACTIVA ===");
        Console.WriteLine("Contactos almacenados con exito \n Consultar las posiciones de la 1 a la 10. \n Digita'0' para salir.\n");

        
        while (true)
        {
            Console.Write("Introduce el número de posición a consultar (1-10): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int posicion))
            {
                if (posicion == 0)
                {
                    Console.WriteLine("Adios...");
                    break;
                }

                if (posicion >= 1 && posicion <= 10)
                {
                    int indice = posicion - 1; 

                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine($"Posicion {posicion}:");
                    Console.WriteLine($"Nombre:   {nombres[indice]}");
                    Console.WriteLine($"Telefono: {telefonos[indice]}");
                    Console.WriteLine(new string('-', 40) + "\n");
                }
                else
                {
                    Console.WriteLine("Error! Opcion invalida...");
                }
            }
            else
            {
                Console.WriteLine("Error! Digita un entero");
            }
        }
    }
}
