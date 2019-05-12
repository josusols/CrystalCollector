//Librerías.
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;


namespace CrystalCollector
{
    class Niveles
    {
        //Coordenadas. Para facilidad de lectura.
        int y = 0, x = 1;

        //Nivel.
        public int nivel = 0;

        //Dimensiones del tablero.
        public int dim = 0;

        //Tableros (5, cada tablero representa un nivel)
        public int[,] Tablero;

        //Trolls / Enemigos (variable, podrían no aparecer)
        public Troll[] Trolls;

        //Respuesta guardada.
        public int respuestaSeleccionada = 0;

        /*Posiciones iniciales del jugador.*/
        //Avatar (único, personaje principal)
        int[] avatar_PosX_Y = new int[2];

        /*Posiciones iniciales del portal.*/
        //Portal de Teletransportación (único, por tablero)
        int[] portal_PosX_Y = new int[2];

        //Método para llenar el tablero.
        void LlenarTablero()
        {
            //Llena el tablero con cuadros blancos.
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    Tablero[i, j] = -1;
                }
            }
        }

        //Método que ubica la posición del Avatar
        public int[] PosicionAvatar()
        {
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (Tablero[i, j] == 1)
                    {
                        avatar_PosX_Y[y] = i;
                        avatar_PosX_Y[x] = j;
                    }
                }
            }

            return avatar_PosX_Y;
        }

        //Ubicación random de los cristales.
        Random rdm = new Random();

        //Método para llenar el tablero de cristales. Deberán aparecer de manera aleatoria en cada uno de los tableros.
        void llenarCristales(int nivel, int dim)
        {
            List<int> cristales = new List<int>();
            //Nivel 2 al 5.
            if (nivel > 1)
            {
                int i = 0;
                int j = 0;

                while (cristales.Count != 6)
                {
                    i = rdm.Next(0, dim);
                    j = rdm.Next(0, dim);

                    if (Tablero[i, j] == -1)
                    {
                        int random = rdm.Next(2, 8);
                        while (cristales.Contains(random))
                        {
                            random = rdm.Next(2, 8);
                        }

                        //No deben aparecer de manera contigua.
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                if ((Tablero[i + 1, j] < 2 || Tablero[i + 1, j] > 7)
                                    && (Tablero[i, j + 1] < 2 || Tablero[i, j + 1] > 7))
                                {
                                    Tablero[i, j] = random;
                                    cristales.Add(random);
                                }
                            }
                            else if (j == dim - 1)
                            {
                                if ((Tablero[i + 1, j] < 2 || Tablero[i + 1, j] > 7)
                                    && (Tablero[i, j - 1] < 2 || Tablero[i, j - 1] > 7))
                                {
                                    Tablero[i, j] = random;
                                    cristales.Add(random);
                                }
                            }
                            else
                            {
                                if ((Tablero[i + 1, j] < 2 || Tablero[i + 1, j] > 7)
                                    && (Tablero[i, j + 1] < 2 || Tablero[i, j + 1] > 7)
                                    && (Tablero[i, j - 1] < 2 || Tablero[i, j - 1] > 7))
                                {
                                    Tablero[i, j] = random;
                                    cristales.Add(random);
                                }
                            }
                        }
                        else if (i == dim - 1)
                        {
                            if (j == 0)
                            {
                                if ((Tablero[i - 1, j] < 2 || Tablero[i - 1, j] > 7)
                                    && (Tablero[i, j + 1] < 2 || Tablero[i, j + 1] > 7))
                                {
                                    Tablero[i, j] = random;
                                    cristales.Add(random);
                                }
                            }
                            else if (j == dim - 1)
                            {
                                if ((Tablero[i - 1, j] < 2 || Tablero[i - 1, j] > 7)
                                    && (Tablero[i, j - 1] < 2 || Tablero[i, j - 1] > 7))
                                {
                                    Tablero[i, j] = random;
                                    cristales.Add(random);
                                }
                            }
                            else
                            {
                                if ((Tablero[i - 1, j] < 2 || Tablero[i - 1, j] > 7)
                                    && (Tablero[i, j + 1] < 2 || Tablero[i, j + 1] > 7)
                                    && (Tablero[i, j - 1] < 2 || Tablero[i, j - 1] > 7))
                                {
                                    Tablero[i, j] = random;
                                    cristales.Add(random);
                                }
                            }
                        }
                        else
                        {
                            if (j == 0)
                            {
                                if ((Tablero[i + 1, j] < 2 || Tablero[i + 1, j] > 7)
                                    && (Tablero[i - 1, j] < 2 || Tablero[i - 1, j] > 7)
                                    && (Tablero[i, j + 1] < 2 || Tablero[i, j + 1] > 7))
                                {
                                    Tablero[i, j] = random;
                                    cristales.Add(random);
                                }
                            }
                            else if (j == dim - 1)
                            {
                                if ((Tablero[i + 1, j] < 2 || Tablero[i + 1, j] > 7)
                                    && (Tablero[i - 1, j] < 2 || Tablero[i - 1, j] > 7)
                                    && (Tablero[i, j - 1] < 2 || Tablero[i, j - 1] > 7))
                                {
                                    Tablero[i, j] = random;
                                    cristales.Add(random);
                                }
                            }
                            else
                            {
                                if ((Tablero[i + 1, j] < 2 || Tablero[i + 1, j] > 7)
                                    && (Tablero[i, j + 1] < 2 || Tablero[i, j + 1] > 7)
                                    && (Tablero[i - 1, j] < 2 || Tablero[i - 1, j] > 7)
                                    && (Tablero[i, j - 1] < 2 || Tablero[i, j - 1] > 7))
                                {
                                    Tablero[i, j] = random;
                                    cristales.Add(random);
                                }
                            }
                        }
                    }
                }
            }
            //Nivel 1.
            else
            {
                int i = 0;
                int j = 0;
                while (cristales.Count < 7)
                {
                    i = rdm.Next(0, dim);
                    j = rdm.Next(0, dim);

                    if (Tablero[i, j] == -1)
                    {
                        int random = rdm.Next(2, 8);

                        while (cristales.Contains(random))
                        {

                            if (rdm.Next(-5, 5) < 0)
                            {
                                random = -1;
                            }
                            else
                            {
                                random = rdm.Next(2, 8);
                            }

                        }

                        Tablero[i, j] = random;
                        cristales.Add(random);
                    }
                }
            }
        }

        //Método para llenar el tablero de trolls. Deberán aparecer de manera aleatoria en cada uno de los tableros.
        void llenarTrolls(int cantidadTrolls, int dim)
        {
            List<int> trolls = new List<int>();

            int i = 0;
            int j = 0;

            while (trolls.Count != cantidadTrolls)
            {
                i = rdm.Next(0, dim);
                j = rdm.Next(0, dim);

                if (Tablero[i, j] == -1)
                {
                    //No deben aparecer de manera contigua.
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            if (Tablero[i + 1, j] != 9
                                && Tablero[i, j + 1] != 9)
                            {
                                Tablero[i, j] = 9;
                                trolls.Add(9);
                            }
                        }
                        else if (j == dim - 1)
                        {
                            if (Tablero[i + 1, j] != 9
                                && Tablero[i, j - 1] != 9)
                            {
                                Tablero[i, j] = 9;
                                trolls.Add(9);
                            }
                        }
                        else
                        {
                            if (Tablero[i + 1, j] != 9
                                && Tablero[i, j + 1] != 9
                                && Tablero[i, j - 1] != 9)
                            {
                                Tablero[i, j] = 9;
                                trolls.Add(9);
                            }
                        }
                    }
                    else if (i == dim - 1)
                    {
                        if (j == 0)
                        {
                            if (Tablero[i - 1, j] != 9
                                && Tablero[i, j + 1] != 9)
                            {
                                Tablero[i, j] = 9;
                                trolls.Add(9);
                            }
                        }
                        else if (j == dim - 1)
                        {
                            if (Tablero[i - 1, j] != 9
                                && Tablero[i, j - 1] != 9)
                            {
                                Tablero[i, j] = 9;
                                trolls.Add(9);
                            }
                        }
                        else
                        {
                            if (Tablero[i - 1, j] != 9
                                && Tablero[i, j + 1] != 9
                                && Tablero[i, j - 1] != 9)
                            {
                                Tablero[i, j] = 9;
                                trolls.Add(9);
                            }
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            if (Tablero[i + 1, j] != 9
                                && Tablero[i - 1, j] != 9
                                && Tablero[i, j + 1] != 9)
                            {
                                Tablero[i, j] = 9;
                                trolls.Add(9);
                            }
                        }
                        else if (j == dim - 1)
                        {
                            if (Tablero[i + 1, j] != 9
                                && Tablero[i - 1, j] != 9
                                && Tablero[i, j - 1] != 9)
                            {
                                Tablero[i, j] = 9;
                                trolls.Add(9);
                            }
                        }
                        else
                        {
                            if (Tablero[i + 1, j] != 9
                                && Tablero[i, j + 1] != 9
                                && Tablero[i - 1, j] != 9
                                && Tablero[i, j - 1] != 9)
                            {
                                Tablero[i, j] = 9;
                                trolls.Add(9);
                            }
                        }
                    }
                }
            }
        }

        //Método que coloca el portal en una posición aleatoria.
        public void PortalAleatorio()
        {
            //Despeja el portal actual.
            int dim = Tablero.GetLength(1);
            int[] posicionActual = new int[2];
            //Valores default.
            posicionActual[y] = 20;
            posicionActual[x] = 20;
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (Tablero[i, j] == 8)
                    {
                        posicionActual[y] = i;
                        posicionActual[x] = j;
                    }
                }
            }
            
            //Crea un nuevo portal.
            portal_PosX_Y[y] = rdm.Next(0, dim);
            portal_PosX_Y[x] = rdm.Next(0, dim);

            while (Tablero[portal_PosX_Y[y], portal_PosX_Y[x]] != -1)
            {
                portal_PosX_Y[y] = rdm.Next(0, dim);
                portal_PosX_Y[x] = rdm.Next(0, dim);
            }
            //Si no cambian los valores default es porque aún no existe.
            if (posicionActual[y] != 20 && posicionActual[x] != 20)
            {
                Tablero[posicionActual[y], posicionActual[x]] = -1;
            }
            Tablero[portal_PosX_Y[y], portal_PosX_Y[x]] = 8;
        }

        //Método que coloca el avatar en una posición aleatoria.
        public void AvatarAleatorio()
        {
            avatar_PosX_Y[y] = rdm.Next(0, dim);
            avatar_PosX_Y[x] = rdm.Next(0, dim);

            while (Tablero[avatar_PosX_Y[y], avatar_PosX_Y[x]] != -1)
            {
                avatar_PosX_Y[y] = rdm.Next(0, dim);
                avatar_PosX_Y[x] = rdm.Next(0, dim);
            }
            Tablero[avatar_PosX_Y[y], avatar_PosX_Y[x]] = 1;
        }

        /*NIVEL 1*/
        public void nivel1()
        {
            //Nivel. 
            nivel = 1;
            //Define las dimensiones del tablero.
            dim = 3;
            //Será de una dimensión de 3 x 3.
            Tablero = new int[dim,dim];
            //Llena el tablero.
            LlenarTablero();
            //Avatar, deberá aparecer en la posición x: 0, y: 0. [i,j] = [0,0]
            avatar_PosX_Y[y] = 0;
            avatar_PosX_Y[x] = 0;
            /*El número 1 es la representación del jugador.*/
            Tablero[avatar_PosX_Y[y], avatar_PosX_Y[x]] = 1;
            //Portal, deberá aparecer en la posición x: 3, y: 1. [i,j] = [0,2]
            portal_PosX_Y[y] = 0;
            portal_PosX_Y[x] = 2;
            /*El número 8 es la representación del portal.*/
            Tablero[portal_PosX_Y[y], portal_PosX_Y[x]] = 8;
            //Cristales, pueden aparecer cristales contiguos.
            llenarCristales(1, dim);
        }

        /*NIVEL 2*/
        public void nivel2()
        {
            //Nivel. 
            nivel = 2;
            //Define las dimensiones del tablero.
            dim = 4;
            //Será de una dimensión de 4 x 4.
            Tablero = new int[dim, dim];
            //Llena el tablero.
            LlenarTablero();
            //Cristales, no pueden aparecer cristales contiguos.
            llenarCristales(2, dim);
            //En este tablero aparecerá 1 Troll.
            Trolls = new Troll[1];
            for (int i = 0; i < 1; i++)
            {
                Trolls[i] = new Troll();
            }
            //Trolls, no pueden aparecer trolls contiguos.
            llenarTrolls(Trolls.Length, dim);
            //Avatar, deberá aparecer ubicado de manera aleatoria.
            AvatarAleatorio();
            /*El número 1 es la representación del jugador.*/
            Tablero[avatar_PosX_Y[y], avatar_PosX_Y[x]] = 1;
            //Portal, deberá aparecer ubicado de manera aleatoria.
            PortalAleatorio();
            /*El número 8 es la representación del portal.*/
            Tablero[portal_PosX_Y[y], portal_PosX_Y[x]] = 8;
        }

        /*NIVEL 3*/
        public void nivel3()
        {
            //Nivel. 
            nivel = 3;
            //Define las dimensiones del tablero.
            dim = 5;
            //Será de una dimensión de 5 x 5.
            Tablero = new int[dim, dim];
            //Llena el tablero.
            LlenarTablero();
            //Cristales, no pueden aparecer cristales contiguos.
            llenarCristales(3, dim);
            //En este tablero aparecerán 4 Trolls.
            Trolls = new Troll[4];
            for (int i = 0; i < 4; i++)
            {
                Trolls[i] = new Troll();
            }
            //Trolls, no pueden aparecer trolls contiguos.
            llenarTrolls(Trolls.Length, dim);
            //Avatar, deberá aparecer ubicado de manera aleatoria.
            AvatarAleatorio();
            /*El número 1 es la representación del jugador.*/
            Tablero[avatar_PosX_Y[y], avatar_PosX_Y[x]] = 1;
            //Portal, deberá aparecer ubicado de manera aleatoria.
            PortalAleatorio();
            /*El número 8 es la representación del portal.*/
            Tablero[portal_PosX_Y[y], portal_PosX_Y[x]] = 8;
        }

        /*NIVEL 4*/
        public void nivel4()
        {
            //Nivel. 
            nivel = 4;
            //Define las dimensiones del tablero.
            dim = 6;
            //Será de una dimensión de 6 x 6.
            Tablero = new int[dim, dim];
            //Llena el tablero.
            LlenarTablero();
            //Cristales, no pueden aparecer cristales contiguos.
            llenarCristales(4, dim);
            //En este tablero aparecerán 7 Trolls.
            Trolls = new Troll[7];
            for (int i = 0; i < 7; i++)
            {
                Trolls[i] = new Troll();
            }
            //Trolls, no pueden aparecer trolls contiguos.
            llenarTrolls(Trolls.Length, dim);
            //Avatar, deberá aparecer ubicado de manera aleatoria.
            AvatarAleatorio();
            /*El número 1 es la representación del jugador.*/
            Tablero[avatar_PosX_Y[y], avatar_PosX_Y[x]] = 1;
            //Portal, deberá aparecer ubicado de manera aleatoria.
            PortalAleatorio();
            /*El número 8 es la representación del portal.*/
            Tablero[portal_PosX_Y[y], portal_PosX_Y[x]] = 8;
        }

        /*NIVEL 5*/
        public void nivel5()
        {
            //Nivel. 
            nivel = 5;
            //Define las dimensiones del tablero.
            dim = 10;
            //Será de una dimensión de 10 x 10.
            Tablero = new int[dim, dim];
            //Llena el tablero.
            LlenarTablero();
            //Cristales, no pueden aparecer cristales contiguos.
            llenarCristales(5, dim);
            //En este tablero aparecerán 12 Trolls.
            Trolls = new Troll[12];
            for (int i = 0; i < 12; i++)
            {
                Trolls[i] = new Troll();
            }
            //Trolls, no pueden aparecer trolls contiguos.
            llenarTrolls(Trolls.Length, dim);
            //Avatar, deberá aparecer ubicado de manera aleatoria.
            AvatarAleatorio();
            /*El número 1 es la representación del jugador.*/
            Tablero[avatar_PosX_Y[y], avatar_PosX_Y[x]] = 1;
            //Portal, deberá aparecer ubicado de manera aleatoria.
            PortalAleatorio();
            /*El número 8 es la representación del portal.*/
            Tablero[portal_PosX_Y[y], portal_PosX_Y[x]] = 8;
        }

        public void Down(ref Jugador jugador)
        {
            int dim = Tablero.GetLength(1);
            int[] posicionActual = new int[2];

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (Tablero[i, j] == 1)
                    {
                        posicionActual[y] = i;
                        posicionActual[x] = j;
                    }
                }
            }
            //Evita que se mueva abajo del borde.
            if (posicionActual[y] != dim - 1)
            {
                if (evaluarMovimiento(posicionActual[y] + 1, posicionActual[x], nivel, ref jugador))
                {
                    //Limpiar.
                    Tablero[posicionActual[y], posicionActual[x]] = -1;

                    //Cambiar.
                    posicionActual[y] += 1;

                    //Mover.
                    Tablero[posicionActual[y], posicionActual[x]] = 1;
                }
            }
        }

        public void Up(ref Jugador jugador)
        {
            int dim = Tablero.GetLength(1);
            int[] posicionActual = new int[2];

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (Tablero[i, j] == 1)
                    {
                        posicionActual[y] = i;
                        posicionActual[x] = j;
                    }
                }
            }
            //Evita que se mueva arriba del borde.
            if (posicionActual[y] != 0)
            {
                if (evaluarMovimiento(posicionActual[y] - 1, posicionActual[x], nivel, ref jugador))
                {
                    //Limpiar.
                    Tablero[posicionActual[y], posicionActual[x]] = -1;

                    //Cambiar.
                    posicionActual[y] -= 1;

                    //Mover.
                    Tablero[posicionActual[y], posicionActual[x]] = 1;
                }
            }
        }

        public void Left(ref Jugador jugador)
        {
            int dim = Tablero.GetLength(1);
            int[] posicionActual = new int[2];

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (Tablero[i, j] == 1)
                    {
                        posicionActual[y] = i;
                        posicionActual[x] = j;
                    }
                }
            }
            //Evita que se mueva a la izquierda del borde.
            if (posicionActual[x] != 0)
            {
                if (evaluarMovimiento(posicionActual[y], posicionActual[x] - 1, nivel, ref jugador))
                {
                    //Limpiar.
                    Tablero[posicionActual[y], posicionActual[x]] = -1;

                    //Cambiar.
                    posicionActual[x] -= 1;

                    //Mover.
                    Tablero[posicionActual[y], posicionActual[x]] = 1;
                }
            }
        }

        public void Right(ref Jugador jugador)
        {
            int dim = Tablero.GetLength(1);
            int[] posicionActual = new int[2];

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (Tablero[i, j] == 1)
                    {
                        posicionActual[y] = i;
                        posicionActual[x] = j;
                    }
                }
            }
            //Evita que se mueva a la derecha del borde.
            if (posicionActual[x] != dim - 1)
            {
                if (evaluarMovimiento(posicionActual[y], posicionActual[x] + 1, nivel, ref jugador))
                {
                    //Limpiar.
                    Tablero[posicionActual[y], posicionActual[x]] = -1;

                    //Cambiar.
                    posicionActual[x] += 1;

                    //Mover.
                    Tablero[posicionActual[y], posicionActual[x]] = 1;
                }
            }
        }

        public bool evaluarMovimiento(int x, int y, int nivel, ref Jugador jug)
        {
            //Llega al portal y le falta.
            if (Tablero[x, y] == 8 && jug.cajaRecolectadora < 6)
            {
                jug.jugadorEnElPortal = true;
                jug.portalListo = false;
                //Por cada intento que el Avatar realice de acceder al Portal, sin tener los 6 Cristales, perderá 25 puntos.
                jug.punteo -= 25;
                if (nivel > 1)
                {
                    PortalAleatorio();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //Llega al portal y tiene los cristales completos.
            if (Tablero[x, y] == 8 && jug.cajaRecolectadora == 6)
            {
                jug.jugadorEnElPortal = true;
                jug.portalListo = true;
                return true;
            }
            //Llega a cualquier cristal.
            else if (Tablero[x, y] >= 2 && Tablero[x, y] <= 7)
            {
                //Aumenta la caja recolectora.
                jug.cajaRecolectadora++;
                //Por cada Cristal recolectado el Avatar recibirá 25 puntos.
                jug.punteo += 25;
                return true;
            }
            //Llega a cualquier troll.
            else if (Tablero[x, y] == 9)
            {
                jug.trollActivo = true;
                //El return true, QUITA al troll pero no lo reubica de manera aleatoria.
                //El return false PERNANECE al troll.
                return false;
            }

            return true;
        }
    }
}
