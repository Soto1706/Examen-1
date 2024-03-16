using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    internal class JuegoRuleta
    {
        private Ruleta ruleta;
        private Jugador jugador;

        public JuegoRuleta()
        {
            ruleta = new Ruleta();
            jugador = new Jugador();
        }

        public void Jugar()
        {
            while (jugador.Dinero > 0)
            {
                Console.WriteLine($"Tu saldo actual es: ${jugador.Dinero}");
                Console.WriteLine("¿Cuánto quieres apostar? (debe ser múltiplo de 10)");
                int apuesta = int.Parse(Console.ReadLine());

                if (apuesta % 10 != 0 || apuesta > jugador.Dinero)
                {
                    Console.WriteLine("La apuesta debe ser múltiplo de 10 y no puedes apostar más de lo que tienes.");
                    continue;
                }

                Console.WriteLine("¿Cómo quieres apostar?");
                Console.WriteLine("1. A un número específico");
                Console.WriteLine("2. A color (rojo o negro)");
                Console.WriteLine("3. A par o impar");
                int opcion = int.Parse(Console.ReadLine());

                int resultado = ruleta.GirarRuleta();
                jugador.RegistrarGiro(resultado);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("¿A qué número quieres apostar? (0-36)");
                        int numero = int.Parse(Console.ReadLine());
                        jugador.RealizarApuesta(apuesta, resultado, numero);
                        break;
                    case 2:
                        Console.WriteLine("¿A qué color quieres apostar? (1: Rojo, 2: Negro)");
                        int color = int.Parse(Console.ReadLine());
                        jugador.RealizarApuestaColor(apuesta, resultado, color);
                        break;
                    case 3:
                        Console.WriteLine("¿A qué quieres apostar? (1: Par, 2: Impar)");
                        int parImpar = int.Parse(Console.ReadLine());
                        jugador.RealizarApuestaParImpar(apuesta, resultado, parImpar);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("¡Te quedaste sin dinero! Gracias por jugar.");
            jugador.MostrarEstadisticas();
        }
    }
}
