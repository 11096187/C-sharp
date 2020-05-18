using System;
using System.IO;
using System.Windows.Forms;

namespace Interfaces
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnFill_Click(object sender, EventArgs e)
    {
      listView1.ListViewItemSorter = null;
      listView1.Items.Clear();
      DirectoryInfo di = new DirectoryInfo(System.Environment.SystemDirectory);
      foreach(FileInfo fi in di.GetFiles() )
      {
        ListViewItem li= listView1.Items.Add(fi.Name);
        li.SubItems.Add (fi.Length.ToString());
      }
      listView1.Enabled = true;
    }
  }
}
