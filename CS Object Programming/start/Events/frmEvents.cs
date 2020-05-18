using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Events
{
  public partial class frmEvents : Form
  {
    public frmEvents()
    {
      InitializeComponent();
    }

    private void btnNewGlass_Click(object sender, EventArgs e)
    {
      groupBox1.Enabled = true;
    }
  }
}
