using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      double x = Convert.ToDouble(txtNumber.Text);
      double result = Treble(x);
      // Console.WriteLine("Result = {0:F2}",result);
      // lblResult.Text = string.Format("The square root of {0:F2} = {1:F4}", x, result);
      // lblResult.Text =$"The square root of {x:F2} = {result:F4}";
      lblResult.Text =$"The treble of {x:F1} = {result:F1}";
    }
    private void txtNumber_TextChanged(object sender, EventArgs e)
    {
      double d;
      if (double.TryParse(txtNumber.Text, out d) && InRange(d,0,100))
      {
        txtNumber.BackColor = Color.White;
        btnCalculate.Enabled = true;
      }
      else
      {
        txtNumber.BackColor = Color.Pink;
        btnCalculate.Enabled = false;
      }
    }
    /// <summary>
    /// this function multiplies the input by three
    /// </summary>
    /// <param name="x">the input number</param>
    /// <returns>the input multiplied by three</returns>
    private double Treble(double x)
    {
      return x * 3;
    }
    private bool InRange(double d, double min, double max)
    {
      return d >= min && d <= max;
    }
  }
}
