
namespace WinUI
{
    partial class AreaForm
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
            this.CircleAreaTitleLabel = new System.Windows.Forms.Label();
            this.RectangleAreaTitleLabel = new System.Windows.Forms.Label();
            this.CylinderAreaTitleLabel = new System.Windows.Forms.Label();
            this.EnterRadiusLabel = new System.Windows.Forms.Label();
            this.CircleRadiusTextBox = new System.Windows.Forms.TextBox();
            this.CircleAreaTotalTitleLabel = new System.Windows.Forms.Label();
            this.CircleAreaTotalLabel = new System.Windows.Forms.Label();
            this.RectangleAreaTotalLabel = new System.Windows.Forms.Label();
            this.RectangleAreaTotalTitleLabel = new System.Windows.Forms.Label();
            this.CylinderAreaTotalLabel = new System.Windows.Forms.Label();
            this.CylinderAreaTotalTitleLabel = new System.Windows.Forms.Label();
            this.EnterWidthTextBox = new System.Windows.Forms.TextBox();
            this.EnterWidthLabel = new System.Windows.Forms.Label();
            this.EnterLengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.EnterCylinderRadiusTextBox = new System.Windows.Forms.TextBox();
            this.CylinderRadiusLabel = new System.Windows.Forms.Label();
            this.EnterCylinderHeightTextBox = new System.Windows.Forms.TextBox();
            this.CylinderHeightLabel = new System.Windows.Forms.Label();
            this.CalculateCircleButton = new System.Windows.Forms.Button();
            this.CalculateRectangleButton = new System.Windows.Forms.Button();
            this.CalculateCylinderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CircleAreaTitleLabel
            // 
            this.CircleAreaTitleLabel.AutoSize = true;
            this.CircleAreaTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleAreaTitleLabel.Location = new System.Drawing.Point(61, 53);
            this.CircleAreaTitleLabel.Name = "CircleAreaTitleLabel";
            this.CircleAreaTitleLabel.Size = new System.Drawing.Size(118, 25);
            this.CircleAreaTitleLabel.TabIndex = 0;
            this.CircleAreaTitleLabel.Text = "Circle Area";
            // 
            // RectangleAreaTitleLabel
            // 
            this.RectangleAreaTitleLabel.AutoSize = true;
            this.RectangleAreaTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectangleAreaTitleLabel.Location = new System.Drawing.Point(302, 53);
            this.RectangleAreaTitleLabel.Name = "RectangleAreaTitleLabel";
            this.RectangleAreaTitleLabel.Size = new System.Drawing.Size(160, 25);
            this.RectangleAreaTitleLabel.TabIndex = 1;
            this.RectangleAreaTitleLabel.Text = "Rectangle Area";
            // 
            // CylinderAreaTitleLabel
            // 
            this.CylinderAreaTitleLabel.AutoSize = true;
            this.CylinderAreaTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylinderAreaTitleLabel.Location = new System.Drawing.Point(587, 53);
            this.CylinderAreaTitleLabel.Name = "CylinderAreaTitleLabel";
            this.CylinderAreaTitleLabel.Size = new System.Drawing.Size(153, 25);
            this.CylinderAreaTitleLabel.TabIndex = 2;
            this.CylinderAreaTitleLabel.Text = "Cyclinder Area";
            // 
            // EnterRadiusLabel
            // 
            this.EnterRadiusLabel.AutoSize = true;
            this.EnterRadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterRadiusLabel.Location = new System.Drawing.Point(12, 124);
            this.EnterRadiusLabel.Name = "EnterRadiusLabel";
            this.EnterRadiusLabel.Size = new System.Drawing.Size(88, 16);
            this.EnterRadiusLabel.TabIndex = 3;
            this.EnterRadiusLabel.Text = "Enter Radius:";
            // 
            // CircleRadiusTextBox
            // 
            this.CircleRadiusTextBox.Location = new System.Drawing.Point(106, 123);
            this.CircleRadiusTextBox.Name = "CircleRadiusTextBox";
            this.CircleRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.CircleRadiusTextBox.TabIndex = 4;
            // 
            // CircleAreaTotalTitleLabel
            // 
            this.CircleAreaTotalTitleLabel.AutoSize = true;
            this.CircleAreaTotalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleAreaTotalTitleLabel.Location = new System.Drawing.Point(12, 197);
            this.CircleAreaTotalTitleLabel.Name = "CircleAreaTotalTitleLabel";
            this.CircleAreaTotalTitleLabel.Size = new System.Drawing.Size(60, 20);
            this.CircleAreaTotalTitleLabel.TabIndex = 5;
            this.CircleAreaTotalTitleLabel.Text = "Area = ";
            // 
            // CircleAreaTotalLabel
            // 
            this.CircleAreaTotalLabel.AutoSize = true;
            this.CircleAreaTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CircleAreaTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleAreaTotalLabel.Location = new System.Drawing.Point(78, 197);
            this.CircleAreaTotalLabel.Name = "CircleAreaTotalLabel";
            this.CircleAreaTotalLabel.Size = new System.Drawing.Size(75, 22);
            this.CircleAreaTotalLabel.TabIndex = 6;
            this.CircleAreaTotalLabel.Text = "                ";
            // 
            // RectangleAreaTotalLabel
            // 
            this.RectangleAreaTotalLabel.AutoSize = true;
            this.RectangleAreaTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectangleAreaTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectangleAreaTotalLabel.Location = new System.Drawing.Point(358, 197);
            this.RectangleAreaTotalLabel.Name = "RectangleAreaTotalLabel";
            this.RectangleAreaTotalLabel.Size = new System.Drawing.Size(75, 22);
            this.RectangleAreaTotalLabel.TabIndex = 8;
            this.RectangleAreaTotalLabel.Text = "                ";
            // 
            // RectangleAreaTotalTitleLabel
            // 
            this.RectangleAreaTotalTitleLabel.AutoSize = true;
            this.RectangleAreaTotalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectangleAreaTotalTitleLabel.Location = new System.Drawing.Point(292, 197);
            this.RectangleAreaTotalTitleLabel.Name = "RectangleAreaTotalTitleLabel";
            this.RectangleAreaTotalTitleLabel.Size = new System.Drawing.Size(60, 20);
            this.RectangleAreaTotalTitleLabel.TabIndex = 7;
            this.RectangleAreaTotalTitleLabel.Text = "Area = ";
            // 
            // CylinderAreaTotalLabel
            // 
            this.CylinderAreaTotalLabel.AutoSize = true;
            this.CylinderAreaTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CylinderAreaTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylinderAreaTotalLabel.Location = new System.Drawing.Point(625, 197);
            this.CylinderAreaTotalLabel.Name = "CylinderAreaTotalLabel";
            this.CylinderAreaTotalLabel.Size = new System.Drawing.Size(75, 22);
            this.CylinderAreaTotalLabel.TabIndex = 10;
            this.CylinderAreaTotalLabel.Text = "                ";
            // 
            // CylinderAreaTotalTitleLabel
            // 
            this.CylinderAreaTotalTitleLabel.AutoSize = true;
            this.CylinderAreaTotalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylinderAreaTotalTitleLabel.Location = new System.Drawing.Point(559, 197);
            this.CylinderAreaTotalTitleLabel.Name = "CylinderAreaTotalTitleLabel";
            this.CylinderAreaTotalTitleLabel.Size = new System.Drawing.Size(60, 20);
            this.CylinderAreaTotalTitleLabel.TabIndex = 9;
            this.CylinderAreaTotalTitleLabel.Text = "Area = ";
            // 
            // EnterWidthTextBox
            // 
            this.EnterWidthTextBox.Location = new System.Drawing.Point(387, 122);
            this.EnterWidthTextBox.Name = "EnterWidthTextBox";
            this.EnterWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnterWidthTextBox.TabIndex = 12;
            // 
            // EnterWidthLabel
            // 
            this.EnterWidthLabel.AutoSize = true;
            this.EnterWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterWidthLabel.Location = new System.Drawing.Point(293, 123);
            this.EnterWidthLabel.Name = "EnterWidthLabel";
            this.EnterWidthLabel.Size = new System.Drawing.Size(79, 16);
            this.EnterWidthLabel.TabIndex = 11;
            this.EnterWidthLabel.Text = "Enter Width:";
            // 
            // EnterLengthTextBox
            // 
            this.EnterLengthTextBox.Location = new System.Drawing.Point(387, 158);
            this.EnterLengthTextBox.Name = "EnterLengthTextBox";
            this.EnterLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnterLengthTextBox.TabIndex = 14;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthLabel.Location = new System.Drawing.Point(293, 159);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(85, 16);
            this.LengthLabel.TabIndex = 13;
            this.LengthLabel.Text = "Enter Length:";
            // 
            // EnterCylinderRadiusTextBox
            // 
            this.EnterCylinderRadiusTextBox.Location = new System.Drawing.Point(654, 121);
            this.EnterCylinderRadiusTextBox.Name = "EnterCylinderRadiusTextBox";
            this.EnterCylinderRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnterCylinderRadiusTextBox.TabIndex = 16;
            // 
            // CylinderRadiusLabel
            // 
            this.CylinderRadiusLabel.AutoSize = true;
            this.CylinderRadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylinderRadiusLabel.Location = new System.Drawing.Point(560, 122);
            this.CylinderRadiusLabel.Name = "CylinderRadiusLabel";
            this.CylinderRadiusLabel.Size = new System.Drawing.Size(88, 16);
            this.CylinderRadiusLabel.TabIndex = 15;
            this.CylinderRadiusLabel.Text = "Enter Radius:";
            // 
            // EnterCylinderHeightTextBox
            // 
            this.EnterCylinderHeightTextBox.Location = new System.Drawing.Point(654, 158);
            this.EnterCylinderHeightTextBox.Name = "EnterCylinderHeightTextBox";
            this.EnterCylinderHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnterCylinderHeightTextBox.TabIndex = 18;
            // 
            // CylinderHeightLabel
            // 
            this.CylinderHeightLabel.AutoSize = true;
            this.CylinderHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylinderHeightLabel.Location = new System.Drawing.Point(560, 159);
            this.CylinderHeightLabel.Name = "CylinderHeightLabel";
            this.CylinderHeightLabel.Size = new System.Drawing.Size(84, 16);
            this.CylinderHeightLabel.TabIndex = 17;
            this.CylinderHeightLabel.Text = "Enter Height:";
            // 
            // CalculateCircleButton
            // 
            this.CalculateCircleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateCircleButton.Location = new System.Drawing.Point(53, 269);
            this.CalculateCircleButton.Name = "CalculateCircleButton";
            this.CalculateCircleButton.Size = new System.Drawing.Size(153, 62);
            this.CalculateCircleButton.TabIndex = 19;
            this.CalculateCircleButton.Text = "Calculate Circle Area";
            this.CalculateCircleButton.UseVisualStyleBackColor = true;
            this.CalculateCircleButton.Click += new System.EventHandler(this.CalculateCircleButton_Click);
            // 
            // CalculateRectangleButton
            // 
            this.CalculateRectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateRectangleButton.Location = new System.Drawing.Point(334, 269);
            this.CalculateRectangleButton.Name = "CalculateRectangleButton";
            this.CalculateRectangleButton.Size = new System.Drawing.Size(153, 62);
            this.CalculateRectangleButton.TabIndex = 20;
            this.CalculateRectangleButton.Text = "Calculate Rectangle Area";
            this.CalculateRectangleButton.UseVisualStyleBackColor = true;
            this.CalculateRectangleButton.Click += new System.EventHandler(this.CalculateRectangleButton_Click);
            // 
            // CalculateCylinderButton
            // 
            this.CalculateCylinderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateCylinderButton.Location = new System.Drawing.Point(601, 269);
            this.CalculateCylinderButton.Name = "CalculateCylinderButton";
            this.CalculateCylinderButton.Size = new System.Drawing.Size(153, 62);
            this.CalculateCylinderButton.TabIndex = 21;
            this.CalculateCylinderButton.Text = "Calculate Cylinder Area";
            this.CalculateCylinderButton.UseVisualStyleBackColor = true;
            this.CalculateCylinderButton.Click += new System.EventHandler(this.CalculateCylinderButton_Click);
            // 
            // AreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.CalculateCylinderButton);
            this.Controls.Add(this.CalculateRectangleButton);
            this.Controls.Add(this.CalculateCircleButton);
            this.Controls.Add(this.EnterCylinderHeightTextBox);
            this.Controls.Add(this.CylinderHeightLabel);
            this.Controls.Add(this.EnterCylinderRadiusTextBox);
            this.Controls.Add(this.CylinderRadiusLabel);
            this.Controls.Add(this.EnterLengthTextBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.EnterWidthTextBox);
            this.Controls.Add(this.EnterWidthLabel);
            this.Controls.Add(this.CylinderAreaTotalLabel);
            this.Controls.Add(this.CylinderAreaTotalTitleLabel);
            this.Controls.Add(this.RectangleAreaTotalLabel);
            this.Controls.Add(this.RectangleAreaTotalTitleLabel);
            this.Controls.Add(this.CircleAreaTotalLabel);
            this.Controls.Add(this.CircleAreaTotalTitleLabel);
            this.Controls.Add(this.CircleRadiusTextBox);
            this.Controls.Add(this.EnterRadiusLabel);
            this.Controls.Add(this.CylinderAreaTitleLabel);
            this.Controls.Add(this.RectangleAreaTitleLabel);
            this.Controls.Add(this.CircleAreaTitleLabel);
            this.Name = "AreaForm";
            this.Text = "Area Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CircleAreaTitleLabel;
        private System.Windows.Forms.Label RectangleAreaTitleLabel;
        private System.Windows.Forms.Label CylinderAreaTitleLabel;
        private System.Windows.Forms.Label EnterRadiusLabel;
        private System.Windows.Forms.TextBox CircleRadiusTextBox;
        private System.Windows.Forms.Label CircleAreaTotalTitleLabel;
        private System.Windows.Forms.Label CircleAreaTotalLabel;
        private System.Windows.Forms.Label RectangleAreaTotalLabel;
        private System.Windows.Forms.Label RectangleAreaTotalTitleLabel;
        private System.Windows.Forms.Label CylinderAreaTotalLabel;
        private System.Windows.Forms.Label CylinderAreaTotalTitleLabel;
        private System.Windows.Forms.TextBox EnterWidthTextBox;
        private System.Windows.Forms.Label EnterWidthLabel;
        private System.Windows.Forms.TextBox EnterLengthTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox EnterCylinderRadiusTextBox;
        private System.Windows.Forms.Label CylinderRadiusLabel;
        private System.Windows.Forms.TextBox EnterCylinderHeightTextBox;
        private System.Windows.Forms.Label CylinderHeightLabel;
        private System.Windows.Forms.Button CalculateCircleButton;
        private System.Windows.Forms.Button CalculateRectangleButton;
        private System.Windows.Forms.Button CalculateCylinderButton;
    }
}

