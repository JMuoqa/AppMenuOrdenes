using AppComida.ElementosPersonalizados;
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
        #region Eventos principales
        private void boton_buscar_Click(object sender, EventArgs e)
        {
            BusquedaPorNombre();
        }
        private void boton_pedidos_agregar_Click(object sender, EventArgs e) 
        {
            Button boton = sender as Button;
            string id = boton.Name.Replace("BTNA_", "");
            // Aca accedemos al label de cantidad para sacar la cantidad. Como son dimnamicos no se puede acceder directamente con el name
            LabelPerPedidos etiqueta_cantidad = panel_pedidos.Controls[$"contenedor_{id}"].Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPCantidad_{id}"] as LabelPerPedidos;
            int cantidad = int.Parse(etiqueta_cantidad.Text.Replace("Cantidad: ", ""));
            cantidad += 1;
            etiqueta_cantidad.Text = $"Cantidad: {cantidad.ToString()}";
        }
        private void boton_pedidos_restar_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            string id = boton.Name.Replace("BTNR_", "");
            // Aca accedemos al label de cantidad para sacar la cantidad. Como son dimnamicos no se puede acceder directamente con el name
            LabelPerPedidos etiqueta_cantidad = panel_pedidos.Controls[$"contenedor_{id}"].Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPCantidad_{id}"] as LabelPerPedidos;
            int cantidad = int.Parse(etiqueta_cantidad.Text.Replace("Cantidad: ", ""));
            cantidad -= 1;
            if (cantidad == 0)
            {
                QuitarMenuDelPedido(id);
            }
            etiqueta_cantidad.Text = $"Cantidad: {cantidad.ToString()}";
        }
        private void boton_pedidos_quitar_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            string id = boton.Name.Replace("BTNQ_", "");
            QuitarMenuDelPedido(id);
        }
        private void panel_Click(object sender, EventArgs e)
        {
            try
            {
                Panel panel = sender as Panel;
                string id = panel.Name.Replace("Panel_", "");
                if (panel_pedidos.Controls[$"contenedor_{id}"] != null)
                    throw new Exception("Ese menu ya esta agregado");
                Label etiqueta_nombre = panel.Controls[$"TN{id}"] as Label;
                Label etiqueta_precio = panel.Controls[$"TP{id}"] as Label;
                string nombre = etiqueta_nombre.Text;
                string precioUnidad = etiqueta_precio.Text;
                //Aca le mando los argumentos para que se les asignen un name diferente
                LabelPerPedidos etiqueta_nueva_nombre = new LabelPerPedidos(id, "LPNombre");
                LabelPerPedidos etiqueta_nueva_precio = new LabelPerPedidos(id, "LPPrecioUni");
                LabelPerPedidos etiqueta_nueva_precioTotal = new LabelPerPedidos(id, "LPPrecioTotal");
                LabelPerPedidos etiqueta_nueva_id = new LabelPerPedidos(id, "LPID");
                LabelPerPedidos etiqueta_cantidad = new LabelPerPedidos(id, "LPCantidad");

                etiqueta_nueva_id.Text = "#" + id;
                etiqueta_nueva_nombre.Text = nombre;
                etiqueta_nueva_precio.Text = $"Precio de unidad: {precioUnidad}";
                etiqueta_cantidad.Text = "Cantidad: 1";
                etiqueta_nueva_precioTotal.Text = $"Precio total: {precioUnidad}";
                Button btn_agregar = new Button();
                btn_agregar.BackColor = Color.Green;
                btn_agregar.Cursor = Cursors.Hand;
                btn_agregar.FlatAppearance.BorderSize = 0;
                btn_agregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
                btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
                btn_agregar.FlatStyle = FlatStyle.Flat;
                btn_agregar.Font = new Font("Montserrat", 12.25F, FontStyle.Bold);
                btn_agregar.ForeColor = Color.FromArgb(242, 225, 199);
                btn_agregar.Location = new Point(9, 25);
                btn_agregar.Margin = new Padding(3, 3, 3, 30);
                btn_agregar.Size = new Size(96, 33);
                btn_agregar.Text = "Sumar";
                btn_agregar.UseVisualStyleBackColor = false;
                btn_agregar.Click += boton_pedidos_agregar_Click;
                btn_agregar.Name = $"BTNA_{id}";
                Button btn_restar = new Button();
                btn_restar.BackColor = Color.Red;
                btn_restar.Cursor = Cursors.Hand;
                btn_restar.FlatAppearance.BorderSize = 0;
                btn_restar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
                btn_restar.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
                btn_restar.FlatStyle = FlatStyle.Flat;
                btn_restar.Font = new Font("Montserrat", 12.25F, FontStyle.Bold);
                btn_restar.ForeColor = Color.FromArgb(242, 225, 199);
                btn_restar.Location = new Point(9, 67);
                btn_restar.Margin = new Padding(3, 3, 3, 30);
                btn_restar.Size = new Size(96, 33);
                btn_restar.Text = "Restar";
                btn_restar.UseVisualStyleBackColor = false;
                btn_restar.Click += boton_pedidos_restar_Click;
                btn_restar.Name = $"BTNR_{id}";
                Button btn_quitar = new Button();
                btn_quitar.BackColor = Color.FromArgb(64, 64, 64);
                btn_quitar.Cursor = Cursors.Hand;
                btn_quitar.FlatAppearance.BorderSize = 0;
                btn_quitar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
                btn_quitar.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
                btn_quitar.FlatStyle = FlatStyle.Flat;
                btn_quitar.Font = new Font("Montserrat", 12.25F, FontStyle.Bold);
                btn_quitar.ForeColor = Color.FromArgb(242, 225, 199);
                btn_quitar.Location = new Point(9, 107);
                btn_quitar.Margin = new Padding(3, 3, 3, 30);
                btn_quitar.Size = new Size(96, 33);
                btn_quitar.Text = "Quitar";
                btn_quitar.UseVisualStyleBackColor = false;
                btn_quitar.Click += boton_pedidos_quitar_Click;
                btn_quitar.Name = $"BTNQ_{id}";
                FlowLayoutPanel pedido = new FlowLayoutPanel();
                pedido.BackColor = Color.FromArgb(242, 225, 199);
                pedido.Dock = DockStyle.Left;
                pedido.Size = new Size(476, 166);
                pedido.Controls.Add(etiqueta_nueva_id);
                pedido.Controls.Add(etiqueta_nueva_nombre);
                pedido.Controls.Add(etiqueta_nueva_precio);
                pedido.Controls.Add(etiqueta_cantidad);
                pedido.Controls.Add(etiqueta_nueva_precioTotal);
                pedido.FlowDirection = FlowDirection.TopDown;
                pedido.Name = $"FLOWLAYOUT_{id}";
                Panel opciones = new Panel();
                opciones.BackColor = Color.FromArgb(232, 215, 189);
                opciones.Dock = DockStyle.Right;
                opciones.Size = new Size(114, 166);
                opciones.Controls.Add(btn_agregar);
                opciones.Controls.Add(btn_restar);
                opciones.Controls.Add(btn_quitar);
                Panel contenedor_pedidos = new Panel();
                contenedor_pedidos.BackColor = Color.FromArgb(242, 225, 199);
                contenedor_pedidos.Controls.Add(pedido);
                contenedor_pedidos.Controls.Add(opciones);
                contenedor_pedidos.Size = new Size(590, 166);
                contenedor_pedidos.TabIndex = 0;
                contenedor_pedidos.Name = $"contenedor_{id}";
                panel_pedidos.Controls.Add(contenedor_pedidos);
                panel_contenedor_menus.Controls.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Funciones principales
        private void QuitarMenuDelPedido(string id)
        {
            Panel panel = panel_pedidos.Controls[$"contenedor_{id}"] as Panel;
            panel.Dispose();
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
                VistaGrafica(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VistaGrafica(DataTable datos)
        {
            D_Tipos obtenerDatos = new D_Tipos();
            var res = obtenerDatos.ObtenerDatos();
            if (!res.estado)
                throw new Exception(res.mensaje);
            DataTable dt = res.datos;

            panel_contenedor_menus.Controls.Clear();
            int ancho = panel_contenedor_menus.Width;
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                int sumarX = i * 286;
                int x = 54 + sumarX;
                int y = 67;
                int tipoID = int.Parse(datos.Rows[i]["TipoID"].ToString());
                string tipo = dt.Rows[tipoID - 1]["Tipo"].ToString();
                LabelPer titulo_id = new LabelPer();
                titulo_id.Size = new Size(34, 26);
                titulo_id.Text = "#" + datos.Rows[i]["ID"].ToString();
                LabelPer titulo_nombre = new LabelPer();
                titulo_nombre.Text = datos.Rows[i]["Nombre"].ToString();
                titulo_nombre.AutoEllipsis = false;
                titulo_nombre.TextAlign = ContentAlignment.TopLeft;
                titulo_nombre.Name = "TN" + datos.Rows[i]["ID"].ToString();
                RichTextBox detalles_ingredientes = new RichTextBox();
                detalles_ingredientes.BackColor = Color.FromArgb(222, 205, 179);
                detalles_ingredientes.BorderStyle = BorderStyle.None;
                detalles_ingredientes.Font = new Font("Montserrat", 14F);
                detalles_ingredientes.Text = datos.Rows[i]["Ingredientes"].ToString();
                LabelPer titulo_tipo = new LabelPer();
                titulo_tipo.Text = "Tipo: " + tipo;
                LabelPer titulo_precio = new LabelPer();
                titulo_precio.Text = "Precio: " + datos.Rows[i]["Precio"].ToString();
                titulo_precio.Name = "TP" + datos.Rows[i]["ID"].ToString();
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.TopDown;
                panel.WrapContents = false;
                panel.AutoScroll = true;
                panel.BackColor = Color.FromArgb(222, 205, 179);
                panel.Controls.Add(titulo_id);
                panel.Controls.Add(titulo_nombre);
                panel.Controls.Add(detalles_ingredientes);
                panel.Controls.Add(titulo_tipo);
                panel.Controls.Add(titulo_precio);
                panel.Padding = new Padding(5);
                panel.Size = new Size(276, 316);
                panel.Location = new Point(x, y);
                panel.Cursor = Cursors.Hand;
                panel.Name = "Panel_" + datos.Rows[i]["ID"].ToString();
                panel.Click += panel_Click;
                int anchoPanel = panel.Width - 15;
                detalles_ingredientes.Size = new Size(anchoPanel, 100);
                panel_contenedor_menus.Controls.Add(panel);
            }
        }
        #endregion

    }
}
