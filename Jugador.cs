using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    internal class Jugador
    {
        private const int DineroInicial = 300;
        private const int MultiplicadorNumeroEspecifico = 10;
        private const int MultiplicadorColor = 5;
        private const int MultiplicadorParImpar = 2;

        public int Dinero { get; private set; }
        private List<int> historialGiros;

        public Jugador()
        {
            Dinero = DineroInicial;
            historialGiros = new List<int>();
        }

        public void RealizarApuesta(int apuesta, int resultado, int numero)
        {
            if (resultado == numero)
            {
                Dinero += apuesta * MultiplicadorNumeroEspecifico;
                Console.WriteLine($"¡Ganaste! El número ganador fue {resultado}. Tu saldo actual es: ${Dinero}");
            }
            else
            {
                Dinero -= apuesta;
                Console.WriteLine($"Perdiste. El número ganador fue {resultado}. Tu saldo actual es: ${Dinero}");
            }
        }

        public void RealizarApuestaColor(int apuesta, int resultado, int color)
        {
            // Lógica para evaluar apuesta por color
        }

        public void RealizarApuestaParImpar(int apuesta, int resultado, int parImpar)
        {
            // Lógica para evaluar apuesta por par/impar
        }

        public void RegistrarGiro(int resultado)
        {
            historialGiros.Add(resultado);
        }

        public void MostrarEstadisticas()
        {
            // Mostrar estadísticas del jugador
        }
    }
}
