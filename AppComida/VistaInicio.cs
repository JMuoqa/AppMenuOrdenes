using AppComida;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeProyectos
{
    public partial class VistaInicio : Form
    {
        public VistaInicio()
        {
            InitializeComponent();
        }
        #region Funciones visuales
        private void OcultarSubMenus()
        {
            panelSubMenuAdministrar.Visible = false;
            panelSubMenuOrdenes.Visible = false;
            panelSubMenuEstadisticas.Visible = false;
        }

        private void ActualizarSubMenus()
        {
            if (panelSubMenuAdministrar.Visible == true)
                panelSubMenuAdministrar.Visible = false;
            if (panelSubMenuOrdenes.Visible == true)
                panelSubMenuOrdenes.Visible = false;
            if (panelSubMenuEstadisticas.Visible == true)
                panelSubMenuEstadisticas.Visible = false;
        }

        private void AbrirSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ActualizarSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion
        #region Eventos visuales
        private void boton_administrar_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(panelSubMenuAdministrar);
        }
        private void boton_busqueda_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(panelSubMenuOrdenes);
        }
        private void boton_estadisticas_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(panelSubMenuEstadisticas);
        }
        #endregion
        #region Eventos principales
        private void boton_agregar_Click(object sender, EventArgs e)
        {
            AgregarMenu agregarProyecto = new(); // Es lo mismo que: "= new AgregarProyecto();" 
            CambiarFormulario(agregarProyecto);
            //Arriba de esto iria codigo
            ActualizarSubMenus();
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            EditarMenu editarProyecto = new EditarMenu();
            CambiarFormulario(editarProyecto);
            ActualizarSubMenus();
        }
        private void boton_error_Click(object sender, EventArgs e)
        {
            BuscarMenu registrarError = new BuscarMenu();
            CambiarFormulario(registrarError);
            ActualizarSubMenus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard verEstadisticas = new DashBoard();
            CambiarFormulario(verEstadisticas);
            ActualizarSubMenus();
        }
        private void boton_lista_Click(object sender, EventArgs e)
        {
            AgregarOrden agregarordenr = new AgregarOrden();
            CambiarFormulario(agregarordenr);
            ActualizarSubMenus();
        }
        private void boton_tarjetas_Click(object sender, EventArgs e)
        {
            EditarOrden editarOrden = new EditarOrden();
            CambiarFormulario(editarOrden);
            ActualizarSubMenus();
        }
        private void boton_ver_ordenes_Click(object sender, EventArgs e)
        {
            VerOrdenes verOrdenes = new VerOrdenes();
            CambiarFormulario(verOrdenes);
            ActualizarSubMenus();
        }
        #endregion
        #region Funciones principales
        private Form formularioActivo = null;
        private void CambiarFormulario(Form formularioHijo)
        {
            formularioActivo?.Close(); //Es lo mismo que: if(formularioActivo != null) { formularioActivo.Close() }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(formularioHijo);
            panelHijo.Tag = formularioActivo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        #endregion
    }
}
