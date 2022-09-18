using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
