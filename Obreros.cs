using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesYClasesAbstractas
{
    internal class Obreros: Empleados
    {
        private string destinoTrabajo;
        private int horasExtra;
        private double precioHE;

        public Obreros(string nombre, string prApellido, string sgApellido, double sueldoBase, string dni, 
            string destinoTrabajo, int horasExtra, double precioHE) 
            : base(nombre, prApellido, sgApellido, sueldoBase, dni)
        {
            this.DestinoTrabajo = destinoTrabajo;
            this.HorasExtra = horasExtra;
            this.PrecioHE = precioHE;
        }

        public string DestinoTrabajo { get => destinoTrabajo; set => destinoTrabajo = value; }
        public int HorasExtra { get => horasExtra; set => horasExtra = value; }
        public double PrecioHE { get => precioHE; set => precioHE = value; }

        public new string informacion()
        {
            return "Destino: " + DestinoTrabajo + "\nPrecio de las horas extra: " + PrecioHE + "€";
        }
    }
}
