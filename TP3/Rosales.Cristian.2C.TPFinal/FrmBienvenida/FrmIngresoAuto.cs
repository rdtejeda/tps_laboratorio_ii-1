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
using ExcepcionesPersonalizadas;

namespace FrmStyloCar
{
    public partial class FrmIngresoAuto : Form
    {
        public FrmIngresoAuto()
        {
            InitializeComponent();
        }

        private void FrmIngresoAuto_Load(object sender, EventArgs e)
        {
            cmbColor.DataSource = Enum.GetNames(typeof(Biblioteca.Color));
            cmbDiagnostico.DataSource = Enum.GetNames(typeof(Automovil.Diagnostico));
            cmbSector.DataSource = Enum.GetNames(typeof(Biblioteca.Sector));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresoAuto_Click(object sender, EventArgs e)
        {
            string marca;
            string modelo;
            int anio;
            string patente;
            int dni;
            string color;
            bool seguro;

            try
            {
                if (String.IsNullOrEmpty(txtMarca.Text) ||
                    String.IsNullOrEmpty(txtModelo.Text) ||
                    String.IsNullOrEmpty(txtAnio.Text) ||
                    String.IsNullOrEmpty(txtPatente.Text) ||
                    String.IsNullOrEmpty(txtDni.Text) ||
                    cmbColor.SelectedItem is null || 
                    cmbDiagnostico.SelectedItem is null)
                {
                    throw new ParametrosVaciosExcepction();
                }
                try
                {
                    if(!int.TryParse(txtAnio.Text, out anio) ||
                        anio<1886 ||
                        anio > DateTime.Now.Year)
                    {
                        throw new FechaIncorrectaExcepction();
                    }
                    try
                    {
                        if(!int.TryParse(txtDni.Text, out dni) ||
                            dni < 0 ||
                            dni > 99999999)
                        {
                            throw new DniInvalidoExcepction();
                        }

                        Automovil auto = new Automovil();



                    }
                    catch (DniInvalidoExcepction)
                    {
                        MessageBox.Show("El DNI es inválido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                }
                catch (FechaIncorrectaExcepction)
                {
                    MessageBox.Show("El anio es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
            catch (ParametrosVaciosExcepction)
            {
                MessageBox.Show("No se pueden dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
