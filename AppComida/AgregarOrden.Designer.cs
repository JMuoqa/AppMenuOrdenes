using System.Windows.Forms;

namespace AppComida
{
    partial class AgregarOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo_agregar = new Label();
            boton_confirmar = new Button();
            linea_nombre_cliente = new Panel();
            entrada_nombre_cliente = new TextBox();
            etiqueta_cliente = new Label();
            linea_numero = new Panel();
            entrada_numero = new TextBox();
            etiqueta_numero = new Label();
            panel1 = new Panel();
            entrada_direccion = new TextBox();
            etiqueta_direccion = new Label();
            panel2 = new Panel();
            entrada_hora_pedida = new TextBox();
            etiqueta_hora_pedida = new Label();
            entrada_minuto_pedido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            entrada_minuto_entrega = new TextBox();
            entrada_hora_entrega = new TextBox();
            etiqueta_hora_entrega = new Label();
            etiqueta_pedido = new Label();
            panel_pedidos = new FlowLayoutPanel();
            boton_buscar = new Button();
            label7 = new Label();
            entrada_busqueda = new TextBox();
            panel7 = new Panel();
            panel_contenedor_menus = new Panel();
            entrada_comentarios = new RichTextBox();
            etiqueta_comentarios = new Label();
            panel8 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            etiqueta_precio_final = new Label();
            etiqueta_items = new Label();
            label1 = new Label();
            entrada_pago = new CheckBox();
            label4 = new Label();
            entrada_metodo_pago = new ComboBox();
            SuspendLayout();
            // 
            // titulo_agregar
            // 
            titulo_agregar.AutoSize = true;
            titulo_agregar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_agregar.ForeColor = Color.Black;
            titulo_agregar.Location = new Point(496, 9);
            titulo_agregar.Name = "titulo_agregar";
            titulo_agregar.Size = new Size(539, 47);
            titulo_agregar.TabIndex = 160;
            titulo_agregar.Text = "Agendar orden manualmente";
            titulo_agregar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boton_confirmar
            // 
            boton_confirmar.BackColor = Color.FromArgb(150, 100, 50);
            boton_confirmar.Cursor = Cursors.Hand;
            boton_confirmar.FlatAppearance.BorderSize = 0;
            boton_confirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            boton_confirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            boton_confirmar.FlatStyle = FlatStyle.Flat;
            boton_confirmar.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_confirmar.ForeColor = Color.FromArgb(242, 225, 199);
            boton_confirmar.Location = new Point(792, 566);
            boton_confirmar.Margin = new Padding(3, 3, 3, 30);
            boton_confirmar.Name = "boton_confirmar";
            boton_confirmar.Size = new Size(582, 40);
            boton_confirmar.TabIndex = 13;
            boton_confirmar.Text = "Agendar orden";
            boton_confirmar.UseVisualStyleBackColor = false;
            boton_confirmar.Click += boton_confirmar_Click;
            // 
            // linea_nombre_cliente
            // 
            linea_nombre_cliente.BackColor = Color.Black;
            linea_nombre_cliente.Enabled = false;
            linea_nombre_cliente.Location = new Point(407, 108);
            linea_nombre_cliente.Margin = new Padding(3, 3, 3, 10);
            linea_nombre_cliente.Name = "linea_nombre_cliente";
            linea_nombre_cliente.Size = new Size(375, 2);
            linea_nombre_cliente.TabIndex = 179;
            // 
            // entrada_nombre_cliente
            // 
            entrada_nombre_cliente.BackColor = Color.FromArgb(242, 225, 199);
            entrada_nombre_cliente.BorderStyle = BorderStyle.None;
            entrada_nombre_cliente.Font = new Font("Montserrat", 15F);
            entrada_nombre_cliente.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_nombre_cliente.Location = new Point(407, 79);
            entrada_nombre_cliente.Name = "entrada_nombre_cliente";
            entrada_nombre_cliente.Size = new Size(375, 25);
            entrada_nombre_cliente.TabIndex = 1;
            entrada_nombre_cliente.Text = "Jesus";
            entrada_nombre_cliente.Enter += TodasLasEntradasNormales_Enter;
            entrada_nombre_cliente.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_cliente
            // 
            etiqueta_cliente.AutoSize = true;
            etiqueta_cliente.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_cliente.ForeColor = Color.Black;
            etiqueta_cliente.Location = new Point(160, 78);
            etiqueta_cliente.Name = "etiqueta_cliente";
            etiqueta_cliente.Size = new Size(231, 27);
            etiqueta_cliente.TabIndex = 180;
            etiqueta_cliente.Text = "Nombre del cliente:";
            etiqueta_cliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linea_numero
            // 
            linea_numero.BackColor = Color.Black;
            linea_numero.Enabled = false;
            linea_numero.Location = new Point(407, 155);
            linea_numero.Margin = new Padding(3, 3, 3, 10);
            linea_numero.Name = "linea_numero";
            linea_numero.Size = new Size(375, 2);
            linea_numero.TabIndex = 183;
            // 
            // entrada_numero
            // 
            entrada_numero.BackColor = Color.FromArgb(242, 225, 199);
            entrada_numero.BorderStyle = BorderStyle.None;
            entrada_numero.Font = new Font("Montserrat", 15F);
            entrada_numero.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_numero.Location = new Point(407, 126);
            entrada_numero.Name = "entrada_numero";
            entrada_numero.Size = new Size(375, 25);
            entrada_numero.TabIndex = 2;
            entrada_numero.Text = "3518182222";
            entrada_numero.Enter += TodasLasEntradasNormales_Enter;
            entrada_numero.KeyPress += entrada_numero_KeyPress;
            entrada_numero.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_numero
            // 
            etiqueta_numero.AutoSize = true;
            etiqueta_numero.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_numero.ForeColor = Color.Black;
            etiqueta_numero.Location = new Point(160, 123);
            etiqueta_numero.Name = "etiqueta_numero";
            etiqueta_numero.Size = new Size(241, 27);
            etiqueta_numero.TabIndex = 184;
            etiqueta_numero.Text = "Numero de telefono:";
            etiqueta_numero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Enabled = false;
            panel1.Location = new Point(407, 199);
            panel1.Margin = new Padding(3, 3, 3, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 2);
            panel1.TabIndex = 186;
            // 
            // entrada_direccion
            // 
            entrada_direccion.BackColor = Color.FromArgb(242, 225, 199);
            entrada_direccion.BorderStyle = BorderStyle.None;
            entrada_direccion.Font = new Font("Montserrat", 15F);
            entrada_direccion.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_direccion.Location = new Point(407, 170);
            entrada_direccion.Name = "entrada_direccion";
            entrada_direccion.Size = new Size(375, 25);
            entrada_direccion.TabIndex = 3;
            entrada_direccion.Text = "Local/Lagunilla 1111";
            entrada_direccion.Enter += TodasLasEntradasNormales_Enter;
            entrada_direccion.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_direccion
            // 
            etiqueta_direccion.AutoSize = true;
            etiqueta_direccion.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_direccion.ForeColor = Color.Black;
            etiqueta_direccion.Location = new Point(160, 173);
            etiqueta_direccion.Name = "etiqueta_direccion";
            etiqueta_direccion.Size = new Size(126, 27);
            etiqueta_direccion.TabIndex = 187;
            etiqueta_direccion.Text = "Domicilio:";
            etiqueta_direccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Enabled = false;
            panel2.Location = new Point(1055, 110);
            panel2.Margin = new Padding(3, 3, 3, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(118, 2);
            panel2.TabIndex = 189;
            // 
            // entrada_hora_pedida
            // 
            entrada_hora_pedida.BackColor = Color.FromArgb(242, 225, 199);
            entrada_hora_pedida.BorderStyle = BorderStyle.None;
            entrada_hora_pedida.Font = new Font("Montserrat", 15F);
            entrada_hora_pedida.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_hora_pedida.Location = new Point(1055, 81);
            entrada_hora_pedida.Name = "entrada_hora_pedida";
            entrada_hora_pedida.Size = new Size(44, 25);
            entrada_hora_pedida.TabIndex = 4;
            entrada_hora_pedida.Text = "20";
            entrada_hora_pedida.TextChanged += entrada_hora_pedida_TextChanged;
            entrada_hora_pedida.Enter += TodasLasEntradasNormales_Enter;
            entrada_hora_pedida.KeyPress += entrada_horario_KeyPress;
            entrada_hora_pedida.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_hora_pedida
            // 
            etiqueta_hora_pedida.AutoSize = true;
            etiqueta_hora_pedida.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_hora_pedida.ForeColor = Color.Black;
            etiqueta_hora_pedida.Location = new Point(788, 78);
            etiqueta_hora_pedida.Name = "etiqueta_hora_pedida";
            etiqueta_hora_pedida.Size = new Size(247, 27);
            etiqueta_hora_pedida.TabIndex = 190;
            etiqueta_hora_pedida.Text = "Hora en que se pidió:";
            etiqueta_hora_pedida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_minuto_pedido
            // 
            entrada_minuto_pedido.BackColor = Color.FromArgb(242, 225, 199);
            entrada_minuto_pedido.BorderStyle = BorderStyle.None;
            entrada_minuto_pedido.Font = new Font("Montserrat", 15F);
            entrada_minuto_pedido.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_minuto_pedido.Location = new Point(1129, 81);
            entrada_minuto_pedido.Name = "entrada_minuto_pedido";
            entrada_minuto_pedido.Size = new Size(44, 25);
            entrada_minuto_pedido.TabIndex = 5;
            entrada_minuto_pedido.Text = "30";
            entrada_minuto_pedido.TextChanged += entrada_minuto_pedido_TextChanged;
            entrada_minuto_pedido.Enter += TodasLasEntradasNormales_Enter;
            entrada_minuto_pedido.KeyPress += entrada_horario_KeyPress;
            entrada_minuto_pedido.Leave += TodasLasEntradasNormales_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1105, 79);
            label2.Name = "label2";
            label2.Size = new Size(18, 27);
            label2.TabIndex = 193;
            label2.Text = ":";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1105, 124);
            label3.Name = "label3";
            label3.Size = new Size(18, 27);
            label3.TabIndex = 199;
            label3.Text = ":";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_minuto_entrega
            // 
            entrada_minuto_entrega.BackColor = Color.FromArgb(242, 225, 199);
            entrada_minuto_entrega.BorderStyle = BorderStyle.None;
            entrada_minuto_entrega.Font = new Font("Montserrat", 15F);
            entrada_minuto_entrega.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_minuto_entrega.Location = new Point(1129, 126);
            entrada_minuto_entrega.Name = "entrada_minuto_entrega";
            entrada_minuto_entrega.Size = new Size(44, 25);
            entrada_minuto_entrega.TabIndex = 7;
            entrada_minuto_entrega.Text = "15";
            entrada_minuto_entrega.Enter += TodasLasEntradasNormales_Enter;
            entrada_minuto_entrega.KeyPress += entrada_horario_KeyPress;
            entrada_minuto_entrega.Leave += TodasLasEntradasNormales_Leave;
            // 
            // entrada_hora_entrega
            // 
            entrada_hora_entrega.BackColor = Color.FromArgb(242, 225, 199);
            entrada_hora_entrega.BorderStyle = BorderStyle.None;
            entrada_hora_entrega.Font = new Font("Montserrat", 15F);
            entrada_hora_entrega.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_hora_entrega.Location = new Point(1055, 126);
            entrada_hora_entrega.Name = "entrada_hora_entrega";
            entrada_hora_entrega.Size = new Size(44, 25);
            entrada_hora_entrega.TabIndex = 6;
            entrada_hora_entrega.Text = "21";
            entrada_hora_entrega.TextChanged += entrada_hora_entrega_TextChanged;
            entrada_hora_entrega.Enter += TodasLasEntradasNormales_Enter;
            entrada_hora_entrega.KeyPress += entrada_horario_KeyPress;
            entrada_hora_entrega.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_hora_entrega
            // 
            etiqueta_hora_entrega.AutoSize = true;
            etiqueta_hora_entrega.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_hora_entrega.ForeColor = Color.Black;
            etiqueta_hora_entrega.Location = new Point(788, 123);
            etiqueta_hora_entrega.Name = "etiqueta_hora_entrega";
            etiqueta_hora_entrega.Size = new Size(197, 27);
            etiqueta_hora_entrega.TabIndex = 196;
            etiqueta_hora_entrega.Text = "Hora de entrega:";
            etiqueta_hora_entrega.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_pedido
            // 
            etiqueta_pedido.AutoSize = true;
            etiqueta_pedido.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_pedido.ForeColor = Color.Black;
            etiqueta_pedido.Location = new Point(160, 223);
            etiqueta_pedido.Name = "etiqueta_pedido";
            etiqueta_pedido.Size = new Size(97, 27);
            etiqueta_pedido.TabIndex = 200;
            etiqueta_pedido.Text = "Pedido:";
            etiqueta_pedido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_pedidos
            // 
            panel_pedidos.AutoScroll = true;
            panel_pedidos.BackColor = Color.FromArgb(222, 205, 179);
            panel_pedidos.Location = new Point(160, 253);
            panel_pedidos.Name = "panel_pedidos";
            panel_pedidos.Padding = new Padding(10);
            panel_pedidos.Size = new Size(622, 427);
            panel_pedidos.TabIndex = 201;
            // 
            // boton_buscar
            // 
            boton_buscar.BackColor = Color.FromArgb(150, 100, 50);
            boton_buscar.Cursor = Cursors.Hand;
            boton_buscar.FlatAppearance.BorderSize = 0;
            boton_buscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            boton_buscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            boton_buscar.FlatStyle = FlatStyle.Flat;
            boton_buscar.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_buscar.ForeColor = Color.FromArgb(242, 225, 199);
            boton_buscar.Location = new Point(1113, 639);
            boton_buscar.Margin = new Padding(3, 3, 3, 30);
            boton_buscar.Name = "boton_buscar";
            boton_buscar.Size = new Size(261, 40);
            boton_buscar.TabIndex = 12;
            boton_buscar.Text = "Buscar";
            boton_buscar.UseVisualStyleBackColor = false;
            boton_buscar.Click += boton_buscar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(788, 615);
            label7.Name = "label7";
            label7.Size = new Size(307, 27);
            label7.TabIndex = 208;
            label7.Text = "Buscar menu para agregar";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_busqueda
            // 
            entrada_busqueda.BackColor = Color.FromArgb(242, 225, 199);
            entrada_busqueda.BorderStyle = BorderStyle.None;
            entrada_busqueda.Font = new Font("Montserrat", 15F);
            entrada_busqueda.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_busqueda.Location = new Point(788, 645);
            entrada_busqueda.Name = "entrada_busqueda";
            entrada_busqueda.Size = new Size(319, 25);
            entrada_busqueda.TabIndex = 11;
            entrada_busqueda.Text = "Lomo completo";
            entrada_busqueda.Enter += TodasLasEntradasNormales_Enter;
            entrada_busqueda.KeyDown += entrada_busqueda_KeyDown;
            entrada_busqueda.Leave += TodasLasEntradasNormales_Leave;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Enabled = false;
            panel7.Location = new Point(788, 674);
            panel7.Margin = new Padding(3, 3, 3, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(319, 2);
            panel7.TabIndex = 207;
            // 
            // panel_contenedor_menus
            // 
            panel_contenedor_menus.AutoScroll = true;
            panel_contenedor_menus.Location = new Point(160, 686);
            panel_contenedor_menus.Name = "panel_contenedor_menus";
            panel_contenedor_menus.Size = new Size(1214, 407);
            panel_contenedor_menus.TabIndex = 205;
            // 
            // entrada_comentarios
            // 
            entrada_comentarios.BackColor = Color.FromArgb(222, 205, 179);
            entrada_comentarios.BorderStyle = BorderStyle.None;
            entrada_comentarios.Location = new Point(792, 261);
            entrada_comentarios.Name = "entrada_comentarios";
            entrada_comentarios.Size = new Size(582, 182);
            entrada_comentarios.TabIndex = 9;
            entrada_comentarios.Text = "";
            // 
            // etiqueta_comentarios
            // 
            etiqueta_comentarios.AutoSize = true;
            etiqueta_comentarios.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_comentarios.ForeColor = Color.Black;
            etiqueta_comentarios.Location = new Point(788, 223);
            etiqueta_comentarios.Name = "etiqueta_comentarios";
            etiqueta_comentarios.Size = new Size(154, 27);
            etiqueta_comentarios.TabIndex = 212;
            etiqueta_comentarios.Text = "Comentarios";
            etiqueta_comentarios.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Enabled = false;
            panel8.Location = new Point(792, 253);
            panel8.Name = "panel8";
            panel8.Size = new Size(582, 2);
            panel8.TabIndex = 214;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Enabled = false;
            panel6.Location = new Point(792, 449);
            panel6.Margin = new Padding(3, 3, 3, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(582, 2);
            panel6.TabIndex = 215;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Enabled = false;
            panel3.Location = new Point(1055, 155);
            panel3.Margin = new Padding(3, 3, 3, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(118, 2);
            panel3.TabIndex = 216;
            // 
            // etiqueta_precio_final
            // 
            etiqueta_precio_final.AutoSize = true;
            etiqueta_precio_final.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_precio_final.ForeColor = Color.Black;
            etiqueta_precio_final.Location = new Point(792, 491);
            etiqueta_precio_final.Margin = new Padding(5);
            etiqueta_precio_final.Name = "etiqueta_precio_final";
            etiqueta_precio_final.Size = new Size(176, 27);
            etiqueta_precio_final.TabIndex = 217;
            etiqueta_precio_final.Text = "Precio final: $0";
            etiqueta_precio_final.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_items
            // 
            etiqueta_items.AutoSize = true;
            etiqueta_items.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_items.ForeColor = Color.Black;
            etiqueta_items.Location = new Point(792, 454);
            etiqueta_items.Margin = new Padding(5);
            etiqueta_items.Name = "etiqueta_items";
            etiqueta_items.Size = new Size(261, 27);
            etiqueta_items.TabIndex = 218;
            etiqueta_items.Text = "Productos añadidos: 0";
            etiqueta_items.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(792, 525);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(103, 27);
            label1.TabIndex = 219;
            label1.Text = "Pagado:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_pago
            // 
            entrada_pago.AutoSize = true;
            entrada_pago.Font = new Font("Montserrat", 15F);
            entrada_pago.Location = new Point(905, 524);
            entrada_pago.Margin = new Padding(5);
            entrada_pago.Name = "entrada_pago";
            entrada_pago.Size = new Size(49, 31);
            entrada_pago.TabIndex = 10;
            entrada_pago.Text = "SI";
            entrada_pago.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(788, 173);
            label4.Name = "label4";
            label4.Size = new Size(206, 27);
            label4.TabIndex = 220;
            label4.Text = "Metodo de pago: ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_metodo_pago
            // 
            entrada_metodo_pago.BackColor = Color.FromArgb(242, 225, 199);
            entrada_metodo_pago.DropDownStyle = ComboBoxStyle.DropDownList;
            entrada_metodo_pago.FlatStyle = FlatStyle.Flat;
            entrada_metodo_pago.Font = new Font("Montserrat", 15F);
            entrada_metodo_pago.ForeColor = Color.Black;
            entrada_metodo_pago.FormattingEnabled = true;
            entrada_metodo_pago.Items.AddRange(new object[] { "Transferencia", "Efectivo" });
            entrada_metodo_pago.Location = new Point(1055, 170);
            entrada_metodo_pago.Name = "entrada_metodo_pago";
            entrada_metodo_pago.Size = new Size(219, 35);
            entrada_metodo_pago.TabIndex = 8;
            entrada_metodo_pago.KeyPress += entrada_metodo_pago_KeyPress;
            // 
            // AgregarOrden
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(1521, 1061);
            Controls.Add(entrada_metodo_pago);
            Controls.Add(label4);
            Controls.Add(boton_confirmar);
            Controls.Add(entrada_pago);
            Controls.Add(label1);
            Controls.Add(etiqueta_items);
            Controls.Add(etiqueta_precio_final);
            Controls.Add(panel3);
            Controls.Add(etiqueta_pedido);
            Controls.Add(panel6);
            Controls.Add(panel8);
            Controls.Add(etiqueta_comentarios);
            Controls.Add(entrada_comentarios);
            Controls.Add(boton_buscar);
            Controls.Add(label7);
            Controls.Add(titulo_agregar);
            Controls.Add(entrada_busqueda);
            Controls.Add(etiqueta_cliente);
            Controls.Add(panel7);
            Controls.Add(entrada_minuto_pedido);
            Controls.Add(panel_contenedor_menus);
            Controls.Add(panel2);
            Controls.Add(entrada_nombre_cliente);
            Controls.Add(label2);
            Controls.Add(linea_nombre_cliente);
            Controls.Add(entrada_hora_pedida);
            Controls.Add(etiqueta_hora_entrega);
            Controls.Add(panel_pedidos);
            Controls.Add(etiqueta_hora_pedida);
            Controls.Add(etiqueta_numero);
            Controls.Add(entrada_hora_entrega);
            Controls.Add(panel1);
            Controls.Add(entrada_numero);
            Controls.Add(label3);
            Controls.Add(entrada_direccion);
            Controls.Add(linea_numero);
            Controls.Add(entrada_minuto_entrega);
            Controls.Add(etiqueta_direccion);
            Font = new Font("Montserrat", 10F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarOrden";
            Text = "AgregarOrden";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo_agregar;
        private Button boton_confirmar;
        private Panel linea_nombre_cliente;
        private TextBox entrada_nombre_cliente;
        private Label etiqueta_cliente;
        private Panel linea_numero;
        private TextBox entrada_numero;
        private Label etiqueta_numero;
        private Panel panel1;
        private TextBox entrada_direccion;
        private Label etiqueta_direccion;
        private Panel panel2;
        private TextBox entrada_hora_pedida;
        private Label etiqueta_hora_pedida;
        private TextBox entrada_minuto_pedido;
        private Label label2;
        private Label label3;
        private TextBox entrada_minuto_entrega;
        private TextBox entrada_hora_entrega;
        private Label etiqueta_hora_entrega;
        private Label etiqueta_pedido;
        private FlowLayoutPanel panel_pedidos;
        private Panel panel_contenedor_menus;
        private Button boton_buscar;
        private Label label7;
        private TextBox entrada_busqueda;
        private Panel panel7;
        private RichTextBox entrada_comentarios;
        private Label etiqueta_comentarios;
        private Panel panel8;
        private Panel panel6;
        private Panel panel3;
        private Label etiqueta_precio_final;
        private Label etiqueta_items;
        private Label label1;
        private CheckBox entrada_pago;
        private Label label4;
        private ComboBox entrada_metodo_pago;
    }
}