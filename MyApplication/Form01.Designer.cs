namespace MyApplication
{
	partial class Form01
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

		#region Windows Form Designer generated code:
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(212, 81);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(178, 24);
            this.testTextBox.TabIndex = 5;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(69, 88);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(107, 17);
            this.testLabel.TabIndex = 4;
            this.testLabel.Text = "zeinab samani";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(72, 171);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(151, 39);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "zeinab samani";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // Form01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 603);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.testButton);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(509, 248);
            this.Name = "Form01";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion /Windows Form Designer generated code

        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button testButton;
    }
}
