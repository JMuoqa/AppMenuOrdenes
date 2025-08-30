using Dominio;
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
        Color colorCeleste = Color.FromArgb(57, 146, 235);
        public EditarMenu()
        {
            InitializeComponent();
            ObtenerTipos();
            if (entrada_tipo.Items.Count > 0)
                entrada_tipo.SelectedIndex = 0;
        }

        #region Funciones de cargas/visuales
        private void ObtenerTipos()
        {
            try
            {
                entrada_tipo.Items.Clear();
                D_Tipos obtenerDatos = new D_Tipos();
                var res = obtenerDatos.ObtenerDatos();
                if (!res.estado)
                    throw new Exception(res.mensaje);
                DataTable dt = res.datos;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    entrada_tipo.Items.Add(dt.Rows[i]["Tipo"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ResetearValores()
        {
            ObtenerTipos();
        }
        private void ActualizarColumnas(DataTable dt)
        {
            resultados_busqueda.DataSource = null;
            resultados_busqueda.DataSource = dt;
            resultados_busqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            for (int i = 0; i < resultados_busqueda.Columns.Count; i++) 
            {
                resultados_busqueda.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        #endregion
        #region Eventos visuales
        private void TodasLasEntradasNormales_Enter(object sender, EventArgs e)
        {
            var caja = sender as TextBox;
            string[] listaDeEjemplos = ["$12000", "Lomo completo", "Empanada/Lomopizza", "#7/Lomo completo"];
            for (int i = 0; i < listaDeEjemplos.Length; i++)
            {
                if (caja.ForeColor == colorPlaceHolder && caja.Text == listaDeEjemplos[i])
                {
                    caja.Text = "";
                    caja.ForeColor = Color.Black;
                    if (caja.Name == "entrada_precio")
                        caja.Text = "$";
                    else
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
                else if (caja.Name == "entrada_menu")
                    caja.Text = "Lomo completo";
                else if (caja.Name == "entrada_agregar_tipo")
                    caja.Text = "Empanada/Lomopizza";
                else if (caja.Text == "entrada_busqueda")
                    caja.Text = "#7/Lomo completo";
            }
        }
        private void EditarMenu_Resize(object sender, EventArgs e)
        {
            panel_arriba.Width = panel_arriba.Parent.Width;
            panel_abajo.Width = panel_abajo.Parent.Width;
        }
        private void entrada_busuqeda_TextChanged(object sender, EventArgs e)
        {
            if (entrada_busuqeda.Text.StartsWith("#"))
            {
                entrada_busuqeda.ForeColor = colorCeleste;
            }
            else
            {
                entrada_busuqeda.ForeColor = Color.Black;
            }
        }
        #endregion
        #region Eventos principales
        private void boton_buscar_Click(object sender, EventArgs e)
        {
            if (entrada_busuqeda.Text.StartsWith("#"))
                BusquedaPorID();
            else
                BusquedaPorNombre();
        }
        private void resultados_busqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) // evita clicks en encabezados
            {
                DataGridViewRow fila = resultados_busqueda.Rows[e.RowIndex];
                // Ejemplo: mostrar valor de la primera columna
                var valorID = fila.Cells[0].Value;
                MessageBox.Show("Fila clickeada: " + e.RowIndex + "\nID: " + valorID);
            }
        }
        #endregion
        #region Funciones principales
        private void BusquedaPorID()
        {
            try
            {
                D_ConMenu conMenu = new D_ConMenu();
                if (string.IsNullOrWhiteSpace(entrada_busuqeda.Text) || entrada_busuqeda.Text.Length == 1)
                    throw new Exception("La entrada de busqueda esta vacia");
                int ID = int.Parse(entrada_busuqeda.Text.Replace("#", ""));
                var res = conMenu.ObtenerMenusPorID(ID);
                if (!res.estado)
                    throw new Exception(res.mensaje);
                DataTable dt = res.datos;
                if (dt.Rows.Count < 0)
                    throw new Exception("No se encontraron resultados para esa búsqueda");
                ActualizarColumnas(dt);

            }
            catch (Exception ex)
            {
                entrada_busuqeda.Text = "#7/Lomo completo";
                entrada_busuqeda.ForeColor = colorPlaceHolder;
                MessageBox.Show(ex.Message);
            }
        }
        private void BusquedaPorNombre()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
