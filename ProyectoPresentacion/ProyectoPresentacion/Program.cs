// using System;

namespace ProyectoPresentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- Menú de Animales ---");
                Console.WriteLine("1. Crear Perro");
                Console.WriteLine("2. Crear Gato");
                Console.WriteLine("3. Crear Pájaro");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CrearPerro();
                        break;
                    case "2":
                        CrearGato();
                        break;
                    case "3":
                        CrearPajaro();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo...");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;


                }
            }

            static void CrearPerro()
            {
                Perro perro = new Perro();
                Console.Write("Introduce el nombre del perro: ");
                perro.Nombre = Console.ReadLine();
                Console.Write("Introduce la edad del perro: ");
                perro.Edad = int.Parse(Console.ReadLine());
                Console.Write("Introduce la raza del perro: ");
                perro.Raza = Console.ReadLine();

                perro.HacerSonido();
                perro.Correr();
            }

            static void CrearGato()
            {
                Gato gato = new Gato();
                Console.Write("Introduce el nombre del gato: ");
                gato.Nombre = Console.ReadLine();
                Console.Write("Introduce la edad del gato: ");
                gato.Edad = int.Parse(Console.ReadLine());
                Console.Write("Introduce el color del gato: ");
                gato.Color = Console.ReadLine();

                gato.HacerSonido();
                gato.Saltar();
            }

            static void CrearPajaro()
            {
                Pajaro pajaro = new Pajaro();
                Console.Write("Introduce el nombre del pájaro: ");
                pajaro.Nombre = Console.ReadLine();
                Console.Write("Introduce la edad del pájaro: ");
                pajaro.Edad = int.Parse(Console.ReadLine());
                Console.Write("Introduce el tipo de pico del pájaro: ");
                pajaro.TipoDePico = Console.ReadLine();

                pajaro.HacerSonido();
                pajaro.Volar();
            }
        }
    }
}