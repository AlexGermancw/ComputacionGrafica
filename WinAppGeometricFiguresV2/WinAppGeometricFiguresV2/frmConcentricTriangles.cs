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
    public partial class frmConcentricTriangles : Form
    {
        CConcentricTriangles ObjCConcentricTriangles = new CConcentricTriangles();
        public frmConcentricTriangles()
        {
            InitializeComponent();            
        }

        private void frmConcentricTriangles_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPlotShape_Click(object sender, EventArgs e)
        {            
            ObjCConcentricTriangles.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
