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
    private GlassOfWater glass;
    public frmEvents()
    {
      InitializeComponent();
    }

    private void btnNewGlass_Click(object sender, EventArgs e)
    {
      glass = new GlassOfWater();
      lblTemperature.Text = "Temperature = " + glass.Temperature.ToString();
      glass.TemperatureChanged += glass_TemperatureChanged;
      glass.Freeze += new GlassOfWater.TemperatureChangedHandler(glass_Freeze);
      glass.Melt += new GlassOfWater.TemperatureChangedHandler(glass_Melt);
      glass.Boil += new GlassOfWater.TemperatureChangedHandler(glass_Boil);
      glass.Condensate += new GlassOfWater.TemperatureChangedHandler(glass_Condensate);
      groupBox1.Enabled = true;
    }

    void glass_Condensate(object sender, TemperatureChangedEventArgs e)
    {
      MessageBox.Show("Condensate");
    }

    void glass_Boil(object sender, TemperatureChangedEventArgs e)
    {
      MessageBox.Show("Boil");
    }

    void glass_Melt(object sender, TemperatureChangedEventArgs e)
    {
      MessageBox.Show("Melt");
    }

    void glass_Freeze(object sender, TemperatureChangedEventArgs e)
    {
      MessageBox.Show("Freeze");
    }

    void glass_TemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
      lblTemperature.Text = "Temperature = " + e.Temperature.ToString();
    }

    private void btnHeat_Click(object sender, EventArgs e)
    {
      if (sender == btnHeat)
        glass.Heat();
      else
        glass.Heat(50);
    }

    private void btnCool_Click(object sender, EventArgs e)
    {
      try
      {
        if (sender == btnCool)
          glass.Cool();
        else
          glass.Cool(50);

      }
      catch (IllegalTemperatureException ex)
      {
        MessageBox.Show(ex.Message );        
      }
    }
  }
}
