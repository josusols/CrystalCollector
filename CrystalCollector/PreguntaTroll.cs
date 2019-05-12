using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalCollector
{
    public partial class PreguntaTroll : Form
    {
        public int respuestaSeleccionada = 0;
        private CrystalCollector cc;
        public PreguntaTroll(Troll t, CrystalCollector _cc)
        {
            InitializeComponent();
            Pregunta.Text = t.pregunta1.pregunta;
            for (int i = 0; i < 5; i++)
            {
                Respuestas.DataSource = t.pregunta1.respuestas;
            }

            cc = _cc;
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            respuestaSeleccionada = Respuestas.SelectedIndex;
            cc.guardarRespuesta(respuestaSeleccionada);
            cc.Show();
            this.Close();
        }
    }
}
