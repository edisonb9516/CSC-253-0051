
namespace WinUI
{
    partial class RandomNumFileWriterForm
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
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.CreateFileButton = new System.Windows.Forms.Button();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(23, 35);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(656, 24);
            this.InstructionsLabel.TabIndex = 0;
            this.InstructionsLabel.Text = "Please Enter the number of random numbers you would like to write into a file\r\n";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFileButton.Location = new System.Drawing.Point(90, 184);
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(181, 56);
            this.CreateFileButton.TabIndex = 1;
            this.CreateFileButton.Text = "Create File";
            this.CreateFileButton.UseVisualStyleBackColor = true;
            this.CreateFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(242, 105);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(196, 20);
            this.userInputTextBox.TabIndex = 2;
            this.userInputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(414, 184);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(181, 56);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RandomNumFileWriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 282);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.CreateFileButton);
            this.Controls.Add(this.InstructionsLabel);
            this.Name = "RandomNumFileWriterForm";
            this.Text = "Random Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

