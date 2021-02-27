using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ursu.Andrii._4J.FigureGeometriche
{
    public partial class Form1 : Form
    {

        const int LATO_X = 200;
        const int LATO_Y = 300;

        const int MARGINE_SINISTRO = 100;
        const int MARGINE_DESTRO = 100;
        const int MARGINE_SUPERIORE = 100;
        const int MARGINE_INFERIORE = 100;

        //cont int K_CORNICE = 10;
        const int LATO_X_FORM = (MARGINE_SINISTRO + LATO_X + MARGINE_DESTRO);// K_CORNICE / 10;
        const int LATO_Y_FORM = (MARGINE_SUPERIORE + LATO_Y + MARGINE_INFERIORE);// K_CORNICE / 10;

        Pen BluePen = new Pen(Color.Blue);


        public Form1()
        {
            InitializeComponent();

            this.MinimumSize = new Size(LATO_X_FORM, LATO_Y_FORM);
            this.MaximumSize = new Size(LATO_X_FORM, LATO_Y_FORM);

            //Graphics dc = this.CreateGraphics();
            //this.Show();

            //linea diagonale per vedere lo spazio attorno al foglio 
            //dc.DrawLine(BluePen, 0, 0, LATO_X_FORM, LATO_Y_FORM);

            //disegno il riquadro del foglio
            //dc.DrawRectangle/BluePen

           
        }
        private int X(double x)
        {
            int xLogico = 0;
            xLogico = (int)(x * 10) + MARGINE_SINISTRO;
            return xLogico;
        }

        private int Y(double y)
        {
            int yLogico = 0;
            yLogico = (MARGINE_SUPERIORE + LATO_Y - (int)(y*10));
            return yLogico;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen BluePen = new Pen(Color.Blue, 1);
            Pen RedPen = new Pen(Color.Red, 1);

            dc.DrawRectangle(BluePen, MARGINE_SINISTRO + 0, MARGINE_SUPERIORE + 0, LATO_X, LATO_Y);


            dc.DrawLine(BluePen, X(4), Y(10), X(10), Y(20.5));
            dc.DrawLine(BluePen, X(10), Y(20.5), X(16), Y(10));
            dc.DrawLine(BluePen, X(16), Y(10), X(4), Y(10));
        }
    }
}
