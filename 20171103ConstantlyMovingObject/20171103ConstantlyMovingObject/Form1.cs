using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171103ConstantlyMovingObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //x and y are coordinates, and others will keep the boundaries of panel.
        int x, y,rightBoundary,topBoundary,leftBoundary,bottomBoundary;


        //Click events for the buttons on screen to operate movement to given direction....
        private void btnEast_Click(object sender, EventArgs e)
        {
            x = 1;
            y = 0;
        }
        private void btnSouth_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 1;
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            x = -1;
            y = 0;
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            x = 0;
            y = -1;
        }

        private void btnNorthEast_Click(object sender, EventArgs e)
        {
            x = 1;
            y = -1;
        }

        private void btnSouthEast_Click(object sender, EventArgs e)
        {
            x = 1;
            y = 1;
        }

        private void btnSouthWest_Click(object sender, EventArgs e)
        {
            x = -1;
            y = 1;
        }

        private void btnNorthWest_Click(object sender, EventArgs e)
        {
            x = -1;
            y = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Boundaries which are taken from panel's top,bottom,right and left......
            topBoundary = panel1.Top;
            rightBoundary = panel1.Right-12;
            leftBoundary = panel1.Left;
            bottomBoundary = panel1.Bottom-12;
            //start the timer so the tick method can operate......
            timer1.Enabled = true;
        }

        private void DirectionChoose(int a,int b)
        {
            //if button's right side is arrived to panel's right side
            //and the movement comes for going right again stop the movement.
            if (btnMovingObject.Right == rightBoundary && x>0)
            {
                x = 0;
            }
            //if button's top is arrived to panel's top
            //and the movement comes for going up again stop the movement.
            else if (btnMovingObject.Top == topBoundary && y < 0)
            {
                y = 0;
            }
            //if button's left side is arrived to panel's left side
            //and the movement comes for going left again stop the movement.
            else if (btnMovingObject.Left == leftBoundary && x < 0)
            {
                x = 0;
            }
            //if button's bottom is arrived to panel's bottom
            //and the movement comes for going down again stop the movement.
            else if (btnMovingObject.Bottom == bottomBoundary && y > 0)
            {
                y = 0;
            }

            ReverseDirection();
            //assign the new location point for the button...
            btnMovingObject.Location = new Point(btnMovingObject.Location.X+a, btnMovingObject.Location.Y+b);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Operate the movement method once in a Tick(depends on the interval of timer.)...
            DirectionChoose(x, y);
        }

        private void ReverseDirection()
        {
            //if button's right side is arrived to panel's right side
            //and the movement comes for going right again stop the movement.
            if (btnMovingObject.Right > rightBoundary && x > 0)
            {
                x = -1;
                MessageBox.Show("Bu yönde gidecek alan kalmadı!!!");
            }
            //if button's top is arrived to panel's top
            //and the movement comes for going up again stop the movement.
            if (btnMovingObject.Top < topBoundary && y < 0)
            {
                y = 1;
                MessageBox.Show("Bu yönde gidecek alan kalmadı!!!");
            }
            //if button's left side is arrived to panel's left side
            //and the movement comes for going left again stop the movement.
            if (btnMovingObject.Left < leftBoundary && x < 0)
            {
                x = 1;
                MessageBox.Show("Bu yönde gidecek alan kalmadı!!!");
            }
            //if button's bottom is arrived to panel's bottom
            //and the movement comes for going down again stop the movement.
            if (btnMovingObject.Bottom >= bottomBoundary && y > 0)
            {
                y = -1;
                MessageBox.Show("Bu yönde gidecek alan kalmadı!!!");
            }
        }
    }
}
