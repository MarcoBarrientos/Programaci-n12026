static void Desafio2(object operaciones)
{
    Console.Write("Numero 1: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Write("Numero 2: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Suma: " + operaciones.sumar(n1, n2));
    Console.WriteLine("Resta: " + operaciones.restar(n1, n2));
    Console.WriteLine("Multiplicacion: " + operaciones.multiplicar(n1, n2));
    Console.WriteLine("Division: " + operaciones.dividir(n1, n2));
}
    Desafio2();
    