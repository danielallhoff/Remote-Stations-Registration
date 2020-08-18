namespace Cliente
{
    partial class VerEstacionLocal
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
            this.texto = new System.Windows.Forms.RichTextBox();
            this.luminosidad = new System.Windows.Forms.TextBox();
            this.humedad = new System.Windows.Forms.TextBox();
            this.temperatura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encript = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cargar = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(124, 233);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(188, 96);
            this.texto.TabIndex = 19;
            this.texto.Text = "";
            // 
            // luminosidad
            // 
            this.luminosidad.Location = new System.Drawing.Point(124, 198);
            this.luminosidad.Name = "luminosidad";
            this.luminosidad.Size = new System.Drawing.Size(100, 20);
            this.luminosidad.TabIndex = 18;
            // 
            // humedad
            // 
            this.humedad.Location = new System.Drawing.Point(124, 154);
            this.humedad.Name = "humedad";
            this.humedad.Size = new System.Drawing.Size(100, 20);
            this.humedad.TabIndex = 17;
            // 
            // temperatura
            // 
            this.temperatura.Location = new System.Drawing.Point(124, 122);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(100, 20);
            this.temperatura.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Texto(max. 150 chars)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Luminosidad(0-800)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Humedad(0-100)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Temperatura(-30C-50C)";
            // 
            // encript
            // 
            this.encript.AutoSize = true;
            this.encript.Location = new System.Drawing.Point(235, 362);
            this.encript.Name = "encript";
            this.encript.Size = new System.Drawing.Size(77, 17);
            this.encript.TabIndex = 20;
            this.encript.Text = "Encriptado";
            this.encript.UseVisualStyleBackColor = true;
            this.encript.CheckStateChanged += new System.EventHandler(this.EncriptacionCheckChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Puerto";
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(235, 79);
            this.Cargar.Name = "Cargar";
            this.Cargar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cargar.Size = new System.Drawing.Size(75, 23);
            this.Cargar.TabIndex = 24;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(124, 84);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 20);
            this.port.TabIndex = 25;
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(17, 362);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 26;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // VerEstacionLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.port);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.encript);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.luminosidad);
            this.Controls.Add(this.humedad);
            this.Controls.Add(this.temperatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "VerEstacionLocal";
            this.Text = "VerEstacionLocal";
            this.Load += new System.EventHandler(this.VerEstacionLocal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.TextBox luminosidad;
        private System.Windows.Forms.TextBox humedad;
        private System.Windows.Forms.TextBox temperatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox encript;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button registrar;
    }
}