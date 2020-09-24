namespace CapaPresentacion
{
    partial class frmTurno
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
            this.lblCodigoTurno = new System.Windows.Forms.Label();
            this.lblCodigoEmpleadoTurno = new System.Windows.Forms.Label();
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.lblMontoApertura = new System.Windows.Forms.Label();
            this.lblMontoCobrado = new System.Windows.Forms.Label();
            this.lblMontoEntregado = new System.Windows.Forms.Label();
            this.lblMontoDiferencia = new System.Windows.Forms.Label();
            this.txtCodigoTurno = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleadoTurno = new System.Windows.Forms.TextBox();
            this.txtMontoApertura = new System.Windows.Forms.TextBox();
            this.txtMontoCobrado = new System.Windows.Forms.TextBox();
            this.txtMontoEntregado = new System.Windows.Forms.TextBox();
            this.txtMontoDiferencia = new System.Windows.Forms.TextBox();
            this.dtpFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.btnSalirTurno = new System.Windows.Forms.Button();
            this.btnRegistrarTurno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigoTurno
            // 
            this.lblCodigoTurno.AutoSize = true;
            this.lblCodigoTurno.Location = new System.Drawing.Point(193, 44);
            this.lblCodigoTurno.Name = "lblCodigoTurno";
            this.lblCodigoTurno.Size = new System.Drawing.Size(57, 17);
            this.lblCodigoTurno.TabIndex = 0;
            this.lblCodigoTurno.Text = "IdTurno";
            // 
            // lblCodigoEmpleadoTurno
            // 
            this.lblCodigoEmpleadoTurno.AutoSize = true;
            this.lblCodigoEmpleadoTurno.Location = new System.Drawing.Point(193, 98);
            this.lblCodigoEmpleadoTurno.Name = "lblCodigoEmpleadoTurno";
            this.lblCodigoEmpleadoTurno.Size = new System.Drawing.Size(89, 17);
            this.lblCodigoEmpleadoTurno.TabIndex = 1;
            this.lblCodigoEmpleadoTurno.Text = "IdEmpleados";
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Location = new System.Drawing.Point(193, 148);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(106, 17);
            this.lblFechaApertura.TabIndex = 2;
            this.lblFechaApertura.Text = "Fecha Apertura";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Location = new System.Drawing.Point(193, 203);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(89, 17);
            this.lblFechaCierre.TabIndex = 3;
            this.lblFechaCierre.Text = "Fecha Cierre";
            // 
            // lblMontoApertura
            // 
            this.lblMontoApertura.AutoSize = true;
            this.lblMontoApertura.Location = new System.Drawing.Point(193, 265);
            this.lblMontoApertura.Name = "lblMontoApertura";
            this.lblMontoApertura.Size = new System.Drawing.Size(106, 17);
            this.lblMontoApertura.TabIndex = 4;
            this.lblMontoApertura.Text = "Monto Apertura";
            // 
            // lblMontoCobrado
            // 
            this.lblMontoCobrado.AutoSize = true;
            this.lblMontoCobrado.Location = new System.Drawing.Point(193, 312);
            this.lblMontoCobrado.Name = "lblMontoCobrado";
            this.lblMontoCobrado.Size = new System.Drawing.Size(105, 17);
            this.lblMontoCobrado.TabIndex = 5;
            this.lblMontoCobrado.Text = "Monto Cobrado";
            // 
            // lblMontoEntregado
            // 
            this.lblMontoEntregado.AutoSize = true;
            this.lblMontoEntregado.Location = new System.Drawing.Point(193, 371);
            this.lblMontoEntregado.Name = "lblMontoEntregado";
            this.lblMontoEntregado.Size = new System.Drawing.Size(117, 17);
            this.lblMontoEntregado.TabIndex = 6;
            this.lblMontoEntregado.Text = "Monto Entregado";
            // 
            // lblMontoDiferencia
            // 
            this.lblMontoDiferencia.AutoSize = true;
            this.lblMontoDiferencia.Location = new System.Drawing.Point(193, 414);
            this.lblMontoDiferencia.Name = "lblMontoDiferencia";
            this.lblMontoDiferencia.Size = new System.Drawing.Size(115, 17);
            this.lblMontoDiferencia.TabIndex = 7;
            this.lblMontoDiferencia.Text = "Monto Diferencia";
            // 
            // txtCodigoTurno
            // 
            this.txtCodigoTurno.Location = new System.Drawing.Point(315, 44);
            this.txtCodigoTurno.Name = "txtCodigoTurno";
            this.txtCodigoTurno.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoTurno.TabIndex = 8;
            // 
            // txtCodigoEmpleadoTurno
            // 
            this.txtCodigoEmpleadoTurno.Location = new System.Drawing.Point(315, 98);
            this.txtCodigoEmpleadoTurno.Name = "txtCodigoEmpleadoTurno";
            this.txtCodigoEmpleadoTurno.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoEmpleadoTurno.TabIndex = 9;
            // 
            // txtMontoApertura
            // 
            this.txtMontoApertura.Location = new System.Drawing.Point(315, 262);
            this.txtMontoApertura.Name = "txtMontoApertura";
            this.txtMontoApertura.Size = new System.Drawing.Size(100, 22);
            this.txtMontoApertura.TabIndex = 10;
            // 
            // txtMontoCobrado
            // 
            this.txtMontoCobrado.Location = new System.Drawing.Point(315, 312);
            this.txtMontoCobrado.Name = "txtMontoCobrado";
            this.txtMontoCobrado.Size = new System.Drawing.Size(100, 22);
            this.txtMontoCobrado.TabIndex = 11;
            // 
            // txtMontoEntregado
            // 
            this.txtMontoEntregado.Location = new System.Drawing.Point(315, 368);
            this.txtMontoEntregado.Name = "txtMontoEntregado";
            this.txtMontoEntregado.Size = new System.Drawing.Size(100, 22);
            this.txtMontoEntregado.TabIndex = 12;
            // 
            // txtMontoDiferencia
            // 
            this.txtMontoDiferencia.Location = new System.Drawing.Point(315, 411);
            this.txtMontoDiferencia.Name = "txtMontoDiferencia";
            this.txtMontoDiferencia.Size = new System.Drawing.Size(100, 22);
            this.txtMontoDiferencia.TabIndex = 13;
            // 
            // dtpFechaApertura
            // 
            this.dtpFechaApertura.Location = new System.Drawing.Point(315, 148);
            this.dtpFechaApertura.Name = "dtpFechaApertura";
            this.dtpFechaApertura.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaApertura.TabIndex = 14;
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Location = new System.Drawing.Point(315, 203);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaCierre.TabIndex = 15;
            // 
            // btnSalirTurno
            // 
            this.btnSalirTurno.Location = new System.Drawing.Point(664, 403);
            this.btnSalirTurno.Name = "btnSalirTurno";
            this.btnSalirTurno.Size = new System.Drawing.Size(75, 34);
            this.btnSalirTurno.TabIndex = 16;
            this.btnSalirTurno.Text = "Salir";
            this.btnSalirTurno.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarTurno
            // 
            this.btnRegistrarTurno.Location = new System.Drawing.Point(513, 403);
            this.btnRegistrarTurno.Name = "btnRegistrarTurno";
            this.btnRegistrarTurno.Size = new System.Drawing.Size(124, 34);
            this.btnRegistrarTurno.TabIndex = 17;
            this.btnRegistrarTurno.Text = "Registrar Turno";
            this.btnRegistrarTurno.UseVisualStyleBackColor = true;
            this.btnRegistrarTurno.Click += new System.EventHandler(this.btnRegistrarTurno_Click);
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 459);
            this.Controls.Add(this.btnRegistrarTurno);
            this.Controls.Add(this.btnSalirTurno);
            this.Controls.Add(this.dtpFechaCierre);
            this.Controls.Add(this.dtpFechaApertura);
            this.Controls.Add(this.txtMontoDiferencia);
            this.Controls.Add(this.txtMontoEntregado);
            this.Controls.Add(this.txtMontoCobrado);
            this.Controls.Add(this.txtMontoApertura);
            this.Controls.Add(this.txtCodigoEmpleadoTurno);
            this.Controls.Add(this.txtCodigoTurno);
            this.Controls.Add(this.lblMontoDiferencia);
            this.Controls.Add(this.lblMontoEntregado);
            this.Controls.Add(this.lblMontoCobrado);
            this.Controls.Add(this.lblMontoApertura);
            this.Controls.Add(this.lblFechaCierre);
            this.Controls.Add(this.lblFechaApertura);
            this.Controls.Add(this.lblCodigoEmpleadoTurno);
            this.Controls.Add(this.lblCodigoTurno);
            this.Name = "frmTurno";
            this.Text = "frmTurno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoTurno;
        private System.Windows.Forms.Label lblCodigoEmpleadoTurno;
        private System.Windows.Forms.Label lblFechaApertura;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.Label lblMontoApertura;
        private System.Windows.Forms.Label lblMontoCobrado;
        private System.Windows.Forms.Label lblMontoEntregado;
        private System.Windows.Forms.Label lblMontoDiferencia;
        private System.Windows.Forms.TextBox txtCodigoTurno;
        private System.Windows.Forms.TextBox txtCodigoEmpleadoTurno;
        private System.Windows.Forms.TextBox txtMontoApertura;
        private System.Windows.Forms.TextBox txtMontoCobrado;
        private System.Windows.Forms.TextBox txtMontoEntregado;
        private System.Windows.Forms.TextBox txtMontoDiferencia;
        private System.Windows.Forms.DateTimePicker dtpFechaApertura;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.Button btnSalirTurno;
        private System.Windows.Forms.Button btnRegistrarTurno;
    }
}