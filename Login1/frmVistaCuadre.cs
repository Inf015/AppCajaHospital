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
    public partial class frmVistaCuadre : Form
    {
        public frmVistaCuadre()
        {
            InitializeComponent();
        }

        private void frmVistaCuadre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.dataSet1.Factura);

            this.reportViewer1.RefreshReport();
        }
    }
}
