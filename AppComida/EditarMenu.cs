using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeProyectos
{
    public partial class EditarMenu : Form
    {
        Color colorPlaceHolder = Color.FromArgb(144, 144, 144);
        public EditarMenu()
        {
            InitializeComponent();
        }
        private void TodasLasEntradasNormales_Enter(object sender, EventArgs e)
        {
            var caja = sender as TextBox;
            string[] listaDeEjemplos = ["$12000", "Lomo completo", "Empanada/Lomopizza"];
            for (int i = 0; i < listaDeEjemplos.Length; i++)
            {
                if (caja.ForeColor == colorPlaceHolder && caja.Text == listaDeEjemplos[i])
                {
                    caja.Text = "";
                    caja.ForeColor = Color.Black;
                    if (caja.Name == "entrada_agregar_tipo")
                        caja.Text = "";
                    else if (caja.Name == "entrada_precio")
                        caja.Text = "$";
                    else if (caja.Name == "entrada_menu")
                        caja.Text = "";
                }
            }
        }
        private void TodasLasEntradasNormales_Leave(object sender, EventArgs e)
        {
            TextBox caja = sender as TextBox;
            if (caja.ForeColor == Color.Black && (string.IsNullOrEmpty(caja.Text) || caja.Text == "$"))
            {
                caja.ForeColor = colorPlaceHolder;
                if (caja.Name == "entrada_precio")
                    caja.Text = "$12000";
                if (caja.Name == "entrada_menu")
                    caja.Text = "Lomo completo";
                else if (caja.Name == "entrada_agregar_tipo")
                    caja.Text = "Empanada/Lomopizza";
            }
        }

        private void EditarMenu_Resize(object sender, EventArgs e)
        {
            panel_arriba.Width = panel_arriba.Parent.Width;
            panel_abajo.Width = panel_abajo.Parent.Width;
        }
    }
}
