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
    public partial class InicioSesion : Form
    {
        C_usuario nuevoUsuario = new C_usuario();

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = txt_correo.Text;
            string contrasena = txt_contrasena.Text;
            bool ingresoVal = nuevoUsuario.iniciarSesion(correo, contrasena);
            if( ingresoVal == true){
                string nombreUsuario= nuevoUsuario.extraerInfoUsuario(correo, contrasena);
                Index nuevaPag = new Index(nombreUsuario);
                nuevaPag.Show();
            }
            else
            {
                lbl_error.Text = "Error, correo o contraseña invalidos";
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Registro = new Registro();
            Hide();
            Registro.Show();
        }
    }
}
