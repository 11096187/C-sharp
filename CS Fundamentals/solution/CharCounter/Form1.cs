using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CharCounter
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCount_Click(object sender, EventArgs e)
    {
      int[,] counters = new int[29,2];
      //DateTime time = DateTime.Now;
      string s = txtText.Text;
      CountValues(counters, s);
      //MessageBox.Show(DateTime.Now.Subtract(time).ToString());
      ShowValues(counters);
    }

    private static void CountValues(int[,] counters, string s)
    {
      for (int i = 0; i < s.Length; i++)
      {
        char c = s[i];
        if (char.IsUpper(c))
        {
          int index = (int)c - (int)'A';
          counters[index, 0]++;
        }
        if (char.IsLower(c))
        {
          int index = (int)c - (int)'a';
          counters[index,1]++;
        }
        else if (char.IsWhiteSpace(c))
        {
          counters[26,0]++;
        }
        else if (char.IsDigit(c))
        {
          counters[28,0]++;
        }
        else
        {
          counters[27,0]++;
        }
      }
    }

    private void ShowValues(int[,] counters)
    {
      ListViewItem li;
      lvChars.Items.Clear();
      for (int i = 0; i < 26; i++)
      {
        char c = (char)(i + (int)'A');
        li = lvChars.Items.Add(c.ToString());
        li.SubItems.Add(counters[i,0].ToString());
        li.SubItems.Add(counters[i,1].ToString());
      }
      li = lvChars.Items.Add("Digits");
      li.SubItems.Add(counters[28,0].ToString());
      li = lvChars.Items.Add("Spaces");
      li.SubItems.Add(counters[26,0].ToString());
      li = lvChars.Items.Add("Other");
      li.SubItems.Add(counters[27,0].ToString());
    }

    private void btnRead_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "TextFiles|*.txt;*.log|All Files|*.*";
      if(ofd.ShowDialog() ==DialogResult.OK )
      {
        txtText.Text = File.ReadAllText(ofd.FileName);
      }
    }
  }
}
