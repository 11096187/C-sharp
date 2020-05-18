namespace PersonTest
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnCreatePerson = new System.Windows.Forms.Button();
      this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lblResult = new System.Windows.Forms.Label();
      this.btnCreateChild = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(44, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "First Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(44, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Last Name";
      // 
      // btnCreatePerson
      // 
      this.btnCreatePerson.Location = new System.Drawing.Point(132, 128);
      this.btnCreatePerson.Name = "btnCreatePerson";
      this.btnCreatePerson.Size = new System.Drawing.Size(104, 23);
      this.btnCreatePerson.TabIndex = 2;
      this.btnCreatePerson.Text = "Create Person";
      this.btnCreatePerson.UseVisualStyleBackColor = true;
      this.btnCreatePerson.Click += new System.EventHandler(this.btnCreatePerson_Click);
      // 
      // dtpBirthday
      // 
      this.dtpBirthday.Location = new System.Drawing.Point(132, 84);
      this.dtpBirthday.Name = "dtpBirthday";
      this.dtpBirthday.Size = new System.Drawing.Size(203, 20);
      this.dtpBirthday.TabIndex = 3;
      // 
      // txtFirstName
      // 
      this.txtFirstName.Location = new System.Drawing.Point(132, 32);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(203, 20);
      this.txtFirstName.TabIndex = 4;
      // 
      // txtLastName
      // 
      this.txtLastName.Location = new System.Drawing.Point(132, 58);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(203, 20);
      this.txtLastName.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(44, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Birthday";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(44, 168);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(37, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Result";
      // 
      // lblResult
      // 
      this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblResult.Location = new System.Drawing.Point(129, 167);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(206, 23);
      this.lblResult.TabIndex = 8;
      // 
      // btnCreateChild
      // 
      this.btnCreateChild.Location = new System.Drawing.Point(242, 128);
      this.btnCreateChild.Name = "btnCreateChild";
      this.btnCreateChild.Size = new System.Drawing.Size(93, 23);
      this.btnCreateChild.TabIndex = 9;
      this.btnCreateChild.Text = "Create Child";
      this.btnCreateChild.UseVisualStyleBackColor = true;
      this.btnCreateChild.Click += new System.EventHandler(this.btnCreateChild_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(377, 238);
      this.Controls.Add(this.btnCreateChild);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtLastName);
      this.Controls.Add(this.txtFirstName);
      this.Controls.Add(this.dtpBirthday);
      this.Controls.Add(this.btnCreatePerson);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Test Person Class";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnCreatePerson;
    private System.Windows.Forms.DateTimePicker dtpBirthday;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.Button btnCreateChild;
  }
}

