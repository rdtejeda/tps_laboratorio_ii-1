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
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            //FrmIngresoAuto frmIngresoAuto = new FrmIngresoAuto();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmBienvenida = new FrmBienvenida();

            int dni;
            string nombre;
            string apellido;
            string telefono;
            double tel;
            string mail;
            string patente;

            try
            {
                if (String.IsNullOrEmpty(txtDni.Text) ||
                    String.IsNullOrEmpty(txtNombre.Text) ||
                    String.IsNullOrEmpty(txtApellido.Text) ||
                    String.IsNullOrEmpty(txtTelefono.Text) ||
                    String.IsNullOrEmpty(txtMail.Text) ||
                    String.IsNullOrEmpty(txtPatente.Text)
                    )
                {
                    throw new ParametrosVaciosExcepction();
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
                        patente = txtPatente.Text;

                        Cliente nuevoCliente = new Cliente(dni, nombre, apellido, telefono, mail, patente);

                        FrmBienvenida.listaClientes.Add(nuevoCliente);

                        MessageBox.Show("Cliente agregado Exitosamente.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarTextBoxes();
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
            catch (ParametrosVaciosExcepction)
            {
                MessageBox.Show("No se pueden dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarTextBoxes()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtMail.Clear();
            txtPatente.Clear();
        }
    }
}
