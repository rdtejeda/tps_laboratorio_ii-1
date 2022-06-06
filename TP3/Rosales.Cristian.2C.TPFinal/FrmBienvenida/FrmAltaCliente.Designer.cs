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
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblClienteExistente = new System.Windows.Forms.Label();
            this.gBoxAltaCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxAltaCliente
            // 
            this.gBoxAltaCliente.Controls.Add(this.btnAltaEmpleado);
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
            this.gBoxAltaCliente.Location = new System.Drawing.Point(12, 12);
            this.gBoxAltaCliente.Name = "gBoxAltaCliente";
            this.gBoxAltaCliente.Size = new System.Drawing.Size(281, 241);
            this.gBoxAltaCliente.TabIndex = 19;
            this.gBoxAltaCliente.TabStop = false;
            this.gBoxAltaCliente.Text = "Cliente Nuevo";
            // 
            // btnAltaEmpleado
            // 
            this.btnAltaEmpleado.Location = new System.Drawing.Point(40, 180);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(202, 43);
            this.btnAltaEmpleado.TabIndex = 17;
            this.btnAltaEmpleado.Text = "Confirmar Alta Cliente";
            this.btnAltaEmpleado.UseVisualStyleBackColor = true;
            this.btnAltaEmpleado.Click += new System.EventHandler(this.btnAltaEmpleado_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(97, 138);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(162, 23);
            this.txtMail.TabIndex = 13;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(8, 141);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 15);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(97, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(162, 23);
            this.txtTelefono.TabIndex = 11;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(8, 112);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 15);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(97, 80);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(162, 23);
            this.txtDni.TabIndex = 7;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(8, 83);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 15);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "DNI:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(97, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(162, 23);
            this.txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(8, 54);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 15;
            this.lstClientes.Location = new System.Drawing.Point(444, 30);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(168, 214);
            this.lstClientes.TabIndex = 20;
            // 
            // lblClienteExistente
            // 
            this.lblClienteExistente.AutoSize = true;
            this.lblClienteExistente.Location = new System.Drawing.Point(444, 9);
            this.lblClienteExistente.Name = "lblClienteExistente";
            this.lblClienteExistente.Size = new System.Drawing.Size(97, 15);
            this.lblClienteExistente.TabIndex = 21;
            this.lblClienteExistente.Text = "Cliente Existente:";
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblClienteExistente);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.gBoxAltaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaCliente";
            this.Activated += new System.EventHandler(this.FrmAltaCliente_Activated);
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.gBoxAltaCliente.ResumeLayout(false);
            this.gBoxAltaCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxAltaCliente;
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
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblClienteExistente;
    }
}