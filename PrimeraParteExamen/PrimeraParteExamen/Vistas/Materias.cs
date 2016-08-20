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
    public partial class Materias : Form
    {
        ControladorMateria controladoresmateria = new ControladorMateria();
        EntidadMateria entidadmateria = new EntidadMateria();

        ControladorProfesor controladoresprofesor = new ControladorProfesor();
        EntidadProfesor entidadprofesor = new EntidadProfesor();

        public Materias()
        {
            InitializeComponent();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            cargarGrid();
            cmbSal.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable dt1 = new DataTable();
            dt1 = controladoresprofesor.leer();
            Dictionary<int, string> data = new Dictionary<int, string>();
            string compose = "";
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                compose = dt1.Rows[i][0].ToString() + " " + dt1.Rows[i][1].ToString() + " " + dt1.Rows[i][2].ToString();
                data.Add(int.Parse(dt1.Rows[i][0].ToString()), compose);
            }

            cmbSal.DataSource = new BindingSource(data, null);
            cmbSal.DisplayMember = "Value";
            cmbSal.ValueMember = "Key";

            cmbSal.SelectedIndex = 0;

        }


        private void cargarGrid()
        {
            dataGridView1.DataSource = controladoresmateria.leer();
        }

        private void cargarEntidad()
        {

            entidadmateria.Id_materia = Convert.ToInt32(textBox1.Text);
            entidadmateria.Nombre = textBox2.Text;
            //entidadmateria.Apellido = textBox3.Text;
            //entidadmateria.Ubicacion = textBox4.Text;
            ///For debug
            //Console.WriteLine("TEST: " + cmbSal.SelectedValue.ToString());
            entidadmateria.Id_Profesor = Int32.Parse(cmbSal.SelectedValue.ToString());


            //entidadmateria.Id_materia = Convert.ToInt16(textBox1.Text);
            //entidadmateria.Nombre = textBox2.Text;
            //entidadmateria.Id_Profesor = Convert.ToInt16(textBox1.Text);

        }


        private void limpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            //textBox3.Text = "";

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //TextBox1.Text = DataGridView1(0, DataGridView1.CurrentRow.Index).Value
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            //textBox3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladoresmateria.insertar(entidadmateria);
            cargarGrid();
            limpiarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladoresmateria.modificar(entidadmateria);
            cargarGrid();
            limpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controladoresmateria.eliminar(Convert.ToInt32(textBox1.Text));
            cargarGrid();
            limpiarCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                //Buscar
                DataTable dt = new DataTable();
                dt = controladoresmateria.buscar(Convert.ToInt32(textBox1.Text));
                textBox2.Text = dt.Rows[0][1].ToString();
                //textBox3.Text = dt.Rows[0][2].ToString();
                //textBox4.Text = dt.Rows[0][3].ToString();
                //int index = Convert.ToInt16(dt.Rows[0][4].ToString()) + 1;
                //comboBox1.SelectedIndex = index;      

                // Seleccion del rango del combobox
                if (dt.Rows[0][2].ToString().Equals("1"))
                    cmbSal.SelectedIndex = 0;
                else if (dt.Rows[0][2].ToString().Equals("2"))
                    cmbSal.SelectedIndex = 1;
                else if (dt.Rows[0][2].ToString().Equals("3"))
                    cmbSal.SelectedIndex = 2;
                else if (dt.Rows[0][2].ToString().Equals("4"))
                    cmbSal.SelectedIndex = 3;
                else if (dt.Rows[0][2].ToString().Equals("5"))
                    cmbSal.SelectedIndex = 4;
                else if (dt.Rows[0][2].ToString().Equals("6"))
                    cmbSal.SelectedIndex = 5;
                else if (dt.Rows[0][2].ToString().Equals("7"))
                    cmbSal.SelectedIndex = 6;
                else if (dt.Rows[0][2].ToString().Equals("8"))
                    cmbSal.SelectedIndex = 7;
                else if (dt.Rows[0][2].ToString().Equals("9"))
                    cmbSal.SelectedIndex = 8;
                else if (dt.Rows[0][2].ToString().Equals("10"))
                    cmbSal.SelectedIndex = 9;
                else if (dt.Rows[0][2].ToString().Equals("11"))
                    cmbSal.SelectedIndex = 10;
                else if (dt.Rows[0][2].ToString().Equals("12"))
                    cmbSal.SelectedIndex = 11;
                else if (dt.Rows[0][2].ToString().Equals("13"))
                    cmbSal.SelectedIndex = 12;
                else if (dt.Rows[0][2].ToString().Equals("14"))
                    cmbSal.SelectedIndex = 13;
                else if (dt.Rows[0][2].ToString().Equals("15"))
                    cmbSal.SelectedIndex = 14;
                else if (dt.Rows[0][2].ToString().Equals("16"))
                    cmbSal.SelectedIndex = 15;
                else
                    cmbSal.SelectedIndex = 0;
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
