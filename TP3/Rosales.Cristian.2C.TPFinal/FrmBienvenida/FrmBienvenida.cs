using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace FrmStyloCar
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        #region Cambio de Form
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.ShowDialog();
        }
        private void btnIngresoAuto_Click(object sender, EventArgs e)
        {
            FrmIngresoAuto frmIngresoAuto = new FrmIngresoAuto();
            frmIngresoAuto.ShowDialog();
        }
        private void btnEgresoAuto_Click(object sender, EventArgs e)
        {
            FrmEgresoAuto frmEgresoAuto = new FrmEgresoAuto();
            frmEgresoAuto.ShowDialog();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            FrmDeposito frmDeposito = new FrmDeposito();
            frmDeposito.ShowDialog();
        }
        #endregion



        #region Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBienvenida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            Trabajos trabajoChapa = new Trabajos(Sector.Chapa);
            Trabajos trabajoPintura = new Trabajos(Sector.Pintura);
            Trabajos trabajoLavado = new Trabajos(Sector.Lavado);
        }
    }
}
