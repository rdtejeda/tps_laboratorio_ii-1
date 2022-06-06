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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            cmbSector.DataSource = Enum.GetNames(typeof(Biblioteca.Sector));
            cmbSector.SelectedIndex = -1;
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmBienvenida = new FrmBienvenida();

            int dni;
            string nombre;
            string apellido;
            string telefono;
            double tel;
            string mail;
            Biblioteca.Sector sector;
            DateTime fechaIngreso;
            DateTime fechaApertura = new DateTime(1, 1, 2020);

            try
            {
                if (String.IsNullOrEmpty(txtDni.Text) ||
                    String.IsNullOrEmpty(txtNombre.Text) ||
                    String.IsNullOrEmpty(txtApellido.Text) ||
                    String.IsNullOrEmpty(txtTelefono.Text) ||
                    String.IsNullOrEmpty(txtMail.Text) ||
                    cmbSector.SelectedItem is null ||
                    cmbSector.SelectedIndex == -1 ||
                    String.IsNullOrEmpty(txtFechaIngreso.Text))
                {
                    throw new AltaEmpleadoException();
                }

                try
                {
                    if (!int.TryParse(txtDni.Text, out dni) ||
                            dni < 0 ||
                            dni > 99999999)
                    {
                        throw new DniInvalidoExcepction();
                    }
                    try
                    {
                        if (!double.TryParse(txtTelefono.Text, out tel) ||
                            tel < 0 ||
                            tel >= 9999999999)
                        {
                            throw new TelefonoInvalidoException();
                        }
                        nombre = txtNombre.Text;
                        apellido = txtApellido.Text;
                        telefono = txtTelefono.Text;
                        mail = txtMail.Text;
                        sector = (Biblioteca.Sector)cmbSector.SelectedIndex;
                        try
                        {
                            if(!DateTime.TryParse(txtFechaIngreso.Text, out fechaIngreso) ||
                                fechaIngreso<fechaApertura)
                            {
                                throw new TelefonoInvalidoException();
                            }
                            Empleado nuevoEmpleado = new Empleado(dni, nombre, apellido, sector, fechaIngreso, telefono, mail);

                            FrmBienvenida.listaEmpleados.Add(nuevoEmpleado);

                            MessageBox.Show("Empleado agregado Exitosamente.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarCheckBoxes();

                        }
                        catch (TelefonoInvalidoException)
                        {

                            MessageBox.Show("El Telefono es inválido.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        
                    }
                    catch (TelefonoInvalidoException)
                    {

                        MessageBox.Show("El Telefono es inválido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (DniInvalidoExcepction)
                {

                    MessageBox.Show("El DNI es inválido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (AltaEmpleadoException)
            {
                MessageBox.Show("No se pueden dejar campos vacios o sin seleccionar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LimpiarCheckBoxes()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtMail.Clear();
            txtTelefono.Clear();
            cmbSector.SelectedIndex = -1;
        }
    }
}
