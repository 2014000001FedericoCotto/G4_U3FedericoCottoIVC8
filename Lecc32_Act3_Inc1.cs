internal class Program
{
    static void Main(string[] args)
    {
        char opcion;

        do
        {
            
            Console.Clear();
            Console.WriteLine("FedricoCottoIVC_Clave8");
            Console.WriteLine("=== CLASIFICADOR DE TRIÁNGULOS ===");

            
            Console.Write("Ingresa la medida del lado a: ");
            double a= Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la medida del lado b: ");
            double b= Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Ingresa la medida del lado c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--------------------------------");

            
            if ((a + b> c) && (a+ c> b) && (b+ c> a))
            {
                
                if (a== b && b== c)
                {
                    Console.WriteLine("Resultado: Es un Euilatero");
                }
                else if (a==b|| a==c|| b== c)
                {
                    Console.WriteLine("Resultado: Es un  Isosceles");
                }
                else
                {
                    Console.WriteLine("Resultado: Es un Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Error: Las medidas ingresadas no pueden formar un triángulo válido.");
            }

            Console.WriteLine("--------------------------------");

            
            Console.Write("Presiona 'R' para reiniciar \nPresiona cualquier otra tecla para salir... ");

            
            opcion = char.ToUpper(Console.ReadKey().KeyChar);

        } while (opcion == 'R'); 

        Console.WriteLine("\nSaliendo del Sistem");
    }
}
