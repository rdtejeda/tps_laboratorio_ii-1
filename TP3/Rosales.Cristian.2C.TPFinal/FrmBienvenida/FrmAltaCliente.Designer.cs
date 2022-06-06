namespace FrmStyloCar
{
    partial class FrmAltaCliente
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
            this.gBoxAltaCliente = new System.Windows.Forms.GroupBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnAltaCliente = new System.Windows.Forms.Button();
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.gBoxAltaCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxAltaCliente
            // 
            this.gBoxAltaCliente.Controls.Add(this.txtPatente);
            this.gBoxAltaCliente.Controls.Add(this.lblPatente);
            this.gBoxAltaCliente.Controls.Add(this.btnAltaCliente);
            this.gBoxAltaCliente.Controls.Add(this.txtMail);
            this.gBoxAltaCliente.Controls.Add(this.lblMail);
            this.gBoxAltaCliente.Controls.Add(this.txtTelefono);
            this.gBoxAltaCliente.Controls.Add(this.lblTelefono);
            this.gBoxAltaCliente.Controls.Add(this.txtDni);
            this.gBoxAltaCliente.Controls.Add(this.lblDni);
            this.gBoxAltaCliente.Controls.Add(this.txtApellido);
            this.gBoxAltaCliente.Controls.Add(this.lblApellido);
            this.gBoxAltaCliente.Controls.Add(this.txtNombre);
            this.gBoxAltaCliente.Controls.Add(this.lblNombre);
            this.gBoxAltaCliente.Location = new System.Drawing.Point(96, 44);
            this.gBoxAltaCliente.Name = "gBoxAltaCliente";
            this.gBoxAltaCliente.Size = new System.Drawing.Size(415, 329);
            this.gBoxAltaCliente.TabIndex = 15;
            this.gBoxAltaCliente.TabStop = false;
            this.gBoxAltaCliente.Text = "Cliente Nuevo";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(97, 167);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(162, 23);
            this.txtPatente.TabIndex = 6;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(8, 170);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(50, 15);
            this.lblPatente.TabIndex = 14;
            this.lblPatente.Text = "Patente:";
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(116, 270);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(202, 43);
            this.btnAltaCliente.TabIndex = 7;
            this.btnAltaCliente.Text = "Confirmar Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(97, 138);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(162, 23);
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
            this.txtTelefono.Size = new System.Drawing.Size(162, 23);
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
            this.txtDni.Size = new System.Drawing.Size(162, 23);
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
            this.txtApellido.Size = new System.Drawing.Size(162, 23);
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
            this.txtNombre.Size = new System.Drawing.Size(162, 23);
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
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(537, 406);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gBoxAltaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaCliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.gBoxAltaCliente.ResumeLayout(false);
            this.gBoxAltaCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxAltaCliente;
        private System.Windows.Forms.Button btnAltaCliente;
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
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblPatente;
    }
}