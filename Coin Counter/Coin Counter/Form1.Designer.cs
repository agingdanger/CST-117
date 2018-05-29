namespace Coin_Counter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNickel = new System.Windows.Forms.Button();
            this.buttonDime = new System.Windows.Forms.Button();
            this.buttonQuarter = new System.Windows.Forms.Button();
            this.buttonHalfDollar = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNickel
            // 
            this.buttonNickel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNickel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNickel.Location = new System.Drawing.Point(247, 133);
            this.buttonNickel.Name = "buttonNickel";
            this.buttonNickel.Size = new System.Drawing.Size(104, 74);
            this.buttonNickel.TabIndex = 1;
            this.buttonNickel.Text = "Nickel";
            this.buttonNickel.UseVisualStyleBackColor = true;
            this.buttonNickel.Click += new System.EventHandler(this.buttonNickel_Click);
            // 
            // buttonDime
            // 
            this.buttonDime.Location = new System.Drawing.Point(352, 133);
            this.buttonDime.Name = "buttonDime";
            this.buttonDime.Size = new System.Drawing.Size(102, 74);
            this.buttonDime.TabIndex = 2;
            this.buttonDime.Text = "Dime";
            this.buttonDime.UseVisualStyleBackColor = true;
            this.buttonDime.Click += new System.EventHandler(this.buttonDime_Click);
            // 
            // buttonQuarter
            // 
            this.buttonQuarter.Location = new System.Drawing.Point(247, 211);
            this.buttonQuarter.Name = "buttonQuarter";
            this.buttonQuarter.Size = new System.Drawing.Size(104, 74);
            this.buttonQuarter.TabIndex = 3;
            this.buttonQuarter.Text = "Quarter";
            this.buttonQuarter.UseVisualStyleBackColor = true;
            this.buttonQuarter.Click += new System.EventHandler(this.buttonQuarter_Click);
            // 
            // buttonHalfDollar
            // 
            this.buttonHalfDollar.Location = new System.Drawing.Point(352, 211);
            this.buttonHalfDollar.Name = "buttonHalfDollar";
            this.buttonHalfDollar.Size = new System.Drawing.Size(102, 74);
            this.buttonHalfDollar.TabIndex = 4;
            this.buttonHalfDollar.Text = "Half Dollar";
            this.buttonHalfDollar.UseVisualStyleBackColor = true;
            this.buttonHalfDollar.Click += new System.EventHandler(this.buttonHalfDollar_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(309, 91);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(87, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Count your Coins";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(492, 211);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total";
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(460, 232);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(100, 23);
            this.labelOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonHalfDollar);
            this.Controls.Add(this.buttonQuarter);
            this.Controls.Add(this.buttonDime);
            this.Controls.Add(this.buttonNickel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNickel;
        private System.Windows.Forms.Button buttonDime;
        private System.Windows.Forms.Button buttonQuarter;
        private System.Windows.Forms.Button buttonHalfDollar;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelOutput;
    }
}

