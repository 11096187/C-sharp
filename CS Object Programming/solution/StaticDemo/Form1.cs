using System;
using System.Windows.Forms;

namespace StaticDemo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      
    }
    private void button1_Click(object sender, EventArgs e)
    {
      Numbers Num = new Numbers();
      int n = 0;
      DateTime dt = DateTime.Now;
      for (int i = 0; i < 20000; i++)
      {
        n = Num.GetNumber(155);
      }

      MessageBox.Show("Time taken : " + DateTime.Now.Subtract(dt).ToString());
      MessageBox.Show(n.ToString());
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Numbers x = new Numbers();
    }
  }
}
