namespace CrystalCollector
{
    partial class CrystalCollector
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tablero = new System.Windows.Forms.DataGridView();
            this.CajaRecolectora = new System.Windows.Forms.RichTextBox();
            this.Etiqueta_CajaRecolectora = new System.Windows.Forms.Label();
            this.JoyasDeVida = new System.Windows.Forms.RichTextBox();
            this.Etiqueta_JoyasDeVida = new System.Windows.Forms.Label();
            this.Punteo = new System.Windows.Forms.Label();
            this.Etiqueta_Puntos = new System.Windows.Forms.Label();
            this.TerminarPartida = new System.Windows.Forms.Button();
            this.EstadoAvatar = new System.Windows.Forms.Button();
            this.Comandos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablero
            // 
            this.Tablero.AllowUserToAddRows = false;
            this.Tablero.BackgroundColor = System.Drawing.Color.White;
            this.Tablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablero.Location = new System.Drawing.Point(2, 1);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(785, 709);
            this.Tablero.TabIndex = 2;
            this.Tablero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tablero_KeyDown);
            // 
            // CajaRecolectora
            // 
            this.CajaRecolectora.Font = new System.Drawing.Font("Modern No. 20", 47.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaRecolectora.Location = new System.Drawing.Point(793, 93);
            this.CajaRecolectora.Name = "CajaRecolectora";
            this.CajaRecolectora.Size = new System.Drawing.Size(110, 135);
            this.CajaRecolectora.TabIndex = 3;
            this.CajaRecolectora.Text = "";
            // 
            // Etiqueta_CajaRecolectora
            // 
            this.Etiqueta_CajaRecolectora.AutoSize = true;
            this.Etiqueta_CajaRecolectora.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_CajaRecolectora.Location = new System.Drawing.Point(796, 231);
            this.Etiqueta_CajaRecolectora.Name = "Etiqueta_CajaRecolectora";
            this.Etiqueta_CajaRecolectora.Size = new System.Drawing.Size(103, 13);
            this.Etiqueta_CajaRecolectora.TabIndex = 4;
            this.Etiqueta_CajaRecolectora.Text = "Caja Recolectora";
            // 
            // JoyasDeVida
            // 
            this.JoyasDeVida.Font = new System.Drawing.Font("Modern No. 20", 47.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoyasDeVida.Location = new System.Drawing.Point(909, 93);
            this.JoyasDeVida.Name = "JoyasDeVida";
            this.JoyasDeVida.Size = new System.Drawing.Size(110, 135);
            this.JoyasDeVida.TabIndex = 5;
            this.JoyasDeVida.Text = "";
            // 
            // Etiqueta_JoyasDeVida
            // 
            this.Etiqueta_JoyasDeVida.AutoSize = true;
            this.Etiqueta_JoyasDeVida.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_JoyasDeVida.Location = new System.Drawing.Point(921, 231);
            this.Etiqueta_JoyasDeVida.Name = "Etiqueta_JoyasDeVida";
            this.Etiqueta_JoyasDeVida.Size = new System.Drawing.Size(85, 13);
            this.Etiqueta_JoyasDeVida.TabIndex = 6;
            this.Etiqueta_JoyasDeVida.Text = "Joyas de Vida";
            // 
            // Punteo
            // 
            this.Punteo.AutoSize = true;
            this.Punteo.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punteo.ForeColor = System.Drawing.Color.DarkBlue;
            this.Punteo.Location = new System.Drawing.Point(793, 1);
            this.Punteo.Name = "Punteo";
            this.Punteo.Size = new System.Drawing.Size(52, 60);
            this.Punteo.TabIndex = 7;
            this.Punteo.Text = "0";
            // 
            // Etiqueta_Puntos
            // 
            this.Etiqueta_Puntos.AutoSize = true;
            this.Etiqueta_Puntos.Font = new System.Drawing.Font("Castellar", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_Puntos.ForeColor = System.Drawing.Color.DarkBlue;
            this.Etiqueta_Puntos.Location = new System.Drawing.Point(828, 59);
            this.Etiqueta_Puntos.Name = "Etiqueta_Puntos";
            this.Etiqueta_Puntos.Size = new System.Drawing.Size(126, 29);
            this.Etiqueta_Puntos.TabIndex = 8;
            this.Etiqueta_Puntos.Text = "puntos";
            // 
            // TerminarPartida
            // 
            this.TerminarPartida.BackColor = System.Drawing.Color.Silver;
            this.TerminarPartida.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminarPartida.Location = new System.Drawing.Point(793, 624);
            this.TerminarPartida.Name = "TerminarPartida";
            this.TerminarPartida.Size = new System.Drawing.Size(226, 86);
            this.TerminarPartida.TabIndex = 9;
            this.TerminarPartida.Text = "Terminar Partida";
            this.TerminarPartida.UseVisualStyleBackColor = false;
            this.TerminarPartida.Click += new System.EventHandler(this.TerminarPartida_Click);
            // 
            // EstadoAvatar
            // 
            this.EstadoAvatar.BackColor = System.Drawing.Color.Silver;
            this.EstadoAvatar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoAvatar.Location = new System.Drawing.Point(793, 532);
            this.EstadoAvatar.Name = "EstadoAvatar";
            this.EstadoAvatar.Size = new System.Drawing.Size(226, 86);
            this.EstadoAvatar.TabIndex = 10;
            this.EstadoAvatar.Text = "Estado de Avatar";
            this.EstadoAvatar.UseVisualStyleBackColor = false;
            this.EstadoAvatar.Click += new System.EventHandler(this.EstadoAvatar_Click);
            // 
            // Comandos
            // 
            this.Comandos.BackColor = System.Drawing.Color.Silver;
            this.Comandos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comandos.Location = new System.Drawing.Point(793, 440);
            this.Comandos.Name = "Comandos";
            this.Comandos.Size = new System.Drawing.Size(226, 86);
            this.Comandos.TabIndex = 12;
            this.Comandos.Text = "Comandos";
            this.Comandos.UseVisualStyleBackColor = false;
            this.Comandos.Click += new System.EventHandler(this.Comandos_Click);
            // 
            // CrystalCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 717);
            this.Controls.Add(this.Comandos);
            this.Controls.Add(this.EstadoAvatar);
            this.Controls.Add(this.TerminarPartida);
            this.Controls.Add(this.Etiqueta_Puntos);
            this.Controls.Add(this.Punteo);
            this.Controls.Add(this.Etiqueta_JoyasDeVida);
            this.Controls.Add(this.JoyasDeVida);
            this.Controls.Add(this.Etiqueta_CajaRecolectora);
            this.Controls.Add(this.CajaRecolectora);
            this.Controls.Add(this.Tablero);
            this.Name = "CrystalCollector";
            this.ShowIcon = false;
            this.Text = "Nivel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrystalCollector_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Tablero;
        private System.Windows.Forms.RichTextBox CajaRecolectora;
        private System.Windows.Forms.Label Etiqueta_CajaRecolectora;
        private System.Windows.Forms.RichTextBox JoyasDeVida;
        private System.Windows.Forms.Label Etiqueta_JoyasDeVida;
        private System.Windows.Forms.Label Punteo;
        private System.Windows.Forms.Label Etiqueta_Puntos;
        private System.Windows.Forms.Button TerminarPartida;
        private System.Windows.Forms.Button EstadoAvatar;
        private System.Windows.Forms.Button Comandos;
    }
}

