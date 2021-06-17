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
    public partial class Pi : Form
    {
        //variables Pi
        int contadorX = 0;
        int corridas, add;

        public static double a;
        public static double c;
        public static double Xo;
        public static double M;
        double n, modulo, m = 0;
        int ad;

        double[] random = new double[100000];
        public Pi()
        {
            InitializeComponent();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            //obtención de los números pseudoaleatorios
            {
                //optención de valores para las variables
                double.TryParse(tbA3.Text, out a);
                double.TryParse(tbC3.Text, out c);
                double.TryParse(tbXo3.Text, out Xo);
                double.TryParse(tbM3.Text, out M);
                double.TryParse(tbn3.Text, out n);



               
                //generar numeros 
                for (int i = 0; i < n; i++)
                {
                    modulo = (a * Xo + c) % M;
                    random[i] = modulo / M;
                    double redoneado = (Math.Round(random[i], 5));
                    ad = dataGridView3.Rows.Add();
                    dataGridView3.Rows[ad].Cells[0].Value = (i + 1).ToString();
                    dataGridView3.Rows[ad].Cells[1].Value = redoneado.ToString();

                    //nps[i] = redoneado;
                    //dataGridView3.Rows[ad].Cells[1].Value = redoneado.ToString();
                    m = modulo;
                    Xo = m;
                }
            }
            try
            {
                if (txtNoCorridas.TextLength == 0)
                {
                    MessageBox.Show("Debes rellenar el campo del número de corridas"); ;
                }
                else
                {
                    if ((double.Parse(tbn3.Text) / 2) < double.Parse(txtNoCorridas.Text))
                    {
                        MessageBox.Show("La cantidad de números pseudoaleatorios deben ser el doble de las corridas");
                    }
                    else
                    {
                        contadorX = 0;
                        corridas = 0; add = 0;
                        dataGridViewPi.Rows.Clear();
                        CalcularPi();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Asegúrate de haber generado los números pseudoaleaotios");
            }

        }

        private void btnLimites_Click(object sender, EventArgs e)
        {

            if (txtTolerancia.TextLength == 0)
            {
                MessageBox.Show("Rellena el campo de tolerancia");
            }
            else
            {
                //limite inf y sup
                double valorPi = Math.PI;
                labelPi.Text = valorPi.ToString();
                double toleranciaPi = valorPi * (double.Parse(txtTolerancia.Text) / 100);
                double limInfPi = Math.Round((valorPi - toleranciaPi), 4);
                double limSupPi = Math.Round((valorPi + toleranciaPi), 4);
                txtLimInfPi.Text = limInfPi.ToString();
                txtLimSupPi.Text = limSupPi.ToString();

                double piAproximado = (4 * contadorX) / double.Parse(txtNoCorridas.Text);
                txtPiAprox.Text = piAproximado.ToString();

                if (piAproximado >= limInfPi && piAproximado <= limSupPi)
                {
                    label16.Text = piAproximado.ToString() + " sí aceptado";
                }
                else
                {
                    label16.Text = piAproximado.ToString() + " no aceptado";
                }
            }
        }

        public void CalcularPi()
        {

            int.TryParse(txtNoCorridas.Text, out corridas);
            int j = corridas;
            int c = 0;
            for (int i = 0; i < corridas; i++)
            {
                add = dataGridViewPi.Rows.Add();
                dataGridViewPi.Rows[add].Cells[0].Value = i + 1;
                dataGridViewPi.Rows[add].Cells[1].Value = dataGridView3.Rows[i].Cells[1].Value;

            }
            for (int k = corridas; k < (corridas * 2); k++)
            {
                dataGridViewPi.Rows[c].Cells[2].Value = dataGridView3.Rows[j].Cells[1].Value;
                c++;
                j++;
            }

            for (int i = 0; i < corridas; i++)
            {
                double R1 = double.Parse(dataGridViewPi.Rows[i].Cells[1].Value.ToString());
                double R2 = double.Parse(dataGridViewPi.Rows[i].Cells[2].Value.ToString());
                double pi = Math.Sqrt(Math.Pow(R1, 2) + Math.Pow(R2, 2));
                dataGridViewPi.Rows[i].Cells[3].Value = pi.ToString();

                if (pi <= 1)
                {
                    dataGridViewPi.Rows[i].Cells[4].Value = "Sí";
                    contadorX++;
                }
                else
                {
                    dataGridViewPi.Rows[i].Cells[4].Value = "No";

                }

                dataGridViewPi.Rows[i].Cells[5].Value = contadorX;
            }
            txtValorAcumulado.Text = contadorX.ToString();
        }
    }
}
