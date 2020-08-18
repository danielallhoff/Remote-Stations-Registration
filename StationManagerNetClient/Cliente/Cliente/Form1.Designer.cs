namespace Cliente
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
            this.SuspendLayout();
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(377, 114);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(75, 23);
            this.conectar.TabIndex = 0;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // conex
            // 
            this.conex.Location = new System.Drawing.Point(225, 114);
            this.conex.Name = "conex";
            this.conex.Size = new System.Drawing.Size(146, 20);
            this.conex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conectar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operar";
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(365, 346);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 23);
            this.consultar.TabIndex = 6;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // resPropiedad
            // 
            this.resPropiedad.Location = new System.Drawing.Point(225, 349);
            this.resPropiedad.Name = "resPropiedad";
            this.resPropiedad.Size = new System.Drawing.Size(120, 20);
            this.resPropiedad.TabIndex = 8;
            // 
            // valorPropiedad
            // 
            this.valorPropiedad.Location = new System.Drawing.Point(225, 377);
            this.valorPropiedad.Name = "valorPropiedad";
            this.valorPropiedad.Size = new System.Drawing.Size(120, 20);
            this.valorPropiedad.TabIndex = 9;
            // 
            // establecer
            // 
            this.establecer.Location = new System.Drawing.Point(365, 375);
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
            this.propiedad.Location = new System.Drawing.Point(225, 320);
            this.propiedad.Name = "propiedad";
            this.propiedad.Size = new System.Drawing.Size(121, 21);
            this.propiedad.TabIndex = 14;
            // 
            // stations
            // 
            this.stations.FormattingEnabled = true;
            this.stations.Location = new System.Drawing.Point(225, 159);
            this.stations.Name = "stations";
            this.stations.Size = new System.Drawing.Size(227, 95);
            this.stations.TabIndex = 15;
            // 
            // stationList
            // 
            this.stationList.FormattingEnabled = true;
            this.stationList.Items.AddRange(new object[] {
            "Temperatura",
            "Luminosidad",
            "Humedad",
            "Pantalla"});
            this.stationList.Location = new System.Drawing.Point(224, 293);
            this.stationList.Name = "stationList";
            this.stationList.Size = new System.Drawing.Size(121, 21);
            this.stationList.TabIndex = 16;
            this.stationList.SelectedIndexChanged += new System.EventHandler(this.estacionSeleccionada);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

