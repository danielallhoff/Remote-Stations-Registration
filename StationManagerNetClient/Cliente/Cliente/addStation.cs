using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class addStation : Form
    {

        private String urlEstacion;
        
        public addStation()
        {
            InitializeComponent();
        }

        private void error(String error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void addEstacion_Click(object sender, EventArgs e)
        {
           

            String nom = nombre.Text.ToString() ;
            
            String conexion = juddip.Text.ToString();
            String puertoEstacion = this.puerto.Text.ToString();
            string hostname = Dns.GetHostName();
            String ip = this.ip.Text.ToString();
            urlEstacion = "http://localhost:" + puertoEstacion + "/EstacionMaster/services/Estacion?wsdl";
            if (nom != ""  && conexion != "" && puertoEstacion != "" && ip != "") {
                Boolean errorVar = false;
                ip += ":" + puertoEstacion;
                try { 
                                      
                    //String conexionURL = "http://" + conexion + "/EstacionMaster/services/Estacion?wsdl";
                    JUDDISecurity.UDDISecurityService securityService = new JUDDISecurity.UDDISecurityService();
                    securityService.Url = "http://" + conexion  + "/juddiv3/services/security";
                    JUDDISecurity.get_authToken token = new JUDDISecurity.get_authToken();
                    token.cred = "root";
                    token.userID = "root";

                    JUDDIPublish.UDDIPublicationService publishService = new JUDDIPublish.UDDIPublicationService();
                    publishService.Url = "http://" + conexion + "/juddiv3/services/publish";
                    JUDDIPublish.businessEntity estacion = new JUDDIPublish.businessEntity();
                    JUDDIPublish.save_business save_buss = new JUDDIPublish.save_business();

                    //Descripcion de la estacion. Guardamos el nombre de la estacion y su ip
                    estacion.name = new JUDDIPublish.name[] { new JUDDIPublish.name() };
                    estacion.name[0].Value = nom;
                    estacion.description = new JUDDIPublish.description[2];
                    estacion.description[0] = new JUDDIPublish.description();
                    estacion.description[1] = new JUDDIPublish.description();
                    //Ip y puerto                   
                    estacion.description[0].Value = ip;


                    JUDDIPublish.businessEntity[] businessEntities = new JUDDIPublish.businessEntity[1];
                    businessEntities[0] = estacion;
                    
                    save_buss.businessEntity = businessEntities;
                    string auth_token = securityService.get_authToken(token).authInfo;
                    save_buss.authInfo = auth_token;
                    publishService.save_business(save_buss);
                    error("Estacion loggeada correctamente!");
                }
                catch(Exception exc)
                {
                    error("Registro JUDDI no existe o se encuentra inhabilitado!");
                }
                    
            }
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VerEstacionLocal est = new VerEstacionLocal();
            est.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
