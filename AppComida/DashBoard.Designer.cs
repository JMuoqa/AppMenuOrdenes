using System.Windows.Forms;
using System.Drawing;
using ControlDeProyectos.ElementosPersonalizados;
using System.Windows.Forms.DataVisualization.Charting;
namespace ControlDeProyectos
{
    partial class DashBoard
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            ChartArea chartArea3 = new ChartArea();
            Legend legend3 = new Legend();
            Series series3 = new Series();
            ChartArea chartArea4 = new ChartArea();
            Legend legend4 = new Legend();
            Series series4 = new Series();
            ChartArea chartArea5 = new ChartArea();
            Legend legend5 = new Legend();
            Series series5 = new Series();
            Series series6 = new Series();
            ChartArea chartArea6 = new ChartArea();
            Legend legend6 = new Legend();
            Series series7 = new Series();
            panel_circulo = new PanelPer();
            estadisticas_circulo = new Chart();
            panel_lineas = new PanelPer();
            estadisticas_lineas = new Chart();
            titulo_editar = new Label();
            etiqueta_cliente = new Label();
            label1 = new Label();
            panelPer1 = new PanelPer();
            egresos_lineal = new Chart();
            panelPer2 = new PanelPer();
            egresos_circulo = new Chart();
            panelPer3 = new PanelPer();
            diferencia_lineal = new Chart();
            panelPer4 = new PanelPer();
            diferencia_circulo = new Chart();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label18 = new Label();
            panel_circulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)estadisticas_circulo).BeginInit();
            panel_lineas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)estadisticas_lineas).BeginInit();
            panelPer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)egresos_lineal).BeginInit();
            panelPer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)egresos_circulo).BeginInit();
            panelPer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)diferencia_lineal).BeginInit();
            panelPer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)diferencia_circulo).BeginInit();
            SuspendLayout();
            // 
            // panel_circulo
            // 
            panel_circulo.BackColor = Color.FromArgb(222, 205, 179);
            panel_circulo.Controls.Add(estadisticas_circulo);
            panel_circulo.Location = new Point(12, 95);
            panel_circulo.Name = "panel_circulo";
            panel_circulo.Size = new Size(367, 234);
            panel_circulo.TabIndex = 0;
            // 
            // estadisticas_circulo
            // 
            estadisticas_circulo.BackColor = Color.FromArgb(222, 205, 179);
            chartArea1.Name = "ChartArea1";
            estadisticas_circulo.ChartAreas.Add(chartArea1);
            estadisticas_circulo.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            estadisticas_circulo.Legends.Add(legend1);
            estadisticas_circulo.Location = new Point(0, 0);
            estadisticas_circulo.Name = "estadisticas_circulo";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Ingresos";
            estadisticas_circulo.Series.Add(series1);
            estadisticas_circulo.Size = new Size(367, 234);
            estadisticas_circulo.TabIndex = 0;
            estadisticas_circulo.Text = "chart1";
            // 
            // panel_lineas
            // 
            panel_lineas.AutoScroll = true;
            panel_lineas.BackColor = Color.FromArgb(222, 205, 179);
            panel_lineas.Controls.Add(estadisticas_lineas);
            panel_lineas.Location = new Point(385, 95);
            panel_lineas.Name = "panel_lineas";
            panel_lineas.Size = new Size(536, 234);
            panel_lineas.TabIndex = 1;
            // 
            // estadisticas_lineas
            // 
            estadisticas_lineas.BackColor = Color.FromArgb(222, 205, 179);
            chartArea2.Name = "ChartArea1";
            estadisticas_lineas.ChartAreas.Add(chartArea2);
            estadisticas_lineas.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            estadisticas_lineas.Legends.Add(legend2);
            estadisticas_lineas.Location = new Point(0, 0);
            estadisticas_lineas.Name = "estadisticas_lineas";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Line;
            series2.Color = Color.Green;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.MarkerSize = 8;
            series2.MarkerStyle = MarkerStyle.Circle;
            series2.Name = "Ingresos";
            estadisticas_lineas.Series.Add(series2);
            estadisticas_lineas.Size = new Size(536, 234);
            estadisticas_lineas.TabIndex = 1;
            estadisticas_lineas.Text = "chart1";
            // 
            // titulo_editar
            // 
            titulo_editar.Anchor = AnchorStyles.Top;
            titulo_editar.AutoSize = true;
            titulo_editar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_editar.ForeColor = Color.Black;
            titulo_editar.Location = new Point(612, 9);
            titulo_editar.Name = "titulo_editar";
            titulo_editar.Size = new Size(305, 47);
            titulo_editar.TabIndex = 147;
            titulo_editar.Text = "Panel de control";
            // 
            // etiqueta_cliente
            // 
            etiqueta_cliente.AutoSize = true;
            etiqueta_cliente.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_cliente.ForeColor = Color.Black;
            etiqueta_cliente.Location = new Point(15, 65);
            etiqueta_cliente.Name = "etiqueta_cliente";
            etiqueta_cliente.Size = new Size(119, 27);
            etiqueta_cliente.TabIndex = 148;
            etiqueta_cliente.Text = "Ingresos :";
            etiqueta_cliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 372);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 149;
            label1.Text = "Gastos:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelPer1
            // 
            panelPer1.AutoScroll = true;
            panelPer1.BackColor = Color.FromArgb(222, 205, 179);
            panelPer1.Controls.Add(egresos_lineal);
            panelPer1.Location = new Point(385, 402);
            panelPer1.Name = "panelPer1";
            panelPer1.Size = new Size(536, 239);
            panelPer1.TabIndex = 151;
            // 
            // egresos_lineal
            // 
            egresos_lineal.BackColor = Color.FromArgb(222, 205, 179);
            chartArea3.Name = "ChartArea1";
            egresos_lineal.ChartAreas.Add(chartArea3);
            egresos_lineal.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            egresos_lineal.Legends.Add(legend3);
            egresos_lineal.Location = new Point(0, 0);
            egresos_lineal.Name = "egresos_lineal";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = SeriesChartType.Line;
            series3.Color = Color.Red;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.MarkerSize = 8;
            series3.MarkerStyle = MarkerStyle.Circle;
            series3.Name = "Egresos";
            egresos_lineal.Series.Add(series3);
            egresos_lineal.Size = new Size(536, 239);
            egresos_lineal.TabIndex = 1;
            egresos_lineal.Text = "chart1";
            // 
            // panelPer2
            // 
            panelPer2.BackColor = Color.FromArgb(222, 205, 179);
            panelPer2.Controls.Add(egresos_circulo);
            panelPer2.Location = new Point(12, 402);
            panelPer2.Name = "panelPer2";
            panelPer2.Size = new Size(367, 239);
            panelPer2.TabIndex = 150;
            // 
            // egresos_circulo
            // 
            egresos_circulo.BackColor = Color.FromArgb(222, 205, 179);
            chartArea4.Name = "ChartArea1";
            egresos_circulo.ChartAreas.Add(chartArea4);
            egresos_circulo.Dock = DockStyle.Fill;
            legend4.Name = "Legend1";
            egresos_circulo.Legends.Add(legend4);
            egresos_circulo.Location = new Point(0, 0);
            egresos_circulo.Name = "egresos_circulo";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Egresos";
            egresos_circulo.Series.Add(series4);
            egresos_circulo.Size = new Size(367, 239);
            egresos_circulo.TabIndex = 0;
            egresos_circulo.Text = "chart1";
            // 
            // panelPer3
            // 
            panelPer3.AutoScroll = true;
            panelPer3.BackColor = Color.FromArgb(222, 205, 179);
            panelPer3.Controls.Add(diferencia_lineal);
            panelPer3.Location = new Point(385, 720);
            panelPer3.Name = "panelPer3";
            panelPer3.Size = new Size(536, 239);
            panelPer3.TabIndex = 154;
            // 
            // diferencia_lineal
            // 
            diferencia_lineal.BackColor = Color.FromArgb(222, 205, 179);
            chartArea5.Name = "ChartArea1";
            diferencia_lineal.ChartAreas.Add(chartArea5);
            diferencia_lineal.Dock = DockStyle.Fill;
            legend5.Name = "Legend1";
            diferencia_lineal.Legends.Add(legend5);
            diferencia_lineal.Location = new Point(0, 0);
            diferencia_lineal.Name = "diferencia_lineal";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = SeriesChartType.Line;
            series5.Color = Color.Green;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.MarkerSize = 8;
            series5.MarkerStyle = MarkerStyle.Circle;
            series5.Name = "Ingresos";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Egresos";
            series6.BorderWidth = 2;
            series6.IsValueShownAsLabel = true;
            series6.Color = Color.Red;
            series6.MarkerSize = 8;
            series6.MarkerStyle = MarkerStyle.Circle;
            diferencia_lineal.Series.Add(series5);
            diferencia_lineal.Series.Add(series6);
            diferencia_lineal.Size = new Size(536, 239);
            diferencia_lineal.TabIndex = 1;
            diferencia_lineal.Text = "chart3";
            // 
            // panelPer4
            // 
            panelPer4.BackColor = Color.FromArgb(222, 205, 179);
            panelPer4.Controls.Add(diferencia_circulo);
            panelPer4.Location = new Point(12, 720);
            panelPer4.Name = "panelPer4";
            panelPer4.Size = new Size(367, 239);
            panelPer4.TabIndex = 153;
            // 
            // diferencia_circulo
            // 
            diferencia_circulo.BackColor = Color.FromArgb(222, 205, 179);
            chartArea6.Name = "ChartArea1";
            diferencia_circulo.ChartAreas.Add(chartArea6);
            diferencia_circulo.Dock = DockStyle.Fill;
            legend6.Name = "Legend1";
            diferencia_circulo.Legends.Add(legend6);
            diferencia_circulo.Location = new Point(0, 0);
            diferencia_circulo.Name = "diferencia_circulo";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = SeriesChartType.Doughnut;
            series7.Legend = "Legend1";
            series7.Name = "Dinero";
            diferencia_circulo.Series.Add(series7);
            diferencia_circulo.Size = new Size(367, 239);
            diferencia_circulo.TabIndex = 0;
            diferencia_circulo.Text = "chart1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 690);
            label2.Name = "label2";
            label2.Size = new Size(133, 27);
            label2.TabIndex = 152;
            label2.Text = "Diferencia:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(927, 95);
            label3.Name = "label3";
            label3.Size = new Size(69, 27);
            label3.TabIndex = 155;
            label3.Text = "Total :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(927, 402);
            label4.Name = "label4";
            label4.Size = new Size(69, 27);
            label4.TabIndex = 156;
            label4.Text = "Total :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 15F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(927, 720);
            label5.Name = "label5";
            label5.Size = new Size(124, 27);
            label5.TabIndex = 157;
            label5.Text = "Diferencia :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 15F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(927, 122);
            label6.Name = "label6";
            label6.Size = new Size(262, 27);
            label6.TabIndex = 158;
            label6.Text = "Mayor fuente de ingreso:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 15F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(927, 429);
            label7.Name = "label7";
            label7.Size = new Size(253, 27);
            label7.TabIndex = 159;
            label7.Text = "Mayor fuente de gastos:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat", 15F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(927, 149);
            label9.Name = "label9";
            label9.Size = new Size(283, 27);
            label9.TabIndex = 161;
            label9.Text = "Mes con mayores ingresos:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Montserrat", 15F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(927, 456);
            label10.Name = "label10";
            label10.Size = new Size(283, 27);
            label10.TabIndex = 162;
            label10.Text = "Mes con mayores ingresos:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat Medium", 15F);
            label11.ForeColor = Color.Green;
            label11.Location = new Point(1002, 95);
            label11.Name = "label11";
            label11.Size = new Size(105, 27);
            label11.TabIndex = 163;
            label11.Text = "$470.000";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Montserrat Medium", 15F);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(1002, 402);
            label12.Name = "label12";
            label12.Size = new Size(103, 27);
            label12.TabIndex = 164;
            label12.Text = "$205.000";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Montserrat Medium", 15F);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(1195, 122);
            label13.Name = "label13";
            label13.Size = new Size(203, 27);
            label13.TabIndex = 165;
            label13.Text = "Cafeteria ($124000)";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Montserrat Medium", 15F);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(1216, 149);
            label14.Name = "label14";
            label14.Size = new Size(92, 27);
            label14.TabIndex = 166;
            label14.Text = "Febrero";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Montserrat Medium", 15F);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(1216, 456);
            label15.Name = "label15";
            label15.Size = new Size(92, 27);
            label15.TabIndex = 168;
            label15.Text = "Febrero";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Montserrat Medium", 15F);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(1186, 429);
            label16.Name = "label16";
            label16.Size = new Size(203, 27);
            label16.TabIndex = 167;
            label16.Text = "Cafeteria ($124000)";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Montserrat Medium", 15F);
            label18.ForeColor = Color.Green;
            label18.Location = new Point(1057, 720);
            label18.Name = "label18";
            label18.Size = new Size(102, 27);
            label18.TabIndex = 170;
            label18.Text = "$265.000";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(1543, 977);
            Controls.Add(label18);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panelPer3);
            Controls.Add(panelPer4);
            Controls.Add(label2);
            Controls.Add(panelPer1);
            Controls.Add(panelPer2);
            Controls.Add(label1);
            Controls.Add(etiqueta_cliente);
            Controls.Add(titulo_editar);
            Controls.Add(panel_lineas);
            Controls.Add(panel_circulo);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashBoard";
            Text = "DashBoard";
            panel_circulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)estadisticas_circulo).EndInit();
            panel_lineas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)estadisticas_lineas).EndInit();
            panelPer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)egresos_lineal).EndInit();
            panelPer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)egresos_circulo).EndInit();
            panelPer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)diferencia_lineal).EndInit();
            panelPer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)diferencia_circulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PanelPer panel_circulo;
        private PanelPer panel_lineas;
        private System.Windows.Forms.DataVisualization.Charting.Chart estadisticas_circulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart estadisticas_lineas;
        private Label titulo_editar;
        private Label etiqueta_cliente;
        private Label label1;
        private PanelPer panelPer1;
        private Chart egresos_lineal;
        private PanelPer panelPer2;
        private Chart egresos_circulo;
        private PanelPer panelPer3;
        private Chart diferencia_lineal;
        private PanelPer panelPer4;
        private Chart diferencia_circulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label18;
    }
}