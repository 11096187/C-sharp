using System;
using System.Drawing;
using System.Windows.Forms;

namespace DynamicEvents
{
  public partial class frmDynamicEvents : Form
  {
    Label[] CurrentFiles;
    public frmDynamicEvents()
    {
      InitializeComponent();
    }

    private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        this.Text = fbd.SelectedPath;
        ClearCurrentFiles();
        ShowCurrentFiles(fbd.SelectedPath);
      }
    }
    private void ClearCurrentFiles()
    {
      if (CurrentFiles != null)
        for (int i = 0; i < CurrentFiles.Length; i++)
        {
          // Todo : part one: remove all labels

        }
      CurrentFiles = null;
    }
    private void ShowCurrentFiles(string Path)
    {
      // Todo : part two: load all labels 

    }
    private void ShowContents(object sender, System.EventArgs e)
    {
      frmViewer f = new frmViewer(((Label)sender).Tag.ToString());
      f.Show();
    }

  }
}