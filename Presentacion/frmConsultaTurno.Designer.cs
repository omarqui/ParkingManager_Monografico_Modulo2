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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lblDesde.Location = new System.Drawing.Point(106, 78);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(80, 25);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "DESDE";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(376, 77);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(81, 25);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "HASTA";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(22, 143);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(88, 24);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "ESTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(256, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "Consulta Cierre Turno";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rbAbierto
            // 
            this.rbAbierto.AutoSize = true;
            this.rbAbierto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbAbierto.ForeColor = System.Drawing.Color.White;
            this.rbAbierto.Location = new System.Drawing.Point(137, 141);
            this.rbAbierto.Name = "rbAbierto";
            this.rbAbierto.Size = new System.Drawing.Size(95, 29);
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
            this.rbCerrado.Location = new System.Drawing.Point(338, 141);
            this.rbCerrado.Name = "rbCerrado";
            this.rbCerrado.Size = new System.Drawing.Size(104, 29);
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
            this.rbTodos.Location = new System.Drawing.Point(548, 141);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(89, 29);
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
            this.btnCajero.Location = new System.Drawing.Point(27, 77);
            this.btnCajero.Name = "btnCajero";
            this.btnCajero.Size = new System.Drawing.Size(75, 26);
            this.btnCajero.TabIndex = 13;
            this.btnCajero.Text = "Cajero";
            this.btnCajero.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 14;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(229, 77);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(139, 26);
            this.dtpDesde.TabIndex = 15;
            this.dtpDesde.Value = new System.DateTime(2020, 9, 25, 22, 34, 59, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(522, 79);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(139, 26);
            this.dtpHasta.TabIndex = 16;
            this.dtpHasta.Value = new System.DateTime(2020, 9, 25, 22, 34, 59, 0);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(550, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(931, 22);
            this.textBox3.TabIndex = 18;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(23, 614);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(99, 20);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad : 0";
            // 
            // lblCuandreAbierto
            // 
            this.lblCuandreAbierto.AutoSize = true;
            this.lblCuandreAbierto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCuandreAbierto.ForeColor = System.Drawing.Color.White;
            this.lblCuandreAbierto.Location = new System.Drawing.Point(478, 614);
            this.lblCuandreAbierto.Name = "lblCuandreAbierto";
            this.lblCuandreAbierto.Size = new System.Drawing.Size(130, 20);
            this.lblCuandreAbierto.TabIndex = 20;
            this.lblCuandreAbierto.Text = "Cuandre Abierto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(824, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cuadre Cerrado";
            // 
            // lblCuandoEntregado
            // 
            this.lblCuandoEntregado.AutoSize = true;
            this.lblCuandoEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCuandoEntregado.ForeColor = System.Drawing.Color.White;
            this.lblCuandoEntregado.Location = new System.Drawing.Point(645, 614);
            this.lblCuandoEntregado.Name = "lblCuandoEntregado";
            this.lblCuandoEntregado.Size = new System.Drawing.Size(144, 20);
            this.lblCuandoEntregado.TabIndex = 22;
            this.lblCuandoEntregado.Text = "Cuadre Entregado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 401);
            this.dataGridView1.TabIndex = 27;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CapaPresentacion.Properties.Resources.Ok_50px;
            this.pictureBox8.Location = new System.Drawing.Point(795, 614);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CapaPresentacion.Properties.Resources.Circled_Pause_50px;
            this.pictureBox7.Location = new System.Drawing.Point(614, 614);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(27, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaPresentacion.Properties.Resources.Circled_Pause_5033px;
            this.pictureBox6.Location = new System.Drawing.Point(449, 614);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.Calendar_31_64px;
            this.pictureBox4.Location = new System.Drawing.Point(457, 80);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.Calendar_31_64px;
            this.pictureBox3.Location = new System.Drawing.Point(188, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Search_52px;
            this.pictureBox2.Location = new System.Drawing.Point(19, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Search_52px;
            this.pictureBox1.Location = new System.Drawing.Point(219, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
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
            this.btnSalirConsultaTurno.Location = new System.Drawing.Point(816, 123);
            this.btnSalirConsultaTurno.Name = "btnSalirConsultaTurno";
            this.btnSalirConsultaTurno.Size = new System.Drawing.Size(136, 49);
            this.btnSalirConsultaTurno.TabIndex = 9;
            this.btnSalirConsultaTurno.Text = "Salir";
            this.btnSalirConsultaTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalirConsultaTurno.UseVisualStyleBackColor = false;
            // 
            // btnCierreConsultaTurno
            // 
            this.btnCierreConsultaTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.btnCierreConsultaTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCierreConsultaTurno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnCierreConsultaTurno.ForeColor = System.Drawing.Color.White;
            this.btnCierreConsultaTurno.Image = global::CapaPresentacion.Properties.Resources.registrar1;
            this.btnCierreConsultaTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCierreConsultaTurno.Location = new System.Drawing.Point(816, 68);
            this.btnCierreConsultaTurno.Name = "btnCierreConsultaTurno";
            this.btnCierreConsultaTurno.Size = new System.Drawing.Size(136, 49);
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
            this.btnImprimirConsultaTurno.Location = new System.Drawing.Point(667, 123);
            this.btnImprimirConsultaTurno.Name = "btnImprimirConsultaTurno";
            this.btnImprimirConsultaTurno.Size = new System.Drawing.Size(136, 49);
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
            this.btnBuscarConsultaTurno.Location = new System.Drawing.Point(667, 68);
            this.btnBuscarConsultaTurno.Name = "btnBuscarConsultaTurno";
            this.btnBuscarConsultaTurno.Size = new System.Drawing.Size(136, 49);
            this.btnBuscarConsultaTurno.TabIndex = 6;
            this.btnBuscarConsultaTurno.Text = "Buscar";
            this.btnBuscarConsultaTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarConsultaTurno.UseVisualStyleBackColor = false;
            // 
            // frmConsultaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(966, 646);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "frmConsultaTurno";
            this.Text = "frmConsultaTurno";
            this.Load += new System.EventHandler(this.frmConsultaTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}