/* Selena Guillen
 * User Interface Engineering Section W01
 * Simple Paint Application
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
        int shape = 0; //default shape will be "free draw"
        PointF p1;
        PointF p2;
        bool start = false;
        int x = 0;
        int y = 0;
        Graphics gp;
        Pen p = new Pen(Brushes.Black, 5.0F);

        
        public Paint()
        {
            InitializeComponent();
            gp = panel1.CreateGraphics();     
        }

        // Color Radio Buttons 
        private void BlkBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (blkBtn.Checked == true)
                p.Color = Color.Black;
        }

        private void RedBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (redBtn.Checked == true)
                p.Color = Color.Red;
        }

        private void YelBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (yelBtn.Checked == true)
                p.Color = Color.Yellow;
        }

        private void BluBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (bluBtn.Checked == true)
                p.Color = Color.Blue;
        }

        // Combobox Thickness 
        private void ThicBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (thicBox.SelectedIndex == 0)
            {
                p.Width = 0.0f;
            }

            else if (thicBox.SelectedIndex == 1)
            {
                p.Width = 5.0f;
            }

            else if (thicBox.SelectedIndex == 2)
            {
                p.Width = 10.0f;
            }
        }

        // Combobox Shape 
        private void ShapeBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            switch (shapeBox.SelectedIndex)
            {
                case 0:
                    //Free Draw
                    shape = 0;
                    break;
                case 1:
                    //Line
                    shape = 1;
                    break;
                case 2:
                    //Rectangle
                    shape = 2;
                    break;
                case 3:
                    //Oval
                    shape = 3;
                    break;
                default:
                    //Free Draw
                    shape = 0;
                    break;
            }
        }

        // CLEAR button
        private void ClrBtn_Click(object sender, EventArgs e)
        {
            // this clears all graphics from the panel/canvas
            panel1.Invalidate();
        }


        // Three methods that allow mouse to move
        public void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (shape)
            {
                case 0:
                    //Free Draw
                    start = false;
                    x = 0;
                    y = 0;
                    break;
                case 1:
                    //Line
                    start = false;
                    PointF p2Temp = new PointF(e.X, e.Y); //gets the coordinates of the point where the mouse releases
                    p2 = p2Temp; //sets that value equal to global variable p1
                    break;
                case 2:
                    //Rectangle
                    start = false;
                    break;
                case 3:
                    //Oval
                    start = false;
                    break;
                default:
                    //Free Draw
                    shape = 0;
                    break;
            }

        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            switch (shape)
            {
                // free draw with eraser on right click hold
                case 0:
                    if (e.Button == MouseButtons.Left)
                    {
                        //if holding mouse down
                        if (start)
                        {
                            if (x > 0 && y > 0)
                            {
                                gp.DrawLine(p, x, y, e.X, e.Y);
                            }

                            x = e.X; //sets x = mouse x coordinate
                            y = e.Y; //sets y = mouse y coordinate
                        }
                    }

                    // eraser 
                    else if (e.Button == MouseButtons.Right)
                    {
                        if (start)
                        {
                            if (x > 0 && y > 0)
                            {
                                p.Color = Color.White;
                                p.Width = 20.0f;
                                gp.DrawLine(p, x, y, e.X, e.Y);
                            }

                            x = e.X;
                            y = e.Y;
                        }
                    }
                    break;
                case 1:
                    //Line or Curve?
                    
                    if (e.Button == MouseButtons.Left)
                    {
                        //if holding mouse down
                        if (start == true)
                        {
                            gp.DrawLine(p, p1, p2);            
                        }
                    }

                    else if (e.Button == MouseButtons.Right)
                    {
                        PointF[] temp = new PointF[2];
                        temp[0] = p1;
                        temp[1] = p2;
                        /* Still need to update */
                        if (start == true)
                        {
                            gp.DrawCurve(p, temp);
                        }
                    }
                    break;
                case 2:
                    //Rectangle
                    // could potentially use for scaling w/ mouse
                    
                    break;
                case 3:
                    //Oval
                    //save for scaling
                    break;
                default:
                    shape = 0;
                    break;
            }
            
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (shape)
            {
                case 0:
                    //Free Draw
                    start = true;
                    break;
                case 1:
                    //Line
                    start = true;
                    PointF p1Temp = new PointF(e.X, e.Y); //gets the coordinates of the point where the mouse clicks
                    p1 = p1Temp; //sets that value equal to global variable p1 
                    break;
                case 2:
                    //Rectangle
                    if (e.Button == MouseButtons.Left)
                    {
                        start = true;
                        Point rect_point = new Point(e.X, e.Y);
                        Size rect_size = new Size(100, 50);
                        Rectangle rect = new Rectangle(rect_point, rect_size);
                        if (start)
                        {
                            gp.DrawRectangle(p, rect);

                        }
                    }

                    if (e.Button == MouseButtons.Right)
                    {
                        start = true;
                        Point rect_point = new Point(e.X, e.Y);
                        Size rect_size = new Size(100, 50);
                        Rectangle rect = new Rectangle(rect_point, rect_size);

                        Color c = p.Color; //Color.Black
                        SolidBrush fill_color = new SolidBrush(c);

                        gp.FillRectangle(fill_color, rect);
                        if (start)
                        {
                            gp.DrawRectangle(p, rect);

                        }
                    }
                    break;
                case 3:
                    //Oval
                    if (e.Button == MouseButtons.Left)
                    {
                        start = true;
                        Point rect_point = new Point(e.X, e.Y);
                        Size rect_size = new Size(100, 50);
                        Rectangle rect = new Rectangle(rect_point, rect_size);
                        if (start)
                        {
                            gp.DrawEllipse(p, rect);
                        }
                    }

                    if (e.Button == MouseButtons.Right)
                    {
                        start = true;
                        Point rect_point = new Point(e.X, e.Y);
                        Size rect_size = new Size(100, 50);
                        Rectangle rect = new Rectangle(rect_point, rect_size);

                        Color c = p.Color; //Color.Black
                        SolidBrush fill_color = new SolidBrush(c);

                        gp.FillEllipse(fill_color, rect);
                        if (start)
                        {
                            gp.DrawEllipse(p, rect);

                        }
                    }
                    break;
                default:
                    //Free Draw
                    shape = 0;
                    break;
            }    
        }

        private void Panel1_Click(object sender, EventArgs e)
        {

        }

    }
}

