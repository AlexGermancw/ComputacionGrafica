using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricFigures
{
    class CCircle
    {
        //Datos miembro - Atributos.
        private float mRadius, mPerimeter, mArea; //m -> miembro
                                                  // mGraph - activar el modo grafico de Windows
        private Graphics mGraph;
        // SF - Scale Factor (Zoom-In/Zoom-Out).
        private const float SF = 20;
        // mPen - Pluma/Lapiz
        private Pen mPen;

        // Funciones miembro - Metodos.

        // Constructor por defecto
        public CCircle()
        {
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
                MessageBox.Show("Ingreso no valido...");
            }
        }
    }
}
