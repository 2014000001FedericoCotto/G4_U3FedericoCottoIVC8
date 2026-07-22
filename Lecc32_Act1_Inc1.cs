internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Fderico Cotto \n Grado: IVC \n Clave:8");
        Console.WriteLine("======CONVERSIONES======");
        double metros;
        double resultado;
        Console.WriteLine("Dame una medida de metros");
        metros= double.Parse(Console.ReadLine());

        Console.WriteLine("Menu Principal");
        Console.WriteLine( 
            "   1- Milimrtros " +
            "\n 2- Centimetros " +
            "\n 3- Decimetros" +
            "\n 4- Hectometros " +
            "\n 5- Kilometros " +
            "\n 6-  Salir" +
            "\n Selccione una opcion []:");
        int opc=Convert.ToInt32(Console.ReadLine());
        switch (opc) 
        { 
            case 1:
                Console.Clear();
                Console.WriteLine("Conversion de metros a MILIMETROS");
                
                resultado = metros * 1000;
                Console.WriteLine("Los metr"+metros+"en MIlimetros es: "+resultado);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Conversion de metros a CENTIMETROS");
                resultado = metros * 100;
                Console.WriteLine("Los metr" + metros + "en centimetros es: " + resultado);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Conversion de metros a DECIMETROS");
                resultado = metros * 10;
                Console.WriteLine("Los metr" + metros + "en decimetros es: " + resultado);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Conversion de metros a HECTOMETROS");
                resultado = metros / 100;
                Console.WriteLine("Los metr" + metros + "en Hectometros es: " + resultado);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Conversion de metros a KILOMETROS");
                resultado = metros / 1000;
                Console.WriteLine("Los metr" + metros + "en Kilometros es: " + resultado);
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Para Salir presione cualquier tecla...");
                Console.ReadKey();
                break;
            default: 
                Console.WriteLine("Seleccione una opcion Valida...");
                break ;
        }

    }
}
