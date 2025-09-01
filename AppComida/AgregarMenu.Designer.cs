namespace ControlDeProyectos
{
    partial class AgregarMenu
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
            etiqueta_ingredientes = new Label();
            etiqueta_menu = new Label();
            etiqueta_precio = new Label();
            titulo_cargar = new Label();
            etiqueta_tipo = new Label();
            entrada_menu = new TextBox();
            linea_menu = new Panel();
            entrada_ingredientes = new RichTextBox();
            linea_ingredientes_sup = new Panel();
            linea_ingredientes_inf = new Panel();
            linea_tipo = new Panel();
            entrada_tipo = new ComboBox();
            linea_precio = new Panel();
            entrada_precio = new TextBox();
            boton_confirmar = new Button();
            boton_agregar_tipo = new Button();
            linea_agregar_tipo = new Panel();
            entrada_agregar_tipo = new TextBox();
            etiqueta_agregar_tipo = new Label();
            boton_cancelar_tipo = new Button();
            Info = new Label();
            Info2 = new Label();
            SuspendLayout();
            // 
            // etiqueta_ingredientes
            // 
            etiqueta_ingredientes.Anchor = AnchorStyles.Top;
            etiqueta_ingredientes.AutoSize = true;
            etiqueta_ingredientes.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_ingredientes.ForeColor = Color.Black;
            etiqueta_ingredientes.ImageAlign = ContentAlignment.MiddleLeft;
            etiqueta_ingredientes.Location = new Point(113, 169);
            etiqueta_ingredientes.Name = "etiqueta_ingredientes";
            etiqueta_ingredientes.Size = new Size(154, 27);
            etiqueta_ingredientes.TabIndex = 7;
            etiqueta_ingredientes.Text = "Ingredientes";
            etiqueta_ingredientes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_menu
            // 
            etiqueta_menu.Anchor = AnchorStyles.Top;
            etiqueta_menu.AutoSize = true;
            etiqueta_menu.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_menu.ForeColor = Color.Black;
            etiqueta_menu.Location = new Point(113, 99);
            etiqueta_menu.Name = "etiqueta_menu";
            etiqueta_menu.Size = new Size(214, 27);
            etiqueta_menu.TabIndex = 99;
            etiqueta_menu.Text = "Nombre del menu";
            etiqueta_menu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_precio
            // 
            etiqueta_precio.Anchor = AnchorStyles.Top;
            etiqueta_precio.AutoSize = true;
            etiqueta_precio.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_precio.ForeColor = Color.Black;
            etiqueta_precio.Location = new Point(503, 99);
            etiqueta_precio.Name = "etiqueta_precio";
            etiqueta_precio.Size = new Size(82, 27);
            etiqueta_precio.TabIndex = 11;
            etiqueta_precio.Text = "Precio";
            // 
            // titulo_cargar
            // 
            titulo_cargar.Anchor = AnchorStyles.Top;
            titulo_cargar.AutoSize = true;
            titulo_cargar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_cargar.ForeColor = Color.Black;
            titulo_cargar.Location = new Point(277, 9);
            titulo_cargar.Name = "titulo_cargar";
            titulo_cargar.Size = new Size(367, 47);
            titulo_cargar.TabIndex = 13;
            titulo_cargar.Text = "Cargar menu nuevo";
            // 
            // etiqueta_tipo
            // 
            etiqueta_tipo.Anchor = AnchorStyles.Top;
            etiqueta_tipo.AutoSize = true;
            etiqueta_tipo.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_tipo.ForeColor = Color.Black;
            etiqueta_tipo.Location = new Point(113, 469);
            etiqueta_tipo.Name = "etiqueta_tipo";
            etiqueta_tipo.Size = new Size(184, 27);
            etiqueta_tipo.TabIndex = 14;
            etiqueta_tipo.Text = "Tipo de comida";
            etiqueta_tipo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entrada_menu
            // 
            entrada_menu.Anchor = AnchorStyles.Top;
            entrada_menu.BackColor = Color.FromArgb(242, 225, 199);
            entrada_menu.BorderStyle = BorderStyle.None;
            entrada_menu.Font = new Font("Montserrat", 15F);
            entrada_menu.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_menu.Location = new Point(113, 129);
            entrada_menu.Name = "entrada_menu";
            entrada_menu.Size = new Size(319, 25);
            entrada_menu.TabIndex = 8;
            entrada_menu.Text = "Lomo completo";
            entrada_menu.Enter += TodasLasEntradasNormales_Enter;
            entrada_menu.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_menu
            // 
            linea_menu.Anchor = AnchorStyles.Top;
            linea_menu.BackColor = Color.Black;
            linea_menu.Enabled = false;
            linea_menu.Location = new Point(113, 158);
            linea_menu.Margin = new Padding(3, 3, 3, 10);
            linea_menu.Name = "linea_menu";
            linea_menu.Size = new Size(319, 2);
            linea_menu.TabIndex = 17;
            // 
            // entrada_ingredientes
            // 
            entrada_ingredientes.Anchor = AnchorStyles.Top;
            entrada_ingredientes.BackColor = Color.FromArgb(222, 205, 179);
            entrada_ingredientes.BorderStyle = BorderStyle.None;
            entrada_ingredientes.Font = new Font("Montserrat", 15F);
            entrada_ingredientes.ForeColor = Color.Black;
            entrada_ingredientes.Location = new Point(113, 215);
            entrada_ingredientes.MaxLength = 350;
            entrada_ingredientes.Name = "entrada_ingredientes";
            entrada_ingredientes.Size = new Size(319, 237);
            entrada_ingredientes.TabIndex = 10;
            entrada_ingredientes.Text = "";
            // 
            // linea_ingredientes_sup
            // 
            linea_ingredientes_sup.Anchor = AnchorStyles.Top;
            linea_ingredientes_sup.BackColor = Color.Black;
            linea_ingredientes_sup.Enabled = false;
            linea_ingredientes_sup.Location = new Point(113, 208);
            linea_ingredientes_sup.Margin = new Padding(3, 3, 3, 10);
            linea_ingredientes_sup.Name = "linea_ingredientes_sup";
            linea_ingredientes_sup.Size = new Size(319, 2);
            linea_ingredientes_sup.TabIndex = 102;
            // 
            // linea_ingredientes_inf
            // 
            linea_ingredientes_inf.Anchor = AnchorStyles.Top;
            linea_ingredientes_inf.BackColor = Color.Black;
            linea_ingredientes_inf.Enabled = false;
            linea_ingredientes_inf.Location = new Point(113, 458);
            linea_ingredientes_inf.Margin = new Padding(3, 3, 3, 10);
            linea_ingredientes_inf.Name = "linea_ingredientes_inf";
            linea_ingredientes_inf.Size = new Size(319, 2);
            linea_ingredientes_inf.TabIndex = 103;
            // 
            // linea_tipo
            // 
            linea_tipo.Anchor = AnchorStyles.Top;
            linea_tipo.BackColor = Color.Black;
            linea_tipo.Enabled = false;
            linea_tipo.Location = new Point(113, 538);
            linea_tipo.Margin = new Padding(3, 3, 3, 10);
            linea_tipo.Name = "linea_tipo";
            linea_tipo.Size = new Size(319, 2);
            linea_tipo.TabIndex = 105;
            // 
            // entrada_tipo
            // 
            entrada_tipo.Anchor = AnchorStyles.Top;
            entrada_tipo.BackColor = Color.FromArgb(242, 225, 199);
            entrada_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            entrada_tipo.FlatStyle = FlatStyle.Flat;
            entrada_tipo.Font = new Font("Montserrat", 15F);
            entrada_tipo.ForeColor = Color.Black;
            entrada_tipo.FormattingEnabled = true;
            entrada_tipo.Location = new Point(113, 499);
            entrada_tipo.Name = "entrada_tipo";
            entrada_tipo.Size = new Size(319, 35);
            entrada_tipo.TabIndex = 11;
            // 
            // linea_precio
            // 
            linea_precio.Anchor = AnchorStyles.Top;
            linea_precio.BackColor = Color.Black;
            linea_precio.Enabled = false;
            linea_precio.Location = new Point(503, 158);
            linea_precio.Margin = new Padding(3, 3, 3, 10);
            linea_precio.Name = "linea_precio";
            linea_precio.Size = new Size(319, 2);
            linea_precio.TabIndex = 114;
            // 
            // entrada_precio
            // 
            entrada_precio.Anchor = AnchorStyles.Top;
            entrada_precio.BackColor = Color.FromArgb(242, 225, 199);
            entrada_precio.BorderStyle = BorderStyle.None;
            entrada_precio.Font = new Font("Montserrat", 15F);
            entrada_precio.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_precio.Location = new Point(503, 129);
            entrada_precio.Name = "entrada_precio";
            entrada_precio.Size = new Size(319, 25);
            entrada_precio.TabIndex = 12;
            entrada_precio.Text = "$12000";
            entrada_precio.TextChanged += entrada_precio_TextChanged;
            entrada_precio.Enter += TodasLasEntradasNormales_Enter;
            entrada_precio.KeyPress += entrada_precio_KeyPress;
            entrada_precio.Leave += TodasLasEntradasNormales_Leave;
            // 
            // boton_confirmar
            // 
            boton_confirmar.Anchor = AnchorStyles.Top;
            boton_confirmar.BackColor = Color.FromArgb(150, 100, 50);
            boton_confirmar.Cursor = Cursors.Hand;
            boton_confirmar.FlatAppearance.BorderSize = 0;
            boton_confirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            boton_confirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            boton_confirmar.FlatStyle = FlatStyle.Flat;
            boton_confirmar.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_confirmar.ForeColor = Color.FromArgb(242, 225, 199);
            boton_confirmar.Location = new Point(503, 172);
            boton_confirmar.Margin = new Padding(3, 3, 3, 30);
            boton_confirmar.Name = "boton_confirmar";
            boton_confirmar.Size = new Size(319, 40);
            boton_confirmar.TabIndex = 15;
            boton_confirmar.Text = "Confirmar";
            boton_confirmar.UseVisualStyleBackColor = false;
            boton_confirmar.Click += boton_confirmar_Click;
            // 
            // boton_agregar_tipo
            // 
            boton_agregar_tipo.Anchor = AnchorStyles.Top;
            boton_agregar_tipo.BackColor = Color.FromArgb(150, 100, 50);
            boton_agregar_tipo.Cursor = Cursors.Hand;
            boton_agregar_tipo.FlatAppearance.BorderSize = 0;
            boton_agregar_tipo.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            boton_agregar_tipo.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            boton_agregar_tipo.FlatStyle = FlatStyle.Flat;
            boton_agregar_tipo.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_agregar_tipo.ForeColor = Color.FromArgb(242, 225, 199);
            boton_agregar_tipo.Location = new Point(113, 622);
            boton_agregar_tipo.Margin = new Padding(3, 3, 3, 30);
            boton_agregar_tipo.Name = "boton_agregar_tipo";
            boton_agregar_tipo.Size = new Size(319, 40);
            boton_agregar_tipo.TabIndex = 14;
            boton_agregar_tipo.Text = "Agregar nuevo tipo";
            boton_agregar_tipo.UseVisualStyleBackColor = false;
            boton_agregar_tipo.Click += boton_agregar_tipo_Click;
            // 
            // linea_agregar_tipo
            // 
            linea_agregar_tipo.Anchor = AnchorStyles.Top;
            linea_agregar_tipo.BackColor = Color.Black;
            linea_agregar_tipo.Enabled = false;
            linea_agregar_tipo.Location = new Point(113, 608);
            linea_agregar_tipo.Margin = new Padding(3, 3, 3, 10);
            linea_agregar_tipo.Name = "linea_agregar_tipo";
            linea_agregar_tipo.Size = new Size(319, 2);
            linea_agregar_tipo.TabIndex = 180;
            // 
            // entrada_agregar_tipo
            // 
            entrada_agregar_tipo.Anchor = AnchorStyles.Top;
            entrada_agregar_tipo.BackColor = Color.FromArgb(242, 225, 199);
            entrada_agregar_tipo.BorderStyle = BorderStyle.None;
            entrada_agregar_tipo.Font = new Font("Montserrat", 15F);
            entrada_agregar_tipo.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_agregar_tipo.Location = new Point(113, 579);
            entrada_agregar_tipo.Name = "entrada_agregar_tipo";
            entrada_agregar_tipo.Size = new Size(319, 25);
            entrada_agregar_tipo.TabIndex = 13;
            entrada_agregar_tipo.Text = "Empanada/Lomopizza";
            entrada_agregar_tipo.Enter += TodasLasEntradasNormales_Enter;
            entrada_agregar_tipo.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_agregar_tipo
            // 
            etiqueta_agregar_tipo.Anchor = AnchorStyles.Top;
            etiqueta_agregar_tipo.AutoSize = true;
            etiqueta_agregar_tipo.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_agregar_tipo.ForeColor = Color.Black;
            etiqueta_agregar_tipo.Location = new Point(113, 549);
            etiqueta_agregar_tipo.Name = "etiqueta_agregar_tipo";
            etiqueta_agregar_tipo.Size = new Size(228, 27);
            etiqueta_agregar_tipo.TabIndex = 181;
            etiqueta_agregar_tipo.Text = "Agregar nuevo tipo";
            etiqueta_agregar_tipo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // boton_cancelar_tipo
            // 
            boton_cancelar_tipo.Anchor = AnchorStyles.Top;
            boton_cancelar_tipo.BackColor = Color.FromArgb(150, 100, 50);
            boton_cancelar_tipo.Cursor = Cursors.Hand;
            boton_cancelar_tipo.FlatAppearance.BorderSize = 0;
            boton_cancelar_tipo.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 80, 40);
            boton_cancelar_tipo.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 120, 70);
            boton_cancelar_tipo.FlatStyle = FlatStyle.Flat;
            boton_cancelar_tipo.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_cancelar_tipo.ForeColor = Color.FromArgb(242, 225, 199);
            boton_cancelar_tipo.Location = new Point(438, 573);
            boton_cancelar_tipo.Margin = new Padding(3, 3, 3, 30);
            boton_cancelar_tipo.Name = "boton_cancelar_tipo";
            boton_cancelar_tipo.Size = new Size(116, 40);
            boton_cancelar_tipo.TabIndex = 16;
            boton_cancelar_tipo.Text = "Cancelar";
            boton_cancelar_tipo.UseVisualStyleBackColor = false;
            boton_cancelar_tipo.Click += boton_cancelar_tipo_Click;
            // 
            // Info
            // 
            Info.AllowDrop = true;
            Info.Anchor = AnchorStyles.Top;
            Info.AutoEllipsis = true;
            Info.AutoSize = true;
            Info.Location = new Point(113, 667);
            Info.Name = "Info";
            Info.Size = new Size(368, 20);
            Info.TabIndex = 183;
            Info.Text = "Si le das de vuelta al boton, agregaras solo el \"Tipo\".";
            // 
            // Info2
            // 
            Info2.AllowDrop = true;
            Info2.Anchor = AnchorStyles.Top;
            Info2.AutoEllipsis = true;
            Info2.AutoSize = true;
            Info2.Location = new Point(113, 692);
            Info2.Name = "Info2";
            Info2.Size = new Size(480, 20);
            Info2.TabIndex = 184;
            Info2.Text = "En cambio si le das a confirmar cargaras ambos (El menu y el tipo).";
            // 
            // AgregarMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(933, 742);
            Controls.Add(Info2);
            Controls.Add(Info);
            Controls.Add(boton_cancelar_tipo);
            Controls.Add(linea_agregar_tipo);
            Controls.Add(entrada_agregar_tipo);
            Controls.Add(etiqueta_agregar_tipo);
            Controls.Add(boton_agregar_tipo);
            Controls.Add(boton_confirmar);
            Controls.Add(linea_precio);
            Controls.Add(entrada_precio);
            Controls.Add(entrada_tipo);
            Controls.Add(linea_tipo);
            Controls.Add(linea_ingredientes_inf);
            Controls.Add(linea_ingredientes_sup);
            Controls.Add(entrada_ingredientes);
            Controls.Add(linea_menu);
            Controls.Add(entrada_menu);
            Controls.Add(etiqueta_tipo);
            Controls.Add(titulo_cargar);
            Controls.Add(etiqueta_precio);
            Controls.Add(etiqueta_ingredientes);
            Controls.Add(etiqueta_menu);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarMenu";
            Text = "AgregarProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label etiqueta_ingredientes;
        private Label etiqueta_menu;
        private Label etiqueta_precio;
        private Label titulo_cargar;
        private Label etiqueta_tipo;
        private TextBox entrada_menu;
        private Panel linea_menu;
        private RichTextBox entrada_ingredientes;
        private Panel linea_ingredientes_sup;
        private Panel linea_ingredientes_inf;
        private Panel linea_tipo;
        private ComboBox entrada_tipo;
        private Panel linea_precio;
        private TextBox entrada_precio;
        private Button boton_confirmar;
        private Button boton_agregar_tipo;
        private Panel linea_agregar_tipo;
        private TextBox entrada_agregar_tipo;
        private Label etiqueta_agregar_tipo;
        private Button boton_cancelar_tipo;
        private Label Info;
        private Label Info2;
    }
}