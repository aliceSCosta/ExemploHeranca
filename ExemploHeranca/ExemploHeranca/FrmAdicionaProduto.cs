using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploHeranca
{
    public partial class FrmAdicionaProduto : Form
    {
        public FrmAdicionaProduto()
        {
            InitializeComponent();
        }

        private void dvgCadastros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.Marca = cmbMarca.Text;
            c.Modelo = txtModelo.Text;
            c.MesesGarantia = Convert.ToInt32(nudGarantia.Value);
        }
    }
}
