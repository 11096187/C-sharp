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

namespace Collections
{
  public partial class Form1 : Form
  {
    private struct Person
    {
      public string FirstName;
      public string LastName;
      public GenderType Gender;
      public override string ToString()
      {
        return $"{FirstName} {LastName} ({Gender.ToString().Substring(0, 1)})";
      }
    }
    private enum GenderType
    {
      Male,
      Female
    }
    private List<Person> Persons = new List<Person>();
    public Form1()
    {
      InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      Person p;
      p.FirstName = txtFirstName.Text;
      p.LastName = txtLastName.Text;
      if (radMale.Checked)
        p.Gender = GenderType.Male;
      else
        p.Gender = GenderType.Female;
      Persons.Add(p);
      ClearControls();
      ShowPersons();
    }
    private void ShowPersons()
    {
      //lstPersons.Items.Clear();
      //foreach (Person p in Persons)
      //{
      //  lstPersons.Items.Add(p);
      //}
      if (radShowAll.Checked)
      {
        lstPersons.DataSource = Persons.ToList();
      }
      else if (radShowMale.Checked)
      {
        var v = from p in Persons
                where p.Gender == GenderType.Male
                select p;
        lstPersons.DataSource = v.ToList();
      }
      else if (radShowFemale.Checked)
      {
        var v = from p in Persons
                where p.Gender == GenderType.Female
                select p;
        lstPersons.DataSource = v.ToList();
      }
      else if (radShowWithText.Checked)
      {
        var v = from p in Persons
                where $"{p.FirstName} {p.LastName}".ToLower()
                      .Contains(txtWithText.Text.ToLower())
                select p;
        lstPersons.DataSource = v.ToList();
      }
    }
    private void ClearControls()
    {
      txtFirstName.Clear();
      txtLastName.Clear();
      radMale.Checked = false;
      radFemale.Checked = false;
      btnAdd.Enabled = false;
    }
    private void ValidateControls(object sender, EventArgs e)
    {
      btnAdd.Enabled = txtFirstName.TextLength > 0
                 && txtLastName.TextLength > 0
                 && (radMale.Checked || radFemale.Checked);
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      ClearControls();
      radShowAll.Checked = true;
      ReadPersons();
      ShowPersons();
    }
    private void WritePersons()
    {
      string Filename = "Persons.txt";
      if (File.Exists(Filename))
        File.Delete(Filename);
      var s = new List<String>();
      foreach (Person p in Persons)
      {
        s.Add($"{p.FirstName}:{p.LastName}:{p.Gender.ToString()}");
      }
      File.AppendAllLines(Filename, s);
    }
    private void ReadPersons()
    {
      string Filename = "Persons.txt";
      if (File.Exists(Filename))
      {
        var lines = File.ReadAllLines(Filename);
        foreach (string line in lines)
        {
          var fields = line.Split(':');
          Person p;
          p.FirstName = fields[0];
          p.LastName = fields[1];
          p.Gender = (GenderType)(Enum.Parse(typeof(GenderType), fields[2]));
          Persons.Add(p);
        }
      }
    }
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      WritePersons();
    }

    private void radShow_CheckedChanged(object sender, EventArgs e)
    {
      ShowPersons();
    }
  }
}
