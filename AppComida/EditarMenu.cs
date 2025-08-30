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
        public EditarMenu()
        {
            InitializeComponent();
        }
        private void TodasLasEntradasNormales_Enter(object sender, EventArgs e)
        {
            var caja = sender as TextBox;
            string[] listaDeEjemplos = ["$400.000", "$200.000", "Gaston", "Dia \"D\"", "24-08-2025", "24-09-2025", "7"];
            for (int i = 0; i < listaDeEjemplos.Length; i++)
            {
                if (caja.ForeColor == Color.FromArgb(144, 144, 144) && caja.Text == listaDeEjemplos[i])
                {
                    caja.Text = "";
                    caja.ForeColor = Color.Black;
                    if (caja.Name == "entrada_precio")
                        caja.Text = "$";
                    else if (caja.Name == "entrada_pago")
                        caja.Text = "$";
                }
            }
        }
        private void TodasLasEntradasNormales_Leave(object sender, EventArgs e)
        {
            TextBox caja = sender as TextBox;
            if (caja.ForeColor == Color.Black && (string.IsNullOrEmpty(caja.Text) || caja.Text == "$"))
            {
                caja.ForeColor = Color.FromArgb(144, 144, 144);
                if (caja.Name == "entrada_precio")
                    caja.Text = "$400.000";
                else if (caja.Name == "entrada_pago")
                    caja.Text = "$200.000";
                else if (caja.Name == "entrada_cliente")
                    caja.Text = "Gaston";
                else if (caja.Name == "entrada_proyecto")
                    caja.Text = "Dia \"D\"";
                else if (caja.Name == "entrada_inicio")
                    caja.Text = "24-08-2025";
                else if (caja.Name == "entrada_entrega")
                    caja.Text = "24-09-2025";
                else if (caja.Name == "entrada_id")
                    caja.Text = "7";
            }
        }

        private void EditarMenu_Resize(object sender, EventArgs e)
        {
            panel_arriba.Width = panel_arriba.Parent.Width;
            panel_abajo.Width = panel_abajo.Parent.Width;
        }
    }
}
