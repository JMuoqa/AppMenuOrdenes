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
            entrada_ver_por_estados = new ComboBox();
            linea_estado = new Panel();
            etiqueta_estado = new Label();
            contenedor_principal_ordenes = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // titulo_editar
            // 
            titulo_editar.Anchor = AnchorStyles.Top;
            titulo_editar.AutoSize = true;
            titulo_editar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_editar.ForeColor = Color.Black;
            titulo_editar.Location = new Point(501, 9);
            titulo_editar.Name = "titulo_editar";
            titulo_editar.Size = new Size(228, 47);
            titulo_editar.TabIndex = 147;
            titulo_editar.Text = "Ver ordenes";
            // 
            // entrada_ver_por_estados
            // 
            entrada_ver_por_estados.BackColor = Color.FromArgb(242, 225, 199);
            entrada_ver_por_estados.DropDownStyle = ComboBoxStyle.DropDownList;
            entrada_ver_por_estados.FlatStyle = FlatStyle.Flat;
            entrada_ver_por_estados.Font = new Font("Montserrat", 15F);
            entrada_ver_por_estados.ForeColor = Color.Black;
            entrada_ver_por_estados.FormattingEnabled = true;
            entrada_ver_por_estados.Items.AddRange(new object[] { "TODOS", "Pendientes", "Confirmadas", "En preparación", "Listas", "Entregadas" });
            entrada_ver_por_estados.Location = new Point(12, 101);
            entrada_ver_por_estados.Name = "entrada_ver_por_estados";
            entrada_ver_por_estados.Size = new Size(319, 35);
            entrada_ver_por_estados.TabIndex = 148;
            entrada_ver_por_estados.SelectedIndexChanged += entrada_ver_por_estados_SelectedIndexChanged;
            // 
            // linea_estado
            // 
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
            // contenedor_principal_ordenes
            // 
            contenedor_principal_ordenes.AutoScroll = true;
            contenedor_principal_ordenes.Location = new Point(12, 173);
            contenedor_principal_ordenes.Name = "contenedor_principal_ordenes";
            contenedor_principal_ordenes.Padding = new Padding(5);
            contenedor_principal_ordenes.Size = new Size(1188, 635);
            contenedor_principal_ordenes.TabIndex = 151;
            // 
            // VerOrdenes
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(1212, 858);
            Controls.Add(contenedor_principal_ordenes);
            Controls.Add(entrada_ver_por_estados);
            Controls.Add(linea_estado);
            Controls.Add(etiqueta_estado);
            Controls.Add(titulo_editar);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VerOrdenes";
            Text = "VerOrden";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo_editar;
        private ComboBox entrada_ver_por_estados;
        private Panel linea_estado;
        private Label etiqueta_estado;
        private FlowLayoutPanel contenedor_principal_ordenes;
    }
}