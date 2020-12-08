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
    public partial class frmTriangle : Form
    {
        private CTriangle ObjCTriangle = new CTriangle();

        public frmTriangle()
        {
            InitializeComponent();
            ObjCTriangle.InitializeData(txtSideA, txtSideB, txtSideC,
                                        txtPerimeter, txtArea, picCanvas);
        }

        private void frmTriangle_Load(object sender, EventArgs e)
        {
            ObjCTriangle.InitializeData(txtSideA, txtSideB, txtSideC,
                                        txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool Validate;

            ObjCTriangle.ReadData(txtSideA, txtSideB, txtSideC);
            Validate = ObjCTriangle.CheckTriangle();

            if(Validate == true)
            {
                ObjCTriangle.PerimeterTriangle();
                ObjCTriangle.AreaTriangle();
                ObjCTriangle.PrintData(txtPerimeter, txtArea);
                ObjCTriangle.GraphShape(picCanvas);
            }
            else // !(Validate == true)
            {
                MessageBox.Show("Error...en el ingreso de datos", 
                                "Mensaje de error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCTriangle.InitializeData(txtSideA, txtSideB, txtSideC,
                                        txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjCTriangle.CloseForm(this);
            //Close();
        }
    }
}
