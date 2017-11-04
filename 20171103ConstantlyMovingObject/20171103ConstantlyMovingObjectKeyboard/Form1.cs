using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171103ConstantlyMovingObjectKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            topBoundary = 4;
            rightBoundary = 550;
            leftBoundary = 4;
            bottomBoundary = this.Bottom;
            timer1.Enabled = true;
        }

        int x, y, rightBoundary, topBoundary, leftBoundary, bottomBoundary;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                x = -1;
                y = -1;
            }
            else if (e.KeyCode == Keys.E)
            {
                x = 1;
                y = -1;
            }
            else if (e.KeyCode == Keys.C)
            {
                x = 1;
                y = 1;
            }
            else if (e.KeyCode == Keys.Z)
            {
                x = -1;
                y = 1;
            }
            else if (e.KeyCode == Keys.W)
            {
                y = -1;
                x = 0;
            }
            else if (e.KeyCode == Keys.S)
            {
                y = 1;
                x = 0;
            }
            else if (e.KeyCode == Keys.A)
            {
                x = -1;
                y = 0;
            }
            else if (e.KeyCode == Keys.D)
            {
                x = 1;
                y = 0;
            }

        }

        private void DirectionChoose(int a, int b)
        {
            //if button's right side is arrived to panel's right side
            //and the movement comes for going right again stop the movement.
            if (btnMovingObject.Right == rightBoundary && x > 0)
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

            btnMovingObject.Location = new Point(btnMovingObject.Location.X + a, btnMovingObject.Location.Y + b);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
