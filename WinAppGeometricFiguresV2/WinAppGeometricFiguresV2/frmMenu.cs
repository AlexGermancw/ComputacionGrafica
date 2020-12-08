using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppGeometricFiguresV2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            frmCircle ObjForm = new frmCircle();
            ObjForm.Show();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            frmSquare ObjForm = new frmSquare();
            ObjForm.Show();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            frmRectangle ObjForm = new frmRectangle();
            ObjForm.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            frmTriangle ObjForm = new frmTriangle();
            ObjForm.Show();
        }
        
        private void btnConcentricTriangles_Click(object sender, EventArgs e)
        {
            frmConcentricTriangles ObjForm = new frmConcentricTriangles();
            ObjForm.Show();
        }

        private void btnHexagon_Click(object sender, EventArgs e)
        {
            frmHexagon ObjForm = new frmHexagon();
            ObjForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
