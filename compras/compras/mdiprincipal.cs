using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace compras
{
    public partial class mdiprincipal : Form
    {
        public mdiprincipal()
        {
            InitializeComponent();
        }

        private void traToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras tran_compras = new Compras();
            tran_compras.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            prov.ShowDialog();
        }

      


    }
}
