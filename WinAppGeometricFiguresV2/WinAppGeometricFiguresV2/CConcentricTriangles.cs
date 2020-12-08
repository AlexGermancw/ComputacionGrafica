using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricFiguresV2
{
    class CConcentricTriangles
    {
        // Datos miembro - Atributos.
        private int maxX, maxY, minMaxXY, xCenter, yCenter;
        private Rectangle d;

        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;
        private PointF mP1, mP2, mP3;

        // Funciones miembro - Métodos.

        // Constructor sin parámetros.
        public CConcentricTriangles()
        {            
            
        }

        public void InitializeData(PictureBox picCanvas)
        {
            picCanvas.Refresh();

            d = new Rectangle();
            d.X = picCanvas.Width;
            d.Y = picCanvas.Height;

            maxX = d.X - 1; maxY = d.Y - 1;
            //maxX = 800 - 1; maxY = 600 - 1;
            minMaxXY = Math.Min(maxX, maxY);
            xCenter = maxX / 2; yCenter = maxY / 2;            
        }

        private int iX(float x) 
        { 
            return ((int)Math.Round(x)); 
        }

        private int iY(float y)
        {
            return (maxY - (int)Math.Round(y));
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 1);          

            InitializeData(picCanvas);

            float side = 0.95f * minMaxXY;
            float sideHalf = 0.5f * side;
            float h = sideHalf * (float)Math.Sqrt(3);
            float xA, yA, xB, yB, xC, yC;
            float xA1, yA1, xB1, yB1, xC1, yC1;
            float p, q;

            q = 0.05f;
            p = 1 - q;
            xA = xCenter - sideHalf;
            yA = yCenter - 0.5f * h;
            xB = xCenter + sideHalf;
            yB = yA;
            xC = xCenter;
            yC = yCenter + 0.5f * h;

            for (int i = 0; i < 50; i++)
            {
                mGraph.DrawLine(mPen, iX(xA), iY(yA), iX(xB), iY(yB));
                mGraph.DrawLine(mPen, iX(xB), iY(yB), iX(xC), iY(yC));
                mGraph.DrawLine(mPen, iX(xC), iY(yC), iX(xA), iY(yA));
                xA1 = p * xA + q * xB;
                yA1 = p * yA + q * yB;
                xB1 = p * xB + q * xC;
                yB1 = p * yB + q * yC;
                xC1 = p * xC + q * xA;
                yC1 = p * yC + q * yA;
                xA = xA1; xB = xB1; xC = xC1;
                yA = yA1; yB = yB1; yC = yC1;
            }

        }

    }
}
