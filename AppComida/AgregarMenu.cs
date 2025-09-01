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
    public partial class AgregarMenu : Form
    {

        private Color colorPlaceHolder = Color.FromArgb(144, 144, 144);
        public AgregarMenu()
        {
            InitializeComponent();
            OcultarElementos();
            ObtenerTipos();
            if (entrada_tipo.Items.Count > 0)
                entrada_tipo.SelectedIndex = 0;
        }
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
        private void OcultarElementos()
        {
            etiqueta_agregar_tipo.Visible = false;
            entrada_agregar_tipo.Visible = false;
            linea_agregar_tipo.Visible = false;
            boton_cancelar_tipo.Visible = false;
            Info.Visible = false;
            Info2.Visible = false;
        }
        private void ResetearValores()
        {
            etiqueta_agregar_tipo.Visible = false;
            entrada_agregar_tipo.Visible = false;
            linea_agregar_tipo.Visible = false;
            boton_cancelar_tipo.Visible = false;
            Info.Visible = false;
            Info2.Visible = false;
            etiqueta_tipo.Visible = true;
            entrada_tipo.Visible = true;
            linea_tipo.Visible = true;
            entrada_menu.Text = "Lomo completo";
            entrada_menu.ForeColor = colorPlaceHolder;
            entrada_tipo.SelectedIndex = 0;
            entrada_agregar_tipo.Text = "Empanada/Lomopizza";
            entrada_agregar_tipo.ForeColor = colorPlaceHolder;
            entrada_precio.Text = "$12000";
            entrada_precio.ForeColor = colorPlaceHolder;
            entrada_ingredientes.Text = "";
            ObtenerTipos();
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
        private void boton_agregar_tipo_Click(object sender, EventArgs e)
        {
            try
            {
                if (etiqueta_agregar_tipo.Visible)
                {
                    AgregarTipos();
                }
                else
                {
                    etiqueta_agregar_tipo.Visible = true;
                    entrada_agregar_tipo.Visible = true;
                    linea_agregar_tipo.Visible = true;
                    boton_cancelar_tipo.Visible = true;
                    Info.Visible = true;
                    Info2.Visible = true;
                    etiqueta_tipo.Visible = false;
                    entrada_tipo.Visible = false;
                    linea_tipo.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AgregarTipos()
        {
            if (string.IsNullOrEmpty(entrada_agregar_tipo.Text) || entrada_agregar_tipo.Text == "Empanada/Lomopizza")
                throw new Exception("Llena la entrada de 'Tipo' para cargar uno nuevo");
            D_Tipos cargarTipoNuevo = new D_Tipos();
            var res = cargarTipoNuevo.InsertarTipo(entrada_agregar_tipo.Text);
            if (!res.estado)
                throw new Exception(res.mensaje);
            MessageBox.Show(res.mensaje);
            ResetearValores();
        }
        private void boton_cancelar_tipo_Click(object sender, EventArgs e)
        {
            etiqueta_agregar_tipo.Visible = false;
            entrada_agregar_tipo.Visible = false;
            linea_agregar_tipo.Visible = false;
            boton_cancelar_tipo.Visible = false;
            Info.Visible = false;
            Info2.Visible = false;
            etiqueta_tipo.Visible = true;
            entrada_tipo.Visible = true;
            linea_tipo.Visible = true;
        }
        private void entrada_precio_TextChanged(object sender, EventArgs e)
        {
            if (entrada_precio.Text.Length == 0)
            {
                entrada_precio.Text = "$";
                entrada_precio.SelectionStart = entrada_precio.Text.Length;
            }
        }
        private void entrada_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void boton_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // condicion ? true : false -> si !string.IsNullOrWhiteSpace(entrada_menu.Text) es true nombre sera igual a entrada_menu.Text
                string nombre = (!string.IsNullOrWhiteSpace(entrada_menu.Text) && entrada_menu.ForeColor != colorPlaceHolder) 
                    ? entrada_menu.Text 
                    : throw new Exception("La entrada del \"nombre\" esta vacia");
                string ingredientes = !string.IsNullOrWhiteSpace(entrada_ingredientes.Text) 
                    ? entrada_ingredientes.Text 
                    : throw new Exception("La entrada de \"ingredientes\" esta vacia");
                int tipo;
                if (entrada_tipo.Visible)
                {
                    tipo = !string.IsNullOrWhiteSpace(entrada_tipo.Text)
                        ? entrada_tipo.SelectedIndex
                        : throw new Exception("La entrada del \"tipo\" esta vacia");
                }
                else
                {
                    AgregarTipos();
                    entrada_tipo.SelectedIndex = entrada_tipo.Items.Count - 1;
                    tipo = entrada_tipo.SelectedIndex;
                }
                string precio = (!string.IsNullOrWhiteSpace(entrada_precio.Text) && entrada_precio.ForeColor != colorPlaceHolder) 
                    ? entrada_precio.Text 
                    : throw new Exception("La entrada del \"precio\" esta vacia");
                tipo += 1;
                Menus menu = new Menus
                {
                    NombreMenu = nombre,
                    IngredientesMenu = ingredientes,
                    TipoMenu = tipo,
                    PrecioMenu = precio
                };
                D_ConMenu conMenu = new D_ConMenu();
                var res = conMenu.InsertarMenu(menu);
                if (!res.estado)
                    throw new Exception(res.mensaje);
                ResetearValores();
                MessageBox.Show(res.mensaje);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
