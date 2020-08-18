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
using System.Text.RegularExpressions;
using System.Net;
using System.Security.Cryptography;
using System.IO;

namespace Cliente
{
    //<>
    public partial class Estaciones : Form
    {
        private const String error_conexion= "Error conexión a estación";
        private const String error_estacion_no_seleccionada = "No hay estación seleccionada!";
        private const String error_formato_entrada = "Valor de entrada incorrecto para la propiedad!";
        private const String error_propiedad_no_seleccionada = "Selecciona estación y propiedad!";
        private const String error_estacion_existente = "Conexión con estación ya establecida!";
        private const String error_entrada_conexion = "Formato de cadena conexión incorrecta(IP:Puerto)!";
        private String user;
        private String miIP;
        private String path = "log.txt";
        private String conexion;
        private String puertoSubs = "8080";
        private SubscribeService.Subscribe subs = new SubscribeService.Subscribe();
        Timer t = new Timer();
        public Estaciones(String user)
        {
            InitializeComponent();
            this.user = user;
            string hostname = Dns.GetHostName();
            miIP = Dns.GetHostByName(hostname).AddressList[0].ToString();
            path = "log.txt";
           
            subs.Url = "http://localhost:"+puertoSubs + "/SubscribeMaster/services/Subscribe?wsdl";
            subs.Timeout = 1000;                    
            this.conf.Image = this.conf.Image.GetThumbnailImage(20, 20, null, IntPtr.Zero);
            //subs.notificarCompleted += new SubscribeService.notificarCompletedEventHandler(getNotificaton);
            t.Interval = 2000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();            

        }
        public void Estaciones_Load(Object sender, EventArgs e)
        {
            
        }
        
        // Specify what is done when a file is changed, created, or deleted.
        private void t_Tick(object sender, EventArgs e)
        {
            try
            {
                String res = subs.obtenerNotificaciones();
                if (res != "NOK")
                {
                    mensaje(res);
                    
                }
                t.Interval = 1000;
            }
            catch (Exception exc)
            {
                t.Interval = 30000;
            }
            
        }

        private void escribirFichero(String cadena)
        {
            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine(cadena);
                sw.Close();
            }
            else
            {
                System.IO.File.CreateText(path);
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(cadena);
                sw.Close();
            }
        }

        private void crearLog(String operacion, String propiedad) {

            var src = DateTime.UtcNow;
            string utc = src.ToString();
            String log = "Usuario " + user + " de IP:" + miIP + " a la hora " + utc + " realiza operación " + operacion + " sobre " + propiedad;
            escribirFichero(log);
            estacionActual.log(user, miIP, utc, operacion, propiedad);
        }

