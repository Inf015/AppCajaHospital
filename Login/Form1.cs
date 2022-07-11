using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        //public void logins()
        //{
        //    try
        //    {
                //TODO: PONER CONECCTION STRING
        //        string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        //        using(SqlConnection conexion = new SqlConnection(cnn))
        //        {
        //            using (SqlCommand cmd = new SqlCommand("SELECT usuario, pass From usuarios WHERE usuario='" + txtUsuario.Text + "'AND pass='" + txtContraseña.Text + "'", conexion))
        //            {
        //                SqlCommand dr = cmd.ExecuteReader();

        //                if (dr.Read())
        //                {
        //                    MessageBox.Show("Logion exitoso");
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Datos Incorrectos");
        //                }
        //            }
        //        }
                

        //    }
        //    catch (Exception EX)
        //    {

        //        MessageBox.Show(EX.ToString());
        //    }
        //}

        private void btlLogIn_Click(object sender, EventArgs e)
        {
            //logins();  
        }
    }
}
