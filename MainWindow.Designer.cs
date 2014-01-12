namespace project1 {
  partial class PrimalityTester {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.inputNumber = new System.Windows.Forms.TextBox();
      this.probabilityTextBox = new System.Windows.Forms.TextBox();
      this.solve = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // inputNumber
      // 
      this.inputNumber.Location = new System.Drawing.Point(13, 12);
      this.inputNumber.Name = "inputNumber";
      this.inputNumber.Size = new System.Drawing.Size(260, 20);
      this.inputNumber.TabIndex = 0;
      // 
      // probabilityTextBox
      // 
      this.probabilityTextBox.Location = new System.Drawing.Point(13, 38);
      this.probabilityTextBox.Name = "probabilityTextBox";
      this.probabilityTextBox.Size = new System.Drawing.Size(260, 20);
      this.probabilityTextBox.TabIndex = 1;
      // 
      // solve
      // 
      this.solve.Location = new System.Drawing.Point(12, 64);
      this.solve.Name = "solve";
      this.solve.Size = new System.Drawing.Size(75, 23);
      this.solve.TabIndex = 2;
      this.solve.Text = "Solve";
      this.solve.UseVisualStyleBackColor = true;
      this.solve.Click += new System.EventHandler(this.buttonSolve);
      // 
      // PrimalityTester
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 94);
      this.Controls.Add(this.solve);
      this.Controls.Add(this.probabilityTextBox);
      this.Controls.Add(this.inputNumber);
      this.Name = "PrimalityTester";
      this.Text = "Primality Tester";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox inputNumber;
    private System.Windows.Forms.TextBox probabilityTextBox;
    private System.Windows.Forms.Button solve;
  }
}

