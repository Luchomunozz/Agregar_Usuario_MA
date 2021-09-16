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

        public AgregarProductos()
        {
            InitializeComponent();
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
            productos.AgregarProducto(btn_nombre.Text, Convert.ToInt32(btn_precio.Text), btn_descripcion.Text, Convert.ToInt32(cantidad.Value), disponible);

            CGlobal.productos.Add(productos);

            btn_nombre.Clear();
            btn_precio.Clear();
            btn_descripcion.Clear();
            cantidad.Value = 1;
        }

        private void agregar_img_Click(object sender, EventArgs e)
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
            Index inicio = new Index();
            inicio.Show();
            this.Close();
        }
    }
}
