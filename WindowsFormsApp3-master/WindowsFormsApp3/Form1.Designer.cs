namespace WindowsFormsApp3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Uno = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.borrartodo = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.borrarnumero = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.borrartodo);
            this.panel1.Controls.Add(this.dividir);
            this.panel1.Controls.Add(this.borrarnumero);
            this.panel1.Controls.Add(this.apagar);
            this.panel1.Controls.Add(this.igual);
            this.panel1.Controls.Add(this.punto);
            this.panel1.Controls.Add(this.cero);
            this.panel1.Controls.Add(this.multiplicar);
            this.panel1.Controls.Add(this.resta);
            this.panel1.Controls.Add(this.suma);
            this.panel1.Controls.Add(this.nueve);
            this.panel1.Controls.Add(this.ocho);
            this.panel1.Controls.Add(this.siete);
            this.panel1.Controls.Add(this.seis);
            this.panel1.Controls.Add(this.cinco);
            this.panel1.Controls.Add(this.cuatro);
            this.panel1.Controls.Add(this.tres);
            this.panel1.Controls.Add(this.dos);
            this.panel1.Controls.Add(this.Uno);
            this.panel1.Location = new System.Drawing.Point(8, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 285);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Uno
            // 
            this.Uno.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uno.Location = new System.Drawing.Point(14, 171);
            this.Uno.Name = "Uno";
            this.Uno.Size = new System.Drawing.Size(55, 48);
            this.Uno.TabIndex = 0;
            this.Uno.Text = "1";
            this.Uno.UseVisualStyleBackColor = true;
            this.Uno.Click += new System.EventHandler(this.Uno_Click);
            // 
            // dos
            // 
            this.dos.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.Location = new System.Drawing.Point(75, 171);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(55, 48);
            this.dos.TabIndex = 1;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.button1_Click);
            // 
            // tres
            // 
            this.tres.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(136, 171);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(55, 48);
            this.tres.TabIndex = 2;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // seis
            // 
            this.seis.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(136, 117);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(55, 48);
            this.seis.TabIndex = 5;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(75, 117);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(55, 48);
            this.cinco.TabIndex = 4;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // cuatro
            // 
            this.cuatro.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.Location = new System.Drawing.Point(14, 117);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(55, 48);
            this.cuatro.TabIndex = 3;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // nueve
            // 
            this.nueve.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueve.Location = new System.Drawing.Point(136, 63);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(55, 48);
            this.nueve.TabIndex = 8;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // ocho
            // 
            this.ocho.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.Location = new System.Drawing.Point(75, 63);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(55, 48);
            this.ocho.TabIndex = 7;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // siete
            // 
            this.siete.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.Location = new System.Drawing.Point(14, 63);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(55, 48);
            this.siete.TabIndex = 6;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(197, 63);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(55, 48);
            this.multiplicar.TabIndex = 11;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(197, 117);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(55, 48);
            this.resta.TabIndex = 10;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(197, 171);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(55, 48);
            this.suma.TabIndex = 9;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // igual
            // 
            this.igual.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(136, 225);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(116, 48);
            this.igual.TabIndex = 14;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // punto
            // 
            this.punto.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.Location = new System.Drawing.Point(75, 225);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(55, 48);
            this.punto.TabIndex = 13;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // cero
            // 
            this.cero.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cero.Location = new System.Drawing.Point(14, 225);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(55, 48);
            this.cero.TabIndex = 12;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // borrartodo
            // 
            this.borrartodo.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrartodo.Location = new System.Drawing.Point(197, 9);
            this.borrartodo.Name = "borrartodo";
            this.borrartodo.Size = new System.Drawing.Size(55, 48);
            this.borrartodo.TabIndex = 18;
            this.borrartodo.Text = "C";
            this.borrartodo.UseVisualStyleBackColor = true;
            this.borrartodo.Click += new System.EventHandler(this.borrartodo_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(136, 9);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(55, 48);
            this.dividir.TabIndex = 17;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // borrarnumero
            // 
            this.borrarnumero.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarnumero.Location = new System.Drawing.Point(75, 9);
            this.borrarnumero.Name = "borrarnumero";
            this.borrarnumero.Size = new System.Drawing.Size(55, 48);
            this.borrarnumero.TabIndex = 16;
            this.borrarnumero.Text = "<";
            this.borrarnumero.UseVisualStyleBackColor = true;
            this.borrarnumero.Click += new System.EventHandler(this.borrarnumero_Click);
            // 
            // apagar
            // 
            this.apagar.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.Location = new System.Drawing.Point(14, 9);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(55, 48);
            this.apagar.TabIndex = 15;
            this.apagar.Text = "OFF";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 359);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button Uno;
        private System.Windows.Forms.Button borrartodo;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button borrarnumero;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button cuatro;
    }
}

