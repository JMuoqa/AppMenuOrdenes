namespace AppComida
{
    partial class VerOrdenes
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
            titulo_editar = new Label();
            entrada_estado = new ComboBox();
            linea_estado = new Panel();
            etiqueta_estado = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            etiqueta_id_nombre = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            etiqueta_hora_pedida = new Label();
            label2 = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            etiqeuta_nombre_pedido = new Label();
            etiqueta_cantidad_pedido = new Label();
            label1 = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            boton_anterior = new Button();
            comboBox1 = new ComboBox();
            boton_siguiente = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // titulo_editar
            // 
            titulo_editar.Anchor = AnchorStyles.Top;
            titulo_editar.AutoSize = true;
            titulo_editar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_editar.ForeColor = Color.Black;
            titulo_editar.Location = new Point(491, 9);
            titulo_editar.Name = "titulo_editar";
            titulo_editar.Size = new Size(228, 47);
            titulo_editar.TabIndex = 147;
            titulo_editar.Text = "Ver ordenes";
            // 
            // entrada_estado
            // 
            entrada_estado.Anchor = AnchorStyles.Top;
            entrada_estado.BackColor = Color.FromArgb(242, 225, 199);
            entrada_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            entrada_estado.FlatStyle = FlatStyle.Flat;
            entrada_estado.Font = new Font("Montserrat", 15F);
            entrada_estado.ForeColor = Color.Black;
            entrada_estado.FormattingEnabled = true;
            entrada_estado.Items.AddRange(new object[] { "TODOS", "Pendientes", "Confirmadas", "En preparación", "Listas", "Entregadas" });
            entrada_estado.Location = new Point(12, 101);
            entrada_estado.Name = "entrada_estado";
            entrada_estado.Size = new Size(319, 35);
            entrada_estado.TabIndex = 148;
            // 
            // linea_estado
            // 
            linea_estado.Anchor = AnchorStyles.Top;
            linea_estado.BackColor = Color.Black;
            linea_estado.Enabled = false;
            linea_estado.Location = new Point(12, 140);
            linea_estado.Margin = new Padding(3, 3, 3, 10);
            linea_estado.Name = "linea_estado";
            linea_estado.Size = new Size(319, 2);
            linea_estado.TabIndex = 150;
            // 
            // etiqueta_estado
            // 
            etiqueta_estado.Anchor = AnchorStyles.Top;
            etiqueta_estado.AutoSize = true;
            etiqueta_estado.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_estado.ForeColor = Color.Black;
            etiqueta_estado.Location = new Point(12, 71);
            etiqueta_estado.Name = "etiqueta_estado";
            etiqueta_estado.Size = new Size(99, 27);
            etiqueta_estado.TabIndex = 149;
            etiqueta_estado.Text = "Estados";
            etiqueta_estado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new Point(12, 173);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1188, 635);
            flowLayoutPanel1.TabIndex = 151;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(202, 185, 159);
            flowLayoutPanel2.Controls.Add(etiqueta_id_nombre);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(8, 8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5);
            flowLayoutPanel2.Size = new Size(518, 613);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // etiqueta_id_nombre
            // 
            etiqueta_id_nombre.Anchor = AnchorStyles.Top;
            etiqueta_id_nombre.AutoSize = true;
            etiqueta_id_nombre.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_id_nombre.ForeColor = Color.Black;
            etiqueta_id_nombre.Location = new Point(111, 5);
            etiqueta_id_nombre.Name = "etiqueta_id_nombre";
            etiqueta_id_nombre.Size = new Size(284, 27);
            etiqueta_id_nombre.TabIndex = 150;
            etiqueta_id_nombre.Text = "#1022 - Maximo Joaquin ";
            etiqueta_id_nombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label3);
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(label5);
            flowLayoutPanel5.Controls.Add(richTextBox1);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(8, 35);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(490, 362);
            flowLayoutPanel5.TabIndex = 153;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 5);
            label3.Margin = new Padding(3, 5, 3, 5);
            label3.Name = "label3";
            label3.Size = new Size(223, 22);
            label3.TabIndex = 154;
            label3.Text = "Domicilio: Avion pieza 2222";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 37);
            label4.Margin = new Padding(3, 5, 3, 5);
            label4.Name = "label4";
            label4.Size = new Size(179, 22);
            label4.TabIndex = 155;
            label4.Text = "Telefono: 3516668888";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 69);
            label5.Margin = new Padding(3, 5, 3, 5);
            label5.Name = "label5";
            label5.Size = new Size(128, 22);
            label5.TabIndex = 157;
            label5.Text = "Precio: $35000";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(212, 195, 169);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Montserrat", 15F);
            richTextBox1.Location = new Point(3, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(468, 132);
            richTextBox1.TabIndex = 158;
            richTextBox1.Text = "";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(etiqueta_hora_pedida);
            flowLayoutPanel6.Controls.Add(label2);
            flowLayoutPanel6.Location = new Point(3, 237);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(487, 35);
            flowLayoutPanel6.TabIndex = 156;
            // 
            // etiqueta_hora_pedida
            // 
            etiqueta_hora_pedida.AutoSize = true;
            etiqueta_hora_pedida.Font = new Font("Montserrat", 12F);
            etiqueta_hora_pedida.ForeColor = Color.Black;
            etiqueta_hora_pedida.Location = new Point(3, 5);
            etiqueta_hora_pedida.Margin = new Padding(3, 5, 3, 5);
            etiqueta_hora_pedida.Name = "etiqueta_hora_pedida";
            etiqueta_hora_pedida.Size = new Size(211, 22);
            etiqueta_hora_pedida.TabIndex = 152;
            etiqueta_hora_pedida.Text = "Hora de pedido:  20:10 HS";
            etiqueta_hora_pedida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(220, 5);
            label2.Margin = new Padding(3, 5, 3, 5);
            label2.Name = "label2";
            label2.Size = new Size(218, 22);
            label2.TabIndex = 153;
            label2.Text = "Hora de entrega:  20:55 HS";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(boton_anterior);
            flowLayoutPanel8.Controls.Add(comboBox1);
            flowLayoutPanel8.Controls.Add(boton_siguiente);
            flowLayoutPanel8.Location = new Point(3, 278);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(487, 51);
            flowLayoutPanel8.TabIndex = 159;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel3.Dock = DockStyle.Bottom;
            flowLayoutPanel3.Location = new Point(5, 400);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(496, 205);
            flowLayoutPanel3.TabIndex = 151;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(212, 195, 169);
            flowLayoutPanel4.Controls.Add(etiqeuta_nombre_pedido);
            flowLayoutPanel4.Controls.Add(etiqueta_cantidad_pedido);
            flowLayoutPanel4.Controls.Add(label1);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(0, 5);
            flowLayoutPanel4.Margin = new Padding(0, 5, 0, 5);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(474, 89);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // etiqeuta_nombre_pedido
            // 
            etiqeuta_nombre_pedido.AutoSize = true;
            etiqeuta_nombre_pedido.Font = new Font("Montserrat", 12F);
            etiqeuta_nombre_pedido.ForeColor = Color.Black;
            etiqeuta_nombre_pedido.Location = new Point(3, 0);
            etiqeuta_nombre_pedido.Name = "etiqeuta_nombre_pedido";
            etiqeuta_nombre_pedido.Size = new Size(137, 22);
            etiqeuta_nombre_pedido.TabIndex = 151;
            etiqeuta_nombre_pedido.Text = "Lomo completo";
            etiqeuta_nombre_pedido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_cantidad_pedido
            // 
            etiqueta_cantidad_pedido.AutoSize = true;
            etiqueta_cantidad_pedido.Font = new Font("Montserrat", 12F);
            etiqueta_cantidad_pedido.ForeColor = Color.Black;
            etiqueta_cantidad_pedido.Location = new Point(3, 27);
            etiqueta_cantidad_pedido.Margin = new Padding(3, 5, 3, 5);
            etiqueta_cantidad_pedido.Name = "etiqueta_cantidad_pedido";
            etiqueta_cantidad_pedido.Size = new Size(99, 22);
            etiqueta_cantidad_pedido.TabIndex = 152;
            etiqueta_cantidad_pedido.Text = "Cantidad: 2";
            etiqueta_cantidad_pedido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 59);
            label1.Margin = new Padding(3, 5, 3, 5);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 153;
            label1.Text = "Precio: $16000";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BackColor = Color.FromArgb(212, 195, 169);
            flowLayoutPanel7.Controls.Add(label6);
            flowLayoutPanel7.Controls.Add(label7);
            flowLayoutPanel7.Controls.Add(label8);
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Location = new Point(0, 104);
            flowLayoutPanel7.Margin = new Padding(0, 5, 0, 5);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(474, 89);
            flowLayoutPanel7.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(137, 22);
            label6.TabIndex = 151;
            label6.Text = "Lomo completo";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(3, 27);
            label7.Margin = new Padding(3, 5, 3, 5);
            label7.Name = "label7";
            label7.Size = new Size(99, 22);
            label7.TabIndex = 152;
            label7.Text = "Cantidad: 2";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(3, 59);
            label8.Margin = new Padding(3, 5, 3, 5);
            label8.Name = "label8";
            label8.Size = new Size(126, 22);
            label8.TabIndex = 153;
            label8.Text = "Precio: $16000";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // boton_anterior
            // 
            boton_anterior.BackColor = Color.FromArgb(150, 100, 50);
            boton_anterior.Cursor = Cursors.Hand;
            boton_anterior.FlatAppearance.BorderSize = 0;
            boton_anterior.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            boton_anterior.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            boton_anterior.FlatStyle = FlatStyle.Flat;
            boton_anterior.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_anterior.ForeColor = Color.FromArgb(242, 225, 199);
            boton_anterior.Location = new Point(3, 3);
            boton_anterior.Margin = new Padding(3, 3, 3, 30);
            boton_anterior.Name = "boton_anterior";
            boton_anterior.Size = new Size(138, 40);
            boton_anterior.TabIndex = 187;
            boton_anterior.Text = "Anterior";
            boton_anterior.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.BackColor = Color.FromArgb(202, 185, 159);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Montserrat", 15F);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "TODOS", "Pendientes", "Confirmadas", "En preparación", "Listas", "Entregadas" });
            comboBox1.Location = new Point(147, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 35);
            comboBox1.TabIndex = 188;
            // 
            // boton_siguiente
            // 
            boton_siguiente.BackColor = Color.FromArgb(150, 100, 50);
            boton_siguiente.Cursor = Cursors.Hand;
            boton_siguiente.FlatAppearance.BorderSize = 0;
            boton_siguiente.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            boton_siguiente.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            boton_siguiente.FlatStyle = FlatStyle.Flat;
            boton_siguiente.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_siguiente.ForeColor = Color.FromArgb(242, 225, 199);
            boton_siguiente.Location = new Point(336, 3);
            boton_siguiente.Margin = new Padding(3, 3, 3, 30);
            boton_siguiente.Name = "boton_siguiente";
            boton_siguiente.Size = new Size(138, 40);
            boton_siguiente.TabIndex = 189;
            boton_siguiente.Text = "Siguiente";
            boton_siguiente.UseVisualStyleBackColor = false;
            // 
            // VerOrdenes
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(1212, 858);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(entrada_estado);
            Controls.Add(linea_estado);
            Controls.Add(etiqueta_estado);
            Controls.Add(titulo_editar);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VerOrdenes";
            Text = "VerOrden";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo_editar;
        private ComboBox entrada_estado;
        private Panel linea_estado;
        private Label etiqueta_estado;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label etiqueta_id_nombre;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label etiqeuta_nombre_pedido;
        private Label etiqueta_cantidad_pedido;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label etiqueta_hora_pedida;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label6;
        private Label label7;
        private Label label8;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel flowLayoutPanel8;
        private Button boton_anterior;
        private ComboBox comboBox1;
        private Button boton_siguiente;
    }
}