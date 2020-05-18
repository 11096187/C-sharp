namespace Exceptions
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
      this.button1 = new System.Windows.Forms.Button();
      this.txtFileName = new System.Windows.Forms.TextBox();
      this.lblTotal = new System.Windows.Forms.Label();
      this.btnDefault = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(29, 54);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(99, 27);
      this.button1.TabIndex = 0;
      this.button1.Text = "Add all numbers";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtFileName
      // 
      this.txtFileName.Location = new System.Drawing.Point(97, 11);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.Size = new System.Drawing.Size(171, 20);
      this.txtFileName.TabIndex = 1;
      // 
      // lblTotal
      // 
      this.lblTotal.BackColor = System.Drawing.Color.LightYellow;
      this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblTotal.Location = new System.Drawing.Point(97, 100);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(102, 32);
      this.lblTotal.TabIndex = 2;
      this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnDefault
      // 
      this.btnDefault.Location = new System.Drawing.Point(169, 54);
      this.btnDefault.Name = "btnDefault";
      this.btnDefault.Size = new System.Drawing.Size(99, 27);
      this.btnDefault.TabIndex = 3;
      this.btnDefault.Text = "Use default file";
      this.btnDefault.UseVisualStyleBackColor = true;
      this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 110);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(34, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Total:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(26, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Filename:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 168);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnDefault);
      this.Controls.Add(this.lblTotal);
      this.Controls.Add(this.txtFileName);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Exceptions";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtFileName;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Button btnDefault;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

