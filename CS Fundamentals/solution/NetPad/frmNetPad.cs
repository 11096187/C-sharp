using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetPad
{
  public partial class frmNetPad : Form
  {
    private string FileName = "";
    private bool ChangesMade;
    public frmNetPad()
    {
      InitializeComponent();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (CheckCancel())
        return;
      textBox1.Clear();
      FileName = "";
      this.ChangesMade = false;
      this.Text = "NetPad - no name";
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (CheckCancel())
        return;
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "Textfiles|*.txt;*.log|All files|*.*";
      if (ofd.ShowDialog() == DialogResult.OK)
      {
        OpenFile(ofd.FileName);
      }
    }
    internal void OpenFile(string fileName)
    {
      FileName = fileName;
      this.ChangesMade = false;
      this.Text = "NetPad - " + Path.GetFileName(FileName);
      using (StreamReader sr = new StreamReader(FileName))
      {
        textBox1.Text = sr.ReadToEnd();
        sr.Close();
      }

    }
    private void SaveFile()
    {
      using (StreamWriter sw = new StreamWriter(FileName))
      {
        sw.Write(textBox1.Text);
        sw.Close();
        this.ChangesMade = false;
      }
    }
    private bool GetFileName()
    {
      SaveFileDialog sfd = new SaveFileDialog();
      sfd.Filter = "Textfile|*.txt|All files|*.*";
      sfd.FileName = FileName;
      sfd.OverwritePrompt = true;
      if (sfd.ShowDialog() == DialogResult.OK)
      {
        FileName = sfd.FileName;
        this.Text = "NetPad - " + Path.GetFileName(FileName);
        return true;
      }
      else
      {
        return false;
      }
    }
    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (FileName.Length > 0 || GetFileName())
      {
        SaveFile();
      }
    }
    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (GetFileName())
      {
        SaveFile();
      }
    }

    private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ColorDialog cd = new ColorDialog();
      cd.Color = textBox1.BackColor;
      if (cd.ShowDialog() == DialogResult.OK)
      {
        textBox1.BackColor = cd.Color;
      }
    }

    private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ColorDialog cd = new ColorDialog();
      cd.Color = textBox1.ForeColor;
      if (cd.ShowDialog() == DialogResult.OK)
      {
        textBox1.ForeColor = cd.Color;
      }
    }

    private void fontToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FontDialog fd = new FontDialog();
      fd.Font = textBox1.Font;
      if (fd.ShowDialog() == DialogResult.OK)
      {
        textBox1.Font = fd.Font;
      }
    }

    private void stayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.TopMost = !this.TopMost;
      stayOnTopToolStripMenuItem.Checked = this.TopMost;
    }
    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmAbout f = new frmAbout();
      f.Icon = this.Icon;
      f.ShowDialog();
    }
    private void boldtoolStripButton_Click(object sender, EventArgs e)
    {
      textBox1.Font = new Font(textBox1.Font,
        textBox1.Font.Style ^ FontStyle.Bold);
    }
    private void italicStripButton_Click(object sender, EventArgs e)
    {
      textBox1.Font = new Font(textBox1.Font,
           textBox1.Font.Style ^ FontStyle.Italic);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      this.ChangesMade = true;
    }

    private void frmNetPad_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (ChangesMade)
      {
        DialogResult answer = MessageBox.Show(
          "Do you want to save the text?",
          Application.ProductName,
          MessageBoxButtons.YesNoCancel,
          MessageBoxIcon.Question);
        switch (answer)
        {
          case DialogResult.Cancel:
            e.Cancel = true;
            break;
          case DialogResult.Yes:
            if (FileName.Length > 0 || GetFileName())
            {
              SaveFile();
            }
            break;
        }
      }
    }
    private bool CheckCancel()
    {
      if (ChangesMade)
      {
        DialogResult answer = MessageBox.Show(
          "Do you want to save the text?",
          Application.ProductName,
          MessageBoxButtons.YesNoCancel,
          MessageBoxIcon.Question);
        switch (answer)
        {
          case DialogResult.Cancel:
            return true;
          case DialogResult.Yes:
            if (FileName.Length > 0 || GetFileName())
            {
              SaveFile();
            }
            break;
        }
      }
      return false;
    }

    private void textBox1_MouseDown(object sender, MouseEventArgs e)
    {
      if( e.Button== MouseButtons.Right)
      {
        ContextMenuStrip cms = new ContextMenuStrip();
        cms.Items.Add(backgroundToolStripMenuItem.Text, null, backgroundToolStripMenuItem_Click);
        cms.Items.Add(foregroundToolStripMenuItem.Text, null, foregroundToolStripMenuItem_Click);
        cms.Items.Add(fontToolStripMenuItem.Text, null, fontToolStripMenuItem_Click);
        textBox1.ContextMenuStrip = cms;
      }
    }
  }
}
