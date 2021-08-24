
namespace Celsius_to_Fahrenheit
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.lbConversionTable = new System.Windows.Forms.ListBox();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(278, 361);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(195, 48);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Start Program";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(191, 27);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(350, 24);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.Text = "Click the button below to start conversion";
            this.lblHelloWorld.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHelloWorld.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbConversionTable
            // 
            this.lbConversionTable.FormattingEnabled = true;
            this.lbConversionTable.Location = new System.Drawing.Point(241, 135);
            this.lbConversionTable.Name = "lbConversionTable";
            this.lbConversionTable.Size = new System.Drawing.Size(270, 186);
            this.lbConversionTable.TabIndex = 2;
            this.lbConversionTable.SelectedIndexChanged += new System.EventHandler(this.ConversionTable_SelectedIndexChanged);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(646, 361);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(115, 47);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.lbConversionTable);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.ListBox lbConversionTable;
        private System.Windows.Forms.Button Exit;
    }
}

