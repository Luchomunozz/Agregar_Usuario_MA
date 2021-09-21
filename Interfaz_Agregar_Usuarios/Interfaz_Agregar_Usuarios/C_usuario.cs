using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Agregar_Usuarios
{
    public class C_usuario
    {
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string correo { set; get; }
        public string contrasena { set; get; }
        public string fecnac { set; get; } 
        public string direccion { set; get; }
        public string celular { set; get; }


        public bool iniciarSesion(string correo, string contrasena)
        {
            bool verificacion = false;
            int posCorreo = CGlobal.usuarios.FindIndex(x => x.correo == correo);
            if (posCorreo != -1)
            {
                if (CGlobal.usuarios[posCorreo].contrasena == contrasena )
                {
                    verificacion = true;
                }
                else
                {
                    verificacion = false;
                }
            }
            return verificacion;
        }

        public int registrarse(string correo, string contrasena, string nombre, string apellido, string fecnac, string direccion, string celular)
        {
            int existe = 0;

            if (correo == "" || contrasena == "" || nombre == "" || apellido == "" || fecnac == "" || direccion == "" || celular == "")
            {
                existe = 0;
                return existe;
            }

            int pos = CGlobal.usuarios.FindIndex(x => x.correo == correo);
            if (pos == -1)
            {
                CGlobal.usuarios.Add(new C_usuario { nombre = nombre, apellido = apellido, correo =correo , fecnac = fecnac, direccion = direccion, celular = celular, contrasena= contrasena});
                existe = 1;
            }
            else
            {
                existe = 2;
            }

            return existe;
        }
    }
}
