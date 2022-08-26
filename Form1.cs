using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRN3_U2_EA_JHRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Prueba de conexión
            Conexion q1 = new Conexion();
            q1.conectar();
            q1.desconectar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c.Curp = cmpCurp.Text;
                c.Nombre = cmpNombre.Text;
                c.Apellido_paterno = cmpApellidoPaterno.Text;
                c.Apellido_materno = cmpApellidoMaterno.Text;
                //Si el RadioButton es hombre o mujer
                if (cmpMujer.Checked)
                    { c.Sexo = "Mujer"; }
                else if (cmpHombre.Checked)
                { c.Sexo = "Hombre"; }
                c.Persona = cmpPersona.Text;
                c.Calle = cmpCalle.Text;
                c.Num_ext = cmpNumExt.Text;
                c.Num_int = cmpNumInt.Text;
                c.Cp = Convert.ToInt32(cmpCp.Text);
                c.Ciudad = cmpCiudad.Text;
                c.Estado = cmpEstado.Text;



                if (AccesoDatosCliente.guardar(c))
                {
                    MessageBox.Show("Cliente se guardó");
                }
                else
                {
                    MessageBox.Show("Cliente no se guardó");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
 }

