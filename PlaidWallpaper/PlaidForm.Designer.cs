namespace PlaidWallpaperWinForm
{
  partial class PlaidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaidForm));
            this.cbVerticalLine = new System.Windows.Forms.CheckBox();
            this.cbHorizontalLine = new System.Windows.Forms.CheckBox();
            this.tbBoxSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxXCells = new System.Windows.Forms.TextBox();
            this.labelMaxXCells = new System.Windows.Forms.Label();
            this.tbMaxYCells = new System.Windows.Forms.TextBox();
            this.labelMaxYCells = new System.Windows.Forms.Label();
            this.buttonDoThePlaid = new System.Windows.Forms.Button();
            this.tbWallpaperNumber = new System.Windows.Forms.TextBox();
            this.labelWallpaperNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbVerticalLine
            // 
            this.cbVerticalLine.AutoSize = true;
            this.cbVerticalLine.Checked = true;
            this.cbVerticalLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVerticalLine.Location = new System.Drawing.Point(30, 28);
            this.cbVerticalLine.Name = "cbVerticalLine";
            this.cbVerticalLine.Size = new System.Drawing.Size(84, 17);
            this.cbVerticalLine.TabIndex = 0;
            this.cbVerticalLine.Text = "Vertical Line";
            this.cbVerticalLine.UseVisualStyleBackColor = true;
            // 
            // cbHorizontalLine
            // 
            this.cbHorizontalLine.AutoSize = true;
            this.cbHorizontalLine.Checked = true;
            this.cbHorizontalLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHorizontalLine.Location = new System.Drawing.Point(167, 28);
            this.cbHorizontalLine.Name = "cbHorizontalLine";
            this.cbHorizontalLine.Size = new System.Drawing.Size(96, 17);
            this.cbHorizontalLine.TabIndex = 1;
            this.cbHorizontalLine.Text = "Horizontal Line";
            this.cbHorizontalLine.UseVisualStyleBackColor = true;
            // 
            // tbBoxSize
            // 
            this.tbBoxSize.Location = new System.Drawing.Point(30, 58);
            this.tbBoxSize.Name = "tbBoxSize";
            this.tbBoxSize.Size = new System.Drawing.Size(100, 20);
            this.tbBoxSize.TabIndex = 2;
            this.tbBoxSize.Text = "25";
            this.tbBoxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Box Size";
            // 
            // tbMaxXCells
            // 
            this.tbMaxXCells.Location = new System.Drawing.Point(30, 96);
            this.tbMaxXCells.Name = "tbMaxXCells";
            this.tbMaxXCells.Size = new System.Drawing.Size(100, 20);
            this.tbMaxXCells.TabIndex = 4;
            this.tbMaxXCells.Text = "5";
            this.tbMaxXCells.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMaxXCells
            // 
            this.labelMaxXCells.AutoSize = true;
            this.labelMaxXCells.Location = new System.Drawing.Point(149, 99);
            this.labelMaxXCells.Name = "labelMaxXCells";
            this.labelMaxXCells.Size = new System.Drawing.Size(62, 13);
            this.labelMaxXCells.TabIndex = 3;
            this.labelMaxXCells.Text = "Max X Cells";
            // 
            // tbMaxYCells
            // 
            this.tbMaxYCells.Location = new System.Drawing.Point(30, 135);
            this.tbMaxYCells.Name = "tbMaxYCells";
            this.tbMaxYCells.Size = new System.Drawing.Size(100, 20);
            this.tbMaxYCells.TabIndex = 6;
            this.tbMaxYCells.Text = "11";
            this.tbMaxYCells.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMaxYCells
            // 
            this.labelMaxYCells.AutoSize = true;
            this.labelMaxYCells.Location = new System.Drawing.Point(149, 138);
            this.labelMaxYCells.Name = "labelMaxYCells";
            this.labelMaxYCells.Size = new System.Drawing.Size(62, 13);
            this.labelMaxYCells.TabIndex = 5;
            this.labelMaxYCells.Text = "Max Y Cells";
            // 
            // buttonDoThePlaid
            // 
            this.buttonDoThePlaid.Location = new System.Drawing.Point(12, 311);
            this.buttonDoThePlaid.Name = "buttonDoThePlaid";
            this.buttonDoThePlaid.Size = new System.Drawing.Size(334, 68);
            this.buttonDoThePlaid.TabIndex = 7;
            this.buttonDoThePlaid.Text = "Plaid!";
            this.buttonDoThePlaid.UseVisualStyleBackColor = true;
            this.buttonDoThePlaid.Click += new System.EventHandler(this.buttonDoThePlaid_Click);
            // 
            // tbWallpaperNumber
            // 
            this.tbWallpaperNumber.Location = new System.Drawing.Point(30, 177);
            this.tbWallpaperNumber.Name = "tbWallpaperNumber";
            this.tbWallpaperNumber.Size = new System.Drawing.Size(100, 20);
            this.tbWallpaperNumber.TabIndex = 9;
            this.tbWallpaperNumber.Text = "25";
            this.tbWallpaperNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWallpaperNumber
            // 
            this.labelWallpaperNumber.AutoSize = true;
            this.labelWallpaperNumber.Location = new System.Drawing.Point(149, 180);
            this.labelWallpaperNumber.Name = "labelWallpaperNumber";
            this.labelWallpaperNumber.Size = new System.Drawing.Size(108, 13);
            this.labelWallpaperNumber.TabIndex = 8;
            this.labelWallpaperNumber.Text = "Wallpaper Generated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "keywords";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(30, 217);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(100, 20);
            this.tbKeyword.TabIndex = 9;
            this.tbKeyword.Text = "bitcoin";
            this.tbKeyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PlaidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 391);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.tbWallpaperNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWallpaperNumber);
            this.Controls.Add(this.buttonDoThePlaid);
            this.Controls.Add(this.tbMaxYCells);
            this.Controls.Add(this.labelMaxYCells);
            this.Controls.Add(this.tbMaxXCells);
            this.Controls.Add(this.labelMaxXCells);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBoxSize);
            this.Controls.Add(this.cbHorizontalLine);
            this.Controls.Add(this.cbVerticalLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlaidForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox cbVerticalLine;
    private System.Windows.Forms.CheckBox cbHorizontalLine;
    private System.Windows.Forms.TextBox tbBoxSize;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbMaxXCells;
    private System.Windows.Forms.Label labelMaxXCells;
    private System.Windows.Forms.TextBox tbMaxYCells;
    private System.Windows.Forms.Label labelMaxYCells;
    private System.Windows.Forms.Button buttonDoThePlaid;
    private System.Windows.Forms.TextBox tbWallpaperNumber;
    private System.Windows.Forms.Label labelWallpaperNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKeyword;
    }
}

