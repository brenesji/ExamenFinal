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
    public partial class Estadisticas : Form
    {
        ControladorEstudiante controladorestudiante = new ControladorEstudiante();
        EntidadEstudiante entidadestudiante = new EntidadEstudiante();

        ControladorMateria controladoresmateria = new ControladorMateria();
        EntidadMateria entidadmateria = new EntidadMateria();

        ControladorProfesor controladoresprofesor = new ControladorProfesor();
        EntidadProfesor entidadprofesor = new EntidadProfesor();


        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            cargarGrid();


        }

        private void cargarGrid()
        {
            dataGridView1.DataSource = controladorestudiante.leer();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar
            int menores = 0;
            int mayores = 0;
            DataTable dt = new DataTable();
            dt = controladorestudiante.leer();



            for (int i = 0; i < dt.Rows.Count; i++)
            {

                int x = Int32.Parse(dt.Rows[i][4].ToString());
                if (x >= 18)
                    menores = menores + 1;
                else
                    mayores++;

            }
            textBox1.Text = menores.ToString();
            textBox2.Text = mayores.ToString();



        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            int mate = 0;
            int cultu = 0, espa = 0,  soc = 0, cien = 0, civi = 0, artes = 0;
            DataTable dt = new DataTable();
            dt = controladorestudiante.leer();
            DataTable dt1 = new DataTable();
            dt1 = controladoresmateria.leer();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Seleccion del rango del combobox
                if (dt.Rows[i][5].ToString().Equals("1"))
                { mate = mate + 1; }
                else if (dt.Rows[i][5].ToString().Equals("2"))
                    cultu++;
                else if (dt.Rows[i][5].ToString().Equals("3"))
                    espa++;
                else if (dt.Rows[i][5].ToString().Equals("4"))
                    soc++;
                else if (dt.Rows[i][5].ToString().Equals("5"))
                    cien++;
                else if (dt.Rows[i][5].ToString().Equals("6"))
                    civi++;
                else
                    artes++;

            }

            textBox4.Text = mate.ToString();
            textBox6.Text = cultu.ToString();
            textBox8.Text = espa.ToString();
            textBox10.Text = soc.ToString();
            textBox12.Text = cien.ToString();
            textBox14.Text = civi.ToString();
            textBox16.Text = artes.ToString();


            for (int i = 0; i < dt1.Rows.Count; i++)
            {

                if (dt1.Rows[i][0].ToString().Equals("1"))

                    textBox3.Text = dt1.Rows[i][1].ToString();

                else if (dt1.Rows[i][0].ToString().Equals("2"))
                    textBox5.Text = dt1.Rows[i][1].ToString();
                else if (dt1.Rows[i][0].ToString().Equals("3"))
                    textBox7.Text = dt1.Rows[i][1].ToString();
                else if (dt1.Rows[i][0].ToString().Equals("4"))
                    textBox9.Text = dt1.Rows[i][1].ToString();
                else if (dt1.Rows[i][0].ToString().Equals("5"))
                    textBox11.Text = dt1.Rows[i][1].ToString();
                else if (dt1.Rows[i][0].ToString().Equals("6"))
                    textBox13.Text = dt1.Rows[i][1].ToString();
                else
                    textBox15.Text = dt1.Rows[i][1].ToString();
        }



    }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            int mate = 0;
            int cultu = 0, espa = 0, soc = 0, cien = 0, civi = 0, artes = 0;
            DataTable dt = new DataTable();
            dt = controladoresprofesor.leer();
            DataTable dt1 = new DataTable();
            dt1 = controladoresmateria.leer();


            //for (int i = 0; i < dt.Rows.Count; i++)
            //{

                textBox30.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                textBox28.Text = dt.Rows[1][1].ToString() + " " + dt.Rows[1][2].ToString();
                textBox26.Text = dt.Rows[2][1].ToString() + " " + dt.Rows[2][2].ToString();
                textBox24.Text = dt.Rows[3][1].ToString() + " " + dt.Rows[3][2].ToString();
                textBox22.Text = dt.Rows[4][1].ToString() + " " + dt.Rows[4][2].ToString();
                textBox20.Text = dt.Rows[5][1].ToString() + " " + dt.Rows[5][2].ToString();
                //textBox18.Text = dt.Rows[6][1].ToString() + " " + dt.Rows[i][2].ToString();

            //}



            for (int i = 0; i < dt1.Rows.Count; i++)
            {

                if (dt1.Rows[i][2].ToString().Equals("1"))

                    mate = mate + 1;

                else if (dt1.Rows[i][2].ToString().Equals("2"))
                    cultu++;
                else if (dt1.Rows[i][2].ToString().Equals("3"))
                    espa++;
                else if (dt1.Rows[i][2].ToString().Equals("4"))
                    soc++;
                else if (dt1.Rows[i][2].ToString().Equals("5"))
                    cien++;
                else
                    civi++;
                //else
                //    artes++;
            }

            textBox29.Text = mate.ToString();
            textBox27.Text = cultu.ToString();
            textBox25.Text = espa.ToString();
            textBox23.Text = soc.ToString();
            textBox21.Text = cien.ToString();
            textBox19.Text = civi.ToString();
            //textBox17.Text = artes.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int javi = 0;
            int jul = 0, mar = 0, fab = 0, esc = 0, ric = 0;
            DataTable dt = new DataTable();
            dt = controladoresprofesor.leer();

            DataTable dt1 = new DataTable();
            dt1 = controladorestudiante.leer();


                textBox44.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                textBox42.Text = dt.Rows[1][1].ToString() + " " + dt.Rows[1][2].ToString();
                textBox40.Text = dt.Rows[2][1].ToString() + " " + dt.Rows[2][2].ToString();
                textBox38.Text = dt.Rows[3][1].ToString() + " " + dt.Rows[3][2].ToString();
                textBox36.Text = dt.Rows[4][1].ToString() + " " + dt.Rows[4][2].ToString();
                textBox34.Text = dt.Rows[5][1].ToString() + " " + dt.Rows[5][2].ToString();


            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                // Seleccion del rango del combobox
                if (dt1.Rows[i][5].ToString().Equals("1"))
                    javi++;
                else if (dt1.Rows[i][5].ToString().Equals("2"))
                    jul++;
                else if (dt1.Rows[i][5].ToString().Equals("3"))
                    mar++;
                else if (dt1.Rows[i][5].ToString().Equals("4"))
                    fab++;
                else if (dt1.Rows[i][5].ToString().Equals("5"))
                    esc++;
                else
                    ric++;

            }

            textBox43.Text = javi.ToString();
            textBox41.Text = jul.ToString();
            textBox39.Text = mar.ToString();
            textBox37.Text = fab.ToString();
            textBox35.Text = esc.ToString();
            textBox33.Text = ric.ToString();
            //textBox31.Text = artes.ToString();


        }
    }
}
