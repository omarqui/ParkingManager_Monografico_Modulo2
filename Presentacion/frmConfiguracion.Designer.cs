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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadParqueos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(334, 215);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(261, 20);
            this.txtNombreEmpresa.TabIndex = 0;
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(334, 253);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(261, 20);
            this.txtDireccionEmpresa.TabIndex = 1;
            // 
            // txtTelefonoEmpresa
            // 
            this.txtTelefonoEmpresa.Location = new System.Drawing.Point(334, 290);
            this.txtTelefonoEmpresa.Name = "txtTelefonoEmpresa";
            this.txtTelefonoEmpresa.Size = new System.Drawing.Size(126, 20);
            this.txtTelefonoEmpresa.TabIndex = 2;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(104, 209);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(184, 26);
            this.lblNombreEmpresa.TabIndex = 3;
            this.lblNombreEmpresa.Text = "Nombre Empresa";
            // 
            // lblDireccionEmpresa
            // 
            this.lblDireccionEmpresa.AutoSize = true;
            this.lblDireccionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDireccionEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblDireccionEmpresa.Location = new System.Drawing.Point(104, 246);
            this.lblDireccionEmpresa.Name = "lblDireccionEmpresa";
            this.lblDireccionEmpresa.Size = new System.Drawing.Size(197, 26);
            this.lblDireccionEmpresa.TabIndex = 4;
            this.lblDireccionEmpresa.Text = "Direccion Empresa";
            // 
            // lblTelefonoEmpresa
            // 
            this.lblTelefonoEmpresa.AutoSize = true;
            this.lblTelefonoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTelefonoEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblTelefonoEmpresa.Location = new System.Drawing.Point(104, 283);
            this.lblTelefonoEmpresa.Name = "lblTelefonoEmpresa";
            this.lblTelefonoEmpresa.Size = new System.Drawing.Size(189, 26);
            this.lblTelefonoEmpresa.TabIndex = 5;
            this.lblTelefonoEmpresa.Text = "Teléfono Empresa";
            // 
            // lblPrecioPorHora
            // 
            this.lblPrecioPorHora.AutoSize = true;
            this.lblPrecioPorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPrecioPorHora.ForeColor = System.Drawing.Color.White;
            this.lblPrecioPorHora.Location = new System.Drawing.Point(104, 321);
            this.lblPrecioPorHora.Name = "lblPrecioPorHora";
            this.lblPrecioPorHora.Size = new System.Drawing.Size(167, 26);
            this.lblPrecioPorHora.TabIndex = 7;
            this.lblPrecioPorHora.Text = "Precio Por Hora";
            // 
            // txtPrecioPorHora
            // 
            this.txtPrecioPorHora.Location = new System.Drawing.Point(334, 327);
            this.txtPrecioPorHora.Name = "txtPrecioPorHora";
            this.txtPrecioPorHora.Size = new System.Drawing.Size(126, 20);
            this.txtPrecioPorHora.TabIndex = 6;
            this.txtPrecioPorHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioPorHora_KeyPress);
            // 
            // lblCantidadParqueos
            // 
            this.lblCantidadParqueos.AutoSize = true;
            this.lblCantidadParqueos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCantidadParqueos.ForeColor = System.Drawing.Color.White;
            this.lblCantidadParqueos.Location = new System.Drawing.Point(104, 358);
            this.lblCantidadParqueos.Name = "lblCantidadParqueos";
            this.lblCantidadParqueos.Size = new System.Drawing.Size(228, 26);
            this.lblCantidadParqueos.TabIndex = 9;
            this.lblCantidadParqueos.Text = "Cantidad de Parqueos";
            // 
            // nudCantidadParqueos
            // 
            this.nudCantidadParqueos.Location = new System.Drawing.Point(334, 365);
            this.nudCantidadParqueos.Name = "nudCantidadParqueos";
            this.nudCantidadParqueos.Size = new System.Drawing.Size(125, 20);
            this.nudCantidadParqueos.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(474, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salir";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo_Parking1;
            this.pictureBox1.Location = new System.Drawing.Point(94, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.save_blanco;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(334, 429);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 49);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(724, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de Sistema";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadParqueos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}