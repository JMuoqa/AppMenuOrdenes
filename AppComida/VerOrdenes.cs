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

namespace AppComida
{
    public partial class VerOrdenes : Form
    {
        public VerOrdenes()
        {
            InitializeComponent();
            entrada_ver_por_estados.SelectedIndex = 0;
        }
        #region Funciones de carga/visuales
        private void CrearTrajetas(DataTable dt)
        {
            try
            {
                contenedor_principal_ordenes.Controls.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)//Aca creamos las tarjetas de las ordenes seleccionadas por su estado
                {
                    int pos_x = (i * 518) + 8;
                    Label etiqueta_titulo_tarjeta = new Label();
                    etiqueta_titulo_tarjeta.Anchor = AnchorStyles.Top;
                    etiqueta_titulo_tarjeta.AutoSize = true;
                    etiqueta_titulo_tarjeta.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
                    etiqueta_titulo_tarjeta.ForeColor = Color.Black;
                    etiqueta_titulo_tarjeta.Location = new Point(111, 5);
                    etiqueta_titulo_tarjeta.Size = new Size(284, 27);
                    etiqueta_titulo_tarjeta.TabIndex = 2;
                    etiqueta_titulo_tarjeta.Text = $"#{dt.Rows[i]["IDOrden"]} - {dt.Rows[i]["NombreDelCliente"]}";
                    etiqueta_titulo_tarjeta.TextAlign = ContentAlignment.MiddleLeft;
                    Label etiqueta_domicilio = new Label();
                    etiqueta_domicilio.AutoSize = true;
                    etiqueta_domicilio.Font = new Font("Montserrat", 12F);
                    etiqueta_domicilio.ForeColor = Color.Black;
                    etiqueta_domicilio.Location = new Point(3, 5);
                    etiqueta_domicilio.Margin = new Padding(3, 5, 3, 5);
                    etiqueta_domicilio.Size = new Size(223, 22);
                    etiqueta_domicilio.TabIndex = 4;
                    etiqueta_domicilio.Text = $"Domicilio: {dt.Rows[i]["DireccionDelCliente"]}";
                    etiqueta_domicilio.TextAlign = ContentAlignment.MiddleLeft;
                    Label etiqueta_tel = new Label();
                    etiqueta_tel.AutoSize = true;
                    etiqueta_tel.Font = new Font("Montserrat", 12F);
                    etiqueta_tel.ForeColor = Color.Black;
                    etiqueta_tel.Location = new Point(3, 37);
                    etiqueta_tel.Margin = new Padding(3, 5, 3, 5);
                    etiqueta_tel.Size = new Size(179, 22);
                    etiqueta_tel.TabIndex = 5;
                    etiqueta_tel.Text = $"Telefono: {dt.Rows[i]["TelefonoDelCliente"]}";
                    etiqueta_tel.TextAlign = ContentAlignment.MiddleLeft;
                    Label etiquera_precio = new Label();
                    etiquera_precio.AutoSize = true;
                    etiquera_precio.Font = new Font("Montserrat", 12F);
                    etiquera_precio.ForeColor = Color.Black;
                    etiquera_precio.Location = new Point(3, 5);
                    etiquera_precio.Margin = new Padding(3, 5, 3, 5);
                    etiquera_precio.Size = new Size(128, 22);
                    etiquera_precio.TabIndex = 7;
                    etiquera_precio.Text = $"Precio: {dt.Rows[i]["PrecioTotal"]}";
                    etiquera_precio.TextAlign = ContentAlignment.MiddleLeft;
                    Label etiqueta_pago = new Label();
                    etiqueta_pago.AutoSize = true;
                    etiqueta_pago.Font = new Font("Montserrat", 12F);
                    etiqueta_pago.ForeColor = Color.Black;
                    etiqueta_pago.Location = new Point(137, 5);
                    etiqueta_pago.Margin = new Padding(3, 5, 3, 5);
                    etiqueta_pago.Size = new Size(80, 22);
                    etiqueta_pago.TabIndex = 8;
                    etiqueta_pago.Text = dt.Rows[i]["Pago"].ToString();
                    etiqueta_pago.TextAlign = ContentAlignment.MiddleLeft;
                    FlowLayoutPanel panel_precio_pago = new FlowLayoutPanel();
                    panel_precio_pago.Controls.Add(etiquera_precio);
                    panel_precio_pago.Controls.Add(etiqueta_pago);
                    panel_precio_pago.Location = new Point(3, 67);
                    panel_precio_pago.Size = new Size(487, 35);
                    panel_precio_pago.TabIndex = 6;
                    RichTextBox caja_comentarios = new RichTextBox();
                    caja_comentarios.BackColor = Color.FromArgb(222, 205, 179);
                    caja_comentarios.BorderStyle = BorderStyle.None;
                    caja_comentarios.Font = new Font("Montserrat", 15F);
                    caja_comentarios.Location = new Point(3, 108);
                    caja_comentarios.ReadOnly = true;
                    caja_comentarios.Size = new Size(485, 132);
                    caja_comentarios.TabIndex = 9;
                    caja_comentarios.Text = dt.Rows[i]["Comentarios"].ToString();
                    Label etiqueta_hora_ingreso = new Label();
                    etiqueta_hora_ingreso.AutoSize = true;
                    etiqueta_hora_ingreso.Font = new Font("Montserrat", 12F);
                    etiqueta_hora_ingreso.ForeColor = Color.Black;
                    etiqueta_hora_ingreso.Location = new Point(3, 5);
                    etiqueta_hora_ingreso.Margin = new Padding(3, 5, 3, 5);
                    etiqueta_hora_ingreso.Size = new Size(211, 22);
                    etiqueta_hora_ingreso.TabIndex = 11;
                    string[] hora_MS_Ingreso = dt.Rows[i]["HoraIngresoPedido"].ToString().Split(":"); // Divide la hora, los minutos y los segundos
                    string horaMinutos_Ingreso = hora_MS_Ingreso[0] + ":" + hora_MS_Ingreso[1];
                    etiqueta_hora_ingreso.Text = $"Hora de pedido:  {horaMinutos_Ingreso}";
                    etiqueta_hora_ingreso.TextAlign = ContentAlignment.MiddleLeft;
                    Label etiqueta_hora_entrega = new Label();
                    etiqueta_hora_entrega.AutoSize = true;
                    etiqueta_hora_entrega.Font = new Font("Montserrat", 12F);
                    etiqueta_hora_entrega.ForeColor = Color.Black;
                    etiqueta_hora_entrega.Location = new Point(220, 5);
                    etiqueta_hora_entrega.Margin = new Padding(3, 5, 3, 5);
                    etiqueta_hora_entrega.Size = new Size(218, 22);
                    etiqueta_hora_entrega.TabIndex = 12;
                    string[] hora_MS_Pedido = dt.Rows[i]["HoraEstimadaEntrega"].ToString().Split(":"); // Divide la hora, los minutos y los segundos
                    string horaMinutos_Pedido= hora_MS_Pedido[0] + ":" + hora_MS_Pedido[1];
                    etiqueta_hora_entrega.Text = $"Hora de pedido:  {horaMinutos_Pedido}";
                    etiqueta_hora_entrega.TextAlign = ContentAlignment.MiddleLeft;
                    FlowLayoutPanel contenedor_horarios = new FlowLayoutPanel();
                    contenedor_horarios.Controls.Add(etiqueta_hora_ingreso);
                    contenedor_horarios.Controls.Add(etiqueta_hora_entrega);
                    contenedor_horarios.Location = new Point(3, 246);
                    contenedor_horarios.Size = new Size(487, 35);
                    contenedor_horarios.TabIndex = 13;
                    Button boton_anterior_estado = new Button();
                    boton_anterior_estado.BackColor = Color.FromArgb(150, 100, 50);
                    boton_anterior_estado.Cursor = Cursors.Hand;
                    boton_anterior_estado.FlatAppearance.BorderSize = 0;
                    boton_anterior_estado.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
                    boton_anterior_estado.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
                    boton_anterior_estado.FlatStyle = FlatStyle.Flat;
                    boton_anterior_estado.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    boton_anterior_estado.ForeColor = Color.FromArgb(242, 225, 199);
                    boton_anterior_estado.Location = new Point(3, 3);
                    boton_anterior_estado.Margin = new Padding(3, 3, 3, 30);
                    boton_anterior_estado.Size = new Size(138, 35);
                    boton_anterior_estado.TabIndex = 14;
                    boton_anterior_estado.Text = "Anterior";
                    boton_anterior_estado.UseVisualStyleBackColor = false;
                    ComboBox caja_estado = new ComboBox();
                    caja_estado.Anchor = AnchorStyles.Top;
                    caja_estado.BackColor = Color.FromArgb(212, 195, 169);
                    caja_estado.DropDownStyle = ComboBoxStyle.DropDownList;
                    caja_estado.FlatStyle = FlatStyle.Flat;
                    caja_estado.Font = new Font("Montserrat", 15F);
                    caja_estado.ForeColor = Color.Black;
                    caja_estado.FormattingEnabled = true;
                    caja_estado.Items.AddRange(new object[] { "Pendiente", "Confirmada", "En preparación", "Lista", "Entregada" });
                    string[] estados = ["Pendiente", "Confirmada", "En preparación", "Lista", "Entregada"];
                    for (int j = 0; j < estados.Length; j++)
                    {
                        if (estados[j] == dt.Rows[i]["Estado"].ToString())
                        {
                            caja_estado.SelectedIndex = j;
                        }
                    }
                    caja_estado.Location = new Point(147, 3);
                    caja_estado.Size = new Size(183, 35);
                    caja_estado.TabIndex = 15;
                    Button boton_siguiente_estado = new Button();
                    boton_siguiente_estado.BackColor = Color.FromArgb(150, 100, 50);
                    boton_siguiente_estado.Cursor = Cursors.Hand;
                    boton_siguiente_estado.FlatAppearance.BorderSize = 0;
                    boton_siguiente_estado.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
                    boton_siguiente_estado.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
                    boton_siguiente_estado.FlatStyle = FlatStyle.Flat;
                    boton_siguiente_estado.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    boton_siguiente_estado.ForeColor = Color.FromArgb(242, 225, 199);
                    boton_siguiente_estado.Location = new Point(336, 3);
                    boton_siguiente_estado.Margin = new Padding(3, 3, 3, 30);
                    boton_siguiente_estado.Size = new Size(138, 35);
                    boton_siguiente_estado.TabIndex = 16;
                    boton_siguiente_estado.Text = "Siguiente";
                    boton_siguiente_estado.UseVisualStyleBackColor = false;
                    FlowLayoutPanel contenedor_estado = new FlowLayoutPanel();
                    contenedor_estado.Controls.Add(boton_anterior_estado);
                    contenedor_estado.Controls.Add(caja_estado);
                    contenedor_estado.Controls.Add(boton_siguiente_estado);
                    contenedor_estado.Location = new Point(3, 287);
                    contenedor_estado.Name = "flowLayoutPanel8";
                    contenedor_estado.Size = new Size(487, 46);
                    contenedor_estado.TabIndex = 17;
                    FlowLayoutPanel contenedor_superior = new FlowLayoutPanel();
                    contenedor_superior.Controls.Add(etiqueta_domicilio);
                    contenedor_superior.Controls.Add(etiqueta_tel);
                    contenedor_superior.Controls.Add(panel_precio_pago);
                    contenedor_superior.Controls.Add(caja_comentarios);
                    contenedor_superior.Controls.Add(contenedor_horarios);
                    contenedor_superior.Controls.Add(contenedor_estado);
                    contenedor_superior.FlowDirection = FlowDirection.TopDown;
                    contenedor_superior.Location = new Point(8, 35);
                    contenedor_superior.Size = new Size(490, 362);
                    contenedor_superior.TabIndex = 3;
                    D_ConOrdenes conOrdenes = new D_ConOrdenes();
                    FlowLayoutPanel contenedor_inferior = new FlowLayoutPanel();
                    contenedor_inferior.Dock = DockStyle.Bottom;
                    contenedor_inferior.Location = new Point(8, 403);
                    contenedor_inferior.Name = "flowLayoutPanel3";
                    contenedor_inferior.Size = new Size(490, 200);
                    contenedor_inferior.TabIndex = 18;
                    int id = int.Parse(dt.Rows[i]["IDOrden"].ToString());
                    var res = conOrdenes.ObtenerDetalles(id);
                    if (!res.estado)
                        throw new Exception(res.mensaje);
                    DataTable datosDeLosDetalles = res.datos;
                    for(int j = 0; j < datosDeLosDetalles.Rows.Count; j++)
                    {
                        int pos_y = (j * 89) + 5;
                        Label etiqueta_nombre_pedido = new Label();
                        etiqueta_nombre_pedido.AutoSize = true;
                        etiqueta_nombre_pedido.Font = new Font("Montserrat", 12F);
                        etiqueta_nombre_pedido.ForeColor = Color.Black;
                        etiqueta_nombre_pedido.Location = new Point(3, 0);
                        etiqueta_nombre_pedido.Size = new Size(137, 22);
                        etiqueta_nombre_pedido.Text = datosDeLosDetalles.Rows[j]["NombreMenu"].ToString();
                        etiqueta_nombre_pedido.TextAlign = ContentAlignment.MiddleLeft;
                        Label etiqueta_cantidad_del_pedido = new Label();
                        etiqueta_cantidad_del_pedido.AutoSize = true;
                        etiqueta_cantidad_del_pedido.Font = new Font("Montserrat", 12F);
                        etiqueta_cantidad_del_pedido.ForeColor = Color.Black;
                        etiqueta_cantidad_del_pedido.Location = new Point(3, 27);
                        etiqueta_cantidad_del_pedido.Margin = new Padding(3, 5, 3, 5);
                        etiqueta_cantidad_del_pedido.Size = new Size(99, 22);
                        etiqueta_cantidad_del_pedido.Text = $"Cantidad: {datosDeLosDetalles.Rows[j]["Cantidad"]}";
                        etiqueta_cantidad_del_pedido.TextAlign = ContentAlignment.MiddleLeft;
                        Label etiqueta_precio_unitario = new Label();
                        etiqueta_precio_unitario.AutoSize = true;
                        etiqueta_precio_unitario.Font = new Font("Montserrat", 12F);
                        etiqueta_precio_unitario.ForeColor = Color.Black;
                        etiqueta_precio_unitario.Location = new Point(3, 59);
                        etiqueta_precio_unitario.Margin = new Padding(3, 5, 3, 5);
                        etiqueta_precio_unitario.Size = new Size(126, 22);
                        etiqueta_precio_unitario.Text = $"Precio: {datosDeLosDetalles.Rows[j]["Precio"]}";
                        etiqueta_precio_unitario.TextAlign = ContentAlignment.MiddleLeft;
                        FlowLayoutPanel datosDeLosDetalles_ = new FlowLayoutPanel();
                        datosDeLosDetalles_.BackColor = Color.FromArgb(222, 205, 179);
                        datosDeLosDetalles_.Controls.Add(etiqueta_nombre_pedido);
                        datosDeLosDetalles_.Controls.Add(etiqueta_cantidad_del_pedido);
                        datosDeLosDetalles_.Controls.Add(etiqueta_precio_unitario);
                        datosDeLosDetalles_.FlowDirection = FlowDirection.TopDown;
                        datosDeLosDetalles_.Location = new Point(0, pos_y);
                        datosDeLosDetalles_.Margin = new Padding(0, 5, 0, 5);
                        datosDeLosDetalles_.Size = new Size(488, 89);
                        contenedor_inferior.Controls.Add(datosDeLosDetalles_);
                    }
                    FlowLayoutPanel tarjeta_principal = new FlowLayoutPanel();
                    tarjeta_principal.BackColor = Color.FromArgb(212, 195, 169);
                    tarjeta_principal.Controls.Add(etiqueta_titulo_tarjeta);
                    tarjeta_principal.Controls.Add(contenedor_superior);
                    tarjeta_principal.Controls.Add(contenedor_inferior);
                    tarjeta_principal.FlowDirection = FlowDirection.TopDown;
                    tarjeta_principal.Location = new Point(pos_x, 8);
                    tarjeta_principal.Padding = new Padding(5);
                    tarjeta_principal.Size = new Size(518, 613);
                    tarjeta_principal.TabIndex = 1;
                    contenedor_principal_ordenes.Controls.Add(tarjeta_principal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Eventos principales
        private void entrada_ver_por_estados_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarOrdenes();
        }
        #endregion
        #region Funciones principales
        private void CargarOrdenes()
        {
            try
            {
                string estado = entrada_ver_por_estados.Text;
                Orden orden = new Orden
                {
                    Estado = estado,
                };
                D_ConOrdenes conOrdenes = new D_ConOrdenes();
                var res = conOrdenes.ObtenerOrdenesPorEstado(orden);
                if (!res.estado)
                    throw new Exception(res.mensaje);
                DataTable dt = res.datos;
                if (dt.Rows.Count == 0)
                    throw new Exception("No hay ordenes cargadas con ese estado");
                CrearTrajetas(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
