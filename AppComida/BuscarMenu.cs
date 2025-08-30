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
    public partial class BuscarMenu : Form
    {
        public BuscarMenu()
        {
            InitializeComponent();
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {

        }

        private void BuscarMenu_Resize(object sender, EventArgs e)
        {
            panel_arriba.Width = panel_arriba.Parent.Width;
            panel_abajo.Width = panel_abajo.Parent.Width;
        }
    }
}
