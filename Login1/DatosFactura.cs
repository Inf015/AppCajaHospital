using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void DatosFactura_Load(object sender, EventArgs e)
        {

        }

        private void btlFacturar_Click(object sender, EventArgs e)
        {
            frmFactura impFactura = new frmFactura();
            impFactura.Show();
        }

        private void inicioDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicioDia frmInicioDia = new frmInicioDia();
            frmInicioDia.Show();
        }

        private void cierreDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCierreDia frmCierreDia = new frmCierreDia();
            frmCierreDia.Show();
        }

        private void cuadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuadre frmCuadre = new frmCuadre();
            frmCuadre.Show();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
