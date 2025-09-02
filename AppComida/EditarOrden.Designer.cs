namespace AppComida
{
    partial class EditarOrden
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
            boton_buscar = new Button();
            label1 = new Label();
            titulo_editar = new Label();
            entrada_busqueda_ordenes = new TextBox();
            panel1 = new Panel();
            etiqueta_items = new Label();
            etiqueta_precio_final = new Label();
            panel3 = new Panel();
            etiqueta_pedido = new Label();
            panel6 = new Panel();
            panel8 = new Panel();
            etiqueta_comentarios = new Label();
            entrada_comentarios = new RichTextBox();
            boton_busqueda_menu = new Button();
            label7 = new Label();
            entrada_busqueda_menu = new TextBox();
            etiqueta_cliente = new Label();
            panel7 = new Panel();
            entrada_minuto_pedido = new TextBox();
            panel_contenedor_menus = new Panel();
            panel2 = new Panel();
            entrada_nombre_cliente = new TextBox();
            label2 = new Label();
            linea_nombre_cliente = new Panel();
            entrada_hora_pedida = new TextBox();
            boton_confirmar = new Button();
            etiqueta_hora_entrega = new Label();
            panel_pedidos = new FlowLayoutPanel();
            etiqueta_hora_pedida = new Label();
            etiqueta_numero = new Label();
            entrada_hora_entrega = new TextBox();
            panel4 = new Panel();
            entrada_numero = new TextBox();
            label3 = new Label();
            entrada_direccion = new TextBox();
            linea_numero = new Panel();
            entrada_minuto_entrega = new TextBox();
            etiqueta_direccion = new Label();
            resultados_busqueda = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            etiqueta_IDOrden = new Label();
            label10 = new Label();
            label11 = new Label();
            entrada_pago = new CheckBox();
            label9 = new Label();
            label12 = new Label();
            entrada_metodo_pago = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)resultados_busqueda).BeginInit();
            SuspendLayout();
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
            boton_buscar.Location = new Point(491, 166);
            boton_buscar.Margin = new Padding(3, 3, 3, 30);
            boton_buscar.Name = "boton_buscar";
            boton_buscar.Size = new Size(138, 40);
            boton_buscar.TabIndex = 186;
            boton_buscar.Text = "Buscar";
            boton_buscar.UseVisualStyleBackColor = false;
            boton_buscar.Click += boton_buscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(166, 142);
            label1.Name = "label1";
            label1.Size = new Size(131, 27);
            label1.TabIndex = 185;
            label1.Text = "Busqueda:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // titulo_editar
            // 
            titulo_editar.Anchor = AnchorStyles.Top;
            titulo_editar.AutoSize = true;
            titulo_editar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_editar.ForeColor = Color.Black;
            titulo_editar.Location = new Point(543, 9);
            titulo_editar.Name = "titulo_editar";
            titulo_editar.Size = new Size(236, 47);
            titulo_editar.TabIndex = 187;
            titulo_editar.Text = "Editar orden";
            titulo_editar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // entrada_busqueda_ordenes
            // 
            entrada_busqueda_ordenes.BackColor = Color.FromArgb(242, 225, 199);
            entrada_busqueda_ordenes.BorderStyle = BorderStyle.None;
            entrada_busqueda_ordenes.Font = new Font("Montserrat", 15F);
            entrada_busqueda_ordenes.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_busqueda_ordenes.Location = new Point(166, 172);
            entrada_busqueda_ordenes.Name = "entrada_busqueda_ordenes";
            entrada_busqueda_ordenes.Size = new Size(319, 25);
            entrada_busqueda_ordenes.TabIndex = 1;
            entrada_busqueda_ordenes.Text = "#7/Julian/-3517787224";
            entrada_busqueda_ordenes.TextChanged += entrada_busqueda_ordenes_TextChanged;
            entrada_busqueda_ordenes.Enter += TodasLasEntradasNormales_Enter;
            entrada_busqueda_ordenes.KeyDown += entrada_busqueda_ordenes_KeyDown;
            entrada_busqueda_ordenes.Leave += TodasLasEntradasNormales_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Enabled = false;
            panel1.Location = new Point(166, 203);
            panel1.Margin = new Padding(3, 3, 3, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 2);
            panel1.TabIndex = 189;
            // 
            // etiqueta_items
            // 
            etiqueta_items.AutoSize = true;
            etiqueta_items.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_items.ForeColor = Color.Black;
            etiqueta_items.Location = new Point(798, 1035);
            etiqueta_items.Margin = new Padding(5);
            etiqueta_items.Name = "etiqueta_items";
            etiqueta_items.Size = new Size(261, 27);
            etiqueta_items.TabIndex = 251;
            etiqueta_items.Text = "Productos añadidos: 0";
            etiqueta_items.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_precio_final
            // 
            etiqueta_precio_final.AutoSize = true;
            etiqueta_precio_final.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_precio_final.ForeColor = Color.Black;
            etiqueta_precio_final.Location = new Point(798, 1073);
            etiqueta_precio_final.Margin = new Padding(5);
            etiqueta_precio_final.Name = "etiqueta_precio_final";
            etiqueta_precio_final.Size = new Size(176, 27);
            etiqueta_precio_final.TabIndex = 250;
            etiqueta_precio_final.Text = "Precio final: $0";
            etiqueta_precio_final.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Enabled = false;
            panel3.Location = new Point(1061, 736);
            panel3.Margin = new Padding(3, 3, 3, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(118, 2);
            panel3.TabIndex = 249;
            // 
            // etiqueta_pedido
            // 
            etiqueta_pedido.AutoSize = true;
            etiqueta_pedido.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_pedido.ForeColor = Color.Black;
            etiqueta_pedido.Location = new Point(166, 804);
            etiqueta_pedido.Name = "etiqueta_pedido";
            etiqueta_pedido.Size = new Size(97, 27);
            etiqueta_pedido.TabIndex = 241;
            etiqueta_pedido.Text = "Pedido:";
            etiqueta_pedido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Enabled = false;
            panel6.Location = new Point(798, 1030);
            panel6.Margin = new Padding(3, 3, 3, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(582, 2);
            panel6.TabIndex = 248;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Enabled = false;
            panel8.Location = new Point(798, 834);
            panel8.Name = "panel8";
            panel8.Size = new Size(582, 2);
            panel8.TabIndex = 247;
            // 
            // etiqueta_comentarios
            // 
            etiqueta_comentarios.AutoSize = true;
            etiqueta_comentarios.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_comentarios.ForeColor = Color.Black;
            etiqueta_comentarios.Location = new Point(794, 804);
            etiqueta_comentarios.Name = "etiqueta_comentarios";
            etiqueta_comentarios.Size = new Size(154, 27);
            etiqueta_comentarios.TabIndex = 246;
            etiqueta_comentarios.Text = "Comentarios";
            etiqueta_comentarios.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_comentarios
            // 
            entrada_comentarios.BackColor = Color.FromArgb(222, 205, 179);
            entrada_comentarios.BorderStyle = BorderStyle.None;
            entrada_comentarios.Font = new Font("Montserrat", 12F);
            entrada_comentarios.Location = new Point(798, 842);
            entrada_comentarios.Name = "entrada_comentarios";
            entrada_comentarios.Size = new Size(582, 182);
            entrada_comentarios.TabIndex = 10;
            entrada_comentarios.Text = "";
            // 
            // boton_busqueda_menu
            // 
            boton_busqueda_menu.BackColor = Color.FromArgb(150, 100, 50);
            boton_busqueda_menu.Cursor = Cursors.Hand;
            boton_busqueda_menu.FlatAppearance.BorderSize = 0;
            boton_busqueda_menu.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            boton_busqueda_menu.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            boton_busqueda_menu.FlatStyle = FlatStyle.Flat;
            boton_busqueda_menu.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_busqueda_menu.ForeColor = Color.FromArgb(242, 225, 199);
            boton_busqueda_menu.Location = new Point(1119, 1220);
            boton_busqueda_menu.Margin = new Padding(3, 3, 3, 30);
            boton_busqueda_menu.Name = "boton_busqueda_menu";
            boton_busqueda_menu.Size = new Size(261, 40);
            boton_busqueda_menu.TabIndex = 13;
            boton_busqueda_menu.Text = "Buscar";
            boton_busqueda_menu.UseVisualStyleBackColor = false;
            boton_busqueda_menu.Click += boton_busqueda_menu_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(794, 1196);
            label7.Name = "label7";
            label7.Size = new Size(307, 27);
            label7.TabIndex = 245;
            label7.Text = "Buscar menu para agregar";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_busqueda_menu
            // 
            entrada_busqueda_menu.BackColor = Color.FromArgb(242, 225, 199);
            entrada_busqueda_menu.BorderStyle = BorderStyle.None;
            entrada_busqueda_menu.Font = new Font("Montserrat", 15F);
            entrada_busqueda_menu.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_busqueda_menu.Location = new Point(794, 1226);
            entrada_busqueda_menu.Name = "entrada_busqueda_menu";
            entrada_busqueda_menu.Size = new Size(319, 25);
            entrada_busqueda_menu.TabIndex = 12;
            entrada_busqueda_menu.Text = "Lomo completo";
            entrada_busqueda_menu.Enter += TodasLasEntradasNormales_Enter;
            entrada_busqueda_menu.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_cliente
            // 
            etiqueta_cliente.AutoSize = true;
            etiqueta_cliente.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_cliente.ForeColor = Color.Black;
            etiqueta_cliente.Location = new Point(166, 659);
            etiqueta_cliente.Name = "etiqueta_cliente";
            etiqueta_cliente.Size = new Size(231, 27);
            etiqueta_cliente.TabIndex = 231;
            etiqueta_cliente.Text = "Nombre del cliente:";
            etiqueta_cliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Enabled = false;
            panel7.Location = new Point(794, 1255);
            panel7.Margin = new Padding(3, 3, 3, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(319, 2);
            panel7.TabIndex = 244;
            // 
            // entrada_minuto_pedido
            // 
            entrada_minuto_pedido.BackColor = Color.FromArgb(242, 225, 199);
            entrada_minuto_pedido.BorderStyle = BorderStyle.None;
            entrada_minuto_pedido.Font = new Font("Montserrat", 15F);
            entrada_minuto_pedido.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_minuto_pedido.Location = new Point(1135, 662);
            entrada_minuto_pedido.Name = "entrada_minuto_pedido";
            entrada_minuto_pedido.Size = new Size(44, 25);
            entrada_minuto_pedido.TabIndex = 6;
            entrada_minuto_pedido.Text = "30";
            entrada_minuto_pedido.Enter += TodasLasEntradasNormales_Enter;
            entrada_minuto_pedido.Leave += TodasLasEntradasNormales_Leave;
            // 
            // panel_contenedor_menus
            // 
            panel_contenedor_menus.AutoScroll = true;
            panel_contenedor_menus.Location = new Point(166, 1267);
            panel_contenedor_menus.Name = "panel_contenedor_menus";
            panel_contenedor_menus.Size = new Size(1214, 395);
            panel_contenedor_menus.TabIndex = 243;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Enabled = false;
            panel2.Location = new Point(1061, 691);
            panel2.Margin = new Padding(3, 3, 3, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(118, 2);
            panel2.TabIndex = 236;
            // 
            // entrada_nombre_cliente
            // 
            entrada_nombre_cliente.BackColor = Color.FromArgb(242, 225, 199);
            entrada_nombre_cliente.BorderStyle = BorderStyle.None;
            entrada_nombre_cliente.Font = new Font("Montserrat", 15F);
            entrada_nombre_cliente.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_nombre_cliente.Location = new Point(413, 660);
            entrada_nombre_cliente.Name = "entrada_nombre_cliente";
            entrada_nombre_cliente.Size = new Size(375, 25);
            entrada_nombre_cliente.TabIndex = 2;
            entrada_nombre_cliente.Text = "Busca un orden para editarla";
            entrada_nombre_cliente.Enter += TodasLasEntradasNormales_Enter;
            entrada_nombre_cliente.Leave += TodasLasEntradasNormales_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1111, 660);
            label2.Name = "label2";
            label2.Size = new Size(18, 27);
            label2.TabIndex = 238;
            label2.Text = ":";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linea_nombre_cliente
            // 
            linea_nombre_cliente.BackColor = Color.Black;
            linea_nombre_cliente.Enabled = false;
            linea_nombre_cliente.Location = new Point(413, 689);
            linea_nombre_cliente.Margin = new Padding(3, 3, 3, 10);
            linea_nombre_cliente.Name = "linea_nombre_cliente";
            linea_nombre_cliente.Size = new Size(375, 2);
            linea_nombre_cliente.TabIndex = 230;
            // 
            // entrada_hora_pedida
            // 
            entrada_hora_pedida.BackColor = Color.FromArgb(242, 225, 199);
            entrada_hora_pedida.BorderStyle = BorderStyle.None;
            entrada_hora_pedida.Font = new Font("Montserrat", 15F);
            entrada_hora_pedida.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_hora_pedida.Location = new Point(1061, 662);
            entrada_hora_pedida.Name = "entrada_hora_pedida";
            entrada_hora_pedida.Size = new Size(44, 25);
            entrada_hora_pedida.TabIndex = 5;
            entrada_hora_pedida.Text = "20";
            entrada_hora_pedida.Enter += TodasLasEntradasNormales_Enter;
            entrada_hora_pedida.Leave += TodasLasEntradasNormales_Leave;
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
            boton_confirmar.Location = new Point(794, 1153);
            boton_confirmar.Margin = new Padding(3, 3, 3, 30);
            boton_confirmar.Name = "boton_confirmar";
            boton_confirmar.Size = new Size(586, 40);
            boton_confirmar.TabIndex = 14;
            boton_confirmar.Text = "Editar orden";
            boton_confirmar.UseVisualStyleBackColor = false;
            boton_confirmar.Click += boton_confirmar_Click;
            // 
            // etiqueta_hora_entrega
            // 
            etiqueta_hora_entrega.AutoSize = true;
            etiqueta_hora_entrega.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_hora_entrega.ForeColor = Color.Black;
            etiqueta_hora_entrega.Location = new Point(794, 704);
            etiqueta_hora_entrega.Name = "etiqueta_hora_entrega";
            etiqueta_hora_entrega.Size = new Size(197, 27);
            etiqueta_hora_entrega.TabIndex = 239;
            etiqueta_hora_entrega.Text = "Hora de entrega:";
            etiqueta_hora_entrega.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_pedidos
            // 
            panel_pedidos.AutoScroll = true;
            panel_pedidos.BackColor = Color.FromArgb(222, 205, 179);
            panel_pedidos.Location = new Point(166, 834);
            panel_pedidos.Name = "panel_pedidos";
            panel_pedidos.Padding = new Padding(10);
            panel_pedidos.Size = new Size(622, 427);
            panel_pedidos.TabIndex = 242;
            // 
            // etiqueta_hora_pedida
            // 
            etiqueta_hora_pedida.AutoSize = true;
            etiqueta_hora_pedida.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_hora_pedida.ForeColor = Color.Black;
            etiqueta_hora_pedida.Location = new Point(794, 659);
            etiqueta_hora_pedida.Name = "etiqueta_hora_pedida";
            etiqueta_hora_pedida.Size = new Size(247, 27);
            etiqueta_hora_pedida.TabIndex = 237;
            etiqueta_hora_pedida.Text = "Hora en que se pidió:";
            etiqueta_hora_pedida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_numero
            // 
            etiqueta_numero.AutoSize = true;
            etiqueta_numero.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_numero.ForeColor = Color.Black;
            etiqueta_numero.Location = new Point(166, 704);
            etiqueta_numero.Name = "etiqueta_numero";
            etiqueta_numero.Size = new Size(241, 27);
            etiqueta_numero.TabIndex = 233;
            etiqueta_numero.Text = "Numero de telefono:";
            etiqueta_numero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_hora_entrega
            // 
            entrada_hora_entrega.BackColor = Color.FromArgb(242, 225, 199);
            entrada_hora_entrega.BorderStyle = BorderStyle.None;
            entrada_hora_entrega.Font = new Font("Montserrat", 15F);
            entrada_hora_entrega.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_hora_entrega.Location = new Point(1061, 707);
            entrada_hora_entrega.Name = "entrada_hora_entrega";
            entrada_hora_entrega.Size = new Size(44, 25);
            entrada_hora_entrega.TabIndex = 7;
            entrada_hora_entrega.Text = "21";
            entrada_hora_entrega.Enter += TodasLasEntradasNormales_Enter;
            entrada_hora_entrega.Leave += TodasLasEntradasNormales_Leave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Enabled = false;
            panel4.Location = new Point(413, 780);
            panel4.Margin = new Padding(3, 3, 3, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 2);
            panel4.TabIndex = 234;
            // 
            // entrada_numero
            // 
            entrada_numero.BackColor = Color.FromArgb(242, 225, 199);
            entrada_numero.BorderStyle = BorderStyle.None;
            entrada_numero.Font = new Font("Montserrat", 15F);
            entrada_numero.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_numero.Location = new Point(413, 707);
            entrada_numero.Name = "entrada_numero";
            entrada_numero.Size = new Size(375, 25);
            entrada_numero.TabIndex = 3;
            entrada_numero.Text = "Busca un orden para editarla";
            entrada_numero.Enter += TodasLasEntradasNormales_Enter;
            entrada_numero.Leave += TodasLasEntradasNormales_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1111, 705);
            label3.Name = "label3";
            label3.Size = new Size(18, 27);
            label3.TabIndex = 240;
            label3.Text = ":";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_direccion
            // 
            entrada_direccion.BackColor = Color.FromArgb(242, 225, 199);
            entrada_direccion.BorderStyle = BorderStyle.None;
            entrada_direccion.Font = new Font("Montserrat", 15F);
            entrada_direccion.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_direccion.Location = new Point(413, 751);
            entrada_direccion.Name = "entrada_direccion";
            entrada_direccion.Size = new Size(375, 25);
            entrada_direccion.TabIndex = 4;
            entrada_direccion.Text = "Busca un orden para editarla";
            entrada_direccion.Enter += TodasLasEntradasNormales_Enter;
            entrada_direccion.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_numero
            // 
            linea_numero.BackColor = Color.Black;
            linea_numero.Enabled = false;
            linea_numero.Location = new Point(413, 736);
            linea_numero.Margin = new Padding(3, 3, 3, 10);
            linea_numero.Name = "linea_numero";
            linea_numero.Size = new Size(375, 2);
            linea_numero.TabIndex = 232;
            // 
            // entrada_minuto_entrega
            // 
            entrada_minuto_entrega.BackColor = Color.FromArgb(242, 225, 199);
            entrada_minuto_entrega.BorderStyle = BorderStyle.None;
            entrada_minuto_entrega.Font = new Font("Montserrat", 15F);
            entrada_minuto_entrega.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_minuto_entrega.Location = new Point(1135, 707);
            entrada_minuto_entrega.Name = "entrada_minuto_entrega";
            entrada_minuto_entrega.Size = new Size(44, 25);
            entrada_minuto_entrega.TabIndex = 8;
            entrada_minuto_entrega.Text = "15";
            entrada_minuto_entrega.Enter += TodasLasEntradasNormales_Enter;
            entrada_minuto_entrega.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_direccion
            // 
            etiqueta_direccion.AutoSize = true;
            etiqueta_direccion.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_direccion.ForeColor = Color.Black;
            etiqueta_direccion.Location = new Point(166, 754);
            etiqueta_direccion.Name = "etiqueta_direccion";
            etiqueta_direccion.Size = new Size(126, 27);
            etiqueta_direccion.TabIndex = 235;
            etiqueta_direccion.Text = "Domicilio:";
            etiqueta_direccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // resultados_busqueda
            // 
            resultados_busqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultados_busqueda.Location = new Point(166, 208);
            resultados_busqueda.Name = "resultados_busqueda";
            resultados_busqueda.ReadOnly = true;
            resultados_busqueda.Size = new Size(1214, 326);
            resultados_busqueda.TabIndex = 252;
            resultados_busqueda.CellClick += resultados_busqueda_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1131, 183);
            label4.Name = "label4";
            label4.Size = new Size(249, 22);
            label4.TabIndex = 253;
            label4.Text = "Click en una orden para editar";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(166, 71);
            label5.Name = "label5";
            label5.Size = new Size(450, 22);
            label5.TabIndex = 254;
            label5.Text = "Coloca \"#\" en la busqueda para buscar por Nº de orden.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(166, 579);
            label6.Name = "label6";
            label6.Size = new Size(245, 27);
            label6.TabIndex = 255;
            label6.Text = "Orden seleccionada: ";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(166, 107);
            label8.Name = "label8";
            label8.Size = new Size(463, 22);
            label8.TabIndex = 256;
            label8.Text = "Coloca \"-\" en la busqueda para buscar por Nº de telefono.";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_IDOrden
            // 
            etiqueta_IDOrden.AutoSize = true;
            etiqueta_IDOrden.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_IDOrden.ForeColor = Color.Black;
            etiqueta_IDOrden.Location = new Point(425, 579);
            etiqueta_IDOrden.Name = "etiqueta_IDOrden";
            etiqueta_IDOrden.Size = new Size(109, 27);
            etiqueta_IDOrden.TabIndex = 257;
            etiqueta_IDOrden.Text = "Ninguna";
            etiqueta_IDOrden.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Montserrat", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(709, 71);
            label10.Name = "label10";
            label10.Size = new Size(282, 22);
            label10.TabIndex = 258;
            label10.Text = "Ejemplo: \"#1\" buscara la orden Nº 1";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat", 12F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(709, 107);
            label11.Name = "label11";
            label11.Size = new Size(640, 22);
            label11.TabIndex = 259;
            label11.Text = "Ejemplo: \"-3517787224\" buscara la/las orden/es con el Nº de telefono 3517787224";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_pago
            // 
            entrada_pago.AutoSize = true;
            entrada_pago.Font = new Font("Montserrat", 15F);
            entrada_pago.Location = new Point(911, 1109);
            entrada_pago.Margin = new Padding(5);
            entrada_pago.Name = "entrada_pago";
            entrada_pago.Size = new Size(49, 31);
            entrada_pago.TabIndex = 11;
            entrada_pago.Text = "SI";
            entrada_pago.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(798, 1110);
            label9.Margin = new Padding(5);
            label9.Name = "label9";
            label9.Size = new Size(103, 27);
            label9.TabIndex = 261;
            label9.Text = "Pagado:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(798, 754);
            label12.Name = "label12";
            label12.Size = new Size(206, 27);
            label12.TabIndex = 262;
            label12.Text = "Metodo de pago: ";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_metodo_pago
            // 
            entrada_metodo_pago.BackColor = Color.FromArgb(242, 225, 199);
            entrada_metodo_pago.DropDownStyle = ComboBoxStyle.DropDownList;
            entrada_metodo_pago.FlatStyle = FlatStyle.Flat;
            entrada_metodo_pago.Font = new Font("Montserrat", 15F);
            entrada_metodo_pago.ForeColor = Color.Black;
            entrada_metodo_pago.FormattingEnabled = true;
            entrada_metodo_pago.Items.AddRange(new object[] { "Transferenia", "Efectivo" });
            entrada_metodo_pago.Location = new Point(1061, 751);
            entrada_metodo_pago.Name = "entrada_metodo_pago";
            entrada_metodo_pago.Size = new Size(243, 35);
            entrada_metodo_pago.TabIndex = 9;
            entrada_metodo_pago.KeyPress += entrada_metodo_pago_KeyPress;
            // 
            // EditarOrden
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(1521, 942);
            Controls.Add(entrada_metodo_pago);
            Controls.Add(label12);
            Controls.Add(entrada_pago);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(etiqueta_IDOrden);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(resultados_busqueda);
            Controls.Add(etiqueta_items);
            Controls.Add(etiqueta_precio_final);
            Controls.Add(panel3);
            Controls.Add(etiqueta_pedido);
            Controls.Add(panel6);
            Controls.Add(panel8);
            Controls.Add(etiqueta_comentarios);
            Controls.Add(entrada_comentarios);
            Controls.Add(boton_busqueda_menu);
            Controls.Add(label7);
            Controls.Add(entrada_busqueda_menu);
            Controls.Add(etiqueta_cliente);
            Controls.Add(panel7);
            Controls.Add(entrada_minuto_pedido);
            Controls.Add(panel_contenedor_menus);
            Controls.Add(panel2);
            Controls.Add(entrada_nombre_cliente);
            Controls.Add(label2);
            Controls.Add(linea_nombre_cliente);
            Controls.Add(entrada_hora_pedida);
            Controls.Add(boton_confirmar);
            Controls.Add(etiqueta_hora_entrega);
            Controls.Add(panel_pedidos);
            Controls.Add(etiqueta_hora_pedida);
            Controls.Add(etiqueta_numero);
            Controls.Add(entrada_hora_entrega);
            Controls.Add(panel4);
            Controls.Add(entrada_numero);
            Controls.Add(label3);
            Controls.Add(entrada_direccion);
            Controls.Add(linea_numero);
            Controls.Add(entrada_minuto_entrega);
            Controls.Add(etiqueta_direccion);
            Controls.Add(entrada_busqueda_ordenes);
            Controls.Add(panel1);
            Controls.Add(titulo_editar);
            Controls.Add(boton_buscar);
            Controls.Add(label1);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditarOrden";
            Text = "EditarOrden";
            ((System.ComponentModel.ISupportInitialize)resultados_busqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button boton_buscar;
        private Label label1;
        private Label titulo_editar;
        private TextBox entrada_busqueda_ordenes;
        private Panel panel1;
        private Label etiqueta_items;
        private Label etiqueta_precio_final;
        private Panel panel3;
        private Label etiqueta_pedido;
        private Panel panel6;
        private Panel panel8;
        private Label etiqueta_comentarios;
        private RichTextBox entrada_comentarios;
        private Button boton_busqueda_menu;
        private Label label7;
        private TextBox entrada_busqueda_menu;
        private Label etiqueta_cliente;
        private Panel panel7;
        private TextBox entrada_minuto_pedido;
        private Panel panel_contenedor_menus;
        private Panel panel2;
        private TextBox entrada_nombre_cliente;
        private Label label2;
        private Panel linea_nombre_cliente;
        private TextBox entrada_hora_pedida;
        private Button boton_confirmar;
        private Label etiqueta_hora_entrega;
        private FlowLayoutPanel panel_pedidos;
        private Label etiqueta_hora_pedida;
        private Label etiqueta_numero;
        private TextBox entrada_hora_entrega;
        private Panel panel4;
        private TextBox entrada_numero;
        private Label label3;
        private TextBox entrada_direccion;
        private Panel linea_numero;
        private TextBox entrada_minuto_entrega;
        private Label etiqueta_direccion;
        private DataGridView resultados_busqueda;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label etiqueta_IDOrden;
        private Label label10;
        private Label label11;
        private CheckBox entrada_pago;
        private Label label9;
        private Label label12;
        private ComboBox entrada_metodo_pago;
    }
}