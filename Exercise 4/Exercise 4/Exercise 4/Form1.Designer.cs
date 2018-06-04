namespace Exercise_4
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.textSeconds = new System.Windows.Forms.TextBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelOutputMinutes = new System.Windows.Forms.Label();
            this.labelOutputHours = new System.Windows.Forms.Label();
            this.labelOutputDays = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(305, 104);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(180, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Enter the number of seconds passed";
            // 
            // textSeconds
            // 
            this.textSeconds.Location = new System.Drawing.Point(341, 132);
            this.textSeconds.Name = "textSeconds";
            this.textSeconds.Size = new System.Drawing.Size(100, 20);
            this.textSeconds.TabIndex = 1;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(264, 174);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(44, 13);
            this.labelMinutes.TabIndex = 2;
            this.labelMinutes.Text = "Minutes";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(264, 206);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(35, 13);
            this.labelHours.TabIndex = 3;
            this.labelHours.Text = "Hours";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(264, 236);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(31, 13);
            this.labelDays.TabIndex = 4;
            this.labelDays.Text = "Days";
            // 
            // labelOutputMinutes
            // 
            this.labelOutputMinutes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutputMinutes.Location = new System.Drawing.Point(409, 174);
            this.labelOutputMinutes.Name = "labelOutputMinutes";
            this.labelOutputMinutes.Size = new System.Drawing.Size(100, 23);
            this.labelOutputMinutes.TabIndex = 5;
            // 
            // labelOutputHours
            // 
            this.labelOutputHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutputHours.Location = new System.Drawing.Point(409, 206);
            this.labelOutputHours.Name = "labelOutputHours";
            this.labelOutputHours.Size = new System.Drawing.Size(100, 23);
            this.labelOutputHours.TabIndex = 6;
            // 
            // labelOutputDays
            // 
            this.labelOutputDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutputDays.Location = new System.Drawing.Point(409, 236);
            this.labelOutputDays.Name = "labelOutputDays";
            this.labelOutputDays.Size = new System.Drawing.Size(100, 23);
            this.labelOutputDays.TabIndex = 7;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(267, 293);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 8;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(434, 293);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "This work is my own for CST 117\r\nCharles Henderson\r\n6/3/2018";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelOutputDays);
            this.Controls.Add(this.labelOutputHours);
            this.Controls.Add(this.labelOutputMinutes);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.textSeconds);
            this.Controls.Add(this.labelHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textSeconds;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelOutputMinutes;
        private System.Windows.Forms.Label labelOutputHours;
        private System.Windows.Forms.Label labelOutputDays;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
    }
}

