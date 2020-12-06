using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppGeometricFigures
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            frmCircle ObjForm = new frmCircle();
            ObjForm.Show();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            frmRetangle ObjForm = new frmRetangle();
            ObjForm.Show();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            frmSquare ObjForm = new frmSquare();
            ObjForm.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            frmTriangle ObjForm = new frmTriangle();
            ObjForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
