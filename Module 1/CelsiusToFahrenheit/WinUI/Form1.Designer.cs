
namespace WinUI
{
    partial class formForCtoF
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
            this.ButtonToDisplayConversion = new System.Windows.Forms.Button();
            this.LabelToGreetUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonToDisplayConversion
            // 
            this.ButtonToDisplayConversion.Location = new System.Drawing.Point(91, 269);
            this.ButtonToDisplayConversion.Name = "ButtonToDisplayConversion";
            this.ButtonToDisplayConversion.Size = new System.Drawing.Size(132, 39);
            this.ButtonToDisplayConversion.TabIndex = 0;
            this.ButtonToDisplayConversion.Text = "Display Conversion";
            this.ButtonToDisplayConversion.UseVisualStyleBackColor = true;
            this.ButtonToDisplayConversion.Click += new System.EventHandler(this.buttonToDisplayMessage_Click);
            // 
            // LabelToGreetUser
            // 
            this.LabelToGreetUser.AutoSize = true;
            this.LabelToGreetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelToGreetUser.Location = new System.Drawing.Point(28, 23);
            this.LabelToGreetUser.Name = "LabelToGreetUser";
            this.LabelToGreetUser.Size = new System.Drawing.Size(287, 16);
            this.LabelToGreetUser.TabIndex = 1;
            this.LabelToGreetUser.Text = "Welcome To Celsius to Fahrenheit Conversion!";
            this.LabelToGreetUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // formForCtoF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 320);
            this.Controls.Add(this.LabelToGreetUser);
            this.Controls.Add(this.ButtonToDisplayConversion);
            this.Name = "formForCtoF";
            this.Text = "Conversion Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonToDisplayConversion;
        private System.Windows.Forms.Label LabelToGreetUser;
    }
}

