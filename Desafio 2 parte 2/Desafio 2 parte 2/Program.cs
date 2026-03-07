class Program
{
    static int puntajeRecord = 0;
    static string jugadorRecord = "";
    static void VerificarRecord(int puntaje, string nombreJugador)
    {
        if (puntaje > puntajeRecord)
        {
            puntajeRecord = puntaje;
            jugadorRecord = nombreJugador;

            Console.WriteLine("La nueva puntuación más alta es " + puntajeRecord);
            Console.WriteLine("La puntuación más alta fue lograda por " + jugadorRecord);
        }
        else
        {
            Console.WriteLine("La puntuación más alta de " + puntajeRecord +
            " no se ha podido superar, y aún está en manos de " + jugadorRecord);
        }
    }

    static void Main()
    {
        VerificarRecord(100, "Dayani");
        VerificarRecord(50, "Glendy");
        VerificarRecord(150, "Yovi");
    }
}