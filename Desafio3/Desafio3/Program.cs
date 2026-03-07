static void Desafio3()
{
    try
    {
        Console.Write("Ingrese primer número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int suma = num1 + num2;
        Console.WriteLine("La suma es: " + suma);
    }
    catch
    {
        Console.WriteLine("Error: Debe ingresar un número válido.");
    }
    finally
    {
        Console.WriteLine("Proceso finalizado.");
    }
}
Desafio3();

