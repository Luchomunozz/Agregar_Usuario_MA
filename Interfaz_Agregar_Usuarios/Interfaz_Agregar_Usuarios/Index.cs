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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            this.tablaProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
            tablaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            foreach (Productos product in CGlobal.productos)
            {
                int n = tablaProductos.Rows.Add();
                tablaProductos.Rows[n].Cells[0].Value = product.nombre;
                tablaProductos.Rows[n].Cells[1].Value = product.nombreEmprendimiento;
                tablaProductos.Rows[n].Cells[2].Value = product.descripcion;
                tablaProductos.Rows[n].Cells[3].Value = product.precio;
                tablaProductos.Rows[n].Cells[4].Value = product.estado;
                tablaProductos.Rows[n].Cells[5].Value = product.cantidad;
                tablaProductos.Rows[n].Cells[7].Value = product.img_producto;
            }

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            AgregarProductos ag_productos = new AgregarProductos();
            ag_productos.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form Index = new Index();
            Hide();
            Index.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Form InicioSesion = new InicioSesion();
            Hide();
            InicioSesion.Show();
        }
    }
}
