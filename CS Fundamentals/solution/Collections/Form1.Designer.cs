namespace Collections
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
      this.grpGender = new System.Windows.Forms.GroupBox();
      this.radFemale = new System.Windows.Forms.RadioButton();
      this.radMale = new System.Windows.Forms.RadioButton();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.lblLastName = new System.Windows.Forms.Label();
      this.lblFirstName = new System.Windows.Forms.Label();
      this.lstPersons = new System.Windows.Forms.ListBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.txtWithText = new System.Windows.Forms.TextBox();
      this.radShowWithText = new System.Windows.Forms.RadioButton();
      this.grpShow = new System.Windows.Forms.GroupBox();
      this.radShowFemale = new System.Windows.Forms.RadioButton();
      this.radShowMale = new System.Windows.Forms.RadioButton();
      this.radShowAll = new System.Windows.Forms.RadioButton();
      this.grpGender.SuspendLayout();
      this.grpShow.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpGender
      // 
      this.grpGender.Controls.Add(this.radFemale);
      this.grpGender.Controls.Add(this.radMale);
      this.grpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grpGender.Location = new System.Drawing.Point(309, 18);
      this.grpGender.Name = "grpGender";
      this.grpGender.Size = new System.Drawing.Size(153, 83);
      this.grpGender.TabIndex = 12;
      this.grpGender.TabStop = false;
      this.grpGender.Text = "Gender";
      // 
      // radFemale
      // 
      this.radFemale.AutoSize = true;
      this.radFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radFemale.Location = new System.Drawing.Point(18, 42);
      this.radFemale.Name = "radFemale";
      this.radFemale.Size = new System.Drawing.Size(72, 20);
      this.radFemale.TabIndex = 1;
      this.radFemale.TabStop = true;
      this.radFemale.Text = "Female";
      this.radFemale.UseVisualStyleBackColor = true;
      this.radFemale.CheckedChanged += new System.EventHandler(this.ValidateControls);
      // 
      // radMale
      // 
      this.radMale.AutoSize = true;
      this.radMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radMale.Location = new System.Drawing.Point(18, 21);
      this.radMale.Name = "radMale";
      this.radMale.Size = new System.Drawing.Size(56, 20);
      this.radMale.TabIndex = 0;
      this.radMale.TabStop = true;
      this.radMale.Text = "Male";
      this.radMale.UseVisualStyleBackColor = true;
      this.radMale.CheckedChanged += new System.EventHandler(this.ValidateControls);
      // 
      // txtLastName
      // 
      this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLastName.Location = new System.Drawing.Point(102, 67);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(100, 22);
      this.txtLastName.TabIndex = 11;
      this.txtLastName.TextChanged += new System.EventHandler(this.ValidateControls);
      // 
      // txtFirstName
      // 
      this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFirstName.Location = new System.Drawing.Point(102, 39);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(100, 22);
      this.txtFirstName.TabIndex = 9;
      this.txtFirstName.TextChanged += new System.EventHandler(this.ValidateControls);
      // 
      // lblLastName
      // 
      this.lblLastName.AutoSize = true;
      this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLastName.Location = new System.Drawing.Point(12, 69);
      this.lblLastName.Name = "lblLastName";
      this.lblLastName.Size = new System.Drawing.Size(73, 16);
      this.lblLastName.TabIndex = 10;
      this.lblLastName.Text = "Last Name";
      // 
      // lblFirstName
      // 
      this.lblFirstName.AutoSize = true;
      this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFirstName.Location = new System.Drawing.Point(12, 39);
      this.lblFirstName.Name = "lblFirstName";
      this.lblFirstName.Size = new System.Drawing.Size(73, 16);
      this.lblFirstName.TabIndex = 8;
      this.lblFirstName.Text = "First Name";
      // 
      // lstPersons
      // 
      this.lstPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstPersons.FormattingEnabled = true;
      this.lstPersons.ItemHeight = 16;
      this.lstPersons.Location = new System.Drawing.Point(15, 192);
      this.lstPersons.Name = "lstPersons";
      this.lstPersons.Size = new System.Drawing.Size(259, 180);
      this.lstPersons.TabIndex = 14;
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Location = new System.Drawing.Point(15, 130);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(259, 28);
      this.btnAdd.TabIndex = 13;
      this.btnAdd.Text = "Add Person";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // txtWithText
      // 
      this.txtWithText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtWithText.Location = new System.Drawing.Point(25, 142);
      this.txtWithText.Name = "txtWithText";
      this.txtWithText.Size = new System.Drawing.Size(100, 22);
      this.txtWithText.TabIndex = 4;
      this.txtWithText.TextChanged += new System.EventHandler(this.radShow_CheckedChanged);
      // 
      // radShowWithText
      // 
      this.radShowWithText.AutoSize = true;
      this.radShowWithText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radShowWithText.Location = new System.Drawing.Point(25, 119);
      this.radShowWithText.Name = "radShowWithText";
      this.radShowWithText.Size = new System.Drawing.Size(81, 20);
      this.radShowWithText.TabIndex = 3;
      this.radShowWithText.TabStop = true;
      this.radShowWithText.Text = "With Text";
      this.radShowWithText.UseVisualStyleBackColor = true;
      this.radShowWithText.CheckedChanged += new System.EventHandler(this.radShow_CheckedChanged);
      // 
      // grpShow
      // 
      this.grpShow.Controls.Add(this.txtWithText);
      this.grpShow.Controls.Add(this.radShowFemale);
      this.grpShow.Controls.Add(this.radShowWithText);
      this.grpShow.Controls.Add(this.radShowMale);
      this.grpShow.Controls.Add(this.radShowAll);
      this.grpShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grpShow.Location = new System.Drawing.Point(309, 192);
      this.grpShow.Name = "grpShow";
      this.grpShow.Size = new System.Drawing.Size(153, 180);
      this.grpShow.TabIndex = 15;
      this.grpShow.TabStop = false;
      this.grpShow.Text = "Show";
      // 
      // radShowFemale
      // 
      this.radShowFemale.AutoSize = true;
      this.radShowFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radShowFemale.Location = new System.Drawing.Point(25, 65);
      this.radShowFemale.Name = "radShowFemale";
      this.radShowFemale.Size = new System.Drawing.Size(72, 20);
      this.radShowFemale.TabIndex = 2;
      this.radShowFemale.TabStop = true;
      this.radShowFemale.Text = "Female";
      this.radShowFemale.UseVisualStyleBackColor = true;
      this.radShowFemale.CheckedChanged += new System.EventHandler(this.radShow_CheckedChanged);
      // 
      // radShowMale
      // 
      this.radShowMale.AutoSize = true;
      this.radShowMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radShowMale.Location = new System.Drawing.Point(25, 42);
      this.radShowMale.Name = "radShowMale";
      this.radShowMale.Size = new System.Drawing.Size(56, 20);
      this.radShowMale.TabIndex = 1;
      this.radShowMale.TabStop = true;
      this.radShowMale.Text = "Male";
      this.radShowMale.UseVisualStyleBackColor = true;
      this.radShowMale.CheckedChanged += new System.EventHandler(this.radShow_CheckedChanged);
      // 
      // radShowAll
      // 
      this.radShowAll.AutoSize = true;
      this.radShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radShowAll.Location = new System.Drawing.Point(25, 19);
      this.radShowAll.Name = "radShowAll";
      this.radShowAll.Size = new System.Drawing.Size(41, 20);
      this.radShowAll.TabIndex = 0;
      this.radShowAll.TabStop = true;
      this.radShowAll.Text = "All";
      this.radShowAll.UseVisualStyleBackColor = true;
      this.radShowAll.CheckedChanged += new System.EventHandler(this.radShow_CheckedChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(473, 382);
      this.Controls.Add(this.grpGender);
      this.Controls.Add(this.txtLastName);
      this.Controls.Add(this.txtFirstName);
      this.Controls.Add(this.lblLastName);
      this.Controls.Add(this.lblFirstName);
      this.Controls.Add(this.lstPersons);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.grpShow);
      this.Name = "Form1";
      this.Text = "Collections";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.grpGender.ResumeLayout(false);
      this.grpGender.PerformLayout();
      this.grpShow.ResumeLayout(false);
      this.grpShow.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.GroupBox grpGender;
    internal System.Windows.Forms.RadioButton radFemale;
    internal System.Windows.Forms.RadioButton radMale;
    internal System.Windows.Forms.TextBox txtLastName;
    internal System.Windows.Forms.TextBox txtFirstName;
    internal System.Windows.Forms.Label lblLastName;
    internal System.Windows.Forms.Label lblFirstName;
    internal System.Windows.Forms.ListBox lstPersons;
    internal System.Windows.Forms.Button btnAdd;
    internal System.Windows.Forms.TextBox txtWithText;
    internal System.Windows.Forms.RadioButton radShowWithText;
    internal System.Windows.Forms.GroupBox grpShow;
    internal System.Windows.Forms.RadioButton radShowFemale;
    internal System.Windows.Forms.RadioButton radShowMale;
    internal System.Windows.Forms.RadioButton radShowAll;
  }
}

