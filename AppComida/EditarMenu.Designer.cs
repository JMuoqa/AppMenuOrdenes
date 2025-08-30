namespace ControlDeProyectos
{
    partial class EditarMenu
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
            linea_precio = new Panel();
            entrada_precio = new TextBox();
            entrada_tipo = new ComboBox();
            linea_tipo = new Panel();
            linea_descripcion2 = new Panel();
            linea_descripcion = new Panel();
            entrada_descripcion = new RichTextBox();
            linea_cliente = new Panel();
            entrada_menu = new TextBox();
            etiqueta_tipo = new Label();
            etiqueta_precio = new Label();
            etiqueta_descripcion = new Label();
            etiqueta_cliente = new Label();
            titulo_editar = new Label();
            linea_id = new Panel();
            entrada_busuqeda = new TextBox();
            etiqueta_buscar = new Label();
            boton_buscar = new Button();
            label2 = new Label();
            menu_seleccionado = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            resultados_busqueda = new DataGridView();
            panel_abajo = new Panel();
            panel_arriba = new Panel();
            ((System.ComponentModel.ISupportInitialize)resultados_busqueda).BeginInit();
            panel_abajo.SuspendLayout();
            panel_arriba.SuspendLayout();
            SuspendLayout();
            // 
            // linea_precio
            // 
            linea_precio.Anchor = AnchorStyles.Top;
            linea_precio.BackColor = Color.Black;
            linea_precio.Enabled = false;
            linea_precio.Location = new Point(516, 134);
            linea_precio.Margin = new Padding(3, 3, 3, 10);
            linea_precio.Name = "linea_precio";
            linea_precio.Size = new Size(319, 1);
            linea_precio.TabIndex = 144;
            // 
            // entrada_precio
            // 
            entrada_precio.Anchor = AnchorStyles.Top;
            entrada_precio.BackColor = Color.FromArgb(242, 225, 199);
            entrada_precio.BorderStyle = BorderStyle.None;
            entrada_precio.Font = new Font("Montserrat", 15F);
            entrada_precio.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_precio.Location = new Point(516, 105);
            entrada_precio.Name = "entrada_precio";
            entrada_precio.Size = new Size(319, 25);
            entrada_precio.TabIndex = 132;
            entrada_precio.Text = "Buscá un menú arriba";
            entrada_precio.Enter += TodasLasEntradasNormales_Enter;
            entrada_precio.Leave += TodasLasEntradasNormales_Leave;
            // 
            // entrada_tipo
            // 
            entrada_tipo.Anchor = AnchorStyles.Top;
            entrada_tipo.BackColor = Color.FromArgb(242, 225, 199);
            entrada_tipo.FlatStyle = FlatStyle.Flat;
            entrada_tipo.Font = new Font("Montserrat", 15F);
            entrada_tipo.ForeColor = Color.White;
            entrada_tipo.FormattingEnabled = true;
            entrada_tipo.Items.AddRange(new object[] { "Pagian Web", "Aplicacion de escritorio" });
            entrada_tipo.Location = new Point(126, 475);
            entrada_tipo.Name = "entrada_tipo";
            entrada_tipo.Size = new Size(319, 35);
            entrada_tipo.TabIndex = 125;
            entrada_tipo.Enter += TodasLasEntradasNormales_Enter;
            entrada_tipo.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_tipo
            // 
            linea_tipo.Anchor = AnchorStyles.Top;
            linea_tipo.BackColor = Color.Black;
            linea_tipo.Enabled = false;
            linea_tipo.Location = new Point(126, 514);
            linea_tipo.Margin = new Padding(3, 3, 3, 10);
            linea_tipo.Name = "linea_tipo";
            linea_tipo.Size = new Size(319, 1);
            linea_tipo.TabIndex = 139;
            // 
            // linea_descripcion2
            // 
            linea_descripcion2.Anchor = AnchorStyles.Top;
            linea_descripcion2.BackColor = Color.Black;
            linea_descripcion2.Enabled = false;
            linea_descripcion2.Location = new Point(126, 437);
            linea_descripcion2.Margin = new Padding(3, 3, 3, 10);
            linea_descripcion2.Name = "linea_descripcion2";
            linea_descripcion2.Size = new Size(319, 1);
            linea_descripcion2.TabIndex = 138;
            // 
            // linea_descripcion
            // 
            linea_descripcion.Anchor = AnchorStyles.Top;
            linea_descripcion.BackColor = Color.Black;
            linea_descripcion.Enabled = false;
            linea_descripcion.Location = new Point(126, 187);
            linea_descripcion.Margin = new Padding(3, 3, 3, 10);
            linea_descripcion.Name = "linea_descripcion";
            linea_descripcion.Size = new Size(319, 1);
            linea_descripcion.TabIndex = 137;
            // 
            // entrada_descripcion
            // 
            entrada_descripcion.Anchor = AnchorStyles.Top;
            entrada_descripcion.BackColor = Color.FromArgb(222, 205, 179);
            entrada_descripcion.BorderStyle = BorderStyle.None;
            entrada_descripcion.Font = new Font("Montserrat", 15F);
            entrada_descripcion.ForeColor = Color.White;
            entrada_descripcion.Location = new Point(126, 194);
            entrada_descripcion.MaxLength = 350;
            entrada_descripcion.Name = "entrada_descripcion";
            entrada_descripcion.Size = new Size(319, 240);
            entrada_descripcion.TabIndex = 123;
            entrada_descripcion.Text = "";
            // 
            // linea_cliente
            // 
            linea_cliente.Anchor = AnchorStyles.Top;
            linea_cliente.BackColor = Color.Black;
            linea_cliente.Enabled = false;
            linea_cliente.Location = new Point(126, 137);
            linea_cliente.Margin = new Padding(3, 3, 3, 10);
            linea_cliente.Name = "linea_cliente";
            linea_cliente.Size = new Size(319, 1);
            linea_cliente.TabIndex = 134;
            // 
            // entrada_menu
            // 
            entrada_menu.Anchor = AnchorStyles.Top;
            entrada_menu.BackColor = Color.FromArgb(242, 225, 199);
            entrada_menu.BorderStyle = BorderStyle.None;
            entrada_menu.Font = new Font("Montserrat", 15F);
            entrada_menu.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_menu.Location = new Point(126, 108);
            entrada_menu.Name = "entrada_menu";
            entrada_menu.Size = new Size(319, 25);
            entrada_menu.TabIndex = 119;
            entrada_menu.Text = "Buscá un menú arriba";
            entrada_menu.Enter += TodasLasEntradasNormales_Enter;
            entrada_menu.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_tipo
            // 
            etiqueta_tipo.Anchor = AnchorStyles.Top;
            etiqueta_tipo.AutoSize = true;
            etiqueta_tipo.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_tipo.ForeColor = Color.Black;
            etiqueta_tipo.Location = new Point(126, 448);
            etiqueta_tipo.Name = "etiqueta_tipo";
            etiqueta_tipo.Size = new Size(164, 27);
            etiqueta_tipo.TabIndex = 129;
            etiqueta_tipo.Text = "Tipo de Menu";
            etiqueta_tipo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_precio
            // 
            etiqueta_precio.Anchor = AnchorStyles.Top;
            etiqueta_precio.AutoSize = true;
            etiqueta_precio.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_precio.ForeColor = Color.Black;
            etiqueta_precio.Location = new Point(516, 78);
            etiqueta_precio.Name = "etiqueta_precio";
            etiqueta_precio.Size = new Size(82, 27);
            etiqueta_precio.TabIndex = 124;
            etiqueta_precio.Text = "Precio";
            // 
            // etiqueta_descripcion
            // 
            etiqueta_descripcion.Anchor = AnchorStyles.Top;
            etiqueta_descripcion.AutoSize = true;
            etiqueta_descripcion.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_descripcion.ForeColor = Color.Black;
            etiqueta_descripcion.ImageAlign = ContentAlignment.MiddleLeft;
            etiqueta_descripcion.Location = new Point(126, 148);
            etiqueta_descripcion.Name = "etiqueta_descripcion";
            etiqueta_descripcion.Size = new Size(154, 27);
            etiqueta_descripcion.TabIndex = 118;
            etiqueta_descripcion.Text = "Ingredientes";
            etiqueta_descripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_cliente
            // 
            etiqueta_cliente.Anchor = AnchorStyles.Top;
            etiqueta_cliente.AutoSize = true;
            etiqueta_cliente.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_cliente.ForeColor = Color.Black;
            etiqueta_cliente.Location = new Point(126, 78);
            etiqueta_cliente.Name = "etiqueta_cliente";
            etiqueta_cliente.Size = new Size(225, 27);
            etiqueta_cliente.TabIndex = 135;
            etiqueta_cliente.Text = "Nombre del cliente";
            etiqueta_cliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // titulo_editar
            // 
            titulo_editar.Anchor = AnchorStyles.Top;
            titulo_editar.AutoSize = true;
            titulo_editar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_editar.ForeColor = Color.Black;
            titulo_editar.Location = new Point(352, 9);
            titulo_editar.Name = "titulo_editar";
            titulo_editar.Size = new Size(237, 47);
            titulo_editar.TabIndex = 146;
            titulo_editar.Text = "Editar menu";
            // 
            // linea_id
            // 
            linea_id.Anchor = AnchorStyles.Top;
            linea_id.BackColor = Color.Black;
            linea_id.Enabled = false;
            linea_id.Location = new Point(127, 71);
            linea_id.Margin = new Padding(3, 3, 3, 30);
            linea_id.Name = "linea_id";
            linea_id.Size = new Size(319, 1);
            linea_id.TabIndex = 148;
            // 
            // entrada_busuqeda
            // 
            entrada_busuqeda.Anchor = AnchorStyles.Top;
            entrada_busuqeda.BackColor = Color.FromArgb(242, 225, 199);
            entrada_busuqeda.BorderStyle = BorderStyle.None;
            entrada_busuqeda.Font = new Font("Montserrat", 15F);
            entrada_busuqeda.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_busuqeda.Location = new Point(127, 40);
            entrada_busuqeda.Name = "entrada_busuqeda";
            entrada_busuqeda.Size = new Size(319, 25);
            entrada_busuqeda.TabIndex = 147;
            entrada_busuqeda.Text = "#7/Lomo completo";
            entrada_busuqeda.TextChanged += entrada_busuqeda_TextChanged;
            entrada_busuqeda.Enter += TodasLasEntradasNormales_Enter;
            entrada_busuqeda.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_buscar
            // 
            etiqueta_buscar.Anchor = AnchorStyles.Top;
            etiqueta_buscar.AutoSize = true;
            etiqueta_buscar.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_buscar.ForeColor = Color.Black;
            etiqueta_buscar.Location = new Point(127, 10);
            etiqueta_buscar.Name = "etiqueta_buscar";
            etiqueta_buscar.Size = new Size(125, 27);
            etiqueta_buscar.TabIndex = 149;
            etiqueta_buscar.Text = "Busqueda";
            etiqueta_buscar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // boton_buscar
            // 
            boton_buscar.Anchor = AnchorStyles.Top;
            boton_buscar.BackColor = Color.FromArgb(150, 100, 50);
            boton_buscar.Cursor = Cursors.Hand;
            boton_buscar.FlatAppearance.BorderSize = 0;
            boton_buscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            boton_buscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            boton_buscar.FlatStyle = FlatStyle.Flat;
            boton_buscar.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_buscar.ForeColor = Color.FromArgb(242, 225, 199);
            boton_buscar.Location = new Point(517, 34);
            boton_buscar.Margin = new Padding(3, 3, 3, 30);
            boton_buscar.Name = "boton_buscar";
            boton_buscar.Size = new Size(319, 40);
            boton_buscar.TabIndex = 154;
            boton_buscar.Text = "Buscar";
            boton_buscar.UseVisualStyleBackColor = false;
            boton_buscar.Click += boton_buscar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(126, 23);
            label2.Name = "label2";
            label2.Size = new Size(233, 27);
            label2.TabIndex = 155;
            label2.Text = "Menú seleccionado:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menu_seleccionado
            // 
            menu_seleccionado.Anchor = AnchorStyles.Top;
            menu_seleccionado.AutoSize = true;
            menu_seleccionado.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu_seleccionado.ForeColor = Color.Black;
            menu_seleccionado.Location = new Point(400, 23);
            menu_seleccionado.Name = "menu_seleccionado";
            menu_seleccionado.Size = new Size(110, 27);
            menu_seleccionado.TabIndex = 156;
            menu_seleccionado.Text = "Ninguno";
            menu_seleccionado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(150, 100, 50);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(242, 225, 199);
            button1.Location = new Point(516, 148);
            button1.Margin = new Padding(3, 3, 3, 30);
            button1.Name = "button1";
            button1.Size = new Size(319, 40);
            button1.TabIndex = 158;
            button1.Text = "Confirmar cambios";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.FromArgb(150, 100, 50);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(220, 0, 0);
            button2.Location = new Point(516, 202);
            button2.Margin = new Padding(3, 3, 3, 30);
            button2.Name = "button2";
            button2.Size = new Size(319, 40);
            button2.TabIndex = 159;
            button2.Text = "Vaciar datos";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Enabled = false;
            panel1.Location = new Point(1, 534);
            panel1.Margin = new Padding(3, 3, 3, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 2);
            panel1.TabIndex = 160;
            // 
            // resultados_busqueda
            // 
            resultados_busqueda.Anchor = AnchorStyles.Top;
            resultados_busqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultados_busqueda.Location = new Point(12, 88);
            resultados_busqueda.Name = "resultados_busqueda";
            resultados_busqueda.ReadOnly = true;
            resultados_busqueda.Size = new Size(899, 300);
            resultados_busqueda.TabIndex = 161;
            resultados_busqueda.CellClick += resultados_busqueda_CellClick;
            // 
            // panel_abajo
            // 
            panel_abajo.Controls.Add(label2);
            panel_abajo.Controls.Add(etiqueta_cliente);
            panel_abajo.Controls.Add(etiqueta_descripcion);
            panel_abajo.Controls.Add(button2);
            panel_abajo.Controls.Add(etiqueta_precio);
            panel_abajo.Controls.Add(button1);
            panel_abajo.Controls.Add(etiqueta_tipo);
            panel_abajo.Controls.Add(menu_seleccionado);
            panel_abajo.Controls.Add(entrada_menu);
            panel_abajo.Controls.Add(linea_cliente);
            panel_abajo.Controls.Add(entrada_descripcion);
            panel_abajo.Controls.Add(linea_descripcion);
            panel_abajo.Controls.Add(linea_descripcion2);
            panel_abajo.Controls.Add(linea_tipo);
            panel_abajo.Controls.Add(entrada_tipo);
            panel_abajo.Controls.Add(linea_precio);
            panel_abajo.Controls.Add(entrada_precio);
            panel_abajo.Location = new Point(0, 501);
            panel_abajo.Name = "panel_abajo";
            panel_abajo.Size = new Size(943, 526);
            panel_abajo.TabIndex = 162;
            // 
            // panel_arriba
            // 
            panel_arriba.Controls.Add(etiqueta_buscar);
            panel_arriba.Controls.Add(entrada_busuqeda);
            panel_arriba.Controls.Add(resultados_busqueda);
            panel_arriba.Controls.Add(linea_id);
            panel_arriba.Controls.Add(boton_buscar);
            panel_arriba.Location = new Point(0, 59);
            panel_arriba.Name = "panel_arriba";
            panel_arriba.Size = new Size(943, 400);
            panel_arriba.TabIndex = 163;
            // 
            // EditarMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(943, 1009);
            Controls.Add(panel_arriba);
            Controls.Add(panel_abajo);
            Controls.Add(panel1);
            Controls.Add(titulo_editar);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditarMenu";
            Text = "EditarProyecto";
            Resize += EditarMenu_Resize;
            ((System.ComponentModel.ISupportInitialize)resultados_busqueda).EndInit();
            panel_abajo.ResumeLayout(false);
            panel_abajo.PerformLayout();
            panel_arriba.ResumeLayout(false);
            panel_arriba.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel linea_precio;
        private TextBox entrada_precio;
        private ComboBox entrada_tipo;
        private Panel linea_tipo;
        private Panel linea_descripcion2;
        private Panel linea_descripcion;
        private RichTextBox entrada_descripcion;
        private Panel linea_cliente;
        private TextBox entrada_menu;
        private Label etiqueta_tipo;
        private Label etiqueta_precio;
        private Label etiqueta_descripcion;
        private Label etiqueta_cliente;
        private Label titulo_editar;
        private Panel linea_id;
        private TextBox entrada_busuqeda;
        private Label etiqueta_buscar;
        private ComboBox comboBox1;
        private Label label1;
        private Button boton_buscar;
        private Label label2;
        private Label menu_seleccionado;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private DataGridView resultados_busqueda;
        private Panel panel_abajo;
        private Panel panel_arriba;
    }
}