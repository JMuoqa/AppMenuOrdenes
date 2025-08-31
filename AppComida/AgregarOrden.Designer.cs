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
            panel3 = new Panel();
            entrada_minuto_pedido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            entrada_minuto_entrega = new TextBox();
            panel5 = new Panel();
            entrada_hora_entrega = new TextBox();
            etiqueta_hora_entrega = new Label();
            etiqueta_pedido = new Label();
            panel_pedido = new FlowLayoutPanel();
            panel6 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label8 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel8 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel_principal = new Panel();
            button1 = new Button();
            label7 = new Label();
            entrada_busqueda = new TextBox();
            panel7 = new Panel();
            panel_contenedor_menus = new Panel();
            panel_pedido.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel_principal.SuspendLayout();
            SuspendLayout();
            // 
            // titulo_agregar
            // 
            titulo_agregar.AutoSize = true;
            titulo_agregar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_agregar.ForeColor = Color.Black;
            titulo_agregar.Location = new Point(635, 9);
            titulo_agregar.Name = "titulo_agregar";
            titulo_agregar.Size = new Size(282, 47);
            titulo_agregar.TabIndex = 160;
            titulo_agregar.Text = "Agendar orden";
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
            boton_confirmar.Location = new Point(789, 200);
            boton_confirmar.Margin = new Padding(3, 3, 3, 30);
            boton_confirmar.Name = "boton_confirmar";
            boton_confirmar.Size = new Size(586, 40);
            boton_confirmar.TabIndex = 181;
            boton_confirmar.Text = "Agendar orden";
            boton_confirmar.UseVisualStyleBackColor = false;
            // 
            // linea_nombre_cliente
            // 
            linea_nombre_cliente.BackColor = Color.Black;
            linea_nombre_cliente.Enabled = false;
            linea_nombre_cliente.Location = new Point(408, 45);
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
            entrada_nombre_cliente.Location = new Point(408, 16);
            entrada_nombre_cliente.Name = "entrada_nombre_cliente";
            entrada_nombre_cliente.Size = new Size(375, 25);
            entrada_nombre_cliente.TabIndex = 178;
            entrada_nombre_cliente.Text = "Jesus";
            entrada_nombre_cliente.Enter += TodasLasEntradasNormales_Enter;
            entrada_nombre_cliente.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_cliente
            // 
            etiqueta_cliente.AutoSize = true;
            etiqueta_cliente.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_cliente.ForeColor = Color.Black;
            etiqueta_cliente.Location = new Point(161, 15);
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
            linea_numero.Location = new Point(408, 92);
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
            entrada_numero.Location = new Point(408, 63);
            entrada_numero.Name = "entrada_numero";
            entrada_numero.Size = new Size(375, 25);
            entrada_numero.TabIndex = 182;
            entrada_numero.Text = "3518182222";
            entrada_numero.Enter += TodasLasEntradasNormales_Enter;
            entrada_numero.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_numero
            // 
            etiqueta_numero.AutoSize = true;
            etiqueta_numero.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_numero.ForeColor = Color.Black;
            etiqueta_numero.Location = new Point(161, 60);
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
            panel1.Location = new Point(408, 136);
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
            entrada_direccion.Location = new Point(408, 107);
            entrada_direccion.Name = "entrada_direccion";
            entrada_direccion.Size = new Size(375, 25);
            entrada_direccion.TabIndex = 185;
            entrada_direccion.Text = "Local/Lagunilla 1111";
            entrada_direccion.Enter += TodasLasEntradasNormales_Enter;
            entrada_direccion.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_direccion
            // 
            etiqueta_direccion.AutoSize = true;
            etiqueta_direccion.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_direccion.ForeColor = Color.Black;
            etiqueta_direccion.Location = new Point(161, 110);
            etiqueta_direccion.Name = "etiqueta_direccion";
            etiqueta_direccion.Size = new Size(125, 27);
            etiqueta_direccion.TabIndex = 187;
            etiqueta_direccion.Text = "Dirección:";
            etiqueta_direccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Enabled = false;
            panel2.Location = new Point(1056, 47);
            panel2.Margin = new Padding(3, 3, 3, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(44, 2);
            panel2.TabIndex = 189;
            // 
            // entrada_hora_pedida
            // 
            entrada_hora_pedida.BackColor = Color.FromArgb(242, 225, 199);
            entrada_hora_pedida.BorderStyle = BorderStyle.None;
            entrada_hora_pedida.Font = new Font("Montserrat", 15F);
            entrada_hora_pedida.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_hora_pedida.Location = new Point(1056, 18);
            entrada_hora_pedida.Name = "entrada_hora_pedida";
            entrada_hora_pedida.Size = new Size(44, 25);
            entrada_hora_pedida.TabIndex = 188;
            entrada_hora_pedida.Text = "20";
            entrada_hora_pedida.Enter += TodasLasEntradasNormales_Enter;
            entrada_hora_pedida.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_hora_pedida
            // 
            etiqueta_hora_pedida.AutoSize = true;
            etiqueta_hora_pedida.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_hora_pedida.ForeColor = Color.Black;
            etiqueta_hora_pedida.Location = new Point(789, 15);
            etiqueta_hora_pedida.Name = "etiqueta_hora_pedida";
            etiqueta_hora_pedida.Size = new Size(247, 27);
            etiqueta_hora_pedida.TabIndex = 190;
            etiqueta_hora_pedida.Text = "Hora en que se pidió:";
            etiqueta_hora_pedida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Enabled = false;
            panel3.Location = new Point(1130, 47);
            panel3.Margin = new Padding(3, 3, 3, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(44, 2);
            panel3.TabIndex = 192;
            // 
            // entrada_minuto_pedido
            // 
            entrada_minuto_pedido.BackColor = Color.FromArgb(242, 225, 199);
            entrada_minuto_pedido.BorderStyle = BorderStyle.None;
            entrada_minuto_pedido.Font = new Font("Montserrat", 15F);
            entrada_minuto_pedido.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_minuto_pedido.Location = new Point(1130, 18);
            entrada_minuto_pedido.Name = "entrada_minuto_pedido";
            entrada_minuto_pedido.Size = new Size(44, 25);
            entrada_minuto_pedido.TabIndex = 191;
            entrada_minuto_pedido.Text = "30";
            entrada_minuto_pedido.Enter += TodasLasEntradasNormales_Enter;
            entrada_minuto_pedido.Leave += TodasLasEntradasNormales_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1106, 16);
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
            label3.Location = new Point(1106, 61);
            label3.Name = "label3";
            label3.Size = new Size(18, 27);
            label3.TabIndex = 199;
            label3.Text = ":";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Enabled = false;
            panel4.Location = new Point(1130, 92);
            panel4.Margin = new Padding(3, 3, 3, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(44, 2);
            panel4.TabIndex = 198;
            // 
            // entrada_minuto_entrega
            // 
            entrada_minuto_entrega.BackColor = Color.FromArgb(242, 225, 199);
            entrada_minuto_entrega.BorderStyle = BorderStyle.None;
            entrada_minuto_entrega.Font = new Font("Montserrat", 15F);
            entrada_minuto_entrega.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_minuto_entrega.Location = new Point(1130, 63);
            entrada_minuto_entrega.Name = "entrada_minuto_entrega";
            entrada_minuto_entrega.Size = new Size(44, 25);
            entrada_minuto_entrega.TabIndex = 197;
            entrada_minuto_entrega.Text = "15";
            entrada_minuto_entrega.Enter += TodasLasEntradasNormales_Enter;
            entrada_minuto_entrega.Leave += TodasLasEntradasNormales_Leave;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Enabled = false;
            panel5.Location = new Point(1056, 92);
            panel5.Margin = new Padding(3, 3, 3, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(44, 2);
            panel5.TabIndex = 195;
            // 
            // entrada_hora_entrega
            // 
            entrada_hora_entrega.BackColor = Color.FromArgb(242, 225, 199);
            entrada_hora_entrega.BorderStyle = BorderStyle.None;
            entrada_hora_entrega.Font = new Font("Montserrat", 15F);
            entrada_hora_entrega.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_hora_entrega.Location = new Point(1056, 63);
            entrada_hora_entrega.Name = "entrada_hora_entrega";
            entrada_hora_entrega.Size = new Size(44, 25);
            entrada_hora_entrega.TabIndex = 194;
            entrada_hora_entrega.Text = "21";
            entrada_hora_entrega.Enter += TodasLasEntradasNormales_Enter;
            entrada_hora_entrega.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_hora_entrega
            // 
            etiqueta_hora_entrega.AutoSize = true;
            etiqueta_hora_entrega.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_hora_entrega.ForeColor = Color.Black;
            etiqueta_hora_entrega.Location = new Point(789, 60);
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
            etiqueta_pedido.Location = new Point(161, 170);
            etiqueta_pedido.Name = "etiqueta_pedido";
            etiqueta_pedido.Size = new Size(97, 27);
            etiqueta_pedido.TabIndex = 200;
            etiqueta_pedido.Text = "Pedido:";
            etiqueta_pedido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_pedido
            // 
            panel_pedido.BackColor = Color.FromArgb(222, 205, 179);
            panel_pedido.Controls.Add(panel6);
            panel_pedido.Location = new Point(166, 200);
            panel_pedido.Name = "panel_pedido";
            panel_pedido.Padding = new Padding(10);
            panel_pedido.Size = new Size(617, 417);
            panel_pedido.TabIndex = 201;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(242, 225, 199);
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(13, 13);
            panel6.Name = "panel6";
            panel6.Size = new Size(590, 166);
            panel6.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(476, 166);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(13, 10);
            label8.Name = "label8";
            label8.Size = new Size(30, 22);
            label8.TabIndex = 205;
            label8.Text = "#2";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 32);
            label1.Name = "label1";
            label1.Size = new Size(137, 22);
            label1.TabIndex = 201;
            label1.Text = "Lomo completo";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 54);
            label4.Name = "label4";
            label4.Size = new Size(169, 22);
            label4.TabIndex = 202;
            label4.Text = "Precio total: $24000";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(13, 76);
            label5.Name = "label5";
            label5.Size = new Size(99, 22);
            label5.TabIndex = 203;
            label5.Text = "Cantidad: 2";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(13, 98);
            label6.Name = "label6";
            label6.Size = new Size(211, 22);
            label6.TabIndex = 204;
            label6.Text = "Precio de unidad: $12000";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(232, 215, 189);
            panel8.Controls.Add(button4);
            panel8.Controls.Add(button3);
            panel8.Controls.Add(button2);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(476, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(114, 166);
            panel8.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Montserrat", 12.25F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(242, 225, 199);
            button4.Location = new Point(9, 107);
            button4.Margin = new Padding(3, 3, 3, 30);
            button4.Name = "button4";
            button4.Size = new Size(96, 33);
            button4.TabIndex = 184;
            button4.Text = "Quitar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Montserrat", 12.25F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(242, 225, 199);
            button3.Location = new Point(9, 67);
            button3.Margin = new Padding(3, 3, 3, 30);
            button3.Name = "button3";
            button3.Size = new Size(96, 33);
            button3.TabIndex = 183;
            button3.Text = "Restar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 12.25F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(242, 225, 199);
            button2.Location = new Point(9, 25);
            button2.Margin = new Padding(3, 3, 3, 30);
            button2.Name = "button2";
            button2.Size = new Size(96, 33);
            button2.TabIndex = 182;
            button2.Text = "Sumar";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel_principal
            // 
            panel_principal.AutoScroll = true;
            panel_principal.Controls.Add(button1);
            panel_principal.Controls.Add(label7);
            panel_principal.Controls.Add(entrada_busqueda);
            panel_principal.Controls.Add(panel7);
            panel_principal.Controls.Add(panel_contenedor_menus);
            panel_principal.Controls.Add(etiqueta_cliente);
            panel_principal.Controls.Add(entrada_nombre_cliente);
            panel_principal.Controls.Add(linea_nombre_cliente);
            panel_principal.Controls.Add(boton_confirmar);
            panel_principal.Controls.Add(panel_pedido);
            panel_principal.Controls.Add(etiqueta_numero);
            panel_principal.Controls.Add(etiqueta_pedido);
            panel_principal.Controls.Add(entrada_numero);
            panel_principal.Controls.Add(label3);
            panel_principal.Controls.Add(linea_numero);
            panel_principal.Controls.Add(panel4);
            panel_principal.Controls.Add(etiqueta_direccion);
            panel_principal.Controls.Add(entrada_minuto_entrega);
            panel_principal.Controls.Add(entrada_direccion);
            panel_principal.Controls.Add(panel5);
            panel_principal.Controls.Add(panel1);
            panel_principal.Controls.Add(entrada_hora_entrega);
            panel_principal.Controls.Add(etiqueta_hora_pedida);
            panel_principal.Controls.Add(etiqueta_hora_entrega);
            panel_principal.Controls.Add(entrada_hora_pedida);
            panel_principal.Controls.Add(label2);
            panel_principal.Controls.Add(panel2);
            panel_principal.Controls.Add(panel3);
            panel_principal.Controls.Add(entrada_minuto_pedido);
            panel_principal.Location = new Point(0, 60);
            panel_principal.Name = "panel_principal";
            panel_principal.Size = new Size(1521, 1028);
            panel_principal.TabIndex = 205;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(150, 100, 50);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(242, 225, 199);
            button1.Location = new Point(1114, 576);
            button1.Margin = new Padding(3, 3, 3, 30);
            button1.Name = "button1";
            button1.Size = new Size(261, 40);
            button1.TabIndex = 209;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(789, 552);
            label7.Name = "label7";
            label7.Size = new Size(159, 27);
            label7.TabIndex = 208;
            label7.Text = "Buscar menu";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_busqueda
            // 
            entrada_busqueda.BackColor = Color.FromArgb(242, 225, 199);
            entrada_busqueda.BorderStyle = BorderStyle.None;
            entrada_busqueda.Font = new Font("Montserrat", 15F);
            entrada_busqueda.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_busqueda.Location = new Point(789, 582);
            entrada_busqueda.Name = "entrada_busqueda";
            entrada_busqueda.Size = new Size(319, 25);
            entrada_busqueda.TabIndex = 206;
            entrada_busqueda.Text = "Lomo completo";
            entrada_busqueda.Enter += TodasLasEntradasNormales_Enter;
            entrada_busqueda.Leave += TodasLasEntradasNormales_Leave;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Enabled = false;
            panel7.Location = new Point(789, 611);
            panel7.Margin = new Padding(3, 3, 3, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(319, 2);
            panel7.TabIndex = 207;
            // 
            // panel_contenedor_menus
            // 
            panel_contenedor_menus.Location = new Point(166, 623);
            panel_contenedor_menus.Name = "panel_contenedor_menus";
            panel_contenedor_menus.Size = new Size(1209, 402);
            panel_contenedor_menus.TabIndex = 205;
            // 
            // AgregarOrden
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(1521, 1061);
            Controls.Add(panel_principal);
            Controls.Add(titulo_agregar);
            Font = new Font("Montserrat", 10F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarOrden";
            Text = "AgregarOrden";
            Resize += AgregarOrden_Resize;
            panel_pedido.ResumeLayout(false);
            panel6.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel_principal.ResumeLayout(false);
            panel_principal.PerformLayout();
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
        private Panel panel3;
        private TextBox entrada_minuto_pedido;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private TextBox entrada_minuto_entrega;
        private Panel panel5;
        private TextBox entrada_hora_entrega;
        private Label etiqueta_hora_entrega;
        private Label etiqueta_pedido;
        private FlowLayoutPanel panel_pedido;
        private Panel panel_principal;
        private Panel panel_contenedor_menus;
        private Button button1;
        private Label label7;
        private TextBox entrada_busqueda;
        private Panel panel7;
        private Panel panel6;
        private Panel panel8;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label4;
        private Label label1;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private Label label6;
    }
}