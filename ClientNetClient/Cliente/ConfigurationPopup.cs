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
    public partial class ConfigurationPopup : Form
    {
        public ConfigurationPopup()
        {
            InitializeComponent();
        }

        private void ConfigurationPopup_Load(object sender, EventArgs e)
        {

        }

        public String getPuerto()
        {
            return this.puerto;
        }

        public String getIp()
        {
            return this.miIp;
        }

        private String puerto;
        private String miIp;
        private void Button1_Click(object sender, EventArgs e)
        {
            this.puerto = puertoSubs.Text;
            this.miIp = mip.Text;

        }
    }
}
