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

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            
        }

        #region Cambio de Form
        private void btnIngresoAuto_Click(object sender, EventArgs e)
        {
            Clientes listaClientes = new Clientes();
            Trabajos listaTrabajos = new Trabajos();
            //Trabajos listaTrabajosPintura = new Trabajos(Sector.Pintura);
            //Trabajos listaTrabajosLavado = new Trabajos(Sector.Lavado);

            FrmIngresoAuto frmIngresoAuto = new FrmIngresoAuto();
            FrmAltaCliente frmIngresoCliente = new FrmAltaCliente();

            frmIngresoAuto.RecibirListaClientes(listaClientes);
            //frmIngresoAuto.RecibirDictTrabajos(dictTrabajos);
            frmIngresoAuto.RecibirListaChapa(listaTrabajos);
            //frmIngresoAuto.RecibirListaPintura(listaTrabajosChapa);
            //frmIngresoAuto.RecibirListaLavado(listaTrabajosChapa);
            frmIngresoCliente.RecibirLista(listaClientes);
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
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.ShowDialog();
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

    }
}
