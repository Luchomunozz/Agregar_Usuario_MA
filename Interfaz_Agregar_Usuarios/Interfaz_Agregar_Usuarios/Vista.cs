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
    public partial class Vista : Form
    {
        Productos producto;
        public Vista(Productos producto)
        {
            this.producto = producto;
            InitializeComponent();
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            nomProducto.Text = producto.nombre;
            nomEmprendimiento.Text = producto.nombreEmprendimiento;
            decimal val = Convert.ToDecimal(producto.precio);
            precio.Text = "$" + val.ToString("N2");
            descripcion.Text = producto.descripcion;
            if (Convert.ToBoolean(producto.estado) == true)
            {
                estado.Text = "Disponible";
            }
            else
            {
                estado.Text = "Agotado";
            }
            imgProducto.Image = Image.FromFile(producto.img_producto);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            AgregarProductos ag_productos = new AgregarProductos();
            ag_productos.Show();
        }
    }
}
