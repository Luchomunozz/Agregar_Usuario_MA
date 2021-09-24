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
    public partial class AgregarProductos : Form
    {
        Productos productos = new Productos();
        string Correo;

        public AgregarProductos(string correo)
        {
            InitializeComponent();
            Correo = correo;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            bool disponible;
            if (p_disponible.Checked)
            {
                disponible = true;
            }
            else
            {
                disponible = false;
            }

            if (btn_nombreEmpr.Text == "" || btn_nombre.Text == "" || btn_precio.Text == "" || btn_descripcion.Text == "" || cantidad.Value == 0)
            {
                t_mensaje.Text = "Campos o datos incorrectos";
            }
            else
            {
                productos.AgregarProducto(btn_nombreEmpr.Text, btn_nombre.Text, Convert.ToDecimal(btn_precio.Text), btn_descripcion.Text, Convert.ToInt32(cantidad.Value), disponible);

                CGlobal.productos.Add(productos);
                t_mensaje.Text = "Producto registado exitosamente";
            }
       
            btn_nombreEmpr.Clear();
            btn_nombre.Clear();
            btn_precio.Clear();
            btn_descripcion.Clear();
            cantidad.Value = 1;

            Form Index = new Index(Correo);
            Hide();
            Index.Show();
        }

        private void AgImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (abrir_imagen.ShowDialog() == DialogResult.OK)
                {
                    string imagen = abrir_imagen.FileName;
                    img_producto.BackgroundImage = Image.FromFile(imagen);
                    productos.AgregarImagen(imagen);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            foreach (Productos i in CGlobal.productos) {
                MessageBox.Show(i + " " );
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Show();
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form AgregarProductos = new AgregarProductos(Correo);
            Hide();
            AgregarProductos.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form InicioSesion = new InicioSesion();
            Hide();
            InicioSesion.Show();
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            button1.Text = Correo;
        }
    }
}
