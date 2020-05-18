using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompuTrain;

namespace PersonTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCreatePerson_Click(object sender, EventArgs e)
    {
      try
      {
        CompuTrain.Person p;
        p= new Person(txtFirstName.Text, txtLastName.Text, dtpBirthday.Value);

        lblResult.Text = string.Format(
                "{0} is {1} years old.",
                p.FullName, p.Age);
      }
      catch (Exception ex)
      {
        lblResult.Text = string.Empty;
        MessageBox.Show(ex.Message );
      }
    }

    private void btnCreateChild_Click(object sender, EventArgs e)
    {
      try
      {
        Person p = new Person(txtFirstName.Text, txtLastName.Text);

        lblResult.Text = string.Format(
                "{0} is {1} years old.",
                p.FullName, p.Age);
      }
      catch (Exception ex)
      {
        lblResult.Text = string.Empty;
        MessageBox.Show(ex.Message);
      }

    }
  }
}
