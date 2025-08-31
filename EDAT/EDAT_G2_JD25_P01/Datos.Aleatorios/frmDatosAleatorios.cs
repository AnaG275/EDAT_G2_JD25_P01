using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos.Aleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        private void frmDatosAleatorios_Load(object sender, EventArgs e)
        {
            cboGrupo.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();

            emp.Numero = rnd.Next(1000, 9999);
            emp.Nombre = GenerarNombre();
            emp.FechaNacimiento = new DateTime(rnd.Next(1970, 2003), rnd.Next(1, 13), rnd.Next(1, 28));
            emp.Sexo = (rnd.Next(0, 2) == 0) ? "Masculino" : "Femenino";
            emp.Grupo = (char)rnd.Next('A', 'F'); // A-E
            emp.Sueldo = Math.Round(rnd.NextDouble() * 20000 + 5000, 2);
            emp.SeguroMedico = rnd.Next(0, 2) == 1;

            // Mostrar en los controles
            txtNumero.Text = emp.Numero.ToString();
            txtNombre.Text = emp.Nombre;
            dtpFechaNacimiento.Value = emp.FechaNacimiento;

            if (emp.Sexo == "Masculino")
                rbMasculino.Checked = true;
            else
                rbFemenino.Checked = true;

            cboGrupo.Text = emp.Grupo.ToString();
            txtSueldo.Text = emp.Sueldo.ToString("F2");
            chkSeguro.Checked = emp.SeguroMedico;
        }

        private string GenerarNombre()
        {
            string[] nombres = { "Ana", "Luis", "Pedro", "María", "Lucía", "Jorge", "Sofía", "Carlos" };
            string[] apellidos = { "García", "Hernández", "Martínez", "López", "Sánchez", "Ramírez" };
            return $"{nombres[rnd.Next(nombres.Length)]} {apellidos[rnd.Next(apellidos.Length)]}";
        }
    }
}
