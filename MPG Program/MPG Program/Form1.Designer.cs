namespace MPG_Program
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
            this.labelMiles = new System.Windows.Forms.Label();
            this.labelGas = new System.Windows.Forms.Label();
            this.boxGas = new System.Windows.Forms.TextBox();
            this.boxMiles = new System.Windows.Forms.TextBox();
            this.labelMPGOutput = new System.Windows.Forms.Label();
            this.labelMPG = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMiles
            // 
            this.labelMiles.AutoSize = true;
            this.labelMiles.Location = new System.Drawing.Point(258, 85);
            this.labelMiles.Name = "labelMiles";
            this.labelMiles.Size = new System.Drawing.Size(65, 13);
            this.labelMiles.TabIndex = 0;
            this.labelMiles.Text = "Miles Driven";
            // 
            // labelGas
            // 
            this.labelGas.AutoSize = true;
            this.labelGas.Location = new System.Drawing.Point(258, 122);
            this.labelGas.Name = "labelGas";
            this.labelGas.Size = new System.Drawing.Size(76, 13);
            this.labelGas.TabIndex = 1;
            this.labelGas.Text = "Gallons of Gas";
            // 
            // boxGas
            // 
            this.boxGas.Location = new System.Drawing.Point(361, 119);
            this.boxGas.Name = "boxGas";
            this.boxGas.Size = new System.Drawing.Size(100, 20);
            this.boxGas.TabIndex = 2;
            // 
            // boxMiles
            // 
            this.boxMiles.Location = new System.Drawing.Point(361, 82);
            this.boxMiles.Name = "boxMiles";
            this.boxMiles.Size = new System.Drawing.Size(100, 20);
            this.boxMiles.TabIndex = 3;
            // 
            // labelMPGOutput
            // 
            this.labelMPGOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMPGOutput.Location = new System.Drawing.Point(334, 159);
            this.labelMPGOutput.Name = "labelMPGOutput";
            this.labelMPGOutput.Size = new System.Drawing.Size(127, 23);
            this.labelMPGOutput.TabIndex = 4;
            // 
            // labelMPG
            // 
            this.labelMPG.AutoSize = true;
            this.labelMPG.Location = new System.Drawing.Point(258, 160);
            this.labelMPG.Name = "labelMPG";
            this.labelMPG.Size = new System.Drawing.Size(31, 13);
            this.labelMPG.TabIndex = 5;
            this.labelMPG.Text = "MPG";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(259, 207);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(386, 207);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelMPG);
            this.Controls.Add(this.labelMPGOutput);
            this.Controls.Add(this.boxMiles);
            this.Controls.Add(this.boxGas);
            this.Controls.Add(this.labelGas);
            this.Controls.Add(this.labelMiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMiles;
        private System.Windows.Forms.Label labelGas;
        private System.Windows.Forms.TextBox boxGas;
        private System.Windows.Forms.TextBox boxMiles;
        private System.Windows.Forms.Label labelMPGOutput;
        private System.Windows.Forms.Label labelMPG;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
    }
}

