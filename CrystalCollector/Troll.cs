//Librerías.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalCollector
{
    public class Troll
    {
        /*Listado de preguntas*/
        public Pregunta pregunta1 = new Pregunta();
        public Pregunta pregunta2 = new Pregunta();
        public Pregunta pregunta3 = new Pregunta();
        public Pregunta pregunta4 = new Pregunta();
        public Pregunta pregunta5 = new Pregunta();
        public Pregunta pregunta6 = new Pregunta();
        public Pregunta pregunta7 = new Pregunta();
        public Pregunta pregunta8 = new Pregunta();
        public Pregunta pregunta9 = new Pregunta();
        public Pregunta pregunta10 = new Pregunta();
        public Pregunta pregunta11 = new Pregunta();
        public Pregunta pregunta12 = new Pregunta();
        public Pregunta pregunta13 = new Pregunta();
        public Pregunta pregunta14 = new Pregunta();
        public Pregunta pregunta15 = new Pregunta();

        public Troll()
        {
            pregunta1.pregunta =
                @"La cantidad de combustible consumido por un transporte, es directamente proporcional a la distancia recorrida. Si un móvil al recorrer una distancia de 182 km, consume 14 l de combustible. ¿Cuál es la distancia, en iguales condiciones a las anteriores, que puede recorrer con 30 l de combustible?";
            pregunta1.respuestas[0] = "15";
            pregunta1.respuestas[1] = "115";
            pregunta1.respuestas[2] = "390";
            pregunta1.respuestas[3] = "260";
            pregunta1.respuestas[4] = "0";
            pregunta1.respuestaCorrecta = 2;
        }

        /*SE PUEDEN SEGUIR AGREGANDO MAS PREGUNTAS!!*/
    }
}
