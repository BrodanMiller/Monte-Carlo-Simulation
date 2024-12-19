namespace TestForDaTest
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
            this.calcpibtn = new System.Windows.Forms.Button();
            this.TotalNumPointslbl = new System.Windows.Forms.Label();
            this.NumPointsInCirclelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EstimatedPilbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcpibtn
            // 
            this.calcpibtn.Location = new System.Drawing.Point(46, 37);
            this.calcpibtn.Name = "calcpibtn";
            this.calcpibtn.Size = new System.Drawing.Size(171, 157);
            this.calcpibtn.TabIndex = 2;
            this.calcpibtn.Text = "calculate pi";
            this.calcpibtn.UseVisualStyleBackColor = true;
            this.calcpibtn.Click += new System.EventHandler(this.calcpibtn_Click);
            // 
            // TotalNumPointslbl
            // 
            this.TotalNumPointslbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalNumPointslbl.Location = new System.Drawing.Point(261, 47);
            this.TotalNumPointslbl.Name = "TotalNumPointslbl";
            this.TotalNumPointslbl.Size = new System.Drawing.Size(164, 23);
            this.TotalNumPointslbl.TabIndex = 3;
            // 
            // NumPointsInCirclelbl
            // 
            this.NumPointsInCirclelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumPointsInCirclelbl.Location = new System.Drawing.Point(261, 106);
            this.NumPointsInCirclelbl.Name = "NumPointsInCirclelbl";
            this.NumPointsInCirclelbl.Size = new System.Drawing.Size(164, 23);
            this.NumPointsInCirclelbl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "NumPointsInCircle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "TotalNumPoints";
            // 
            // EstimatedPilbl
            // 
            this.EstimatedPilbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EstimatedPilbl.Location = new System.Drawing.Point(261, 163);
            this.EstimatedPilbl.Name = "EstimatedPilbl";
            this.EstimatedPilbl.Size = new System.Drawing.Size(164, 23);
            this.EstimatedPilbl.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estimated Pi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 213);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EstimatedPilbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumPointsInCirclelbl);
            this.Controls.Add(this.TotalNumPointslbl);
            this.Controls.Add(this.calcpibtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calcpibtn;
        private System.Windows.Forms.Label TotalNumPointslbl;
        private System.Windows.Forms.Label NumPointsInCirclelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EstimatedPilbl;
        private System.Windows.Forms.Label label4;
    }
}

