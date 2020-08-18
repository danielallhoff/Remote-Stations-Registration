namespace Cliente
{
    partial class Estaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estaciones));
            this.conectar = new System.Windows.Forms.Button();
            this.conex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.consultar = new System.Windows.Forms.Button();
            this.resPropiedad = new System.Windows.Forms.TextBox();
            this.valorPropiedad = new System.Windows.Forms.TextBox();
            this.establecer = new System.Windows.Forms.Button();
            this.propiedad = new System.Windows.Forms.ComboBox();
            this.stations = new System.Windows.Forms.ListBox();
            this.stationList = new System.Windows.Forms.ComboBox();
            this.comunicacion = new System.Windows.Forms.CheckBox();
            this.refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.conf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(195, 119);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(75, 23);
            this.conectar.TabIndex = 0;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // conex
            // 
            this.conex.Location = new System.Drawing.Point(43, 119);
            this.conex.Name = "conex";
            this.conex.Size = new System.Drawing.Size(146, 20);
            this.conex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conectar a JUDDI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operar";
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(183, 351);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 23);
            this.consultar.TabIndex = 6;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // resPropiedad
            // 
            this.resPropiedad.Location = new System.Drawing.Point(43, 354);
            this.resPropiedad.Name = "resPropiedad";
            this.resPropiedad.Size = new System.Drawing.Size(120, 20);
            this.resPropiedad.TabIndex = 8;
            // 
            // valorPropiedad
            // 
            this.valorPropiedad.Location = new System.Drawing.Point(43, 382);
            this.valorPropiedad.Name = "valorPropiedad";
            this.valorPropiedad.Size = new System.Drawing.Size(120, 20);
            this.valorPropiedad.TabIndex = 9;
            // 
            // establecer
            // 
            this.establecer.Location = new System.Drawing.Point(183, 380);
            this.establecer.Name = "establecer";
            this.establecer.Size = new System.Drawing.Size(75, 23);
            this.establecer.TabIndex = 10;
            this.establecer.Text = "Establecer";
            this.establecer.UseVisualStyleBackColor = true;
            this.establecer.Click += new System.EventHandler(this.establecer_Click);
            // 
            // propiedad
            // 
            this.propiedad.FormattingEnabled = true;
            this.propiedad.Items.AddRange(new object[] {
            "Temperatura",
            "Luminosidad",
            "Humedad",
            "Pantalla"});
            this.propiedad.Location = new System.Drawing.Point(43, 325);
            this.propiedad.Name = "propiedad";
            this.propiedad.Size = new System.Drawing.Size(121, 21);
            this.propiedad.TabIndex = 14;
            // 
            // stations
            // 
            this.stations.FormattingEnabled = true;
            this.stations.Location = new System.Drawing.Point(43, 164);
            this.stations.Name = "stations";
            this.stations.Size = new System.Drawing.Size(227, 95);
            this.stations.TabIndex = 15;
            // 
            // stationList
            // 
            this.stationList.FormattingEnabled = true;
            this.stationList.Location = new System.Drawing.Point(42, 298);
            this.stationList.Name = "stationList";
            this.stationList.Size = new System.Drawing.Size(121, 21);
            this.stationList.TabIndex = 16;
            this.stationList.SelectedIndexChanged += new System.EventHandler(this.estacionSeleccionada);
            // 
            // comunicacion
            // 
            this.comunicacion.AutoSize = true;
            this.comunicacion.Location = new System.Drawing.Point(42, 408);
            this.comunicacion.Name = "comunicacion";
            this.comunicacion.Size = new System.Drawing.Size(146, 17);
            this.comunicacion.TabIndex = 17;
            this.comunicacion.Text = "Comunicación encriptada";
            this.comunicacion.UseVisualStyleBackColor = true;
            this.comunicacion.CheckedChanged += new System.EventHandler(this.encriptacion);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(195, 64);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 18;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Suscribirse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(183, 296);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(29, 20);
            this.min.TabIndex = 20;
            this.min.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(229, 296);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(29, 20);
            this.max.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Max";
            // 
            // conf
            // 
            this.conf.Image = ((System.Drawing.Image)(resources.GetObject("conf.Image")));
            this.conf.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.conf.Location = new System.Drawing.Point(42, 24);
            this.conf.Name = "conf";
            this.conf.Size = new System.Drawing.Size(23, 25);
            this.conf.TabIndex = 24;
            this.conf.UseVisualStyleBackColor = true;
            this.conf.Click += new System.EventHandler(this.Conf_Click);
            // 
            // Estaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 456);
            this.Controls.Add(this.conf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.comunicacion);
            this.Controls.Add(this.stationList);
            this.Controls.Add(this.stations);
            this.Controls.Add(this.propiedad);
            this.Controls.Add(this.establecer);
            this.Controls.Add(this.valorPropiedad);
            this.Controls.Add(this.resPropiedad);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conex);
            this.Controls.Add(this.conectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Estaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.TextBox conex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.TextBox resPropiedad;
        private System.Windows.Forms.TextBox valorPropiedad;
        private System.Windows.Forms.Button establecer;
        private System.Windows.Forms.ComboBox propiedad;
        private System.Windows.Forms.ListBox stations;
        private System.Windows.Forms.ComboBox stationList;
        private System.Windows.Forms.CheckBox comunicacion;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button conf;
    }
}

