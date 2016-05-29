using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrwingResizableRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      Rectangle areaRect = new Rectangle(100,100, 300, 300);
Boolean dragging = false;
Point ptOld = new Point(0, 0);

protected override void OnPaint(PaintEventArgs e)
{
  Graphics dcPaint = e.Graphics;
  dcPaint.DrawRectangle(rectPen, areaRect);
}

protected override void OnMouseDown(MouseEventArgs e)
{
  ptOld = new Point(e.X, e.Y);
  dragging = true;
}

protected override void OnMouseMove(MouseEventArgs e)
{
  if(dragging = true) 
  {
    Point ptNew = new Point(e.X, e.Y);
    Int32 handleSelected = GetSelectedHandle(ptNew);

   // Lets say I want to resize this rectangle using Handle 2 now.
    if(handleSelected == 2) 
    {
      // I am resizing this rectangle Width
      areaRect.X += ptNew.X - ptOld.X;
      areaRect.Width -= ptNew .X - ptOld.X;

      this.Invalidate();
    }
  }
}

protected override void OnMouseUp(MouseEventArgs e)
{
  dragging = false;
}
        }

        }
    
}
