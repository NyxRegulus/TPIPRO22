using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Consultas : Form
    {
        private SQLControl oConexion;
    
        public Consultas()
        {
            InitializeComponent();
            oConexion= new SQLControl();
            
            Habilitar(true);
        }
        public void Habilitar(bool v)
        {
            lbConsulta1.Visible = !v;
            lbConsulta2.Visible = !v;
            lbConsulta3.Visible = !v;
            lbConsulta4.Visible = !v;
            lbConsulta5.Visible = !v;
            lbConsulta6.Visible = !v;
            lbConsulta7.Visible = !v;
            lbConsulta8.Visible = !v;
            lbConsulta9.Visible = !v;

        }
        public void Limpiar() 
        {
            lbConsulta1.Hide();
            lbConsulta2.Hide();
            lbConsulta3.Hide();
            lbConsulta4.Hide();
            lbConsulta5.Hide();
            lbConsulta6.Hide();
            lbConsulta7.Hide();
            lbConsulta8.Hide();
            lbConsulta9.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //consulta 1
            Limpiar();
            lbConsulta1.Show();
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
          
        }

        private void label8_Click(object sender, EventArgs e)
        {
          
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta2.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta3.Show();
            oConexion = new SQLControl();
            DataTable tabla = oConexion.ConsultarSQL("aca va la consulta");
            dgvConsulta.DataSource = tabla;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta6.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta7.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta8.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta9.Show();
        }
    }
}
