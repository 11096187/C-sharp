namespace Instances
{
  partial class frmDialog
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
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnIncrement = new System.Windows.Forms.Button();
      this.lblCounter = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(192, 24);
      this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(100, 28);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(192, 79);
      this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(100, 28);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnIncrement
      // 
      this.btnIncrement.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnIncrement.Location = new System.Drawing.Point(13, 24);
      this.btnIncrement.Margin = new System.Windows.Forms.Padding(4);
      this.btnIncrement.Name = "btnIncrement";
      this.btnIncrement.Size = new System.Drawing.Size(100, 28);
      this.btnIncrement.TabIndex = 2;
      this.btnIncrement.Text = "Increment";
      this.btnIncrement.UseVisualStyleBackColor = true;
      this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
      // 
      // lblCounter
      // 
      this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblCounter.Location = new System.Drawing.Point(13, 74);
      this.lblCounter.Name = "lblCounter";
      this.lblCounter.Size = new System.Drawing.Size(100, 33);
      this.lblCounter.TabIndex = 3;
      // 
      // frmDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Bisque;
      this.ClientSize = new System.Drawing.Size(305, 132);
      this.Controls.Add(this.lblCounter);
      this.Controls.Add(this.btnIncrement);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "frmDialog";
      this.Text = "frmDialog";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnIncrement;
    private System.Windows.Forms.Label lblCounter;
  }
}