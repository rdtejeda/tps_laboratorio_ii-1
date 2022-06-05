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
            this.lablSectorChapa = new System.Windows.Forms.Label();
            this.lblSectorPintura = new System.Windows.Forms.Label();
            this.lblSectorLavado = new System.Windows.Forms.Label();
            this.lstChapa = new System.Windows.Forms.ListBox();
            this.lstPintura = new System.Windows.Forms.ListBox();
            this.lstLavado = new System.Windows.Forms.ListBox();
            this.btnAbmEmpleado = new System.Windows.Forms.Button();
            this.btnInformeEmpleado = new System.Windows.Forms.Button();
            this.lstAdmin = new System.Windows.Forms.ListBox();
            this.lblAdmin = new System.Windows.Forms.Label();
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
            // lablSectorChapa
            // 
            this.lablSectorChapa.AutoSize = true;
            this.lablSectorChapa.Location = new System.Drawing.Point(12, 9);
            this.lablSectorChapa.Name = "lablSectorChapa";
            this.lablSectorChapa.Size = new System.Drawing.Size(77, 15);
            this.lablSectorChapa.TabIndex = 1;
            this.lablSectorChapa.Text = "Sector Chapa";
            // 
            // lblSectorPintura
            // 
            this.lblSectorPintura.AutoSize = true;
            this.lblSectorPintura.Location = new System.Drawing.Point(12, 114);
            this.lblSectorPintura.Name = "lblSectorPintura";
            this.lblSectorPintura.Size = new System.Drawing.Size(81, 15);
            this.lblSectorPintura.TabIndex = 2;
            this.lblSectorPintura.Text = "Sector Pintura";
            // 
            // lblSectorLavado
            // 
            this.lblSectorLavado.AutoSize = true;
            this.lblSectorLavado.Location = new System.Drawing.Point(12, 223);
            this.lblSectorLavado.Name = "lblSectorLavado";
            this.lblSectorLavado.Size = new System.Drawing.Size(127, 15);
            this.lblSectorLavado.TabIndex = 3;
            this.lblSectorLavado.Text = "Sector Lavado y Pulido";
            // 
            // lstChapa
            // 
            this.lstChapa.FormattingEnabled = true;
            this.lstChapa.ItemHeight = 15;
            this.lstChapa.Location = new System.Drawing.Point(12, 27);
            this.lstChapa.Name = "lstChapa";
            this.lstChapa.Size = new System.Drawing.Size(120, 79);
            this.lstChapa.TabIndex = 4;
            // 
            // lstPintura
            // 
            this.lstPintura.FormattingEnabled = true;
            this.lstPintura.ItemHeight = 15;
            this.lstPintura.Location = new System.Drawing.Point(12, 132);
            this.lstPintura.Name = "lstPintura";
            this.lstPintura.Size = new System.Drawing.Size(120, 79);
            this.lstPintura.TabIndex = 5;
            // 
            // lstLavado
            // 
            this.lstLavado.FormattingEnabled = true;
            this.lstLavado.ItemHeight = 15;
            this.lstLavado.Location = new System.Drawing.Point(12, 241);
            this.lstLavado.Name = "lstLavado";
            this.lstLavado.Size = new System.Drawing.Size(120, 79);
            this.lstLavado.TabIndex = 6;
            // 
            // btnAbmEmpleado
            // 
            this.btnAbmEmpleado.Location = new System.Drawing.Point(494, 12);
            this.btnAbmEmpleado.Name = "btnAbmEmpleado";
            this.btnAbmEmpleado.Size = new System.Drawing.Size(118, 56);
            this.btnAbmEmpleado.TabIndex = 7;
            this.btnAbmEmpleado.Text = "ABM Empleado";
            this.btnAbmEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnInformeEmpleado
            // 
            this.btnInformeEmpleado.Location = new System.Drawing.Point(494, 78);
            this.btnInformeEmpleado.Name = "btnInformeEmpleado";
            this.btnInformeEmpleado.Size = new System.Drawing.Size(118, 56);
            this.btnInformeEmpleado.TabIndex = 8;
            this.btnInformeEmpleado.Text = "Informes";
            this.btnInformeEmpleado.UseVisualStyleBackColor = true;
            // 
            // lstAdmin
            // 
            this.lstAdmin.FormattingEnabled = true;
            this.lstAdmin.ItemHeight = 15;
            this.lstAdmin.Location = new System.Drawing.Point(12, 350);
            this.lstAdmin.Name = "lstAdmin";
            this.lstAdmin.Size = new System.Drawing.Size(120, 79);
            this.lstAdmin.TabIndex = 10;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(12, 332);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(121, 15);
            this.lblAdmin.TabIndex = 9;
            this.lblAdmin.Text = "Sector Administrativo";
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lstAdmin);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnInformeEmpleado);
            this.Controls.Add(this.btnAbmEmpleado);
            this.Controls.Add(this.lstLavado);
            this.Controls.Add(this.lstPintura);
            this.Controls.Add(this.lstChapa);
            this.Controls.Add(this.lblSectorLavado);
            this.Controls.Add(this.lblSectorPintura);
            this.Controls.Add(this.lablSectorChapa);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados | Rosales.Cristian.2C";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lablSectorChapa;
        private System.Windows.Forms.Label lblSectorPintura;
        private System.Windows.Forms.Label lblSectorLavado;
        private System.Windows.Forms.ListBox lstChapa;
        private System.Windows.Forms.ListBox lstPintura;
        private System.Windows.Forms.ListBox lstLavado;
        private System.Windows.Forms.Button btnAbmEmpleado;
        private System.Windows.Forms.Button btnInformeEmpleado;
        private System.Windows.Forms.ListBox lstAdmin;
        private System.Windows.Forms.Label lblAdmin;
    }
}