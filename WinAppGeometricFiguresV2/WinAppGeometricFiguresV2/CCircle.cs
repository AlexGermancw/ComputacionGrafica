using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricFiguresV2
{
    class CCircle
    {
        // Datos miembro - Atributos.
        private float mRadius, mPerimeter, mArea;

        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        // Funciones miembro - Métodos.

        // Constructor sin parámetros.
        public CCircle()
        {
            //this.mRadius = 0.0f; this.mPerimeter = 0.0f; this.mArea = 0.0f;
            mRadius = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }
        }

        public void PerimeterCircle()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        public void AreaCircle()
        {
            // mArea = (float)Math.PI * mRadius * mRadius;
            mArea = (float)Math.PI * (float)Math.Pow(mRadius, 2);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtRadius,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            txtRadius.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            // Mantiene el cursor titilando en una caja de texto.
            txtRadius.Focus();

            mRadius = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;

            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            // Graficar un círculo en base a una elipse.
            mGraph.DrawEllipse(mPen, 0, 0, 2 * mRadius * SF, 2 * mRadius * SF);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
