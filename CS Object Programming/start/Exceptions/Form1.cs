using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            int Total = 0;

            // Streamreader implements a textreader that reads characters from a byte stream
            // in  a particular encoding.
            using (StreamReader sr = new StreamReader(txtFileName.Text))
            {
                // lees telkens een regel text via readline methode van de streamreader
                // ken het resultaat van de aanroep toe aan een stringvariabele
                string line = sr.ReadToEnd();
                int number = Convert.ToInt32(line);
                Total = Total + number;
            }

            lblTotal.Text = Convert.ToString(Total);



        }
    }
}
