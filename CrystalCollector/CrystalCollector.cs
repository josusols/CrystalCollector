//Librerías.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalCollector
{
    public partial class CrystalCollector : Form
    {
        //Objetos.
        private Tools t;
        private Jugador jug;
        private Niveles nivel;
        private PantallaInicial pi;

        //Constructor.
        public CrystalCollector(string nombre, string genero, PantallaInicial _pi)
        {
            InitializeComponent();

            pi = _pi;
            //Ocular Pantalla Inicial.
            pi.Hide();

            //Maximizar ventana.
            this.WindowState = FormWindowState.Maximized;

            //Espacio para inicializar clases.
            t = new Tools();
            nivel = new Niveles();

            //**ELIMINA LOS HEADERS DE LAS FILAS Y LAS COLUMNAS DEL TABLERO**
            Tablero.ColumnHeadersVisible = false;
            Tablero.RowHeadersVisible = false;

            //**AGREGAR LAS IMAGENES A LA LISTA**
            //Cuadro en blanco.
            t.listaIMG.Add(new Bitmap("../../Resources/Blanco.png"));
            //Avatar 1.
            t.listaIMG.Add(new Bitmap("../../Resources/IMG1.png"));
            //Cristal 1.
            t.listaIMG.Add(new Bitmap("../../Resources/IMG2.png"));
            //Cristal 2
            t.listaIMG.Add(new Bitmap("../../Resources/IMG3.png"));
            //Cristal 3.
            t.listaIMG.Add(new Bitmap("../../Resources/IMG4.png"));
            //Cristal 4.
            t.listaIMG.Add(new Bitmap("../../Resources/IMG5.png"));
            //Cristal 5.
            t.listaIMG.Add(new Bitmap("../../Resources/IMG6.png"));
            //Cristal 6.
            t.listaIMG.Add(new Bitmap("../../Resources/IMG7.png"));
            //Portal.
            t.listaIMG.Add(new Bitmap("../../Resources/IMG8.png"));
            //Troll. (Solamente uno puede estar descomentado, porque representa el indice [9])
            //Para que los Trolls se vean.
            t.listaIMG.Add(new Bitmap("../../Resources/IMG9.png"));
            //Para que los Trolls NO se vean.
            //t.listaIMG.Add(new Bitmap("../../Resources/Blanco.png"));

            IniciarJuego(nombre, genero);
        }

        //Método que limpia el tablero.
        public void LimpiarTablero()
        {
            //Limpia el DataGridView.
            Tablero.Rows.Clear();
            Tablero.Columns.Clear();
        }

        public void llenarColumnas(int dim)
        {
            DataGridViewImageColumn imgCol;
            for (int i = 0; i < dim; i++)
            {
                imgCol = new DataGridViewImageColumn();
                imgCol.Name = "c" + i;
                imgCol.HeaderText = "";
                Tablero.Columns.Insert(i, imgCol);
            }
        }

        //Método que imprime el tablero en el DGV.
        public void ImprimirTablero()
        {
            for (int i = 0; i < nivel.dim; i++)
            {
                for (int j = 0; j < nivel.dim; j++)
                {
                    Tablero.Rows[i].Cells[j].Value = t.listaIMG[t.Representa("IMG" + nivel.Tablero[i, j])];
                }
            }
        }

        //Método que resetea el tablero.
        public void ResetTablero(int Nivel)
        {
            //Limpiar el tablero.
            LimpiarTablero();

            switch (Nivel)
            {
                case 1:
                    //Inicia el nivel 1.
                    nivel.nivel1();
                    break;
                case 2:
                    //Inicia el nivel 2.
                    nivel.nivel2();
                    break;
                case 3:
                    //Inicia el nivel 3.
                    nivel.nivel3();
                    break;
                case 4:
                    //Inicia el nivel 4.
                    nivel.nivel4();
                    break;
                case 5:
                    //Inicia el nivel 5.
                    nivel.nivel5();
                    break;
                default:
                    //Inicia el nivel 1.
                    nivel.nivel1();
                    break;
            }

            //Agregar las columnas del DGV que hacen falta.
            llenarColumnas(nivel.dim);

            //Agregar las filas del DGV que hacen falta.
            for (int i = 0; i < nivel.dim; i++)
            {
                Tablero.Rows.Add(); //Agrega la fila.
                Tablero.Columns[i].Width = 76; //Cambia el tamaño de la columna.
                Tablero.Rows[i].Height = 76; //Cambia el tamaño de la fila.
            }

            ImprimirTablero();
        }

        public void IniciarJuego(string nombre, string genero)
        {
            //Activar tablero.
            Tablero.Enabled = true;
            Tablero.Visible = true;
            Comandos.Enabled = true;
            EstadoAvatar.Enabled = true;
            //Nuevo Jugador.
            jug = new Jugador(nombre, genero);
            //Comienza el juego en el nivel 1.
            ResetTablero(1);
            //Limpiar Panel.
            ActualizarPanel();
        }

        private void ActualizarPanel()
        {
            //Joyas de Vida.
            JoyasDeVida.Text = jug.joyasVida.ToString();

            //Punteo.
            Punteo.Text = jug.punteo.ToString();

            //Caja Recolectadora.
            if (jug.cajaRecolectadora < 6)
            {
                CajaRecolectora.Text = jug.cajaRecolectadora.ToString();
            }
            else
            {
                CajaRecolectora.Text = jug.cristalesRecolectados;
            }

            if (jug.cajaRecolectadora == 6 && jug.cristalesRecolectados == ":)")
            {
                jug.cristalesRecolectados = "******";
                MessageBox.Show("¡Encontro los 6 cristales! Puede dirigirse hacia el Portal de Teletransportación",
                    "6 CRISTALES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (jug.jugadorEnElPortal == true && jug.portalListo == false)
            {
                MessageBox.Show("¡Aún no ha recolectado los 6 Cristales del tablero!", "FALTAN CRISTALES",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //El Portal será el encargado de teletransportar al Avatar hacia los siguientes niveles (tableros)
            if (jug.jugadorEnElPortal == true && jug.portalListo == true)
            {
                if (nivel.nivel < 5)
                {
                    nivel.nivel++;
                    ResetTablero(nivel.nivel);
                    jug.levelUp();
                    ActualizarPanel();
                }
                else
                {
                    //Al momento de finalizar el último tablero, el Avatar recibirá 5000 puntos.
                    jug.punteo += 5000;
                    Tablero.Enabled = false;
                    //Punteo.
                    Punteo.Text = jug.punteo.ToString();
                    MessageBox.Show("¡GANO!", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

            if (jug.trollActivo == true)
            {
                PreguntaTroll pt = new PreguntaTroll(nivel.Trolls[0], this);
                this.Hide();
                pt.Show();
            }

            //Al momento de perder todas sus joyas, la partida se dará por finalizada y se mostrará el resultado obtenido.
            if (jug.joyasVida == 0)
            {
                MessageBox.Show("¡PERDIO! DEBERA TERMINAR LA PARTIDA...", "PERDEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Puntaje Obtenido: " + jug.punteo, "PUNTAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tablero.Enabled = false;
                Tablero.Visible = false;
                Comandos.Enabled = false;
                EstadoAvatar.Enabled = false;
                jug.punteo = 0;
                Punteo.Text = jug.punteo.ToString();
            }
        }

        private void Tablero_KeyDown(object sender, KeyEventArgs e)
        {
            //Reset de la bandera Jugador en el Portal.
            jug.jugadorEnElPortal = false;
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                nivel.Up(ref jug);
                ImprimirTablero();
                ActualizarPanel();
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                nivel.Down(ref jug);
                ImprimirTablero();
                ActualizarPanel();
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                nivel.Left(ref jug);
                ImprimirTablero();
                ActualizarPanel();
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                nivel.Right(ref jug);
                ImprimirTablero();
                ActualizarPanel();
            }
        }

        //Evento que reacciona al cerrar el juego CrystalCollector.
        private void CrystalCollector_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Muestra el menú principal.
            pi.Show();
        }

        private void TerminarPartida_Click(object sender, EventArgs e)
        {
            //Esta opción terminará la partida y regresará al menú principal.
            this.Close();
        }

        private void Comandos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Mover derecha (flecha hacia la derecha o tecla D):
Moverá al personaje sobre el eje X una posición del lado positivo.

Mover izquierda (flecha hacia la izquierda o tecla A):
Moverá al personaje sobre el eje X una posición del lado negativo.


Mover arriba (flecha hacia arriba o tecla W):
Moverá al personaje sobre el eje Y una posición del lado positivo.

Mover abajo (flecha hacia abajo o tecla S):
Moverá al personaje sobre el eje Y una posición del lado negativo.", "COMANDOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EstadoAvatar_Click(object sender, EventArgs e)
        {
            int [] posAvatar = new int[2];
            posAvatar = nivel.PosicionAvatar();
            MessageBox.Show(@"*Nombre del Avatar: " + jug.nombre + "\n" +
                            @"*Género del Avatar: " + jug.genero + "\n" +
                            @"*Número de Joyas de Vida restantes: " + jug.joyasVida + "\n" +
                            @"*Cantidad de Cristales en la Caja Recolectora: " + jug.cajaRecolectadora + "\n" +
                            @"*Cantidad de Puntos obtenidos en la partida hasta el momento de la consulta: " + jug.punteo + "\n" +
                            @"*Ubicación actual del Avatar: " + "[" + (posAvatar[1]) + ", " + (-1 * (posAvatar[0] - nivel.dim + 1)) + "]");
        }

        //Guarda en la clase del nivel, la respuesta que selecciono el jugador en el reto del Troll.
        public void guardarRespuesta(int res)
        {
            nivel.respuestaSeleccionada = res;
            //Va a calificar la respuesta del usuario vs la del Troll.
            if(nivel.respuestaSeleccionada == nivel.Trolls[0].pregunta1.respuestaCorrecta)
            {
                MessageBox.Show("¡Respuesta Correcta!", "RESPUESTA CORRECTA", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                jug.joyasVida++;
                //Por cada Trivia respondida correctamente el Avatar recibirá 15 puntos.
                jug.punteo += 15;
                jug.trollActivo = false;
                ActualizarPanel();
                //JoyasDeVida.Text = jug.joyasVida.ToString();

            }
            else
            {
                MessageBox.Show("¡Respuesta Incorrecta!", "RESPUESTA INCORRECTA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                jug.joyasVida--;
                //Por cada Trivia respondida de manera incorrecta el Avatar perderá 100 puntos.
                jug.punteo -= 100;
                nivel.nivel--;
                jug.cajaRecolectadora = 0;
                ResetTablero(nivel.nivel);
                jug.trollActivo = false;
                ActualizarPanel();
                //JoyasDeVida.Text = jug.joyasVida.ToString();
                //CajaRecolectora.Text = jug.cajaRecolectadora.ToString();
            }
        }
    }
}
