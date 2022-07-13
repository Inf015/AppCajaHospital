using Login1.General;
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

namespace Login1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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

        private void btlLogIn_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                using(SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("LoginVerification", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", txtUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Passsword", txtContraseña.Text.Trim());

                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            Facturacion facturacion = new Facturacion();
                            facturacion.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario o contraseña incorrecto", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private bool Isvalid()
        {
            if(txtUsuario.Text.Trim() == String.Empty)
            {
                MessageBox.Show("El nombre de usuario es requerido", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtContraseña.Text.Trim() == String.Empty)
            {
                MessageBox.Show("La contraseña es requerida", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
    }
}
