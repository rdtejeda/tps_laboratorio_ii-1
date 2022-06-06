namespace FrmStyloCar
{
    partial class FrmEgresoAuto
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
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lstTrabajos = new System.Windows.Forms.ListBox();
            this.lblTrabajosPendientes = new System.Windows.Forms.Label();
            this.btnTerminado = new System.Windows.Forms.Button();
            this.gBoxEgreso = new System.Windows.Forms.GroupBox();
            this.gBoxEgreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(537, 406);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(26, 28);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(50, 15);
            this.lblPatente.TabIndex = 3;
            this.lblPatente.Text = "Patente:";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(26, 46);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 23);
            this.txtPatente.TabIndex = 4;
            // 
            // lstTrabajos
            // 
            this.lstTrabajos.FormattingEnabled = true;
            this.lstTrabajos.ItemHeight = 15;
            this.lstTrabajos.Location = new System.Drawing.Point(254, 46);
            this.lstTrabajos.Name = "lstTrabajos";
            this.lstTrabajos.Size = new System.Drawing.Size(212, 244);
            this.lstTrabajos.TabIndex = 5;
            // 
            // lblTrabajosPendientes
            // 
            this.lblTrabajosPendientes.AutoSize = true;
            this.lblTrabajosPendientes.Location = new System.Drawing.Point(254, 28);
            this.lblTrabajosPendientes.Name = "lblTrabajosPendientes";
            this.lblTrabajosPendientes.Size = new System.Drawing.Size(114, 15);
            this.lblTrabajosPendientes.TabIndex = 6;
            this.lblTrabajosPendientes.Text = "Trabajos Pendientes:";
            // 
            // btnTerminado
            // 
            this.btnTerminado.Location = new System.Drawing.Point(26, 175);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(197, 115);
            this.btnTerminado.TabIndex = 7;
            this.btnTerminado.Text = "Trabajo Terminado";
            this.btnTerminado.UseVisualStyleBackColor = true;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click);
            // 
            // gBoxEgreso
            // 
            this.gBoxEgreso.Controls.Add(this.btnTerminado);
            this.gBoxEgreso.Controls.Add(this.lblTrabajosPendientes);
            this.gBoxEgreso.Controls.Add(this.lstTrabajos);
            this.gBoxEgreso.Controls.Add(this.txtPatente);
            this.gBoxEgreso.Controls.Add(this.lblPatente);
            this.gBoxEgreso.Location = new System.Drawing.Point(68, 44);
            this.gBoxEgreso.Name = "gBoxEgreso";
            this.gBoxEgreso.Size = new System.Drawing.Size(491, 324);
            this.gBoxEgreso.TabIndex = 8;
            this.gBoxEgreso.TabStop = false;
            this.gBoxEgreso.Text = "Egreso Auto:";
            // 
            // FrmEgresoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.gBoxEgreso);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmEgresoAuto";
            this.Text = "FrmEgresoAuto | Rosales.Cristian.2C";
            this.gBoxEgreso.ResumeLayout(false);
            this.gBoxEgreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.ListBox lstTrabajos;
        private System.Windows.Forms.Label lblTrabajosPendientes;
        private System.Windows.Forms.Button btnTerminado;
        private System.Windows.Forms.GroupBox gBoxEgreso;
    }
}