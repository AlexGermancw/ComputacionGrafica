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
    public partial class frmCircle : Form
    {
        private CCircle ObjCCircle = new CCircle();

        public frmCircle()
        {
            InitializeComponent();
            ObjCCircle.InitializeData(txtRadius, txtPerimeter,
                                      txtArea, picCanvas);
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {
            ObjCCircle.InitializeData(txtRadius, txtPerimeter,
                                      txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCCircle.ReadData(txtRadius);
            ObjCCircle.PerimeterCircle();
            ObjCCircle.AreaCircle();
            ObjCCircle.PrintData(txtPerimeter, txtArea);
            ObjCCircle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCCircle.InitializeData(txtRadius, txtPerimeter,
                                      txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // El objoeto this (puntero this) tiene la referencia actua del
            // objeto con el cual se esta trabajando.
            ObjCCircle.CloseForm(this);
            //Close();
        }
    }
}
