            static void Desafio1()
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Mes 1: ");
                double mes1 = double.Parse(Console.ReadLine());
                Console.Write("Mes 2: ");
                double mes2 = double.Parse(Console.ReadLine());
                Console.Write("Mes 3: ");
                double mes3 = double.Parse(Console.ReadLine());

                double suma = mes1 + mes2 + mes3;
                double promedio = suma / 3;

                Console.WriteLine("Hola " + nombre + ", en total ganaste: " + suma + ". Promediaste: " + promedio);
            }
Desafio1();