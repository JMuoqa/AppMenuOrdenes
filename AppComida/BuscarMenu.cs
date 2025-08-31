using AppComida.ElementosPersonalizados;
using ControlDeProyectos.ElementosPersonalizados;
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
    public partial class BuscarMenu : Form
    {
        Color colorPlaceHolder = Color.FromArgb(144, 144, 144);
        Color colorCeleste = Color.FromArgb(57, 146, 235);
        public BuscarMenu()
        {
            InitializeComponent();
        }
        #region Funciones de carga/visuales
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
            string[] listaDeEjemplos = ["#7/Lomo completo"];
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
                if (caja.Name == "entrada_busqueda")
                    caja.Text = "#7/Lomo completo";
            }
        }
        private void entrada_busuqeda_TextChanged(object sender, EventArgs e)
        {
            if (entrada_busqueda.Text.StartsWith("#") && entrada_busqueda.Text != "#7/Lomo completo")
            {
                entrada_busqueda.ForeColor = colorCeleste;
            }
            else
            {
                entrada_busqueda.ForeColor = Color.Black;
            }
        }
        private void BuscarMenu_Resize(object sender, EventArgs e)
        {
            panel_arriba.Width = panel_arriba.Parent.Width;
            panel_abajo.Width = panel_abajo.Parent.Width;
        }
        #endregion
        #region Eventos principales
        private void boton_buscar_Click(object sender, EventArgs e)
        {
            if (entrada_busqueda.Text.StartsWith("#"))
                BusquedaPorID();
            else
                BusquedaPorNombre();
        }
        #endregion
        #region Funciones principales
        private void BusquedaPorID()
        {
            try
            {
                D_ConMenu conMenu = new D_ConMenu();
                if (string.IsNullOrWhiteSpace(entrada_busqueda.Text) || entrada_busqueda.Text.Length == 1)
                    throw new Exception("La entrada de busqueda esta vacia");
                int ID = int.Parse(entrada_busqueda.Text.Replace("#", ""));
                var res = conMenu.ObtenerMenusPorID(ID);
                if (!res.estado)
                    throw new Exception(res.mensaje);
                DataTable dt = res.datos;
                if (dt.Rows.Count < 0)
                    throw new Exception("No se encontraron resultados para esa búsqueda");
                ActualizarColumnas(dt);
                VistaGrafica(dt);
            }
            catch (Exception ex)
            {
                entrada_busqueda.Text = "#7/Lomo completo";
                entrada_busqueda.ForeColor = colorPlaceHolder;
                resultados_busqueda.DataSource = null;
                MessageBox.Show(ex.Message);
            }
        }
        private void BusquedaPorNombre()
        {
            try
            {
                D_ConMenu conMenu = new D_ConMenu();
                if (string.IsNullOrWhiteSpace(entrada_busqueda.Text))
                    throw new Exception("La entrada de busqueda esta vacia");
                var res = conMenu.ObtenerMenusPorNombre(entrada_busqueda.Text);
                if (!res.estado)
                    throw new Exception(res.mensaje);
                DataTable dt = res.datos;
                if (dt.Rows.Count < 0)
                    throw new Exception("No se encontraron resultados para esa búsqueda");
                ActualizarColumnas(dt);
                VistaGrafica(dt);
            }
            catch (Exception ex)
            {
                entrada_busqueda.Text = "#7/Lomo completo";
                entrada_busqueda.ForeColor = colorPlaceHolder;
                resultados_busqueda.DataSource = null;
                MessageBox.Show(ex.Message);
            }
        }
        private void VistaGrafica(DataTable datos)
        {
            panel_abajo.Controls.Clear();
            int ancho = panel_abajo.Width;
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                int sumarX = i * 286;
                int x = 54 + sumarX;
                int y = 67;
                LabelPer titulo_id = new LabelPer();
                titulo_id.Size = new Size(34, 26);
                titulo_id.Text = "#"+datos.Rows[i]["ID"].ToString();
                LabelPer titulo_nombre = new LabelPer();
                titulo_nombre.Text = datos.Rows[i]["Nombre"].ToString();
                titulo_nombre.AutoEllipsis = false;
                titulo_nombre.TextAlign = ContentAlignment.TopLeft;
                RichTextBox detalles_ingredientes = new RichTextBox();
                detalles_ingredientes.BackColor = Color.FromArgb(222, 205, 179);
                detalles_ingredientes.BorderStyle = BorderStyle.None;
                detalles_ingredientes.Font = new Font("Montserrat", 14F);
                detalles_ingredientes.Text = datos.Rows[i]["Ingredientes"].ToString();
                LabelPer titulo_tipo = new LabelPer();
                titulo_tipo.Text = "Tipo: " + datos.Rows[i]["TipoID"].ToString();
                LabelPer titulo_precio = new LabelPer();
                titulo_precio.Text = "Precio: " + datos.Rows[i]["Precio"].ToString();
                Button boton_editar = new Button();
                boton_editar.BackColor = Color.FromArgb(150, 100, 50);
                boton_editar.Cursor = Cursors.Hand;
                boton_editar.FlatAppearance.BorderSize = 0;
                boton_editar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
                boton_editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
                boton_editar.FlatStyle = FlatStyle.Flat;
                boton_editar.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                boton_editar.ForeColor = Color.FromArgb(242, 225, 199);
                boton_editar.Margin = new Padding(3, 3, 3, 30);
                boton_editar.Text = "Editar";
                boton_editar.UseVisualStyleBackColor = false;
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.TopDown;
                panel.Anchor = AnchorStyles.Top; 
                panel.WrapContents = false;
                panel.AutoScroll = true;
                panel.BackColor = Color.FromArgb(222, 205, 179);
                panel.Controls.Add(titulo_id);
                panel.Controls.Add(titulo_nombre);
                panel.Controls.Add(detalles_ingredientes);
                panel.Controls.Add(titulo_tipo);
                panel.Controls.Add(titulo_precio);
                panel.Controls.Add(boton_editar);
                panel.Padding = new Padding(5);
                panel.Size = new Size(276, 316);
                panel.Location = new Point(x, y);
                int anchoPanel = panel.Width - 15;
                boton_editar.Size = new Size(anchoPanel, 40);
                detalles_ingredientes.Size = new Size(anchoPanel, 100);
                panel_abajo.Controls.Add(panel);
            }
        }
        #endregion
    }
}
