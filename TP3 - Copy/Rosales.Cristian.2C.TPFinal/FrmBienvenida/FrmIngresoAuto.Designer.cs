namespace FrmStyloCar
{
    partial class FrmIngresoAuto
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
            this.components = new System.ComponentModel.Container();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnIngresoAuto = new System.Windows.Forms.Button();
            this.gBoxIngresoAuto = new System.Windows.Forms.GroupBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.lblDerivaSeguro = new System.Windows.Forms.Label();
            this.cmbSeguro = new System.Windows.Forms.ComboBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbDiagnostico = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.automovilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automovilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxIngresoAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automovilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automovilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(537, 406);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(8, 33);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(8, 52);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(114, 52);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 23);
            this.txtModelo.TabIndex = 5;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(114, 33);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(51, 15);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(375, 33);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(39, 15);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(114, 104);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 23);
            this.txtAnio.TabIndex = 9;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(114, 85);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(35, 15);
            this.lblAnio.TabIndex = 6;
            this.lblAnio.Text = "Anio:";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(220, 86);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(0, 15);
            this.lblSeguro.TabIndex = 14;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(8, 105);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 23);
            this.txtPatente.TabIndex = 7;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(8, 86);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(50, 15);
            this.lblPatente.TabIndex = 10;
            this.lblPatente.Text = "Patente:";
            // 
            // btnIngresoAuto
            // 
            this.btnIngresoAuto.Location = new System.Drawing.Point(157, 197);
            this.btnIngresoAuto.Name = "btnIngresoAuto";
            this.btnIngresoAuto.Size = new System.Drawing.Size(206, 47);
            this.btnIngresoAuto.TabIndex = 22;
            this.btnIngresoAuto.Text = "Confirmar Ingreso";
            this.btnIngresoAuto.UseVisualStyleBackColor = true;
            this.btnIngresoAuto.Click += new System.EventHandler(this.btnIngresoAuto_Click);
            // 
            // gBoxIngresoAuto
            // 
            this.gBoxIngresoAuto.Controls.Add(this.lblSector);
            this.gBoxIngresoAuto.Controls.Add(this.cmbSector);
            this.gBoxIngresoAuto.Controls.Add(this.btnIngresoAuto);
            this.gBoxIngresoAuto.Controls.Add(this.lblDerivaSeguro);
            this.gBoxIngresoAuto.Controls.Add(this.cmbSeguro);
            this.gBoxIngresoAuto.Controls.Add(this.lblDiagnostico);
            this.gBoxIngresoAuto.Controls.Add(this.cmbColor);
            this.gBoxIngresoAuto.Controls.Add(this.cmbDiagnostico);
            this.gBoxIngresoAuto.Controls.Add(this.lblSeguro);
            this.gBoxIngresoAuto.Controls.Add(this.txtDni);
            this.gBoxIngresoAuto.Controls.Add(this.lblDni);
            this.gBoxIngresoAuto.Controls.Add(this.txtPatente);
            this.gBoxIngresoAuto.Controls.Add(this.lblPatente);
            this.gBoxIngresoAuto.Controls.Add(this.lblColor);
            this.gBoxIngresoAuto.Controls.Add(this.txtAnio);
            this.gBoxIngresoAuto.Controls.Add(this.lblAnio);
            this.gBoxIngresoAuto.Controls.Add(this.txtModelo);
            this.gBoxIngresoAuto.Controls.Add(this.lblModelo);
            this.gBoxIngresoAuto.Controls.Add(this.txtMarca);
            this.gBoxIngresoAuto.Controls.Add(this.lblMarca);
            this.gBoxIngresoAuto.Location = new System.Drawing.Point(57, 73);
            this.gBoxIngresoAuto.Name = "gBoxIngresoAuto";
            this.gBoxIngresoAuto.Size = new System.Drawing.Size(512, 269);
            this.gBoxIngresoAuto.TabIndex = 17;
            this.gBoxIngresoAuto.TabStop = false;
            this.gBoxIngresoAuto.Text = "Ingreso Auto";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(248, 33);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(43, 15);
            this.lblSector.TabIndex = 22;
            this.lblSector.Text = "Sector:";
            // 
            // cmbSector
            // 
            this.cmbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbSector.Location = new System.Drawing.Point(248, 51);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(121, 23);
            this.cmbSector.TabIndex = 13;
            // 
            // lblDerivaSeguro
            // 
            this.lblDerivaSeguro.AutoSize = true;
            this.lblDerivaSeguro.Location = new System.Drawing.Point(248, 90);
            this.lblDerivaSeguro.Name = "lblDerivaSeguro";
            this.lblDerivaSeguro.Size = new System.Drawing.Size(115, 15);
            this.lblDerivaSeguro.TabIndex = 20;
            this.lblDerivaSeguro.Text = "Lo manda el Seguro:";
            // 
            // cmbSeguro
            // 
            this.cmbSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeguro.FormattingEnabled = true;
            this.cmbSeguro.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbSeguro.Location = new System.Drawing.Point(248, 108);
            this.cmbSeguro.Name = "cmbSeguro";
            this.cmbSeguro.Size = new System.Drawing.Size(121, 23);
            this.cmbSeguro.TabIndex = 17;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(375, 90);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(76, 15);
            this.lblDiagnostico.TabIndex = 18;
            this.lblDiagnostico.Text = "Diagnostico: ";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(375, 52);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 23);
            this.cmbColor.TabIndex = 15;
            // 
            // cmbDiagnostico
            // 
            this.cmbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiagnostico.FormattingEnabled = true;
            this.cmbDiagnostico.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbDiagnostico.Location = new System.Drawing.Point(375, 108);
            this.cmbDiagnostico.Name = "cmbDiagnostico";
            this.cmbDiagnostico.Size = new System.Drawing.Size(121, 23);
            this.cmbDiagnostico.TabIndex = 21;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(8, 158);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 11;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(8, 139);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(70, 15);
            this.lblDni.TabIndex = 12;
            this.lblDni.Text = "DNI Cliente:";
            // 
            // automovilBindingSource
            // 
            this.automovilBindingSource.DataSource = typeof(Biblioteca.Automovil);
            // 
            // automovilBindingSource1
            // 
            this.automovilBindingSource1.DataSource = typeof(Biblioteca.Automovil);
            // 
            // FrmIngresoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.gBoxIngresoAuto);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIngresoAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIngresoAuto | Rosales.Cristian.2C";
            this.Load += new System.EventHandler(this.FrmIngresoAuto_Load);
            this.gBoxIngresoAuto.ResumeLayout(false);
            this.gBoxIngresoAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automovilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automovilBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Button btnIngresoAuto;
        private System.Windows.Forms.GroupBox gBoxIngresoAuto;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbDiagnostico;
        private System.Windows.Forms.BindingSource automovilBindingSource;
        private System.Windows.Forms.BindingSource automovilBindingSource1;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.Label lblDerivaSeguro;
        private System.Windows.Forms.ComboBox cmbSeguro;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
    }
}