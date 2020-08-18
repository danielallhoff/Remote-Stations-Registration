using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cliente
{
    public partial class Login : Form
    {
        private const String error_login_incorrecto = "Usuario o contraseñas incorrectos!";
        private const String error_fichero_usuarios = "Fichero usuarios no accesible!";
        public Login()
        {
            InitializeComponent();
        }
        private void error(String error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private static String Hash(string input)
        {
            SHA1Managed sha1 = new SHA1Managed();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();

        }
        private void login() {
            if (user.Text.Length == 0 || password.Text.Length == 0)
            {
                error(error_login_incorrecto);
            }
            else {
                bool verificado = false;
                String usuario = user.Text;
                String pass = Hash(password.Text);                
                string[] text;
                String path = "usuarios.txt";
                try
                {

                    text = System.IO.File.ReadAllLines(path);
                    foreach (string line in text)
                    {
                        try
                        {
                            String[] split = line.Split(' ');
                            if (usuario.Equals(split[0]) && pass.Equals(split[1]))
                            {                                
                                verificado = true;
                                Estaciones est = new Estaciones(usuario);
                                est.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                error(error_login_incorrecto);
                            }
                        }
                        catch (Exception e)
                        {
                            error(e.Message);
                            error(error_login_incorrecto);
                        }
                    }
                }
                catch (Exception exc) {
                    error(error_fichero_usuarios);
                }
                
            }
            
            
        }

        private void login_button(object sender, EventArgs e)
        {
            login();
        }

        private void login_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                login();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
