using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Login1.General;

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
            txtMetodoPago.Items.Add("Efectivo");
            txtMetodoPago.Items.Add("Tarejta");
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

        private void btlGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("InsertFactura", con))
                {
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                   
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Precio", float.Parse(txtPrecio.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Articulo", txtServicio.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tax", float.Parse(txtTax.Text.Trim()));

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("La informacion se guardo correctamente");
                    
                }
            }
        }

        private void txtMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