        private static void error(String error) {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void mensaje(String mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private Boolean encriptado = false;
        private Estacion.Estacion estacionActual;
        private Dictionary<String, Estacion.Estacion> estaciones = new Dictionary<string, Estacion.Estacion>();
        private Dictionary<String, String> ips = new Dictionary<String, String>();
        private static int timeout = 1000;

        private void cargarEstaciones()
        {
            try
            {
                conexion = conex.Text.ToString();
                JUDDISecurity.UDDISecurityService securityService = new JUDDISecurity.UDDISecurityService();             
                securityService.Url = "http://" + conexion + "/juddiv3/services/security";
                JUDDISecurity.get_authToken token = new JUDDISecurity.get_authToken();
                token.cred = "root";
                token.userID = "root";


                JUDDInquiry.UDDIInquiryService inquiryService = new JUDDInquiry.UDDIInquiryService();
                inquiryService.Timeout = 2000;
                inquiryService.Url = "http://" + conexion + "/juddiv3/services/inquiry";
                JUDDInquiry.find_business bussines = new JUDDInquiry.find_business();
                bussines.findQualifiers = new string[] { "approximateMatch" };
                bussines.name = new JUDDInquiry.name[] { new JUDDInquiry.name() };
                bussines.name[0].Value = "estacion%";
                JUDDInquiry.businessList estacionesBuss = new JUDDInquiry.businessList();
            
                JUDDIPublish.UDDIPublicationService publishService = new JUDDIPublish.UDDIPublicationService();                
                publishService.Url = "http://" + conexion + "/juddiv3/services/publish";
                int numEstaciones = 0;
            
                estacionesBuss = inquiryService.find_business(bussines);
                numEstaciones = estacionesBuss.businessInfos.Length;
                if (numEstaciones == 0)
                {
                    error("No se han encontrado estaciones!");
                }
                string auth_token = securityService.get_authToken(token).authInfo;
                for (int i = 0; i < numEstaciones; ++i)
                {
                    JUDDInquiry.businessInfo info = estacionesBuss.businessInfos[i];
                    String estacionNombre = info.name[0].Value.ToString();
                    String estacionIP = info.description[0].Value.ToString();
                    if (!ips.ContainsKey(estacionIP))
                    {

                        try
                        {
                            String urlEstacion = "http://" + estacionIP + "/EstacionMaster/services/Estacion?wsdl";
                            Estacion.Estacion estacionNueva = new Estacion.Estacion();                            
                            estacionNueva.Url = urlEstacion;                            
                            estacionNueva.getHumedad();
                            String estacionText = estacionNombre + "=>" + estacionIP;
                            stationList.Items.Add(estacionText);
                            stations.Items.Add(estacionText);
                            ips[estacionIP] = estacionNombre;
                            estaciones[estacionText] = estacionNueva;
                        }
                        catch (Exception exc)
                        {
                            try
                            {
                                JUDDIPublish.delete_business delete_bussines = new JUDDIPublish.delete_business();
                                String[] keys = new string[1];
                                keys[0] = info.businessKey;
                                delete_bussines.businessKey = keys;
                                delete_bussines.authInfo = auth_token;
                                publishService.delete_business(delete_bussines);
                            }
                            catch (Exception)
                            {

                            }
                            
                        }

                    }

                }
            }
            catch(Exception exc)
            {
                error("Servidor JUDDI no existe o se encuentra inhabilitado");
            }

        }

        private void conectar_Click(object sender, EventArgs e)
        {
            
            conexion = conex.Text.ToString();
            cargarEstaciones();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            cargarEstaciones();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            String ValPropiedad = propiedad.Text;
            String res = "NOK";
            if (ValPropiedad.Length != 0 && stationList.Text != "") {
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
                    crearLog("get", ValPropiedad);
                    if (encriptado) {
                        try { 
                            resPropiedad.Text = AesBase64Wrapper.DecodeAndDecrypt(res);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    else
                    {
                        resPropiedad.Text = res;
                    }
                }
                catch (Exception ex)
                {
                    error("Esta estación se encuentra inactiva!");
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
            }
            return res;
        }
        private void establecer_Click(object sender, EventArgs e)
        {
            String valor = valorPropiedad.Text;
            String propiedadSeleccionada = propiedad.Text;
            if (propiedadSeleccionada.Length != 0 && stationList.Text != "")
            {
                if (propiedadSeleccionada.Equals("Pantalla"))
                {
                    
                    if (valor.Length != 0)
                    {
                        if (encriptado)
                        {
                            try
                            {
                                valor = AesBase64Wrapper.EncryptAndEncode(valor);
                            }
                            catch (Exception ex) {
                                
                            }
                            
                        }
                        try
                        {
                            estacionActual.setPantalla(valor, encriptado.ToString());
                            crearLog("set", propiedadSeleccionada);
                        }
                        catch (Exception exc)
                        {
                            error("Esta estación se encuentra inactiva!");
                        }
                       
                        
                    }
                    else {
                        error(error_formato_entrada);
                    }
                }
                else {

                    int valorInt = convertirToInt(valor);
                    if (encriptado)
                    {
                        try
                        {
                            valor = AesBase64Wrapper.EncryptAndEncode(valor);
                        }
                        catch (Exception ex)
                        {

                        }

                    }

                    if (valorInt != -1) {                                                            
                        try
                        {
                            switch (propiedadSeleccionada)
                            {
                                case "Temperatura":
                                    estacionActual.setTemperatura(valor, encriptado.ToString());
                                    break;
                                case "Humedad":
                                    estacionActual.setHumedad(valor, encriptado.ToString());
                                    break;
                                case "Luminosidad":
                                    estacionActual.setLuminosidad(valor, encriptado.ToString());
                                    break;
                            }
                            crearLog("set", propiedadSeleccionada);
                        }
                        catch (Exception exc)
                        {
                            error("Esta estación se encuentra inactiva!");
                        }
                    }
                    else
                    {
                        error(error_formato_entrada);
                    }
                }
            }
            else {
                error(error_propiedad_no_seleccionada);
            }
            
        }

        private void estacionSeleccionada(object sender, EventArgs e)
        {
            String stationText = stationList.SelectedItem.ToString();
            Estacion.Estacion estacion = estaciones[stationText];
            try
            {
                estacion.getPantalla();
                estacionActual = estacion;
            }
            catch(Exception exep)
            {
                error("Estacion se encuentra inhabilitada!");
                estaciones.Remove(stationText);
            }
            
        }

        private void encriptacion(object sender, EventArgs e)
        {
            if (comunicacion.CheckState == CheckState.Checked)
            {
                encriptado = true;
            }
            else {
                encriptado = false;
            }
        }
        class AesBase64Wrapper
        {
            private static string IV = "IV_VALUE_16_BYTE";
            private static string PASSWORD = "PASSWORD_VALUE";
            private static string SALT = "SALT_VALUE";

            public static string EncryptAndEncode(string raw)
            {
                using (var csp = new AesCryptoServiceProvider())
                {
                    ICryptoTransform e = GetCryptoTransform(csp, true);
                    byte[] inputBuffer = Encoding.UTF8.GetBytes(raw);
                    byte[] output = e.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
                    string encrypted = Convert.ToBase64String(output);
                    return encrypted;
                }
            }

            public static string DecodeAndDecrypt(string encrypted)
            {
                using (var csp = new AesCryptoServiceProvider())
                {
                    var d = GetCryptoTransform(csp, false);
                    byte[] output = Convert.FromBase64String(encrypted);
                    byte[] decryptedOutput = d.TransformFinalBlock(output, 0, output.Length);
                    string decypted = Encoding.UTF8.GetString(decryptedOutput);
                    return decypted;
                }
            }

            private static ICryptoTransform GetCryptoTransform(AesCryptoServiceProvider csp, bool encrypting)
            {
                csp.Mode = CipherMode.CBC;
                csp.Padding = PaddingMode.PKCS7;
                var spec = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(PASSWORD), Encoding.UTF8.GetBytes(SALT), 65536);
                byte[] key = spec.GetBytes(16);


                csp.IV = Encoding.UTF8.GetBytes(IV);
                csp.Key = key;
                if (encrypting)
                {
                    return csp.CreateEncryptor();
                }
                return csp.CreateDecryptor();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {

            String prop = propiedad.Text;
            String estac = stationList.SelectedItem.ToString();
            String errorTexto = "";
            if(estac == "")
            {
                errorTexto += "-Elige una estación!\n";
            }
            if(prop == "")
            {
                errorTexto += "-Elige propiedad de estación!\n";
            }

            try
            {
                
                int minimun = Convert.ToInt32(min.Text);
                int maximun = Convert.ToInt32(max.Text);
                if(minimun < maximun)
                {
                    String numPropiedad = "-1";
                    switch (prop)
                    {
                        case "Temperatura":
                            numPropiedad = "0";
                            break;
                        case "Humedad":
                            numPropiedad = "1";
                            break;
                        case "Luminosidad":
                            numPropiedad = "2";
                            break;     

                    }
                    Estacion.Estacion estacionSeleccionada = estaciones[estac];                    
                    try                                               
                    {
                        estacionSeleccionada.suscribirAEstacion(miIP, puertoSubs, numPropiedad, min.Text, max.Text);
                        //subs.notificarCompleted += new SubscribeService.notificarCompletedEventHandler(getNotificaton);

                        mensaje("Subscripción correcta!");
                    }
                    catch(Exception exc)
                    {
                        error("No se ha podido suscribir a la estación!");
                    }
                    
                }
                else
                {
                    errorTexto += "-Introduce rango de valores correctos de mínimo y máximo\n";
                    
                }
            }catch(Exception exc)
            {
                errorTexto += "-Introduce rango de valores correctos de mínimo y máximo\n";
            }
            if(errorTexto != "")
            {
                error(errorTexto);
            }
                        
        }

        private void Conf_Click(object sender, EventArgs e)
        {

            ConfigurationPopup popup = new ConfigurationPopup();
            popup.ShowDialog();
            if(popup.getIp() != "")
            {
                miIP = popup.getIp();
            }

            if(popup.getPuerto() != "")
            {
                puertoSubs = popup.getPuerto();
            }
            popup.Dispose();
            subs.Url = "http://localhost:" + puertoSubs + "/SubscribeMaster/services/Subscribe?wsdl";
        }
    }
}
