namespace FrmBienvenida
{
    partial class FrmBienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresoAuto = new System.Windows.Forms.Button();
            this.btnEgresoAuto = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIngresoAuto
            // 
            this.btnIngresoAuto.Location = new System.Drawing.Point(40, 331);
            this.btnIngresoAuto.Name = "btnIngresoAuto";
            this.btnIngresoAuto.Size = new System.Drawing.Size(230, 82);
            this.btnIngresoAuto.TabIndex = 0;
            this.btnIngresoAuto.Text = "Ingreso Auto";
            this.btnIngresoAuto.UseVisualStyleBackColor = true;
            // 
            // btnEgresoAuto
            // 
            this.btnEgresoAuto.Location = new System.Drawing.Point(40, 216);
            this.btnEgresoAuto.Name = "btnEgresoAuto";
            this.btnEgresoAuto.Size = new System.Drawing.Size(230, 82);
            this.btnEgresoAuto.TabIndex = 1;
            this.btnEgresoAuto.Text = "Egreso Auto";
            this.btnEgresoAuto.UseVisualStyleBackColor = true;
            // 
            // btnMateriales
            // 
            this.btnMateriales.Location = new System.Drawing.Point(301, 216);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(230, 82);
            this.btnMateriales.TabIndex = 2;
            this.btnMateriales.Text = "Materiales";
            this.btnMateriales.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(301, 331);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(230, 82);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(512, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(512, 53);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 15);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(512, 27);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 23);
            this.txtFecha.TabIndex = 6;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(512, 71);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 23);
            this.txtHora.TabIndex = 7;
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnMateriales);
            this.Controls.Add(this.btnEgresoAuto);
            this.Controls.Add(this.btnIngresoAuto);
            this.Name = "FrmBienvenida";
            this.Text = "Strylo Car | Rosales.Cristian.2C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoAuto;
        private System.Windows.Forms.Button btnEgresoAuto;
        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHora;
    }
}
