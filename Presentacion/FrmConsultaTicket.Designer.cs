﻿namespace CapaPresentacion
{
    partial class FrmConsultaTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAbierto = new System.Windows.Forms.RadioButton();
            this.rbCerrado = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.btnCajero = new System.Windows.Forms.Button();
            this.txtIdCajero = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.txtNombreCajero = new System.Windows.Forms.TextBox();
            this.txtTextoAbierto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCuandreAbierto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCuandoEntregado = new System.Windows.Forms.Label();
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalirConsultaTurno = new System.Windows.Forms.Button();
            this.btnCierreConsultaTurno = new System.Windows.Forms.Button();
            this.btnImprimirConsultaTurno = new System.Windows.Forms.Button();
            this.btnBuscarConsultaTurno = new System.Windows.Forms.Button();
            this.dgvIdUso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesde.ForeColor = System.Drawing.Color.White;
            this.lblDesde.Location = new System.Drawing.Point(80, 63);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(66, 20);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "DESDE";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(282, 63);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(63, 20);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "HASTA";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(16, 116);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(69, 18);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "ESTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(192, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Consulta de Ticket";
            // 
            // rbAbierto
            // 
            this.rbAbierto.AutoSize = true;
            this.rbAbierto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbAbierto.ForeColor = System.Drawing.Color.White;
            this.rbAbierto.Location = new System.Drawing.Point(103, 115);
            this.rbAbierto.Margin = new System.Windows.Forms.Padding(2);
            this.rbAbierto.Name = "rbAbierto";
            this.rbAbierto.Size = new System.Drawing.Size(78, 24);
            this.rbAbierto.TabIndex = 10;
            this.rbAbierto.TabStop = true;
            this.rbAbierto.Text = "Abierto";
            this.rbAbierto.UseVisualStyleBackColor = true;
            // 
            // rbCerrado
            // 
            this.rbCerrado.AutoSize = true;
            this.rbCerrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbCerrado.ForeColor = System.Drawing.Color.White;
            this.rbCerrado.Location = new System.Drawing.Point(254, 115);
            this.rbCerrado.Margin = new System.Windows.Forms.Padding(2);
            this.rbCerrado.Name = "rbCerrado";
            this.rbCerrado.Size = new System.Drawing.Size(84, 24);
            this.rbCerrado.TabIndex = 11;
            this.rbCerrado.TabStop = true;
            this.rbCerrado.Text = "Cerrado";
            this.rbCerrado.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(411, 115);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(2);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(71, 24);
            this.rbTodos.TabIndex = 12;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // btnCajero
            // 
            this.btnCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.btnCajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCajero.ForeColor = System.Drawing.Color.White;
            this.btnCajero.Location = new System.Drawing.Point(20, 63);
            this.btnCajero.Margin = new System.Windows.Forms.Padding(2);
            this.btnCajero.Name = "btnCajero";
            this.btnCajero.Size = new System.Drawing.Size(56, 21);
            this.btnCajero.TabIndex = 13;
            this.btnCajero.Text = "Cajero";
            this.btnCajero.UseVisualStyleBackColor = false;
            // 
            // txtIdCajero
            // 
            this.txtIdCajero.Location = new System.Drawing.Point(20, 93);
            this.txtIdCajero.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCajero.Name = "txtIdCajero";
            this.txtIdCajero.Size = new System.Drawing.Size(57, 20);
            this.txtIdCajero.TabIndex = 14;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(172, 63);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(105, 23);
            this.dtpDesde.TabIndex = 15;
            this.dtpDesde.Value = new System.DateTime(2020, 9, 25, 22, 34, 59, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(392, 64);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(105, 23);
            this.dtpHasta.TabIndex = 16;
            this.dtpHasta.Value = new System.DateTime(2020, 9, 25, 22, 34, 59, 0);
            // 
            // txtNombreCajero
            // 
            this.txtNombreCajero.Location = new System.Drawing.Point(83, 93);
            this.txtNombreCajero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCajero.Name = "txtNombreCajero";
            this.txtNombreCajero.Size = new System.Drawing.Size(414, 20);
            this.txtNombreCajero.TabIndex = 17;
            // 
            // txtTextoAbierto
            // 
            this.txtTextoAbierto.Location = new System.Drawing.Point(16, 143);
            this.txtTextoAbierto.Margin = new System.Windows.Forms.Padding(2);
            this.txtTextoAbierto.Name = "txtTextoAbierto";
            this.txtTextoAbierto.Size = new System.Drawing.Size(699, 20);
            this.txtTextoAbierto.TabIndex = 18;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(17, 499);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(84, 17);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad : 0";
            // 
            // lblCuandreAbierto
            // 
            this.lblCuandreAbierto.AutoSize = true;
            this.lblCuandreAbierto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCuandreAbierto.ForeColor = System.Drawing.Color.White;
            this.lblCuandreAbierto.Location = new System.Drawing.Point(699, 499);
            this.lblCuandreAbierto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuandreAbierto.Name = "lblCuandreAbierto";
            this.lblCuandreAbierto.Size = new System.Drawing.Size(95, 17);
            this.lblCuandreAbierto.TabIndex = 20;
            this.lblCuandreAbierto.Text = "Ticket Abierto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(959, 499);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cuadre Cerrado";
            // 
            // lblCuandoEntregado
            // 
            this.lblCuandoEntregado.AutoSize = true;
            this.lblCuandoEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCuandoEntregado.ForeColor = System.Drawing.Color.White;
            this.lblCuandoEntregado.Location = new System.Drawing.Point(825, 499);
            this.lblCuandoEntregado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuandoEntregado.Name = "lblCuandoEntregado";
            this.lblCuandoEntregado.Size = new System.Drawing.Size(116, 17);
            this.lblCuandoEntregado.TabIndex = 22;
            this.lblCuandoEntregado.Text = "Ticket Entregado";
            // 
            // dtgvTicket
            // 
            this.dtgvTicket.AllowUserToAddRows = false;
            this.dtgvTicket.AllowUserToDeleteRows = false;
            this.dtgvTicket.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdUso,
            this.dgvFechaEntrada,
            this.dgvFechaSalida,
            this.dgvEmpleado,
            this.dgvTiempo,
            this.dgvTotal,
            this.dgvDescuento,
            this.dgvNeto,
            this.dgvEstado});
            this.dtgvTicket.EnableHeadersVisualStyles = false;
            this.dtgvTicket.Location = new System.Drawing.Point(14, 166);
            this.dtgvTicket.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvTicket.Name = "dtgvTicket";
            this.dtgvTicket.ReadOnly = true;
            this.dtgvTicket.RowHeadersVisible = false;
            this.dtgvTicket.RowHeadersWidth = 51;
            this.dtgvTicket.RowTemplate.Height = 24;
            this.dtgvTicket.Size = new System.Drawing.Size(1054, 326);
            this.dtgvTicket.TabIndex = 27;
            this.dtgvTicket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgvTicket_MouseDown);
            this.dtgvTicket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtgvTicket_MouseUp);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CapaPresentacion.Properties.Resources.Ok_50px;
            this.pictureBox8.Location = new System.Drawing.Point(937, 499);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 16);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CapaPresentacion.Properties.Resources.Circled_Pause_50px;
            this.pictureBox7.Location = new System.Drawing.Point(801, 499);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 16);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaPresentacion.Properties.Resources.Circled_Pause_5033px;
            this.pictureBox6.Location = new System.Drawing.Point(678, 499);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 16);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.Calendar_31_64px;
            this.pictureBox4.Location = new System.Drawing.Point(343, 65);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.Calendar_31_64px;
            this.pictureBox3.Location = new System.Drawing.Point(141, 64);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Search_52px;
            this.pictureBox2.Location = new System.Drawing.Point(14, 144);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Search_52px;
            this.pictureBox1.Location = new System.Drawing.Point(164, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalirConsultaTurno
            // 
            this.btnSalirConsultaTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.btnSalirConsultaTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirConsultaTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalirConsultaTurno.ForeColor = System.Drawing.Color.White;
            this.btnSalirConsultaTurno.Image = global::CapaPresentacion.Properties.Resources.Exit_64px;
            this.btnSalirConsultaTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirConsultaTurno.Location = new System.Drawing.Point(612, 100);
            this.btnSalirConsultaTurno.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirConsultaTurno.Name = "btnSalirConsultaTurno";
            this.btnSalirConsultaTurno.Size = new System.Drawing.Size(102, 40);
            this.btnSalirConsultaTurno.TabIndex = 9;
            this.btnSalirConsultaTurno.Text = "Salir";
            this.btnSalirConsultaTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalirConsultaTurno.UseVisualStyleBackColor = false;
            this.btnSalirConsultaTurno.Click += new System.EventHandler(this.btnSalirConsultaTurno_Click);
            // 
            // btnCierreConsultaTurno
            // 
            this.btnCierreConsultaTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.btnCierreConsultaTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCierreConsultaTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCierreConsultaTurno.ForeColor = System.Drawing.Color.White;
            this.btnCierreConsultaTurno.Image = global::CapaPresentacion.Properties.Resources.registrar1;
            this.btnCierreConsultaTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCierreConsultaTurno.Location = new System.Drawing.Point(612, 55);
            this.btnCierreConsultaTurno.Margin = new System.Windows.Forms.Padding(2);
            this.btnCierreConsultaTurno.Name = "btnCierreConsultaTurno";
            this.btnCierreConsultaTurno.Size = new System.Drawing.Size(102, 40);
            this.btnCierreConsultaTurno.TabIndex = 8;
            this.btnCierreConsultaTurno.Text = "Cierre";
            this.btnCierreConsultaTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCierreConsultaTurno.UseVisualStyleBackColor = false;
            // 
            // btnImprimirConsultaTurno
            // 
            this.btnImprimirConsultaTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.btnImprimirConsultaTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirConsultaTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnImprimirConsultaTurno.ForeColor = System.Drawing.Color.White;
            this.btnImprimirConsultaTurno.Image = global::CapaPresentacion.Properties.Resources.PRINTERPEQ;
            this.btnImprimirConsultaTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirConsultaTurno.Location = new System.Drawing.Point(500, 100);
            this.btnImprimirConsultaTurno.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimirConsultaTurno.Name = "btnImprimirConsultaTurno";
            this.btnImprimirConsultaTurno.Size = new System.Drawing.Size(102, 40);
            this.btnImprimirConsultaTurno.TabIndex = 7;
            this.btnImprimirConsultaTurno.Text = "Imprimir";
            this.btnImprimirConsultaTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImprimirConsultaTurno.UseVisualStyleBackColor = false;
            // 
            // btnBuscarConsultaTurno
            // 
            this.btnBuscarConsultaTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.btnBuscarConsultaTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarConsultaTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBuscarConsultaTurno.ForeColor = System.Drawing.Color.White;
            this.btnBuscarConsultaTurno.Image = global::CapaPresentacion.Properties.Resources.BUSCARPEQ_;
            this.btnBuscarConsultaTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarConsultaTurno.Location = new System.Drawing.Point(500, 55);
            this.btnBuscarConsultaTurno.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarConsultaTurno.Name = "btnBuscarConsultaTurno";
            this.btnBuscarConsultaTurno.Size = new System.Drawing.Size(102, 40);
            this.btnBuscarConsultaTurno.TabIndex = 6;
            this.btnBuscarConsultaTurno.Text = "Buscar";
            this.btnBuscarConsultaTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarConsultaTurno.UseVisualStyleBackColor = false;
            this.btnBuscarConsultaTurno.Click += new System.EventHandler(this.btnBuscarConsultaTurno_Click);
            // 
            // dgvIdUso
            // 
            this.dgvIdUso.HeaderText = "TICKET NO.";
            this.dgvIdUso.Name = "dgvIdUso";
            this.dgvIdUso.ReadOnly = true;
            // 
            // dgvFechaEntrada
            // 
            this.dgvFechaEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFechaEntrada.HeaderText = "FECHA ENTRADA";
            this.dgvFechaEntrada.Name = "dgvFechaEntrada";
            this.dgvFechaEntrada.ReadOnly = true;
            this.dgvFechaEntrada.Width = 112;
            // 
            // dgvFechaSalida
            // 
            this.dgvFechaSalida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFechaSalida.HeaderText = "FECHA SALIDA";
            this.dgvFechaSalida.Name = "dgvFechaSalida";
            this.dgvFechaSalida.ReadOnly = true;
            this.dgvFechaSalida.Width = 99;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEmpleado.HeaderText = "CAJERO";
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            // 
            // dgvTiempo
            // 
            this.dgvTiempo.HeaderText = "TIEMPO (MIN)";
            this.dgvTiempo.Name = "dgvTiempo";
            this.dgvTiempo.ReadOnly = true;
            // 
            // dgvTotal
            // 
            this.dgvTotal.HeaderText = "TOTAL";
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            // 
            // dgvDescuento
            // 
            this.dgvDescuento.HeaderText = "DESCUENTO";
            this.dgvDescuento.Name = "dgvDescuento";
            this.dgvDescuento.ReadOnly = true;
            // 
            // dgvNeto
            // 
            this.dgvNeto.HeaderText = "NETO";
            this.dgvNeto.Name = "dgvNeto";
            this.dgvNeto.ReadOnly = true;
            // 
            // dgvEstado
            // 
            this.dgvEstado.HeaderText = "ESTADO";
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            // 
            // FrmConsultaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1079, 525);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dtgvTicket);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCuandoEntregado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCuandreAbierto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtTextoAbierto);
            this.Controls.Add(this.txtNombreCajero);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.txtIdCajero);
            this.Controls.Add(this.btnCajero);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.rbCerrado);
            this.Controls.Add(this.rbAbierto);
            this.Controls.Add(this.btnSalirConsultaTurno);
            this.Controls.Add(this.btnCierreConsultaTurno);
            this.Controls.Add(this.btnImprimirConsultaTurno);
            this.Controls.Add(this.btnBuscarConsultaTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConsultaTicket";
            this.Text = "frmConsultaTurno";
            this.Load += new System.EventHandler(this.frmConsultaTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarConsultaTurno;
        private System.Windows.Forms.Button btnImprimirConsultaTurno;
        private System.Windows.Forms.Button btnCierreConsultaTurno;
        private System.Windows.Forms.Button btnSalirConsultaTurno;
        private System.Windows.Forms.RadioButton rbAbierto;
        private System.Windows.Forms.RadioButton rbCerrado;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Button btnCajero;
        private System.Windows.Forms.TextBox txtIdCajero;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.TextBox txtNombreCajero;
        private System.Windows.Forms.TextBox txtTextoAbierto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCuandreAbierto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCuandoEntregado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dtgvTicket;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdUso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
    }
}