using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_un_grupo_musical.Clases
{
    class Global
    {
        public static List<Usuario> ListaUsuario = new List<Usuario>();
        public static Usuario UsuarioActual;
        public static string NombreGrupo;

        public static void CargarDatosGolbal()
        {
            NombreGrupo = ConfigurationManager.AppSettings["Key0"];
            CargarUsuarios();
        }

        public static void CargarUsuarios()
        {
            ListaUsuario.Add(new Usuario("root","root","1234"));
            ListaUsuario.Add(new Usuario("invitado", "invitado", "1212"));
        }

        public static bool ValidarUsuario(string usuario, string clave)
        {
            int posicion = Global.ListaUsuario.FindIndex(x=>x.Id == usuario.ToLower());
            if (posicion !=-1)
            {
                if (Global.ListaUsuario[posicion].Clave == clave)
                {
                    UsuarioActual = ListaUsuario[posicion];
                    ListaUsuario[posicion].ContadorFallos = 0;
                    return true;
                }
                else
                {
                    ListaUsuario[posicion].ContadorFallos++;
                    if (ListaUsuario[posicion].ContadorFallos>=3)
                    {
                        Application.Exit();  
                    }
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



    }
}
