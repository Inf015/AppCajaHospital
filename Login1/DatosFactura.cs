using Login1.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1
{
    
    public partial class Facturacion : Form
    {
        string servicio, Descripcion;
        double Tax, Precio;
        int Metodo;
        public Facturacion()
        {
            InitializeComponent();
        }

        private void DatosFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.MetodoPago' table. You can move, or remove it, as needed.
            this.metodoPagoTableAdapter.Fill(this.dataSet1.MetodoPago);

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

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            Precio = double.Parse(txtPrecio.Text);
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            Tax = double.Parse(txtTax.Text);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Descripcion = txtDescripcion.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Metodo = int.Parse(comboBox1.Text);
        }

        private void txtServicio_TextChanged(object sender, EventArgs e)
        {
            servicio = txtServicio.Text;
        }

        private void btlGuardar_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter adapter = new QueriesTableAdapter();
            adapter.InsertFactura(Descripcion,Precio,servicio,Precio,Precio*Tax,Tax,DateTime.Now,Precio*Tax);
            adapter.ppinserMetodo(Metodo);
            MessageBox.Show("Guardado");
            
        }
    }
}
