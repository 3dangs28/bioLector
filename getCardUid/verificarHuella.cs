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
using System.IO;

namespace getCardUid
{
    public partial class verificarHuella : CaptureForm
    {

        public delegate void SetTextValueCallBack(string str);
        public SetTextValueCallBack SetTextValue;

        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        public verificarHuella()
        {
            InitializeComponent();
        }



        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Huella Digital";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }


        protected override void Process(DPFP.Sample Sample)
        {


            base.Process(Sample);
            string monto = "";

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                DPFP.Template template = new DPFP.Template();




                // SqlConnection conn = new SqlConnection("Data Source=10.2.7.11;Initial Catalog=SIPAF_App;User ID=sa;Password=sqladmin");
                string aux = "Data Source=" + conexion.Fuente + ";Initial Catalog=" + conexion.Catalogo + ";User ID=" + conexion.User + ";Password=" + conexion.Password;
                //   string aux = "Data Source=" + conexion.Fuente + ";Initial Catalog=" + conexion.Catalogo + ";integrated security = true;";
                //    string aux = "Data Source = 10.2.7.11; Initial Catalog = OfiELE_mvpsportcity_ofiele_es; User ID = sa; Password = sqladmin";
                Stream stream;

                SqlConnection conn = new SqlConnection(aux);

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from datos", conn);


                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {
                        byte[] data = (byte[])dr[8];

                        stream = new MemoryStream(data);
                        template = new DPFP.Template(stream);

                        Verificator.Verify(features, template, ref result);
                        UpdateStatus(result.FARAchieved);
                        if (result.Verified)
                        {
                            /*  double gato = Convert.ToDouble(dr[4].ToString());
                              if (gato == 0) {
                                  mensaje = "No debe";
                              }else
                              {
                                  mensaje = "Moroso";
                              }*/
                            MakeReport(" ");
                            MakeReport("Huella encontrada");
                            MakeReport("Nombre: " + dr[0].ToString());
                            MakeReport("Cédula: " + dr[1].ToString());
                            MakeReport("Total: " + dr[3].ToString());
                            MakeReport("Cobrado: " + dr[4].ToString() + " B/.");
                            MakeReport("Pendiente: " + dr[5].ToString() + " B/.");

                            Form1 fafa = new Form1();
                            this.SetTextValue += new SetTextValueCallBack(fafa.SetText);
                          
                            //conexion.Fotografia = "C:/DESARROLLO/proyectosC#/biometrico/img/iwuk.png";
                            //  pctFoto.Image = new Bitmap(conexion.RutaImg + dr[1].ToString() + ".jpg");
                            //  pctFoto.Image = new Bitmap(@"C:\Users\Rumijsd\Pictures\papaya\" + dr[1].ToString() + ".png");
                           //   pctFoto.SizeMode = PictureBoxSizeMode.StretchImage;



                            monto = dr[9].ToString();

                            switch (monto)
                            {
                                case "1":
                                    // celeste
                                    // -- >             pctColor.BackColor = Color.FromArgb(121, 174, 235);
                                    break;
                                case "2":
                                // amarillo
                                // -- >         pctColor.BackColor = Color.FromArgb(255, 247, 0);
                                            break;
                                case "3":
                                    // rojo
                                    // -- >                pctColor.BackColor = Color.FromArgb(255, 0, 0);
                                    break;
                                case "4":
                                    // rojo
                                    // -- >              pctColor.BackColor = Color.FromArgb(255, 0, 0);
                                    break;
                                default:
                                    // -- >                 pctColor.BackColor = Color.FromArgb(255, 0, 0);
                                    // -- >
                                    break;
                            }

                            MakeReport("Retraso: " + monto + "  Meses");
                            //   MessageBox.Show(" Estatus: " + mensaje);

                            break;
                        }


                        dr.GetString(1);

                    }




                    dr.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }




            }
        }






    }
}
