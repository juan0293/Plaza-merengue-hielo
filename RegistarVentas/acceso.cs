using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistarVentas
{
    class acceso
    {
        public bool login(string nombre_user, string password)
        {

            var db = new beutyEntities();

            var usuario = db.login.FirstOrDefault(u => u.usuario == nombre_user && u.pass == password);

            if (usuario != null)
            {
                Global.iduser = usuario.iduser.ToString();
                Global.tipo = usuario.tipo.ToString();
                Global.nombre = usuario.nombre.ToString();
                Global.empresa = usuario.empresa.ToString();
              
            
                return true;
            }
            return false;


        }
    }
}
