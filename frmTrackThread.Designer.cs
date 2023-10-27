namespace ThreadPriority_Reyes
{
    partial class frmTrackThread
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
            this.lblThreadStart = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThreadStart
            // 
            this.lblThreadStart.AutoSize = true;
            this.lblThreadStart.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreadStart.Location = new System.Drawing.Point(72, 44);
            this.lblThreadStart.Name = "lblThreadStart";
            this.lblThreadStart.Size = new System.Drawing.Size(215, 32);
            this.lblThreadStart.TabIndex = 0;
            this.lblThreadStart.Text = "- Thread Starts -";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.btnRun.Location = new System.Drawing.Point(124, 94);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(123, 35);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // frmTrackThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 167);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblThreadStart);
            this.Name = "frmTrackThread";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTrackThread_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThreadStart;
        private System.Windows.Forms.Button btnRun;
    }
}

