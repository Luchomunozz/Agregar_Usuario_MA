using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Agregar_Usuarios
{
    public partial class Registro : Form
    {
        C_usuario usuario = new C_usuario();

        public Registro()
        {
            InitializeComponent();
        }

        private void btn_registrarse_Click_1(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string correo = txt_correo.Text;
            string contrasena = txt_contrasena.Text;
            string fecnac = txt_fecnac.Text;
            string direccion = txt_direccion.Text;
            string celular = txt_celular.Text;

            int usuarioVal = usuario.registrarse(correo, contrasena, nombre, apellido, fecnac, direccion, celular);
            if (usuarioVal == 1)
            {
                Form InicioSesion = new InicioSesion();
                Hide();
                InicioSesion.Show();
            }
            else if(usuarioVal==2)
            {
                lbl_error.Text = "Este usuario ya existe";
            }
            else
            {
                lbl_error.Text = "Rellene todos los campos para continuar";
            }
        }
    }
}
