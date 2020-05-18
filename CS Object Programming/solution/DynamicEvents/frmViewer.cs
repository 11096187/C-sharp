using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DynamicEvents
{
  public partial class frmViewer : Form
  {
    public frmViewer(string Path)
    {
      InitializeComponent();
      this.Path = Path;
    }
    string m_Path;
    public string Path
    {
      get
      {
        return m_Path;
      }
      set
      {
        m_Path = value;
      }
    }

    private void frmViewer_Load(object sender, EventArgs e)
    {
      string ext;
      FileInfo fi = new FileInfo(this.Path);
      this.Text = this.Path;
      ext = fi.Extension.ToLower();
      if (ext == ".txt" || ext == ".log"
        || ext == ".frm" || ext == ".vb"
        || ext == ".cs" || ext == ".csproj"
        || ext == ".vbs" || ext == ".cmd"
        || ext == ".ini" || ext == ".bat"
        || ext == ".html" || ext == ".htm")
      {
        StreamReader sr = new StreamReader(this.Path);
        textBox1.Text = sr.ReadToEnd();
        sr.Close();
        textBox1.Location = new Point(0, 0);
        textBox1.Size = this.ClientSize;
        textBox1.Visible = true;
        textBox1.Select(0, 0);
      }
      else if (ext == ".bmp" || ext == ".jpg"
        || ext == ".gif" || ext == "ico")
      {
        pictureBox1.Image = new Bitmap(this.Path);
        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Visible = true;
      }
      else
      {
        MessageBox.Show("sorry, no viewer available...", Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.Close();
      }

    }
  }
}
