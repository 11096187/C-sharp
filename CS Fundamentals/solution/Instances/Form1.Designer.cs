namespace Instances
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
      this.button2 = new System.Windows.Forms.Button();
      this.btnShowValue = new System.Windows.Forms.Button();
      this.lblValue = new System.Windows.Forms.Label();
      this.lblSquare = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(24, 20);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(157, 43);
      this.button1.TabIndex = 0;
      this.button1.Text = "Show Dialog";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(24, 86);
      this.button2.Margin = new System.Windows.Forms.Padding(4);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(157, 43);
      this.button2.TabIndex = 1;
      this.button2.Text = "Show Form";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnShowValue
      // 
      this.btnShowValue.Location = new System.Drawing.Point(252, 20);
      this.btnShowValue.Margin = new System.Windows.Forms.Padding(4);
      this.btnShowValue.Name = "btnShowValue";
      this.btnShowValue.Size = new System.Drawing.Size(157, 43);
      this.btnShowValue.TabIndex = 2;
      this.btnShowValue.Text = "Show Value";
      this.btnShowValue.UseVisualStyleBackColor = true;
      this.btnShowValue.Click += new System.EventHandler(this.btnShowValue_Click);
      // 
      // lblValue
      // 
      this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblValue.Location = new System.Drawing.Point(252, 86);
      this.lblValue.Name = "lblValue";
      this.lblValue.Size = new System.Drawing.Size(157, 32);
      this.lblValue.TabIndex = 3;
      // 
      // lblSquare
      // 
      this.lblSquare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblSquare.Location = new System.Drawing.Point(252, 129);
      this.lblSquare.Name = "lblSquare";
      this.lblSquare.Size = new System.Drawing.Size(157, 32);
      this.lblSquare.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(422, 195);
      this.Controls.Add(this.lblSquare);
      this.Controls.Add(this.lblValue);
      this.Controls.Add(this.btnShowValue);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnShowValue;
    private System.Windows.Forms.Label lblValue;
    private System.Windows.Forms.Label lblSquare;
  }
}

