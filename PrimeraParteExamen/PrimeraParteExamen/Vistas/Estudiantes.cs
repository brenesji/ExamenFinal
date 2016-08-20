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
    public partial class Estudiantes : Form
    {
        ControladorEstudiante controladorestudiante = new ControladorEstudiante();
        EntidadEstudiante entidadestudiante = new EntidadEstudiante();

        ControladorMateria controladoresmateria = new ControladorMateria();
        EntidadMateria entidadmateria = new EntidadMateria();

        public Estudiantes()
        {
            InitializeComponent();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            cargarGrid();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable dt1 = new DataTable();
            dt1 = controladoresmateria.leer();
            Dictionary<int, string> data = new Dictionary<int, string>();
            string compose = "";
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                compose = dt1.Rows[i][0].ToString() + " " + dt1.Rows[i][1].ToString();
                data.Add(int.Parse(dt1.Rows[i][0].ToString()), compose);
            }

            comboBox1.DataSource = new BindingSource(data, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            comboBox1.SelectedIndex = 0;


        }


        private void cargarGrid()
        {
            dataGridView1.DataSource = controladorestudiante.leer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladorestudiante.insertar(entidadestudiante);
            cargarGrid();
            limpiarCampos();
        }

        private void cargarEntidad()
        {

            entidadestudiante.Id_estudiante = Convert.ToInt32(textBox1.Text);
            entidadestudiante.Nombre = textBox2.Text;
            entidadestudiante.Apellido = textBox3.Text;
            entidadestudiante.Direccion = textBox4.Text;
            entidadestudiante.Edad = Convert.ToInt32(textBox5.Text);
            ///For debug
            //Console.WriteLine("TEST: " + cmbSal.SelectedValue.ToString());
            entidadestudiante.Id_Curso = Int32.Parse(comboBox1.SelectedValue.ToString());


            //entidadmateria.Id_materia = Convert.ToInt16(textBox1.Text);
            //entidadmateria.Nombre = textBox2.Text;
            //entidadmateria.Id_Profesor = Convert.ToInt16(textBox1.Text);

        }


        private void limpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //TextBox1.Text = DataGridView1(0, DataGridView1.CurrentRow.Index).Value
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                //textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladorestudiante.modificar(entidadestudiante);
            cargarGrid();
            limpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controladorestudiante.eliminar(Convert.ToInt32(textBox1.Text));
            cargarGrid();
            limpiarCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                //Buscar
                DataTable dt = new DataTable();
                dt = controladorestudiante.buscar(Convert.ToInt32(textBox1.Text));
                textBox2.Text = dt.Rows[0][1].ToString();
                textBox3.Text = dt.Rows[0][2].ToString();
                textBox4.Text = dt.Rows[0][3].ToString();
                textBox5.Text = dt.Rows[0][4].ToString();
                //int index = Convert.ToInt16(dt.Rows[0][4].ToString()) + 1;
                //comboBox1.SelectedIndex = index;      

                // Seleccion del rango del combobox
                if (dt.Rows[0][5].ToString().Equals("1"))
                    comboBox1.SelectedIndex = 0;
                else if (dt.Rows[0][5].ToString().Equals("2"))
                    comboBox1.SelectedIndex = 1;
                else if (dt.Rows[0][5].ToString().Equals("3"))
                    comboBox1.SelectedIndex = 2;
                else if (dt.Rows[0][5].ToString().Equals("4"))
                    comboBox1.SelectedIndex = 3;
                else if (dt.Rows[0][5].ToString().Equals("5"))
                    comboBox1.SelectedIndex = 4;
                else if (dt.Rows[0][5].ToString().Equals("6"))
                    comboBox1.SelectedIndex = 5;
                else if (dt.Rows[0][5].ToString().Equals("7"))
                    comboBox1.SelectedIndex = 6;
                else if (dt.Rows[0][5].ToString().Equals("8"))
                    comboBox1.SelectedIndex = 7;
                else if (dt.Rows[0][5].ToString().Equals("9"))
                    comboBox1.SelectedIndex = 8;
                else if (dt.Rows[0][5].ToString().Equals("10"))
                    comboBox1.SelectedIndex = 9;
                else if (dt.Rows[0][5].ToString().Equals("11"))
                    comboBox1.SelectedIndex = 10;
                else if (dt.Rows[0][5].ToString().Equals("12"))
                    comboBox1.SelectedIndex = 11;
                else if (dt.Rows[0][5].ToString().Equals("13"))
                    comboBox1.SelectedIndex = 12;
                else if (dt.Rows[0][5].ToString().Equals("14"))
                    comboBox1.SelectedIndex = 13;
                else if (dt.Rows[0][5].ToString().Equals("15"))
                    comboBox1.SelectedIndex = 14;
                else if (dt.Rows[0][5].ToString().Equals("16"))
                    comboBox1.SelectedIndex = 15;
                else
                    comboBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Ingrese una Cedula a buscar");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }
    }
}
