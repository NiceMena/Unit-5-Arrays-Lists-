namespace ListsNiceM
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(283, 128);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 35);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(338, 66);
            this.txtMarks.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(164, 26);
            this.txtMarks.TabIndex = 1;
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 20;
            this.lstNumbers.Location = new System.Drawing.Point(208, 214);
            this.lstNumbers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(226, 224);
            this.lstNumbers.TabIndex = 2;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(48, 66);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(267, 20);
            this.lblEnter.TabIndex = 3;
            this.lblEnter.Text = "Enter a number between 0-100: \r\n";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(150, 538);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(57, 20);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "label2";
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(397, 502);
            this.btnAverage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(237, 35);
            this.btnAverage.TabIndex = 5;
            this.btnAverage.Text = "Calculate Average\r\n";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 629);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.btnEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnAverage;
    }
}

