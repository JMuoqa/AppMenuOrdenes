namespace ControlDeProyectos
{
    partial class BuscarMenu
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
            boton_buscar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            entrada_busqueda = new TextBox();
            resultados_busqueda = new DataGridView();
            label2 = new Label();
            panel_abajo = new Panel();
            panel_arriba = new Panel();
            ((System.ComponentModel.ISupportInitialize)resultados_busqueda).BeginInit();
            panel_abajo.SuspendLayout();
            panel_arriba.SuspendLayout();
            SuspendLayout();
            // 
            // titulo_editar
            // 
            titulo_editar.Anchor = AnchorStyles.Top;
            titulo_editar.AutoSize = true;
            titulo_editar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_editar.ForeColor = Color.Black;
            titulo_editar.Location = new Point(327, 9);
            titulo_editar.Name = "titulo_editar";
            titulo_editar.Size = new Size(254, 47);
            titulo_editar.TabIndex = 159;
            titulo_editar.Text = "Buscar menu";
            titulo_editar.TextAlign = ContentAlignment.MiddleCenter;
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
            boton_buscar.Location = new Point(522, 32);
            boton_buscar.Margin = new Padding(3, 3, 3, 30);
            boton_buscar.Name = "boton_buscar";
            boton_buscar.Size = new Size(319, 40);
            boton_buscar.TabIndex = 180;
            boton_buscar.Text = "Buscar";
            boton_buscar.UseVisualStyleBackColor = false;
            boton_buscar.Click += boton_buscar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(109, 8);
            label1.Name = "label1";
            label1.Size = new Size(131, 27);
            label1.TabIndex = 179;
            label1.Text = "Busqueda:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Black;
            panel1.Enabled = false;
            panel1.Location = new Point(109, 69);
            panel1.Margin = new Padding(3, 3, 3, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 1);
            panel1.TabIndex = 178;
            //
            //
            //

            // 
            // entrada_busqueda
            // 
            entrada_busqueda.Anchor = AnchorStyles.Top;
            entrada_busqueda.BackColor = Color.FromArgb(242, 225, 199);
            entrada_busqueda.BorderStyle = BorderStyle.None;
            entrada_busqueda.Font = new Font("Montserrat", 15F);
            entrada_busqueda.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_busqueda.Location = new Point(109, 38);
            entrada_busqueda.Name = "entrada_busqueda";
            entrada_busqueda.Size = new Size(319, 25);
            entrada_busqueda.TabIndex = 177;
            entrada_busqueda.Text = "#7/Lomo completo";
            entrada_busqueda.TextChanged += entrada_busuqeda_TextChanged;
            entrada_busqueda.Enter += TodasLasEntradasNormales_Enter;
            entrada_busqueda.Leave += TodasLasEntradasNormales_Leave;
            // 
            // resultados_busqueda
            // 
            resultados_busqueda.Anchor = AnchorStyles.Top;
            resultados_busqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultados_busqueda.Location = new Point(109, 87);
            resultados_busqueda.Name = "resultados_busqueda";
            resultados_busqueda.Size = new Size(732, 245);
            resultados_busqueda.TabIndex = 182;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(352, 0);
            label2.Name = "label2";
            label2.Size = new Size(238, 47);
            label2.TabIndex = 183;
            label2.Text = "Vista grafica";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_abajo
            // 
            panel_abajo.Controls.Add(label2);
            panel_abajo.Location = new Point(0, 417);
            panel_abajo.Name = "panel_abajo";
            panel_abajo.Size = new Size(933, 424);
            panel_abajo.TabIndex = 184;
            // 
            // panel_arriba
            // 
            panel_arriba.Controls.Add(resultados_busqueda);
            panel_arriba.Controls.Add(boton_buscar);
            panel_arriba.Controls.Add(entrada_busqueda);
            panel_arriba.Controls.Add(panel1);
            panel_arriba.Controls.Add(label1);
            panel_arriba.Location = new Point(0, 59);
            panel_arriba.Name = "panel_arriba";
            panel_arriba.Size = new Size(933, 352);
            panel_arriba.TabIndex = 185;
            // 
            // BuscarMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(933, 741);
            Controls.Add(panel_arriba);
            Controls.Add(panel_abajo);
            Controls.Add(titulo_editar);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BuscarMenu";
            Text = "RegistrarError";
            Resize += BuscarMenu_Resize;
            ((System.ComponentModel.ISupportInitialize)resultados_busqueda).EndInit();
            panel_abajo.ResumeLayout(false);
            panel_abajo.PerformLayout();
            panel_arriba.ResumeLayout(false);
            panel_arriba.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label titulo_editar;
        private Button boton_buscar;
        private Label label1;
        private Panel panel1;
        private TextBox entrada_busqueda;
        private DataGridView resultados_busqueda;
        private Label label2;
        private Panel panel_abajo;
        private Panel panel_arriba;
    }
}