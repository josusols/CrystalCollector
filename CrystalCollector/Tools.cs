//Librerías.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalCollector
{
    class Tools
    {
        //Constructor.
        public Tools()
        { }

        //Crear una lista que almacena las imagenes que se usaran en el DataGridView.
        public List<Bitmap> listaIMG = new List<Bitmap>();

        //Función entera porque retorna el indice de la lista de las imagenes.
        //Tiene una cadena como parametro para que se pueda concatenar la palabra identificadora "IMG" y el número que representa en la lista.
        public int Representa(string identificadorImagen)
        {
            switch (identificadorImagen)
            {
                //-1: Espacio en blanco.
                case "IMG-1":
                    //El elemento [0] de la lista es el cuadro en blanco.
                    return 0;
                //1: Jugador.
                case "IMG1":
                    //El elemento [1] de la lista es el cuadro del jugador.
                    return 1;
                //2: Diamante 1.
                case "IMG2":
                    //El elemento [2] de la lista es el cuadro del 1er diamante.
                    return 2;
                //3: Diamante 2.
                case "IMG3":
                    //El elemento [3] de la lista es el cuadro del 2do diamante.
                    return 3;
                //4: Diamante 3.
                case "IMG4":
                    //El elemento [4] de la lista es el cuadro del 3er diamante.
                    return 4;
                //5: Diamante 4.
                case "IMG5":
                    //El elemento [5] de la lista es el cuadro del 4to diamante.
                    return 5;
                //6: Diamante 5.
                case "IMG6":
                    //El elemento [6] de la lista es el cuadro del 5to diamante.
                    return 6;
                //7: Diamante 6.
                case "IMG7":
                    //El elemento [7] de la lista es el cuadro del 6to diamante.
                    return 7;
                //8: Portal.
                case "IMG8":
                    //El elemento [8] de la lista es el cuadro del portal.
                    return 8;
                //8: Troll.
                case "IMG9":
                    //El elemento [9] de la lista es el cuadro del troll.
                    return 9;
                //Default: Espacio en blanco.
                default:
                    //El elemento default es el cuadro en blanco.
                    return -1;
            }
        }
    }
}
