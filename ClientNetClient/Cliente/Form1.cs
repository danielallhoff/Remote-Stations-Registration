using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Cliente
{
    //<>
    public partial class Form1 : Form
    {
        private const String error_conexion= "Error conexión a estación";
        private const String error_estacion_no_seleccionada = "No hay estación seleccionada!";
        private const String error_formato_entrada = "Valor de entrada incorrecto para la propiedad!";
        private const String error_propiedad_no_seleccionada = "No hay propiedad seleccionada!";
        private const String error_estacion_existente = "Conexión con estación ya establecida!";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void error(String error) {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Estacion.EstacionService estacionActual;
        private Dictionary<String, Estacion.EstacionService> estaciones = new Dictionary<string, Estacion.EstacionService>();
        private void conectar_Click(object sender, EventArgs e)
        {

            String conexion = conex.Text.ToString();
            String conexionURL = "http://" + conexion + "/EstacionMaster/services/Estacion?wsdl";
            Estacion.EstacionService estacion = new Estacion.EstacionService();
           
            try
            {
                estacion.Url = conexionURL;
                int numEstacion = estaciones.Keys.Count();
                String estacionText = "station"+numEstacion + " -> " + conexion;
                String estacionNombre = "station" + estaciones.Count;
                if (!estaciones.ContainsKey(estacionText))
                {
                    stationList.Items.Add(estacionNombre);
                    stations.Items.Add(estacionText);
                    estaciones.Add(estacionNombre, estacion);
                    //estacionActual = estacion;
                }
                else {
                    error(error_estacion_existente);
                }
                
            }
            catch (Exception ex) {
                error(error_conexion);
            }
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            String ValPropiedad = propiedad.Text;
            String res = "NOK";
            if (ValPropiedad.Length != 0) {
                try
                {
                    switch (ValPropiedad)
                    {
                        case "Temperatura":
                            res = estacionActual.getTemperatura().ToString();
                            break;
                        case "Humedad":
                            res = estacionActual.getHumedad().ToString();
                            break;
                        case "Luminosidad":
                            res = estacionActual.getLuminosidad().ToString();
                            break;
                        case "Pantalla":
                            res = estacionActual.getPantalla();
                            break;
                    }

                    resPropiedad.Text = res;
                }
                catch (Exception ex)
                {
                    error(error_estacion_no_seleccionada);
                }
            }
            else {
                error(error_propiedad_no_seleccionada);
            }
            
        }
        private int convertirToInt(String valor) {
            int res = -1;
            try
            {
                res = Int32.Parse(valor);
            }
            catch (Exception e)
            {
                res = -1;
                error(error_formato_entrada);
            }
            return res;
        }
        private void establecer_Click(object sender, EventArgs e)
        {
            String valor = valorPropiedad.Text;
            String propiedadSeleccionada = propiedad.Text;
            if (propiedadSeleccionada.Length != 0)
            {
                if (propiedadSeleccionada.Equals("Pantalla"))
                {
                    if (valor.Length != 0)
                    {
                        estacionActual.setPantalla(valor);
                        resPropiedad.Text = valor;
                    }
                    else {
                        error(error_formato_entrada);
                    }
                    
                }
                else {
                    int valorInt = convertirToInt(valor);
                    switch (propiedadSeleccionada)
                    {
                        case "Temperatura":
                            estacionActual.setTemperatura(valorInt);
                            break;
                        case "Humedad":
                            estacionActual.setHumedad(valorInt);
                            break;
                        case "Luminosidad":
                            estacionActual.setLuminosidad(valorInt);
                            break;
                    }
                    if (valorInt != -1) {
                        resPropiedad.Text = valorInt.ToString();
                    }
                }
                
            }
            else {
                error(error_propiedad_no_seleccionada);
            }
            
        }

        private void estacionSeleccionada(object sender, EventArgs e)
        {
            Estacion.EstacionService estacion = estaciones[stations.SelectedItem.ToString()];
            estacionActual = estacion;

        }
        /*
        private void keyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) {
                String estacion = stationSelected.Text;
                foreach (String key in estaciones.Keys){
                    if()

                }

            }
        }*/
    }
}
