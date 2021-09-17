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
            precio.Text = "$" + Convert.ToString(producto.precio);
            descripcion.Text = producto.descripcion;
            estado.Text = Convert.ToString(producto.estado);
            imgProducto.Image = Image.FromFile(producto.img_producto);
        }
    }
}
