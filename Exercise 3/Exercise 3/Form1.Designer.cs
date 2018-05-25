namespace Hello_World
{
    partial class dataProcessingForm
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
            this.calculateBox = new System.Windows.Forms.Button();
            this.label_years = new System.Windows.Forms.Label();
            this.label_results = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateBox
            // 
            this.calculateBox.Location = new System.Drawing.Point(97, 64);
            this.calculateBox.Name = "calculateBox";
            this.calculateBox.Size = new System.Drawing.Size(61, 39);
            this.calculateBox.TabIndex = 0;
            this.calculateBox.Text = "Calculate";
            this.calculateBox.UseVisualStyleBackColor = true;
            this.calculateBox.Click += new System.EventHandler(this.sayHi_Click);
            // 
            // label_years
            // 
            this.label_years.Location = new System.Drawing.Point(26, 15);
            this.label_years.Name = "label_years";
            this.label_years.Size = new System.Drawing.Size(35, 18);
            this.label_years.TabIndex = 1;
            this.label_years.Text = "Age";
            // 
            // label_results
            // 
            this.label_results.AutoSize = true;
            this.label_results.Location = new System.Drawing.Point(26, 41);
            this.label_results.Name = "label_results";
            this.label_results.Size = new System.Drawing.Size(51, 13);
            this.label_results.TabIndex = 2;
            this.label_results.Text = "Years left";
            this.label_results.Click += new System.EventHandler(this.label_results_Click);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(83, 12);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 3;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(83, 38);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 4;
            // 
            // dataProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 191);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label_results);
            this.Controls.Add(this.label_years);
            this.Controls.Add(this.calculateBox);
            this.Name = "dataProcessingForm";
            this.Text = "Time Determinant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBox;
        private System.Windows.Forms.Label label_years;
        private System.Windows.Forms.Label label_results;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox resultBox;
    }
}

