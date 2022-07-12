using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;

namespace Punto_V5
{
    public partial class FormContenedor : ForMaster
    {
        public FormContenedor()
        {
            InitializeComponent();
           
        }

        private void FormContenedor_Load(object sender, EventArgs e)
        {
            //para colocar el usuario que inicia session
            //string cmd = "SELECT * FROM Usuarios WHERE id_usuario =" + Login.Codigo;

          //  DataSet DS = Utilidades.Ejecutar(cmd);

           // lblUsuActivo.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuActivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormContenedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
