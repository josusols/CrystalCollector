//Librerías.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalCollector
{
    class Jugador
    {
        //Datos del jugador.
        public string nombre;
        public string genero;

        //Punteo.
        public int joyasVida;
        public int cajaRecolectadora;
        public string cristalesRecolectados;
        public bool jugadorEnElPortal;
        public bool portalListo;
        //Contador: La funcionalidad del Contador es acumular los puntos que el Avatar durante la sesión de Juego.
        public int punteo;
        public bool trollActivo;

        //Constructor.
        public Jugador(string nom, string gen)
        {
            //Inicia los atributos de la clase.
            joyasVida = 3;
            cajaRecolectadora = 0;
            cristalesRecolectados = ":)";
            jugadorEnElPortal = false;
            portalListo = false;
            punteo = 0;
            trollActivo = false;

            //Guarda el nombre y el género.
            nombre = nom;
            genero = gen;
        }

        //Cambio de tablero.
        public void levelUp()
        {
            cajaRecolectadora = 0;
            cristalesRecolectados = ":)";
            jugadorEnElPortal = false;
            portalListo = false;
            trollActivo = false;
            //Por cada Tablero conquistado el Avatar recibirá 100 puntos.
            punteo += 100;
        }
    }
}
