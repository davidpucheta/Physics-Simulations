namespace ControlDeTemperatura
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
            this.trackBarFlIn = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFlIn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBarTempDeseada = new System.Windows.Forms.TrackBar();
            this.textBoxTempDeseada = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.VoltControl = new System.Windows.Forms.TextBox();
            this.TempControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TempEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFlIn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTempDeseada)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarFlIn
            // 
            this.trackBarFlIn.Location = new System.Drawing.Point(6, 19);
            this.trackBarFlIn.Maximum = 20;
            this.trackBarFlIn.Name = "trackBarFlIn";
            this.trackBarFlIn.Size = new System.Drawing.Size(104, 42);
            this.trackBarFlIn.TabIndex = 0;
            this.trackBarFlIn.Scroll += new System.EventHandler(this.trackBarFlIn_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFlIn);
            this.groupBox1.Controls.Add(this.trackBarFlIn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flujo de entrada";
            // 
            // textBoxFlIn
            // 
            this.textBoxFlIn.Enabled = false;
            this.textBoxFlIn.Location = new System.Drawing.Point(6, 55);
            this.textBoxFlIn.Name = "textBoxFlIn";
            this.textBoxFlIn.Size = new System.Drawing.Size(101, 20);
            this.textBoxFlIn.TabIndex = 1;
            this.textBoxFlIn.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBarTempDeseada);
            this.groupBox2.Controls.Add(this.textBoxTempDeseada);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temp. deseada";
            // 
            // trackBarTempDeseada
            // 
            this.trackBarTempDeseada.Location = new System.Drawing.Point(7, 20);
            this.trackBarTempDeseada.Maximum = 40;
            this.trackBarTempDeseada.Minimum = 20;
            this.trackBarTempDeseada.Name = "trackBarTempDeseada";
            this.trackBarTempDeseada.Size = new System.Drawing.Size(104, 42);
            this.trackBarTempDeseada.TabIndex = 1;
            this.trackBarTempDeseada.Value = 20;
            this.trackBarTempDeseada.Scroll += new System.EventHandler(this.trackBarTempDeseada_Scroll);
            // 
            // textBoxTempDeseada
            // 
            this.textBoxTempDeseada.Enabled = false;
            this.textBoxTempDeseada.Location = new System.Drawing.Point(7, 63);
            this.textBoxTempDeseada.Name = "textBoxTempDeseada";
            this.textBoxTempDeseada.Size = new System.Drawing.Size(100, 20);
            this.textBoxTempDeseada.TabIndex = 0;
            this.textBoxTempDeseada.Text = "20";
            this.textBoxTempDeseada.TextChanged += new System.EventHandler(this.textBoxTempDeseada_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VoltControl);
            this.groupBox3.Controls.Add(this.TempControl);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(155, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 161);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // VoltControl
            // 
            this.VoltControl.Enabled = false;
            this.VoltControl.Location = new System.Drawing.Point(6, 112);
            this.VoltControl.Name = "VoltControl";
            this.VoltControl.Size = new System.Drawing.Size(100, 20);
            this.VoltControl.TabIndex = 3;
            this.VoltControl.Text = "0";
            // 
            // TempControl
            // 
            this.TempControl.Enabled = false;
            this.TempControl.Location = new System.Drawing.Point(9, 36);
            this.TempControl.Name = "TempControl";
            this.TempControl.Size = new System.Drawing.Size(100, 20);
            this.TempControl.TabIndex = 2;
            this.TempControl.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voltaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TempEntrada
            // 
            this.TempEntrada.Location = new System.Drawing.Point(158, 208);
            this.TempEntrada.Name = "TempEntrada";
            this.TempEntrada.Size = new System.Drawing.Size(121, 20);
            this.TempEntrada.TabIndex = 4;
            this.TempEntrada.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temperatura de entrada:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 255);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TempEntrada);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Control de temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFlIn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTempDeseada)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarFlIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFlIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarTempDeseada;
        private System.Windows.Forms.TextBox textBoxTempDeseada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VoltControl;
        private System.Windows.Forms.TextBox TempControl;
        private System.Windows.Forms.TextBox TempEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

