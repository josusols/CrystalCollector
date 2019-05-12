namespace CrystalCollector
{
    partial class PantallaInicial
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
            this.Inicio = new System.Windows.Forms.Button();
            this.Instrucciones = new System.Windows.Forms.Button();
            this.Informacion = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.Silver;
            this.Inicio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.Location = new System.Drawing.Point(12, 12);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(144, 86);
            this.Inicio.TabIndex = 2;
            this.Inicio.Text = "Iniciar Nueva Partida";
            this.Inicio.UseVisualStyleBackColor = false;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Instrucciones
            // 
            this.Instrucciones.BackColor = System.Drawing.Color.Silver;
            this.Instrucciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instrucciones.Location = new System.Drawing.Point(162, 12);
            this.Instrucciones.Name = "Instrucciones";
            this.Instrucciones.Size = new System.Drawing.Size(141, 86);
            this.Instrucciones.TabIndex = 3;
            this.Instrucciones.Text = "Instrucciones";
            this.Instrucciones.UseVisualStyleBackColor = false;
            this.Instrucciones.Click += new System.EventHandler(this.Instrucciones_Click);
            // 
            // Informacion
            // 
            this.Informacion.BackColor = System.Drawing.Color.Silver;
            this.Informacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacion.Location = new System.Drawing.Point(12, 104);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(144, 86);
            this.Informacion.TabIndex = 4;
            this.Informacion.Text = "Información sobre CRYSTAL COLLECTOR";
            this.Informacion.UseVisualStyleBackColor = false;
            this.Informacion.Click += new System.EventHandler(this.Informacion_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Silver;
            this.Salir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(162, 104);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(141, 86);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir del Juego";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 204);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Informacion);
            this.Controls.Add(this.Instrucciones);
            this.Controls.Add(this.Inicio);
            this.Name = "PantallaInicial";
            this.ShowIcon = false;
            this.Text = "Pantalla Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Instrucciones;
        private System.Windows.Forms.Button Informacion;
        private System.Windows.Forms.Button Salir;
    }
}