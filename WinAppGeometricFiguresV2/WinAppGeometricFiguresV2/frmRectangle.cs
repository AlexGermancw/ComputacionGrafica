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
    public partial class frmRectangle : Form
    {
        private CRectangle ObjCRectangle = new CRectangle();

        public frmRectangle()
        {
            InitializeComponent();
            ObjCRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter,
                                         txtArea, picCanvas);
        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {
            ObjCRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter,
                                         txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCRectangle.ReadData(txtWidth, txtHeight);
            ObjCRectangle.PerimeterRectangle();
            ObjCRectangle.AreaRectangle();
            ObjCRectangle.PrintData(txtPerimeter, txtArea);
            ObjCRectangle.GraphShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter,
                                         txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjCRectangle.CloseForm(this);
        }
    }
}
