using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcepcionesPersonalizadas;
using Biblioteca;

namespace FrmStyloCar
{
    public partial class FrmEgresoAuto : Form
    {
        public FrmEgresoAuto()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            string patente;
            DateTime fechaFin = DateTime.Today;
            try
            {
                if (String.IsNullOrEmpty(txtPatente.Text))
                {
                    throw new PatenteInvalidaException();
                }
                patente = txtPatente.Text;

                try
                {
                    if(lstTrabajos.SelectedIndex == -1)
                    {
                        throw new ParametrosVaciosExcepction();
                    }

                    Trabajo trabajoTerminar = lstTrabajos.SelectedItem as Trabajo;
                    if(trabajoTerminar != null)
                    {
                        trabajoTerminar.TrabajoTerminado = true;
                        trabajoTerminar.FechaFin = fechaFin;
                     
                    }
                    MessageBox.Show("Se termino el trabajo seleccionado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarBoxes();

                }
                catch (Exception)
                {

                    MessageBox.Show("Debe seleccionar un trabajo para terminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (PatenteInvalidaException)
            {

                MessageBox.Show("La Patente no puede quedar vacia.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarBoxes()
        {
            txtPatente.Clear();
            lstTrabajos.ResetText();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmBienvenida = new FrmBienvenida();
            try
            {
                if (String.IsNullOrEmpty(txtPatente.Text))
                {
                    throw new ParametrosVaciosExcepction();
                }

                Automovil auxAuto = null;
                foreach(Trabajo trabajo in FrmBienvenida.listaTrabajos)
                {
                    if(trabajo.Auto.Patente == txtPatente.Text)
                    {
                        lstTrabajos.Items.Add(trabajo); 
                        auxAuto = trabajo.Auto;
                    }
                }
                try
                {
                    if(auxAuto is null)
                    {
                        throw new ParametrosVaciosExcepction();
                    }
                    try
                    {
                        if(lstTrabajos.SelectedIndex == -1)
                        {
                            throw new ParametrosVaciosExcepction();
                        }
                    }
                    catch (ParametrosVaciosExcepction)
                    {

                        MessageBox.Show("No se seleccionó ningún trabajo de la lista para poder FINALIZAR.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (ParametrosVaciosExcepction)
                {
                    MessageBox.Show("No se encontró la patente ingresada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ParametrosVaciosExcepction)
            {
                MessageBox.Show("Se debe ingresar una patente a buscar.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEgresoAuto_Load(object sender, EventArgs e)
        {
            
        }
    }
}
