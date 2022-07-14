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
        double Tax, Precio;
        int Metodo;

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
            QueriesTableAdapter adapter = new QueriesTableAdapter();

            double total = (Precio * Tax) + Precio;

            adapter.InsertFactura(Descripcion,Precio,servicio,Precio,total,Tax,DateTime.Now,Metodo);
            MessageBox.Show("Guardado");

            //=======
            //        private void btlGuardar_Click(object sender, EventArgs e)
            //        {

            //            //using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            //            //{
            //            //    using (SqlCommand cmd = new SqlCommand("InsertFactura", con))
            //            //    {
            //            //        con.Open();

            //            //        cmd.CommandType = CommandType.StoredProcedure;

            //            //        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
            //            //        cmd.Parameters.AddWithValue("@Precio", float.Parse(txtPrecio.Text.Trim()));
            //            //        cmd.Parameters.AddWithValue("@Articulo", txtServicio.Text.Trim());
            //            //        cmd.Parameters.AddWithValue("@Tax", float.Parse(txtTax.Text.Trim()));

            //            //        cmd.ExecuteNonQuery();

            //            //        con.Close();
            //            //        MessageBox.Show("La informacion se guardo correctamente");

            //            //    }
        }
    }

    }
