using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instances
{
  public partial class frmDialog : Form
  {
    internal int Counter = 0;
    public frmDialog()
    {
      InitializeComponent();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnIncrement_Click(object sender, EventArgs e)
    {
      Counter++;
      lblCounter.Text = Counter.ToString();
    }
  }
}
