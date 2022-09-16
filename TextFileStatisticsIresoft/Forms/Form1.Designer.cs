namespace TextFileStatisticsIresoft
{
    partial class Form1
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
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.inputFileButton = new System.Windows.Forms.Button();
            this.outputFileButton = new System.Windows.Forms.Button();
            this.numberOfLinesLabel = new System.Windows.Forms.Label();
            this.reloadStatsButton = new System.Windows.Forms.Button();
            this.numberOfWordsLabel = new System.Windows.Forms.Label();
            this.numberOfCharsLabel = new System.Windows.Forms.Label();
            this.numberOfSentencesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startFormatButton = new System.Windows.Forms.Button();
            this.formatProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Location = new System.Drawing.Point(34, 11);
            this.inputFileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.Size = new System.Drawing.Size(185, 23);
            this.inputFileTextBox.TabIndex = 0;
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(34, 47);
            this.outputFileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(185, 23);
            this.outputFileTextBox.TabIndex = 1;
            // 
            // inputFileButton
            // 
            this.inputFileButton.Location = new System.Drawing.Point(222, 10);
            this.inputFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(32, 24);
            this.inputFileButton.TabIndex = 2;
            this.inputFileButton.Text = "...";
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.inputFileButton_Click);
            // 
            // outputFileButton
            // 
            this.outputFileButton.Location = new System.Drawing.Point(222, 46);
            this.outputFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.outputFileButton.Name = "outputFileButton";
            this.outputFileButton.Size = new System.Drawing.Size(32, 24);
            this.outputFileButton.TabIndex = 3;
            this.outputFileButton.Text = "...";
            this.outputFileButton.UseVisualStyleBackColor = true;
            this.outputFileButton.Click += new System.EventHandler(this.outputFileButton_Click);
            // 
            // numberOfLinesLabel
            // 
            this.numberOfLinesLabel.AutoSize = true;
            this.numberOfLinesLabel.Location = new System.Drawing.Point(165, 119);
            this.numberOfLinesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfLinesLabel.Name = "numberOfLinesLabel";
            this.numberOfLinesLabel.Size = new System.Drawing.Size(89, 15);
            this.numberOfLinesLabel.TabIndex = 4;
            this.numberOfLinesLabel.Text = "numberOfLines";
            // 
            // reloadStatsButton
            // 
            this.reloadStatsButton.Location = new System.Drawing.Point(87, 83);
            this.reloadStatsButton.Margin = new System.Windows.Forms.Padding(2);
            this.reloadStatsButton.Name = "reloadStatsButton";
            this.reloadStatsButton.Size = new System.Drawing.Size(109, 20);
            this.reloadStatsButton.TabIndex = 5;
            this.reloadStatsButton.Text = "Reload Stats";
            this.reloadStatsButton.UseVisualStyleBackColor = true;
            this.reloadStatsButton.Click += new System.EventHandler(this.reloadStatsButton_Click);
            // 
            // numberOfWordsLabel
            // 
            this.numberOfWordsLabel.AutoSize = true;
            this.numberOfWordsLabel.Location = new System.Drawing.Point(165, 134);
            this.numberOfWordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfWordsLabel.Name = "numberOfWordsLabel";
            this.numberOfWordsLabel.Size = new System.Drawing.Size(96, 15);
            this.numberOfWordsLabel.TabIndex = 6;
            this.numberOfWordsLabel.Text = "numberOfWords";
            this.numberOfWordsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfCharsLabel
            // 
            this.numberOfCharsLabel.AutoSize = true;
            this.numberOfCharsLabel.Location = new System.Drawing.Point(165, 164);
            this.numberOfCharsLabel.Name = "numberOfCharsLabel";
            this.numberOfCharsLabel.Size = new System.Drawing.Size(92, 15);
            this.numberOfCharsLabel.TabIndex = 7;
            this.numberOfCharsLabel.Text = "numberOfChars";
            // 
            // numberOfSentencesLabel
            // 
            this.numberOfSentencesLabel.AutoSize = true;
            this.numberOfSentencesLabel.Location = new System.Drawing.Point(165, 149);
            this.numberOfSentencesLabel.Name = "numberOfSentencesLabel";
            this.numberOfSentencesLabel.Size = new System.Drawing.Size(115, 15);
            this.numberOfSentencesLabel.TabIndex = 8;
            this.numberOfSentencesLabel.Text = "numberOfSentences";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of chars:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number of sentences:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of words:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number of lines:";
            // 
            // startFormatButton
            // 
            this.startFormatButton.Location = new System.Drawing.Point(94, 206);
            this.startFormatButton.Name = "startFormatButton";
            this.startFormatButton.Size = new System.Drawing.Size(89, 23);
            this.startFormatButton.TabIndex = 13;
            this.startFormatButton.Text = "Start Format";
            this.startFormatButton.UseVisualStyleBackColor = true;
            this.startFormatButton.Click += new System.EventHandler(this.startFormatButton_Click);
            // 
            // formatProgressBar
            // 
            this.formatProgressBar.Location = new System.Drawing.Point(12, 235);
            this.formatProgressBar.Name = "formatProgressBar";
            this.formatProgressBar.Size = new System.Drawing.Size(261, 23);
            this.formatProgressBar.Step = 1;
            this.formatProgressBar.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 270);
            this.Controls.Add(this.formatProgressBar);
            this.Controls.Add(this.startFormatButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfSentencesLabel);
            this.Controls.Add(this.numberOfCharsLabel);
            this.Controls.Add(this.numberOfWordsLabel);
            this.Controls.Add(this.reloadStatsButton);
            this.Controls.Add(this.numberOfLinesLabel);
            this.Controls.Add(this.outputFileButton);
            this.Controls.Add(this.inputFileButton);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.inputFileTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox inputFileTextBox;
        private TextBox outputFileTextBox;
        private Button inputFileButton;
        private Button outputFileButton;
        private Label numberOfLinesLabel;
        private Button reloadStatsButton;
        private Label numberOfWordsLabel;
        private Label numberOfCharsLabel;
        private Label numberOfSentencesLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button startFormatButton;
        private ProgressBar formatProgressBar;
    }
}