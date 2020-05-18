using System;
using System.IO;
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
          CurrentFiles[i].Click -= ShowContents;
          panel1.Controls.Remove(CurrentFiles[i]);
          CurrentFiles[i] = null;
        }
      CurrentFiles = null;
    }
    private void ShowCurrentFiles(string Path)
    {
      // Todo : part two: load all labels 
      DirectoryInfo di = new DirectoryInfo(Path);
      FileInfo[] fi = di.GetFiles();
      CurrentFiles = new Label[fi.Length];
      for (int i = 0; i < fi.Length ; i++)
      {
        CurrentFiles[i] = new Label();
        panel1.Controls.Add(CurrentFiles[i]);
        CurrentFiles[i].Location =new Point (2, 15*i);
        CurrentFiles[i].AutoSize=true;
        CurrentFiles[i].Text =fi[i].Name;
        CurrentFiles[i].Tag=fi[i].FullName;
        CurrentFiles[i].ForeColor=Color.Blue;
        CurrentFiles[i].Font=new Font(CurrentFiles[i].Font, 
                        CurrentFiles[i].Font.Style | FontStyle.Underline);
        CurrentFiles[i].Cursor=Cursors.Hand;
        CurrentFiles[i].Visible=true;
        CurrentFiles[i].Click += ShowContents;
      }
    }
    private void ShowContents(object sender, System.EventArgs e)
    {
      frmViewer f = new frmViewer(((Label)sender).Tag.ToString());
      f.Show();
    }

  }
}