namespace calculadora
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 111);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 36);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 153);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 36);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 195);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 36);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 237);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 36);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(114, 69);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 36);
            this.button8.TabIndex = 1;
            this.button8.Text = "button1";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(114, 111);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 36);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(114, 153);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 36);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(114, 195);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 36);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Location = new System.Drawing.Point(114, 237);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(45, 36);
            this.btnpunto.TabIndex = 1;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(12, 27);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(179, 20);
            this.pantalla.TabIndex = 0;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(63, 69);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(45, 36);
            this.button15.TabIndex = 1;
            this.button15.Text = "button1";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(63, 111);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(45, 36);
            this.button16.TabIndex = 1;
            this.button16.Text = "button1";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(63, 153);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(45, 36);
            this.button17.TabIndex = 1;
            this.button17.Text = "button1";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(63, 195);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(45, 36);
            this.button18.TabIndex = 1;
            this.button18.Text = "button1";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.Location = new System.Drawing.Point(114, 69);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(45, 36);
            this.btnmultiplicacion.TabIndex = 1;
            this.btnmultiplicacion.Text = "*";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(63, 69);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(45, 36);
            this.btndividir.TabIndex = 1;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(63, 111);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 36);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(63, 153);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 36);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(63, 195);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 36);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(165, 69);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(45, 36);
            this.button30.TabIndex = 1;
            this.button30.Text = "button1";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // btnrestar
            // 
            this.btnrestar.Location = new System.Drawing.Point(165, 69);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(45, 36);
            this.btnrestar.TabIndex = 1;
            this.btnrestar.Text = "-";
            this.btnrestar.UseVisualStyleBackColor = true;
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(165, 111);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(45, 36);
            this.btnsumar.TabIndex = 1;
            this.btnsumar.Text = "+";
            this.btnsumar.UseVisualStyleBackColor = true;
            // 
            // btnraiz
            // 
            this.btnraiz.Location = new System.Drawing.Point(165, 153);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(45, 36);
            this.btnraiz.TabIndex = 1;
            this.btnraiz.Text = "Raiz";
            this.btnraiz.UseVisualStyleBackColor = true;
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(165, 195);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(45, 78);
            this.btnigual.TabIndex = 1;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 280);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btnigual;
    }
}

