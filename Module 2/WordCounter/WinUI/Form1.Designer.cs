
namespace WinUI
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
            this.EnterPhraseLabel = new System.Windows.Forms.Label();
            this.CountWordButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UserPhraseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterPhraseLabel
            // 
            this.EnterPhraseLabel.AutoSize = true;
            this.EnterPhraseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPhraseLabel.Location = new System.Drawing.Point(40, 58);
            this.EnterPhraseLabel.Name = "EnterPhraseLabel";
            this.EnterPhraseLabel.Size = new System.Drawing.Size(165, 25);
            this.EnterPhraseLabel.TabIndex = 0;
            this.EnterPhraseLabel.Text = "Enter a phrase: ";
            this.EnterPhraseLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CountWordButton
            // 
            this.CountWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountWordButton.Location = new System.Drawing.Point(45, 187);
            this.CountWordButton.Name = "CountWordButton";
            this.CountWordButton.Size = new System.Drawing.Size(206, 89);
            this.CountWordButton.TabIndex = 1;
            this.CountWordButton.Text = "Count Words";
            this.CountWordButton.UseVisualStyleBackColor = true;
            this.CountWordButton.Click += new System.EventHandler(this.CountWordButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(459, 187);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(206, 89);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UserPhraseTextBox
            // 
            this.UserPhraseTextBox.Location = new System.Drawing.Point(253, 64);
            this.UserPhraseTextBox.Name = "UserPhraseTextBox";
            this.UserPhraseTextBox.Size = new System.Drawing.Size(254, 20);
            this.UserPhraseTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 288);
            this.Controls.Add(this.UserPhraseTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CountWordButton);
            this.Controls.Add(this.EnterPhraseLabel);
            this.Name = "Form1";
            this.Text = "Word Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterPhraseLabel;
        private System.Windows.Forms.Button CountWordButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox UserPhraseTextBox;
    }
}

