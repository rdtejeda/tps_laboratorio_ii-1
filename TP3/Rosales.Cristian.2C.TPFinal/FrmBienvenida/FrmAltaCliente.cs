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
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaCliente_Activated(object sender, EventArgs e)
        {
            lstClientes.ResetBindings();
        }

        internal void RecibirLista(Clientes listaClientes)
        {
            foreach(Cliente c in listaClientes.ListaCliente)
            {
                lstClientes.DataSource = c.NombreCompleto;
            }
            
        }
    }
}
