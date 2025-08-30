using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace ControlDeProyectos
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            estadisticas_circulo.ChartAreas[0].BackColor = Color.Transparent;
            estadisticas_lineas.ChartAreas[0].BackColor= Color.Transparent; 
            egresos_circulo.ChartAreas[0].BackColor= Color.Transparent; 
            egresos_lineal.ChartAreas[0].BackColor= Color.Transparent;
            diferencia_circulo.ChartAreas[0].BackColor = Color.Transparent;
            diferencia_lineal.ChartAreas[0].BackColor = Color.Transparent;
            //estadisticas_circulo
            estadisticas_circulo.Series["Ingresos"].Points.AddXY("Enero", 100000);
            estadisticas_circulo.Series["Ingresos"].Points.AddXY("Febrero", 124000);
            estadisticas_circulo.Series["Ingresos"].Points.AddXY("Marzo", 92000);
            estadisticas_circulo.Series["Ingresos"].Points.AddXY("Abril", 52000);
            estadisticas_circulo.Series["Ingresos"].Points.AddXY("Mayo", 102000);
            // estadisticas_lineas
            estadisticas_lineas.Series["Ingresos"].Points.AddXY(1, 100000);
            estadisticas_lineas.Series["Ingresos"].Points.AddXY(2, 124000);
            estadisticas_lineas.Series["Ingresos"].Points.AddXY(3, 92000);
            estadisticas_lineas.Series["Ingresos"].Points.AddXY(4, 52000);
            estadisticas_lineas.Series["Ingresos"].Points.AddXY(5, 102000);
            //egresos_circulo
            egresos_circulo.Series["Egresos"].Points.AddXY("Enero", 45000);
            egresos_circulo.Series["Egresos"].Points.AddXY("Febrero", 73000);
            egresos_circulo.Series["Egresos"].Points.AddXY("Marzo", 34000);
            egresos_circulo.Series["Egresos"].Points.AddXY("Abril", 12000);
            egresos_circulo.Series["Egresos"].Points.AddXY("Mayo", 41000);
            //egreso_lineal
            egresos_lineal.Series["Egresos"].Points.AddXY(1, 45000);
            egresos_lineal.Series["Egresos"].Points.AddXY(2, 73000);
            egresos_lineal.Series["Egresos"].Points.AddXY(3, 34000);
            egresos_lineal.Series["Egresos"].Points.AddXY(4, 12000);
            egresos_lineal.Series["Egresos"].Points.AddXY(5, 41000);
            //diferencia_circulo
            diferencia_circulo.Series["Dinero"].Points.AddXY("Ingresos", 470000);
            diferencia_circulo.Series["Dinero"].Points.AddXY("Gastos", 265000);
            //diferencia_lineal
            diferencia_lineal.Series["Ingresos"].Points.AddXY(1, 100000);
            diferencia_lineal.Series["Ingresos"].Points.AddXY(2, 124000);
            diferencia_lineal.Series["Ingresos"].Points.AddXY(3, 92000);
            diferencia_lineal.Series["Ingresos"].Points.AddXY(4, 52000);
            diferencia_lineal.Series["Ingresos"].Points.AddXY(5, 102000);
            diferencia_lineal.Series["Egresos"].Points.AddXY(1, 45000);
            diferencia_lineal.Series["Egresos"].Points.AddXY(2, 73000);
            diferencia_lineal.Series["Egresos"].Points.AddXY(3, 34000);
            diferencia_lineal.Series["Egresos"].Points.AddXY(4, 12000);
            diferencia_lineal.Series["Egresos"].Points.AddXY(5, 41000);
        }
    }
}
