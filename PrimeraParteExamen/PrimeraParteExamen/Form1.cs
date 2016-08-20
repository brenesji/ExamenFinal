using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraParteExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vistas.Estudiantes estu = new Vistas.Estudiantes();
            estu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vistas.Profesores profe = new Vistas.Profesores();
            profe.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vistas.Materias mate = new Vistas.Materias();
            mate.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vistas.Estadisticas esta = new Vistas.Estadisticas();
            esta.Show();
        }
    }
}
