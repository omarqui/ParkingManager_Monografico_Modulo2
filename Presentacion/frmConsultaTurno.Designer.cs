namespace CapaPresentacion
{
    partial class frmConsultaTurno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAbierto = new System.Windows.Forms.RadioButton();
            this.rbCerrado = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.btnCajero = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCuandreAbierto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCuandoEntregado = new System.Windows.Forms.Label();
            this.dtgvTurnos = new System.Windows.Forms.DataGridView();
            this.dgvIdTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMontoApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMontoCobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMontoEntregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMontoDiferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurnos)).BeginInit();
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
            this.lblDesde.Location = new System.Drawing.Point(261, 55);
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
            this.lblHasta.Location = new System.Drawing.Point(463, 55);
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
            this.lblEstado.Location = new System.Drawing.Point(197, 108);
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
            this.label6.Location = new System.Drawing.Point(373, -1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Consulta Cierre Turno";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rbAbierto
            // 
            this.rbAbierto.AutoSize = true;
            this.rbAbierto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbAbierto.ForeColor = System.Drawing.Color.White;
            this.rbAbierto.Location = new System.Drawing.Point(284, 107);
            this.rbAbierto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rbCerrado.Location = new System.Drawing.Point(435, 107);
            this.rbCerrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rbTodos.Location = new System.Drawing.Point(592, 107);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnCajero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.btnCajero.ForeColor = System.Drawing.Color.White;
            this.btnCajero.Location = new System.Drawing.Point(201, 55);
            this.btnCajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCajero.Name = "btnCajero";
            this.btnCajero.Size = new System.Drawing.Size(56, 21);
            this.btnCajero.TabIndex = 13;
            this.btnCajero.Text = "Cajero";
            this.btnCajero.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 14;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(353, 55);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(105, 23);
            this.dtpDesde.TabIndex = 15;
            this.dtpDesde.Value = new System.DateTime(2020, 9, 25, 22, 34, 59, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(573, 56);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(105, 23);
            this.dtpHasta.TabIndex = 16;
            this.dtpHasta.Value = new System.DateTime(2020, 9, 25, 22, 34, 59, 0);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(265, 84);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(414, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(197, 135);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(699, 20);
            this.textBox3.TabIndex = 18;
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
            this.lblCuandreAbierto.Location = new System.Drawing.Point(358, 499);
            this.lblCuandreAbierto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuandreAbierto.Name = "lblCuandreAbierto";
            this.lblCuandreAbierto.Size = new System.Drawing.Size(111, 17);
            this.lblCuandreAbierto.TabIndex = 20;
            this.lblCuandreAbierto.Text = "Cuandre Abierto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(618, 499);
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
            this.lblCuandoEntregado.Location = new System.Drawing.Point(484, 499);
            this.lblCuandoEntregado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuandoEntregado.Name = "lblCuandoEntregado";
            this.lblCuandoEntregado.Size = new System.Drawing.Size(124, 17);
            this.lblCuandoEntregado.TabIndex = 22;
            this.lblCuandoEntregado.Text = "Cuadre Entregado";
            // 
            // dtgvTurnos
            // 
            this.dtgvTurnos.AllowUserToAddRows = false;
            this.dtgvTurnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.dtgvTurnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdTurno,
            this.dgvIdEmpleado,
            this.dgvNombreEmpleado,
            this.dgvFechaApertura,
            this.dgvFechaCierre,
            this.dgvMontoApertura,
            this.dgvMontoCobrado,
            this.dgvMontoEntregado,
            this.dgvMontoDiferencia,
            this.dgvEstado});
            this.dtgvTurnos.Location = new System.Drawing.Point(15, 160);
            this.dtgvTurnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvTurnos.Name = "dtgvTurnos";
            this.dtgvTurnos.ReadOnly = true;
            this.dtgvTurnos.RowHeadersVisible = false;
            this.dtgvTurnos.RowHeadersWidth = 51;
            this.dtgvTurnos.RowTemplate.Height = 24;
            this.dtgvTurnos.Size = new System.Drawing.Size(1063, 326);
            this.dtgvTurnos.TabIndex = 27;
            // 
            // dgvIdTurno
            // 
            this.dgvIdTurno.HeaderText = "TURNO";
            this.dgvIdTurno.MinimumWidth = 6;
            this.dgvIdTurno.Name = "dgvIdTurno";
            this.dgvIdTurno.ReadOnly = true;
            this.dgvIdTurno.Width = 125;
            // 
            // dgvIdEmpleado
            // 
            this.dgvIdEmpleado.HeaderText = "ID EMPLEADO";
            this.dgvIdEmpleado.MinimumWidth = 6;
            this.dgvIdEmpleado.Name = "dgvIdEmpleado";
            this.dgvIdEmpleado.ReadOnly = true;
            this.dgvIdEmpleado.Width = 125;
            // 
            // dgvNombreEmpleado
            // 
            this.dgvNombreEmpleado.HeaderText = "NOMBRE EMPLEADO";
            this.dgvNombreEmpleado.MinimumWidth = 6;
            this.dgvNombreEmpleado.Name = "dgvNombreEmpleado";
            this.dgvNombreEmpleado.ReadOnly = true;
            this.dgvNombreEmpleado.Width = 125;
            // 
            // dgvFechaApertura
            // 
            this.dgvFechaApertura.HeaderText = "FECHA APERTURA";
            this.dgvFechaApertura.MinimumWidth = 6;
            this.dgvFechaApertura.Name = "dgvFechaApertura";
            this.dgvFechaApertura.ReadOnly = true;
            this.dgvFechaApertura.Width = 125;
            // 
            // dgvFechaCierre
            // 
            this.dgvFechaCierre.HeaderText = "FECHA CIERRE";
            this.dgvFechaCierre.MinimumWidth = 6;
            this.dgvFechaCierre.Name = "dgvFechaCierre";
            this.dgvFechaCierre.ReadOnly = true;
            this.dgvFechaCierre.Width = 125;
            // 
            // dgvMontoApertura
            // 
            this.dgvMontoApertura.HeaderText = "MONTO APERTURA";
            this.dgvMontoApertura.MinimumWidth = 6;
            this.dgvMontoApertura.Name = "dgvMontoApertura";
            this.dgvMontoApertura.ReadOnly = true;
            this.dgvMontoApertura.Width = 125;
            // 
            // dgvMontoCobrado
            // 
            this.dgvMontoCobrado.HeaderText = "MONTO COBRADO";
            this.dgvMontoCobrado.MinimumWidth = 6;
            this.dgvMontoCobrado.Name = "dgvMontoCobrado";
            this.dgvMontoCobrado.ReadOnly = true;
            this.dgvMontoCobrado.Width = 125;
            // 
            // dgvMontoEntregado
            // 
            this.dgvMontoEntregado.HeaderText = "MONTO ENTREGADO";
            this.dgvMontoEntregado.MinimumWidth = 6;
            this.dgvMontoEntregado.Name = "dgvMontoEntregado";
            this.dgvMontoEntregado.ReadOnly = true;
            this.dgvMontoEntregado.Width = 125;
            // 
            // dgvMontoDiferencia
            // 
            this.dgvMontoDiferencia.HeaderText = "MONTO DIFERENCIA";
            this.dgvMontoDiferencia.MinimumWidth = 6;
            this.dgvMontoDiferencia.Name = "dgvMontoDiferencia";
            this.dgvMontoDiferencia.ReadOnly = true;
            this.dgvMontoDiferencia.Width = 125;
            // 
            // dgvEstado
            // 
            this.dgvEstado.HeaderText = "ESTADO";
            this.dgvEstado.MinimumWidth = 6;
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.Width = 125;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CapaPresentacion.Properties.Resources.Ok_50px;
            this.pictureBox8.Location = new System.Drawing.Point(596, 499);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 16);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CapaPresentacion.Properties.Resources.Circled_Pause_50px;
            this.pictureBox7.Location = new System.Drawing.Point(460, 499);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 16);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaPresentacion.Properties.Resources.Circled_Pause_5033px;
            this.pictureBox6.Location = new System.Drawing.Point(337, 499);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 16);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.Calendar_31_64px;
            this.pictureBox4.Location = new System.Drawing.Point(524, 57);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.Calendar_31_64px;
            this.pictureBox3.Location = new System.Drawing.Point(322, 56);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Search_52px;
            this.pictureBox2.Location = new System.Drawing.Point(195, 135);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Search_52px;
            this.pictureBox1.Location = new System.Drawing.Point(345, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnSalirConsultaTurno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnSalirConsultaTurno.ForeColor = System.Drawing.Color.White;
            this.btnSalirConsultaTurno.Image = global::CapaPresentacion.Properties.Resources.Exit_64px;
            this.btnSalirConsultaTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirConsultaTurno.Location = new System.Drawing.Point(793, 92);
            this.btnSalirConsultaTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnCierreConsultaTurno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnCierreConsultaTurno.ForeColor = System.Drawing.Color.White;
            this.btnCierreConsultaTurno.Image = global::CapaPresentacion.Properties.Resources.registrar1;
            this.btnCierreConsultaTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCierreConsultaTurno.Location = new System.Drawing.Point(793, 47);
            this.btnCierreConsultaTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnImprimirConsultaTurno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnImprimirConsultaTurno.ForeColor = System.Drawing.Color.White;
            this.btnImprimirConsultaTurno.Image = global::CapaPresentacion.Properties.Resources.PRINTERPEQ;
            this.btnImprimirConsultaTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirConsultaTurno.Location = new System.Drawing.Point(681, 92);
            this.btnImprimirConsultaTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnBuscarConsultaTurno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnBuscarConsultaTurno.ForeColor = System.Drawing.Color.White;
            this.btnBuscarConsultaTurno.Image = global::CapaPresentacion.Properties.Resources.BUSCARPEQ_;
            this.btnBuscarConsultaTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarConsultaTurno.Location = new System.Drawing.Point(681, 47);
            this.btnBuscarConsultaTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarConsultaTurno.Name = "btnBuscarConsultaTurno";
            this.btnBuscarConsultaTurno.Size = new System.Drawing.Size(102, 40);
            this.btnBuscarConsultaTurno.TabIndex = 6;
            this.btnBuscarConsultaTurno.Text = "Buscar";
            this.btnBuscarConsultaTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarConsultaTurno.UseVisualStyleBackColor = false;
            this.btnBuscarConsultaTurno.Click += new System.EventHandler(this.btnBuscarConsultaTurno_Click);
            // 
            // frmConsultaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1089, 525);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dtgvTurnos);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCuandoEntregado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCuandreAbierto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.textBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConsultaTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaTurno";
            this.Load += new System.EventHandler(this.frmConsultaTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurnos)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCuandreAbierto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCuandoEntregado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dtgvTurnos;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMontoApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMontoCobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMontoEntregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMontoDiferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
    }
}