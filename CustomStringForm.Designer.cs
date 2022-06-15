
namespace CustomStringApp
{
    partial class CustomStringForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComparisonOperatorLabel = new System.Windows.Forms.Label();
            this.String1TextBox = new System.Windows.Forms.TextBox();
            this.String1ReadJSONButton = new System.Windows.Forms.Button();
            this.String1SaveJSONButton = new System.Windows.Forms.Button();
            this.String2TextBox = new System.Windows.Forms.TextBox();
            this.CompareButton = new System.Windows.Forms.Button();
            this.String2SaveJSONButton = new System.Windows.Forms.Button();
            this.String2ReadJSONButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ConcatenateButton = new System.Windows.Forms.Button();
            this.ConcatenationResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComparisonOperatorLabel
            // 
            this.ComparisonOperatorLabel.Location = new System.Drawing.Point(475, 154);
            this.ComparisonOperatorLabel.Name = "ComparisonOperatorLabel";
            this.ComparisonOperatorLabel.Size = new System.Drawing.Size(50, 27);
            this.ComparisonOperatorLabel.TabIndex = 0;
            this.ComparisonOperatorLabel.Text = "==";
            this.ComparisonOperatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComparisonOperatorLabel.Click += new System.EventHandler(this.ComparisonOperatorLabel_Click);
            // 
            // String1TextBox
            // 
            this.String1TextBox.Location = new System.Drawing.Point(206, 154);
            this.String1TextBox.Name = "String1TextBox";
            this.String1TextBox.Size = new System.Drawing.Size(263, 27);
            this.String1TextBox.TabIndex = 1;
            this.String1TextBox.TextChanged += new System.EventHandler(this.String1TextBox_TextChanged);
            // 
            // String1ReadJSONButton
            // 
            this.String1ReadJSONButton.Location = new System.Drawing.Point(54, 127);
            this.String1ReadJSONButton.Name = "String1ReadJSONButton";
            this.String1ReadJSONButton.Size = new System.Drawing.Size(146, 29);
            this.String1ReadJSONButton.TabIndex = 2;
            this.String1ReadJSONButton.Text = "Read From JSON";
            this.String1ReadJSONButton.UseVisualStyleBackColor = true;
            this.String1ReadJSONButton.Click += new System.EventHandler(this.String1ReadJSONButton_Click);
            // 
            // String1SaveJSONButton
            // 
            this.String1SaveJSONButton.Location = new System.Drawing.Point(54, 180);
            this.String1SaveJSONButton.Name = "String1SaveJSONButton";
            this.String1SaveJSONButton.Size = new System.Drawing.Size(146, 29);
            this.String1SaveJSONButton.TabIndex = 2;
            this.String1SaveJSONButton.Text = "Save To JSON";
            this.String1SaveJSONButton.UseVisualStyleBackColor = true;
            this.String1SaveJSONButton.Click += new System.EventHandler(this.String1SaveJSONButton_Click);
            // 
            // String2TextBox
            // 
            this.String2TextBox.Location = new System.Drawing.Point(531, 154);
            this.String2TextBox.Name = "String2TextBox";
            this.String2TextBox.Size = new System.Drawing.Size(263, 27);
            this.String2TextBox.TabIndex = 1;
            this.String2TextBox.TextChanged += new System.EventHandler(this.String2TextBox_TextChanged);
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(452, 220);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(94, 29);
            this.CompareButton.TabIndex = 3;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // String2SaveJSONButton
            // 
            this.String2SaveJSONButton.Location = new System.Drawing.Point(800, 180);
            this.String2SaveJSONButton.Name = "String2SaveJSONButton";
            this.String2SaveJSONButton.Size = new System.Drawing.Size(146, 29);
            this.String2SaveJSONButton.TabIndex = 4;
            this.String2SaveJSONButton.Text = "Save To JSON";
            this.String2SaveJSONButton.UseVisualStyleBackColor = true;
            this.String2SaveJSONButton.Click += new System.EventHandler(this.String2SaveJSONButton_Click);
            // 
            // String2ReadJSONButton
            // 
            this.String2ReadJSONButton.Location = new System.Drawing.Point(800, 127);
            this.String2ReadJSONButton.Name = "String2ReadJSONButton";
            this.String2ReadJSONButton.Size = new System.Drawing.Size(146, 29);
            this.String2ReadJSONButton.TabIndex = 5;
            this.String2ReadJSONButton.Text = "Read From JSON";
            this.String2ReadJSONButton.UseVisualStyleBackColor = true;
            this.String2ReadJSONButton.Click += new System.EventHandler(this.String2ReadJSONButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ConcatenateButton
            // 
            this.ConcatenateButton.Location = new System.Drawing.Point(363, 340);
            this.ConcatenateButton.Name = "ConcatenateButton";
            this.ConcatenateButton.Size = new System.Drawing.Size(263, 29);
            this.ConcatenateButton.TabIndex = 3;
            this.ConcatenateButton.Text = "Concatenate";
            this.ConcatenateButton.UseVisualStyleBackColor = true;
            this.ConcatenateButton.Click += new System.EventHandler(this.ConcatenateButton_Click);
            // 
            // ConcatenationResultTextBox
            // 
            this.ConcatenationResultTextBox.Location = new System.Drawing.Point(363, 307);
            this.ConcatenationResultTextBox.Name = "ConcatenationResultTextBox";
            this.ConcatenationResultTextBox.Size = new System.Drawing.Size(263, 27);
            this.ConcatenationResultTextBox.TabIndex = 1;
            this.ConcatenationResultTextBox.TextChanged += new System.EventHandler(this.String1TextBox_TextChanged);
            // 
            // CustomStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 402);
            this.Controls.Add(this.String2SaveJSONButton);
            this.Controls.Add(this.String2ReadJSONButton);
            this.Controls.Add(this.ConcatenateButton);
            this.Controls.Add(this.CompareButton);
            this.Controls.Add(this.String1SaveJSONButton);
            this.Controls.Add(this.String1ReadJSONButton);
            this.Controls.Add(this.String2TextBox);
            this.Controls.Add(this.ConcatenationResultTextBox);
            this.Controls.Add(this.String1TextBox);
            this.Controls.Add(this.ComparisonOperatorLabel);
            this.Name = "CustomStringForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComparisonOperatorLabel;
        private System.Windows.Forms.TextBox String1TextBox;
        private System.Windows.Forms.Button String1ReadJSONButton;
        private System.Windows.Forms.Button String1SaveJSONButton;
        private System.Windows.Forms.TextBox String2TextBox;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.Button String2SaveJSONButton;
        private System.Windows.Forms.Button String2ReadJSONButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button ConcatenateButton;
        private System.Windows.Forms.TextBox ConcatenationResultTextBox;
    }
}

