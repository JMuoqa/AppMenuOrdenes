using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComida
{
    public partial class AgregarOrden : Form
    {
        Color colorPlaceHolder = Color.FromArgb(144, 144, 144);
        public AgregarOrden()
        {
            InitializeComponent();
        }

        #region Funciones visuales
        private void AgregarOrden_Resize(object sender, EventArgs e)
        {
            panel_principal.Width = panel_principal.Parent.Width;
        }
        #endregion
        #region Eventos visuales
        private void TodasLasEntradasNormales_Enter(object sender, EventArgs e)
        {
            var caja = sender as TextBox;
            string[] listaDeEjemplos = ["Jesus", "Lomo completo", "3518182222", "Local/Lagunilla 1111", "20", "21", "30", "15"];
            for (int i = 0; i < listaDeEjemplos.Length; i++)
            {
                if (caja.ForeColor == colorPlaceHolder && caja.Text == listaDeEjemplos[i])
                {
                    caja.Text = "";
                    caja.ForeColor = Color.Black;
                }
            }
        }
        private void TodasLasEntradasNormales_Leave(object sender, EventArgs e)
        {
            TextBox caja = sender as TextBox;
            if (caja.ForeColor == Color.Black && (string.IsNullOrEmpty(caja.Text) || caja.Text == "$"))
            {
                caja.ForeColor = colorPlaceHolder;
                if (caja.Name == "entrada_nombre_cliente")
                    caja.Text = "Jesus";
                else if (caja.Name == "entrada_numero")
                    caja.Text = "3518182222";
                else if (caja.Name == "entrada_direccion")
                    caja.Text = "Local/Lagunilla 1111";
                else if (caja.Name == "entrada_hora_pedida")
                    caja.Text = "20";
                else if (caja.Name == "entrada_minuto_pedido")
                    caja.Text = "30";
                else if (caja.Name == "entrada_hora_entrega")
                    caja.Text = "21";
                else if (caja.Name == "entrada_minuto_entrega")
                    caja.Text = "15";
                else if (caja.Name == "entrada_busqueda")
                    caja.Text = "Lomo completo";
            }
        }
        #endregion
    }
}
