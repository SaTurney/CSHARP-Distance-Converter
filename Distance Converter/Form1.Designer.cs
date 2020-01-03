namespace Distance_Converter
{
    partial class distanceConverter
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
            this.enterLabel = new System.Windows.Forms.Label();
            this.enterBox = new System.Windows.Forms.TextBox();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.fromBox = new System.Windows.Forms.ListBox();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.toBox = new System.Windows.Forms.ListBox();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.convertedDistance = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Location = new System.Drawing.Point(36, 30);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(182, 17);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Enter a distance to convert:";
            // 
            // enterBox
            // 
            this.enterBox.Location = new System.Drawing.Point(224, 30);
            this.enterBox.Name = "enterBox";
            this.enterBox.Size = new System.Drawing.Size(100, 22);
            this.enterBox.TabIndex = 1;
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromBox);
            this.fromGroupBox.Location = new System.Drawing.Point(39, 86);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(197, 204);
            this.fromGroupBox.TabIndex = 2;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From";
            // 
            // fromBox
            // 
            this.fromBox.FormattingEnabled = true;
            this.fromBox.ItemHeight = 16;
            this.fromBox.Items.AddRange(new object[] {
            "Inch",
            "Feet",
            "Yards"});
            this.fromBox.Location = new System.Drawing.Point(35, 57);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(116, 68);
            this.fromBox.TabIndex = 0;
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.toBox);
            this.toGroupBox.Location = new System.Drawing.Point(272, 86);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(197, 204);
            this.toGroupBox.TabIndex = 3;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // toBox
            // 
            this.toBox.FormattingEnabled = true;
            this.toBox.ItemHeight = 16;
            this.toBox.Items.AddRange(new object[] {
            "Inch",
            "Feet",
            "Yards"});
            this.toBox.Location = new System.Drawing.Point(36, 57);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(116, 68);
            this.toBox.TabIndex = 1;
            // 
            // convertedLabel
            // 
            this.convertedLabel.AutoSize = true;
            this.convertedLabel.Location = new System.Drawing.Point(71, 320);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(136, 17);
            this.convertedLabel.TabIndex = 4;
            this.convertedLabel.Text = "Converted Distance:";
            // 
            // convertedDistance
            // 
            this.convertedDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedDistance.Location = new System.Drawing.Point(224, 319);
            this.convertedDistance.Name = "convertedDistance";
            this.convertedDistance.Size = new System.Drawing.Size(161, 47);
            this.convertedDistance.TabIndex = 5;
            this.convertedDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(39, 391);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(168, 29);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(256, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(168, 29);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // distanceConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 460);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedDistance);
            this.Controls.Add(this.convertedLabel);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.fromGroupBox);
            this.Controls.Add(this.enterBox);
            this.Controls.Add(this.enterLabel);
            this.Name = "distanceConverter";
            this.Text = "Distance Converter";
            this.fromGroupBox.ResumeLayout(false);
            this.toGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox enterBox;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.ListBox fromBox;
        private System.Windows.Forms.ListBox toBox;
        private System.Windows.Forms.Label convertedDistance;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

