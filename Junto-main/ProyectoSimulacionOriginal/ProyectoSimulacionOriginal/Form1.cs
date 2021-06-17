using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSimulacionOriginal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables para volados y generador de numeros pseudoalatorios
        
        public static double a;
        public static double c;
        public static double Xo;
        public static double M;
        double n, modulo, m = 0, acumulador = 0, promedio, Zo;
        double[] random = new double[100000];
        int ad;

        private void btnPi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pi p = new Pi();
            p.tbA3.Text = tbA.Text;
            p.tbC3.Text = tbC.Text;
            p.tbM3.Text = tbM.Text;
            p.tbXo3.Text = tbXo.Text;
            p.tbn3.Text = tbn.Text;
            p.Show();
        }

        private void tbA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras.");
            }
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios.");
            }
        }

        private void tbC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras.");
            }
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios.");
            }
        }

        private void tbXo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras.");
            }
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PruebaPromedios pp = new PruebaPromedios();
            pp.Show();
        }

        private void PDistancia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pdistancia pd = new Pdistancia();
            pd.tbA2.Text = tbA.Text;
            pd.tbC2.Text = tbC.Text;
            pd.tbM2.Text = tbM.Text;
            pd.tbXo2.Text = tbXo.Text;
            pd.tbn2.Text = tbn.Text;
            pd.nn.Text = tbn.Text;
            pd.Show();
        }

        private void tbM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras.");
            }
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios.");
            }
        }

        private void tbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras.");
            }
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios.");
            }
        }

        private void btnTinas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tinas t = new Tinas();
            t.Show();
        }

        
        
        private void btnNoPseudoalatorio_Click(object sender, EventArgs e)
        {
            if (tbA.Text == "" || tbC.Text == "" || tbXo.Text == "" || tbM.Text == ""|| tbn.Text == "")
            {
                MessageBox.Show("Revise que llenara los campos necesarios");
            }
            double.TryParse(tbA.Text, out a);
            double.TryParse(tbC.Text, out c);
            double.TryParse(tbXo.Text, out Xo);
            double.TryParse(tbM.Text, out M);
            double.TryParse(tbn.Text, out n);
            //generar numeros 
            for (int i = 0; i < n; i++)
            {
                modulo = (a * Xo + c) % M;
                random[i] = modulo / M;
                double redoneado = (Math.Round(random[i], 5));
                ad = dataGridView1.Rows.Add();
                dataGridView1.Rows[ad].Cells[0].Value = (i + 1).ToString();
                dataGridView1.Rows[ad].Cells[1].Value = redoneado.ToString();

                acumulador += random[i];

                m = modulo;
                Xo = m;


            }

            //obtenemos el promedio de los números pseodoaleatorios
            promedio = acumulador / n;
            lblpromedio.Text = (Math.Round(promedio, 5)).ToString();

            //obtenemos la distribución normal
            Zo = ((Math.Sqrt(n)) * (promedio - 0.5)) / (Math.Sqrt(0.083333333));
            lbldisnor2.Text = (Math.Round(Zo, 5)).ToString();


        }

        
        private void btnV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Volados v = new Volados();
            v.tbA4.Text = tbA.Text;
            v.tbC4.Text = tbC.Text;
            v.tbM4.Text = tbM.Text;
            v.tbXo4.Text = tbXo.Text;
            v.tbn4.Text = tbn.Text;
            v.Show();
        }
    }
}
