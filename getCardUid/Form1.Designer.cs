namespace getCardUid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbReaders = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCardAtr = new System.Windows.Forms.Label();
            this.lblCardUid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCardType = new System.Windows.Forms.TextBox();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnHuella = new System.Windows.Forms.Button();
            this.btnSubirImagenBio = new System.Windows.Forms.Button();
            this.lblRutaBio = new System.Windows.Forms.Label();
            this.btnGuardarHuella = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPruebas = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNombreNino = new System.Windows.Forms.Label();
            this.lblDeporteNino = new System.Windows.Forms.Label();
            this.lblUid2 = new System.Windows.Forms.Label();
            this.lblST = new System.Windows.Forms.Label();
            this.lblMexico = new System.Windows.Forms.Label();
            this.pctCara = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pctColor = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lectora conectada";
            // 
            // cbReaders
            // 
            this.cbReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReaders.FormattingEnabled = true;
            this.cbReaders.Location = new System.Drawing.Point(134, 23);
            this.cbReaders.Name = "cbReaders";
            this.cbReaders.Size = new System.Drawing.Size(161, 21);
            this.cbReaders.TabIndex = 1;
            this.cbReaders.SelectedIndexChanged += new System.EventHandler(this.cbReaders_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(336, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Estatus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ATR:";
            // 
            // lblCardAtr
            // 
            this.lblCardAtr.AutoSize = true;
            this.lblCardAtr.Location = new System.Drawing.Point(46, 55);
            this.lblCardAtr.Name = "lblCardAtr";
            this.lblCardAtr.Size = new System.Drawing.Size(344, 13);
            this.lblCardAtr.TabIndex = 5;
            this.lblCardAtr.Text = "XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX";
            // 
            // lblCardUid
            // 
            this.lblCardUid.AutoSize = true;
            this.lblCardUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardUid.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblCardUid.Location = new System.Drawing.Point(38, 77);
            this.lblCardUid.Name = "lblCardUid";
            this.lblCardUid.Size = new System.Drawing.Size(83, 16);
            this.lblCardUid.TabIndex = 7;
            this.lblCardUid.Text = "XX XX XX X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "UID:";
            // 
            // lblCardType
            // 
            this.lblCardType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCardType.Location = new System.Drawing.Point(12, 59);
            this.lblCardType.Multiline = true;
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.ReadOnly = true;
            this.lblCardType.Size = new System.Drawing.Size(496, 31);
            this.lblCardType.TabIndex = 11;
            this.lblCardType.Text = "xxxxxxxxxx";
            this.lblCardType.Visible = false;
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Location = new System.Drawing.Point(65, 99);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(21, 13);
            this.lblProtocol.TabIndex = 13;
            this.lblProtocol.Text = "XX";
            this.lblProtocol.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Protocolo:";
            this.label7.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sistema de identificación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctFoto);
            this.groupBox1.Controls.Add(this.lblCedula);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(148, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 299);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ATLETA";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(49, 268);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(127, 16);
            this.lblCedula.TabIndex = 29;
            this.lblCedula.Text = "00-00-0000-00000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Zona Lectora";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(76, 477);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(163, 20);
            this.txtCedula.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cédula:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMexico);
            this.groupBox2.Controls.Add(this.lblST);
            this.groupBox2.Controls.Add(this.lblUid2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnSubirImagenBio);
            this.groupBox2.Controls.Add(this.lblRutaBio);
            this.groupBox2.Controls.Add(this.btnGuardarHuella);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblCardUid);
            this.groupBox2.Controls.Add(this.btnConfig);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCedula);
            this.groupBox2.Controls.Add(this.cbReaders);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCardAtr);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.pctColor);
            this.groupBox2.Controls.Add(this.lblCardType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblProtocol);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 655);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblMonto);
            this.groupBox3.Controls.Add(this.lblEstatus);
            this.groupBox3.Location = new System.Drawing.Point(12, 513);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 119);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Respuesta:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(8, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(6, 86);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(70, 20);
            this.lblMonto.TabIndex = 27;
            this.lblMonto.Text = "Retraso:";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(8, 62);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 13);
            this.lblEstatus.TabIndex = 26;
            this.lblEstatus.Text = "Estatus:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(19, 441);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(104, 16);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "Identificación:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnVerificar);
            this.groupBox4.Controls.Add(this.btnHuella);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(439, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 193);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zona Biometrica";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(54, 121);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(109, 51);
            this.btnVerificar.TabIndex = 39;
            this.btnVerificar.Text = "Verificar Huella";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // btnHuella
            // 
            this.btnHuella.Location = new System.Drawing.Point(54, 43);
            this.btnHuella.Name = "btnHuella";
            this.btnHuella.Size = new System.Drawing.Size(109, 53);
            this.btnHuella.TabIndex = 37;
            this.btnHuella.Text = "Capturar Huella";
            this.btnHuella.UseVisualStyleBackColor = true;
            this.btnHuella.Click += new System.EventHandler(this.BtnHuella_Click);
            // 
            // btnSubirImagenBio
            // 
            this.btnSubirImagenBio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubirImagenBio.Enabled = false;
            this.btnSubirImagenBio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubirImagenBio.Location = new System.Drawing.Point(571, 412);
            this.btnSubirImagenBio.Name = "btnSubirImagenBio";
            this.btnSubirImagenBio.Size = new System.Drawing.Size(109, 36);
            this.btnSubirImagenBio.TabIndex = 35;
            this.btnSubirImagenBio.Text = "Subir Imagen";
            this.btnSubirImagenBio.UseVisualStyleBackColor = false;
            this.btnSubirImagenBio.Click += new System.EventHandler(this.BtnSubirImagenBio_Click);
            // 
            // lblRutaBio
            // 
            this.lblRutaBio.AutoSize = true;
            this.lblRutaBio.Location = new System.Drawing.Point(9, 109);
            this.lblRutaBio.Name = "lblRutaBio";
            this.lblRutaBio.Size = new System.Drawing.Size(33, 13);
            this.lblRutaBio.TabIndex = 36;
            this.lblRutaBio.Text = "Ruta:";
            // 
            // btnGuardarHuella
            // 
            this.btnGuardarHuella.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardarHuella.Enabled = false;
            this.btnGuardarHuella.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarHuella.Location = new System.Drawing.Point(571, 468);
            this.btnGuardarHuella.Name = "btnGuardarHuella";
            this.btnGuardarHuella.Size = new System.Drawing.Size(109, 36);
            this.btnGuardarHuella.TabIndex = 27;
            this.btnGuardarHuella.Text = "Guardar";
            this.btnGuardarHuella.UseVisualStyleBackColor = false;
            this.btnGuardarHuella.Click += new System.EventHandler(this.BtnGuardarHuella_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(842, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 73);
            this.label9.TabIndex = 32;
            this.label9.Text = "Bienvenido";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPruebas
            // 
            this.lblPruebas.AutoSize = true;
            this.lblPruebas.Location = new System.Drawing.Point(724, 411);
            this.lblPruebas.Name = "lblPruebas";
            this.lblPruebas.Size = new System.Drawing.Size(116, 13);
            this.lblPruebas.TabIndex = 37;
            this.lblPruebas.Text = "Solo usar para pruebas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(713, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 31);
            this.label11.TabIndex = 35;
            this.label11.Text = "Nombre:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(713, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 31);
            this.label12.TabIndex = 36;
            this.label12.Text = "Deporte:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreNino
            // 
            this.lblNombreNino.AutoSize = true;
            this.lblNombreNino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNino.Location = new System.Drawing.Point(836, 448);
            this.lblNombreNino.Name = "lblNombreNino";
            this.lblNombreNino.Size = new System.Drawing.Size(0, 25);
            this.lblNombreNino.TabIndex = 37;
            this.lblNombreNino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDeporteNino
            // 
            this.lblDeporteNino.AutoSize = true;
            this.lblDeporteNino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteNino.Location = new System.Drawing.Point(838, 508);
            this.lblDeporteNino.Name = "lblDeporteNino";
            this.lblDeporteNino.Size = new System.Drawing.Size(0, 25);
            this.lblDeporteNino.TabIndex = 38;
            this.lblDeporteNino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUid2
            // 
            this.lblUid2.AutoSize = true;
            this.lblUid2.Location = new System.Drawing.Point(232, 78);
            this.lblUid2.Name = "lblUid2";
            this.lblUid2.Size = new System.Drawing.Size(0, 13);
            this.lblUid2.TabIndex = 37;
            // 
            // lblST
            // 
            this.lblST.AutoSize = true;
            this.lblST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblST.Location = new System.Drawing.Point(63, 158);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(22, 16);
            this.lblST.TabIndex = 38;
            this.lblST.Text = "St";
            // 
            // lblMexico
            // 
            this.lblMexico.AutoSize = true;
            this.lblMexico.Location = new System.Drawing.Point(6, 158);
            this.lblMexico.Name = "lblMexico";
            this.lblMexico.Size = new System.Drawing.Size(51, 13);
            this.lblMexico.TabIndex = 40;
            this.lblMexico.Text = "Brazalate";
            // 
            // pctCara
            // 
            this.pctCara.Location = new System.Drawing.Point(914, 166);
            this.pctCara.Name = "pctCara";
            this.pctCara.Size = new System.Drawing.Size(229, 211);
            this.pctCara.TabIndex = 33;
            this.pctCara.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(633, 11);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(57, 51);
            this.btnConfig.TabIndex = 15;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // pctFoto
            // 
            this.pctFoto.Image = global::getCardUid.Properties.Resources.atleta;
            this.pctFoto.Location = new System.Drawing.Point(12, 22);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(210, 236);
            this.pctFoto.TabIndex = 30;
            this.pctFoto.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(484, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(27, 30);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pctColor
            // 
            this.pctColor.Location = new System.Drawing.Point(301, 24);
            this.pctColor.Name = "pctColor";
            this.pctColor.Size = new System.Drawing.Size(30, 20);
            this.pctColor.TabIndex = 18;
            this.pctColor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 733);
            this.Controls.Add(this.lblPruebas);
            this.Controls.Add(this.lblDeporteNino);
            this.Controls.Add(this.lblNombreNino);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pctCara);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BioLectora";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbReaders;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCardAtr;
        private System.Windows.Forms.Label lblCardUid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox lblCardType;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pctColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnGuardarHuella;
        private System.Windows.Forms.Button btnSubirImagenBio;
        private System.Windows.Forms.Button btnHuella;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblRutaBio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Label lblPruebas;
        private System.Windows.Forms.PictureBox pctCara;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNombreNino;
        private System.Windows.Forms.Label lblDeporteNino;
        private System.Windows.Forms.Label lblUid2;
        private System.Windows.Forms.Label lblST;
        private System.Windows.Forms.Label lblMexico;
    }
}

