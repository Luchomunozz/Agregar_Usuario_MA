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
            this.dataGridView7.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView7.AutoResizeRows();
            dataGridView7.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            AgregarProductos ag_productos = new AgregarProductos();
            ag_productos.Show();
        }
    }
}
