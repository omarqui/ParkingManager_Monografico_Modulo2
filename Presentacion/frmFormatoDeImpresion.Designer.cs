namespace CapaPresentacion
{
    partial class frmFormatoDeImpresion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormatoDeImpresion));
            this.rbLista = new System.Windows.Forms.RadioButton();
            this.rbSeleccion = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbLista
            // 
            this.rbLista.AutoSize = true;
            this.rbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbLista.ForeColor = System.Drawing.Color.White;
            this.rbLista.Location = new System.Drawing.Point(56, 64);
            this.rbLista.Margin = new System.Windows.Forms.Padding(2);
            this.rbLista.Name = "rbLista";
            this.rbLista.Size = new System.Drawing.Size(121, 24);
            this.rbLista.TabIndex = 0;
            this.rbLista.Text = "Imprimir Lista";
            this.rbLista.UseVisualStyleBackColor = true;
            // 
            // rbSeleccion
            // 
            this.rbSeleccion.AutoSize = true;
            this.rbSeleccion.Checked = true;
            this.rbSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbSeleccion.ForeColor = System.Drawing.Color.White;
            this.rbSeleccion.Location = new System.Drawing.Point(56, 100);
            this.rbSeleccion.Margin = new System.Windows.Forms.Padding(2);
            this.rbSeleccion.Name = "rbSeleccion";
            this.rbSeleccion.Size = new System.Drawing.Size(156, 24);
            this.rbSeleccion.TabIndex = 1;
            this.rbSeleccion.TabStop = true;
            this.rbSeleccion.Text = "Imprimir Selección";
            this.rbSeleccion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FORMATO DE IMPRESIÓN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Versions_50px;
            this.pictureBox1.Location = new System.Drawing.Point(19, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.printmediano;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(45, 191);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(103, 47);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImprimir.UseVisualStyleBackColor = false
            this.btnImprimir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.Exit_64px;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(192, 191);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 47);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmFormatoDeImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(272, 222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbSeleccion);
            this.Controls.Add(this.rbLista);
            this.Controls.Add(this.btnImprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFormatoDeImpresion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFormatoDeImpresion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLista;
        private System.Windows.Forms.RadioButton rbSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}