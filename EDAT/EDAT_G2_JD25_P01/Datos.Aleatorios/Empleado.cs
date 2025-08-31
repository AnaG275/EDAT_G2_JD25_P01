using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Aleatorios
{
    public class Empleado
    {
        // Campos privados
        private int _intNumero;
        private string _strNombre;
        private DateTime _dtmFechaNacimiento;
        private string _strSexo;
        private char _chrGrupo;
        private double _dblSueldo;
        private bool _blnSeguroMedico;

        // Propiedades
        public int Numero { get => _intNumero; set => _intNumero = value; }
        public string Nombre { get => _strNombre; set => _strNombre = value; }
        public DateTime FechaNacimiento { get => _dtmFechaNacimiento; set => _dtmFechaNacimiento = value; }
        public string Sexo { get => _strSexo; set => _strSexo = value; }
        public char Grupo { get => _chrGrupo; set => _chrGrupo = value; }
        public double Sueldo { get => _dblSueldo; set => _dblSueldo = value; }
        public bool SeguroMedico { get => _blnSeguroMedico; set => _blnSeguroMedico = value; }

        public override string ToString()
        {
            return $"Número: {Numero}\nNombre: {Nombre}\nFecha: {FechaNacimiento.ToShortDateString()}\n" +
                   $"Sexo: {Sexo}\nGrupo: {Grupo}\nSueldo: {Sueldo:C}\nSeguro Médico: {SeguroMedico}";
        }
    }
}
