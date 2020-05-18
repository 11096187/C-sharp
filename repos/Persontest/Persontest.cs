using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persontest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Set up new person
            Person person = new Person();

            // Parse value from fields
            person.FirstName = txtFirstname.Text;
            person.LastName = txtLastname.Text;
            person.Birthday = dateTimePicker.Value;

            lblAnswer.Text = person.FullName + ", " + person.Age;

        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
