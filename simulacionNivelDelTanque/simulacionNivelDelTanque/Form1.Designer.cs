namespace simulacionNivelDelTanque
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.llaveLlenado = new System.Windows.Forms.TrackBar();
            this.textBoxFlujoLlenado = new System.Windows.Forms.TextBox();
            this.flujoLlenado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFlujoVaciado = new System.Windows.Forms.TextBox();
            this.llaveVaciado = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTanqueLitros = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTanquePorcentaje = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.initBtn = new System.Windows.Forms.Button();
            this.capacidadTanque = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.llaveLlenado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llaveVaciado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacidadTanque)).BeginInit();
            this.SuspendLayout();
            // 
            // llaveLlenado
            // 
            this.llaveLlenado.Location = new System.Drawing.Point(12, 12);
            this.llaveLlenado.Maximum = 100;
            this.llaveLlenado.Name = "llaveLlenado";
            this.llaveLlenado.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.llaveLlenado.Size = new System.Drawing.Size(42, 104);
            this.llaveLlenado.TabIndex = 0;
            this.llaveLlenado.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // textBoxFlujoLlenado
            // 
            this.textBoxFlujoLlenado.Enabled = false;
            this.textBoxFlujoLlenado.Location = new System.Drawing.Point(60, 62);
            this.textBoxFlujoLlenado.Name = "textBoxFlujoLlenado";
            this.textBoxFlujoLlenado.Size = new System.Drawing.Size(30, 20);
            this.textBoxFlujoLlenado.TabIndex = 1;
            this.textBoxFlujoLlenado.Text = "0";
            this.textBoxFlujoLlenado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flujoLlenado
            // 
            this.flujoLlenado.AutoSize = true;
            this.flujoLlenado.Location = new System.Drawing.Point(57, 28);
            this.flujoLlenado.Name = "flujoLlenado";
            this.flujoLlenado.Size = new System.Drawing.Size(81, 13);
            this.flujoLlenado.TabIndex = 2;
            this.flujoLlenado.Text = "Flujo de llenado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "lts/min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "lts/min";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Flujo de vaciado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxFlujoVaciado
            // 
            this.textBoxFlujoVaciado.Enabled = false;
            this.textBoxFlujoVaciado.Location = new System.Drawing.Point(287, 295);
            this.textBoxFlujoVaciado.Name = "textBoxFlujoVaciado";
            this.textBoxFlujoVaciado.Size = new System.Drawing.Size(30, 20);
            this.textBoxFlujoVaciado.TabIndex = 5;
            this.textBoxFlujoVaciado.Text = "0";
            this.textBoxFlujoVaciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFlujoVaciado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // llaveVaciado
            // 
            this.llaveVaciado.Location = new System.Drawing.Point(239, 245);
            this.llaveVaciado.Maximum = 100;
            this.llaveVaciado.Name = "llaveVaciado";
            this.llaveVaciado.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.llaveVaciado.Size = new System.Drawing.Size(42, 104);
            this.llaveVaciado.TabIndex = 4;
            this.llaveVaciado.TickStyle = System.Windows.Forms.TickStyle.None;
            this.llaveVaciado.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Capacidad del tanque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "lts";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxTanqueLitros);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxTanquePorcentaje);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 123);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tanque";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "lts";
            // 
            // textBoxTanqueLitros
            // 
            this.textBoxTanqueLitros.Enabled = false;
            this.textBoxTanqueLitros.Location = new System.Drawing.Point(76, 68);
            this.textBoxTanqueLitros.Name = "textBoxTanqueLitros";
            this.textBoxTanqueLitros.Size = new System.Drawing.Size(100, 20);
            this.textBoxTanqueLitros.TabIndex = 2;
            this.textBoxTanqueLitros.Text = "0";
            this.textBoxTanqueLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "%";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxTanquePorcentaje
            // 
            this.textBoxTanquePorcentaje.Enabled = false;
            this.textBoxTanquePorcentaje.Location = new System.Drawing.Point(76, 42);
            this.textBoxTanquePorcentaje.Name = "textBoxTanquePorcentaje";
            this.textBoxTanquePorcentaje.Size = new System.Drawing.Size(100, 20);
            this.textBoxTanquePorcentaje.TabIndex = 0;
            this.textBoxTanquePorcentaje.Text = "0";
            this.textBoxTanquePorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // initBtn
            // 
            this.initBtn.Location = new System.Drawing.Point(239, 28);
            this.initBtn.Name = "initBtn";
            this.initBtn.Size = new System.Drawing.Size(122, 54);
            this.initBtn.TabIndex = 12;
            this.initBtn.Text = "Iniciar simulación";
            this.initBtn.UseVisualStyleBackColor = true;
            this.initBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // capacidadTanque
            // 
            this.capacidadTanque.Location = new System.Drawing.Point(12, 315);
            this.capacidadTanque.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.capacidadTanque.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.capacidadTanque.Name = "capacidadTanque";
            this.capacidadTanque.Size = new System.Drawing.Size(100, 20);
            this.capacidadTanque.TabIndex = 13;
            this.capacidadTanque.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.capacidadTanque);
            this.Controls.Add(this.initBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFlujoVaciado);
            this.Controls.Add(this.llaveVaciado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flujoLlenado);
            this.Controls.Add(this.textBoxFlujoLlenado);
            this.Controls.Add(this.llaveLlenado);
            this.Name = "Form1";
            this.Text = "Nivel del tanque";
            ((System.ComponentModel.ISupportInitialize)(this.llaveLlenado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llaveVaciado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacidadTanque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar llaveLlenado;
        private System.Windows.Forms.TextBox textBoxFlujoLlenado;
        private System.Windows.Forms.Label flujoLlenado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFlujoVaciado;
        private System.Windows.Forms.TrackBar llaveVaciado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTanquePorcentaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTanqueLitros;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button initBtn;
        private System.Windows.Forms.NumericUpDown capacidadTanque;
    }
}

