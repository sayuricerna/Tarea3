﻿using System;
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
    public partial class CUDescuentos : UserControl
    {
        public CUDescuentos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Descuentos.FrmDescuentos frm = new Descuentos.FrmDescuentos();
            frm.ShowDialog();
        }
    }
}