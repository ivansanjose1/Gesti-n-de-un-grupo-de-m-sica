using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_un_grupo_musical.Clases
{
    class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int ContadorFallos { get; set; }

        public Usuario(string _id, string _nombre, string _clave)
        {
            Id = _id;
            this.Nombre = _nombre;
            Clave = _clave;
            ContadorFallos =0;
        }



    }
}
