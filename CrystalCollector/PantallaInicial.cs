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
//Para usar el InputBox de VisualBasic .NET
using Microsoft.VisualBasic;

namespace CrystalCollector
{
    public partial class PantallaInicial : Form
    {
        private string genero;
        private string nombre;
        public PantallaInicial()
        {
            InitializeComponent();
            genero = "Masculino";
            nombre = "Avatar";
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            //Al seleccionar la opción de Iniciar nueva partida el jugador deberá: Seleccionar si desea jugar con un Avatar masculino o femenino.
            genero = Interaction.InputBox("¿Deseas jugar con un Avatar (Masculino / Femenino)?", "GENERO AVATAR", genero);
            //Al seleccionar la opción de Iniciar nueva partida el jugador deberá: Asignarle un nombre al Avatar.
            nombre = Interaction.InputBox("Asignale un nombre al Avatar:", "NOMBRE AVATAR", nombre);

            CrystalCollector cc = new CrystalCollector(nombre, genero, this);
            cc.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Instrucciones.
        private void Instrucciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"El juego consiste en un Avatar que debe de moverse a lo largo de un tablero, el cual podrá cambiar dependiendo el nivel que se encuentre jugando.

El objetivo principal del juego es recolectar cristales que se encuentran esparcidos por el tablero.

El Avatar podrá subir de nivel si y sólo si ha recolectado todos los cristales de cada tablero.

Dentro del tablero se encontrarán con varios obstáculos que pondrán a prueba a dicho Avatar.", "INSTRUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Información sobre CRYSTAL COLLECTOR.
        private void Informacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"El juego de Crystal Collector consiste en un Avatar moviéndose alrededor de un tablero con la finalidad encontrar el portal hacia el nuevo nivel.

Para acceder al siguiente nivel, el Avatar deberá recolectar los Cristales que se encontrarán en cada uno de los tableros que componen el juego.

Dentro de cada tablero se encontrarán Trolls o Enemigos los cuales podrán o no aparecer en cada nivel y se encargarán de poner a prueba al jugador con trivias, las cuales deberán ser respondidas correctamente, de lo contrario serán forzados a reiniciar en el tablero previo.", "INFORMACION SOBRE CRYSTAL COLLECTOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
