using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpringCard.PCSC;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace getCardUid
{
   
    public partial class Form1 : Form
    {
        private DPFP.Template Template;

        private SCardReader reader = null;      // The reader's object
        private SCardChannel channel = null;    // A channel to the reader and card
        private Dictionary<string, string> cardsNames = new Dictionary<string, string>();
        private Dictionary<int, string> protocols = new Dictionary<int, string>();



        //- Segundo procedimiento

        int retCode;
        int hCard;
        int hContext;
        int Protocol;
        public bool connActive = false;
        string readername = "ACS ACR122 0";      // change depending on reader
        public byte[] SendBuff = new byte[263];
        public byte[] RecvBuff = new byte[263];
        public int SendLen, RecvLen, nBytesRet, reqType, Aprotocol, dwProtocol, cbPciLength;
        int bandera = 0;

        private Card.SCARD_READERSTATE RdrState;

        public Form1()
        {
            InitializeComponent();
            SelectDevice();
            establishContext();
         //   pctFeliz.Image = Properties.Resources.caraFeliz;
            btnSubirImagenBio.Visible = false;
            btnGuardarHuella.Visible = false;
        }


        public bool connectCard()
        {
            connActive = true;

            retCode = Card.SCardConnect(hContext, readername, Card.SCARD_SHARE_SHARED,
                      Card.SCARD_PROTOCOL_T0 | Card.SCARD_PROTOCOL_T1, ref hCard, ref Protocol);

            if (retCode != Card.SCARD_S_SUCCESS)
            {
                MessageBox.Show(Card.GetScardErrMsg(retCode), "Tarjeta no disponible");
                connActive = false;
                return false;
            }
            return true;
        }

        private string getcardUID()//only for mifare 1k cards
        {
            byte[] receivedUID = new byte[256];
            Card.SCARD_IO_REQUEST request = new Card.SCARD_IO_REQUEST();
            request.dwProtocol = Card.SCARD_PROTOCOL_T1;
            request.cbPciLength = System.Runtime.InteropServices.Marshal.SizeOf(typeof(Card.SCARD_IO_REQUEST));
            byte[] sendBytes = new byte[] { 0xFF, 0xCA, 0x00, 0x00, 0x00 }; //get UID command      for Mifare cards
            int outBytes = receivedUID.Length;
            int status = Card.SCardTransmit(hCard, ref request, ref sendBytes[0], sendBytes.Length, ref request, ref receivedUID[0], ref outBytes);
            string cardUID;
            if (status != Card.SCARD_S_SUCCESS)
            {
                cardUID = "Error";
            }
            else
            {
                cardUID = BitConverter.ToString(receivedUID.Take(4).ToArray()).Replace("-", string.Empty).ToLower();
            }

            return cardUID;
        }


        public void SelectDevice()
        {
            // List<string> availableReaders = new List<string>(new string[] {"lala"}) ;//this.ListReaders();
            List<string> availableReaders =this.ListReaders();
            this.RdrState = new Card.SCARD_READERSTATE();
            readername = availableReaders[0].ToString();//selecting first device
            this.RdrState.RdrName = readername;
        }


        public List<string> ListReaders()
        {
            int ReaderCount = 0;
            List<string> AvailableReaderList = new List<string>();

            //Make sure a context has been established before 
            //retrieving the list of smartcard readers.
            retCode = Card.SCardListReaders(hContext, null, null, ref ReaderCount);
            if (retCode != Card.SCARD_S_SUCCESS)
            {
                MessageBox.Show(Card.GetScardErrMsg(retCode));
                //connActive = false;
            }

            byte[] ReadersList = new byte[ReaderCount];

            //Get the list of reader present again but this time add sReaderGroup, retData as 2rd & 3rd parameter respectively.
            retCode = Card.SCardListReaders(hContext, null, ReadersList, ref ReaderCount);
            if (retCode != Card.SCARD_S_SUCCESS)
            {
                MessageBox.Show(Card.GetScardErrMsg(retCode));
            }

            string rName = "";
            int indx = 0;
            if (ReaderCount > 0)
            {
                // Convert reader buffer to string
                while (ReadersList[indx] != 0)
                {

                    while (ReadersList[indx] != 0)
                    {
                        rName = rName + (char)ReadersList[indx];
                        indx += 1;
                    }

                    //Add reader name to list
                    AvailableReaderList.Add(rName);
                    rName = "";
                    indx += 1;

                }
            }
            return AvailableReaderList;

        }

        internal void establishContext()
        {
            retCode = Card.SCardEstablishContext(Card.SCARD_SCOPE_SYSTEM, 0, 0, ref hContext);
            if (retCode != Card.SCARD_S_SUCCESS)
            {

                MessageBox.Show("Por favor revise el dispositivo e intente de nuevo", "Lector no conectado");
                connActive = false;
                return;
            }
        }



        private void loadProtocols()
        {
            protocols.Add(0, "Información no dada");
            protocols.Add(1, "ISO 14443 A, level 1");
            protocols.Add(2, "ISO 14443 A, level 2");
            protocols.Add(3, "ISO 14443 A, level 3 or 4 (y Mifare)");
            protocols.Add(5, "ISO 14443 B, level 1");
            protocols.Add(6, "ISO 14443 B, level 2");
            protocols.Add(7, "ISO 14443 B, level 3 o 4");
            protocols.Add(9, "ICODE 1");
            protocols.Add(11, "ISO 15693");
        }

        private void loadCardsNames()
        {
            cardsNames.Add("0001", "NXP Mifare Standard 1k");
            cardsNames.Add("0002", "NXP Mifare Standard 4k");
            cardsNames.Add("0003", "NXP Mifare UltraLight, Other Type 2 NFC Tags(NFC Forum) with a capacity <= 64 bytes");
            cardsNames.Add("0006", "ST Micro Electronics SR176");
            cardsNames.Add("0007", "ST Micro Electronics SRI4K, SRIX4K, SRIX512, SRI512, SRT512");
            cardsNames.Add("000A", "Atmel AT88SC0808CRF");
            cardsNames.Add("000B", "Atmel AT88SC1616CRF");
            cardsNames.Add("000C", "Atmel AT88SC3216CRF");
            cardsNames.Add("000D", "Atmel AT88SC6416CRF");
            cardsNames.Add("0012", "Texas Instruments TAG IT");
            cardsNames.Add("0013", "ST Micro Electronics LRI512");
            cardsNames.Add("0014", "NXP ICODE SLI");
            cardsNames.Add("0015", "NXP ICODE1");
            cardsNames.Add("0021", "ST Micro Electronics LRI64");
            cardsNames.Add("0024", "ST Micro Electronics LR12");
            cardsNames.Add("0025", "ST Micro Electronics LRI128");
            cardsNames.Add("0026", "NXP Mifare Mini");
            cardsNames.Add("002F", "Innovision Jewel");
            cardsNames.Add("0030", "Innovision Topaz (NFC Forum type 1 tag)");
            cardsNames.Add("0034", "Atmel AT88RF04C");
            cardsNames.Add("0035", "NXP ICODE SL2");
            cardsNames.Add("003A", "NXP Mifare UltraLight C. Other Type 2 NFC Tags(NFC Forum) with a capacity > 64 bytes");
            cardsNames.Add("FFA0", "Generic/unknown 14443-A card");
            cardsNames.Add("FFA1", "Kovio RF barcode");
            cardsNames.Add("FFB0", "Generic/unknown 14443-B card");
            cardsNames.Add("FFB1", "ASK CTS 256B");
            cardsNames.Add("FFB2", "ASK CTS 512B");
            cardsNames.Add("FFB3", "Pre-standard ST Micro Electronics SRI 4K");
            cardsNames.Add("FFB4", "Pre-standard ST Micro Electronics SRI X512");
            cardsNames.Add("FFB5", "Pre-standard ST Micro Electronics SRI 512");
            cardsNames.Add("FFB6", "Pre-standard ST Micro Electronics SRT 512");
            cardsNames.Add("FFB7", "Inside Contactless PICOTAG/PICOPASS");
            cardsNames.Add("FFB8", "Generic Atmel AT88SC / AT88RF card");
            cardsNames.Add("FFC0", "Calypso card using the Innovatron protoco");
            cardsNames.Add("FFD0", "Generic ISO 15693 from unknown manufacturer");
            cardsNames.Add("FFD1", "Generic ISO 15693 from EM Marin (or Legic)");
            cardsNames.Add("FFD2", "Generic ISO 15693 from ST Micro Electronics, block number on 8 bits");
            cardsNames.Add("FFD3", "Generic ISO 15693 from ST Micro Electronics, block number on 16");
            cardsNames.Add("FFFF", "Virtual card (test only)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProtocols();
            loadCardsNames();
            refreshReaders();
            lblProtocol.Text = "";
            lblStatus.Text = "";
            lblCardAtr.Text = "";
            lblCardUid.Text = "";
            lblCardType.Text = "";
         
        }

        private void refreshReaders()
        {
            cbReaders.Items.Clear();
            try
            {
                string[] readers = SCARD.Readers;
                foreach (string reader in readers)
                    cbReaders.Items.Add(reader);

                if(cbReaders.Items.Count > 0)
                    cbReaders.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Hay algún problema en la busqueda de la lista de lectores, puede que no este conectado");
                
        }
            
        }




        //zona biometrica
        private void BtnSubirImagenBio_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // Filtro de imagenes   
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // muestra la imagen en el pictureBox
                pctFoto.Image = new Bitmap(open.FileName);
                pctFoto.SizeMode = PictureBoxSizeMode.StretchImage;
             
                //guarda la extensión de la imagen

                string ext = Path.GetExtension(open.FileName);
                //  MessageBox.Show(ext);
                //    ext = ext.ToLower();

                // Guarda en un string la ruta
                string ruta = conexion.RutaImg;

                // ruta de la imagen captada
                lblRutaBio.Text = open.FileName;
                pctFoto.Image.Save(ruta + txtCedula.Text + ext, ImageFormat.Jpeg);
    
                conexion.Cedula = txtCedula.Text;
                MessageBox.Show("La imagen ha sido cargada satisfactoriamente!");
                bandera = 1;
            }
        }

        private void BtnHuella_Click(object sender, EventArgs e)
        {


            capturarHuella capturar = new capturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }

        public void SetText(string str) {

            lblPruebas.Text = str;
        }


        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
               
                btnGuardarHuella.Enabled = (Template != null);
                btnSubirImagenBio.Enabled = (Template != null);
                btnSubirImagenBio.Visible = true;
                btnGuardarHuella.Visible = true;
             

                if (Template != null)
                {
                    MessageBox.Show("La imprensión de huella esta verificada y lista para su captura.", "Impresión de huella");
                    lblRutaBio.Text = "Huella fue capturada correctamente";
                    txtCedula.Text = conexion.Cedula;
   

                }
                else
                {
                    MessageBox.Show("La impresión no es valida. Vuelva a repetir la impresión.", "Impresión de huella");
                }
            }));
        }

        private void BtnGuardarHuella_Click(object sender, EventArgs e)
        {
            byte[] streamHuella = Template.Bytes;


            if (txtCedula.Text == "") {
                MessageBox.Show("Por favor llene espacio de la cédula.");
            }
            else if (lblUid2.Text == "") {
                MessageBox.Show("Por favor acerque el brazalete para su captura");
            }
            else if (bandera==0) {
                MessageBox.Show("Por favor suba la imagen del atleta.");
            }
            else {
                string gato = "";
                string aux = "Data Source=" + conexion.Fuente + ";Initial Catalog=" + conexion.Catalogo + ";User ID=" + conexion.User + ";Password=" + conexion.Password + "";
                //   string aux = "Data Source=" + conexion.Fuente + ";Initial Catalog=" + conexion.Catalogo + ";integrated security = true;";
                SqlConnection conn = new SqlConnection(aux);
                conn.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_info";


                // @salida

                //pase de parametros a proceso de almacenamiento
                cmd.Parameters.Add(new SqlParameter("@cedula", SqlDbType.VarChar)).Value = txtCedula.Text;
                cmd.Parameters.Add(new SqlParameter("@huellero", SqlDbType.VarBinary)).Value = streamHuella;
                cmd.Parameters.Add(new SqlParameter("@brazalete", SqlDbType.VarChar)).Value = lblUid2.Text;
                cmd.Parameters.Add(new SqlParameter("@mensaje", SqlDbType.VarChar)).Value = "";
                //devuelve el valor del stores
                cmd.Parameters["@mensaje"].Direction = ParameterDirection.Output;


                int res = cmd.ExecuteNonQuery();
                gato = Convert.ToString(cmd.Parameters["@mensaje"].Value);
                switch (gato) {
                    case "Y":
                        gato = "Ya tiene una huella registrada";
                        break;
                    case "S":
                        gato = "Se inserto exitosamente el registro";
                        break;
                    case "N":
                        gato = "No esta registrado en el sistema";
                        break;
                    default:
                        MessageBox.Show("Fuera de rango");
                        break;
                }

                if (res > 0)
                {
                    MessageBox.Show("Usuario insertado satisfactoriamente,  " + gato);
                }
                else
                {
                    MessageBox.Show("No insertado");
                    MessageBox.Show(res + "");
                }

                conn.Close();
                // se coloca el template en null para volver hacer otra lectura
                Template = null;

                btnSubirImagenBio.Enabled = false;
                btnGuardarHuella.Enabled = false;
                btnSubirImagenBio.Visible = false;
                btnGuardarHuella.Visible = false;

                bandera = 0;

            }
          


        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            verificarHuella verificar = new verificarHuella();
            verificar.ShowDialog();

        }


        //fin zona biometrica












        private void cbReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReaders.SelectedIndex == -1)
                return;

            if (reader != null)
                reader.StopMonitor();

            try
            {
                string readerName = this.cbReaders.GetItemText(cbReaders.SelectedItem);
                reader = new SCardReader(readerName);
                reader.StartMonitor(readerStatusChanged);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hay un error mientras se esta creado el objeto de lectoras : " + Ex.Message);
                
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshReaders();
        }

        delegate void readerStatusChangedInvoker(uint readerState, CardBuffer cardAtr);

        /// <summary>
        /// Callback used when the reader's status change
        /// As this method is called from a thread, you can't directly modify the user interface
        /// </summary>
        /// <param name="readerState"></param>
        /// <param name="cardAtr"></param>
        private void readerStatusChanged(uint readerState, CardBuffer cardAtr)
        {
            // When you are in a thread you can't directly modify the user interface
            if (InvokeRequired)
            {
                this.BeginInvoke(new readerStatusChangedInvoker(readerStatusChanged), readerState, cardAtr);
                
                return;
            }

			lblCardUid.Text = "";
            lblCardAtr.Text = "";
            lblCardType.Text = "";
            lblProtocol.Text = "";

      
            lblMonto.BackColor = Color.FromArgb(240, 240, 240);

            pctColor.BackColor = Color.FromArgb(255, 0, 0);


          //  pctFoto.Image = Properties.Resources.atleta;


            lblStatus.Text = SCARD.ReaderStatusToString(readerState);
           
            if (cardAtr != null)
            {
                lblCardAtr.Text = cardAtr.AsString(" ");
                channel = new SCardChannel(reader);


                pctColor.BackColor = Color.FromArgb(121, 174, 235);
          
              //   pctFoto.Image = Properties.Resources.atleta;
             //    pctFoto.SizeMode = PictureBoxSizeMode.StretchImage;

              
                    lblCedula.Text = "Cédula: ";
                    lblId.Text = "Identificación: ";
                    lblEstatus.Text = "Cobrado: ";
                    lblTotal.Text = "Total: ";
                    lblMonto.Text = "Retraso: ";
                    lblNombreNino.Text = "";
                    lblDeporteNino.Text = "";

                    pctFoto.Image = Properties.Resources.atleta;
                    pctCara.Image = Properties.Resources.blanco;

                if (!channel.Connect())
                {
                    lblCardUid.Text = "Error, no puede connectar la tarjeta";
                    
                    return;
                }
                CAPDU capdu = new CAPDU(0xFF, 0xCA, 0x00, 0x00);    // Command sent to the reader
                RAPDU rapdu = channel.Transmit(capdu);              // Response sent from card
                
                if (connectCard())
                {
                    string cardUID = getcardUID();
                    lblCardUid.Text = cardUID;
                    lblUid2.Text = cardUID;
                    lblST.Text = "OK";
                    lblST.ForeColor = Color.FromArgb(34, 177, 76);



                    string aux = "Data Source=" + conexion.Fuente + ";Initial Catalog=" + conexion.Catalogo + ";User ID=" + conexion.User + ";Password=" + conexion.Password;


                    SqlConnection conn = new SqlConnection(aux);
                    string consulta = "Select * from datos where brasalete =@zip";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(consulta, conn);
                        cmd.Parameters.AddWithValue("@zip", cardUID);

                        conn.Open();
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader dr = cmd.ExecuteReader();


                        while (dr.Read())
                        {

                            //   pctFoto.Image = Properties.Resources.lala;
                           pctFoto.Image = new Bitmap(conexion.RutaImg + dr[1].ToString() + ".jpg");
                           pctFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                            lblId.Text = "Identificación: " + dr[0].ToString();
                            lblCedula.Text = "Cédula: " + dr[1].ToString();
                            lblTotal.Text = " Total: B/. " + dr[3].ToString();
                            lblEstatus.Text = "Cobrado:  B/. " + dr[4].ToString() + "  " + "Pendiente: B/. " + dr[5].ToString();

                            lblNombreNino.Text = dr[0].ToString();
                            lblDeporteNino.Text = dr[2].ToString();

                            string monto = dr[10].ToString();
                            lblMonto.Text = "Retraso: " + monto + "  Meses";
                            switch (monto)
                            {
                                case "1":
                                    // celeste
                                    lblMonto.ForeColor = Color.FromArgb(121, 174, 235);
                                    pctCara.Image = Properties.Resources.caraFeliz;
                                    break;
                                case "2":
                                    // amarillo
                                    lblMonto.BackColor = Color.FromArgb(255, 247, 0);
                                    pctCara.Image = Properties.Resources.caraTriste;
                                    //  pctFoto.
                                    break;
                                case "3":
                                    // rojo
                                    lblMonto.ForeColor = Color.FromArgb(255, 0, 0);
                                    pctCara.Image = Properties.Resources.llorando;
                                    break;
                          
                                // rojo
                                default:
                                    lblMonto.ForeColor = Color.FromArgb(255, 0, 0);
                                    pctCara.Image = Properties.Resources.blanco;
                                    break;
                            }


                            dr.GetString(1);
                            break;

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



                }//fin de connect card()
                //----------------------------------------------------------------



                /*

                if (rapdu.SW != 0x9000)                              // Something failed
                {
                    lblCardUid.Text = "Get UID APDU fallido!";
                    return;
                }
                */
                // Display card's UID formated as an hexadecimal string
                /*
                byte[] rapduB = rapdu.data.GetBytes();
                string hexadecimalResult = BitConverter.ToString(rapduB);

                lblCardUid.Text = hexadecimalResult.Replace("-", " ");
                */
            

                // Card's type
                if (cardAtr.Length >= 19)
                {
                    // Card's protocol
                    int cardProdocol = cardAtr[12];
                    if (protocols.ContainsKey(cardProdocol))
                        lblProtocol.Text = protocols[cardProdocol];

                    if (cardAtr[4] == 0x80 && cardAtr[5] == 0x4F && cardAtr[6] == 0x0C && cardAtr[7] == 0xA0 && cardAtr[8] == 0x00 && cardAtr[9] == 0x00 && cardAtr[10] == 0x03 && cardAtr[11] == 0x06)
                    {
                        string pixSs = cardAtr[13].ToString("X2") + cardAtr[14].ToString("X2");
                        lblCardType.Text = "Wired-logic: ";
                        if (cardsNames.ContainsKey(pixSs))
                            lblCardType.Text += cardsNames[pixSs];
                    }
                    else
                    {
                        lblCardType.Text = "Desconocido tipo de tarjeta";
                    }
                }
                else
                {

                
                    lblCardType.Text = "Smartcard";
                }
            }                
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Stop properly
            if (channel != null)
            {
                channel.Disconnect();
                channel = null;
            }

            if (reader != null)
            {
                reader.StopMonitor();
                reader = null;
            }
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            ventaConfig configuracion = new ventaConfig();
            configuracion.ShowDialog();

        }
    }
}
