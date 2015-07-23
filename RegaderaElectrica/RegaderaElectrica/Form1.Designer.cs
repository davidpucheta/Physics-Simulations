namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.check4000w = new System.Windows.Forms.RadioButton();
            this.check2500w = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tempAguaFria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llave = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.resultadoTemperatura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Flujo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llave)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Potencia";
            // 
            // check4000w
            // 
            this.check4000w.AutoSize = true;
            this.check4000w.Location = new System.Drawing.Point(15, 26);
            this.check4000w.Name = "check4000w";
            this.check4000w.Size = new System.Drawing.Size(57, 17);
            this.check4000w.TabIndex = 1;
            this.check4000w.Text = "4000w";
            this.check4000w.UseVisualStyleBackColor = true;
            this.check4000w.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // check2500w
            // 
            this.check2500w.AutoSize = true;
            this.check2500w.Checked = true;
            this.check2500w.Location = new System.Drawing.Point(15, 49);
            this.check2500w.Name = "check2500w";
            this.check2500w.Size = new System.Drawing.Size(57, 17);
            this.check2500w.TabIndex = 2;
            this.check2500w.TabStop = true;
            this.check2500w.Text = "2500w";
            this.check2500w.UseVisualStyleBackColor = true;
            this.check2500w.CheckedChanged += new System.EventHandler(this.check2500w_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura de agua fria";
            // 
            // tempAguaFria
            // 
            this.tempAguaFria.Location = new System.Drawing.Point(115, 26);
            this.tempAguaFria.Name = "tempAguaFria";
            this.tempAguaFria.Size = new System.Drawing.Size(85, 20);
            this.tempAguaFria.TabIndex = 4;
            this.tempAguaFria.Text = "20";
            this.tempAguaFria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tempAguaFria.TextChanged += new System.EventHandler(this.tempAguaFria_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "°C";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llave);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.resultadoTemperatura);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Flujo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // llave
            // 
            this.llave.Location = new System.Drawing.Point(16, 49);
            this.llave.Maximum = 100;
            this.llave.Name = "llave";
            this.llave.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.llave.Size = new System.Drawing.Size(42, 87);
            this.llave.TabIndex = 1;
            this.llave.TickStyle = System.Windows.Forms.TickStyle.None;
            this.llave.Scroll += new System.EventHandler(this.llave_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "°C";
            // 
            // resultadoTemperatura
            // 
            this.resultadoTemperatura.Location = new System.Drawing.Point(101, 87);
            this.resultadoTemperatura.Name = "resultadoTemperatura";
            this.resultadoTemperatura.ReadOnly = true;
            this.resultadoTemperatura.Size = new System.Drawing.Size(84, 20);
            this.resultadoTemperatura.TabIndex = 8;
            this.resultadoTemperatura.Text = "Llave cerrada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Temperatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "lt/min";
            // 
            // Flujo
            // 
            this.Flujo.Location = new System.Drawing.Point(101, 38);
            this.Flujo.Name = "Flujo";
            this.Flujo.ReadOnly = true;
            this.Flujo.Size = new System.Drawing.Size(85, 20);
            this.Flujo.TabIndex = 5;
            this.Flujo.Text = "0";
            this.Flujo.TextChanged += new System.EventHandler(this.Flujo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Flujo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "100%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Llave de agua";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tempAguaFria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check2500w);
            this.Controls.Add(this.check4000w);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(279, 279);
            this.MinimumSize = new System.Drawing.Size(279, 279);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regadera electrica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton check4000w;
        private System.Windows.Forms.RadioButton check2500w;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tempAguaFria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar llave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Flujo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultadoTemperatura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

