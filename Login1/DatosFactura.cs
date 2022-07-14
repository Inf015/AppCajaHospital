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
using Login1.General;

namespace Login1
{
    
    public partial class Facturacion : Form
    {

        string servicio, Descripcion;
        double Tax, Precio, Total, PrecioTotal;
        int Metodo;
        public class capPrecio
        {
            public double Preciototal { get; set; }
        }
        public Facturacion()
        {
            InitializeComponent();

        }

        private void DatosFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.dataSet1.Factura);
            //<<<<<<< HEAD
            //            // TODO: This line of code loads data into the 'dataSet1.MetodoPago' table. You can move, or remove it, as needed.
            //            this.metodoPagoTableAdapter.Fill(this.dataSet1.MetodoPago);

            //=======
            //            txtMetodoPago.Items.Add("Efectivo");
            //            txtMetodoPago.Items.Add("Tarejta");
            //>>>>>>> 16c6e8b837e42cc8728ad977fd90caecaeb5f2ac
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
            frmVistaCuadre frmVistaCuadre = new frmVistaCuadre();
            frmVistaCuadre.Show();
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


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Efectivo")
            {
                Metodo = 1;
            }
            else if (comboBox1.Text == "Tarjeta")
            {
                Metodo = 2;
            }
            else if (comboBox1.Text == "Transferencia")
            {
                Metodo = 3;
            }
           
            //Metodo = (int)comboBox1.SelectedValue;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.metodoPagoTableAdapter.FillBy(this.dataSet1.MetodoPago);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtServicio_TextChanged(object sender, EventArgs e)
        {
            servicio = txtServicio.Text;
        }

        private void btlGuardar_Click(object sender, EventArgs e)
        {
            Total = (Precio * Tax) + Precio;

            QueriesTableAdapter adapter = new QueriesTableAdapter();
            FacturaTableAdapter adapter1 = new FacturaTableAdapter();


            adapter.InsertFactura(Descripcion, Precio, servicio, Precio, Total, Tax, DateTime.Now, Metodo);

            //PrecioTotal = adapter1.SumaPrecio(capPrecio);
           
            //INVENTO
            //query = "SELECT SUM(Total) AS Expr1 FROM Factura";
            //SqlCommand command = new SqlCommand(query);
            //SqlDataAdapter data = new SqlDataAdapter(command);
            //DataTable table = new DataTable();
            //data.Fill(table);


            //PrecioTotal = adapter1.FillBy(test);

            adapter.InsertPreciototal(PrecioTotal);
            MessageBox.Show("Guardado");

        }
    }

    }
