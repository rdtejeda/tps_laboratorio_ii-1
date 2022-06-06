using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Clientes
    {
        private List<Cliente> clientes;

        public Clientes()
        {
            clientes = new List<Cliente>();;
        }

        /// <summary>
        /// Prop Lista Cliente. ReadOnly
        /// </summary>
        public List<Cliente> ListaCliente
        {
            get
            {
                return this.clientes;
            }
        }

        /// <summary>
        /// Metodo Agregar Cliente.
        /// </summary>
        /// <param name="clienteNuevo"></param>
        public void Add(Cliente clienteNuevo)
        {
            this.Add(clienteNuevo);
        }
    }
}
