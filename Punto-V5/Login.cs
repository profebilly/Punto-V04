using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Punto_V5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static String Codigo = "";

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            FormContenedor FC = new FormContenedor();
              FC.Show();
               

        }

        // al pasar el mouse por encima de la caja de texto activa el toolstrip debajo de la ventana
        private void txtUsuario_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Requiere el Nombre de Usuario";
        }
        // al pasar el mouse por encima de la caja de texto activa el toolstrip debajo de la ventana
        private void txtUsuario_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtPass_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Requiere la Contraseña de Usuario";
        }

        private void txtPass_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {

                string CMD = string.Format("SELECT * FROM Usuarios WHERE account = '{0}' AND password = '{1}'", txtUsuario.Text.Trim(), txtPass.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string pass = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtUsuario.Text.Trim() && pass == txtPass.Text.Trim())
                {
                     //este if validara si el usuario es normal o admin, debo habilitar funciones segun el usuario
                    if(Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        FormContenedor FC = new FormContenedor();
                        this.Hide();
                        FC.Show();
                 
                    }
                }
            }
            catch
            {
             
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
