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

                foreach(Trabajo t in FrmBienvenida.listaTrabajos)
                {
                    if(t.Auto.Patente == patente)
                    {
                        if(t.TrabajoTerminado == false)
                        {
                            lstTrabajos.Items.Add(t.ToString());
                        }
                    }
                }
                try
                {
                    if(lstTrabajos.SelectedItem is null)
                    {
                        throw new ParametrosVaciosExcepction();
                    }

                    Trabajo trabajoTerminar = lstTrabajos.SelectedItem as Trabajo;
                    if(trabajoTerminar != null)
                    {
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
    }
}
