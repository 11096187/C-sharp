using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Overloading
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.MoveLabel(50, 50, false);
    }
    private void button2_Click(object sender, EventArgs e)
    {
      //this.SizeLabel(40, 20);
      //this.SizeLabel();
      this.SizeLabel(height: 20);
    }

    private void MoveLabel(Point location, bool Foreground)
    {
      label1.Location = location;
      if (Foreground)
        label1.BringToFront();
      else
        label1.SendToBack();
    }
    private void MoveLabel(Point location)
    {
      this.MoveLabel(location, false);
    }
    private void MoveLabel(int x, int y)
    {
      this.MoveLabel(new Point(x, y));
    }
    private void MoveLabel(int x, int y, bool Foreground)
    {
      this.MoveLabel(new Point(x, y),Foreground);
    }

    private void SizeLabel(int width=100, int height=40)
    {
      label1.Width=width;
      label1.Height = height;
    }



  }
}
