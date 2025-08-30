using ClasesG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionDatos;
namespace Dominio
{
    public class D_ConMenu
    {
        ConMenus conMenu = new ConMenus();
        public (bool estado, string mensaje) InsertarMenu(Menus menu)
        {
            return conMenu.InsertarMenu(menu);
        }
    }
}
