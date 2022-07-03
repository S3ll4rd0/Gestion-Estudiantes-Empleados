using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesYClasesAbstractas
{
    internal class Cualificados: Empleados
    {
        private string titulacion;
        private string departamento;
        private double plus;

        public Cualificados(string nombre, string prApellido, string sgApellido, double sueldoBase, string dni,
            string titulacion, string departamento, double plus) 
            : base(nombre, prApellido, sgApellido, sueldoBase, dni)
        {
            this.Titulacion = titulacion;
            this.Departamento = departamento;
            this.Plus = plus;
        }

        public string Titulacion { get => titulacion; set => titulacion = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public double Plus { get => plus; set => plus = value; }

        public new string informacion()
        {
            return "Titulación: " + Titulacion + "\nDepartamento: " + Departamento;
        }
    }
}
