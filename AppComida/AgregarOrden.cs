using AppComida.ElementosPersonalizados;
using ClasesG;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
        private void boton_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (panel_pedidos.Controls.Count == 0)
                    throw new Exception("No se agregó ningún menú a esta orden.");
                string nombreCliente = (!string.IsNullOrWhiteSpace(entrada_nombre_cliente.Text) && entrada_nombre_cliente.ForeColor != colorPlaceHolder)
                    ? entrada_nombre_cliente.Text
                    : throw new Exception("No se agregó ningún nombre del cliente a esta orden");
                string numeroTelefono = (!string.IsNullOrWhiteSpace(entrada_numero.Text) && entrada_numero.ForeColor != colorPlaceHolder)
                    ? entrada_numero.Text
                    : throw new Exception("No se agregó ningún numero de telefono a esta orden");
                string docmicilio = (!string.IsNullOrWhiteSpace(entrada_direccion.Text) && entrada_direccion.ForeColor != colorPlaceHolder)
                    ? entrada_direccion.Text
                    : throw new Exception("No se agregó ningún domicilio a esta orden");
                string horaIngreso = (!string.IsNullOrWhiteSpace(entrada_hora_pedida.Text) && entrada_hora_pedida.ForeColor != colorPlaceHolder)
                    ? entrada_hora_pedida.Text
                    : throw new Exception("No se agregó ningún horario de ingreso a esta orden");
                string minutoIngreso = (!string.IsNullOrWhiteSpace(entrada_minuto_pedido.Text) && entrada_minuto_pedido.ForeColor != colorPlaceHolder)
                    ? entrada_minuto_pedido.Text
                    : throw new Exception("No se agregó ningún horario de ingreso a esta orden");
                string horaEntrega = (!string.IsNullOrWhiteSpace(entrada_hora_entrega.Text) && entrada_hora_entrega.ForeColor != colorPlaceHolder)
                    ? entrada_hora_entrega.Text
                    : throw new Exception("No se agregó ningún horario de entrega estimada a esta orden");
                string minutoEntrega = (!string.IsNullOrWhiteSpace(entrada_minuto_entrega.Text) && entrada_minuto_entrega.ForeColor != colorPlaceHolder)
                    ? entrada_minuto_entrega.Text
                    : throw new Exception("No se agregó ningún horario de entrega estimada a esta orden");
                string comentarios = entrada_comentarios.Text ?? ""; // Comentarios si puede estar vacio
                horaIngreso = horaIngreso.Length == 1
                    ? horaIngreso = "0" + horaIngreso
                    : horaIngreso;
                minutoIngreso = minutoIngreso.Length == 1
                    ? minutoIngreso = "0" + minutoIngreso
                    : minutoIngreso;
                horaEntrega = horaEntrega.Length == 1
                    ? horaEntrega = "0" + horaEntrega
                    : horaEntrega;
                minutoEntrega = minutoEntrega.Length == 1
                    ? minutoEntrega = "0" + minutoEntrega
                    : minutoEntrega;
                string horarioDeIngreso = horaIngreso + ":" + minutoIngreso;
                string horarioDeEntrega = horaEntrega + ":" + minutoEntrega;
                int productosSeleccionados = panel_pedidos.Controls.Count;
                Orden orden = new Orden
                {
                    NombreCliente = nombreCliente,
                    NumeroCliente = numeroTelefono,
                    DireccionCliente = docmicilio,
                    HoraIngresoPedido = DateTime.ParseExact(horarioDeIngreso, "HH:mm", CultureInfo.InvariantCulture),
                    HoraEstimadaEntrega = DateTime.ParseExact(horarioDeEntrega, "HH:mm", CultureInfo.InvariantCulture),
                    Comentarios = comentarios,
                    ProductosSeleccionados = productosSeleccionados,
                    Estado = "Confirmado"
                };
                List<DetallesDeLosPedidos> detallesDeLosPedidos = new List<DetallesDeLosPedidos>();
                for (int i = 0; i < panel_pedidos.Controls.Count; i++)
                {
                    Panel panel = panel_pedidos.Controls[i] as Panel;
                    string id = panel.Name.Replace("contenedor_", "");
                    LabelPerPedidos eti_id = panel.Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPID_{id}"] as LabelPerPedidos;
                    LabelPerPedidos eti_nombre = panel.Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPNombre_{id}"] as LabelPerPedidos;
                    LabelPerPedidos eti_cantidad = panel.Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPCantidad_{id}"] as LabelPerPedidos;
                    LabelPerPedidos eti_precioTotal = panel.Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPPrecioTotal_{id}"] as LabelPerPedidos;
                    int idMenu = int.Parse(eti_id.Text.Replace("#", ""));
                    string nombre = eti_nombre.Text;
                    int cantidad = int.Parse(eti_cantidad.Text.Replace("Cantidad: ", ""));
                    string precioTotal = eti_precioTotal.Text.Replace("Precio total: ", "");
                    DetallesDeLosPedidos detalles = new DetallesDeLosPedidos
                    {
                        IDMenu = idMenu,
                        NombreMenu = nombre,
                        Cantidad = cantidad,
                        Precio = precioTotal
                    };
                    detallesDeLosPedidos.Add(detalles);
                }
                D_ConOrdenes conOrdenes = new D_ConOrdenes();
                var res = conOrdenes.InsertarOrden(detallesDeLosPedidos, orden);
                if (!res.estado)
                    throw new Exception(res.mensaje);
                MessageBox.Show(res.mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void boton_pedidos_agregar_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            string id = boton.Name.Replace("BTNA_", "");
            // Aca accedemos al label de cantidad para sacar la cantidad. Como son dimnamicos no se puede acceder directamente con el name
            LabelPerPedidos etiqueta_cantidad = panel_pedidos.Controls[$"contenedor_{id}"].Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPCantidad_{id}"] as LabelPerPedidos;
            LabelPerPedidos etiqueta_precio = panel_pedidos.Controls[$"contenedor_{id}"].Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPPrecioUni_{id}"] as LabelPerPedidos;
            LabelPerPedidos etiqueta_precioTotal = panel_pedidos.Controls[$"contenedor_{id}"].Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPPrecioTotal_{id}"] as LabelPerPedidos;
            int cantidad = int.Parse(etiqueta_cantidad.Text.Replace("Cantidad: ", ""));
            int precio = int.Parse(etiqueta_precio.Text.Replace("Precio de unidad: $", ""));
            cantidad += 1;
            int total = precio * cantidad;
            etiqueta_precioTotal.Text = $"Precio total: ${total}";
            etiqueta_cantidad.Text = $"Cantidad: {cantidad.ToString()}";
            ActualizarPrecioEItems();
        }
        private void boton_pedidos_restar_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            string id = boton.Name.Replace("BTNR_", "");
            // Aca accedemos al label de cantidad para sacar la cantidad. Como son dimnamicos no se puede acceder directamente con el name
            LabelPerPedidos etiqueta_cantidad = panel_pedidos.Controls[$"contenedor_{id}"].Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPCantidad_{id}"] as LabelPerPedidos;
            LabelPerPedidos etiqueta_precio = panel_pedidos.Controls[$"contenedor_{id}"].Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPPrecioUni_{id}"] as LabelPerPedidos;
            LabelPerPedidos etiqueta_precioTotal = panel_pedidos.Controls[$"contenedor_{id}"].Controls[$"FLOWLAYOUT_{id}"].Controls[$"LPPrecioTotal_{id}"] as LabelPerPedidos;
            int cantidad = int.Parse(etiqueta_cantidad.Text.Replace("Cantidad: ", ""));
            int precio = int.Parse(etiqueta_precio.Text.Replace("Precio de unidad: $", ""));
            cantidad -= 1;
            if (cantidad == 0)
            {
                QuitarMenuDelPedido(id);
            }
            else
            {
                int total = precio * cantidad;
                etiqueta_precioTotal.Text = $"Precio total: ${total}";
                etiqueta_cantidad.Text = $"Cantidad: {cantidad.ToString()}";
            }
            ActualizarPrecioEItems();
        }
        private void boton_pedidos_quitar_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            string id = boton.Name.Replace("BTNQ_", "");
            QuitarMenuDelPedido(id);
            ActualizarPrecioEItems();
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
                string precioUnidad = etiqueta_precio.Text.Replace("Precio: $", "");
                //Aca le mando los argumentos para que se les asignen un name diferente
                LabelPerPedidos etiqueta_nueva_nombre = new LabelPerPedidos(id, "LPNombre");
                LabelPerPedidos etiqueta_nueva_precio = new LabelPerPedidos(id, "LPPrecioUni");
                LabelPerPedidos etiqueta_nueva_precioTotal = new LabelPerPedidos(id, "LPPrecioTotal");
                LabelPerPedidos etiqueta_nueva_id = new LabelPerPedidos(id, "LPID");
                LabelPerPedidos etiqueta_cantidad = new LabelPerPedidos(id, "LPCantidad");

                etiqueta_nueva_id.Text = "#" + id;
                etiqueta_nueva_nombre.Text = nombre;
                etiqueta_nueva_precio.Text = $"Precio de unidad: ${precioUnidad}";
                etiqueta_cantidad.Text = "Cantidad: 1";
                etiqueta_nueva_precioTotal.Text = $"Precio total: ${precioUnidad}";
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
                ActualizarPrecioEItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Funciones principales
        //Esto actualiza los label de precio total y productos seleccionados
        private void ActualizarPrecioEItems()
        {
            etiqueta_items.Text = $"Productos seleccionados: {panel_pedidos.Controls.Count}";
            int precioTotal = 0;
            foreach (Control panel in panel_pedidos.Controls)
            {
                if (panel is Panel)
                {
                    foreach (Control flow in panel.Controls)
                    {
                        if (flow is FlowLayoutPanel)
                        {
                            foreach (Control label in flow.Controls)
                            {
                                if (label is LabelPerPedidos && label.Name.StartsWith("LPPrecioTotal_"))
                                {
                                    precioTotal += int.Parse(label.Text.Replace("Precio total: $", ""));
                                }
                            }
                        }
                    }
                }
            }
            etiqueta_precio_final.Text = $"Precio final: ${precioTotal}";
        }
        private void QuitarMenuDelPedido(string id)
        {
            Panel panel = panel_pedidos.Controls[$"contenedor_{id}"] as Panel;
            panel.Dispose();
            ActualizarPrecioEItems();
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

        private void entrada_busqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BusquedaPorNombre();
            }
        }

        private void entrada_hora_pedida_TextChanged(object sender, EventArgs e)
        {
            if (entrada_hora_pedida.Text.Length == 2)
            {
                entrada_minuto_pedido.Select();
            }
        }

        private void entrada_minuto_pedido_TextChanged(object sender, EventArgs e)
        {
            if (entrada_minuto_pedido.Text.Length == 2)
            {
                entrada_hora_entrega.Select();
            }
        }

        private void entrada_hora_entrega_TextChanged(object sender, EventArgs e)
        {
            if (entrada_hora_entrega.Text.Length == 2)
            {
                entrada_minuto_entrega.Select();
            }
        }

        private void entrada_horario_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox texto = sender as TextBox;
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
            if (texto.ForeColor != colorPlaceHolder)
            {
                if (texto.Text.Length == 2 && (e.KeyChar != (char)Keys.Back))
                    e.Handled = true;
                else if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void entrada_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
