using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Exceptions
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnDefault_Click(object sender, EventArgs e)
    {
      txtFileName.Text = @"..\..\numbers.txt";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      StreamReader reader = null;
      int total = 0;
      try
      {
        reader = new StreamReader(txtFileName.Text);

        for (; ; )
        {
          string s = reader.ReadLine();
          if (s == null)
            break;
          int number;
          try
          {
            number = Convert.ToInt32(s);
          }
          catch (FormatException)
          {
            number = 0;
          }
          catch (OverflowException)
          {
            number = 1000;
          }
          total += number;
        }
        lblTotal.Text = total.ToString();
      }
      catch (FileNotFoundException)
      {
        MessageBox.Show("File not found");
      }
      catch (DirectoryNotFoundException)
      {
        MessageBox.Show("folder not found");
      }
      catch (ArgumentException ex)
      {
        MessageBox.Show(ex.Message);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
      finally
      {
        if (reader != null)
          reader.Close();
      }
    }
  }
}
