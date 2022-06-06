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
            
            cmbColor.SelectedIndex = -1;
            cmbDiagnostico.SelectedIndex = -1;
            cmbSeguro.SelectedIndex = -1;
            cmbSector.SelectedIndex = -1;

            //Trabajos trabajoChapa = new Trabajos(Sector.Chapa);
            //Trabajos trabajoPintura = new Trabajos(Sector.Pintura);
            //Trabajos trabajoLavado = new Trabajos(Sector.Lavado);
        }

        private void btnIngresoAuto_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmBienvenida = new FrmBienvenida();

            string marca;
            string modelo;
            int anio;
            string patente;
            int dni;
            bool seguro = false;
            Biblioteca.Color color;
            Automovil.Diagnostico diagnostico;
            Biblioteca.Sector sector;
            DateTime fechaInicio = DateTime.Today;
            bool clienteNuevo = true;

            try
            {
                if (String.IsNullOrEmpty(txtMarca.Text) ||
                    String.IsNullOrEmpty(txtModelo.Text) ||
                    String.IsNullOrEmpty(txtAnio.Text) ||
                    String.IsNullOrEmpty(txtPatente.Text) ||
                    String.IsNullOrEmpty(txtDni.Text) ||
                    cmbColor.SelectedItem is null || 
                    cmbColor.SelectedIndex == -1 || 
                    cmbDiagnostico.SelectedItem is null ||
                    cmbDiagnostico.SelectedIndex == -1||
                    cmbSector.SelectedItem is null ||
                    cmbSector.SelectedIndex == -1 ||
                    cmbSeguro.SelectedItem is null ||
                    cmbSeguro.SelectedIndex == -1)
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

                    marca = txtMarca.Text;
                    modelo = txtModelo.Text;
                    patente = txtPatente.Text;
                    color = (Biblioteca.Color)cmbColor.SelectedIndex;
                    diagnostico = (Automovil.Diagnostico)cmbDiagnostico.SelectedIndex;
                    sector = (Biblioteca.Sector)cmbDiagnostico.SelectedIndex;
                    if (cmbSeguro.SelectedItem.ToString() == "SI")
                    {
                        seguro = true;
                    }

                    try
                    {
                        if (!int.TryParse(txtDni.Text, out dni) ||
                            dni < 0 ||
                            dni > 99999999)
                        {
                            throw new DniInvalidoExcepction();
                        }

                        marca = txtMarca.Text;
                        modelo = txtModelo.Text;
                        patente = txtPatente.Text;
                        color = (Biblioteca.Color)cmbColor.SelectedIndex;
                        diagnostico = (Automovil.Diagnostico)cmbDiagnostico.SelectedIndex;
                        sector = (Biblioteca.Sector)cmbDiagnostico.SelectedIndex;
                        if (cmbSeguro.SelectedText == "SI")
                        {
                            seguro = true;
                        }

                        foreach(Cliente c in FrmBienvenida.listaClientes)
                        {
                            if(c.Dni == dni)
                            {
                                clienteNuevo = false;
                                break;
                            }

                        }
                        if(clienteNuevo == true)
                        {
                            MessageBox.Show("Cliente Nuevo. Se debe dar de alta.",          "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmAltaCliente frmAltaCliente = new FrmAltaCliente();
                            frmAltaCliente.ShowDialog();
                        }
                        Automovil autoNuevo = new Automovil(marca, modelo, anio, color, patente, diagnostico);
                        Trabajo nuevoTrabajo = new Trabajo(fechaInicio, autoNuevo, seguro, sector);

                        FrmBienvenida.listaTrabajos.Add(nuevoTrabajo);
                        MessageBox.Show("Se dio de alta un nuevo trabajo pendiente.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarTextBoxes();

                    }
                    catch (DniInvalidoExcepction)
                    {
                        MessageBox.Show("El DNI es inválido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FechaIncorrectaExcepction)
                {
                    MessageBox.Show("El anio es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ParametrosVaciosExcepction)
            {
                MessageBox.Show("No se pueden dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxes();
            this.Close();
        }

        private void LimpiarTextBoxes()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtAnio.Clear();
            txtPatente.Clear();
            txtDni.Clear();
            cmbColor.SelectedIndex = -1;
            cmbSeguro.SelectedIndex = -1;
            cmbDiagnostico.SelectedIndex = -1;
            cmbSector.SelectedIndex = -1;
        }
        
    }
}
