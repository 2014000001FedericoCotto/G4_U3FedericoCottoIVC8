using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Cual es el precio del producto? : ");
        int precio = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Cual es el valor del billete? : ");
        int pago = Convert.ToInt32(Console.ReadLine());
        
        int vuelto = pago - precio;
        
        if (cambio < 0) {
            Console.WriteLine("No tienes el suficiente dinero");
        } else {
            Console.WriteLine($"\nEl vuelto total es: {vuelto}");
            
            int b200 = vuelto / 200; vuelto %= 200;
            int b100 = vuelto / 100; vuelto %= 100;
            int b50 = vuelto / 50;   vuelto %= 50;
            int b20 = vuelto / 20;   vuelto %= 20;
            
            Console.WriteLine($"Billetes de 200: {b200}");
            Console.WriteLine($"Billetes de 100: {b100}");
            Console.WriteLine($"Billetes de 50: {b50}");
            Console.WriteLine($"Billetes de 20: {b20}");
            Console.WriteLine($"Monedas restantes: {vuelto}");
        }
    }
}
