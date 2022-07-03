using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesYClasesAbstractas
{
    internal abstract class Empleados
    {
        private string nombre;
        private string prApellido;
        private string sgApellido;
        private double sueldoBase;
        private string dni;

        public Empleados(string nombre, string prApellido, string sgApellido, double sueldoBase, string dni)
        {
            this.Nombre = nombre;
            this.PrApellido = prApellido;
            this.SgApellido = sgApellido;
            this.SueldoBase = sueldoBase;
            this.Dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string PrApellido { get => prApellido; set => prApellido = value; }
        public string SgApellido { get => sgApellido; set => sgApellido = value; }
        public double SueldoBase { get => sueldoBase; set => sueldoBase = value; }
        public string Dni { get => dni; set => dni = value; }

        public string informacion()
        {
            return "Sueldo Base: " + SueldoBase + "\nEmpleado: Sin titulación";
        }
    }
}
