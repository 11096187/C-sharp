﻿namespace Interfaces
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
      this.listView1 = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnFill = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listView1
      // 
      this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.listView1.Enabled = false;
      this.listView1.GridLines = true;
      this.listView1.Location = new System.Drawing.Point(12, 48);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(374, 256);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = System.Windows.Forms.View.Details;
      this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Filename";
      this.columnHeader1.Width = 220;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Size";
      this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.columnHeader2.Width = 106;
      // 
      // btnFill
      // 
      this.btnFill.Location = new System.Drawing.Point(15, 11);
      this.btnFill.Name = "btnFill";
      this.btnFill.Size = new System.Drawing.Size(85, 22);
      this.btnFill.TabIndex = 1;
      this.btnFill.Text = "Fill";
      this.btnFill.UseVisualStyleBackColor = true;
      this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(411, 327);
      this.Controls.Add(this.btnFill);
      this.Controls.Add(this.listView1);
      this.Name = "Form1";
      this.Text = "Interfaces";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button btnFill;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
  }
}

