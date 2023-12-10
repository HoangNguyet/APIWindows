namespace src.scheduling_algorithms.user_controls
{
    partial class gant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gantColor = new Guna.UI2.WinForms.Guna2Panel();
            this.nameProcess = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.Label();
            this.timeEnd = new System.Windows.Forms.Label();
            this.gantColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gantColor
            // 
            this.gantColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gantColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.gantColor.Controls.Add(this.nameProcess);
            this.gantColor.Location = new System.Drawing.Point(0, 0);
            this.gantColor.Name = "gantColor";
            this.gantColor.Size = new System.Drawing.Size(70, 66);
            this.gantColor.TabIndex = 0;
            // 
            // nameProcess
            // 
            this.nameProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameProcess.AutoSize = true;
            this.nameProcess.BackColor = System.Drawing.Color.Transparent;
            this.nameProcess.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProcess.Location = new System.Drawing.Point(14, 18);
            this.nameProcess.Name = "nameProcess";
            this.nameProcess.Size = new System.Drawing.Size(47, 34);
            this.nameProcess.TabIndex = 3;
            this.nameProcess.Text = "P1";
            // 
            // timeStart
            // 
            this.timeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeStart.AutoSize = true;
            this.timeStart.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart.Location = new System.Drawing.Point(-6, 67);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(30, 34);
            this.timeStart.TabIndex = 1;
            this.timeStart.Text = "0";
            // 
            // timeEnd
            // 
            this.timeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeEnd.AutoSize = true;
            this.timeEnd.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd.Location = new System.Drawing.Point(34, 67);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(30, 34);
            this.timeEnd.TabIndex = 2;
            this.timeEnd.Text = "0";
            // 
            // gant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.gantColor);
            this.Name = "gant";
            this.Size = new System.Drawing.Size(70, 99);
            this.Load += new System.EventHandler(this.gant_Load);
            this.gantColor.ResumeLayout(false);
            this.gantColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gantColor;
        private System.Windows.Forms.Label timeStart;
        private System.Windows.Forms.Label timeEnd;
        private System.Windows.Forms.Label nameProcess;
    }
}
