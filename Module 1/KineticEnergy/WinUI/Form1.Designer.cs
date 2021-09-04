
namespace WinUI
{
    partial class KineticEnergyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MassLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.KineticEnergyLabel = new System.Windows.Forms.Label();
            this.MassTextBox = new System.Windows.Forms.TextBox();
            this.VelocityTextBox = new System.Windows.Forms.TextBox();
            this.KineticEnergyTotalLabel = new System.Windows.Forms.Label();
            this.ButtonToCalculateKineticEnergyTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // MassLabel
            // 
            this.MassLabel.AutoSize = true;
            this.MassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MassLabel.Location = new System.Drawing.Point(13, 53);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(88, 18);
            this.MassLabel.TabIndex = 1;
            this.MassLabel.Text = "Enter Mass:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kinetic Energy Calculator";
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VelocityLabel.Location = new System.Drawing.Point(13, 91);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(102, 18);
            this.VelocityLabel.TabIndex = 3;
            this.VelocityLabel.Text = "Enter Velocity:";
            // 
            // KineticEnergyLabel
            // 
            this.KineticEnergyLabel.AutoSize = true;
            this.KineticEnergyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KineticEnergyLabel.Location = new System.Drawing.Point(12, 144);
            this.KineticEnergyLabel.Name = "KineticEnergyLabel";
            this.KineticEnergyLabel.Size = new System.Drawing.Size(127, 20);
            this.KineticEnergyLabel.TabIndex = 4;
            this.KineticEnergyLabel.Text = "Kinetic Energy = ";
            // 
            // MassTextBox
            // 
            this.MassTextBox.Location = new System.Drawing.Point(129, 54);
            this.MassTextBox.Name = "MassTextBox";
            this.MassTextBox.Size = new System.Drawing.Size(100, 20);
            this.MassTextBox.TabIndex = 5;
            // 
            // VelocityTextBox
            // 
            this.VelocityTextBox.Location = new System.Drawing.Point(129, 92);
            this.VelocityTextBox.Name = "VelocityTextBox";
            this.VelocityTextBox.Size = new System.Drawing.Size(100, 20);
            this.VelocityTextBox.TabIndex = 6;
            // 
            // KineticEnergyTotalLabel
            // 
            this.KineticEnergyTotalLabel.AutoSize = true;
            this.KineticEnergyTotalLabel.Location = new System.Drawing.Point(145, 149);
            this.KineticEnergyTotalLabel.Name = "KineticEnergyTotalLabel";
            this.KineticEnergyTotalLabel.Size = new System.Drawing.Size(100, 13);
            this.KineticEnergyTotalLabel.TabIndex = 7;
            this.KineticEnergyTotalLabel.Text = "                               ";
            // 
            // ButtonToCalculateKineticEnergyTotal
            // 
            this.ButtonToCalculateKineticEnergyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonToCalculateKineticEnergyTotal.Location = new System.Drawing.Point(81, 198);
            this.ButtonToCalculateKineticEnergyTotal.Name = "ButtonToCalculateKineticEnergyTotal";
            this.ButtonToCalculateKineticEnergyTotal.Size = new System.Drawing.Size(147, 36);
            this.ButtonToCalculateKineticEnergyTotal.TabIndex = 8;
            this.ButtonToCalculateKineticEnergyTotal.Text = "Calculate Kinetic Energy";
            this.ButtonToCalculateKineticEnergyTotal.UseVisualStyleBackColor = true;
            this.ButtonToCalculateKineticEnergyTotal.Click += new System.EventHandler(this.ButtonToCalculateKineticEnergyTotal_Click);
            // 
            // KineticEnergyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 252);
            this.Controls.Add(this.ButtonToCalculateKineticEnergyTotal);
            this.Controls.Add(this.KineticEnergyTotalLabel);
            this.Controls.Add(this.VelocityTextBox);
            this.Controls.Add(this.MassTextBox);
            this.Controls.Add(this.KineticEnergyLabel);
            this.Controls.Add(this.VelocityLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MassLabel);
            this.Controls.Add(this.label1);
            this.Name = "KineticEnergyForm";
            this.Text = "Kinetic Energy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.Label KineticEnergyLabel;
        private System.Windows.Forms.TextBox MassTextBox;
        private System.Windows.Forms.TextBox VelocityTextBox;
        private System.Windows.Forms.Label KineticEnergyTotalLabel;
        private System.Windows.Forms.Button ButtonToCalculateKineticEnergyTotal;
    }
}

