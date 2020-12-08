using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricFiguresV2
{
    class CTriangle
    {
        // Datos miembro - Atributos.
        private float mA, mB, mC;
        private float mPerimeter, mArea;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mP1, mP2, mP3;
        private float mAngleA;

        // Funciones miembro - Métodos.

        // Constructor sin parámetros.
        public CTriangle()
        {
            mA = 0.0f; mB = 0.0f; mC = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que permite leer los tres lados del triángulo.
        public void ReadData(TextBox txtSideA,
                             TextBox txtSideB,
                             TextBox txtSideC)
        {
            try
            {
                mA = float.Parse(txtSideA.Text);
                mB = float.Parse(txtSideB.Text);
                mC = float.Parse(txtSideC.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }            
        }

        // Función que permite calcular el semi-perímetro del triángulo.
        private float SemiperimeterTriangle()
        {
            return ((mA + mB + mC) / 2);
        }

        // Función que permite calcular el perímetro del triángulo.
        public void PerimeterTriangle()
        {
            float s = SemiperimeterTriangle();
            mPerimeter = 2 * s;
        }

        // Función que permite calcular el área del triángulo.
        public void AreaTriangle()
        {
            float s = SemiperimeterTriangle();
            mArea = (float)Math.Sqrt(s * (s - mA) * (s - mB) * (s - mC));
        }

        // Función que permite imprimir el perímetro y el área del triángulo.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que permite inicializar los datos y controles que operan en 
        // la GUI del triángulo.
        public void InitializeData(TextBox txtSideA,
                                   TextBox txtSideB,
                                   TextBox txtSideC,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            txtSideA.Text = ""; txtSideB.Text = ""; txtSideC.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            // Mantiene el cursor titilando en una caja de texto.
            txtSideA.Focus();
            mA = 0.0f; mB = 0.0f; mC = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            picCanvas.Refresh();
        }

        // Función que permite validar la existencia de un triángulo.
        public bool CheckTriangle()
        {
            if ((mA + mB > mC) && (mA + mC > mB) && (mB + mC > mA))
            {
                return (true);
            }
            else // !((mA + mB > mC) && (mA + mC > mB) && (mB + mC > mA))
                return (false);
        }

        // Función que permite calcular el ángulo A del triángulo, utilizando 
        // la Ley de Cosenos.
        private void CalculateAngleA()
        {
            mAngleA = (float)Math.Acos((mB * mB + mC * mC - mA * mA) / (2 * mB * mC));
        }

        // Función que permite calcular los valores de los tres vértices del triángulo,
        // utilizando fórmulas de Geometría Analítica.
        private void CalculateVertexC()
        {
            mP1.X = 0.0f; mP1.Y = 0.0f;
            mP2.X = mC; mP2.Y = 0.0f;

            CalculateAngleA();

            mP3.X = mB * (float)Math.Cos(mAngleA);
            mP3.Y = mB * (float)Math.Sin(mAngleA);
        }

        // Función que permite graficar un triángulo en base a los valores de los tres 
        // vértices representados por tres puntos en un plano.
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            CalculateVertexC();

            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
