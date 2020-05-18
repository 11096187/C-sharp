using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch
{
  public partial class frmWatch : Form
  {
    private enum SetMode
    {
      Save,
      Load
    }
    public frmWatch()
    {
      InitializeComponent();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      ShowTime();
    }

    private void btnHide_Click(object sender, EventArgs e)
    {
      this.Height = 75;
    }

    private void frmWatch_Load(object sender, EventArgs e)
    {
      Settings(SetMode.Load);
      this.Height = 75;
      // radLong.Checked = true;
      cbPosition.Items.Add("Center Screen");
      cbPosition.Items.Add("Top Right");
      cbPosition.Items.Add("Bottom Right");
      ShowTime();
    }
    private void ShowTime()
    {
      if (radLong.Checked)
        lblTime.Text = DateTime.Now.ToLongTimeString();
      else
        lblTime.Text = DateTime.Now.ToShortTimeString();

      if (this.WindowState == FormWindowState.Minimized)
        this.Text = lblTime.Text;
      else
        this.Text = Application.ProductName;
    }
    private void radShort_CheckedChanged(object sender, EventArgs e)
    {
      ShowTime();
    }
    private void radLong_CheckedChanged(object sender, EventArgs e)
    {
      ShowTime();

    }
    private void frmWatch_Resize(object sender, EventArgs e)
    {
      ShowTime();
    }

    private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (cbPosition.SelectedIndex)
      {
        case 0:
          this.CenterToScreen();
          break;
        case 1:
          this.Top = 0;
          this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
          break;
        case 2:
          this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
          this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
          break;
      }
    }

    private void lblTime_DoubleClick(object sender, EventArgs e)
    {
      this.Height = 150;
    }
    private void Settings(SetMode mode)
    {
      switch (mode)
      {
        case SetMode.Save:
          Properties.Settings.Default.x = this.Left;
          Properties.Settings.Default.y = this.Top;
          Properties.Settings.Default.longformat = radLong.Checked;
          Properties.Settings.Default.Save();
          break;
        case SetMode.Load:
          this.Left = Properties.Settings.Default.x;
          this.Top = Properties.Settings.Default.y;
          radLong.Checked = Properties.Settings.Default.longformat;
          radShort.Checked = !radLong.Checked;
          break;
        default:
          break;
      }
    }

    private void frmWatch_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings(SetMode.Save);
    }
  }
}
