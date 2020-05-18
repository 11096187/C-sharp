using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroLab
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if( chkNewLine.Checked)
      {
        lblAllText.Text += "\n";
      }
      lblAllText.Text += txtNewText.Text;
      txtNewText.Clear();
      txtNewText.Focus();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      lblAllText.Text = "";
    }

    private void btnShow_Click(object sender, EventArgs e)
    {
      MessageBox.Show(lblAllText.Text);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
