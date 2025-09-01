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
            textBox1 = new TextBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
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
            boton_buscar.Location = new Point(513, 97);
            boton_buscar.Margin = new Padding(3, 3, 3, 30);
            boton_buscar.Name = "boton_buscar";
            boton_buscar.Size = new Size(319, 40);
            boton_buscar.TabIndex = 186;
            boton_buscar.Text = "Buscar";
            boton_buscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(100, 73);
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
            titulo_editar.Location = new Point(312, 9);
            titulo_editar.Name = "titulo_editar";
            titulo_editar.Size = new Size(236, 47);
            titulo_editar.TabIndex = 187;
            titulo_editar.Text = "Editar orden";
            titulo_editar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(242, 225, 199);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Montserrat", 15F);
            textBox1.ForeColor = Color.FromArgb(144, 144, 144);
            textBox1.Location = new Point(100, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 25);
            textBox1.TabIndex = 188;
            textBox1.Text = "#7/Lomo completo";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Black;
            panel1.Enabled = false;
            panel1.Location = new Point(100, 134);
            panel1.Margin = new Padding(3, 3, 3, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 2);
            panel1.TabIndex = 189;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(222, 205, 179);
            flowLayoutPanel1.Location = new Point(0, 169);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(933, 568);
            flowLayoutPanel1.TabIndex = 190;
            // 
            // EditarOrden
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(933, 742);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(titulo_editar);
            Controls.Add(boton_buscar);
            Controls.Add(label1);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditarOrden";
            Text = "EditarOrden";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button boton_buscar;
        private Label label1;
        private Label titulo_editar;
        private TextBox textBox1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}