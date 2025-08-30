namespace ControlDeProyectos
{
    partial class autenticacion_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autenticacion_principal));
            panel_logo = new Panel();
            logo = new PictureBox();
            linea_usuario = new Panel();
            entrada_usuario = new TextBox();
            entrada_pass = new TextBox();
            linea_pass = new Panel();
            label1 = new Label();
            boton_confirmar = new Button();
            link_olvidaste = new LinkLabel();
            cerrar_app = new PictureBox();
            minimizar_app = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cerrar_app).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizar_app).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel_logo
            // 
            panel_logo.BackColor = Color.FromArgb(0, 0, 16);
            panel_logo.Controls.Add(logo);
            panel_logo.Dock = DockStyle.Left;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(407, 407);
            panel_logo.TabIndex = 0;
            panel_logo.MouseDown += panel_logo_MouseDown;
            // 
            // logo
            // 
            logo.Enabled = false;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(53, 53);
            logo.Name = "logo";
            logo.Size = new Size(300, 300);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // linea_usuario
            // 
            linea_usuario.BackColor = Color.FromArgb(255, 149, 0);
            linea_usuario.Enabled = false;
            linea_usuario.Location = new Point(614, 160);
            linea_usuario.Name = "linea_usuario";
            linea_usuario.Size = new Size(400, 1);
            linea_usuario.TabIndex = 1;
            // 
            // entrada_usuario
            // 
            entrada_usuario.BackColor = Color.FromArgb(0, 0, 32);
            entrada_usuario.BorderStyle = BorderStyle.None;
            entrada_usuario.Font = new Font("Montserrat", 12F);
            entrada_usuario.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_usuario.Location = new Point(614, 136);
            entrada_usuario.Name = "entrada_usuario";
            entrada_usuario.Size = new Size(400, 20);
            entrada_usuario.TabIndex = 1;
            entrada_usuario.Text = "USUARIO";
            entrada_usuario.Enter += entrada_usuario_Enter;
            entrada_usuario.KeyDown += Entradas_KeyDown;
            entrada_usuario.Leave += entrada_usuario_Leave;
            // 
            // entrada_pass
            // 
            entrada_pass.BackColor = Color.FromArgb(0, 0, 32);
            entrada_pass.BorderStyle = BorderStyle.None;
            entrada_pass.Font = new Font("Montserrat", 12F);
            entrada_pass.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_pass.Location = new Point(614, 211);
            entrada_pass.Name = "entrada_pass";
            entrada_pass.Size = new Size(400, 20);
            entrada_pass.TabIndex = 2;
            entrada_pass.Text = "CONTRASEÑA";
            entrada_pass.Enter += entrada_pass_Enter;
            entrada_pass.KeyDown += Entradas_KeyDown;
            entrada_pass.Leave += entrada_pass_Leave;
            // 
            // linea_pass
            // 
            linea_pass.BackColor = Color.FromArgb(255, 149, 0);
            linea_pass.Enabled = false;
            linea_pass.Location = new Point(614, 235);
            linea_pass.Name = "linea_pass";
            linea_pass.Size = new Size(400, 1);
            linea_pass.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 24F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(745, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 44);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // boton_confirmar
            // 
            boton_confirmar.BackColor = Color.FromArgb(222, 205, 179);
            boton_confirmar.Cursor = Cursors.Hand;
            boton_confirmar.FlatAppearance.BorderSize = 0;
            boton_confirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 195, 169);
            boton_confirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 215, 189);
            boton_confirmar.FlatStyle = FlatStyle.Flat;
            boton_confirmar.Font = new Font("Montserrat", 14.25F, FontStyle.Bold);
            boton_confirmar.ForeColor = Color.FromArgb(0, 0, 23);
            boton_confirmar.Location = new Point(614, 296);
            boton_confirmar.Name = "boton_confirmar";
            boton_confirmar.Size = new Size(400, 40);
            boton_confirmar.TabIndex = 3;
            boton_confirmar.Text = "Confirmar";
            boton_confirmar.UseVisualStyleBackColor = false;
            boton_confirmar.Click += boton_confirmar_Click;
            // 
            // link_olvidaste
            // 
            link_olvidaste.AutoSize = true;
            link_olvidaste.LinkColor = Color.White;
            link_olvidaste.Location = new Point(745, 348);
            link_olvidaste.Name = "link_olvidaste";
            link_olvidaste.Size = new Size(139, 15);
            link_olvidaste.TabIndex = 0;
            link_olvidaste.TabStop = true;
            link_olvidaste.Text = "¿Olvidaste la contraseña?";
            // 
            // cerrar_app
            // 
            cerrar_app.Cursor = Cursors.Hand;
            cerrar_app.Image = (Image)resources.GetObject("cerrar_app.Image");
            cerrar_app.Location = new Point(1167, 9);
            cerrar_app.Name = "cerrar_app";
            cerrar_app.Size = new Size(20, 20);
            cerrar_app.SizeMode = PictureBoxSizeMode.Zoom;
            cerrar_app.TabIndex = 8;
            cerrar_app.TabStop = false;
            cerrar_app.Click += cerrar_app_Click;
            // 
            // minimizar_app
            // 
            minimizar_app.Cursor = Cursors.Hand;
            minimizar_app.Image = (Image)resources.GetObject("minimizar_app.Image");
            minimizar_app.Location = new Point(1141, 9);
            minimizar_app.Name = "minimizar_app";
            minimizar_app.Size = new Size(20, 20);
            minimizar_app.SizeMode = PictureBoxSizeMode.Zoom;
            minimizar_app.TabIndex = 9;
            minimizar_app.TabStop = false;
            minimizar_app.Click += minimizar_app_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // autenticacion_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 32);
            ClientSize = new Size(1199, 407);
            Controls.Add(minimizar_app);
            Controls.Add(cerrar_app);
            Controls.Add(link_olvidaste);
            Controls.Add(boton_confirmar);
            Controls.Add(label1);
            Controls.Add(linea_pass);
            Controls.Add(entrada_pass);
            Controls.Add(entrada_usuario);
            Controls.Add(linea_usuario);
            Controls.Add(panel_logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "autenticacion_principal";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana principal";
            Load += AutenticacionPrincipal_Load;
            MouseDown += autenticacion_principal_MouseDown;
            panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)cerrar_app).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizar_app).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_logo;
        private Panel linea_usuario;
        private TextBox entrada_usuario;
        private TextBox entrada_pass;
        private Panel linea_pass;
        private Label label1;
        private Button boton_confirmar;
        private LinkLabel link_olvidaste;
        private PictureBox logo;
        private PictureBox cerrar_app;
        private PictureBox minimizar_app;
        private ErrorProvider errorProvider1;
    }
}
