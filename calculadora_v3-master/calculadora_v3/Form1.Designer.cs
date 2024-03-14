namespace calculadora_v3
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.but0 = new System.Windows.Forms.Button();
            this.butpunto = new System.Windows.Forms.Button();
            this.butigual = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.butsuma = new System.Windows.Forms.Button();
            this.butresta = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.butdividir = new System.Windows.Forms.Button();
            this.butborrartodo = new System.Windows.Forms.Button();
            this.butborrar = new System.Windows.Forms.Button();
            this.apagado = new System.Windows.Forms.Button();
            this.butmultiplicar = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butmultiplicar);
            this.panel1.Controls.Add(this.but9);
            this.panel1.Controls.Add(this.but8);
            this.panel1.Controls.Add(this.but7);
            this.panel1.Controls.Add(this.butdividir);
            this.panel1.Controls.Add(this.butborrartodo);
            this.panel1.Controls.Add(this.butborrar);
            this.panel1.Controls.Add(this.apagado);
            this.panel1.Controls.Add(this.butresta);
            this.panel1.Controls.Add(this.but6);
            this.panel1.Controls.Add(this.but5);
            this.panel1.Controls.Add(this.but4);
            this.panel1.Controls.Add(this.butsuma);
            this.panel1.Controls.Add(this.but3);
            this.panel1.Controls.Add(this.but2);
            this.panel1.Controls.Add(this.but1);
            this.panel1.Controls.Add(this.butigual);
            this.panel1.Controls.Add(this.butpunto);
            this.panel1.Controls.Add(this.but0);
            this.panel1.Location = new System.Drawing.Point(16, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 356);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(805, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(238, 52);
            this.textBox1.TabIndex = 2;
            // 
            // but0
            // 
            this.but0.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but0.Location = new System.Drawing.Point(7, 279);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(55, 62);
            this.but0.TabIndex = 0;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.but0_Click);
            // 
            // butpunto
            // 
            this.butpunto.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butpunto.Location = new System.Drawing.Point(68, 279);
            this.butpunto.Name = "butpunto";
            this.butpunto.Size = new System.Drawing.Size(55, 62);
            this.butpunto.TabIndex = 1;
            this.butpunto.Text = ".";
            this.butpunto.UseVisualStyleBackColor = true;
            this.butpunto.Click += new System.EventHandler(this.butpunto_Click);
            // 
            // butigual
            // 
            this.butigual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butigual.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butigual.Location = new System.Drawing.Point(129, 279);
            this.butigual.Name = "butigual";
            this.butigual.Size = new System.Drawing.Size(116, 62);
            this.butigual.TabIndex = 2;
            this.butigual.Text = "=";
            this.butigual.UseVisualStyleBackColor = false;
            this.butigual.Click += new System.EventHandler(this.butigual_Click);
            // 
            // but3
            // 
            this.but3.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.Location = new System.Drawing.Point(129, 211);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(55, 62);
            this.but3.TabIndex = 5;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // but2
            // 
            this.but2.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.Location = new System.Drawing.Point(68, 211);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(55, 62);
            this.but2.TabIndex = 4;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but1
            // 
            this.but1.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.Location = new System.Drawing.Point(7, 211);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(55, 62);
            this.but1.TabIndex = 3;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // butsuma
            // 
            this.butsuma.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsuma.Location = new System.Drawing.Point(190, 211);
            this.butsuma.Name = "butsuma";
            this.butsuma.Size = new System.Drawing.Size(55, 62);
            this.butsuma.TabIndex = 6;
            this.butsuma.Text = "+";
            this.butsuma.UseVisualStyleBackColor = true;
            this.butsuma.Click += new System.EventHandler(this.butsuma_Click);
            // 
            // butresta
            // 
            this.butresta.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butresta.Location = new System.Drawing.Point(190, 143);
            this.butresta.Name = "butresta";
            this.butresta.Size = new System.Drawing.Size(55, 62);
            this.butresta.TabIndex = 10;
            this.butresta.Text = "-";
            this.butresta.UseVisualStyleBackColor = true;
            this.butresta.Click += new System.EventHandler(this.butresta_Click);
            // 
            // but6
            // 
            this.but6.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but6.Location = new System.Drawing.Point(129, 143);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(55, 62);
            this.but6.TabIndex = 9;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.but6_Click);
            // 
            // but5
            // 
            this.but5.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but5.Location = new System.Drawing.Point(68, 143);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(55, 62);
            this.but5.TabIndex = 8;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // but4
            // 
            this.but4.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but4.Location = new System.Drawing.Point(7, 143);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(55, 62);
            this.but4.TabIndex = 7;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // butdividir
            // 
            this.butdividir.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdividir.Location = new System.Drawing.Point(190, 7);
            this.butdividir.Name = "butdividir";
            this.butdividir.Size = new System.Drawing.Size(55, 62);
            this.butdividir.TabIndex = 14;
            this.butdividir.Text = "/";
            this.butdividir.UseVisualStyleBackColor = true;
            this.butdividir.Click += new System.EventHandler(this.butdividir_Click);
            // 
            // butborrartodo
            // 
            this.butborrartodo.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butborrartodo.Location = new System.Drawing.Point(129, 7);
            this.butborrartodo.Name = "butborrartodo";
            this.butborrartodo.Size = new System.Drawing.Size(55, 62);
            this.butborrartodo.TabIndex = 13;
            this.butborrartodo.Text = "C";
            this.butborrartodo.UseVisualStyleBackColor = true;
            this.butborrartodo.Click += new System.EventHandler(this.butborrartodo_Click);
            // 
            // butborrar
            // 
            this.butborrar.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butborrar.Location = new System.Drawing.Point(68, 7);
            this.butborrar.Name = "butborrar";
            this.butborrar.Size = new System.Drawing.Size(55, 62);
            this.butborrar.TabIndex = 12;
            this.butborrar.Text = "CE";
            this.butborrar.UseVisualStyleBackColor = true;
            this.butborrar.Click += new System.EventHandler(this.butborrar_Click);
            // 
            // apagado
            // 
            this.apagado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.apagado.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagado.Location = new System.Drawing.Point(7, 7);
            this.apagado.Name = "apagado";
            this.apagado.Size = new System.Drawing.Size(55, 62);
            this.apagado.TabIndex = 11;
            this.apagado.Text = "OFF";
            this.apagado.UseVisualStyleBackColor = false;
            this.apagado.Click += new System.EventHandler(this.apagado_Click);
            // 
            // butmultiplicar
            // 
            this.butmultiplicar.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmultiplicar.Location = new System.Drawing.Point(190, 75);
            this.butmultiplicar.Name = "butmultiplicar";
            this.butmultiplicar.Size = new System.Drawing.Size(55, 62);
            this.butmultiplicar.TabIndex = 18;
            this.butmultiplicar.Text = "*";
            this.butmultiplicar.UseVisualStyleBackColor = true;
            this.butmultiplicar.Click += new System.EventHandler(this.butmultiplicar_Click);
            // 
            // but9
            // 
            this.but9.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but9.Location = new System.Drawing.Point(129, 75);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(55, 62);
            this.but9.TabIndex = 17;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but9_Click);
            // 
            // but8
            // 
            this.but8.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but8.Location = new System.Drawing.Point(68, 75);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(55, 62);
            this.but8.TabIndex = 16;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but8_Click);
            // 
            // but7
            // 
            this.but7.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but7.Location = new System.Drawing.Point(7, 75);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(55, 62);
            this.but7.TabIndex = 15;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(280, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butdividir;
        private System.Windows.Forms.Button butborrartodo;
        private System.Windows.Forms.Button butborrar;
        private System.Windows.Forms.Button apagado;
        private System.Windows.Forms.Button butresta;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button butsuma;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button butigual;
        private System.Windows.Forms.Button butpunto;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butmultiplicar;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but7;
    }
}

