namespace src
{
    partial class Home
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAlgorithm = new Guna.UI2.WinForms.Guna2Button();
            this.btnProcess = new Guna.UI2.WinForms.Guna2Button();
            this.btnThread = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.process_controls1 = new src.process.process_controls();
            this.thread_controls1 = new src.thread.thread_controls();
            this.scheduling_algorithm1 = new src.scheduling_algorithms.scheduling_algorithm();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnAlgorithm);
            this.guna2Panel1.Controls.Add(this.btnProcess);
            this.guna2Panel1.Controls.Add(this.btnThread);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 75);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1471, 66);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnAlgorithm
            // 
            this.btnAlgorithm.BackColor = System.Drawing.Color.Transparent;
            this.btnAlgorithm.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAlgorithm.CheckedState.CustomBorderColor = System.Drawing.Color.Firebrick;
            this.btnAlgorithm.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAlgorithm.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAlgorithm.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAlgorithm.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAlgorithm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlgorithm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlgorithm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlgorithm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlgorithm.FillColor = System.Drawing.Color.Transparent;
            this.btnAlgorithm.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlgorithm.ForeColor = System.Drawing.Color.Black;
            this.btnAlgorithm.HoverState.CustomBorderColor = System.Drawing.Color.Firebrick;
            this.btnAlgorithm.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAlgorithm.Location = new System.Drawing.Point(422, 3);
            this.btnAlgorithm.Name = "btnAlgorithm";
            this.btnAlgorithm.Size = new System.Drawing.Size(339, 60);
            this.btnAlgorithm.TabIndex = 4;
            this.btnAlgorithm.Text = "Các thuật toán điều độ";
            this.btnAlgorithm.Click += new System.EventHandler(this.btnAlgorithm_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.Transparent;
            this.btnProcess.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnProcess.CheckedState.CustomBorderColor = System.Drawing.Color.Firebrick;
            this.btnProcess.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProcess.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnProcess.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnProcess.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnProcess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProcess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProcess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProcess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProcess.FillColor = System.Drawing.Color.Transparent;
            this.btnProcess.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic);
            this.btnProcess.ForeColor = System.Drawing.Color.Black;
            this.btnProcess.HoverState.CustomBorderColor = System.Drawing.Color.Firebrick;
            this.btnProcess.HoverState.FillColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(219, 3);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(189, 60);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Tiến Trình";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnThread
            // 
            this.btnThread.BackColor = System.Drawing.Color.Transparent;
            this.btnThread.Checked = true;
            this.btnThread.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnThread.CheckedState.CustomBorderColor = System.Drawing.Color.Firebrick;
            this.btnThread.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThread.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnThread.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnThread.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnThread.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThread.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThread.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThread.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThread.FillColor = System.Drawing.Color.Transparent;
            this.btnThread.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic);
            this.btnThread.ForeColor = System.Drawing.Color.Black;
            this.btnThread.HoverState.CustomBorderColor = System.Drawing.Color.Firebrick;
            this.btnThread.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThread.Location = new System.Drawing.Point(3, 3);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(189, 60);
            this.btnThread.TabIndex = 2;
            this.btnThread.Text = "Luồng";
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.thread_controls1);
            this.guna2Panel2.Controls.Add(this.scheduling_algorithm1);
            this.guna2Panel2.Controls.Add(this.process_controls1);
            this.guna2Panel2.Location = new System.Drawing.Point(-8, 147);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1485, 585);
            this.guna2Panel2.TabIndex = 2;
            // 
            // process_controls1
            // 
            this.process_controls1.BackColor = System.Drawing.Color.White;
            this.process_controls1.Location = new System.Drawing.Point(0, 0);
            this.process_controls1.Name = "process_controls1";
            this.process_controls1.Size = new System.Drawing.Size(1485, 729);
            this.process_controls1.TabIndex = 2;
            // 
            // thread_controls1
            // 
            this.thread_controls1.BackColor = System.Drawing.Color.White;
            this.thread_controls1.Location = new System.Drawing.Point(-6, -3);
            this.thread_controls1.Name = "thread_controls1";
            this.thread_controls1.Size = new System.Drawing.Size(1482, 785);
            this.thread_controls1.TabIndex = 1;
            this.thread_controls1.Load += new System.EventHandler(this.thread_controls1_Load);
            // 
            // scheduling_algorithm1
            // 
            this.scheduling_algorithm1.BackColor = System.Drawing.Color.White;
            this.scheduling_algorithm1.Location = new System.Drawing.Point(0, 0);
            this.scheduling_algorithm1.Name = "scheduling_algorithm1";
            this.scheduling_algorithm1.Size = new System.Drawing.Size(1485, 729);
            this.scheduling_algorithm1.TabIndex = 0;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(11)))), ((int)(((byte)(54)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, -3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1477, 75);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(585, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(424, 41);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Chương 2: Tiến trình và luồng";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1474, 728);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnThread;
        private Guna.UI2.WinForms.Guna2Button btnAlgorithm;
        private Guna.UI2.WinForms.Guna2Button btnProcess;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private scheduling_algorithms.scheduling_algorithm scheduling_algorithm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private thread.thread_controls thread_controls1;
        private process.process_controls process_controls1;
    }
}

