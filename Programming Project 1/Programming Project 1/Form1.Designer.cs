namespace Programming_Project_1
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
            this.pictureKoala = new System.Windows.Forms.PictureBox();
            this.pictureJelly = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelKoala = new System.Windows.Forms.Label();
            this.labelJelly = new System.Windows.Forms.Label();
            this.textKoala = new System.Windows.Forms.TextBox();
            this.textJelly = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelOutput2 = new System.Windows.Forms.Label();
            this.labelKJ = new System.Windows.Forms.Label();
            this.labelJK = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelWe = new System.Windows.Forms.Label();
            this.labelFancy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKoala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureJelly)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureKoala
            // 
            this.pictureKoala.Image = global::Programming_Project_1.Properties.Resources.Koala;
            this.pictureKoala.Location = new System.Drawing.Point(118, 73);
            this.pictureKoala.Name = "pictureKoala";
            this.pictureKoala.Size = new System.Drawing.Size(208, 126);
            this.pictureKoala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKoala.TabIndex = 1;
            this.pictureKoala.TabStop = false;
            this.pictureKoala.Click += new System.EventHandler(this.pictureKoala_Click);
            // 
            // pictureJelly
            // 
            this.pictureJelly.Image = global::Programming_Project_1.Properties.Resources.Jellyfish;
            this.pictureJelly.Location = new System.Drawing.Point(380, 73);
            this.pictureJelly.Name = "pictureJelly";
            this.pictureJelly.Size = new System.Drawing.Size(208, 126);
            this.pictureJelly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureJelly.TabIndex = 0;
            this.pictureJelly.TabStop = false;
            this.pictureJelly.Click += new System.EventHandler(this.pictureJelly_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHeader.Location = new System.Drawing.Point(219, 38);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(270, 15);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Ensure Koala to Jellyfish ratios are at a profitable margin";
            // 
            // labelKoala
            // 
            this.labelKoala.AutoSize = true;
            this.labelKoala.Location = new System.Drawing.Point(115, 202);
            this.labelKoala.Name = "labelKoala";
            this.labelKoala.Size = new System.Drawing.Size(86, 13);
            this.labelKoala.TabIndex = 3;
            this.labelKoala.Text = "Number of Koala";
            // 
            // labelJelly
            // 
            this.labelJelly.AutoSize = true;
            this.labelJelly.Location = new System.Drawing.Point(377, 202);
            this.labelJelly.Name = "labelJelly";
            this.labelJelly.Size = new System.Drawing.Size(95, 13);
            this.labelJelly.TabIndex = 4;
            this.labelJelly.Text = "Number of Jellyfish";
            // 
            // textKoala
            // 
            this.textKoala.Location = new System.Drawing.Point(226, 199);
            this.textKoala.Name = "textKoala";
            this.textKoala.Size = new System.Drawing.Size(100, 20);
            this.textKoala.TabIndex = 5;
            // 
            // textJelly
            // 
            this.textJelly.Location = new System.Drawing.Point(488, 199);
            this.textJelly.Name = "textJelly";
            this.textJelly.Size = new System.Drawing.Size(100, 20);
            this.textJelly.TabIndex = 6;
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(202, 222);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(305, 23);
            this.labelOutput.TabIndex = 7;
            // 
            // labelOutput2
            // 
            this.labelOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput2.Location = new System.Drawing.Point(202, 261);
            this.labelOutput2.Name = "labelOutput2";
            this.labelOutput2.Size = new System.Drawing.Size(305, 23);
            this.labelOutput2.TabIndex = 8;
            // 
            // labelKJ
            // 
            this.labelKJ.AutoSize = true;
            this.labelKJ.Location = new System.Drawing.Point(121, 223);
            this.labelKJ.Name = "labelKJ";
            this.labelKJ.Size = new System.Drawing.Size(75, 13);
            this.labelKJ.TabIndex = 9;
            this.labelKJ.Text = "Koala per Jelly";
            // 
            // labelJK
            // 
            this.labelJK.AutoSize = true;
            this.labelJK.Location = new System.Drawing.Point(121, 262);
            this.labelJK.Name = "labelJK";
            this.labelJK.Size = new System.Drawing.Size(75, 13);
            this.labelJK.TabIndex = 10;
            this.labelJK.Text = "Jelly per Koala";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(118, 310);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(316, 310);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(513, 310);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelWe
            // 
            this.labelWe.AutoSize = true;
            this.labelWe.Location = new System.Drawing.Point(77, 128);
            this.labelWe.Name = "labelWe";
            this.labelWe.Size = new System.Drawing.Size(0, 13);
            this.labelWe.TabIndex = 14;
            // 
            // labelFancy
            // 
            this.labelFancy.AutoSize = true;
            this.labelFancy.Location = new System.Drawing.Point(594, 128);
            this.labelFancy.Name = "labelFancy";
            this.labelFancy.Size = new System.Drawing.Size(0, 13);
            this.labelFancy.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "This work is my own for CST 117. Charles Henderson 5/27/2018";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFancy);
            this.Controls.Add(this.labelWe);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelJK);
            this.Controls.Add(this.labelKJ);
            this.Controls.Add(this.labelOutput2);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textJelly);
            this.Controls.Add(this.textKoala);
            this.Controls.Add(this.labelJelly);
            this.Controls.Add(this.labelKoala);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.pictureKoala);
            this.Controls.Add(this.pictureJelly);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureKoala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureJelly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureJelly;
        private System.Windows.Forms.PictureBox pictureKoala;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelKoala;
        private System.Windows.Forms.Label labelJelly;
        private System.Windows.Forms.TextBox textKoala;
        private System.Windows.Forms.TextBox textJelly;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelOutput2;
        private System.Windows.Forms.Label labelKJ;
        private System.Windows.Forms.Label labelJK;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelWe;
        private System.Windows.Forms.Label labelFancy;
        private System.Windows.Forms.Label label1;
    }
}

