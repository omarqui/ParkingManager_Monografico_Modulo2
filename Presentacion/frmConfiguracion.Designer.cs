namespace CapaPresentacion
{
    partial class frmConfiguracion
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
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.txtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpresa = new System.Windows.Forms.TextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.lblDireccionEmpresa = new System.Windows.Forms.Label();
            this.lblTelefonoEmpresa = new System.Windows.Forms.Label();
            this.lblPrecioPorHora = new System.Windows.Forms.Label();
            this.txtPrecioPorHora = new System.Windows.Forms.TextBox();
            this.lblCantidadParqueos = new System.Windows.Forms.Label();
            this.nudCantidadParqueos = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.llbTituloConfiguracion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadParqueos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(231, 74);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(236, 20);
            this.txtNombreEmpresa.TabIndex = 0;
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(231, 114);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(236, 20);
            this.txtDireccionEmpresa.TabIndex = 1;
            // 
            // txtTelefonoEmpresa
            // 
            this.txtTelefonoEmpresa.Location = new System.Drawing.Point(231, 161);
            this.txtTelefonoEmpresa.Name = "txtTelefonoEmpresa";
            this.txtTelefonoEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoEmpresa.TabIndex = 2;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(113, 87);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(88, 13);
            this.lblNombreEmpresa.TabIndex = 3;
            this.lblNombreEmpresa.Text = "Nombre Empresa";
            // 
            // lblDireccionEmpresa
            // 
            this.lblDireccionEmpresa.AutoSize = true;
            this.lblDireccionEmpresa.Location = new System.Drawing.Point(113, 121);
            this.lblDireccionEmpresa.Name = "lblDireccionEmpresa";
            this.lblDireccionEmpresa.Size = new System.Drawing.Size(96, 13);
            this.lblDireccionEmpresa.TabIndex = 4;
            this.lblDireccionEmpresa.Text = "Direccion Empresa";
            // 
            // lblTelefonoEmpresa
            // 
            this.lblTelefonoEmpresa.AutoSize = true;
            this.lblTelefonoEmpresa.Location = new System.Drawing.Point(105, 164);
            this.lblTelefonoEmpresa.Name = "lblTelefonoEmpresa";
            this.lblTelefonoEmpresa.Size = new System.Drawing.Size(93, 13);
            this.lblTelefonoEmpresa.TabIndex = 5;
            this.lblTelefonoEmpresa.Text = "Teléfono Empresa";
            // 
            // lblPrecioPorHora
            // 
            this.lblPrecioPorHora.AutoSize = true;
            this.lblPrecioPorHora.Location = new System.Drawing.Point(105, 200);
            this.lblPrecioPorHora.Name = "lblPrecioPorHora";
            this.lblPrecioPorHora.Size = new System.Drawing.Size(82, 13);
            this.lblPrecioPorHora.TabIndex = 7;
            this.lblPrecioPorHora.Text = "Precio Por Hora";
            // 
            // txtPrecioPorHora
            // 
            this.txtPrecioPorHora.Location = new System.Drawing.Point(231, 197);
            this.txtPrecioPorHora.Name = "txtPrecioPorHora";
            this.txtPrecioPorHora.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioPorHora.TabIndex = 6;
            // 
            // lblCantidadParqueos
            // 
            this.lblCantidadParqueos.AutoSize = true;
            this.lblCantidadParqueos.Location = new System.Drawing.Point(105, 226);
            this.lblCantidadParqueos.Name = "lblCantidadParqueos";
            this.lblCantidadParqueos.Size = new System.Drawing.Size(112, 13);
            this.lblCantidadParqueos.TabIndex = 9;
            this.lblCantidadParqueos.Text = "Cantidad de Parqueos";
            // 
            // nudCantidadParqueos
            // 
            this.nudCantidadParqueos.Location = new System.Drawing.Point(231, 226);
            this.nudCantidadParqueos.Name = "nudCantidadParqueos";
            this.nudCantidadParqueos.Size = new System.Drawing.Size(100, 20);
            this.nudCantidadParqueos.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(279, 321);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 38);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(385, 321);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 38);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // llbTituloConfiguracion
            // 
            this.llbTituloConfiguracion.AutoSize = true;
            this.llbTituloConfiguracion.Location = new System.Drawing.Point(203, 28);
            this.llbTituloConfiguracion.Name = "llbTituloConfiguracion";
            this.llbTituloConfiguracion.Size = new System.Drawing.Size(88, 13);
            this.llbTituloConfiguracion.TabIndex = 13;
            this.llbTituloConfiguracion.Text = "Nombre Empresa";
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 441);
            this.Controls.Add(this.llbTituloConfiguracion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nudCantidadParqueos);
            this.Controls.Add(this.lblCantidadParqueos);
            this.Controls.Add(this.lblPrecioPorHora);
            this.Controls.Add(this.txtPrecioPorHora);
            this.Controls.Add(this.lblTelefonoEmpresa);
            this.Controls.Add(this.lblDireccionEmpresa);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.txtTelefonoEmpresa);
            this.Controls.Add(this.txtDireccionEmpresa);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Name = "frmConfiguracion";
            this.Text = "Configuración de Sistema";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadParqueos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.TextBox txtDireccionEmpresa;
        private System.Windows.Forms.TextBox txtTelefonoEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblDireccionEmpresa;
        private System.Windows.Forms.Label lblTelefonoEmpresa;
        private System.Windows.Forms.Label lblPrecioPorHora;
        private System.Windows.Forms.TextBox txtPrecioPorHora;
        private System.Windows.Forms.Label lblCantidadParqueos;
        private System.Windows.Forms.NumericUpDown nudCantidadParqueos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label llbTituloConfiguracion;
    }
}