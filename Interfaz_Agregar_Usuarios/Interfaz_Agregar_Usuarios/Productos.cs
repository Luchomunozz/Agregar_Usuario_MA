using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Agregar_Usuarios
{
    public class Productos
    {
        public string nombre { set; get; }
        public int precio { set; get; }
        public string descripcion { set; get; }
        public int cantidad { set; get; }
        public string img_producto { set; get; }

        public void AgregarProducto(string _nombre, int _precio, string _descripcion , int _cantidad)
        {
            nombre = _nombre;
            precio = _precio;
            descripcion = _descripcion;
            cantidad = _cantidad;     
        }

        public void AgregarImagen(string _img_producto)
        {
            img_producto = _img_producto;
        }

    }
}
