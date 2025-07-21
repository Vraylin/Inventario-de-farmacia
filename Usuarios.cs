using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_de_farmacia
{
    public  class Usuarios
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public string Rol { get; set; }
    }

    public static class Registro_Usuarios
    {
        public static List<Usuarios> Lista = new List<Usuarios>()
        {
            new Usuarios {nombre= "Gerente", contraseña = "Gerente123", Rol= "Gerente"},
            new Usuarios {nombre= "Caja", contraseña= "Caja123", Rol= "Caja"}
        };
        public static Usuarios Validar(string usuario, string contraseña)
        {
            return Lista.FirstOrDefault(u=> u.nombre == usuario && u.contraseña == contraseña);
        }
    }
}
