namespace CrystalCollector
{
    partial class PreguntaTroll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Etiqueta_Pregunta = new System.Windows.Forms.Label();
            this.Pregunta = new System.Windows.Forms.RichTextBox();
            this.Respuestas = new System.Windows.Forms.CheckedListBox();
            this.Etiqueta_Respuestas = new System.Windows.Forms.Label();
            this.Enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Etiqueta_Pregunta
            // 
            this.Etiqueta_Pregunta.AutoSize = true;
            this.Etiqueta_Pregunta.Location = new System.Drawing.Point(12, 9);
            this.Etiqueta_Pregunta.Name = "Etiqueta_Pregunta";
            this.Etiqueta_Pregunta.Size = new System.Drawing.Size(53, 13);
            this.Etiqueta_Pregunta.TabIndex = 0;
            this.Etiqueta_Pregunta.Text = "Pregunta:";
            // 
            // Pregunta
            // 
            this.Pregunta.Location = new System.Drawing.Point(26, 25);
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.Size = new System.Drawing.Size(353, 96);
            this.Pregunta.TabIndex = 1;
            this.Pregunta.Text = "";
            // 
            // Respuestas
            // 
            this.Respuestas.FormattingEnabled = true;
            this.Respuestas.Location = new System.Drawing.Point(26, 149);
            this.Respuestas.Name = "Respuestas";
            this.Respuestas.Size = new System.Drawing.Size(353, 94);
            this.Respuestas.TabIndex = 2;
            // 
            // Etiqueta_Respuestas
            // 
            this.Etiqueta_Respuestas.AutoSize = true;
            this.Etiqueta_Respuestas.Location = new System.Drawing.Point(12, 133);
            this.Etiqueta_Respuestas.Name = "Etiqueta_Respuestas";
            this.Etiqueta_Respuestas.Size = new System.Drawing.Size(66, 13);
            this.Etiqueta_Respuestas.TabIndex = 3;
            this.Etiqueta_Respuestas.Text = "Respuestas:";
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(15, 261);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(364, 39);
            this.Enviar.TabIndex = 4;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // PreguntaTroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 317);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.Etiqueta_Respuestas);
            this.Controls.Add(this.Respuestas);
            this.Controls.Add(this.Pregunta);
            this.Controls.Add(this.Etiqueta_Pregunta);
            this.Name = "PreguntaTroll";
            this.Text = "PreguntaTroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Etiqueta_Pregunta;
        private System.Windows.Forms.RichTextBox Pregunta;
        private System.Windows.Forms.CheckedListBox Respuestas;
        private System.Windows.Forms.Label Etiqueta_Respuestas;
        private System.Windows.Forms.Button Enviar;
    }
}