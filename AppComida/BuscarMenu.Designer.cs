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
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel_abajo = new Panel();
            panel_arriba = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button2.ForeColor = Color.FromArgb(242, 225, 199);
            button2.Location = new Point(522, 32);
            button2.Margin = new Padding(3, 3, 3, 30);
            button2.Name = "button2";
            button2.Size = new Size(319, 40);
            button2.TabIndex = 180;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(242, 225, 199);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Montserrat", 15F);
            textBox1.ForeColor = Color.FromArgb(144, 144, 144);
            textBox1.Location = new Point(109, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 25);
            textBox1.TabIndex = 177;
            textBox1.Text = "7/";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Enabled = false;
            panel2.Location = new Point(0, 401);
            panel2.Margin = new Padding(3, 3, 3, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 2);
            panel2.TabIndex = 181;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(109, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(732, 227);
            dataGridView1.TabIndex = 182;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(336, 17);
            label2.Name = "label2";
            label2.Size = new Size(238, 47);
            label2.TabIndex = 183;
            label2.Text = "Vista grafica";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_abajo
            // 
            panel_abajo.Controls.Add(label2);
            panel_abajo.Location = new Point(0, 412);
            panel_abajo.Name = "panel_abajo";
            panel_abajo.Size = new Size(933, 331);
            panel_abajo.TabIndex = 184;
            // 
            // panel_arriba
            // 
            panel_arriba.Controls.Add(dataGridView1);
            panel_arriba.Controls.Add(button2);
            panel_arriba.Controls.Add(textBox1);
            panel_arriba.Controls.Add(panel1);
            panel_arriba.Controls.Add(label1);
            panel_arriba.Location = new Point(0, 77);
            panel_arriba.Name = "panel_arriba";
            panel_arriba.Size = new Size(933, 317);
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
            Controls.Add(panel2);
            Controls.Add(titulo_editar);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BuscarMenu";
            Text = "RegistrarError";
            Resize += BuscarMenu_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_abajo.ResumeLayout(false);
            panel_abajo.PerformLayout();
            panel_arriba.ResumeLayout(false);
            panel_arriba.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label titulo_editar;
        private Button button2;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panel_abajo;
        private Panel panel_arriba;
    }
}