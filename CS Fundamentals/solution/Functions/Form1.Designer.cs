namespace Functions
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
      this.txtNumber = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.lblResult = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtNumber
      // 
      this.txtNumber.Location = new System.Drawing.Point(16, 15);
      this.txtNumber.Name = "txtNumber";
      this.txtNumber.Size = new System.Drawing.Size(191, 24);
      this.txtNumber.TabIndex = 0;
      this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
      // 
      // btnCalculate
      // 
      this.btnCalculate.Enabled = false;
      this.btnCalculate.Location = new System.Drawing.Point(237, 15);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(90, 30);
      this.btnCalculate.TabIndex = 1;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // lblResult
      // 
      this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblResult.Location = new System.Drawing.Point(16, 54);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(310, 32);
      this.lblResult.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(338, 99);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtNumber);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Functions";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtNumber;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label lblResult;
  }
}

