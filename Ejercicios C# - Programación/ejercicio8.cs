//Casting implicito
int valor = 200;
double total = valor;
Console.WriteLine("Implicito: " + total);

//casting explicito
double precio = 500.23;
int descuento = (int)precio;
Console.WriteLine("Explicito: " + descuento);

char letra = 'A';
int codigoAsci = letra;
Console.WriteLine(codigoAsci);

string palabra = "123456";
int numero = Convert.ToInt32(palabra);
Console.WriteLine(numero); 

string textoDecimal = "150.60";
double valor3 = double.Parse(textoDecimal);
Console.WriteLine(valor3);