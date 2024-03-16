namespace Ruleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Bienvenido al juego de Ruleta");
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Salir");
                Console.Write("Elige una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        JuegoRuleta juego = new JuegoRuleta();
                        juego.Jugar();
                        break;
                    case 2:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                        break;
                }
            }

            Console.WriteLine("¡Gracias por jugar!");
        }

    }
    }


