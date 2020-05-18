namespace IntroLab
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
      this.txtNewText = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.lblAllText = new System.Windows.Forms.Label();
      this.chkNewLine = new System.Windows.Forms.CheckBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnShow = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtNewText
      // 
      this.txtNewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNewText.Location = new System.Drawing.Point(17, 14);
      this.txtNewText.Name = "txtNewText";
      this.txtNewText.Size = new System.Drawing.Size(261, 24);
      this.txtNewText.TabIndex = 0;
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Location = new System.Drawing.Point(299, 14);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(92, 31);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "&Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // lblAllText
      // 
      this.lblAllText.BackColor = System.Drawing.Color.PaleGreen;
      this.lblAllText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAllText.Location = new System.Drawing.Point(14, 77);
      this.lblAllText.Name = "lblAllText";
      this.lblAllText.Size = new System.Drawing.Size(266, 179);
      this.lblAllText.TabIndex = 2;
      // 
      // chkNewLine
      // 
      this.chkNewLine.AutoSize = true;
      this.chkNewLine.Location = new System.Drawing.Point(17, 48);
      this.chkNewLine.Name = "chkNewLine";
      this.chkNewLine.Size = new System.Drawing.Size(167, 17);
      this.chkNewLine.TabIndex = 3;
      this.chkNewLine.Text = "Insert newline before new text";
      this.chkNewLine.UseVisualStyleBackColor = true;
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(299, 77);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(92, 31);
      this.btnClear.TabIndex = 4;
      this.btnClear.Text = "Clear All";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnShow
      // 
      this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnShow.Location = new System.Drawing.Point(299, 125);
      this.btnShow.Name = "btnShow";
      this.btnShow.Size = new System.Drawing.Size(92, 49);
      this.btnShow.TabIndex = 5;
      this.btnShow.Text = "Show in Dialog";
      this.btnShow.UseVisualStyleBackColor = true;
      this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(299, 225);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(92, 31);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(412, 280);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnShow);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.chkNewLine);
      this.Controls.Add(this.lblAllText);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.txtNewText);
      this.Name = "Form1";
      this.Text = "IntroLab";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtNewText;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Label lblAllText;
    private System.Windows.Forms.CheckBox chkNewLine;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnShow;
    private System.Windows.Forms.Button btnClose;
  }
}

