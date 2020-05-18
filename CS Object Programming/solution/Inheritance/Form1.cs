using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inheritance
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Task t = new Task("Daily reports");
      MessageBox.Show(t.ToString());
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        UrgentTask ut = new UrgentTask("Administration", 60);
        // MessageBox.Show(ut.ToString());
        Task t = ut;
        (t as UrgentTask).DeadLine = DateTime.Now.AddDays(20);
        MessageBox.Show(t.ToString());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);       
      }
    }
  }
  public class Task
  {
    public readonly DateTime CreationDate;
    public Task(string name)
    {
      this.Name = name;
      this.CreationDate = DateTime.Now.Date;
    }
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("Name = {0}", this.Name);
      sb.AppendLine();
      sb.AppendFormat("Creation Date = {0}", this.CreationDate.ToLongDateString ());
      return sb.ToString();
    }

    public string Name { get; set; }
  }

  public class UrgentTask : Task
  {
    public UrgentTask(string name,uint numberOfDays)
      : base(name)
    {
      this.DeadLine = DateTime.Now.AddDays(numberOfDays);
    }
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine (base.ToString());
      sb.AppendFormat("Deadline = {0}", this.DeadLine.ToLongDateString());
      return sb.ToString();
    }

    private DateTime m_Deadline;
    public DateTime DeadLine
    {
      get { return m_Deadline; }
      set {
        if (value.Date < DateTime.Now.Date)
        {
          throw new ArgumentException("Deadline already passed", "Deadline");
        }
        m_Deadline = value; 
      }
    }
    
  }
}
