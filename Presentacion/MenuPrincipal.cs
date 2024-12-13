using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btbAutores_Click(object sender, EventArgs e)
        {
            CUAutores frmPrueba = new CUAutores();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            CUCalendario frmPrueba = new CUCalendario();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void btnEditores_Click(object sender, EventArgs e)
        {
            CUDescuentos frmPrueba = new CUDescuentos();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            CUEditoriales frmPrueba = new CUEditoriales();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            CUEmpleados frmPrueba = new CUEmpleados();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CUEmpleos frmPrueba = new CUEmpleos();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CUVentas frmPrueba = new CUVentas();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CUInfEditorial frmPrueba = new CUInfEditorial();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CUTiendas frmPrueba = new CUTiendas();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CUTiAutor frmPrueba = new CUTiAutor();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUTitulos frmPrueba = new CUTitulos();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }
    }
}
