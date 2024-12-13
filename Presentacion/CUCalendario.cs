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
    public partial class CUCalendario : UserControl
    {
        public CUCalendario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalendarioRegalias.FrmCalendarioRegalias frm = new CalendarioRegalias.FrmCalendarioRegalias();
            frm.ShowDialog();
        }
    }
}
