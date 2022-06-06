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
        public static List<Trabajo> listaTrabajos;
        public static List<Cliente> listaClientes;
        public static List<Empleado> listaEmpleados;

        BindingSource trabajosBindingSource = new BindingSource();

        public FrmBienvenida()
        {
            listaTrabajos = new List<Trabajo>();
            listaClientes = new List<Cliente>();
            listaEmpleados = new List<Empleado>();
            InitializeComponent();

        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToString("dd-MM-yyyy");
            txtHora.Text = DateTime.Now.ToString("H:mm");        
        }

        #region Cambio de Form
        private void btnIngresoAuto_Click(object sender, EventArgs e)
        {
            //Clientes listaClientes = new Clientes();
            ////Trabajos listaTrabajosPintura = new Trabajos(Sector.Pintura);
            ////Trabajos listaTrabajosLavado = new Trabajos(Sector.Lavado);

            FrmIngresoAuto frmIngresoAuto = new FrmIngresoAuto();
            //FrmAltaCliente frmIngresoCliente = new FrmAltaCliente();

            //frmIngresoAuto.RecibirListaClientes(listaClientes);
            //frmIngresoAuto.RecibirListTrabajos(listaTrabajos);
            //frmIngresoAuto.RecibirListaChapa(listaTrabajos);
            ////frmIngresoAuto.RecibirListaPintura(listaTrabajosChapa);
            ////frmIngresoAuto.RecibirListaLavado(listaTrabajosChapa);
            //frmIngresoCliente.RecibirLista(listaClientes);
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
        private void btnInformes_Click(object sender, EventArgs e)
        {
            FrmInformes frmInformes = new FrmInformes();
            frmInformes.ShowDialog();

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
