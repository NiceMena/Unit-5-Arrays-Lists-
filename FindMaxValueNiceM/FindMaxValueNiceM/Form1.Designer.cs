namespace FindMaxValueNiceM
{
    partial class frmFindMaxValue
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.lstMaxValue = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(146, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxValue.Location = new System.Drawing.Point(77, 367);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(57, 20);
            this.lblMaxValue.TabIndex = 1;
            this.lblMaxValue.Text = "label1";
            // 
            // lstMaxValue
            // 
            this.lstMaxValue.BackColor = System.Drawing.Color.MediumPurple;
            this.lstMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMaxValue.FormattingEnabled = true;
            this.lstMaxValue.ItemHeight = 20;
            this.lstMaxValue.Location = new System.Drawing.Point(81, 85);
            this.lstMaxValue.Name = "lstMaxValue";
            this.lstMaxValue.Size = new System.Drawing.Size(224, 244);
            this.lstMaxValue.TabIndex = 2;
            // 
            // frmFindMaxValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(449, 462);
            this.Controls.Add(this.lstMaxValue);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.btnStart);
            this.Name = "frmFindMaxValue";
            this.Text = "FindMaxValue";
            this.Load += new System.EventHandler(this.frmFindMaxValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.ListBox lstMaxValue;
    }
}

