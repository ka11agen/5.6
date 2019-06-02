using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        private Point _targetPosition;
        private Point _targetPosition1;
        private Point _targetPosition2;
        private Point _targetPosition3;
        private Point _targetPosition4;
        private Point _targetPosition5;
        private Point _targetPosition6;
        private Point _targetPosition7;
        private Point _targetPosition8;
        private Point _direction;
        SolidBrush brush;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            UpdateStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _targetPosition.X = 250;
            _targetPosition.Y = 250;
            _targetPosition.X = 250;
            _targetPosition.Y = 250;
            _targetPosition1.X = 240;
            _targetPosition1.Y = 250;
            _targetPosition2.X = 230;
            _targetPosition2.Y = 250;
            _targetPosition3.X = 220;
            _targetPosition3.Y = 250;
            _targetPosition4.X = 210;
            _targetPosition4.Y = 250;
            _targetPosition5.X = 200;
            _targetPosition5.Y = 250;
            _targetPosition6.X = 190;
            _targetPosition6.Y = 250;
            _targetPosition7.X = 180;
            _targetPosition7.Y = 250;
            _targetPosition7.X = 170;
            _targetPosition7.Y = 250;
            brush = new SolidBrush(Color.Black);
            _direction.X = 5;
            _direction.Y = 3;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            _targetPosition.X += _direction.X;
            _targetPosition.Y += _direction.Y;
            if (_targetPosition.X < 0 || _targetPosition.X > 800)
            {
                _direction.X *= -1;
            }
            if (_targetPosition.Y < 0 || _targetPosition.Y > 400)
            {
                _direction.Y *= -1;
            }

            var TargetRect = new Rectangle(_targetPosition.X, _targetPosition.Y, 10, 10);
            var TargetRect1 = new Rectangle(_targetPosition1.X, _targetPosition1.Y, 10, 10);
            var TargetRect2 = new Rectangle(_targetPosition2.X, _targetPosition2.Y, 10, 10);
            var TargetRect3 = new Rectangle(_targetPosition3.X, _targetPosition3.Y, 10, 10);
            var TargetRect4 = new Rectangle(_targetPosition4.X, _targetPosition4.Y, 10, 10);
            var TargetRect5 = new Rectangle(_targetPosition5.X, _targetPosition5.Y, 10, 10);
            var TargetRect6 = new Rectangle(_targetPosition6.X, _targetPosition6.Y, 10, 10);
            var TargetRect7 = new Rectangle(_targetPosition7.X, _targetPosition7.Y, 10, 10);
            var TargetRect8 = new Rectangle(_targetPosition8.X, _targetPosition8.Y, 10, 10);

            g.FillRectangle(brush, TargetRect);
            g.FillRectangle(brush, TargetRect1);
            g.FillRectangle(brush, TargetRect2);
            g.FillRectangle(brush, TargetRect3);
            g.FillRectangle(brush, TargetRect4);
            g.FillRectangle(brush, TargetRect5);
            g.FillRectangle(brush, TargetRect6);
            g.FillRectangle(brush, TargetRect7);
            g.FillRectangle(brush, TargetRect8);
            /*g.FillRectangle(brush, 100, 100, 10, 10);
            g.FillRectangle(brush, 100, 400, 10, 10);
            g.FillRectangle(brush, 400, 100, 10, 10);
            g.FillRectangle(brush, 400, 400, 10, 10);*/
            _targetPosition8.X = _targetPosition7.X;
            _targetPosition8.Y = _targetPosition7.Y;
            _targetPosition7.X = _targetPosition6.X;
            _targetPosition7.Y = _targetPosition6.Y;
            _targetPosition6.X = _targetPosition5.X;
            _targetPosition6.Y = _targetPosition5.Y;
            _targetPosition5.X = _targetPosition4.X;
            _targetPosition5.Y = _targetPosition4.Y;
            _targetPosition4.X = _targetPosition3.X;
            _targetPosition4.Y = _targetPosition3.Y;
            _targetPosition3.X = _targetPosition2.X;
            _targetPosition3.Y = _targetPosition2.Y;
            _targetPosition2.X = _targetPosition1.X;
            _targetPosition2.Y = _targetPosition1.Y;
            _targetPosition1.X = _targetPosition.X;
            _targetPosition1.Y = _targetPosition.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*Random r = new Random();
            _direction.X = 5;
            _direction.Y = 1;
            /*int numcolor = r.Next(2);
            int x = 5;
            switch (numcolor)
            {
                case 0:
                    x = 5; break;

                case 1:
                    x = -5; break;
            }
            int y = 5;
            numcolor = r.Next(2);
            switch (numcolor)
            {
                case 0:
                    y = 5; break;

                case 1:
                    y = -5; break;
            }

            _direction.X = x;
            _direction.Y = y;*/
        }
    }
}
