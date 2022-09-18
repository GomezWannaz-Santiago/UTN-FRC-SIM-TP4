using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.LogicaDeNegocio;

namespace WindowsFormsApp1
{
    public partial class DuracionProyecto : Form
    {
        public DuracionProyecto()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {                
                if (txtCantidadVueltas.Text == "")
                {
                    throw new Exception("Ingrese la cantidad de simulaciones");
                }
                else if (int.Parse(txtCantidadVueltas.Text) < 0)
                {
                    throw new Exception("Ingrese un valor valido mayor a 0");
                }

                Proyecto proyecto = new Proyecto();

                gridTiempos.Rows.Clear();
                graficoLineas.Series.Clear();                
                graficoLineas.Series.Add("Valores");
                graficoLineas.Series[0].ChartType = SeriesChartType.Line;

                var resultado = proyecto.Simulacion(int.Parse(txtCantidadVueltas.Text), gridTiempos, graficoLineas);

                txtTiempoMaximo.Text = resultado[0].ToString();
                txtTiempoMinimo.Text = resultado[1].ToString();
                txtPromedio.Text = resultado[2].ToString();
                txtPromedio45.Text = resultado[3].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
