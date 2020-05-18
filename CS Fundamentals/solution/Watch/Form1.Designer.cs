namespace Watch
{
  partial class frmWatch
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWatch));
      this.lblTime = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.btnHide = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radLong = new System.Windows.Forms.RadioButton();
      this.radShort = new System.Windows.Forms.RadioButton();
      this.cbPosition = new System.Windows.Forms.ComboBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTime
      // 
      this.lblTime.BackColor = System.Drawing.Color.LightGreen;
      this.lblTime.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.ForeColor = System.Drawing.Color.ForestGreen;
      this.lblTime.Location = new System.Drawing.Point(0, 0);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(185, 39);
      this.lblTime.TabIndex = 0;
      this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblTime.DoubleClick += new System.EventHandler(this.lblTime_DoubleClick);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // btnHide
      // 
      this.btnHide.Location = new System.Drawing.Point(110, 45);
      this.btnHide.Name = "btnHide";
      this.btnHide.Size = new System.Drawing.Size(74, 26);
      this.btnHide.TabIndex = 1;
      this.btnHide.Text = "Fold";
      this.btnHide.UseVisualStyleBackColor = true;
      this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radLong);
      this.groupBox1.Controls.Add(this.radShort);
      this.groupBox1.Location = new System.Drawing.Point(0, 42);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(85, 64);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Format";
      // 
      // radLong
      // 
      this.radLong.AutoSize = true;
      this.radLong.Location = new System.Drawing.Point(11, 34);
      this.radLong.Name = "radLong";
      this.radLong.Size = new System.Drawing.Size(49, 17);
      this.radLong.TabIndex = 1;
      this.radLong.TabStop = true;
      this.radLong.Text = "Long";
      this.radLong.UseVisualStyleBackColor = true;
      this.radLong.CheckedChanged += new System.EventHandler(this.radLong_CheckedChanged);
      // 
      // radShort
      // 
      this.radShort.AutoSize = true;
      this.radShort.Location = new System.Drawing.Point(11, 16);
      this.radShort.Name = "radShort";
      this.radShort.Size = new System.Drawing.Size(50, 17);
      this.radShort.TabIndex = 0;
      this.radShort.TabStop = true;
      this.radShort.Text = "Short";
      this.radShort.UseVisualStyleBackColor = true;
      this.radShort.CheckedChanged += new System.EventHandler(this.radShort_CheckedChanged);
      // 
      // cbPosition
      // 
      this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbPosition.FormattingEnabled = true;
      this.cbPosition.Location = new System.Drawing.Point(96, 82);
      this.cbPosition.Name = "cbPosition";
      this.cbPosition.Size = new System.Drawing.Size(87, 21);
      this.cbPosition.TabIndex = 3;
      this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
      // 
      // frmWatch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(184, 111);
      this.Controls.Add(this.cbPosition);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnHide);
      this.Controls.Add(this.lblTime);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "frmWatch";
      this.Text = "Watch";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWatch_FormClosing);
      this.Load += new System.EventHandler(this.frmWatch_Load);
      this.Resize += new System.EventHandler(this.frmWatch_Resize);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnHide;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radLong;
    private System.Windows.Forms.RadioButton radShort;
    private System.Windows.Forms.ComboBox cbPosition;
  }
}

