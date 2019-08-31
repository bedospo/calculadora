namespace entregar_calculadora
{
    partial class Form1
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
            this.pantalla = new System.Windows.Forms.TextBox();
            this.botigual = new System.Windows.Forms.Button();
            this.botpunto = new System.Windows.Forms.Button();
            this.bot2 = new System.Windows.Forms.Button();
            this.bot0 = new System.Windows.Forms.Button();
            this.bot5 = new System.Windows.Forms.Button();
            this.botraiz = new System.Windows.Forms.Button();
            this.bot6 = new System.Windows.Forms.Button();
            this.bot1 = new System.Windows.Forms.Button();
            this.bot8 = new System.Windows.Forms.Button();
            this.botsuma = new System.Windows.Forms.Button();
            this.bot9 = new System.Windows.Forms.Button();
            this.bot4 = new System.Windows.Forms.Button();
            this.botdivision = new System.Windows.Forms.Button();
            this.botresta = new System.Windows.Forms.Button();
            this.botmultiplicacion = new System.Windows.Forms.Button();
            this.bot7 = new System.Windows.Forms.Button();
            this.boteliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.botretroceder = new System.Windows.Forms.Button();
            this.botporcentaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(11, 9);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(262, 35);
            this.pantalla.TabIndex = 20;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // botigual
            // 
            this.botigual.Location = new System.Drawing.Point(175, 202);
            this.botigual.Name = "botigual";
            this.botigual.Size = new System.Drawing.Size(99, 32);
            this.botigual.TabIndex = 18;
            this.botigual.Text = "=";
            this.botigual.UseVisualStyleBackColor = true;
            this.botigual.Click += new System.EventHandler(this.Botigual_Click);
            // 
            // botpunto
            // 
            this.botpunto.Location = new System.Drawing.Point(226, 126);
            this.botpunto.Name = "botpunto";
            this.botpunto.Size = new System.Drawing.Size(48, 32);
            this.botpunto.TabIndex = 17;
            this.botpunto.Text = ".";
            this.botpunto.UseVisualStyleBackColor = true;
            this.botpunto.Click += new System.EventHandler(this.Botpunto_Click);
            // 
            // bot2
            // 
            this.bot2.Location = new System.Drawing.Point(12, 164);
            this.bot2.Name = "bot2";
            this.bot2.Size = new System.Drawing.Size(48, 32);
            this.bot2.TabIndex = 16;
            this.bot2.Text = "2";
            this.bot2.UseVisualStyleBackColor = true;
            this.bot2.Click += new System.EventHandler(this.Bot2_Click);
            // 
            // bot0
            // 
            this.bot0.Location = new System.Drawing.Point(66, 202);
            this.bot0.Name = "bot0";
            this.bot0.Size = new System.Drawing.Size(101, 32);
            this.bot0.TabIndex = 14;
            this.bot0.Text = "0";
            this.bot0.UseVisualStyleBackColor = true;
            this.bot0.Click += new System.EventHandler(this.Bot0_Click);
            // 
            // bot5
            // 
            this.bot5.Location = new System.Drawing.Point(65, 126);
            this.bot5.Name = "bot5";
            this.bot5.Size = new System.Drawing.Size(48, 32);
            this.bot5.TabIndex = 13;
            this.bot5.Text = "5";
            this.bot5.UseVisualStyleBackColor = true;
            this.bot5.Click += new System.EventHandler(this.Bot5_Click);
            // 
            // botraiz
            // 
            this.botraiz.Location = new System.Drawing.Point(175, 164);
            this.botraiz.Name = "botraiz";
            this.botraiz.Size = new System.Drawing.Size(99, 32);
            this.botraiz.TabIndex = 12;
            this.botraiz.Text = "Raiz";
            this.botraiz.UseVisualStyleBackColor = true;
            this.botraiz.Click += new System.EventHandler(this.Botraiz_Click);
            // 
            // bot6
            // 
            this.bot6.Location = new System.Drawing.Point(12, 88);
            this.bot6.Name = "bot6";
            this.bot6.Size = new System.Drawing.Size(48, 32);
            this.bot6.TabIndex = 19;
            this.bot6.Text = "6";
            this.bot6.UseVisualStyleBackColor = true;
            this.bot6.Click += new System.EventHandler(this.Bot6_Click);
            // 
            // bot1
            // 
            this.bot1.Location = new System.Drawing.Point(12, 202);
            this.bot1.Name = "bot1";
            this.bot1.Size = new System.Drawing.Size(48, 32);
            this.bot1.TabIndex = 2;
            this.bot1.Text = "1";
            this.bot1.UseVisualStyleBackColor = true;
            this.bot1.Click += new System.EventHandler(this.Bot1_Click);
            // 
            // bot8
            // 
            this.bot8.Location = new System.Drawing.Point(11, 50);
            this.bot8.Name = "bot8";
            this.bot8.Size = new System.Drawing.Size(48, 32);
            this.bot8.TabIndex = 9;
            this.bot8.Text = "8";
            this.bot8.UseVisualStyleBackColor = true;
            this.bot8.Click += new System.EventHandler(this.Bot8_Click);
            // 
            // botsuma
            // 
            this.botsuma.Location = new System.Drawing.Point(226, 88);
            this.botsuma.Name = "botsuma";
            this.botsuma.Size = new System.Drawing.Size(48, 32);
            this.botsuma.TabIndex = 8;
            this.botsuma.Text = "+";
            this.botsuma.UseVisualStyleBackColor = true;
            this.botsuma.Click += new System.EventHandler(this.Botsuma_Click);
            // 
            // bot9
            // 
            this.bot9.Location = new System.Drawing.Point(65, 50);
            this.bot9.Name = "bot9";
            this.bot9.Size = new System.Drawing.Size(48, 32);
            this.bot9.TabIndex = 7;
            this.bot9.Text = "9";
            this.bot9.UseVisualStyleBackColor = true;
            this.bot9.Click += new System.EventHandler(this.Bot9_Click);
            // 
            // bot4
            // 
            this.bot4.Location = new System.Drawing.Point(11, 126);
            this.bot4.Name = "bot4";
            this.bot4.Size = new System.Drawing.Size(48, 32);
            this.bot4.TabIndex = 6;
            this.bot4.Text = "4";
            this.bot4.UseVisualStyleBackColor = true;
            this.bot4.Click += new System.EventHandler(this.Bot4_Click);
            // 
            // botdivision
            // 
            this.botdivision.Location = new System.Drawing.Point(175, 50);
            this.botdivision.Name = "botdivision";
            this.botdivision.Size = new System.Drawing.Size(48, 32);
            this.botdivision.TabIndex = 5;
            this.botdivision.Text = "/";
            this.botdivision.UseVisualStyleBackColor = true;
            this.botdivision.Click += new System.EventHandler(this.Botdivision_Click);
            // 
            // botresta
            // 
            this.botresta.Location = new System.Drawing.Point(226, 50);
            this.botresta.Name = "botresta";
            this.botresta.Size = new System.Drawing.Size(48, 32);
            this.botresta.TabIndex = 4;
            this.botresta.Text = "-";
            this.botresta.UseVisualStyleBackColor = true;
            this.botresta.Click += new System.EventHandler(this.Botresta_Click);
            // 
            // botmultiplicacion
            // 
            this.botmultiplicacion.Location = new System.Drawing.Point(175, 88);
            this.botmultiplicacion.Name = "botmultiplicacion";
            this.botmultiplicacion.Size = new System.Drawing.Size(48, 32);
            this.botmultiplicacion.TabIndex = 3;
            this.botmultiplicacion.Text = "*";
            this.botmultiplicacion.UseVisualStyleBackColor = true;
            this.botmultiplicacion.Click += new System.EventHandler(this.Botmultiplicacion_Click);
            // 
            // bot7
            // 
            this.bot7.Location = new System.Drawing.Point(65, 88);
            this.bot7.Name = "bot7";
            this.bot7.Size = new System.Drawing.Size(48, 32);
            this.bot7.TabIndex = 10;
            this.bot7.Text = "7";
            this.bot7.UseVisualStyleBackColor = true;
            this.bot7.Click += new System.EventHandler(this.Bot7_Click);
            // 
            // boteliminar
            // 
            this.boteliminar.Location = new System.Drawing.Point(119, 126);
            this.boteliminar.Name = "boteliminar";
            this.boteliminar.Size = new System.Drawing.Size(48, 70);
            this.boteliminar.TabIndex = 11;
            this.boteliminar.Text = "CE";
            this.boteliminar.UseVisualStyleBackColor = true;
            this.boteliminar.Click += new System.EventHandler(this.Boteliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Bot3_Click);
            // 
            // botretroceder
            // 
            this.botretroceder.Location = new System.Drawing.Point(119, 50);
            this.botretroceder.Name = "botretroceder";
            this.botretroceder.Size = new System.Drawing.Size(48, 70);
            this.botretroceder.TabIndex = 11;
            this.botretroceder.Text = "C";
            this.botretroceder.UseVisualStyleBackColor = true;
            this.botretroceder.Click += new System.EventHandler(this.Boteliminar_Click);
            // 
            // botporcentaje
            // 
            this.botporcentaje.Location = new System.Drawing.Point(175, 126);
            this.botporcentaje.Name = "botporcentaje";
            this.botporcentaje.Size = new System.Drawing.Size(48, 32);
            this.botporcentaje.TabIndex = 21;
            this.botporcentaje.Text = "%";
            this.botporcentaje.UseVisualStyleBackColor = true;
            this.botporcentaje.Click += new System.EventHandler(this.Botporcentaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 241);
            this.Controls.Add(this.botporcentaje);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.botigual);
            this.Controls.Add(this.botpunto);
            this.Controls.Add(this.bot2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bot0);
            this.Controls.Add(this.bot5);
            this.Controls.Add(this.botraiz);
            this.Controls.Add(this.bot6);
            this.Controls.Add(this.bot1);
            this.Controls.Add(this.bot8);
            this.Controls.Add(this.botsuma);
            this.Controls.Add(this.bot9);
            this.Controls.Add(this.bot4);
            this.Controls.Add(this.botdivision);
            this.Controls.Add(this.botresta);
            this.Controls.Add(this.botmultiplicacion);
            this.Controls.Add(this.bot7);
            this.Controls.Add(this.botretroceder);
            this.Controls.Add(this.boteliminar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button botigual;
        private System.Windows.Forms.Button botpunto;
        private System.Windows.Forms.Button bot2;
        private System.Windows.Forms.Button bot0;
        private System.Windows.Forms.Button bot5;
        private System.Windows.Forms.Button botraiz;
        private System.Windows.Forms.Button bot6;
        private System.Windows.Forms.Button bot1;
        private System.Windows.Forms.Button bot8;
        private System.Windows.Forms.Button botsuma;
        private System.Windows.Forms.Button bot9;
        private System.Windows.Forms.Button bot4;
        private System.Windows.Forms.Button botdivision;
        private System.Windows.Forms.Button botresta;
        private System.Windows.Forms.Button botmultiplicacion;
        private System.Windows.Forms.Button bot7;
        private System.Windows.Forms.Button boteliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botretroceder;
        private System.Windows.Forms.Button botporcentaje;
    }
}

