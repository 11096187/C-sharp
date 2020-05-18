using System;
using System.Collections;
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
      foreach (FileInfo fi in di.GetFiles())
      {
        ListViewItem li = listView1.Items.Add(fi.Name);
        li.SubItems.Add(fi.Length.ToString());
      }
      listView1.Enabled = true;
    }
    private SortOrder sortOrder = SortOrder.None;
    private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      if (sortOrder == SortOrder.Ascending)
        sortOrder = SortOrder.Descending;
      else
        sortOrder = SortOrder.Ascending;
      listView1.ListViewItemSorter = new lvComparer(e.Column, sortOrder);
    }
  }
  public class lvComparer : IComparer
  {
    private int ColumnNumber;
    private SortOrder SortOrder;
    public lvComparer(int columnNumber, SortOrder sortOrder)
    {
      this.ColumnNumber = columnNumber;
      this.SortOrder = sortOrder;
    }
    public int Compare(object x, object y)
    {
      ListViewItem l1, l2;
      if (this.SortOrder == SortOrder.Ascending)
      {
        l1 = (ListViewItem)x;
        l2 = (ListViewItem)y;
      }
      else
      {
        l2 = (ListViewItem)x;
        l1 = (ListViewItem)y;
      }

      switch (this.ColumnNumber)
      {
        case 0:
          return string.Compare(l1.SubItems[0].Text, l2.SubItems[1].Text);
        case 1:
          int i1, i2;
          i1 = Convert.ToInt32(l1.SubItems[1].Text);
          i2 = Convert.ToInt32(l2.SubItems[1].Text);
          if (i1 < i2)
            return -1;
          else if (i1 > i2)
            return 1;
          else
            return string.Compare(l1.SubItems[0].Text, l2.SubItems[1].Text);
        default:
          return 0;
      }
    }
  }
}
