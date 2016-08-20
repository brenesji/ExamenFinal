using PrimeraParteExamen.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraParteExamen.Vistas
{
    public partial class Profesores : Form
    {
        ControladorProfesor controladoresprofesor = new ControladorProfesor();
        EntidadProfesor entidadprofesor = new EntidadProfesor();

        public Profesores()
        {
            InitializeComponent();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            cargarGrid();

        }

        private void cargarGrid()
        {
            dataGridView1.DataSource = controladoresprofesor.leer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void cargarEntidad()
        {

            entidadprofesor.Id_Profesor = Convert.ToInt16(textBox1.Text);
            entidadprofesor.Nombre = textBox2.Text;
            entidadprofesor.Apellido = textBox3.Text;
            //entidadempleado.Ubicacion = textBox4.Text;
            //entidadempleado.Id_Salario = Convert.ToInt16(comboBox1.SelectedValue);


            //entidadempleado.Cedula = Convert.ToInt16(textBox1.Text);
            //entidadempleado.Nombre = textBox2.Text;
            //entidadempleado.Apellido = textBox3.Text;
            //entidadempleado.Ubicacion = textBox4.Text;
            //entidadempleado.Id_Salario = Convert.ToInt16(comboBox1.SelectedValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladoresprofesor.insertar(entidadprofesor);
            cargarGrid();
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladoresprofesor.modificar(entidadprofesor);
            cargarGrid();
            limpiarCampos();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //TextBox1.Text = DataGridView1(0, DataGridView1.CurrentRow.Index).Value
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controladoresprofesor.eliminar(Convert.ToInt16(textBox1.Text));
            cargarGrid();
            limpiarCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controladoresprofesor.buscar(Convert.ToInt16(textBox1.Text));
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
            //textBox4.Text = dt.Rows[0][3].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }
    }
}
