class Program
{
    static string usuarioGuardado;
    static string claveGuardada;

    static void Registrar()
    {
        Console.Write("Crea tu usuario: ");
        usuarioGuardado = Console.ReadLine();

        Console.Write("Crea tu contraseña: ");
        claveGuardada = Console.ReadLine();

        Console.WriteLine("Registro completado");
    }

    static void IniciarSesion()
    {
        Console.Write("Usuario: ");
        string usuario = Console.ReadLine();

        Console.Write("Contraseña: ");
        string clave = Console.ReadLine();

        if (usuario == usuarioGuardado && clave == claveGuardada)
        {
            Console.WriteLine("Inicio de sesión correcto");
        }
        else
        {
            Console.WriteLine("Usuario o contraseña incorrectos");
        }
    }
    static void Main()
    {
        Registrar();
        IniciarSesion();
    }
}