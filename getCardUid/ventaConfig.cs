using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace getCardUid
{
    public partial class ventaConfig : Form
    {
        public ventaConfig()
        {
            InitializeComponent();
            //    pctColor.BackColor = Color.FromArgb(255, 0, 0);

          
             txtSource.Text = "10.2.7.11";
             txtCatalog.Text = "OfiELE_mvpsportcity_ofiele_es";
             txtUser.Text = "sa";
             txtPass.Text = "sqladmin";
             txtRuta.Text = @"C:\Users\AngelGarcia\Desktop\investigacion\"; 
             

            /*
            txtSource.Text = "192.168.1.100";
            txtCatalog.Text = "prueba-mvp";
            txtUser.Text = "sa";
            txtPass.Text = "123";
            txtRuta.Text = @"C:\Users\Administrador\Pictures\img\";
            */
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {


            if ((txtSource.Text == "") || (txtCatalog.Text == "") || (txtUser.Text == "") || (txtPass.Text == "") || (txtRuta.Text == ""))
            //   if ((txtSource.Text == "") || (txtCatalog.Text == "") )
            {
                MessageBox.Show("Por favor complete todos los campos.");
            }
            else
            {
                conexion.Fuente = txtSource.Text;
                conexion.Catalogo = txtCatalog.Text;
                conexion.User = txtUser.Text;
                conexion.Password = txtPass.Text;
                conexion.RutaImg = txtRuta.Text;


                string aux = "Data Source=" + conexion.Fuente + ";Initial Catalog=" + conexion.Catalogo + ";User ID=" + conexion.User + ";Password=" + conexion.Password + ";";

                //     string aux = "Data Source=" + conexion.Fuente + ";Initial Catalog=" + conexion.Catalogo + ";integrated security = true;";
                bool manu = IsServerConnected(aux);
                if (manu == true)
                {
                    MessageBox.Show("Conexión establecida: " + manu);
                    MessageBox.Show("Conexión guardada: " + aux);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo conectar: " + manu);
                }



            }
        }





        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }


    }



}
