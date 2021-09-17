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

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string correo = txt_correo.Text;
            string contrasena = txt_contrasena.Text;
            string fecnac = txt_fecnac.Text;
            string direccion = txt_direccion.Text;
            string celular = txt_celular.Text;

            bool usuarioVal = usuario.registrarse(correo, contrasena, nombre, apellido, fecnac, direccion, celular);
            if (usuarioVal == true)
            {
                Index nuevaPag = new Index();
                nuevaPag.Show();
                this.Close();
            }
            else
            {
                lbl_error.Text = "Este usuario ya existe";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form InicioSesion = new InicioSesion();
            Hide();
            InicioSesion.Show();
        }

        private void btn_registrarse_Click_1(object sender, EventArgs e)
        {
            Form InicioSesion = new InicioSesion();
            Hide();
            InicioSesion.Show();
        }
    }
}
