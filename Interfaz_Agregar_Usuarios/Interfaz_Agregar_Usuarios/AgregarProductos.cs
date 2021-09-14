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
        public AgregarProductos()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();

            productos.AgregarProducto(btn_nombre.Text, Convert.ToInt32(btn_precio.Text), btn_descripcion.Text, Convert.ToInt32(cantidad.Value));
        }
    }
}
