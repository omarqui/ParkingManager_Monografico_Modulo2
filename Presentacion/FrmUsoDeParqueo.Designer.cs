namespace CapaPresentacion
{
    partial class FrmUsoDeParqueo
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
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNumeroTicket = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.btnDescuento = new System.Windows.Forms.Button();
            this.txtNetoTab2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDescuentoTab2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTotalTab2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPagadoTab2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioXMinTab2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTiempoTab2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSalidaTab2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEntradaTab2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNumeroTicketTab2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDevueltaTab3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPagadoTab3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNetoTab3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescuentoTab3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalTab3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioXMinTab3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTiempoTab3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalidaTab3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntradaTab3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroTicketTab3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDerecha
            // 
            this.btnDerecha.Enabled = false;
            this.btnDerecha.Location = new System.Drawing.Point(482, 313);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 21;
            this.btnDerecha.Text = "Siguiente";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(16, 313);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 22;
            this.btnIzquierda.Text = "Cancelar";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 295);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNumeroTicket);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNumeroTicket
            // 
            this.txtNumeroTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTicket.Location = new System.Drawing.Point(137, 125);
            this.txtNumeroTicket.Name = "txtNumeroTicket";
            this.txtNumeroTicket.Size = new System.Drawing.Size(280, 44);
            this.txtNumeroTicket.TabIndex = 0;
            this.txtNumeroTicket.TextChanged += new System.EventHandler(this.txtNumeroTicket_TextChanged);
            this.txtNumeroTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTicket_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Numero de Ticket";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.btnDescuento);
            this.tabPage2.Controls.Add(this.txtNetoTab2);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.txtDescuentoTab2);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.txtTotalTab2);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.txtPagadoTab2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtPrecioXMinTab2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtTiempoTab2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtSalidaTab2);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtEntradaTab2);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtNumeroTicketTab2);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(278, 93);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(224, 1);
            this.label23.TabIndex = 39;
            this.label23.Text = "Neto";
            // 
            // btnDescuento
            // 
            this.btnDescuento.Location = new System.Drawing.Point(403, 65);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(23, 23);
            this.btnDescuento.TabIndex = 38;
            this.btnDescuento.Text = "button4";
            this.btnDescuento.UseVisualStyleBackColor = true;
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click);
            // 
            // txtNetoTab2
            // 
            this.txtNetoTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetoTab2.Location = new System.Drawing.Point(280, 114);
            this.txtNetoTab2.Name = "txtNetoTab2";
            this.txtNetoTab2.ReadOnly = true;
            this.txtNetoTab2.Size = new System.Drawing.Size(222, 44);
            this.txtNetoTab2.TabIndex = 37;
            this.txtNetoTab2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNetoTab2.TextChanged += new System.EventHandler(this.txtNetoTab2_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(278, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "Neto";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // txtDescuentoTab2
            // 
            this.txtDescuentoTab2.Location = new System.Drawing.Point(432, 67);
            this.txtDescuentoTab2.Name = "txtDescuentoTab2";
            this.txtDescuentoTab2.ReadOnly = true;
            this.txtDescuentoTab2.Size = new System.Drawing.Size(71, 20);
            this.txtDescuentoTab2.TabIndex = 35;
            this.txtDescuentoTab2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuentoTab2.TextChanged += new System.EventHandler(this.txtDescuentoTab2_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(277, 70);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 34;
            this.label22.Text = "Decuento";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // txtTotalTab2
            // 
            this.txtTotalTab2.Location = new System.Drawing.Point(403, 41);
            this.txtTotalTab2.Name = "txtTotalTab2";
            this.txtTotalTab2.ReadOnly = true;
            this.txtTotalTab2.Size = new System.Drawing.Size(100, 20);
            this.txtTotalTab2.TabIndex = 33;
            this.txtTotalTab2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalTab2.TextChanged += new System.EventHandler(this.txtTotalTab2_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(278, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Total";
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(253, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1, 275);
            this.label18.TabIndex = 31;
            this.label18.Text = "label18";
            // 
            // txtPagadoTab2
            // 
            this.txtPagadoTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagadoTab2.Location = new System.Drawing.Point(281, 181);
            this.txtPagadoTab2.Name = "txtPagadoTab2";
            this.txtPagadoTab2.Size = new System.Drawing.Size(221, 44);
            this.txtPagadoTab2.TabIndex = 30;
            this.txtPagadoTab2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagadoTab2.TextChanged += new System.EventHandler(this.txtPagadoTab2_TextChanged);
            this.txtPagadoTab2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagadoTab2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Monto Pago";
            // 
            // txtPrecioXMinTab2
            // 
            this.txtPrecioXMinTab2.Location = new System.Drawing.Point(99, 225);
            this.txtPrecioXMinTab2.Name = "txtPrecioXMinTab2";
            this.txtPrecioXMinTab2.ReadOnly = true;
            this.txtPrecioXMinTab2.Size = new System.Drawing.Size(129, 20);
            this.txtPrecioXMinTab2.TabIndex = 19;
            this.txtPrecioXMinTab2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioXMinTab2.TextChanged += new System.EventHandler(this.txtPrecioXMinTab2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Precio (Min)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtTiempoTab2
            // 
            this.txtTiempoTab2.Location = new System.Drawing.Point(99, 175);
            this.txtTiempoTab2.Name = "txtTiempoTab2";
            this.txtTiempoTab2.ReadOnly = true;
            this.txtTiempoTab2.Size = new System.Drawing.Size(129, 20);
            this.txtTiempoTab2.TabIndex = 17;
            this.txtTiempoTab2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTiempoTab2.TextChanged += new System.EventHandler(this.txtTiempoTab2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tiempo (Min)";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtSalidaTab2
            // 
            this.txtSalidaTab2.Location = new System.Drawing.Point(99, 125);
            this.txtSalidaTab2.Name = "txtSalidaTab2";
            this.txtSalidaTab2.ReadOnly = true;
            this.txtSalidaTab2.Size = new System.Drawing.Size(129, 20);
            this.txtSalidaTab2.TabIndex = 15;
            this.txtSalidaTab2.TextChanged += new System.EventHandler(this.txtSalidaTab2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Salida";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtEntradaTab2
            // 
            this.txtEntradaTab2.Location = new System.Drawing.Point(99, 75);
            this.txtEntradaTab2.Name = "txtEntradaTab2";
            this.txtEntradaTab2.ReadOnly = true;
            this.txtEntradaTab2.Size = new System.Drawing.Size(129, 20);
            this.txtEntradaTab2.TabIndex = 13;
            this.txtEntradaTab2.TextChanged += new System.EventHandler(this.txtEntradaTab2_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Entrada";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtNumeroTicketTab2
            // 
            this.txtNumeroTicketTab2.Location = new System.Drawing.Point(97, 25);
            this.txtNumeroTicketTab2.Name = "txtNumeroTicketTab2";
            this.txtNumeroTicketTab2.ReadOnly = true;
            this.txtNumeroTicketTab2.Size = new System.Drawing.Size(129, 20);
            this.txtNumeroTicketTab2.TabIndex = 11;
            this.txtNumeroTicketTab2.TextChanged += new System.EventHandler(this.txtNumeroTicketTab2_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Ticket #";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.txtPrecioXMinTab3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtTiempoTab3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtSalidaTab3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtEntradaTab3);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtNumeroTicketTab3);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.txtDevueltaTab3);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtPagadoTab3);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtNetoTab3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtDescuentoTab3);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtTotalTab3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(541, 286);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(260, -3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1, 275);
            this.label19.TabIndex = 42;
            this.label19.Text = "label19";
            // 
            // txtDevueltaTab3
            // 
            this.txtDevueltaTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevueltaTab3.Location = new System.Drawing.Point(298, 194);
            this.txtDevueltaTab3.Name = "txtDevueltaTab3";
            this.txtDevueltaTab3.ReadOnly = true;
            this.txtDevueltaTab3.Size = new System.Drawing.Size(203, 44);
            this.txtDevueltaTab3.TabIndex = 30;
            this.txtDevueltaTab3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Devuelta";
            // 
            // txtPagadoTab3
            // 
            this.txtPagadoTab3.Location = new System.Drawing.Point(373, 139);
            this.txtPagadoTab3.Name = "txtPagadoTab3";
            this.txtPagadoTab3.ReadOnly = true;
            this.txtPagadoTab3.Size = new System.Drawing.Size(129, 20);
            this.txtPagadoTab3.TabIndex = 28;
            this.txtPagadoTab3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagadoTab3.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Monto Pago";
            // 
            // txtNetoTab3
            // 
            this.txtNetoTab3.Location = new System.Drawing.Point(373, 109);
            this.txtNetoTab3.Name = "txtNetoTab3";
            this.txtNetoTab3.ReadOnly = true;
            this.txtNetoTab3.Size = new System.Drawing.Size(129, 20);
            this.txtNetoTab3.TabIndex = 26;
            this.txtNetoTab3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNetoTab3.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Neto";
            // 
            // txtDescuentoTab3
            // 
            this.txtDescuentoTab3.Location = new System.Drawing.Point(373, 79);
            this.txtDescuentoTab3.Name = "txtDescuentoTab3";
            this.txtDescuentoTab3.ReadOnly = true;
            this.txtDescuentoTab3.Size = new System.Drawing.Size(129, 20);
            this.txtDescuentoTab3.TabIndex = 24;
            this.txtDescuentoTab3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuentoTab3.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Decuento";
            // 
            // txtTotalTab3
            // 
            this.txtTotalTab3.Location = new System.Drawing.Point(373, 49);
            this.txtTotalTab3.Name = "txtTotalTab3";
            this.txtTotalTab3.ReadOnly = true;
            this.txtTotalTab3.Size = new System.Drawing.Size(129, 20);
            this.txtTotalTab3.TabIndex = 22;
            this.txtTotalTab3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalTab3.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total";
            // 
            // txtPrecioXMinTab3
            // 
            this.txtPrecioXMinTab3.Location = new System.Drawing.Point(105, 224);
            this.txtPrecioXMinTab3.Name = "txtPrecioXMinTab3";
            this.txtPrecioXMinTab3.ReadOnly = true;
            this.txtPrecioXMinTab3.Size = new System.Drawing.Size(129, 20);
            this.txtPrecioXMinTab3.TabIndex = 52;
            this.txtPrecioXMinTab3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Precio (Min)";
            // 
            // txtTiempoTab3
            // 
            this.txtTiempoTab3.Location = new System.Drawing.Point(105, 174);
            this.txtTiempoTab3.Name = "txtTiempoTab3";
            this.txtTiempoTab3.ReadOnly = true;
            this.txtTiempoTab3.Size = new System.Drawing.Size(129, 20);
            this.txtTiempoTab3.TabIndex = 50;
            this.txtTiempoTab3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tiempo (Min)";
            // 
            // txtSalidaTab3
            // 
            this.txtSalidaTab3.Location = new System.Drawing.Point(105, 124);
            this.txtSalidaTab3.Name = "txtSalidaTab3";
            this.txtSalidaTab3.ReadOnly = true;
            this.txtSalidaTab3.Size = new System.Drawing.Size(129, 20);
            this.txtSalidaTab3.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Salida";
            // 
            // txtEntradaTab3
            // 
            this.txtEntradaTab3.Location = new System.Drawing.Point(105, 74);
            this.txtEntradaTab3.Name = "txtEntradaTab3";
            this.txtEntradaTab3.ReadOnly = true;
            this.txtEntradaTab3.Size = new System.Drawing.Size(129, 20);
            this.txtEntradaTab3.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Entrada";
            // 
            // txtNumeroTicketTab3
            // 
            this.txtNumeroTicketTab3.Location = new System.Drawing.Point(103, 24);
            this.txtNumeroTicketTab3.Name = "txtNumeroTicketTab3";
            this.txtNumeroTicketTab3.ReadOnly = true;
            this.txtNumeroTicketTab3.Size = new System.Drawing.Size(129, 20);
            this.txtNumeroTicketTab3.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Ticket #";
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(287, 169);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(224, 1);
            this.label24.TabIndex = 53;
            this.label24.Text = "Neto";
            // 
            // FrmUsoDeParqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 349);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Name = "FrmUsoDeParqueo";
            this.Text = "FrmUsoDeParqueo";
            this.Load += new System.EventHandler(this.FrmUsoDeParqueo_Load);
            this.Shown += new System.EventHandler(this.FrmUsoDeParqueo_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNumeroTicket;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtPrecioXMinTab2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTiempoTab2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSalidaTab2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEntradaTab2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNumeroTicketTab2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDevueltaTab3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPagadoTab3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNetoTab3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescuentoTab3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalTab3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPagadoTab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTotalTab2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnDescuento;
        private System.Windows.Forms.TextBox txtNetoTab2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDescuentoTab2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPrecioXMinTab3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTiempoTab3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalidaTab3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntradaTab3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroTicketTab3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label24;
    }
}