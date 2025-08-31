using ClasesG;
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
            ResetearValores();
            if (entrada_tipo.Items.Count > 0)
                entrada_tipo.SelectedIndex = 0;

        }
        public EditarMenu(int id)
        {
            InitializeComponent();
            ResetearValores();
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
                entrada_tipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ResetearValores()
        { 
            menu_seleccionado.Text = "Ninguno";
            entrada_menu.Text = "Buscá un menú arriba";
            entrada_menu.ReadOnly = true;
            entrada_menu.ForeColor = colorPlaceHolder;
            entrada_ingredientes.Text = "";
            entrada_ingredientes.ReadOnly = true;
            entrada_precio.Text = "Buscá un menú arriba";
            entrada_precio.ForeColor = colorPlaceHolder;
            entrada_precio.ReadOnly = true;
            resultados_busqueda.DataSource = null;
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
        private void boton_vaciar_Click(object sender, EventArgs e)
        {
            ResetearValores();
        }
        private void EditarMenu_Resize(object sender, EventArgs e)
        {
            panel_arriba.Width = panel_arriba.Parent.Width;
            panel_abajo.Width = panel_abajo.Parent.Width;
        }
        private void entrada_busuqeda_TextChanged(object sender, EventArgs e)
        {
            if (entrada_busuqeda.Text.StartsWith("#") && entrada_busuqeda.Text != "#7/Lomo completo")
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
            if (e.RowIndex >= 0) // evita clicks en encabezados
            {
                DataGridViewRow fila = resultados_busqueda.Rows[e.RowIndex];
                LlenarDatos(fila);
            }
        }
        private void entrada_busuqeda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (entrada_busuqeda.Text.StartsWith("#"))
                    BusquedaPorID();
                else
                    BusquedaPorNombre();
            }
        }
        #endregion
        #region Funciones principales
        private void LlenarDatos(DataGridViewRow fila)
        {
            try
            {
                menu_seleccionado.Text = fila.Cells[0].Value.ToString();
                entrada_menu.Text = fila.Cells[1].Value.ToString();
                entrada_menu.ForeColor = Color.Black;
                entrada_ingredientes.Text = fila.Cells[2].Value.ToString();
                entrada_tipo.SelectedIndex = int.Parse(fila.Cells[3].Value.ToString()) - 1;
                entrada_precio.Text = fila.Cells[4].Value.ToString();
                entrada_precio.ForeColor = Color.Black;
                entrada_menu.ReadOnly = false;
                entrada_ingredientes.ReadOnly = false;
                entrada_precio.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
                resultados_busqueda.DataSource = null;
                MessageBox.Show(ex.Message);
            }
        }
        private void BusquedaPorNombre()
        {
            try
            {
                D_ConMenu conMenu = new D_ConMenu();
                if (string.IsNullOrWhiteSpace(entrada_busuqeda.Text))
                    throw new Exception("La entrada de busqueda esta vacia");
                var res = conMenu.ObtenerMenusPorNombre(entrada_busuqeda.Text);
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
                resultados_busqueda.DataSource = null;
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void boton_confirmar_Click(object sender, EventArgs e)
        {
            ConfirmarEdicion();
        }
        private void ConfirmarEdicion()
        {
            int id = (!string.IsNullOrWhiteSpace(menu_seleccionado.Text) || menu_seleccionado.Text != "Ninguno")
                ? int.Parse(menu_seleccionado.Text)
                : throw new Exception("No hay ningun menu seleccionado");
            string nombre = (!string.IsNullOrWhiteSpace(entrada_menu.Text) || entrada_menu.Text != "Buscá un menú arriba")
                ? entrada_menu.Text
                : throw new Exception("La entrada del \"nombre\" esta vacia");
            string ingredientes = !string.IsNullOrWhiteSpace(entrada_ingredientes.Text)
                ? entrada_ingredientes.Text
                : throw new Exception("La entrada de \"ingredientes\" esta vacia");
            int tipo = !string.IsNullOrWhiteSpace(entrada_tipo.Text)
                ? entrada_tipo.SelectedIndex
                : throw new Exception("La entrada del \"tipo\" esta vacia");
            string precio = (!string.IsNullOrWhiteSpace(entrada_precio.Text) || entrada_precio.Text != "Buscá un menú arriba")
                ? entrada_precio.Text
                : throw new Exception("La entrada del \"precio\" esta vacia");
            tipo += 1;
            Menus menu = new Menus
            {
                IDMenu = id,
                NombreMenu = nombre,
                IngredientesMenu = ingredientes,
                TipoMenu = tipo,
                PrecioMenu = precio
            };
            D_ConMenu conMenu = new D_ConMenu();
            var res = conMenu.ModificarMenu(menu);
            if (!res.estado)
                throw new Exception(res.mensaje);
            ResetearValores();
            MessageBox.Show(res.mensaje);
        }
    }
}
