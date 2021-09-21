
namespace WinUI
{
    partial class RandomFileReaderForm
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
            this.DisplayFileTotalButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RunningTotalLabel = new System.Windows.Forms.Label();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayFileTotalButton
            // 
            this.DisplayFileTotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayFileTotalButton.Location = new System.Drawing.Point(96, 197);
            this.DisplayFileTotalButton.Name = "DisplayFileTotalButton";
            this.DisplayFileTotalButton.Size = new System.Drawing.Size(227, 65);
            this.DisplayFileTotalButton.TabIndex = 0;
            this.DisplayFileTotalButton.Text = "Display File Total and Item Number";
            this.DisplayFileTotalButton.UseVisualStyleBackColor = true;
            this.DisplayFileTotalButton.Click += new System.EventHandler(this.DisplayFileTotalButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(434, 197);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(227, 65);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Of The Numbers: ";
            // 
            // RunningTotalLabel
            // 
            this.RunningTotalLabel.AutoSize = true;
            this.RunningTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RunningTotalLabel.Location = new System.Drawing.Point(253, 75);
            this.RunningTotalLabel.Name = "RunningTotalLabel";
            this.RunningTotalLabel.Size = new System.Drawing.Size(54, 15);
            this.RunningTotalLabel.TabIndex = 3;
            this.RunningTotalLabel.Text = "               ";
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsLabel.Location = new System.Drawing.Point(446, 70);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(96, 20);
            this.ItemsLabel.TabIndex = 4;
            this.ItemsLabel.Text = "Total Items: ";
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalItemsLabel.Location = new System.Drawing.Point(567, 75);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(54, 15);
            this.TotalItemsLabel.TabIndex = 5;
            this.TotalItemsLabel.Text = "               ";
            // 
            // RandomFileReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 294);
            this.Controls.Add(this.TotalItemsLabel);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.RunningTotalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayFileTotalButton);
            this.Name = "RandomFileReaderForm";
            this.Text = "Random File Reader Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayFileTotalButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RunningTotalLabel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label TotalItemsLabel;
    }
}

