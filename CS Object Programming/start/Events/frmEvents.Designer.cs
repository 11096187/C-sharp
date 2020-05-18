namespace Events
{
  partial class frmEvents
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
      this.btnNewGlass = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnTurboCool = new System.Windows.Forms.Button();
      this.btnTurboHeat = new System.Windows.Forms.Button();
      this.btnCool = new System.Windows.Forms.Button();
      this.btnHeat = new System.Windows.Forms.Button();
      this.lblTemperature = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnNewGlass
      // 
      this.btnNewGlass.Location = new System.Drawing.Point(88, 19);
      this.btnNewGlass.Name = "btnNewGlass";
      this.btnNewGlass.Size = new System.Drawing.Size(108, 29);
      this.btnNewGlass.TabIndex = 0;
      this.btnNewGlass.Text = "New Glass";
      this.btnNewGlass.UseVisualStyleBackColor = true;
      this.btnNewGlass.Click += new System.EventHandler(this.btnNewGlass_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnTurboCool);
      this.groupBox1.Controls.Add(this.btnTurboHeat);
      this.groupBox1.Controls.Add(this.btnCool);
      this.groupBox1.Controls.Add(this.btnHeat);
      this.groupBox1.Controls.Add(this.lblTemperature);
      this.groupBox1.Enabled = false;
      this.groupBox1.Location = new System.Drawing.Point(22, 84);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(247, 175);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Temperature";
      // 
      // btnTurboCool
      // 
      this.btnTurboCool.Location = new System.Drawing.Point(142, 124);
      this.btnTurboCool.Name = "btnTurboCool";
      this.btnTurboCool.Size = new System.Drawing.Size(84, 23);
      this.btnTurboCool.TabIndex = 4;
      this.btnTurboCool.Text = "Turbo Cool";
      this.btnTurboCool.UseVisualStyleBackColor = true;
      // 
      // btnTurboHeat
      // 
      this.btnTurboHeat.Location = new System.Drawing.Point(27, 124);
      this.btnTurboHeat.Name = "btnTurboHeat";
      this.btnTurboHeat.Size = new System.Drawing.Size(84, 23);
      this.btnTurboHeat.TabIndex = 3;
      this.btnTurboHeat.Text = "Turbo Heat";
      this.btnTurboHeat.UseVisualStyleBackColor = true;
      // 
      // btnCool
      // 
      this.btnCool.Location = new System.Drawing.Point(142, 74);
      this.btnCool.Name = "btnCool";
      this.btnCool.Size = new System.Drawing.Size(84, 23);
      this.btnCool.TabIndex = 2;
      this.btnCool.Text = "Cool";
      this.btnCool.UseVisualStyleBackColor = true;
      // 
      // btnHeat
      // 
      this.btnHeat.Location = new System.Drawing.Point(27, 74);
      this.btnHeat.Name = "btnHeat";
      this.btnHeat.Size = new System.Drawing.Size(84, 23);
      this.btnHeat.TabIndex = 1;
      this.btnHeat.Text = "Heat";
      this.btnHeat.UseVisualStyleBackColor = true;
      // 
      // lblTemperature
      // 
      this.lblTemperature.Location = new System.Drawing.Point(24, 33);
      this.lblTemperature.Name = "lblTemperature";
      this.lblTemperature.Size = new System.Drawing.Size(206, 21);
      this.lblTemperature.TabIndex = 0;
      // 
      // frmEvents
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnNewGlass);
      this.Name = "frmEvents";
      this.Text = "Events";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnNewGlass;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnTurboCool;
    private System.Windows.Forms.Button btnTurboHeat;
    private System.Windows.Forms.Button btnCool;
    private System.Windows.Forms.Button btnHeat;
    private System.Windows.Forms.Label lblTemperature;
  }
}

