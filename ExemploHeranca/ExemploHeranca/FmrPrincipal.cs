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
    public partial class FmrPrincipal : Form
    {
        public FmrPrincipal()
        {
            InitializeComponent();
        }

        private void adcionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdicionaProduto addProd = new FrmAdicionaProduto();
            addProd.MdiParent = this;
            addProd.WindowState = FormWindowState.Maximized;
            addProd.Show();
        }
    }
}
