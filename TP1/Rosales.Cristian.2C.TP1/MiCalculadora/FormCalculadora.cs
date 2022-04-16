using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numeroUno = this.txtNumero1.Text;
            string numeroDos = this.txtNumero2.Text;
            string operacion = this.cmbOperador.GetItemText(this.cmbOperador.SelectedItem);
            string calculadora;
            string resultado = Operar(numeroUno, numeroDos, operacion).ToString();
            this.lblResultado.Text = resultado;
            calculadora = $"{numeroUno} {operacion} {numeroDos} = {resultado}";
            this.lstOperaciones.Items.Add(calculadora);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = this.lblResultado.Text;
            if (resultado != "Resultado")
            {
                resultado = Operando.DecimalBinario(resultado);
                this.lblResultado.Text = resultado;
            }
            
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = this.lblResultado.Text;
            if (resultado != "Resultado")
            {
                resultado = Operando.BinarioDecimal(resultado);
                this.lblResultado.Text = resultado;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = String.Empty;
            this.cmbOperador.Text = $" {Environment.NewLine}+{Environment.NewLine}-{Environment.NewLine}/{Environment.NewLine}* ";
            this.txtNumero2.Text = String.Empty;
            this.lblResultado.Text = String.Empty;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            
            Operando numeroUno = new Operando(numero1);
            Operando numeroDos = new Operando(numero2);
            char operacion = Convert.ToChar(operador);
            
            resultado = Calculadora.Operar(numeroUno, numeroDos, operacion);
            
            return resultado;
        }
    }
}
