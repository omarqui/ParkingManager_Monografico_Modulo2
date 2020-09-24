namespace CapaPresentacion
{
    partial class frmConsultaEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvEmpleado = new System.Windows.Forms.DataGridView();
            this.dgvIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEmpleado
            // 
            this.dtgvEmpleado.AllowUserToAddRows = false;
            this.dtgvEmpleado.AllowUserToDeleteRows = false;
            this.dtgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.dtgvEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dtgvEmpleado.ColumnHeadersHeight = 30;
            this.dtgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdEmpleado,
            this.dgvNombre,
            this.dgvUsuario,
            this.dgvEstado});
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvEmpleado.DefaultCellStyle = dataGridViewCellStyle38;
            this.dtgvEmpleado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dtgvEmpleado.EnableHeadersVisualStyles = false;
            this.dtgvEmpleado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.dtgvEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvEmpleado.Location = new System.Drawing.Point(25, 65);
            this.dtgvEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvEmpleado.Name = "dtgvEmpleado";
            this.dtgvEmpleado.ReadOnly = true;
            this.dtgvEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dtgvEmpleado.RowHeadersVisible = false;
            this.dtgvEmpleado.RowHeadersWidth = 51;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dtgvEmpleado.Size = new System.Drawing.Size(771, 315);
            this.dtgvEmpleado.TabIndex = 0;
            // 
            // dgvIdEmpleado
            // 
            this.dgvIdEmpleado.HeaderText = "ID";
            this.dgvIdEmpleado.MinimumWidth = 6;
            this.dgvIdEmpleado.Name = "dgvIdEmpleado";
            this.dgvIdEmpleado.ReadOnly = true;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.MinimumWidth = 6;
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.HeaderText = "Usuario";
            this.dgvUsuario.MinimumWidth = 6;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            // 
            // dgvEstado
            // 
            this.dgvEstado.HeaderText = "Estado";
            this.dgvEstado.MinimumWidth = 6;
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta Empleados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo_Parking1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.Exit_64px;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(688, 401);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 38);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.btnNuevoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnNuevoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnNuevoEmpleado.Image = global::CapaPresentacion.Properties.Resources.nuevo1;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(152, 401);
            this.btnNuevoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(108, 38);
            this.btnNuevoEmpleado.TabIndex = 2;
            this.btnNuevoEmpleado.Text = "Crear";
            this.btnNuevoEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = false;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.btnEditarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnEditarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEditarEmpleado.Image = global::CapaPresentacion.Properties.Resources.Edit_User_Male_40px;
            this.btnEditarEmpleado.Location = new System.Drawing.Point(25, 401);
            this.btnEditarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(108, 38);
            this.btnEditarEmpleado.TabIndex = 1;
            this.btnEditarEmpleado.Text = "Editar";
            this.btnEditarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // frmConsultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(825, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.btnEditarEmpleado);
            this.Controls.Add(this.dtgvEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaEmpleado";
            this.Load += new System.EventHandler(this.frmConsultaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
        private System.Windows.Forms.Button btnNuevoEmpleado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgvEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}