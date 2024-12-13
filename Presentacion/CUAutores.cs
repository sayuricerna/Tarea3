using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea3.Datos;

namespace Tarea3.Presentacion
{
    public partial class CUAutores : UserControl
    {
        conexion dbConexion = new conexion(); // Instanciamos la clase de conexión

        public CUAutores()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Autores.FrmAutores frm = new Autores.FrmAutores();
            frm.ShowDialog();
        }
    }
}
