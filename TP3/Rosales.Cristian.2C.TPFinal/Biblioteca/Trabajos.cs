using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    //public static class Trabajos
    public class Trabajos
    {
        //static Dictionary<Trabajo, Sector> dicTrabajos;
        public List<Trabajo> trabajosChapa;
        public List<Trabajo> trabajosPintura;
        public List<Trabajo> trabajosLavado;

        public Trabajos()
        {
            this.trabajosChapa = new List<Trabajo>();
            this.trabajosPintura = new List<Trabajo>();
            this.trabajosLavado = new List<Trabajo>();
        }

        public void Add(object nuevotrabajo)
        {
            this.Add(nuevotrabajo);
        }
        //public static Sector sector;

        ///// <summary>
        ///// Constructor con Parametros. Inicializa la lista de trabajos y le asigna el sector que corresponde
        ///// </summary>
        //public Trabajos(Sector sector)
        //{
        //    this.trabajos = new Trabajos();
        //    this.sector = sector;
        //}

        ///// <summary>
        ///// Prop ListaTrabajos. ReadOnly
        ///// </summary>
        //public static Dictionary<Trabajo, Sector> ListaTrabajos
        //{
        //    get
        //    {
        //        return dicTrabajos;
        //    }
        //    set
        //    {
        //        if(dicTrabajos ==  null)
        //        {
        //            dicTrabajos = new Dictionary<Trabajo, Sector>();
        //        }
        //    }
        //}

        ///// <summary>
        ///// Incluyo un trabajo a la lista de trabajos
        ///// </summary>
        ///// <param name="trabajo"></param>
        //public void AgregarTrabajo(List<T> trabajo)
        //{
        //    this.trabajos.Add(trabajo);
        //}

        ///// <summary>
        ///// Prop ListaTrabajos. Devuelve una lista de trabajos.
        ///// </summary>
        //public List<T> ListaTrabajos
        //{
        //    get
        //    {
        //        return this.trabajos;
        //    }
        //}
    }
}
