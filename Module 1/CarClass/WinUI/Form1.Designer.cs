
namespace WinUI
{
    partial class CarClassSim
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
            this.AccelerationButton = new System.Windows.Forms.Button();
            this.BrakeButton = new System.Windows.Forms.Button();
            this.CarMakeLabel = new System.Windows.Forms.Label();
            this.CarModelLabel = new System.Windows.Forms.Label();
            this.CarYearLabel = new System.Windows.Forms.Label();
            this.CarMakeTextBox = new System.Windows.Forms.TextBox();
            this.CarModelTextBox = new System.Windows.Forms.TextBox();
            this.CarYearTextBox = new System.Windows.Forms.TextBox();
            this.AcceptCarSpecsButton = new System.Windows.Forms.Button();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.DisplaySpeedLabel = new System.Windows.Forms.Label();
            this.DisplayCarLabel = new System.Windows.Forms.Label();
            this.DisplayCarMakeLabel = new System.Windows.Forms.Label();
            this.DisplayCarModelLabel = new System.Windows.Forms.Label();
            this.DisplayCarYearLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CarSpeedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccelerationButton
            // 
            this.AccelerationButton.Location = new System.Drawing.Point(58, 360);
            this.AccelerationButton.Name = "AccelerationButton";
            this.AccelerationButton.Size = new System.Drawing.Size(179, 56);
            this.AccelerationButton.TabIndex = 0;
            this.AccelerationButton.Text = "Accelerate";
            this.AccelerationButton.UseVisualStyleBackColor = true;
            this.AccelerationButton.Click += new System.EventHandler(this.AccelerationButton_Click);
            // 
            // BrakeButton
            // 
            this.BrakeButton.Location = new System.Drawing.Point(533, 369);
            this.BrakeButton.Name = "BrakeButton";
            this.BrakeButton.Size = new System.Drawing.Size(209, 47);
            this.BrakeButton.TabIndex = 1;
            this.BrakeButton.Text = "Brake";
            this.BrakeButton.UseVisualStyleBackColor = true;
            this.BrakeButton.Click += new System.EventHandler(this.BrakeButton_Click);
            // 
            // CarMakeLabel
            // 
            this.CarMakeLabel.AutoSize = true;
            this.CarMakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarMakeLabel.Location = new System.Drawing.Point(51, 37);
            this.CarMakeLabel.Name = "CarMakeLabel";
            this.CarMakeLabel.Size = new System.Drawing.Size(81, 18);
            this.CarMakeLabel.TabIndex = 2;
            this.CarMakeLabel.Text = "Car Make: ";
            // 
            // CarModelLabel
            // 
            this.CarModelLabel.AutoSize = true;
            this.CarModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarModelLabel.Location = new System.Drawing.Point(52, 74);
            this.CarModelLabel.Name = "CarModelLabel";
            this.CarModelLabel.Size = new System.Drawing.Size(81, 18);
            this.CarModelLabel.TabIndex = 3;
            this.CarModelLabel.Text = "Car Model:";
            // 
            // CarYearLabel
            // 
            this.CarYearLabel.AutoSize = true;
            this.CarYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarYearLabel.Location = new System.Drawing.Point(52, 106);
            this.CarYearLabel.Name = "CarYearLabel";
            this.CarYearLabel.Size = new System.Drawing.Size(74, 18);
            this.CarYearLabel.TabIndex = 4;
            this.CarYearLabel.Text = "Car Year: ";
            // 
            // CarMakeTextBox
            // 
            this.CarMakeTextBox.Location = new System.Drawing.Point(140, 38);
            this.CarMakeTextBox.Name = "CarMakeTextBox";
            this.CarMakeTextBox.Size = new System.Drawing.Size(138, 20);
            this.CarMakeTextBox.TabIndex = 5;
            this.CarMakeTextBox.TextChanged += new System.EventHandler(this.CarMakeTextBox_TextChanged);
            // 
            // CarModelTextBox
            // 
            this.CarModelTextBox.Location = new System.Drawing.Point(139, 74);
            this.CarModelTextBox.Name = "CarModelTextBox";
            this.CarModelTextBox.Size = new System.Drawing.Size(139, 20);
            this.CarModelTextBox.TabIndex = 6;
            this.CarModelTextBox.TextChanged += new System.EventHandler(this.CarModelTextBox_TextChanged);
            // 
            // CarYearTextBox
            // 
            this.CarYearTextBox.Location = new System.Drawing.Point(139, 107);
            this.CarYearTextBox.Name = "CarYearTextBox";
            this.CarYearTextBox.Size = new System.Drawing.Size(139, 20);
            this.CarYearTextBox.TabIndex = 7;
            this.CarYearTextBox.TextChanged += new System.EventHandler(this.CarYearTextBox_TextChanged);
            // 
            // AcceptCarSpecsButton
            // 
            this.AcceptCarSpecsButton.Location = new System.Drawing.Point(341, 60);
            this.AcceptCarSpecsButton.Name = "AcceptCarSpecsButton";
            this.AcceptCarSpecsButton.Size = new System.Drawing.Size(165, 46);
            this.AcceptCarSpecsButton.TabIndex = 8;
            this.AcceptCarSpecsButton.Text = "Enter Car Specifications";
            this.AcceptCarSpecsButton.UseVisualStyleBackColor = true;
            this.AcceptCarSpecsButton.Click += new System.EventHandler(this.AcceptCarSpecsButton_Click);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.Location = new System.Drawing.Point(335, 211);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(92, 31);
            this.SpeedLabel.TabIndex = 9;
            this.SpeedLabel.Text = "Speed";
            // 
            // DisplaySpeedLabel
            // 
            this.DisplaySpeedLabel.AutoSize = true;
            this.DisplaySpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplaySpeedLabel.Location = new System.Drawing.Point(362, 282);
            this.DisplaySpeedLabel.Name = "DisplaySpeedLabel";
            this.DisplaySpeedLabel.Size = new System.Drawing.Size(0, 25);
            this.DisplaySpeedLabel.TabIndex = 10;
            // 
            // DisplayCarLabel
            // 
            this.DisplayCarLabel.AutoSize = true;
            this.DisplayCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCarLabel.Location = new System.Drawing.Point(578, 33);
            this.DisplayCarLabel.Name = "DisplayCarLabel";
            this.DisplayCarLabel.Size = new System.Drawing.Size(164, 24);
            this.DisplayCarLabel.TabIndex = 11;
            this.DisplayCarLabel.Text = "Car Specifications:";
            // 
            // DisplayCarMakeLabel
            // 
            this.DisplayCarMakeLabel.AutoSize = true;
            this.DisplayCarMakeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayCarMakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCarMakeLabel.Location = new System.Drawing.Point(598, 78);
            this.DisplayCarMakeLabel.Name = "DisplayCarMakeLabel";
            this.DisplayCarMakeLabel.Size = new System.Drawing.Size(111, 22);
            this.DisplayCarMakeLabel.TabIndex = 12;
            this.DisplayCarMakeLabel.Text = "                         ";
            // 
            // DisplayCarModelLabel
            // 
            this.DisplayCarModelLabel.AutoSize = true;
            this.DisplayCarModelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayCarModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCarModelLabel.Location = new System.Drawing.Point(598, 129);
            this.DisplayCarModelLabel.Name = "DisplayCarModelLabel";
            this.DisplayCarModelLabel.Size = new System.Drawing.Size(111, 22);
            this.DisplayCarModelLabel.TabIndex = 13;
            this.DisplayCarModelLabel.Text = "                         ";
            // 
            // DisplayCarYearLabel
            // 
            this.DisplayCarYearLabel.AutoSize = true;
            this.DisplayCarYearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayCarYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCarYearLabel.Location = new System.Drawing.Point(598, 178);
            this.DisplayCarYearLabel.Name = "DisplayCarYearLabel";
            this.DisplayCarYearLabel.Size = new System.Drawing.Size(111, 22);
            this.DisplayCarYearLabel.TabIndex = 14;
            this.DisplayCarYearLabel.Text = "                         ";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(329, 393);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 45);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CarSpeedLabel
            // 
            this.CarSpeedLabel.AutoSize = true;
            this.CarSpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarSpeedLabel.Location = new System.Drawing.Point(341, 280);
            this.CarSpeedLabel.Name = "CarSpeedLabel";
            this.CarSpeedLabel.Size = new System.Drawing.Size(110, 27);
            this.CarSpeedLabel.TabIndex = 16;
            this.CarSpeedLabel.Text = "                ";
            // 
            // CarClassSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarSpeedLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayCarYearLabel);
            this.Controls.Add(this.DisplayCarModelLabel);
            this.Controls.Add(this.DisplayCarMakeLabel);
            this.Controls.Add(this.DisplayCarLabel);
            this.Controls.Add(this.DisplaySpeedLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.AcceptCarSpecsButton);
            this.Controls.Add(this.CarYearTextBox);
            this.Controls.Add(this.CarModelTextBox);
            this.Controls.Add(this.CarMakeTextBox);
            this.Controls.Add(this.CarYearLabel);
            this.Controls.Add(this.CarModelLabel);
            this.Controls.Add(this.CarMakeLabel);
            this.Controls.Add(this.BrakeButton);
            this.Controls.Add(this.AccelerationButton);
            this.Name = "CarClassSim";
            this.Text = "Car Driving Simulator";
            this.Load += new System.EventHandler(this.CarClassSim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AccelerationButton;
        private System.Windows.Forms.Button BrakeButton;
        private System.Windows.Forms.Label CarMakeLabel;
        private System.Windows.Forms.Label CarModelLabel;
        private System.Windows.Forms.Label CarYearLabel;
        private System.Windows.Forms.TextBox CarMakeTextBox;
        private System.Windows.Forms.TextBox CarModelTextBox;
        private System.Windows.Forms.TextBox CarYearTextBox;
        private System.Windows.Forms.Button AcceptCarSpecsButton;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label DisplaySpeedLabel;
        private System.Windows.Forms.Label DisplayCarLabel;
        private System.Windows.Forms.Label DisplayCarMakeLabel;
        private System.Windows.Forms.Label DisplayCarModelLabel;
        private System.Windows.Forms.Label DisplayCarYearLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label CarSpeedLabel;
    }
}

