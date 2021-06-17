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
    public partial class Tinas : Form
    {
        //variables Tinas
        public static double a = 101;
        public static double c = 221;
        public static double Xo = 17;
        public static double M = 17001;
        public static int i;
        public static int b;
        public static double numerodetinas = 4;
        public static double modulo, m = 0, acumulador = 0;
        public static int ad;
        public static double[] random = new double[100000];
        public static double t1;
        public static double media;
        public static double t2;
        public static double costo_de_transporte;
        public static double peso_de_tina;
        public static double redondeado;
        public static double peso_acumulado_tinas;
        public static double numcorridas;
        public static double vecesqueserenta = 0;

        private void btngenerarT_Click(object sender, EventArgs e)
        {
            double.TryParse(txttotaldecorridas.Text, out numcorridas);
            double.TryParse(txttinasporcorrida.Text, out numerodetinas);

            for (i = 1; i <= numcorridas; i++)
            {
                peso_acumulado_tinas = 0;
                ad = dataGridView1.Rows.Add();
                dataGridView1.Rows[ad].Cells[0].Value = (i).ToString();

                for (b = 1; b <= numerodetinas; b++)
                {

                    ad = dataGridView1.Rows.Add();
                    dataGridView1.Rows[ad].Cells[1].Value = (b).ToString();
                    modulo = (a * Xo + c) % M;
                    random[b] = modulo / M;
                    double redoneado = (Math.Round(random[b], 5));
                    dataGridView1.Rows[ad].Cells[2].Value = redoneado.ToString();
                    acumulador += random[b];
                    PesoDeTina(redoneado);
                    m = modulo;
                    Xo = m;

                }
                txttotaldiasderenta.Text = numcorridas.ToString();
                Rentar();

            }
        }

        private void btnrentacamion_Click(object sender, EventArgs e)
        {

            double costoderentadecamion;
            double totaldedediasderenta;
            double vecesqueserenta;
            double costotalderenta;


            double.TryParse(txtcostoderentadecamion.Text, out costoderentadecamion);
            double.TryParse(txttotaldiasderenta.Text, out totaldedediasderenta);
            double.TryParse(txtvecesqueserenta.Text, out vecesqueserenta);
            double.TryParse(txtcostodetransporte.Text, out costo_de_transporte);

            if (totaldedediasderenta == vecesqueserenta)
            {
                costotalderenta = costo_de_transporte * totaldedediasderenta;
                txttotalderenta.Text = costotalderenta.ToString();
            }
            else
            {
                costotalderenta = costo_de_transporte * vecesqueserenta;
                txttotalderenta.Text = costotalderenta.ToString();
            }

            if (costotalderenta <= costoderentadecamion)
            {
                lbldecision.Text = "Sigue rentando camión";
            }
            else
            {
                lbldecision.Text = "Compra nuevo camión";
            }
        }

        public void PesoAcumulado()
        {
            peso_acumulado_tinas = peso_acumulado_tinas + peso_de_tina;

            dataGridView1.Rows[ad].Cells[4].Value = Math.Round(peso_acumulado_tinas, 5).ToString();

        }

        public void Rentar()
        {
            if (peso_acumulado_tinas < 1000)
            {
                dataGridView1.Rows[ad].Cells[5].Value = "Rentar";
            }
            else
            {

                dataGridView1.Rows[ad].Cells[5].Value = "No rentar";
            }
            if (dataGridView1.Rows[ad].Cells[5].Value.ToString() == "Rentar")
            {
                vecesqueserenta = vecesqueserenta + 1;
                txtvecesqueserenta.Text = vecesqueserenta.ToString();
            }

        }
        public void PesoDeTina(double redondeado)
        {
            double.TryParse(txtpesotina1.Text, out t1);
            double.TryParse(txtmedia.Text, out media);
            double.TryParse(txtpesotina2.Text, out t2);

            double basetriangulomayor;
            double baseprimertriangulomenor;
            double basesegundotriangulomenor;
            double proporciondeltrianguodebase1;
            double proporciondeltrianguodebase2;

            basetriangulomayor = (t2 - t1);
            baseprimertriangulomenor = (media - t1);
            basesegundotriangulomenor = (t2 - media);

            proporciondeltrianguodebase1 = (baseprimertriangulomenor / basetriangulomayor);
            proporciondeltrianguodebase2 = (basesegundotriangulomenor / basetriangulomayor);


            if (redondeado < proporciondeltrianguodebase1)
            {
                peso_de_tina = t1 + Math.Sqrt((t2 - t1) * (media - t1) * redondeado);
                PesoAcumulado();
                dataGridView1.Rows[ad].Cells[3].Value = Math.Round(peso_de_tina, 5).ToString();
            }
            else if (redondeado >= proporciondeltrianguodebase1)
            {
                peso_de_tina = t2 - Math.Sqrt((t2 - t1) * (t2 - media) * (1 - redondeado));
                PesoAcumulado();
                dataGridView1.Rows[ad].Cells[3].Value = Math.Round(peso_de_tina, 5).ToString();
            }
            else if (redondeado == proporciondeltrianguodebase1)
            {
                peso_de_tina = t1 + Math.Sqrt((t2 - t1) * (media - t1) * redondeado);
                peso_de_tina = t2 - Math.Sqrt((t2 - t1) * (t2 - media) * (1 - redondeado));
            }
        }

        public Tinas()
        {
            InitializeComponent();
        }
    }
}
