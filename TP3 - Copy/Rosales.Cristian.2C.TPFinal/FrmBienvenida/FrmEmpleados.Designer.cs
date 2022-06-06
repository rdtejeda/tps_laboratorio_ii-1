namespace FrmStyloCar
{
    partial class FrmEmpleados
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.gBoxAltaEmpleado = new System.Windows.Forms.GroupBox();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.btnAltaEmpleado = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.gBoxAltaEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(537, 406);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gBoxAltaEmpleado
            // 
            this.gBoxAltaEmpleado.Controls.Add(this.txtFechaIngreso);
            this.gBoxAltaEmpleado.Controls.Add(this.cmbSector);
            this.gBoxAltaEmpleado.Controls.Add(this.lblFechaIngreso);
            this.gBoxAltaEmpleado.Controls.Add(this.lblSector);
            this.gBoxAltaEmpleado.Controls.Add(this.btnAltaEmpleado);
            this.gBoxAltaEmpleado.Controls.Add(this.txtMail);
            this.gBoxAltaEmpleado.Controls.Add(this.lblMail);
            this.gBoxAltaEmpleado.Controls.Add(this.txtTelefono);
            this.gBoxAltaEmpleado.Controls.Add(this.lblTelefono);
            this.gBoxAltaEmpleado.Controls.Add(this.txtDni);
            this.gBoxAltaEmpleado.Controls.Add(this.lblDni);
            this.gBoxAltaEmpleado.Controls.Add(this.txtApellido);
            this.gBoxAltaEmpleado.Controls.Add(this.lblApellido);
            this.gBoxAltaEmpleado.Controls.Add(this.txtNombre);
            this.gBoxAltaEmpleado.Controls.Add(this.lblNombre);
            this.gBoxAltaEmpleado.Location = new System.Drawing.Point(111, 45);
            this.gBoxAltaEmpleado.Name = "gBoxAltaEmpleado";
            this.gBoxAltaEmpleado.Size = new System.Drawing.Size(415, 329);
            this.gBoxAltaEmpleado.TabIndex = 16;
            this.gBoxAltaEmpleado.TabStop = false;
            this.gBoxAltaEmpleado.Text = "Empleado Nuevo";
            // 
            // cmbSector
            // 
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(97, 167);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(200, 23);
            this.cmbSector.TabIndex = 16;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(8, 196);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(83, 15);
            this.lblFechaIngreso.TabIndex = 15;
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(8, 170);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(43, 15);
            this.lblSector.TabIndex = 14;
            this.lblSector.Text = "Sector:";
            // 
            // btnAltaEmpleado
            // 
            this.btnAltaEmpleado.Location = new System.Drawing.Point(116, 270);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(202, 43);
            this.btnAltaEmpleado.TabIndex = 7;
            this.btnAltaEmpleado.Text = "Confirmar Alta Empleado";
            this.btnAltaEmpleado.UseVisualStyleBackColor = true;
            this.btnAltaEmpleado.Click += new System.EventHandler(this.btnAltaEmpleado_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(97, 138);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 23);
            this.txtMail.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(8, 141);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 15);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(97, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 23);
            this.txtTelefono.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(8, 112);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 15);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(97, 80);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(200, 23);
            this.txtDni.TabIndex = 3;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(8, 83);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 15);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "DNI:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(97, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 23);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(8, 54);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(97, 196);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(200, 23);
            this.txtFechaIngreso.TabIndex = 17;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.gBoxAltaEmpleado);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpleados | Rosales.Cristian.2C";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.gBoxAltaEmpleado.ResumeLayout(false);
            this.gBoxAltaEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gBoxAltaEmpleado;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Button btnAltaEmpleado;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtFechaIngreso;
    }
}