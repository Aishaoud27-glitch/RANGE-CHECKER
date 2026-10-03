namespace RANGE_CHECKER
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.decisionTitleLabel = new System.Windows.Forms.Label();
            this.decisionTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(77, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(202, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Range Checker Application";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(77, 84);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(328, 20);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Enter an integer in the range of 1 througth 10";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(120, 129);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(177, 26);
            this.numberTextBox.TabIndex = 2;
            // 
            // decisionTitleLabel
            // 
            this.decisionTitleLabel.AutoSize = true;
            this.decisionTitleLabel.Location = new System.Drawing.Point(146, 178);
            this.decisionTitleLabel.Name = "decisionTitleLabel";
            this.decisionTitleLabel.Size = new System.Drawing.Size(122, 20);
            this.decisionTitleLabel.TabIndex = 3;
            this.decisionTitleLabel.Text = "Range Decision";
            // 
            // decisionTextBox
            // 
            this.decisionTextBox.Location = new System.Drawing.Point(81, 222);
            this.decisionTextBox.Name = "decisionTextBox";
            this.decisionTextBox.Size = new System.Drawing.Size(264, 26);
            this.decisionTextBox.TabIndex = 4;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(58, 312);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(126, 77);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check Qualification";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(215, 312);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 37);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(210, 355);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.decisionTextBox);
            this.Controls.Add(this.decisionTitleLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Range Checker Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label decisionTitleLabel;
        private System.Windows.Forms.TextBox decisionTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

