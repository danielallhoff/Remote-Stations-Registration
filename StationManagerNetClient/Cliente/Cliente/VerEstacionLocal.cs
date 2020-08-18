using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class VerEstacionLocal : Form
    {
        
      
        private EstacionService.Estacion estacion;
        private String puertoEstacion;
        public VerEstacionLocal()
        {
            InitializeComponent();
            estacion = new EstacionService.Estacion();
        }
        private void error(String error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void VerEstacionLocal_Load(object sender, EventArgs e)
        {
          

 
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            puertoEstacion = port.Text.ToString();
            
            
            estacion.Url = "http://localhost:" + puertoEstacion + "/EstacionMaster/services/Estacion?wsdl";
            try
            {
                String temp = estacion.getTemperatura().ToString();
                temperatura.Text = estacion.getTemperatura().ToString();
                humedad.Text = estacion.getHumedad();
                luminosidad.Text = estacion.getLuminosidad();
                texto.Text = estacion.getPantalla();
            }
            catch (Exception exc)
            {
                error("Estación no existe o no se pueden obtener los datos!");
            }    
           
           
        }

        private void EncriptacionCheckChanged(object sender, EventArgs e)
        {
            bool encriptado = encript.Checked;
            if (encriptado)
            {
                estacion.setEncriptado("1");
            }
            else
            {
                estacion.setEncriptado("0");
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String temp = temperatura.Text.ToString();
            String hum = humedad.Text.ToString();
            String lum = luminosidad.Text.ToString();
            String tex = texto.Text.ToString();        
            String puertoEstacion = port.Text.ToString();
            String urlEstacion = "http://localhost:" + puertoEstacion + "/EstacionMaster/services/Estacion?wsdl";
            if ( temp != "" && hum != "" && lum != "" && tex != "" && puertoEstacion != "")
            {
                Boolean errorVar = false;
                try
                {

                    int tempInt = int.Parse(temp);
                    int humInt = int.Parse(hum);
                    int lumInt = int.Parse(lum);
                    tex = tex == null
                        ? string.Empty
                        : tex.Substring(0, Math.Min(150, tex.Length));

                    if (tempInt < -30 || tempInt > 50)
                    {
                        errorVar = true;
                    }

                    if (humInt < 0 || humInt > 100)
                    {
                        errorVar = true;
                    }
                    if (lumInt < 0 || lumInt > 800)
                    {
                        errorVar = true;
                    }
                }
                catch (Exception)
                {
                    errorVar = true;
                }

                if (errorVar)
                {
                    error("Variables de entrada no correctas! Tipo incorrecto o no están en el rango");
                }
                else
                {
                    EstacionService.Estacion estacion = new EstacionService.Estacion();
                    estacion.Url = urlEstacion;
                    estacion.setHumedad(hum,"False");
                    estacion.setLuminosidad(lum, "False");
                    estacion.setTemperatura(temp, "False");
                    estacion.setPantalla(tex, "False");

                }
            }
            else
            {
                error("Datos de entrada vacíos!");
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            addStation est = new addStation();
            est.Show();
            this.Hide();
        }
    }
}
